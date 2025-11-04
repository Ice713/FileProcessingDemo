Imports System.IO

Public Class Form1
    Private Sub ButtonWrite_Click(sender As Object, e As EventArgs) Handles ButtonWrite.Click
        Try
            Dim filePath As String = "sample.txt" ' File Location

            Using writer As New StreamWriter(filePath)
                writer.WriteLine("Hello, this is a test file!")
                writer.WriteLine("Second line of the text.")
            End Using

            MessageBox.Show("Data written successfully.", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class
