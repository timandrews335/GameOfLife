﻿'The Grid class controls the visual output of the Game of Life.  It draws the background, gridlines and cells if the cells are alive.
'If a cell is alive, it draws the color based on the mColorBoard array.  This is a boolean array since we are allowed to have two
'different colors for live cells and just one color for dead cells.

'The RefreshBoard routine is important as it is called from the UI when the collection of cells have changed generation.

Public Class Grid
    Inherits Panel

    'This main image represents the grid
    Public mImage As Bitmap

    'Fill up the background, in case the grid does not take up the entire screen
    Private mBackImage As Bitmap


    'Grid Colors
    Private mBackColor As Color
    Private mGridColor As Color
    Private mFalseType As Color
    Private mTrueType As Color

    'Array for live/dead color1/color2 on the grid
    Private mGridBoard As Boolean(,)
    Private mColorBoard As Boolean(,)

    'Pixel size of each cell
    Private mCellSize As Integer = 10

    'Current coordinates to set at the 0,0 position of the grid image.
    Private mCurrentCoordinates As Point = New Point(0, 0)





    Sub New(BackColor As Color, GridColor As Color, FalseType As Color, TrueType As Color)
        Me.DoubleBuffered = True

        Me.mBackColor = BackColor
        Me.mGridColor = GridColor
        Me.mFalseType = FalseType
        Me.mTrueType = TrueType

        Me.mBackImage = New Bitmap(Me.Width, Me.Height)


    End Sub
    Protected Overrides Sub OnPaintBackground(e As System.Windows.Forms.PaintEventArgs)
        'MyBase.OnPaintBackground(e)
        Dim g As Graphics = Graphics.FromImage(Me.mBackImage)
        g.Clear(Me.Parent.BackColor)
        g = Graphics.FromImage(Me.mImage)
        g.Clear(Me.mBackColor)

        Dim b As Brush
        Dim TrueBrush As Brush = New SolidBrush(Me.mTrueType)
        Dim FalseBrush As Brush = New SolidBrush(Me.mFalseType)

        Dim p As Pen
        p = New Pen(Me.mGridColor, 1)

        If Not Me.mGridBoard Is Nothing Then


            'How many cells can the image display?  wRatio and hRatio
            Dim wRatio As Double = Me.mImage.Width / Me.mCellSize
            Dim hRatio As Double = Me.mImage.Width / Me.mCellSize

            'How many cells are there in the grid array, including the offset?
            Dim wCellsInGrid As Integer = Me.mGridBoard.GetLength(0) - 1 - Me.mCurrentCoordinates.X
            Dim hCellsInGrid As Integer = Me.mGridBoard.GetLength(0) - 1 - Me.mCurrentCoordinates.Y

            Dim AdjustedWidth As Double = wRatio
            If wCellsInGrid < wRatio Then AdjustedWidth = wCellsInGrid

            Dim AdjustedHeight As Double = hRatio
            If hCellsInGrid < hRatio Then AdjustedHeight = hCellsInGrid



            'How many cells can we go wide?
            For w As Integer = 0 To AdjustedWidth

                For h As Integer = 0 To AdjustedHeight

                    If Me.mGridBoard(w + Me.mCurrentCoordinates.X, h + Me.mCurrentCoordinates.Y) Then 'It is alive
                        If Me.mColorBoard(w + Me.mCurrentCoordinates.X, h + Me.mCurrentCoordinates.Y) Then
                            b = TrueBrush
                        Else
                            b = FalseBrush
                        End If
                        'Draw the cell

                        g.FillRectangle(b, w * Me.mCellSize, h * Me.mCellSize, Me.mCellSize, Me.mCellSize)
                    End If


                    'Draw a grid-line
                    g.DrawRectangle(p, w * Me.mCellSize, h * Me.mCellSize, Me.mCellSize, Me.mCellSize)
                Next
            Next


        End If
        e.Graphics.DrawImage(Me.mBackImage, 0, 0)
        e.Graphics.DrawImage(Me.mImage, 0, 0)


    End Sub

    'Called from user interface class
    Friend Sub RefreshBoard(GridBoard(,) As Boolean, ColorBoard(,) As Boolean)
        Me.mGridBoard = GridBoard
        Me.mColorBoard = ColorBoard
        Me.Invalidate()
    End Sub



    Private Sub Grid_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
        If Not Me.ClientSize.Width = 0 And Not Me.ClientSize.Height = 0 Then
            Me.mImage = New Bitmap(Me.ClientSize.Width, Me.ClientSize.Height)
            Me.mBackImage = New Bitmap(Me.ClientSize.Width, Me.ClientSize.Height)
            Me.Invalidate()
        End If
    End Sub

    Friend Property GridBackColor As Color
        Get
            Return Me.mBackColor
        End Get
        Set(value As Color)
            Me.mBackColor = value
            Me.Invalidate()
        End Set
    End Property

    Friend Property GridColor As Color
        Get
            Return Me.mGridColor
        End Get
        Set(value As Color)
            Me.mGridColor = value
            Me.Invalidate()
        End Set
    End Property
    Friend Property FalseType As Color
        Get
            Return Me.mFalseType
        End Get
        Set(value As Color)
            Me.mFalseType = value
            Me.Invalidate()
        End Set
    End Property
    Friend Property TrueType As Color
        Get
            Return Me.mTrueType
        End Get
        Set(value As Color)
            Me.mTrueType = value
            Me.Invalidate()
        End Set
    End Property
    Friend Property CellSize As Integer
        Get
            Return Me.mCellSize
        End Get
        Set(value As Integer)
            Me.mCellSize = value
            Invalidate()
        End Set
    End Property

    Friend Property CurrentCoordinates
        Get
            Return Me.mCurrentCoordinates
        End Get
        Set(value)
            Me.mCurrentCoordinates = value
            Me.Invalidate()
        End Set
    End Property
End Class
