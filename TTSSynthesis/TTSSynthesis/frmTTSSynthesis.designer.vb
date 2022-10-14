<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTTSSynthesis
    'Inherits System.Windows.Forms.Form
    Inherits MetroFramework.Forms.MetroForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTTSSynthesis))
        Me.lblVolume = New System.Windows.Forms.Label()
        Me.trbVolume = New System.Windows.Forms.TrackBar()
        Me.lblVoice = New System.Windows.Forms.Label()
        Me.cmbVoices = New System.Windows.Forms.ComboBox()
        Me.txtMessage = New System.Windows.Forms.RichTextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnSaveWavFile = New System.Windows.Forms.Button()
        Me.lblRate = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.trbRate = New System.Windows.Forms.TrackBar()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnPause = New System.Windows.Forms.Button()
        Me.btnResume = New System.Windows.Forms.Button()
        Me.btnLoadTextFile = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        CType(Me.trbVolume, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trbRate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblVolume
        '
        Me.lblVolume.AutoSize = True
        Me.lblVolume.Location = New System.Drawing.Point(10, 104)
        Me.lblVolume.Name = "lblVolume"
        Me.lblVolume.Size = New System.Drawing.Size(61, 18)
        Me.lblVolume.TabIndex = 13
        Me.lblVolume.Text = "Volume "
        '
        'trbVolume
        '
        Me.trbVolume.Location = New System.Drawing.Point(101, 95)
        Me.trbVolume.Maximum = 100
        Me.trbVolume.Minimum = 10
        Me.trbVolume.Name = "trbVolume"
        Me.trbVolume.Size = New System.Drawing.Size(201, 45)
        Me.trbVolume.TabIndex = 1
        Me.trbVolume.TickFrequency = 10
        Me.trbVolume.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.trbVolume.Value = 100
        '
        'lblVoice
        '
        Me.lblVoice.AutoSize = True
        Me.lblVoice.Location = New System.Drawing.Point(10, 63)
        Me.lblVoice.Name = "lblVoice"
        Me.lblVoice.Size = New System.Drawing.Size(85, 18)
        Me.lblVoice.TabIndex = 11
        Me.lblVoice.Text = "Select Voice"
        '
        'cmbVoices
        '
        Me.cmbVoices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbVoices.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbVoices.FormattingEnabled = True
        Me.cmbVoices.Location = New System.Drawing.Point(101, 60)
        Me.cmbVoices.Name = "cmbVoices"
        Me.cmbVoices.Size = New System.Drawing.Size(335, 24)
        Me.cmbVoices.TabIndex = 0
        '
        'txtMessage
        '
        Me.txtMessage.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMessage.Location = New System.Drawing.Point(12, 197)
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.txtMessage.Size = New System.Drawing.Size(421, 237)
        Me.txtMessage.TabIndex = 11
        Me.txtMessage.Text = "Enter text here"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Orange
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(451, 399)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(130, 34)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.Crimson
        Me.btnStart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStart.FlatAppearance.BorderSize = 0
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStart.ForeColor = System.Drawing.Color.White
        Me.btnStart.Location = New System.Drawing.Point(451, 59)
        Me.btnStart.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(130, 34)
        Me.btnStart.TabIndex = 4
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'btnSaveWavFile
        '
        Me.btnSaveWavFile.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnSaveWavFile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveWavFile.FlatAppearance.BorderSize = 0
        Me.btnSaveWavFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveWavFile.ForeColor = System.Drawing.Color.White
        Me.btnSaveWavFile.Location = New System.Drawing.Point(451, 357)
        Me.btnSaveWavFile.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSaveWavFile.Name = "btnSaveWavFile"
        Me.btnSaveWavFile.Size = New System.Drawing.Size(130, 34)
        Me.btnSaveWavFile.TabIndex = 9
        Me.btnSaveWavFile.Text = "Save to WAV"
        Me.btnSaveWavFile.UseVisualStyleBackColor = False
        '
        'lblRate
        '
        Me.lblRate.AutoSize = True
        Me.lblRate.Location = New System.Drawing.Point(10, 142)
        Me.lblRate.Name = "lblRate"
        Me.lblRate.Size = New System.Drawing.Size(38, 18)
        Me.lblRate.TabIndex = 19
        Me.lblRate.Text = "Rate"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(290, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 14)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Fast"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(78, 145)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 14)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Slow"
        '
        'trbRate
        '
        Me.trbRate.LargeChange = 1
        Me.trbRate.Location = New System.Drawing.Point(101, 143)
        Me.trbRate.Minimum = -10
        Me.trbRate.Name = "trbRate"
        Me.trbRate.Size = New System.Drawing.Size(201, 45)
        Me.trbRate.TabIndex = 2
        Me.trbRate.Value = -1
        '
        'btnStop
        '
        Me.btnStop.BackColor = System.Drawing.Color.Green
        Me.btnStop.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStop.FlatAppearance.BorderSize = 0
        Me.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStop.ForeColor = System.Drawing.Color.White
        Me.btnStop.Location = New System.Drawing.Point(451, 101)
        Me.btnStop.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(130, 34)
        Me.btnStop.TabIndex = 5
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = False
        '
        'btnPause
        '
        Me.btnPause.BackColor = System.Drawing.Color.Olive
        Me.btnPause.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPause.FlatAppearance.BorderSize = 0
        Me.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPause.ForeColor = System.Drawing.Color.White
        Me.btnPause.Location = New System.Drawing.Point(451, 143)
        Me.btnPause.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnPause.Name = "btnPause"
        Me.btnPause.Size = New System.Drawing.Size(130, 34)
        Me.btnPause.TabIndex = 6
        Me.btnPause.Text = "Pause"
        Me.btnPause.UseVisualStyleBackColor = False
        '
        'btnResume
        '
        Me.btnResume.BackColor = System.Drawing.Color.Maroon
        Me.btnResume.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnResume.FlatAppearance.BorderSize = 0
        Me.btnResume.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResume.ForeColor = System.Drawing.Color.White
        Me.btnResume.Location = New System.Drawing.Point(451, 185)
        Me.btnResume.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnResume.Name = "btnResume"
        Me.btnResume.Size = New System.Drawing.Size(130, 34)
        Me.btnResume.TabIndex = 7
        Me.btnResume.Text = "Resume"
        Me.btnResume.UseVisualStyleBackColor = False
        '
        'btnLoadTextFile
        '
        Me.btnLoadTextFile.BackColor = System.Drawing.Color.DarkMagenta
        Me.btnLoadTextFile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoadTextFile.FlatAppearance.BorderSize = 0
        Me.btnLoadTextFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoadTextFile.ForeColor = System.Drawing.Color.White
        Me.btnLoadTextFile.Location = New System.Drawing.Point(451, 315)
        Me.btnLoadTextFile.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnLoadTextFile.Name = "btnLoadTextFile"
        Me.btnLoadTextFile.Size = New System.Drawing.Size(130, 34)
        Me.btnLoadTextFile.TabIndex = 8
        Me.btnLoadTextFile.Text = "Load Text File"
        Me.btnLoadTextFile.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReset.FlatAppearance.BorderSize = 0
        Me.btnReset.Location = New System.Drawing.Point(361, 95)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 32)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'frmTTSSynthesis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 447)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnLoadTextFile)
        Me.Controls.Add(Me.btnResume)
        Me.Controls.Add(Me.btnPause)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.trbRate)
        Me.Controls.Add(Me.lblRate)
        Me.Controls.Add(Me.btnSaveWavFile)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblVolume)
        Me.Controls.Add(Me.trbVolume)
        Me.Controls.Add(Me.lblVoice)
        Me.Controls.Add(Me.cmbVoices)
        Me.Controls.Add(Me.txtMessage)
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTTSSynthesis"
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow
        Me.Style = MetroFramework.MetroColorStyle.Orange
        Me.Text = "Text To Speech Synthesis"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.TransparencyKey = System.Drawing.Color.Empty
        CType(Me.trbVolume, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trbRate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblVolume As System.Windows.Forms.Label
    Friend WithEvents trbVolume As System.Windows.Forms.TrackBar
    Friend WithEvents lblVoice As System.Windows.Forms.Label
    Friend WithEvents cmbVoices As System.Windows.Forms.ComboBox
    Friend WithEvents txtMessage As System.Windows.Forms.RichTextBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnSaveWavFile As System.Windows.Forms.Button
    Friend WithEvents lblRate As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents trbRate As System.Windows.Forms.TrackBar
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents btnPause As System.Windows.Forms.Button
    Friend WithEvents btnResume As System.Windows.Forms.Button
    Friend WithEvents btnLoadTextFile As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button

End Class
