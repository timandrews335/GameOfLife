Public Class Form1
    Private WithEvents mUniverse As New Universe(120, 120)
    Private WithEvents mGrid As New Grid(Color.White, Color.LightSteelBlue, Color.Blue, Color.Red)
    Private mInitialSeed(,) As Boolean
    Private mInitialType(,) As Boolean
    Dim r As New Random

    Private mGenerations As Double = 0
    Private mCurrentCoordinates As Point = New Point(0, 0)
    Private mLivingCells As Double = 0



#Region "Form Loading and Unloading"
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Load in the colors that the user chose last time.  If this is the first run, then pick some defaults
        If Not My.Settings.GridBackColor.Equals(My.Settings.GridForeColor) Then
            Me.lbGridBackground.BackColor = My.Settings.GridBackColor
            Me.lbGridLines.BackColor = My.Settings.GridForeColor
            Me.lbColor1.BackColor = My.Settings.CellColor1
            Me.lbColor2.BackColor = My.Settings.CellColor2
        End If


        'Setup
        Me.mGrid.BackColor = Color.Transparent
        Me.mGrid.Dock = DockStyle.Fill
        Me.mGrid.Location = New Point(0, 0)
        Me.GroupBox1.Controls.Add(Me.mGrid)
        Me.mGrid.TabIndex = 100
        Me.mGrid.GridBackColor = Me.lbGridBackground.BackColor
        Me.mGrid.GridColor = Me.lbGridLines.BackColor
        Me.mGrid.FalseType = Me.lbColor1.BackColor
        Me.mGrid.TrueType = Me.lbColor2.BackColor

        'We start the Universe, because we want to randomly seed some cells as colored, just for visual purposes
        StartUniverse()

    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.mUniverse.StopSimulation()

        'Save off our color settings
        My.Settings.GridBackColor = Me.lbGridBackground.BackColor
        My.Settings.GridForeColor = Me.lbGridLines.BackColor
        My.Settings.CellColor1 = Me.lbColor1.BackColor
        My.Settings.CellColor2 = Me.lbColor2.BackColor
    End Sub
