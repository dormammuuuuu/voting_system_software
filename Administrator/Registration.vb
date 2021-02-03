Public Class Registration

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnsubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsubmit.Click
        Dim sql As String
        If ComboBox1.Text = "-------------Select Candidate--------------" Then
            MsgBox("Please fill all entries")
            With ComboBox1
                .Focus()
                .SelectAll()
            End With
            Exit Sub
        End If
        If ComboBox2.Text = "-------------Select Candidate--------------" Then
            MsgBox("Please fill all entries")
            With ComboBox2
                .Focus()
                .SelectAll()
            End With
            Exit Sub
        End If
        sql = "select * from tblCandidate where cand_name ='" & lblPres.Text & "'"
        ejbfindthis(sql)
        VoteScore()
        sql = "select * from tblCandidate where cand_name ='" & lblVpre.Text & "'"
        ejbfindthis(sql)
        VoteScore()
        ejbupdateVote("UPDATE tblVoters set VoteMonitor = Yes where StudentId = '" & txtStudentId.Text & "'")
        Registration_Load(sender, e)
        Me.Close()
        MainBallot.Show()
    End Sub

    Private Sub lblPres_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblPres.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        lblPres.Text = ComboBox1.Text
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        lblVpre.Text = ComboBox2.Text
    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub btnregister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnregister.Click
        Dim sql As String
        sql = "select * from tblVoters where StudentId='" & txtStudentId.Text & "'"
        ejbfindthis(sql)
        checkRegistration()
    End Sub

    Private Sub Registration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnsubmit.Enabled = False
        Panel1.Hide()
        Panel2.Hide()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    Private Sub txtStudentId_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtStudentId.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
           AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "-" Then
            e.Handled = True
            MessageBox.Show("You can only input numbers!")
        End If
    End Sub

    Private Sub txtStudentId_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStudentId.TextChanged
        txtStudentId.Text = SigninPanel.TextBox1.Text
    End Sub

    Private Sub btnsubmit_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsubmit.MouseHover
        btnsubmit.Image = My.Resources.LOGIN
    End Sub

    Private Sub btnsubmit_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnsubmit.MouseLeave
        btnsubmit.Image = My.Resources._default
    End Sub

    Private Sub btnregister_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnregister.MouseHover
        btnregister.Image = My.Resources.LOGIN
    End Sub

    Private Sub btnregister_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnregister.MouseLeave
        btnregister.Image = My.Resources._default
    End Sub

    Private Sub btnexit_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.MouseHover
        btnexit.Image = My.Resources.cancel2
    End Sub

    Private Sub btnexit_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnexit.MouseLeave
        btnexit.Image = My.Resources._default
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label6_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        SigninPanel.TextBox1.Text = txtStudentId.Text
    End Sub

End Class