Module ejbsqlstatements

    Dim cmd As New OleDb.OleDbCommand
    Dim da As New OleDb.OleDbDataAdapter

    Public Sub ejbfindthis(ByVal sql As String)

        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql
            End With
        Catch ex As Exception

        End Try
        con.Close()
        da.Dispose()

    End Sub

    Public Sub checkWinner()

        Dim table As New DataTable
        Try
            da.SelectCommand = cmd
            da.Fill(table)
            If table.Rows.Count > 0 Then
            Else
            End If
        Catch ex As Exception
        End Try

    End Sub

    Public Sub checkCandidate()

        Dim table As New DataTable
        Try
            da.SelectCommand = cmd
            da.Fill(table)
            If table.Rows.Count > 0 Then
                MsgBox("Candidate Already Exist")
            Else
                ejbinsert("INSERT INTO tblCandidate (cand_name, candidacy, gov_id, cand_score) " & _
                   " VALUES('" & AddCandidate.txtname.Text & "','" & AddCandidate.cbcandidacy.Text & "'," & AddCandidate.cbyrlevel.Text & "," & 0 & ")")
            End If
        Catch ex As Exception
        End Try

    End Sub

    Public Sub checkVoters()

        Dim table As New DataTable
        Try
            da.SelectCommand = cmd
            da.Fill(table)
            If table.Rows.Count > 0 Then
                MsgBox("Student ID already exist")
            Else
                Dim precentoNo As String
                precentoNo = " "
                If Voters.cbyearlevel.Text = 11 Then
                    precentoNo = "YEAR11"
                ElseIf Voters.cbyearlevel.Text = 12 Then
                    precentoNo = "YEAR12"
                End If
                ejbinsert("INSERT INTO tblVoters (StudentId, StudentName, YearLevel, precentoNo) " & _
                        " VALUES('" & Voters.txtstudentID.Text & "','" & Voters.txtstudname.Text & "'," & Voters.cbyearlevel.Text & ",'" & precentoNo & "')")
            End If
        Catch ex As Exception
        End Try

    End Sub

    Public Sub VoteScore()

        Dim table As New DataTable
        Dim candid, score As Integer
        Try
            da.SelectCommand = cmd
            da.Fill(table)
            If table.Rows.Count > 0 Then
                score = table.Rows(0).Item(5) + 1
                candid = table.Rows(0).Item(0)
                ejbupdateVote("UPDATE tblCandidate set cand_score =" & score & " where candidateID = " & candid & "")
            Else
            End If
        Catch ex As Exception
        End Try

    End Sub

    Public Sub checkRegistration()

        Dim table As New DataTable
        Try
            da.SelectCommand = cmd
            da.Fill(table)
            If table.Rows.Count > 0 Then
                Dim studentId As String
                Dim votemonitor As Integer
                studentId = table.Rows(0).Item(4)
                votemonitor = table.Rows(0).Item(5)
                If studentId = 11 And votemonitor = 0 Then
                    MsgBox("Start Voting Now")
                    MsgBox("Vote Wisely!")

                    ejbselect("select distinct [cand_name] from tblCandidate where candidacy = 'President' and a_y ='" & StartVote.ComboBox1.Text & "'")
                    fillcombobox(Registration.ComboBox1)

                    ejbselect("select distinct [cand_name] from tblCandidate where candidacy = 'Vice-President' and a_y ='" & StartVote.ComboBox1.Text & "'")
                    fillcombobox(Registration.ComboBox2)

                    With Registration
                        .Panel1.Show()
                        .Panel2.Show()
                        .btnsubmit.Enabled = True
                        .btnregister.Enabled = False
                        .txtStudentId.Enabled = False
                    End With
                ElseIf studentId = 12 And votemonitor = 0 Then
                    MsgBox("Start Voting Now")
                    MsgBox("Vote Wisely!")

                    ejbselect("select distinct [cand_name] from tblCandidate where candidacy = 'President' and a_y ='" & StartVote.ComboBox1.Text & "'")
                    fillcombobox(Registration.ComboBox1)


                    ejbselect("select distinct [cand_name] from tblCandidate where candidacy = 'Vice-President' and a_y ='" & StartVote.ComboBox1.Text & "'")
                    fillcombobox(Registration.ComboBox2)

                    With Registration
                        .Panel1.Show()
                        .Panel2.Show()
                        .btnsubmit.Enabled = True
                        .btnregister.Enabled = False
                        .txtStudentId.Enabled = False
                    End With
                Else
                    MsgBox("You Are Finished Voting")
                End If
            Else
                MsgBox("Please Register to the Admin")
                With Registration
                End With
            End If
        Catch ex As Exception
        End Try

    End Sub

    Public Sub checkresultuser()

        Dim table As New DataTable
        Try
            da.SelectCommand = cmd
            da.Fill(table)
            If table.Rows.Count > 0 Then
                Dim res, name As String
                Dim u_id As Integer
                u_id = table.Rows(0).Item(0)
                res = table.Rows(0).Item(4)
                name = table.Rows(0).Item(1)
                ejbinsert2("insert into tbllogs(userid, res, uname, oras) values(" & u_id & ",'" & res & "','" & name & "','" & Date.Now & "')")
                If res = "Administrator" Then
                    MsgBox("Welcome! You have logged in as an " & res)
                    SigninPanel.TextBox2.Clear()
                    With AdminPanel
                        .Button7.Hide()
                        .Button10.Show()
                        .Button2.Show()
                        .Button5.Show()
                        .Button3.Show()
                        .Button4.Show()
                        .Button6.Show()
                        .Button1.Show()
                        .PictureBox1.Show()
                        .Button8.Text = "Log Out"
                    End With
                ElseIf res = "Student" Then
                    MessageBox.Show("Welcome! You have logged in as a Student.")
                    SigninPanel.TextBox2.Clear()
                    Tutorial.Show()
                    With AdminPanel
                        .Button10.Hide()
                        .Button7.Show()
                        .Button2.Hide()
                        .Button5.Hide()
                        .Button3.Hide()
                        .Button4.Hide()
                        .Button6.Hide()
                        .Button1.Hide()
                        .PictureBox1.Show()
                        .Button8.Text = "Log Out"
                    End With
                End If
                SigninPanel.Hide()
            Else
                MsgBox("Contact the administrator to register!")
                SigninPanel.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

End Module
