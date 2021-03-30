Public Class FileIOForm
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        'Me.Close()
        ReadFile()
    End Sub

    Private Sub GoButton_Click(sender As Object, e As EventArgs) Handles GoButton.Click
        'TODO
        WriteToFile()
    End Sub

    Sub WriteToFile()

        Dim fileNumber As Integer = FreeFile()
        Dim fileName As String = "data.txt"

        FileOpen(fileNumber, fileName, OpenMode.Append)

        Write(fileNumber, TextBox1.Text)
        Write(fileNumber, TextBox2.Text)
        WriteLine(fileNumber, TextBox3.Text)

        FileClose(fileNumber)

    End Sub

    Sub ClearFields()
        'TODO
    End Sub

    Sub ReadFile()
        Dim fileNumber As Integer = FreeFile()
        Dim fileName As String = "data.txt"
        Dim currentRecord As String

        Try
            FileOpen(fileNumber, fileName, OpenMode.Input)
            Do Until EOF(fileNumber)
                Input(fileNumber, currentRecord)
                Console.WriteLine(currentRecord)
                Console.ReadLine()
            Loop
        Catch ex As Exception
            'TODO user pick file
            OpenFileDialog.ShowDialog()
            fileName = OpenFileDialog.FileName
        End Try

        FileClose(fileNumber)

    End Sub

End Class
