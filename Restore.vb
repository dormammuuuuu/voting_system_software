Public Class Restore

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        OpenFileDialog1.Filter = "Access *.mdb | *.mdb"
        If (OpenFileDialog1.ShowDialog() = DialogResult.OK) Then
            TextBox1.Text = OpenFileDialog1.FileName.ToString
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim restore As Integer = MessageBox.Show("Are you sure you want to restore your database? It will overwrite your database since the backup have made.", "WARNING", MessageBoxButtons.YesNo)
        If restore = DialogResult.No Then

        End If
        If restore = DialogResult.Yes Then
            If TextBox1.Text = "" Then
                MsgBox("Please fill all the entries.", MsgBoxStyle.Information)
                Exit Sub
            End If
            Try
                My.Computer.FileSystem.CopyFile(TextBox1.Text, "C:\Users\user\Documents\VotingSoftwareDb.mdb", True)
                MsgBox("Restore Success!")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Restore_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class