Public Class MainForm
    Private HaveUnsavedData As Boolean 'defined on form laod
    Private HaveData As Boolean 'defined on form load
    Private Title As String = "Gamedata file editor"
    Private CurrentPath As String = "D:\"
    Private CurrentFile As String = "Dinotracker.gamedata"
    Private ARKFolder As String = ""

    Private Sub UpdateTitle()
        Dim one As String = ""
        Dim two As String = ""

        If HaveData Then two = " - "
        If HaveUnsavedData Then one = "*"

        Me.Text = one & ModName.Text & two & Title
    End Sub

    Private Function HaveUnsaved()
        Dim Response
        Status.Text = HaveUnsavedData
        If HaveUnsavedData Then
            Response = MsgBox("Save changes?", vbYesNoCancel + vbQuestion, "Attention!")
            Select Case Response
                Case vbYes
                    'save data
                    Return False
                Case vbNo
                    'dont save
                    Return False
                Case vbCancel
                    Return True
            End Select
        End If
        Return False
    End Function

    Private Sub NewData()
        If HaveUnsaved() = False Then
            Creatures.Rows.Clear()
            Engrams.Rows.Clear()
            Items.Rows.Clear()
            MapSpawns.Rows.Clear()
            SupplyCrates.Rows.Clear()
            Inventories.Rows.Clear()
            GameMaps.Rows.Clear()
            ModName.Text = ""
            ModID.Text = ""
            HaveUnsavedData = False
            HaveData = False
            CreationDate.Text = DateTime.UtcNow.ToString("o")
            UpdateTitle()

        End If
    End Sub

    Private Function OpenData(FilePath As String)

        HaveData = True
    End Function

    Private Function SaveData(FilePath As String)

        HaveUnsavedData = False
    End Function

    Private Function ScanData(FolderPath As String)

    End Function

    Private Sub OpenFile()
        If Not HaveUnsaved() Then
            OpenFileDialog1.Title = "Please select a Gamedata file"
            OpenFileDialog1.Filter = "Gamedata Files|*.gamedata|Text Files|*.txt|All Files|*.*"
            OpenFileDialog1.InitialDirectory = CurrentPath
            OpenFileDialog1.FileName = CurrentFile

            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                OpenData(OpenFileDialog1.FileName)
            End If
        End If

    End Sub

    Private Sub SafeFile()
        SaveFileDialog1.Title = "Please select a Gamedata file"
        SaveFileDialog1.Filter = "Gamedata Files|*.gamedata|Text Files|*.txt|All Files|*.*"
        SaveFileDialog1.InitialDirectory = CurrentPath
        SaveFileDialog1.FileName = CurrentFile

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            SaveData(SaveFileDialog1.FileName)
        End If
    End Sub

    Private Sub MadeChanges()
        If Not HaveUnsavedData Then
            HaveData = True
            HaveUnsavedData = True
        End If
        UpdateTitle()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = HaveUnsaved()
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click, ToolStripButton1.Click
        NewData()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HaveUnsavedData = False
        HaveData = False
        NewData()
    End Sub

    Private Sub ModName_TextChanged(sender As Object, e As EventArgs) Handles ModName.TextChanged
        MadeChanges()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click, ToolStripButton2.Click
        OpenFile()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Status.Text = HaveUnsavedData
        UpdateTitle()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        HaveUnsavedData = False
    End Sub
End Class
