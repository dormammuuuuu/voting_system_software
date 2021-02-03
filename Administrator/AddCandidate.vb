Public Class AddCandidate

    Dim Watermark As String = "Yes"
    Private Sub cbcandidacy_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbcandidacy.SelectedIndexChanged

        If cbcandidacy.Text = "President" Then
            lblpriority.Text = 1
        ElseIf cbcandidacy.Text = "Vice-President" Then
            lblpriority.Text = 2
        ElseIf cbcandidacy.Text = "Secretary" Then
            lblpriority.Text = 3
        ElseIf cbcandidacy.Text = "Assistant Secretary" Then
            lblpriority.Text = 4
        ElseIf cbcandidacy.Text = "Treasurer" Then
            lblpriority.Text = 5
        ElseIf cbcandidacy.Text = "Assistant Treasurer" Then
            lblpriority.Text = 6
        ElseIf cbcandidacy.Text = "P.R.O." Then
            lblpriority.Text = 7
        ElseIf cbcandidacy.Text = "P.O." Then
            lblpriority.Text = 8
        ElseIf cbcandidacy.Text = "ABM Grade 11 Representative" Then
            lblpriority.Text = 9
        ElseIf cbcandidacy.Text = "ABM Grade 12 Representative" Then
            lblpriority.Text = 10
        ElseIf cbcandidacy.Text = "GAS Grade 11 Representative" Then
            lblpriority.Text = 11
        ElseIf cbcandidacy.Text = "GAS Grade 12 Representative" Then
            lblpriority.Text = 12
        ElseIf cbcandidacy.Text = "HUMSS Grade 11 Representative" Then
            lblpriority.Text = 13
        ElseIf cbcandidacy.Text = "HUMSS Grade 12 Representative" Then
            lblpriority.Text = 14
        ElseIf cbcandidacy.Text = "ICT Grade 11 Representative" Then
            lblpriority.Text = 15
        ElseIf cbcandidacy.Text = "ICT Grade 12 Representative" Then
            lblpriority.Text = 16
        ElseIf cbcandidacy.Text = "STEM Grade 11 Representative" Then
            lblpriority.Text = 17
        ElseIf cbcandidacy.Text = "STEM Grade 12 Representative" Then
            lblpriority.Text = 18
        ElseIf cbcandidacy.Text = "SPORTS Grade 11 Representative" Then
            lblpriority.Text = 19
        ElseIf cbcandidacy.Text = "SPORTS Grade 12 Representative" Then
            lblpriority.Text = 20
        End If
        If Me.cbcandidacy.SelectedIndex = 0 Then
            Me.cbcourse.Enabled = True
            Me.cbyrlevel.Enabled = True
            Me.cbyrlevel.Text = Nothing
            Me.cbcourse.Text = Nothing
        End If
        If Me.cbcandidacy.SelectedIndex = 1 Then
            Me.cbcourse.Enabled = True
            Me.cbyrlevel.Enabled = True
            Me.cbyrlevel.Text = Nothing
            Me.cbcourse.Text = Nothing
        End If
        If Me.cbcandidacy.SelectedIndex = 2 Then
            Me.cbcourse.Enabled = True
            Me.cbyrlevel.Enabled = True
            Me.cbyrlevel.Text = Nothing
            Me.cbcourse.Text = Nothing
        End If
        If Me.cbcandidacy.SelectedIndex = 3 Then
            Me.cbcourse.Enabled = True
            Me.cbyrlevel.Enabled = True
            Me.cbyrlevel.Text = Nothing
            Me.cbcourse.Text = Nothing
        End If
        If Me.cbcandidacy.SelectedIndex = 4 Then
            Me.cbcourse.Enabled = True
            Me.cbyrlevel.Enabled = True
            Me.cbyrlevel.Text = Nothing
            Me.cbcourse.Text = Nothing
        End If
        If Me.cbcandidacy.SelectedIndex = 5 Then
            Me.cbcourse.Enabled = True
            Me.cbyrlevel.Enabled = True
            Me.cbyrlevel.Text = Nothing
            Me.cbcourse.Text = Nothing
        End If
        If Me.cbcandidacy.SelectedIndex = 6 Then
            Me.cbcourse.Enabled = True
            Me.cbyrlevel.Enabled = True
            Me.cbyrlevel.Text = Nothing
            Me.cbcourse.Text = Nothing
        End If
        If Me.cbcandidacy.SelectedIndex = 7 Then
            Me.cbcourse.Enabled = True
            Me.cbyrlevel.Enabled = True
            Me.cbyrlevel.Text = Nothing
            Me.cbcourse.Text = Nothing
        End If
        If Me.cbcandidacy.SelectedIndex = 8 Then
            Me.cbcourse.SelectedIndex = 0
            Me.cbyrlevel.SelectedIndex = 0
            Me.cbcourse.Enabled = False
            Me.cbyrlevel.Enabled = False
        End If
        If Me.cbcandidacy.SelectedIndex = 9 Then
            Me.cbcourse.SelectedIndex = 0
            Me.cbyrlevel.SelectedIndex = 1
            Me.cbcourse.Enabled = False
            Me.cbyrlevel.Enabled = False
        End If
        If Me.cbcandidacy.SelectedIndex = 10 Then
            Me.cbcourse.SelectedIndex = 1
            Me.cbyrlevel.SelectedIndex = 0
            Me.cbcourse.Enabled = False
            Me.cbyrlevel.Enabled = False
        End If
        If Me.cbcandidacy.SelectedIndex = 11 Then
            Me.cbcourse.SelectedIndex = 1
            Me.cbyrlevel.SelectedIndex = 1
            Me.cbcourse.Enabled = False
            Me.cbyrlevel.Enabled = False
        End If
        If Me.cbcandidacy.SelectedIndex = 12 Then
            Me.cbcourse.SelectedIndex = 2
            Me.cbyrlevel.SelectedIndex = 0
            Me.cbcourse.Enabled = False
            Me.cbyrlevel.Enabled = False
        End If
        If Me.cbcandidacy.SelectedIndex = 13 Then
            Me.cbcourse.SelectedIndex = 2
            Me.cbyrlevel.SelectedIndex = 1
            Me.cbcourse.Enabled = False
            Me.cbyrlevel.Enabled = False
        End If
        If Me.cbcandidacy.SelectedIndex = 14 Then
            Me.cbcourse.SelectedIndex = 3
            Me.cbyrlevel.SelectedIndex = 0
            Me.cbcourse.Enabled = False
            Me.cbyrlevel.Enabled = False
        End If
        If Me.cbcandidacy.SelectedIndex = 15 Then
            Me.cbcourse.SelectedIndex = 3
            Me.cbyrlevel.SelectedIndex = 1
            Me.cbcourse.Enabled = False
            Me.cbyrlevel.Enabled = False
        End If
        If Me.cbcandidacy.SelectedIndex = 16 Then
            Me.cbcourse.SelectedIndex = 5
            Me.cbyrlevel.SelectedIndex = 0
            Me.cbcourse.Enabled = False
            Me.cbyrlevel.Enabled = False
        End If
        If Me.cbcandidacy.SelectedIndex = 17 Then
            Me.cbcourse.SelectedIndex = 5
            Me.cbyrlevel.SelectedIndex = 1
            Me.cbcourse.Enabled = False
            Me.cbyrlevel.Enabled = False
        End If
        If Me.cbcandidacy.SelectedIndex = 18 Then
            Me.cbcourse.SelectedIndex = 4
            Me.cbyrlevel.SelectedIndex = 0
            Me.cbcourse.Enabled = False
            Me.cbyrlevel.Enabled = False
        End If
        If Me.cbcandidacy.SelectedIndex = 19 Then
            Me.cbcourse.SelectedIndex = 4
            Me.cbyrlevel.SelectedIndex = 1
            Me.cbcourse.Enabled = False
            Me.cbyrlevel.Enabled = False
        End If
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        lblid.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        txtstudentID.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        txtname.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        cbcandidacy.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        cbcourse.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
        cbyrlevel.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
        lblpriority.Text = DataGridView1.CurrentRow.Cells(9).Value.ToString
        cbay.Text = DataGridView1.CurrentRow.Cells(10).Value.ToString
        Button5_Click(sender, e)

    End Sub

    Public Sub displaymember()

        ejbselect("Select candidateID as [Candidate ID], studentID as [Student Number], cand_name as [Student Name], candidacy as [Candidacy], course as [Strand], gov_id as [Year Level], cand_score, precentoNO as [Precenct], sphoto, priority, a_y From tblCandidate")
        fillcandidate(DataGridView1)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        clearall(GroupBox1, DataGridView1)
        cbcandidacy.Text = Nothing
        cbay.Text = Nothing
        cbyrlevel.Text = Nothing
        cbcourse.Text = Nothing
        PictureBox1.Image = Nothing

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        If OpenFileDialog1.ShowDialog = 1 Then
            PictureBox1.Image = System.Drawing.Image.FromFile(OpenFileDialog1.FileName)
        End If

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        Dim cn As New OleDb.OleDbConnection
        cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\Documents\VotingSoftwareDb.mdb"
        cn.Open()

        Dim arrImage() As Byte
        Dim myMS As New IO.MemoryStream
        Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM tblCandidate " & _
                                            " WHERE candidateID=" & lblid.Text, cn)
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        checkLength(txtstudentID.Text)
        If txtname.Text = "" Or txtstudentID.Text = "" Or txtname.Text = "" Or cbay.SelectedItem = "" Or cbcandidacy.SelectedItem = "" Or cbcourse.SelectedItem = "" Or cbyrlevel.SelectedItem = "" Then
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
            sql = "select * from tblCandidate where studentId ='" & txtstudentID.Text & "'"
            cmd.CommandText = sql
            da.SelectCommand = cmd
            da.Fill(table)
            If table.Rows.Count > 0 Then
                MsgBox("Duplicate Candidate ID")
            Else
                Dim precentoNo As String
                precentoNo = " "
                If cbyrlevel.Text = 11 Then
                    precentoNo = "YEAR11"
                ElseIf cbyrlevel.Text = 12 Then
                    precentoNo = "YEAR12"
                End If
                cmd.CommandText = "INSERT INTO tblCandidate (studentID, cand_name, candidacy, course, gov_id, cand_score, precentoNo, sphoto, priority, a_y) VALUES('" & _
                                                       txtstudentID.Text & "','" & txtname.Text & "','" & cbcandidacy.Text & "','" & cbcourse.Text & "','" & cbyrlevel.Text & "'," & 0 & ",'" & precentoNo & "'," & strImage & "," & lblpriority.Text & ",'" & cbay.Text & "')"
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
        cbcourse.Text = Nothing
        PictureBox1.Image = Nothing

    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        If txtname.Text = "" Or txtstudentID.Text = "" Or txtname.Text = "" Or cbay.SelectedItem = "" Or cbcandidacy.SelectedItem = "" Or cbcourse.SelectedItem = "" Or cbyrlevel.SelectedItem = "" Then
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
        cmd.CommandText = "update tblCandidate set sphoto =" & strImage & " where candidateID = " & lblid.Text & ""
        ejbupdate("UPDATE tblCandidate set studentID ='" & txtstudentID.Text & "' , cand_name = '" & txtname.Text & "', candidacy ='" & cbcandidacy.Text & "', course ='" & cbcourse.Text & "', gov_id =" & cbyrlevel.Text & ", priority =" & lblpriority.Text & ", a_y ='" & cbay.Text & "' where candidateId = " & lblid.Text & "")
        If strImage = "?" Then
            cmd.Parameters.Add(strImage, OleDb.OleDbType.Binary).Value = arrImage
        End If
        cmd.ExecuteNonQuery()
        cn.Close()
        PictureBox1.Image = Nothing
        displaymember()
        Button3_Click(sender, e)

    End Sub

    Private Sub btndel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndel.Click

        ejbdelete("Delete * from tblCandidate where candidateID= " & lblid.Text & "")
        displaymember()
        Button3_Click(sender, e)
        MsgBox("Succesfully Deleted")

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Me.Close()

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

        displaymember()

    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub

    Private Sub lblpriority_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblpriority.Click

    End Sub

    Private Sub lblid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblid.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub AddCandidate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label4.Hide()
        displaymember()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchTextBox.TextChanged

    End Sub

    Private Sub SearchTextBox_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles SearchTextBox.Enter
        If Watermark = "Yes" Then
            SearchTextBox.Clear()
            SearchTextBox.ForeColor = Color.Black
            Watermark = "No"
        End If
    End Sub


    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim da As New OleDb.OleDbDataAdapter("select * from tblCandidate where [studentID] = ?", con)
        da.SelectCommand.Parameters.AddWithValue("p0", SearchTextBox.Text)

        Dim ds As New DataSet()
        If da.Fill(ds, "tblCandidate") Then
            Dim view As DataView = ds.Tables(0).DefaultView
            DataGridView1.DataSource = view
        Else
            MsgBox("No Data!")
        End If
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

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

    Private Sub txtstudentID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtstudentID.TextChanged

    End Sub

    Private Sub checkLength(ByVal Text As String)
        If Not Text.Length > 7 Then
            Label4.Show()
            Label4.Text = "The Student ID must be 8 digits."
            txtstudentID.Clear()
        Else
            Label4.Hide()
        End If
    End Sub

    Private Sub txtname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtname.KeyPress
        If (e.KeyChar < "A" OrElse e.KeyChar > "Z") _
           And (e.KeyChar < "a" OrElse e.KeyChar > "z") _
            AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
            MessageBox.Show("You can only input letter!")
        End If
    End Sub

    Private Sub txtname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtname.TextChanged

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

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

    Private Sub btndel_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndel.MouseLeave
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

    Private Sub Button4_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.MouseHover
        Button4.Image = My.Resources.LOGIN

    End Sub

    Private Sub Button4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.MouseLeave
        Button4.Image = My.Resources._default

    End Sub

    Private Sub Button5_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.MouseHover
        Button5.Image = My.Resources.LOGIN

    End Sub

    Private Sub Button5_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button5.MouseLeave
        Button5.Image = My.Resources._default

    End Sub

    Private Sub Button3_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.MouseHover
        Button3.Image = My.Resources.LOGIN

    End Sub

    Private Sub Button3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.MouseLeave
        Button3.Image = My.Resources._default

    End Sub

    Private Sub cbcourse_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbcourse.SelectedIndexChanged

    End Sub

    Private Sub cbyrlevel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbyrlevel.SelectedIndexChanged

    End Sub

    Private Sub cbay_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbay.SelectedIndexChanged

    End Sub
End Class