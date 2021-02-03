Public Class SecurityVoteScores

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "admin" Then
            Me.Close()
            ejbupdate("update tblCandidate set cand_score = 0")
            MessageBox.Show("Reset Done!")
        ElseIf TextBox1.Text = "" Then
            MessageBox.Show("Enter PIN CODE")
        Else
            MessageBox.Show("Sorry you are not authorized!")
            Me.Close()
        End If
    End Sub
End Class