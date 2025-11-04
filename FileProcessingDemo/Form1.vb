Imports System.IO

Public Class Form1
    Private Sub ButtonWrite_Click(sender As Object, e As EventArgs) Handles ButtonWrite.Click
        Try
            Dim filePath As String = "sample.txt" ' File Location

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
        Dim filePath As String = "sample.txt"

        Using reader As New StreamReader(filePath)
            Dim content As String = reader.ReadToEnd()
            MessageBox.Show("File Content: " + content)
        End Using
    End Sub
End Class
