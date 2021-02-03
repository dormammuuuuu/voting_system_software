Public Class Backup

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub Backup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim data As String = Now().Day.ToString & "-" & Now().Month.ToString & "-" & Now().Year.ToString
        TextBox1.Text = data
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox2.Text = "" Or TextBox6.Text = "" Then
            MsgBox("Please fill all the entries.", MsgBoxStyle.Information)
            Exit Sub
        End If
        Try
            Dim cn As New OleDb.OleDbConnection
            cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\Documents\VotingSoftwareDb.mdb"
            Dim data As String = Now().Day.ToString & "-" & Now().Month.ToString & "-" & Now().Year.ToString
            TextBox1.Text = data
            TextBox5.Text = TextBox2.Text + "\" + TextBox1.Text
            My.Computer.FileSystem.CreateDirectory(TextBox5.Text)
            TextBox7.Text = TextBox5.Text + "\" + TextBox6.Text + ".mdb"
            My.Computer.FileSystem.CopyFile("C:\Users\user\Documents\VotingSoftwareDb.mdb", TextBox7.Text, True)
            MsgBox("Backup Success!")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            TextBox2.Text = FolderBrowserDialog1.SelectedPath
            TextBox5.Text = TextBox2.Text + "\" + TextBox1.Text
        End If
    End Sub
End Class