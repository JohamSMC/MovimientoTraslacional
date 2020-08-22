Public Class Form3
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub ListFiles(ByVal folderPath As String)
        filesListBox.Items.Clear()

        Dim fileNames = My.Computer.FileSystem.GetFiles(
            folderPath, FileIO.SearchOption.SearchTopLevelOnly, "octave-cli-*")

        For Each fileName As String In fileNames
            filesListBox.Items.Add(fileName)
        Next
    End Sub

    Private Sub browseButton_Click_1(sender As Object, e As EventArgs) Handles browseButton.Click
        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            ListFiles(FolderBrowserDialog1.SelectedPath)
        End If
    End Sub

    Private Sub examineButton_Click_1(sender As Object, e As EventArgs) Handles examineButton.Click
        If filesListBox.SelectedItem Is Nothing Then
            MessageBox.Show("Porfavor seleccione un archivo")
            Exit Sub
        End If
        Dim filePath = filesListBox.SelectedItem.ToString
        If My.Computer.FileSystem.FileExists(filePath) = False Then
            MessageBox.Show("Archivo no encontrado: " & filePath)
            Exit Sub
        End If
        Form1.setPath(filePath)
        Finalize()
        Form1.Show()
    End Sub


End Class