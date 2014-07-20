'Keirathi

Public Class UpdateForm

    Dim path = "LNP"
    Dim checkAgainDate

    Public Sub New()
        InitializeComponent()
        RemindAgainBox.SelectedIndex = 0
        GetCheckAgainDate()
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Dim url As String = "http://dffd.wimbli.com/file.php?id=7622"
        Process.Start(url)
        Application.Exit()
    End Sub

    Private Sub RemindButton_Click(sender As Object, e As EventArgs) Handles RemindButton.Click
        '0,1,3,7,14,30
        Select Case RemindAgainBox.SelectedIndex
            Case 0
                Me.Close()
            Case 1
                ChangeCheckAgain(DateTime.Today.Date.AddDays(1))
            Case 2
                ChangeCheckAgain(DateTime.Today.Date.AddDays(3))
            Case 3
                ChangeCheckAgain(DateTime.Today.Date.AddDays(7))
            Case 4
                ChangeCheckAgain(DateTime.Today.Date.AddDays(14))
            Case 5
                ChangeCheckAgain(DateTime.Today.Date.AddDays(30))
        End Select
        Me.Close()
    End Sub

    Private Sub ChangeCheckAgain(ByVal day As DateTime)
        Dim file = FileWorking.ReadFile("LNPWin.txt", path)
        FileWorking.ReplaceText(file, checkAgainDate, day)
        FileWorking.SaveFile("LNPWin.txt", path, file)
    End Sub

    Private Sub GetCheckAgainDate()
        FileOpen(1, path & "\LNPWin.txt", OpenMode.Input)
        Dim line As String
        line = LineInput(1)
        Do While Not EOF(1)
            If line.StartsWith("CheckAgain:") Then
                Dim temp = Split(line, " ")
                checkAgainDate = DateTime.Parse(temp(temp.Length - 1))
                FileClose(1)
                Return
            Else
                line = LineInput(1)
            End If
        Loop
        FileClose(1)
    End Sub
End Class