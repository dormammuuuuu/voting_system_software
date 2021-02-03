Imports System.Data.OleDb
Imports System.Data

Public Class SigninPanel

    Private Sub SigninPanel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'If TextBox1.Text = "admin" And TextBox2.Text = "a1" Then

        '    MessageBox.Show("You log-on as administrator.")

        '    With AdminPanel

        '        .Button7.Show()
        '        .Button2.Show()
        '        .Button5.Show()
        '        .Button3.Show()
        '        .Button4.Show()
        '        .Button6.Show()
        '        .Button1.Show()

        '        .Button8.Text = "Log-Out"

        '    End With

        '    Me.Close()


        'ElseIf TextBox1.Text = "jason" And TextBox2.Text = "062108" Then

        '    MessageBox.Show("You log-on as Programmer.")

        '    With AdminPanel

        '        .Button7.Show()
        '        .Button2.Show()
        '        .Button5.Show()
        '        .Button3.Show()
        '        .Button4.Show()
        '        .Button6.Show()

        '        .Button8.Text = "Log-Out"

        '    End With

        '    Me.Close()


        'ElseIf TextBox1.Text = "comelec" And TextBox2.Text = "ssao" Then
        '    MessageBox.Show("You log-on as Board of Election Inspector.")
        '    Me.Close()
        '    AdminPanel.Button8.Text = "Log-Out"
        'Else


        Dim sql As String

        sql = "select * from tbluseraccounts where userusername ='" & TextBox1.Text & "' and userpassword = '" & TextBox2.Text & "'"
        ejbfindthis(sql)
        checkresultuser()

        'End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress

    End Sub

    Private Sub TextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.LostFocus
        Registration.txtStudentId.Text = TextBox1.Text
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button2_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.MouseHover
        Button2.Image = My.Resources.LOGIN
    End Sub

    Private Sub Button2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseLeave
        Button2.Image = My.Resources._default
    End Sub

    Private Sub Button1_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseHover
        Button1.Image = My.Resources.cancel2
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        Button1.Image = My.Resources._default

    End Sub
End Class