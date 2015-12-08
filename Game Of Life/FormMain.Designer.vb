<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.pnlLeft = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.trkCellSize = New System.Windows.Forms.TrackBar()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.trkSpeed = New System.Windows.Forms.TrackBar()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSurvive = New System.Windows.Forms.TextBox()
        Me.txtBirth = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.nudStableCount = New System.Windows.Forms.NumericUpDown()
        Me.rbCircularCells = New System.Windows.Forms.RadioButton()
        Me.rbSquareCells = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbColor2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbColor1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbGridLines = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbGridBackground = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.nudCellAxisLength = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nudRandomPct = New System.Windows.Forms.NumericUpDown()
        Me.btnCollapse = New System.Windows.Forms.Button()
        Me.pnlRight = New System.Windows.Forms.Panel()
        Me.pnlUniverse = New System.Windows.Forms.Panel()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.lbCounter = New System.Windows.Forms.Label()
        Me.btnRecap = New System.Windows.Forms.Button()
        Me.btnResume = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.pnlBottom = New System.Windows.Forms.Panel()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.cd1 = New System.Windows.Forms.ColorDialog()
        Me.pnlLeft.SuspendLayout()
        CType(Me.trkCellSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trkSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudStableCount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCellAxisLength, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudRandomPct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlRight.SuspendLayout()
        Me.pnlTop.SuspendLayout()
        Me.pnlBottom.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlLeft
        '
        Me.pnlLeft.AutoScroll = True
        Me.pnlLeft.Controls.Add(Me.Label11)
        Me.pnlLeft.Controls.Add(Me.trkCellSize)
        Me.pnlLeft.Controls.Add(Me.Label10)
        Me.pnlLeft.Controls.Add(Me.trkSpeed)
        Me.pnlLeft.Controls.Add(Me.Label7)
        Me.pnlLeft.Controls.Add(Me.Label5)
        Me.pnlLeft.Controls.Add(Me.txtSurvive)
        Me.pnlLeft.Controls.Add(Me.txtBirth)
        Me.pnlLeft.Controls.Add(Me.Label9)
        Me.pnlLeft.Controls.Add(Me.nudStableCount)
        Me.pnlLeft.Controls.Add(Me.rbCircularCells)
        Me.pnlLeft.Controls.Add(Me.rbSquareCells)
        Me.pnlLeft.Controls.Add(Me.Label6)
        Me.pnlLeft.Controls.Add(Me.lbColor2)
        Me.pnlLeft.Controls.Add(Me.Label4)
        Me.pnlLeft.Controls.Add(Me.lbColor1)
        Me.pnlLeft.Controls.Add(Me.Label3)
        Me.pnlLeft.Controls.Add(Me.lbGridLines)
        Me.pnlLeft.Controls.Add(Me.Label2)
        Me.pnlLeft.Controls.Add(Me.lbGridBackground)
        Me.pnlLeft.Controls.Add(Me.Label8)
        Me.pnlLeft.Controls.Add(Me.nudCellAxisLength)
        Me.pnlLeft.Controls.Add(Me.Label1)
        Me.pnlLeft.Controls.Add(Me.nudRandomPct)
        Me.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlLeft.Location = New System.Drawing.Point(0, 0)
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Size = New System.Drawing.Size(250, 457)
        Me.pnlLeft.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(131, 295)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 13)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Cell Size"
        '
        'trkCellSize
        '
        Me.trkCellSize.Location = New System.Drawing.Point(126, 311)
        Me.trkCellSize.Maximum = 20
        Me.trkCellSize.Minimum = 3
        Me.trkCellSize.Name = "trkCellSize"
        Me.trkCellSize.Size = New System.Drawing.Size(104, 45)
        Me.trkCellSize.TabIndex = 23
        Me.trkCellSize.Value = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 295)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Speed"
        '
        'trkSpeed
        '
        Me.trkSpeed.Location = New System.Drawing.Point(9, 311)
        Me.trkSpeed.Name = "trkSpeed"
        Me.trkSpeed.Size = New System.Drawing.Size(104, 45)
        Me.trkSpeed.TabIndex = 21
        Me.trkSpeed.Value = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(184, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Survive Rule"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(127, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Birth Rule"
        '
        'txtSurvive
        '
        Me.txtSurvive.Location = New System.Drawing.Point(187, 95)
        Me.txtSurvive.Name = "txtSurvive"
        Me.txtSurvive.Size = New System.Drawing.Size(55, 20)
        Me.txtSurvive.TabIndex = 9
        Me.txtSurvive.Text = "23"
        '
        'txtBirth
        '
        Me.txtBirth.Location = New System.Drawing.Point(130, 95)
        Me.txtBirth.Name = "txtBirth"
        Me.txtBirth.Size = New System.Drawing.Size(55, 20)
        Me.txtBirth.TabIndex = 7
        Me.txtBirth.Text = "3"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(15, 63)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 29)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "$ generations for stable pop. (0 for all)"
        '
        'nudStableCount
        '
        Me.nudStableCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudStableCount.Location = New System.Drawing.Point(11, 95)
        Me.nudStableCount.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nudStableCount.Name = "nudStableCount"
        Me.nudStableCount.Size = New System.Drawing.Size(105, 22)
        Me.nudStableCount.TabIndex = 5
        Me.nudStableCount.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'rbCircularCells
        '
        Me.rbCircularCells.AutoSize = True
        Me.rbCircularCells.Location = New System.Drawing.Point(134, 258)
        Me.rbCircularCells.Name = "rbCircularCells"
        Me.rbCircularCells.Size = New System.Drawing.Size(56, 17)
        Me.rbCircularCells.TabIndex = 19
        Me.rbCircularCells.Text = "Circles"
        Me.rbCircularCells.UseVisualStyleBackColor = True
        '
        'rbSquareCells
        '
        Me.rbSquareCells.AutoSize = True
        Me.rbSquareCells.Checked = True
        Me.rbSquareCells.Location = New System.Drawing.Point(9, 258)
        Me.rbSquareCells.Name = "rbSquareCells"
        Me.rbSquareCells.Size = New System.Drawing.Size(84, 17)
        Me.rbSquareCells.TabIndex = 18
        Me.rbSquareCells.TabStop = True
        Me.rbSquareCells.Text = "Square Cells"
        Me.rbSquareCells.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(131, 197)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Color 2"
        '
        'lbColor2
        '
        Me.lbColor2.BackColor = System.Drawing.Color.DodgerBlue
        Me.lbColor2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbColor2.Location = New System.Drawing.Point(130, 210)
        Me.lbColor2.Name = "lbColor2"
        Me.lbColor2.Size = New System.Drawing.Size(106, 23)
        Me.lbColor2.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Color 1"
        '
        'lbColor1
        '
        Me.lbColor1.BackColor = System.Drawing.Color.DodgerBlue
        Me.lbColor1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbColor1.Location = New System.Drawing.Point(9, 210)
        Me.lbColor1.Name = "lbColor1"
        Me.lbColor1.Size = New System.Drawing.Size(108, 23)
        Me.lbColor1.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(131, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Gridlines"
        '
        'lbGridLines
        '
        Me.lbGridLines.BackColor = System.Drawing.Color.Black
        Me.lbGridLines.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbGridLines.Location = New System.Drawing.Point(130, 157)
        Me.lbGridLines.Name = "lbGridLines"
        Me.lbGridLines.Size = New System.Drawing.Size(106, 23)
        Me.lbGridLines.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Background"
        '
        'lbGridBackground
        '
        Me.lbGridBackground.BackColor = System.Drawing.Color.White
        Me.lbGridBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbGridBackground.Location = New System.Drawing.Point(9, 157)
        Me.lbGridBackground.Name = "lbGridBackground"
        Me.lbGridBackground.Size = New System.Drawing.Size(108, 23)
        Me.lbGridBackground.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(131, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "# cells on an axis"
        '
        'nudCellAxisLength
        '
        Me.nudCellAxisLength.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudCellAxisLength.Location = New System.Drawing.Point(130, 25)
        Me.nudCellAxisLength.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nudCellAxisLength.Minimum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.nudCellAxisLength.Name = "nudCellAxisLength"
        Me.nudCellAxisLength.Size = New System.Drawing.Size(106, 22)
        Me.nudCellAxisLength.TabIndex = 3
        Me.nudCellAxisLength.Value = New Decimal(New Integer() {120, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "% of cells to start live"
        '
        'nudRandomPct
        '
        Me.nudRandomPct.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudRandomPct.Location = New System.Drawing.Point(11, 25)
        Me.nudRandomPct.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.nudRandomPct.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudRandomPct.Name = "nudRandomPct"
        Me.nudRandomPct.Size = New System.Drawing.Size(106, 22)
        Me.nudRandomPct.TabIndex = 1
        Me.nudRandomPct.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'btnCollapse
        '
        Me.btnCollapse.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnCollapse.Location = New System.Drawing.Point(250, 0)
        Me.btnCollapse.Name = "btnCollapse"
        Me.btnCollapse.Size = New System.Drawing.Size(20, 457)
        Me.btnCollapse.TabIndex = 1
        Me.btnCollapse.Text = "<"
        Me.btnCollapse.UseVisualStyleBackColor = True
        '
        'pnlRight
        '
        Me.pnlRight.BackColor = System.Drawing.SystemColors.Control
        Me.pnlRight.Controls.Add(Me.pnlUniverse)
        Me.pnlRight.Controls.Add(Me.pnlTop)
        Me.pnlRight.Controls.Add(Me.pnlBottom)
        Me.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlRight.Location = New System.Drawing.Point(270, 0)
        Me.pnlRight.Name = "pnlRight"
        Me.pnlRight.Size = New System.Drawing.Size(495, 457)
        Me.pnlRight.TabIndex = 2
        '
        'pnlUniverse
        '
        Me.pnlUniverse.AutoScroll = True
        Me.pnlUniverse.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlUniverse.Location = New System.Drawing.Point(0, 58)
        Me.pnlUniverse.Name = "pnlUniverse"
        Me.pnlUniverse.Size = New System.Drawing.Size(495, 369)
        Me.pnlUniverse.TabIndex = 1
        '
        'pnlTop
        '
        Me.pnlTop.Controls.Add(Me.lbCounter)
        Me.pnlTop.Controls.Add(Me.btnRecap)
        Me.pnlTop.Controls.Add(Me.btnResume)
        Me.pnlTop.Controls.Add(Me.btnStop)
        Me.pnlTop.Controls.Add(Me.btnStart)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(495, 58)
        Me.pnlTop.TabIndex = 0
        '
        'lbCounter
        '
        Me.lbCounter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbCounter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCounter.Location = New System.Drawing.Point(6, 29)
        Me.lbCounter.Name = "lbCounter"
        Me.lbCounter.Size = New System.Drawing.Size(477, 23)
        Me.lbCounter.TabIndex = 4
        '
        'btnRecap
        '
        Me.btnRecap.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecap.Location = New System.Drawing.Point(405, 3)
        Me.btnRecap.Name = "btnRecap"
        Me.btnRecap.Size = New System.Drawing.Size(78, 23)
        Me.btnRecap.TabIndex = 3
        Me.btnRecap.Text = "Recap"
        Me.btnRecap.UseVisualStyleBackColor = True
        '
        'btnResume
        '
        Me.btnResume.Enabled = False
        Me.btnResume.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResume.Location = New System.Drawing.Point(272, 3)
        Me.btnResume.Name = "btnResume"
        Me.btnResume.Size = New System.Drawing.Size(127, 23)
        Me.btnResume.TabIndex = 2
        Me.btnResume.Text = "Resume Universe"
        Me.btnResume.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Enabled = False
        Me.btnStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStop.Location = New System.Drawing.Point(139, 3)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(127, 23)
        Me.btnStop.TabIndex = 1
        Me.btnStop.Text = "Stop Universe"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(6, 3)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(127, 23)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start Universe"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'pnlBottom
        '
        Me.pnlBottom.Controls.Add(Me.btnExit)
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottom.Location = New System.Drawing.Point(0, 427)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New System.Drawing.Size(495, 30)
        Me.pnlBottom.TabIndex = 2
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(417, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(765, 457)
        Me.Controls.Add(Me.pnlRight)
        Me.Controls.Add(Me.btnCollapse)
        Me.Controls.Add(Me.pnlLeft)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Game of Life - Tim Andrews"
        Me.pnlLeft.ResumeLayout(False)
        Me.pnlLeft.PerformLayout()
        CType(Me.trkCellSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trkSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudStableCount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCellAxisLength, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudRandomPct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlRight.ResumeLayout(False)
        Me.pnlTop.ResumeLayout(False)
        Me.pnlBottom.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlLeft As System.Windows.Forms.Panel
    Friend WithEvents btnCollapse As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nudRandomPct As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents nudCellAxisLength As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbGridBackground As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbGridLines As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbColor1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbColor2 As System.Windows.Forms.Label
    Friend WithEvents rbCircularCells As System.Windows.Forms.RadioButton
    Friend WithEvents rbSquareCells As System.Windows.Forms.RadioButton
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents nudStableCount As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSurvive As System.Windows.Forms.TextBox
    Friend WithEvents txtBirth As System.Windows.Forms.TextBox
    Friend WithEvents trkSpeed As System.Windows.Forms.TrackBar
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents trkCellSize As System.Windows.Forms.TrackBar
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents pnlRight As System.Windows.Forms.Panel
    Friend WithEvents cd1 As System.Windows.Forms.ColorDialog
    Friend WithEvents pnlBottom As System.Windows.Forms.Panel
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents btnRecap As System.Windows.Forms.Button
    Friend WithEvents btnResume As System.Windows.Forms.Button
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents lbCounter As System.Windows.Forms.Label
    Friend WithEvents pnlUniverse As System.Windows.Forms.Panel
End Class
