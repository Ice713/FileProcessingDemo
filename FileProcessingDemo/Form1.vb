Imports System.IO

Public Class Form1
    Dim filePath As String = "sample.txt" ' File Location
    Private Sub ButtonWrite_Click(sender As Object, e As EventArgs) Handles ButtonWrite.Click
        Try


            Using writer As New StreamWriter(filePath, True) ' True to append
                writer.WriteLine("Hello, this is a test file!")
                writer.WriteLine("Second line of the text.")
            End Using

            MessageBox.Show("Data written successfully.", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub ButtonRead_Click(sender As Object, e As EventArgs) Handles ButtonRead.Click

        Using reader As New StreamReader(filePath) ' Read the text file
            Dim content As String = reader.ReadToEnd()
            MessageBox.Show("File Content: " + content)
        End Using
    End Sub

    Private Sub ButtonReadPerLine_Click(sender As Object, e As EventArgs) Handles ButtonReadPerLine.Click
        ListBox1.Items.Clear()

        Using reader As New StreamReader(filePath)
            Dim line As String
            line = reader.ReadLine()
            While (line IsNot Nothing)
                ListBox1.Items.Add(line)
                line = reader.ReadLine()
            End While
        End Using
    End Sub
End Class
