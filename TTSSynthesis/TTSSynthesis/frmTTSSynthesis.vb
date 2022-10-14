#Region "ABOUT"
' / --------------------------------------------------------------------------------
' / Developer : Mr.Surapon Yodsanga (Thongkorn Tubtimkrob)
' / eMail : thongkorn@hotmail.com
' / URL: http://www.g2gnet.com (Khon Kaen - Thailand)
' / Facebook: http://www.facebook.com/g2gnet (for Thailand)
' / Facebook: http://www.facebook.com/commonindy (Worldwide)
' / More Info: http://www.g2gsoft.com
' /
' / Purpose: Text To Speech (TTS).
' / Microsoft Visual Basic .NET (2010)
' /
' / This is open source code under @CopyLeft by Thongkorn Tubtimkrob.
' / You can modify and/or distribute without to inform the developer.
' / --------------------------------------------------------------------------------
#End Region

Imports System.Speech.Synthesis
Imports System.Collections.ObjectModel
Imports System.IO

Public Class frmTTSSynthesis
    Private WithEvents SpeechSynth As New SpeechSynthesizer

    ' / --------------------------------------------------------------------------------
    ' / START HERE ...
    Private Sub frmTextToSpeechLib_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Text To Speech Synthesis"
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        txtMessage.Text = "I have a beautiful bedroom. There is a bed in my room. I love my room because I can do everything I want in the room. I have a cupboard in my room where I keep my clothes. My room is decorated with many stickers. My friends love playing in my room. I love my bedroom so much."
        '// Clear All or Start Mode.
        Call btnReset_Click(sender, e)
        '// Event Handler when speak complete.
        AddHandler SpeechSynth.SpeakCompleted, AddressOf SpeakComplete
    End Sub

    ' / --------------------------------------------------------------------------------
    '// When speak complete.
    Private Sub SpeakComplete(sender As Object, e As SpeakCompletedEventArgs)
        Try
            SpeechSynth.SpeakAsyncCancelAll()
            'MessageBox.Show("Speach Done.", "Report Status", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnStart.Enabled = True
            btnStop.Enabled = False
            btnPause.Enabled = False
            btnResume.Enabled = False
            btnExit.Enabled = True
            '//
            btnLoadTextFile.Enabled = True
            btnSaveWavFile.Enabled = True
        Catch ex As Exception
            MessageBox.Show("Error : " & ex.Message, "Report Status", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    ' / --------------------------------------------------------------------------------
    Private Sub btnStart_Click(sender As System.Object, e As System.EventArgs) Handles btnStart.Click
        SpeechSynth.SelectVoice(cmbVoices.Text)
        SpeechSynth.SpeakAsync(txtMessage.Text)
        SpeechSynth.Volume = trbVolume.Value
        SpeechSynth.Rate = trbRate.Value
        '/
        btnStart.Enabled = False
        btnStop.Enabled = True
        btnPause.Enabled = True
        btnResume.Enabled = False
        btnExit.Enabled = False
        btnLoadTextFile.Enabled = False
        btnSaveWavFile.Enabled = False
        '//
        txtMessage.Focus()
    End Sub

    ' / --------------------------------------------------------------------------------
    ' / The events that SpeechSynthesizer generates enables us to tell what the computer voice is just speaking.
    Private Sub SpeakProgress(sender As Object, e As SpeakProgressEventArgs) Handles SpeechSynth.SpeakProgress
        txtMessage.SelectionStart = e.CharacterPosition
        txtMessage.SelectionLength = e.CharacterCount
    End Sub

    ' / --------------------------------------------------------------------------------
    Private Sub btnStop_Click(sender As System.Object, e As System.EventArgs) Handles btnStop.Click
        SpeechSynth.SpeakAsyncCancelAll()
        Call btnReset_Click(sender, e)
    End Sub

    ' / --------------------------------------------------------------------------------
    Private Sub btnPause_Click(sender As System.Object, e As System.EventArgs) Handles btnPause.Click
        SpeechSynth.Pause()
        btnPause.Enabled = False
        btnStop.Enabled = False
        btnResume.Enabled = True
    End Sub

    ' / --------------------------------------------------------------------------------
    Private Sub btnResume_Click(sender As System.Object, e As System.EventArgs) Handles btnResume.Click
        SpeechSynth.Resume()
        txtMessage.Focus()
        btnPause.Enabled = True
        btnStop.Enabled = True
        btnResume.Enabled = False
    End Sub

    ' / --------------------------------------------------------------------------------
    Private Sub trbVolume_ValueChanged(sender As Object, e As System.EventArgs) Handles trbVolume.ValueChanged
        SpeechSynth.Volume = trbVolume.Value
    End Sub

    ' / --------------------------------------------------------------------------------
    Private Sub trbRate_ValueChanged(sender As Object, e As System.EventArgs) Handles trbRate.ValueChanged
        SpeechSynth.Rate = trbRate.Value
    End Sub

    ' / --------------------------------------------------------------------------------
    Private Sub btnLoadTextFile_Click(sender As System.Object, e As System.EventArgs) Handles btnLoadTextFile.Click
        Dim OpenFile As New OpenFileDialog
        With OpenFile
            .InitialDirectory = MyPath(Application.StartupPath)
            .Filter = "Text Files (*.txt)|*.txt"
            .Title = "Open Text File"
            .RestoreDirectory = True
        End With
        If OpenFile.ShowDialog() = Windows.Forms.DialogResult.OK Then
            '/ Load File Content
            Dim strmRedr As New System.IO.StreamReader(OpenFile.FileName)
            txtMessage.Text = strmRedr.ReadToEnd
            strmRedr.Close()
        End If
    End Sub

    ' / --------------------------------------------------------------------------------
    Private Sub btnSaveWavFile_Click(sender As System.Object, e As System.EventArgs) Handles btnSaveWavFile.Click
        If txtMessage.Text.Trim.Length = 0 Then Return
        Dim SaveFileDialog As New SaveFileDialog
        Try
            With SaveFileDialog
                .InitialDirectory = MyPath(Application.StartupPath)
                .Filter = "Wav Files (*.wav)|*.wav"
                .Title = "Save to wav file"
                .RestoreDirectory = True
            End With
            If SaveFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.Cursor = Cursors.WaitCursor
                Dim fs As FileStream = New FileStream(SaveFileDialog.FileName, FileMode.Create, FileAccess.Write)
                SpeechSynth.SetOutputToWaveStream(fs)
                SpeechSynth.Speak(txtMessage.Text)
                Me.Cursor = Cursors.Default
                MessageBox.Show("Save file to wav successfully.", "Report Status", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Report Status", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' / --------------------------------------------------------------------------------
    Private Sub btnReset_Click(sender As System.Object, e As System.EventArgs) Handles btnReset.Click
        Try
            cmbVoices.Items.Clear()
            Dim objVoices As ReadOnlyCollection(Of InstalledVoice) = SpeechSynth.GetInstalledVoices()
            Dim objVoiceInformation As VoiceInfo = objVoices(0).VoiceInfo
            For Each tmpvoice As InstalledVoice In objVoices
                objVoiceInformation = tmpvoice.VoiceInfo
                cmbVoices.Items.Add(objVoiceInformation.Name.ToString)
            Next
            cmbVoices.SelectedIndex = 0
            trbVolume.Value = 100
            trbRate.Value = -1
            '//
            SpeechSynth.SpeakAsyncCancelAll()
            btnStart.Enabled = True
            btnStop.Enabled = False
            btnPause.Enabled = False
            btnResume.Enabled = False
            '//
            btnLoadTextFile.Enabled = True
            btnSaveWavFile.Enabled = True
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Report Status", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End Try
    End Sub

    ' / --------------------------------------------------------------------------------
    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    ' / --------------------------------------------------------------------------------
    Private Sub frmTextToSpeechLib_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        SpeechSynth.Dispose()
        Me.Dispose()
        GC.SuppressFinalize(Me)
        Application.Exit()
    End Sub

    ' / --------------------------------------------------------------------------------
    ' / Get my project path
    ' / AppPath = C:\My Project\bin\debug
    ' / Replace "\bin\debug" with "\"
    ' / Return : C:\My Project\
    Function MyPath(AppPath As String) As String
        '/ Return Value
        MyPath = AppPath.ToLower.Replace("\bin\debug", "\").Replace("\bin\release", "\").Replace("\bin\x86\debug", "\")
        '// Put the BackSlash "\" or ASCII Code = 92 at the end.
        If Microsoft.VisualBasic.Right(MyPath, 1) <> Chr(92) Then MyPath = MyPath & Chr(92)
    End Function
End Class
