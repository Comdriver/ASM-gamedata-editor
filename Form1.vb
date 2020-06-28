
Imports System.IO

Public Class MainForm
    Private DataFile As StreamReader
    Private HaveUnsavedData As Boolean 'defined on form laod
    Private HaveData As Boolean 'defined on form load
    Private Title As String = "Gamedata file editor"
    Private CurrentPath As String = ""
    Private CurrentFile As String = ""
    Private ARKFolder As String = ""
    Private strQuote As Char = Chr(34)

    Private testline As String = "  ""Created"": ""2020-06-24T00:00:00.0000000Z"","

    Private Sub UpdateTitle()
        Dim one As String = ""
        Dim two As String = ""

        If HaveData Then two = " - "
        If HaveUnsavedData Then one = "*"

        Me.Text = one & ModName.Text & two & Title
    End Sub

    Private Sub WrongFileMsg(FileLine As String)
        MsgBox("Incorrect file or data corruption!" & vbNewLine & "FIle: " & CurrentFile & " Line: " & FileLine, vbOKOnly + vbExclamation, "Attention!")
    End Sub

    Private Function GetLine() As String
        Dim Line As String
        Line = DataFile.ReadLine
        If Line Is Nothing Then Return Nothing
        Line = Line.Replace(strQuote, "")
        Line = Line.Replace(" ", "")
        Line = Line.TrimEnd(",")
        Return Line
    End Function

    Private Function HaveUnsaved() As Boolean
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
            CurrentFile = ""
            HaveUnsavedData = False
            HaveData = False
            CreationDate.Text = DateTime.UtcNow.ToString("o")
            UpdateTitle()

        End If
    End Sub

    Private Function OpenData(FilePath As String) As Boolean
        Dim Line As String
        DataFile = My.Computer.FileSystem.OpenTextFileReader(FilePath)
        'Dim LinePos As Integer

        CurrentFile = System.IO.Path.GetFileName(FilePath)
        CurrentPath = FilePath

        Line = GetLine()  'skip first bracket

        'read header
        Line = GetLine()

        If InStr(Line, "Application") < 1 Then
            WrongFileMsg("1")
            Return False
        End If

        If InStr(Line, "ark") < 1 Then
            WrongFileMsg("1")
            Return False
        End If

        Line = GetLine()  'read version
        If InStr(Line, "Version") < 1 Then
            WrongFileMsg("2")
            Return False
        End If

        Line = GetLine()  'read creation date
        CreationDate.Text = Line.Remove(0, 8)

        'read data
        Do
            Line = GetLine() 'read data header

            Select Case Line
                Case "Engrams:["
                   ' ReadEngrams()
                Case "Creatures:["
                    ReadCreatures()
                Case "Items"
                    ReadItems()
                Case "MapSpawners:["
                    ReadMapSpawns()
                Case "SupplyCrates:["
                    ReadCreatures()
                Case "Inventories:["
                    ReadInventories()
                Case "GameMaps:["
                    ReadGameMaps()
            End Select
        Loop Until Line Is Nothing

        DataFile.Close()

        HaveData = True
        HaveUnsavedData = False
        Return True
    End Function

    Private Sub ReadCreatures()

    End Sub

    Private Sub ReadEngrams()
        Dim Line As String
        Dim RowCount As Integer = Engrams.Rows.Count
        Dim Level As Integer = 0
        Dim Points As Integer = 0
        Dim IsTekgram As Boolean = False
        Dim ClassName As String
        Dim Description As String


        Do
            Line = GetLine() 'read first bracket
            Line = GetLine()
            If Line = "]" Or Line = "]," Or Line Is Nothing Then
                Return
            End If
            Engrams.Rows()
            RowCount += 1



        Loop

    End Sub

    Private Sub ReadItems()

    End Sub

    Private Sub ReadMapSpawns()

    End Sub

    Private Sub ReadCrates()

    End Sub

    Private Sub ReadInventories()

    End Sub

    Private Sub ReadGameMaps()

    End Sub

    Private Function SaveData(FilePath As String, FileName As String)

        HaveUnsavedData = False
        Return True
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

    Private Sub SaveFile()
        Dim FilePath As String = ""
        Dim FileName As String = ""
        SaveFileDialog1.Title = "Please select a Gamedata file"
        SaveFileDialog1.Filter = "Gamedata Files|*.gamedata|Text Files|*.txt|All Files|*.*"
        SaveFileDialog1.InitialDirectory = CurrentPath
        SaveFileDialog1.FileName = CurrentFile

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            FileName = System.IO.Path.GetFileName(SaveFileDialog1.FileName)
            FilePath = SaveFileDialog1.FileName
            SaveData(FilePath, FileName)
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

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        SaveFile()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        If CurrentFile = "" Then
            SaveFile()
        Else
            SaveData(CurrentPath, CurrentFile)
        End If

    End Sub

    Private Sub ScanAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScanAllToolStripMenuItem.Click
        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
            ARKFolder = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub ScanModFolder(sender As Object, e As EventArgs) Handles ScanModToolStripMenuItem.Click, ToolStripButton5.Click
        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
            ARKFolder = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

End Class
