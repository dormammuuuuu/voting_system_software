Public Class Voters

    Dim Watermark As String = "Yes"
    Private Sub btndel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndel.Click
        ejbdelete("Delete * from tblVoters where votersID= " & lblid.Text & "")
        displaymember()
        Button3_Click(sender, e)
    End Sub

    Public Sub displaymember()

        ejbselect("Select votersID as [Student Number], precentoNo as [Precent], StudentID as [Student ID], StudentName as [Student Name], YearLevel as [Year Level], course as [Strand] , VoteMonitor as [Vote Monitor], email as [Email Address], contact as [Contact], sphoto From tblVoters")
        fillVoters(DataGridView1)

    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        lblid.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        txtstudentID.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        txtstudname.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        cbyearlevel.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
        cbcourse.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
        txtemail.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString
        txtcontact.Text = DataGridView1.CurrentRow.Cells(8).Value.ToString
        btnload_Click(sender, e)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        checkLength(txtstudentID.Text)
        If txtstudentID.Text = "" Or txtstudname.Text = "" Or cbyearlevel.SelectedItem = "" Or txtemail.Text = "" Or txtcontact.Text = "" Or cbcourse.SelectedItem = "" Then
            MsgBox("Please fill all the informations.", MsgBoxStyle.Information)
            Exit Sub
        End If
        Try

            Dim cn As New OleDb.OleDbConnection
            Dim da As New OleDb.OleDbDataAdapter
            cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\Documents\VotingSoftwareDb.mdb"
            cn.Open()
            Dim arrImage() As Byte
            Dim strImage As String
            Dim myMs As New IO.MemoryStream
            '
            If Not IsNothing(PictureBox1.Image) Then
                PictureBox1.Image.Save(myMs, PictureBox1.Image.RawFormat)
                arrImage = myMs.GetBuffer
                strImage = "?"
            Else
                arrImage = Nothing
                strImage = "NULL"
            End If
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = cn
            Dim sql As String
            Dim table As New DataTable
            sql = "select * from tblVoters where studentId ='" & txtstudentID.Text & "'"
            cmd.CommandText = sql
            da.SelectCommand = cmd
            da.Fill(table)
            If table.Rows.Count > 0 Then
                MsgBox("Duplicate Student ID")
            Else
                Dim precentoNo As String
                precentoNo = " "
                If cbyearlevel.Text = 11 Then
                    precentoNo = "YEAR11"
                ElseIf cbyearlevel.Text = 12 Then
                    precentoNo = "YEAR12"
                End If
                cmd.CommandText = "INSERT INTO tblVoters (StudentId, StudentName, YearLevel, precentoNo, email, contact, course, sphoto) VALUES('" & _
                                                       txtstudentID.Text & "','" & txtstudname.Text & "'," & cbyearlevel.Text & ",'" & precentoNo & "','" & txtemail.Text & "','" & txtcontact.Text & "','" & cbcourse.Text & "'," & strImage & ")"

                If strImage = "?" Then
                    cmd.Parameters.Add(strImage, OleDb.OleDbType.Binary).Value = arrImage
                End If
                '
                MsgBox("Data save successfully!")
                cmd.ExecuteNonQuery()
                cn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
        displaymember()
        Button3_Click(sender, e)
        PictureBox1.Image = Nothing

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        clearall(GroupBox1, DataGridView1)
        cbyearlevel.Text = Nothing
        cbcourse.Text = Nothing
        PictureBox1.Image = Nothing
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        If txtstudentID.Text = "" Or txtstudname.Text = "" Or cbyearlevel.SelectedItem = "" Or txtemail.Text = "" Or txtcontact.Text = "" Or cbcourse.SelectedItem = "" Then
            MsgBox("Please fill all the informations.", MsgBoxStyle.Information)
            Exit Sub
        End If
        Dim cn As New OleDb.OleDbConnection
        Dim da As New OleDb.OleDbDataAdapter
        cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\Documents\VotingSoftwareDb.mdb"
        cn.Open()
        'string image update
        Dim arrImage() As Byte
        Dim strImage As String
        Dim myMs As New IO.MemoryStream
        '
        If Not IsNothing(PictureBox1.Image) Then
            PictureBox1.Image.Save(myMs, PictureBox1.Image.RawFormat)
            arrImage = myMs.GetBuffer
            strImage = "?"
        Else
            arrImage = Nothing
            strImage = "NULL"
        End If
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = cn
        cmd.CommandText = "update tblVoters set sphoto =" & strImage & " where votersID = " & lblid.Text & ""
        ejbupdate("UPDATE tblVoters set StudentID ='" & txtstudentID.Text & "' , StudentName = '" & txtstudname.Text & "', YearLevel =" & cbyearlevel.Text & ", email ='" & txtemail.Text & "', contact ='" & txtcontact.Text & "', course ='" & cbcourse.Text & "' where votersID = " & lblid.Text & "")
        If strImage = "?" Then
            cmd.Parameters.Add(strImage, OleDb.OleDbType.Binary).Value = arrImage
        End If
        cmd.ExecuteNonQuery()
        cn.Close()
        PictureBox1.Image = Nothing
        displaymember()
        Button3_Click(sender, e)

    End Sub
    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

        displaymember()

    End Sub
    Private Sub btnload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnload.Click

        Dim cn As New OleDb.OleDbConnection
        cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\Documents\VotingSoftwareDb.mdb"
        cn.Open()
        Dim arrImage() As Byte
        Dim myMS As New IO.MemoryStream
        Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM tblVoters " & _
                                            " WHERE votersID=" & lblid.Text, cn)
        Dim dt As New DataTable
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            'Me.txtName.Text = dt.Rows(0).Item("name") & ""
            If Not IsDBNull(dt.Rows(0).Item("sphoto")) Then
                arrImage = dt.Rows(0).Item("sphoto")
                For Each ar As Byte In arrImage
                    myMS.WriteByte(ar)
                Next
                '
                PictureBox1.Image = System.Drawing.Image.FromStream(myMS)
            End If
            'Me.btnAdd.Enabled = False
        Else
            MsgBox("Record not found!")
        End If

        cn.Close()

    End Sub
    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Me.Close()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        If OpenFileDialog1.ShowDialog = 1 Then
            PictureBox1.Image = System.Drawing.Image.FromFile(OpenFileDialog1.FileName)
        End If

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub lblid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblid.Click

    End Sub

    Private Sub txtstudentID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtstudentID.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
           AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "-" Then
            e.Handled = True
            MessageBox.Show("You can only input numbers!")
        End If
    End Sub

    Private Sub txtstudentID_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtstudentID.Leave
        checkLength(txtstudentID.Text)
    End Sub

    Private Sub checkLength(ByVal Text As String)
        If Not Text.Length > 7 Then
            Label9.Show()
            Label9.Text = "The Student ID must be 8 digits."
            txtstudentID.Clear()
        Else
            Label9.Hide()
        End If
    End Sub
    Private Sub txtstudentID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtstudentID.TextChanged

    End Sub

    Private Sub Voters_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label9.Hide()
        displaymember()
    End Sub

    Private Sub cbcourse_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbcourse.SelectedIndexChanged

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim da As New OleDb.OleDbDataAdapter("select * from tblVoters where [StudentId] = ?", con)
        da.SelectCommand.Parameters.AddWithValue("p0", SearchTextBox.Text)

        Dim ds As New DataSet()
        If da.Fill(ds, "tblVoters") Then
            Dim view As DataView = ds.Tables(0).DefaultView
            DataGridView1.DataSource = view
        Else
            MsgBox("No Data!")
        End If
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

    Private Sub txtstudname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtstudname.KeyPress
        If (e.KeyChar < "A" OrElse e.KeyChar > "Z") _
           And (e.KeyChar < "a" OrElse e.KeyChar > "z") _
            AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
            MessageBox.Show("You can only input letter!")
        End If
    End Sub

    Private Sub txtstudname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtstudname.TextChanged

    End Sub

    Private Sub txtcontact_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcontact.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
           AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "-" Then
            e.Handled = True
            MessageBox.Show("You can only input numbers!")
        End If
    End Sub

    Private Sub txtcontact_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcontact.TextChanged

    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub

    Private Sub Button2_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.MouseHover
        Button2.Image = My.Resources.cancel2

    End Sub

    Private Sub Button2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseLeave
        Button2.Image = My.Resources._default

    End Sub

    Private Sub btndel_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndel.MouseHover
        btndel.Image = My.Resources.cancel2

    End Sub

    Private Sub btndel_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btndel.MouseLeave
        btndel.Image = My.Resources._default

    End Sub

    Private Sub btnedit_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.MouseHover
        btnedit.Image = My.Resources.LOGIN

    End Sub

    Private Sub btnedit_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnedit.MouseLeave
        btnedit.Image = My.Resources._default

    End Sub

    Private Sub Button1_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseHover
        Button1.Image = My.Resources.LOGIN

    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        Button1.Image = My.Resources._default

    End Sub

    Private Sub Button6_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.MouseHover
        Button6.Image = My.Resources.LOGIN

    End Sub

    Private Sub Button6_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button6.MouseLeave
        Button6.Image = My.Resources._default

    End Sub

    Private Sub btnload_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnload.MouseHover
        btnload.Image = My.Resources.LOGIN

    End Sub

    Private Sub btnload_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnload.MouseLeave
        btnload.Image = My.Resources._default

    End Sub

    Private Sub Button3_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.MouseHover
        Button3.Image = My.Resources.LOGIN

    End Sub

    Private Sub Button3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.MouseLeave
        Button3.Image = My.Resources._default

    End Sub
End Class