#End Region


    'Starts or sets up a Universe, based on user chose settings
    Private Sub StartUniverse()
        Dim InitialSeed(nudCellAxisLength.Value, nudCellAxisLength.Value) As Boolean
        Dim InitialType(nudCellAxisLength.Value, nudCellAxisLength.Value) As Boolean
        For i As Integer = 0 To nudCellAxisLength.Value - 1
            For j As Integer = 0 To nudCellAxisLength.Value - 1
                'We are randomly making the cells dead or alive, based on the pct. chance as specified by users
                InitialSeed(i, j) = (r.Next(1, (100 / nudRandomPct.Value) + 1) = 1)
                'We are randomly coloring a cell
                InitialType(i, j) = (r.Next(1, 3) = 1)
            Next
        Next


        'Pulsar
        'InitialSeed(5, 1) = True
        'InitialSeed(11, 1) = True

        'InitialSeed(5, 2) = True
        'InitialSeed(11, 2) = True

        'InitialSeed(5, 3) = True
        'InitialSeed(6, 3) = True

        'InitialSeed(10, 3) = True
        'InitialSeed(11, 3) = True


        'InitialSeed(1, 5) = True
        'InitialSeed(2, 5) = True
        'InitialSeed(3, 5) = True

        'InitialSeed(6, 5) = True
        'InitialSeed(7, 5) = True

        'InitialSeed(9, 5) = True
        'InitialSeed(10, 5) = True

        'InitialSeed(13, 5) = True
        'InitialSeed(14, 5) = True
        'InitialSeed(15, 5) = True

        'InitialSeed(3, 6) = True
        'InitialSeed(5, 6) = True
        'InitialSeed(7, 6) = True
        'InitialSeed(9, 6) = True
        'InitialSeed(11, 6) = True
        'InitialSeed(13, 6) = True

        'InitialSeed(5, 7) = True
        'InitialSeed(6, 7) = True
        'InitialSeed(10, 7) = True
        'InitialSeed(11, 7) = True

        'InitialSeed(5, 9) = True
        'InitialSeed(6, 9) = True
        'InitialSeed(10, 9) = True
        'InitialSeed(11, 9) = True

        'InitialSeed(3, 10) = True
        'InitialSeed(5, 10) = True
        'InitialSeed(7, 10) = True
        'InitialSeed(9, 10) = True
        'InitialSeed(11, 10) = True
        'InitialSeed(13, 10) = True


        'InitialSeed(1, 11) = True
        'InitialSeed(2, 11) = True
        'InitialSeed(3, 11) = True
        'InitialSeed(6, 11) = True
        'InitialSeed(7, 11) = True
        'InitialSeed(9, 11) = True
        'InitialSeed(10, 11) = True
        'InitialSeed(13, 11) = True
        'InitialSeed(14, 11) = True
        'InitialSeed(15, 11) = True


        'InitialSeed(5, 13) = True
        'InitialSeed(6, 13) = True
        'InitialSeed(10, 13) = True
        'InitialSeed(11, 13) = True

        'InitialSeed(5, 14) = True
        'InitialSeed(11, 14) = True

        'InitialSeed(5, 15) = True
        'InitialSeed(11, 15) = True

        Me.mInitialSeed = InitialSeed
        Me.mInitialType = InitialType
        mUniverse = New Universe(nudCellAxisLength.Value, nudCellAxisLength.Value)
        Me.mGrid.RefreshBoard(InitialSeed, InitialType) 'InitialSeed maps to alive or dead, and InitialType maps to the color of the cell
    End Sub

    'The Universe object ticks.
    Private Sub mUniverse_Tick(CurrentState(,) As Boolean, CurrentType(,) As Boolean, LivingCells As Double) Handles mUniverse.Tick
        Me.mGrid.RefreshBoard(CurrentState, CurrentType)
        Me.mGenerations += 1
        Me.mLivingCells = LivingCells
        Call UpdateStatus()

        'The speed on the form is expressed between 0 and 10.  At its lowest speed, we have one generation per second
        If (10 - Me.trkSpeed.Value) * 100 > 0 Then Threading.Thread.Sleep((10 - Me.trkSpeed.Value) * 100)
    End Sub

    Private Sub UpdateStatus()
        Try
            Me.lbCounter.Text = Format(Me.mGenerations, "###,###") & " generations.  " & Format(Me.mLivingCells, "###,###") & " living cells.  (" & Me.mCurrentCoordinates.X.ToString & ", " & Me.mCurrentCoordinates.Y.ToString & ")."
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnStart_Click(sender As System.Object, e As System.EventArgs) Handles btnStart.Click
        Me.btnStart.Enabled = False
        Me.btnStop.Enabled = True
        Me.mGenerations = 0
        StartUniverse()
        Me.mUniverse.Simulate(Me.mInitialSeed, Me.mInitialType)
    End Sub


    Private Sub btnStop_Click(sender As System.Object, e As System.EventArgs) Handles btnStop.Click
        Me.mUniverse.StopSimulation()
        Me.btnStart.Enabled = True
        Me.btnResume.Enabled = True
    End Sub

    Private Sub lbGridBackground_Click(sender As System.Object, e As System.EventArgs) Handles lbGridBackground.Click
        Me.cd1.Color = Me.lbGridBackground.BackColor
        Me.cd1.ShowDialog()
        Me.lbGridBackground.BackColor = Me.cd1.Color
        Me.mGrid.GridBackColor = Me.lbGridBackground.BackColor
    End Sub

    Private Sub lbGridLines_Click(sender As System.Object, e As System.EventArgs) Handles lbGridLines.Click
        Me.cd1.Color = Me.lbGridLines.BackColor
        Me.cd1.ShowDialog()
        Me.lbGridLines.BackColor = Me.cd1.Color
        Me.mGrid.GridColor = Me.lbGridLines.BackColor
    End Sub

    Private Sub lbColor1_Click(sender As System.Object, e As System.EventArgs) Handles lbColor1.Click
        Me.cd1.Color = Me.lbColor1.BackColor
        Me.cd1.ShowDialog()
        Me.lbColor1.BackColor = Me.cd1.Color
        Me.mGrid.FalseType = Me.lbColor1.BackColor
    End Sub

    Private Sub lbColor2_Click(sender As System.Object, e As System.EventArgs) Handles lbColor2.Click
        Me.cd1.Color = Me.lbColor2.BackColor
        Me.cd1.ShowDialog()
        Me.lbColor2.BackColor = Me.cd1.Color
        Me.mGrid.TrueType = Me.lbColor2.BackColor
    End Sub

    Private Sub btnResume_Click(sender As System.Object, e As System.EventArgs) Handles btnResume.Click
        Me.btnResume.Enabled = False
        Me.btnStop.Enabled = True
        Me.mUniverse.Simulate()
    End Sub


    Private Sub trkCellSize_Scroll(sender As System.Object, e As System.EventArgs) Handles trkCellSize.Scroll
        Me.mGrid.CellSize = Me.trkCellSize.Value
    End Sub

    Private Sub ScrollBar_Scroll(sender As System.Object, e As System.Windows.Forms.ScrollEventArgs) Handles VScrollBar1.Scroll, HScrollBar1.Scroll
        Dim x As Integer
        Dim y As Integer
        If Me.HScrollBar1.Value = 0 Then
            x = 0
        Else
            x = Me.mUniverse.Width * (Me.HScrollBar1.Value / 100.0)
        End If
        If Me.VScrollBar1.Value = 0 Then
            y = 0
        Else
            y = Me.mUniverse.Height * (Me.VScrollBar1.Value / 100.0)
        End If

        Me.mCurrentCoordinates = New Point(x, y)
        Me.mGrid.CurrentCoordinates = Me.mCurrentCoordinates
    End Sub


End Class
