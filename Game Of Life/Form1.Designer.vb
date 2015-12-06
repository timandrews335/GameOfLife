<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtSurvive = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtBirth = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.nudStableCount = New System.Windows.Forms.NumericUpDown()
        Me.btnRecap = New System.Windows.Forms.Button()
        Me.rbCircularCells = New System.Windows.Forms.RadioButton()
        Me.rbSquareCells = New System.Windows.Forms.RadioButton()
        Me.lblTim = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.nudCellAxisLength = New System.Windows.Forms.NumericUpDown()
        Me.trkCellSize = New System.Windows.Forms.TrackBar()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbCounter = New System.Windows.Forms.Label()
        Me.trkSpeed = New System.Windows.Forms.TrackBar()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnResume = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbColor2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbColor1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbGridLines = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbGridBackground = New System.Windows.Forms.Label()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nudRandomPct = New System.Windows.Forms.NumericUpDown()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.cd1 = New System.Windows.Forms.ColorDialog()
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1.SuspendLayout()
        CType(Me.nudStableCount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCellAxisLength, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trkCellSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trkSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudRandomPct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.txtSurvive)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.txtBirth)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.nudStableCount)
        Me.Panel1.Controls.Add(Me.btnRecap)
        Me.Panel1.Controls.Add(Me.rbCircularCells)
        Me.Panel1.Controls.Add(Me.rbSquareCells)
        Me.Panel1.Controls.Add(Me.lblTim)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.nudCellAxisLength)
        Me.Panel1.Controls.Add(Me.trkCellSize)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.lbCounter)
        Me.Panel1.Controls.Add(Me.trkSpeed)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.btnResume)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.lbColor2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.lbColor1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.lbGridLines)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lbGridBackground)
        Me.Panel1.Controls.Add(Me.btnStop)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.nudRandomPct)
        Me.Panel1.Controls.Add(Me.btnStart)
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(763, 131)
        Me.Panel1.TabIndex = 0
        '
        'txtSurvive
        '
        Me.txtSurvive.Location = New System.Drawing.Point(599, 68)
        Me.txtSurvive.Name = "txtSurvive"
        Me.txtSurvive.Size = New System.Drawing.Size(55, 20)
        Me.txtSurvive.TabIndex = 24
        Me.txtSurvive.Text = "23"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(579, 75)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(14, 13)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "S"
        '
        'txtBirth
        '
        Me.txtBirth.Location = New System.Drawing.Point(509, 68)
        Me.txtBirth.Name = "txtBirth"
        Me.txtBirth.Size = New System.Drawing.Size(55, 20)
        Me.txtBirth.TabIndex = 22
        Me.txtBirth.Text = "3"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(489, 74)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(14, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "B"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(291, 57)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(113, 31)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "$ generations for stable pop. (0 for all)"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'nudStableCount
        '
        Me.nudStableCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudStableCount.Location = New System.Drawing.Point(408, 66)
        Me.nudStableCount.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nudStableCount.Name = "nudStableCount"
        Me.nudStableCount.Size = New System.Drawing.Size(64, 22)
        Me.nudStableCount.TabIndex = 19
        Me.nudStableCount.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'btnRecap
        '
        Me.btnRecap.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecap.Location = New System.Drawing.Point(678, 68)
        Me.btnRecap.Name = "btnRecap"
        Me.btnRecap.Size = New System.Drawing.Size(78, 23)
        Me.btnRecap.TabIndex = 25
        Me.btnRecap.Text = "Recap"
        Me.btnRecap.UseVisualStyleBackColor = True
        '
        'rbCircularCells
        '
        Me.rbCircularCells.AutoSize = True
        Me.rbCircularCells.Location = New System.Drawing.Point(229, 66)
        Me.rbCircularCells.Name = "rbCircularCells"
        Me.rbCircularCells.Size = New System.Drawing.Size(56, 17)
        Me.rbCircularCells.TabIndex = 17
        Me.rbCircularCells.Text = "Circles"
        Me.rbCircularCells.UseVisualStyleBackColor = True
        '
        'rbSquareCells
        '
        Me.rbSquareCells.AutoSize = True
        Me.rbSquareCells.Checked = True
        Me.rbSquareCells.Location = New System.Drawing.Point(139, 66)
        Me.rbSquareCells.Name = "rbSquareCells"
        Me.rbSquareCells.Size = New System.Drawing.Size(84, 17)
        Me.rbSquareCells.TabIndex = 16
        Me.rbSquareCells.TabStop = True
        Me.rbSquareCells.Text = "Square Cells"
        Me.rbSquareCells.UseVisualStyleBackColor = True
        '
        'lblTim
        '
        Me.lblTim.AutoSize = True
        Me.lblTim.Location = New System.Drawing.Point(433, 50)
        Me.lblTim.Name = "lblTim"
        Me.lblTim.Size = New System.Drawing.Size(0, 13)
        Me.lblTim.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "# cells on an axis"
        '
        'nudCellAxisLength
        '
        Me.nudCellAxisLength.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudCellAxisLength.Location = New System.Drawing.Point(9, 66)
        Me.nudCellAxisLength.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nudCellAxisLength.Minimum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.nudCellAxisLength.Name = "nudCellAxisLength"
        Me.nudCellAxisLength.Size = New System.Drawing.Size(106, 22)
        Me.nudCellAxisLength.TabIndex = 15
        Me.nudCellAxisLength.Value = New Decimal(New Integer() {120, 0, 0, 0})
        '
        'trkCellSize
        '
        Me.trkCellSize.Location = New System.Drawing.Point(646, 3)
        Me.trkCellSize.Maximum = 20
        Me.trkCellSize.Minimum = 3
        Me.trkCellSize.Name = "trkCellSize"
        Me.trkCellSize.Size = New System.Drawing.Size(104, 45)
        Me.trkCellSize.TabIndex = 13
        Me.trkCellSize.Value = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(602, 4)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Cell Size"
        '
        'lbCounter
        '
        Me.lbCounter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbCounter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCounter.Location = New System.Drawing.Point(408, 94)
        Me.lbCounter.Name = "lbCounter"
        Me.lbCounter.Size = New System.Drawing.Size(348, 23)
        Me.lbCounter.TabIndex = 29
        '
        'trkSpeed
        '
        Me.trkSpeed.Location = New System.Drawing.Point(489, 3)
        Me.trkSpeed.Name = "trkSpeed"
        Me.trkSpeed.Size = New System.Drawing.Size(104, 45)
        Me.trkSpeed.TabIndex = 11
        Me.trkSpeed.Value = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(445, 4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Speed"
        '
        'btnResume
        '
        Me.btnResume.Enabled = False
        Me.btnResume.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResume.Location = New System.Drawing.Point(275, 94)
        Me.btnResume.Name = "btnResume"
        Me.btnResume.Size = New System.Drawing.Size(127, 23)
        Me.btnResume.TabIndex = 28
        Me.btnResume.Text = "Resume Universe"
        Me.btnResume.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(364, 4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Color 2"
        '
        'lbColor2
        '
        Me.lbColor2.BackColor = System.Drawing.Color.DodgerBlue
        Me.lbColor2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbColor2.Location = New System.Drawing.Point(361, 17)
        Me.lbColor2.Name = "lbColor2"
        Me.lbColor2.Size = New System.Drawing.Size(68, 23)
        Me.lbColor2.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(290, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Color 1"
        '
        'lbColor1
        '
        Me.lbColor1.BackColor = System.Drawing.Color.DodgerBlue
        Me.lbColor1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbColor1.Location = New System.Drawing.Point(287, 17)
        Me.lbColor1.Name = "lbColor1"
        Me.lbColor1.Size = New System.Drawing.Size(68, 23)
        Me.lbColor1.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(216, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Gridlines"
        '
        'lbGridLines
        '
        Me.lbGridLines.BackColor = System.Drawing.Color.Black
        Me.lbGridLines.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbGridLines.Location = New System.Drawing.Point(213, 17)
        Me.lbGridLines.Name = "lbGridLines"
        Me.lbGridLines.Size = New System.Drawing.Size(68, 23)
        Me.lbGridLines.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(142, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Background"
        '
        'lbGridBackground
        '
        Me.lbGridBackground.BackColor = System.Drawing.Color.White
        Me.lbGridBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbGridBackground.Location = New System.Drawing.Point(139, 17)
        Me.lbGridBackground.Name = "lbGridBackground"
        Me.lbGridBackground.Size = New System.Drawing.Size(68, 23)
        Me.lbGridBackground.TabIndex = 3
        '
        'btnStop
        '
        Me.btnStop.Enabled = False
        Me.btnStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStop.Location = New System.Drawing.Point(142, 94)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(127, 23)
        Me.btnStop.TabIndex = 27
        Me.btnStop.Text = "Stop Universe"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "% of cells to start live"
        '
        'nudRandomPct
        '
        Me.nudRandomPct.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudRandomPct.Location = New System.Drawing.Point(9, 20)
        Me.nudRandomPct.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.nudRandomPct.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudRandomPct.Name = "nudRandomPct"
        Me.nudRandomPct.Size = New System.Drawing.Size(106, 22)
        Me.nudRandomPct.TabIndex = 1
        Me.nudRandomPct.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'btnStart
        '
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(9, 94)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(127, 23)
        Me.btnStart.TabIndex = 26
        Me.btnStart.Text = "Start Universe"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VScrollBar1.Location = New System.Drawing.Point(747, 135)
        Me.VScrollBar1.Maximum = 109
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(17, 304)
        Me.VScrollBar1.TabIndex = 2
        '
        'HScrollBar1
        '
        Me.HScrollBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HScrollBar1.Location = New System.Drawing.Point(1, 439)
        Me.HScrollBar1.Maximum = 109
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(746, 17)
        Me.HScrollBar1.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(1, 135)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(743, 301)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Universe"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(765, 457)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.HScrollBar1)
        Me.Controls.Add(Me.VScrollBar1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Game of Life - Tim Andrews"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.nudStableCount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCellAxisLength, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trkCellSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trkSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudRandomPct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nudRandomPct As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents lbGridBackground As System.Windows.Forms.Label
    Friend WithEvents cd1 As System.Windows.Forms.ColorDialog
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbGridLines As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbColor2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbColor1 As System.Windows.Forms.Label
    Friend WithEvents btnResume As System.Windows.Forms.Button
    Friend WithEvents trkSpeed As System.Windows.Forms.TrackBar
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbCounter As System.Windows.Forms.Label
    Friend WithEvents trkCellSize As System.Windows.Forms.TrackBar
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents nudCellAxisLength As System.Windows.Forms.NumericUpDown
    Friend WithEvents VScrollBar1 As System.Windows.Forms.VScrollBar
    Friend WithEvents HScrollBar1 As System.Windows.Forms.HScrollBar
    Friend WithEvents lblTim As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbCircularCells As System.Windows.Forms.RadioButton
    Friend WithEvents rbSquareCells As System.Windows.Forms.RadioButton
    Friend WithEvents btnRecap As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents nudStableCount As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtSurvive As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtBirth As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label

End Class
