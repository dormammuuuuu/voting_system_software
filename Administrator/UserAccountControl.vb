Public Class UserAccountControl

    Dim Watermark As String = "Yes"
    Public Sub displaymember()
        ejbselect("Select *, username as [Name], userusername as [Student ID], usertype as [User Type] From tbluseraccounts")
        filluser(DataGridView1)

    End Sub

    Private Sub itemdatagrid_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        lblid.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        txtname.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        txtuname.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        txtpass.Clear()
        cbtype.SelectedItem = DataGridView1.CurrentRow.Cells(2).Value.ToString

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub txtname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub txtuname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub txtpass_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub txtconfirm_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub cbtype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub btndel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub lblid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtname.KeyPress
        If (e.KeyChar < "A" OrElse e.KeyChar > "Z") _
           And (e.KeyChar < "a" OrElse e.KeyChar > "z") _
            AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
            MessageBox.Show("You can only input letter!")
        End If
    End Sub

    Private Sub txtname_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtname.TextChanged

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        checkLength(txtuname.Text)
        If txtname.Text = "" Or txtuname.Text = "" Or txtconfirm.Text = "" Or cbtype.SelectedItem = "" Or txtpass.Text = "" Then
            MsgBox("Please fill all the informations.", MsgBoxStyle.Information)
            Exit Sub
        End If
        Try
            Dim cn As New OleDb.OleDbConnection
            Dim da As New OleDb.OleDbDataAdapter
            cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\Documents\VotingSoftwareDb.mdb"
            cn.Open()
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = cn
            Dim sql As String
            Dim table As New DataTable
            sql = "select * from tbluseraccounts where userusername ='" & txtuname.Text & "'"
            cmd.CommandText = sql
            da.SelectCommand = cmd
            da.Fill(table)
            If table.Rows.Count > 0 Then
                MsgBox("User already exists!")
            ElseIf txtpass.Text <> txtconfirm.Text Then
                MsgBox("Password confirmation did not match!", MsgBoxStyle.Information)
            Else
                cmd.CommandText = ("INSERT INTO tbluseraccounts (username, userusername, userpassword, usertype) " & _
                          " VALUES('" & txtname.Text & "','" & txtuname.Text & "','" & txtpass.Text & "','" & cbtype.SelectedItem & "')")
                cmd.ExecuteNonQuery()
                cn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
        displaymember()
    End Sub

    Private Sub btndel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndel.Click
        ejbdelete("Delete * from tbluseraccounts where userid= " & lblid.Text & "")
        displaymember()
        Button3_Click(sender, e)
    End Sub

    Private Sub btnedit_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        If txtname.Text = "" Or txtuname.Text = "" Or txtconfirm.Text = "" Or cbtype.SelectedItem = "" Or txtpass.Text = "" Then
            MsgBox("Please fill all the informations.", MsgBoxStyle.Information)
            Exit Sub
        End If
        If txtpass.Text <> txtconfirm.Text Then
            MsgBox("Password confirmation did not match!", MsgBoxStyle.Information)
        Else
            ejbupdate("UPDATE tbluseraccounts set username ='" & txtname.Text & "', userusername = '" & txtuname.Text & "', userpassword = '" & txtpass.Text & "', usertype ='" & cbtype.SelectedItem & "' where userid = " & lblid.Text & "")
            displaymember()
        End If
        Button3_Click(sender, e)
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        clearall(GroupBox1, DataGridView1)
        cbtype.Text = Nothing
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Label6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        If Label6.Text = "Show List of Users" Then
            Me.Height = 526
            displaymember()
            Label6.Text = "Hide list of users"
        ElseIf Label6.Text = "Hide list of users" Then
            Me.Height = 281
            Label6.Text = "Show List of Users"
        End If
    End Sub

    Private Sub cbtype_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbtype.SelectedIndexChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub txtuname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtuname.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
           AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "-" Then
            e.Handled = True
            MessageBox.Show("You can only input numbers!")
        End If
    End Sub

    Private Sub txtuname_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtuname.Leave
        checkLength(txtuname.Text)
    End Sub

    Private Sub checkLength(ByVal Text As String)
        If Not Text.Length > 7 Then
            Label7.Show()
            Label7.Text = "The Student ID must be 8 digits."
            txtuname.Clear()
        Else
            Label7.Hide()
        End If
    End Sub

    Private Sub txtuname_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtuname.TextChanged

    End Sub

    Private Sub txtpass_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpass.TextChanged

    End Sub

    Private Sub txtconfirm_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtconfirm.TextChanged

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub GroupBox1_Enter_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label7.Hide()
        Me.Height = 281
    End Sub

    Private Sub lblid_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblid.Click

    End Sub

    Private Sub Label2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button2_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.MouseHover
        Button2.Image = My.Resources.cancel2

    End Sub

    Private Sub Button2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseLeave
        Button2.Image = My.Resources._default

    End Sub

    Private Sub SearchTextBox_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles SearchTextBox.Enter
        If Watermark = "Yes" Then
            SearchTextBox.Clear()
            SearchTextBox.ForeColor = Color.Black
            Watermark = "No"
        End If
    End Sub

    Private Sub SearchTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchTextBox.TextChanged

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim search As New OleDb.OleDbDataAdapter("select * from tbluseraccounts where [username] = ?", con)
        search.SelectCommand.Parameters.AddWithValue("p0", SearchTextBox.Text)

        Dim search2 As New DataSet()
        If search.Fill(search2, "tbluseraccounts") Then
            Dim view As DataView = search2.Tables(0).DefaultView
            DataGridView1.DataSource = view
        Else
            MsgBox("No Data!")
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        displaymember()
    End Sub

    Private Sub cbyrlevel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class