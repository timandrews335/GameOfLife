'The Universe class holds the actual logic of the simulation.  Two-dimensional arrays are utilized to track the status (alive or dead)
', and color of each cell.
Public Class Universe
    Private mCurrentState As Boolean(,)     '2-D array to track the status (alive or dead) of each cell. Current state reprsents the beginning of a generation.
    Private mFutureState As Boolean(,)      'Future state reprsents the beginning of a generation.
    Private mCurrentType As Boolean(,)
    Private mFutureType As Boolean(,)
    Private mStopped As Boolean = False

    'Notify the consumer that a generation has elapsed.  The consumer would be interested in knowing the new status of each cell.
    Friend Event Tick(CurrentState As Boolean(,), CurrentType As Boolean(,), LivingCells As Double)

    Private mLivingCells As Double = 0

    'A list to store the number of living cells at each generation
    Private mLivingCellList As New ArrayList

    'A number to say how many generations of exactly the same population indicate a stable population
    Private mGenerationStabilityIndicator As Integer = 10

    'Lists to hold the rules for neighbors counts to be born and to survive
    Private mBirthNeighbors As New List(Of Integer)
    Private mSurviveNeighbors As New List(Of Integer)

    'Variables to help in the looping
    Private xMin As Integer = 1
    Private yMin As Integer = 1
    Private xMax As Integer = 0
    Private yMax As Integer = 0

    Private LivingNeighbors As Integer = 0
    Private TypedNeighbors As Integer = 0

    Private CurrentPopulation As Integer = 0
    Private PriorPopulation As Integer = 0
    Private Stable As Boolean = True

    Friend Sub New(Width As Integer, Height As Integer)
        ReDim mCurrentState(Width, Height)
        ReDim mFutureState(Width, Height)
        ReDim mCurrentType(Width, Height)
        ReDim mFutureType(Width, Height)

        'Default the rules to Conway's Game of Life
        Me.mBirthNeighbors.Add(3)
        mSurviveNeighbors.AddRange({2, 3})
    End Sub
    Friend Sub StopSimulation()
        Me.mStopped = True
        Me.mLivingCellList.Clear()
    End Sub

    'The Simulate routine calls itself upon completion, until the mStopped variable is set to true
    Friend Sub Simulate(Optional CurrentState As Boolean(,) = Nothing, Optional CurrentType As Boolean(,) = Nothing)


        Me.mStopped = False

        'If the user is seeding the simulation, we need to set our mCurrentState and mCurrentType
        If Not CurrentState Is Nothing Then
            CopyArray(CurrentState, Me.mCurrentState)
        End If
        If Not CurrentType Is Nothing Then
            CopyArray(CurrentType, Me.mCurrentType)
        End If

        'If our population has been stable for at least N generations, then stop the simulation
        CurrentPopulation = 0
        PriorPopulation = 0
        Stable = True

        If (Me.mGenerationStabilityIndicator = 0) Then
            Stable = False

        ElseIf Me.mLivingCellList.Count > Me.mGenerationStabilityIndicator Then
            For i As Integer = Me.mLivingCellList.Count - 1 To Me.mLivingCellList.Count - Me.mGenerationStabilityIndicator Step -1
                CurrentPopulation = Me.mLivingCellList(i)
                If (CurrentPopulation <> PriorPopulation And PriorPopulation <> 0) Then
                    Stable = False
                End If
                PriorPopulation = CurrentPopulation
            Next
        Else
            Stable = False
        End If
        If Stable Then
            Me.mStopped = True
            Exit Sub
        End If


        'Let the calling application render the output of the CurrentState and CurrentType
        RaiseEvent Tick(Me.mCurrentState, Me.mCurrentType, Me.mLivingCells)
        Me.mLivingCellList.Add(Me.mLivingCells)


        xMin = 1
        yMin = 1
        xMax = Me.mCurrentState.GetLength(0) - 2
        yMax = Me.mCurrentState.GetLength(1) - 2

        mLivingCells = 0

        'Let's see if the cells live or die
        For x As Integer = 0 To xMax
            For y As Integer = 0 To yMax

                'Count the number of neighbors that are alive
                LivingNeighbors = 0
                TypedNeighbors = 0

                If x <= xMax AndAlso Me.mCurrentState(x + 1, y) Then
                    LivingNeighbors += 1 'East
                    If Me.mCurrentType(x + 1, y) Then TypedNeighbors += 1
                End If

                If x >= xMin AndAlso Me.mCurrentState(x - 1, y) Then
                    LivingNeighbors += 1 'West
                    If Me.mCurrentType(x - 1, y) Then TypedNeighbors += 1
                End If

                If y >= yMin AndAlso Me.mCurrentState(x, y - 1) Then
                    LivingNeighbors += 1 'North
                    If Me.mCurrentType(x, y - 1) Then TypedNeighbors += 1
                End If

                If y <= yMax AndAlso Me.mCurrentState(x, y + 1) Then
                    LivingNeighbors += 1 'South
                    If Me.mCurrentType(x, y + 1) Then TypedNeighbors += 1
                End If

                If (x <= xMax And y >= yMin) AndAlso Me.mCurrentState(x + 1, y - 1) Then
                    LivingNeighbors += 1 'Northeast
                    If Me.mCurrentType(x + 1, y - 1) Then TypedNeighbors += 1
                End If

                If (x <= xMax And y <= yMax) AndAlso Me.mCurrentState(x + 1, y + 1) Then
                    LivingNeighbors += 1 'Southeast
                    If Me.mCurrentType(x + 1, y + 1) Then TypedNeighbors += 1
                End If

                If (x >= xMin And y >= yMin) AndAlso Me.mCurrentState(x - 1, y - 1) Then
                    LivingNeighbors += 1 'Northwest
                    If Me.mCurrentType(x - 1, y - 1) Then TypedNeighbors += 1
                End If

                If (x >= xMin And y <= yMax) AndAlso Me.mCurrentState(x - 1, y + 1) Then
                    LivingNeighbors += 1 'Southwest
                    If Me.mCurrentType(x - 1, y + 1) Then TypedNeighbors += 1
                End If


                'Find out of the cell will live or die
                If Me.mCurrentState(x, y) Then  'Current cell is ALIVE
                    ''Me.mFutureState(x, y) = (LivingNeighbors = 2 Or LivingNeighbors = 3)
                    ''Me.mFutureState(x, y) = (LivingNeighbors = 2 Or LivingNeighbors = 1 Or LivingNeighbors = 5)
                    ''Me.mFutureState(x, y) = (LivingNeighbors = 2 Or LivingNeighbors = 3)

                    Me.mFutureState(x, y) = False
                    For Each i As Integer In Me.mSurviveNeighbors
                        If i = LivingNeighbors Then
                            Me.mFutureState(x, y) = True
                            Exit For
                        End If
                    Next

                    If Me.mFutureState(x, y) Then mLivingCells += 1
                Else                            'Current cell is DEAD
                    ''Me.mFutureState(x, y) = (LivingNeighbors = 3)
                    ''Me.mFutureState(x, y) = (LivingNeighbors = 3 Or LivingNeighbors = 6)

                    Me.mFutureState(x, y) = False
                    For Each i As Integer In Me.mBirthNeighbors
                        If i = LivingNeighbors Then
                            Me.mFutureState(x, y) = True
                            Exit For
                        End If
                    Next

                    If Me.mFutureState(x, y) Then mLivingCells += 1
                    'Decide what Type (Color) the newborn will be.  
                    Me.mFutureType(x, y) = (TypedNeighbors >= 2)

                End If
                Application.DoEvents()
            Next
            Application.DoEvents()
        Next

        'Repeat the simulation
        Array.Copy(Me.mFutureState, Me.mCurrentState, Me.mCurrentState.Length)
        Array.Copy(Me.mFutureType, Me.mCurrentType, Me.mCurrentType.Length)

        If Not Me.mStopped Then Simulate()

    End Sub

    Private Sub DoWork(Optional CurrentState As Boolean(,) = Nothing, Optional CurrentType As Boolean(,) = Nothing)

    End Sub

    Private Sub CopyArray(ByRef Source(,) As Boolean, ByRef Target(,) As Boolean)
        Dim x As Integer
        x = Source.GetLength(0) - 1
        If Target.GetLength(0) - 1 < x Then x = Target.GetLength(0) - 1

        Dim y As Integer
        y = Source.GetLength(1) - 1
        If Target.GetLength(1) - 1 < y Then y = Target.GetLength(1) - 1

        For i As Integer = 0 To x
            For j As Integer = 0 To y
                Target(i, j) = Source(i, j)
            Next
        Next

    End Sub

    Friend ReadOnly Property Width
        Get
            Return Me.mCurrentState.GetLength(0) - 1
        End Get
    End Property

    Friend ReadOnly Property Height
        Get
            Return Me.mCurrentState.GetLength(1) - 1
        End Get
    End Property

    Friend WriteOnly Property BirthNeighborCount As String
        Set(value As String)
            Me.mBirthNeighbors.Clear()
            For Each c As Char In value.ToCharArray
                If Asc(c.ToString) >= 49 And Asc(c.ToString) <= 56 Then
                    Me.mBirthNeighbors.Add(Integer.Parse(c.ToString))
                End If
            Next
        End Set
    End Property
    Friend WriteOnly Property SurviveNeighborCount As String
        Set(value As String)
            Me.mSurviveNeighbors.Clear()
            For Each c As Char In value.ToCharArray
                If Asc(c.ToString) >= 49 And Asc(c.ToString) <= 56 Then
                    Me.mSurviveNeighbors.Add(Integer.Parse(c.ToString))
                End If
            Next
        End Set
    End Property

    Friend ReadOnly Property LivingCellList
        Get
            Return Me.mLivingCellList
        End Get
    End Property
    Friend Property GenerationStabilityIndicator As Integer
        Get
            Return Me.mGenerationStabilityIndicator
        End Get
        Set(value As Integer)
            Me.mGenerationStabilityIndicator = value
        End Set
    End Property

End Class
