
Imports System.IO

Public Class MainForm
    Private DataFile As StreamReader
    Private HaveUnsavedData As Boolean 'defined on form laod
    Private HaveData As Boolean 'defined on form load
    Private ReadOnly Title As String = "Gamedata file editor"
    Private CurrentPath As String = ""
    Private CurrentFile As String = ""
    Private CurrentLine As Integer
    Private ARKFolder As String = ""
    Private ReadOnly strQuote As Char = Chr(34)
    Private Version As String = "1.1.0"
    Private Application As String = "ark"

    Private testline As String = "  ""Created"": ""2020-06-24T00:00:00.0000000Z"","

    Private Sub UpdateTitle()
        Dim one As String = ""
        Dim two As String = ""

        If HaveData Then two = " - "
        If HaveUnsavedData Then one = "*"

        Me.Text = one & ModName.Text & two & Title
    End Sub

    Private Sub WrongFileMsg()
        MsgBox("Incorrect file or data corruption!" & vbNewLine & "FIle: " & CurrentFile & vbNewLine & " Line: " & CurrentLine, vbOKOnly + vbExclamation, "Attention!")
    End Sub

    Private Function GetLines() As String()
        Dim splits As String = ": " 'strQuote & ": " & strQuote
        Dim line As String
        Dim result As String()

        CurrentLine += 1
        line = DataFile.ReadLine
        If line Is Nothing Then Return Nothing 'eof
        line = line.Trim()  'remove spaces
        line = line.TrimEnd(",") 'remove commas at the end
        line = line.TrimEnd(strQuote) 'remove last quote mark
        line = line.TrimStart(strQuote) 'remove first quote mark

        result = Split(line, splits, 2)

        For l = 0 To result.Count - 1
            result(l) = result(l).TrimEnd(strQuote)
            result(l) = result(l).TrimStart(strQuote)
        Next

        Return result
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

            Status.Text = "Ready"
            Status2.Text = "Empty data generated"

        End If
    End Sub

    Private Function OpenData(FilePath As String) As Boolean
        'Dim Line As String
        Dim lines As String()
        DataFile = My.Computer.FileSystem.OpenTextFileReader(FilePath)
        'Dim LinePos As Integer

        CurrentFile = System.IO.Path.GetFileName(FilePath)
        CurrentPath = FilePath

        Status.Text = "reading " & CurrentFile
        Status2.Text = "Reading header.."

        lines = GetLines()  'skip first bracket

        'read header
        lines = GetLines()

        If lines(0) <> "Application" Then
            WrongFileMsg()
            Return False
        End If

        Application = lines(1)

        If (lines(1) <> "ark") And (lines(1) <> "Ark") Then
            WrongFileMsg()
            Return False
        End If

        lines = GetLines()  'read version
        If lines(0) <> "Version" Then
            WrongFileMsg()
            Return False
        End If

        Version = lines(1)

        lines = GetLines()  'read creation date
        CreationDate.Text = lines(1)

        'read data
        Do
            lines = GetLines() 'read data header

            If Not lines Is Nothing Then
                Select Case lines(0)
                    Case "Engrams"
                        ReadEngrams()
                    Case "Creatures"
                        ReadCreatures()
                    Case "Items"
                        ReadItems()
                    Case "MapSpawners"
                        ReadMapSpawns()
                    Case "SupplyCrates"
                        ReadCrates()
                    Case "Inventories"
                        ReadInventories()

                    Case "GameMaps"
                        ReadGameMaps()
                End Select
            End If

        Loop Until lines Is Nothing

        DataFile.Close()

        HaveData = True
        HaveUnsavedData = False
        Status.Text = "Ready"
        Status2.Text = ""
        Return True
    End Function

    Private Sub ReadCreatures()
        Dim lines As String()
        Dim NameTag As String
        Dim IsSpawnable As Boolean
        Dim IsTameable As String
        Dim ClassName As String
        Dim Description As String

        Status.Text = "Reading Creatures.."

        Do
            lines = GetLines() 'read open bracket
            If lines(0) = "]" Or lines Is Nothing Then
                Return
            End If

            lines = GetLines() 'read name tag
            NameTag = lines(1)
            lines = GetLines() 'read is spawnable
            IsSpawnable = lines(1)
            lines = GetLines() 'read is tameable
            IsTameable = lines(1)
            lines = GetLines() 'read class
            ClassName = lines(1)
            lines = GetLines() 'read desc
            Description = lines(1)
            lines = GetLines() 'read mod name
            ModName.Text = lines(1)

            Creatures.Rows.Add(New String() {NameTag, IsSpawnable, IsTameable, ClassName, Description})

            Status2.Text = ClassName

            GetLines() 'read closing bracket

        Loop

    End Sub

    Private Sub ReadEngrams()
        Dim lines As String()
        Dim Level As Integer
        Dim Points As Integer
        Dim IsTekgram As Boolean
        Dim ClassName As String
        Dim Description As String

        Status.Text = "Reading Engrams.."

        Do
            lines = GetLines() 'read open bracket
            If lines(0) = "]" Or lines Is Nothing Then
                Return
            End If

            lines = GetLines() 'read level
            Level = lines(1)
            lines = GetLines() 'read points
            Points = lines(1)
            lines = GetLines() 'read tekgram
            IsTekgram = lines(1)
            lines = GetLines() 'read class
            ClassName = lines(1)
            lines = GetLines() 'read desc
            Description = lines(1)
            lines = GetLines() 'read mod name
            ModName.Text = lines(1)

            Engrams.Rows.Add(New String() {Level, Points, IsTekgram, ClassName, Description})

            Status2.Text = ClassName

            GetLines() 'read closing bracket

        Loop

    End Sub

    Private Sub ReadItems()
        Dim lines As String()
        Dim Category As String
        Dim IsHarvestable As Boolean
        Dim ClassName As String
        Dim Description As String

        Status.Text = "Reading Items.."

        Do
            lines = GetLines() 'read open bracket
            If lines(0) = "]" Or lines Is Nothing Then
                Return
            End If

            lines = GetLines() 'read Category
            Category = lines(1)
            lines = GetLines() 'read Is Harvestable
            IsHarvestable = lines(1)
            lines = GetLines() 'read class
            ClassName = lines(1)
            lines = GetLines() 'read desc
            Description = lines(1)
            lines = GetLines() 'read mod name
            ModName.Text = lines(1)

            Items.Rows.Add(New String() {Category, IsHarvestable, ClassName, Description})

            Status2.Text = ClassName

            GetLines() 'read closing bracket

        Loop

    End Sub

    Private Sub ReadMapSpawns()
        Dim lines As String()
        Dim ClassName As String
        Dim Description As String

        Status.Text = "Reading Map Spawners.."

        Do
            lines = GetLines() 'read open bracket
            If lines(0) = "]" Or lines Is Nothing Then
                Return
            End If

            lines = GetLines() 'read class
            ClassName = lines(1)
            lines = GetLines() 'read desc
            Description = lines(1)
            lines = GetLines() 'read mod name
            ModName.Text = lines(1)

            MapSpawns.Rows.Add(New String() {ClassName, Description})

            Status2.Text = ClassName

            GetLines() 'read closing bracket

        Loop

    End Sub

    Private Sub ReadCrates()
        Dim lines As String()
        Dim ClassName As String
        Dim Description As String

        Status.Text = "Reading Supply Crates.."

        Do
            lines = GetLines() 'read open bracket
            If lines(0) = "]" Or lines Is Nothing Then
                Return
            End If

            lines = GetLines() 'read class
            ClassName = lines(1)
            lines = GetLines() 'read desc
            Description = lines(1)
            lines = GetLines() 'read mod name
            ModName.Text = lines(1)

            SupplyCrates.Rows.Add(New String() {ClassName, Description})

            Status2.Text = ClassName

            GetLines() 'read closing bracket

        Loop

    End Sub

    Private Sub ReadInventories()
        Dim lines As String()
        Dim ClassName As String
        Dim Description As String

        Status.Text = "Reading Inventories.."

        Do
            lines = GetLines() 'read open bracket
            If lines(0) = "]" Or lines Is Nothing Then
                Return
            End If

            lines = GetLines() 'read class
            ClassName = lines(1)
            lines = GetLines() 'read desc
            Description = lines(1)
            lines = GetLines() 'read mod name
            ModName.Text = lines(1)

            Inventories.Rows.Add(New String() {ClassName, Description})

            Status2.Text = ClassName

            GetLines() 'read closing bracket

        Loop

    End Sub

    Private Sub ReadGameMaps()
        Dim lines As String()
        Dim IsSotF As Boolean
        Dim ClassName As String
        Dim Description As String

        Status.Text = "Reading Game Maps.."

        Do
            lines = GetLines() 'read open bracket
            If lines(0) = "]" Or lines Is Nothing Then
                Return
            End If

            lines = GetLines() 'read is SotF
            IsSotF = lines(1)
            lines = GetLines() 'read class
            ClassName = lines(1)
            lines = GetLines() 'read desc
            Description = lines(1)
            lines = GetLines() 'read mod name
            ModName.Text = lines(1)

            GameMaps.Rows.Add(New String() {IsSotF, ClassName, Description})

            Status2.Text = ClassName

            GetLines() 'read closing bracket

        Loop

    End Sub

    Private Function SaveData(FilePath As String, FileName As String) As Boolean

        HaveUnsavedData = False
        Return True
    End Function

    Private Function ScanData(FolderPath As String) As Boolean

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Select Case TabControl1.SelectedIndex
            Case 0
                Creatures.Rows.Add()
            Case 1
                Engrams.Rows.Add()
            Case 2
                Items.Rows.Add()
            Case 3
                MapSpawns.Rows.Add()
            Case 4
                SupplyCrates.Rows.Add()
            Case 5
                Inventories.Rows.Add()
            Case 6
                GameMaps.Rows.Add()
        End Select
    End Sub

    Private Sub Creatures_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles Creatures.RowPostPaint, Engrams.RowPostPaint, SupplyCrates.RowPostPaint, MapSpawns.RowPostPaint, Items.RowPostPaint, Inventories.RowPostPaint, GameMaps.RowPostPaint
        Dim strRowNumber As String = (e.RowIndex + 1).ToString

        Dim size As SizeF = e.Graphics.MeasureString(strRowNumber, Me.Font)
        ' If e.RowHeadersWidth < CInt((size.Width + 20)) Then
        'e.RowHeadersWidth = CInt((size.Width + 20))
        'End If
        Dim b As Brush = SystemBrushes.ControlText
        e.Graphics.DrawString(strRowNumber, Me.Font, b, e.RowBounds.Location.X + 15,
                             e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2))

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim splits As String = strQuote & ": " & strQuote
        Dim Line As String
        Dim lines As String()
        Line = testline
        Status2.Text = Line
        'Line = Line.Replace(strQuote, "") 'remove quote marks
        Line = Line.Trim()  'remove spaces
        Line = Line.TrimEnd(",") 'remove commas at the end
        Line = Line.TrimEnd(strQuote) 'remove last quote mark
        Line = Line.TrimStart(strQuote) 'remove first quote mark
        lines = Split(Line, splits, 2)
        MsgBox(lines(1), vbOKOnly, lines(0))

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Select Case TabControl1.SelectedIndex
            Case 0 'Creatures
                For Each row As DataGridViewRow In Creatures.SelectedRows
                    Creatures.Rows.Remove(row)
                Next
            Case 1 'Engrams
                For Each row As DataGridViewRow In Engrams.SelectedRows
                    Engrams.Rows.Remove(row)
                Next
            Case 2 'Items
                For Each row As DataGridViewRow In Items.SelectedRows
                    Items.Rows.Remove(row)
                Next
            Case 3 'MapSpawns
                For Each row As DataGridViewRow In MapSpawns.SelectedRows
                    MapSpawns.Rows.Remove(row)
                Next
            Case 4 'SupplyCrates
                For Each row As DataGridViewRow In SupplyCrates.SelectedRows
                    SupplyCrates.Rows.Remove(row)
                Next
            Case 5 'Inventories
                For Each row As DataGridViewRow In Inventories.SelectedRows
                    Inventories.Rows.Remove(row)
                Next
            Case 6 'GameMaps
                For Each row As DataGridViewRow In GameMaps.SelectedRows
                    GameMaps.Rows.Remove(row)
                Next
        End Select
    End Sub

    Private Sub Creatures_Rows() Handles Creatures.RowsAdded, Creatures.RowsRemoved
        TabCreatures.Text = ("Creatures (" & Creatures.Rows.Count & ")")
    End Sub

    Private Sub Engrams_Rows() Handles Engrams.RowsAdded, Engrams.RowsRemoved
        TabEngrams.Text = ("Engrams (" & Engrams.Rows.Count & ")")
    End Sub

    Private Sub Items_Rows() Handles Items.RowsAdded, Items.RowsRemoved
        TabItems.Text = ("Items (" & Items.Rows.Count & ")")
    End Sub

    Private Sub MapSpawns_Rows() Handles MapSpawns.RowsAdded, MapSpawns.RowsRemoved
        TabMapSpawns.Text = ("MapSpawners (" & MapSpawns.Rows.Count & ")")
    End Sub

    Private Sub SupplyCrates_Rows() Handles SupplyCrates.RowsAdded, SupplyCrates.RowsRemoved
        TabCrates.Text = ("SupplyCrates (" & SupplyCrates.Rows.Count & ")")
    End Sub

    Private Sub Inventories_Rows() Handles Inventories.RowsAdded, Inventories.RowsRemoved
        TabInventories.Text = ("Inventories (" & Inventories.Rows.Count & ")")
    End Sub

    Private Sub GameMaps_Rows() Handles GameMaps.RowsAdded, GameMaps.RowsRemoved
        TabGameMaps.Text = ("GameMaps (" & GameMaps.Rows.Count & ")")
    End Sub

End Class
