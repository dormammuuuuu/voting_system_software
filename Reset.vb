Public Class Reset

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Result As Integer = MessageBox.Show("Are you sure you want to reset all scores?", "WARNING", MessageBoxButtons.YesNo)
        If Result = DialogResult.No Then

        End If
        If Result = DialogResult.Yes Then
            SecurityVoteScores.Show()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim Result As Integer = MessageBox.Show("Are you sure you want to reset all votes of user?", "WARNING", MessageBoxButtons.YesNo)
        If Result = DialogResult.No Then

        End If
        If Result = DialogResult.Yes Then
            SecurityVoteMonitor.Show()
        End If
    End Sub

    Private Sub Button1_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseHover
        Button1.Image = My.Resources.LOGIN
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        Button1.Image = My.Resources._default
    End Sub

    Private Sub Button2_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.MouseHover
        Button2.Image = My.Resources.LOGIN
    End Sub

    Private Sub Button2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseLeave
        Button2.Image = My.Resources._default
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button3_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.MouseHover
        Button3.Image = My.Resources.LOGIN
    End Sub

    Private Sub Button3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.MouseLeave
        Button3.Image = My.Resources._default

    End Sub

    Private Sub Reset_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class