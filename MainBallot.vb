Public Class MainBallot

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub ComboBox3_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox3.TextChanged
        lblSec.Text = ComboBox3.Text
    End Sub

    Private Sub ComboBox4_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox4.TextChanged
        lblasec.Text = ComboBox4.Text
    End Sub

    Private Sub ComboBox5_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox5.TextChanged
        lbltreas.Text = ComboBox5.Text
    End Sub

    Private Sub ComboBox6_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox6.TextChanged
        lblatreas.Text = ComboBox6.Text
    End Sub

    Private Sub ComboBox7_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox7.TextChanged
        lblsenpro.Text = ComboBox7.Text
    End Sub

    Private Sub ComboBox8_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox7.TextChanged
        lblpo.Text = ComboBox8.Text
    End Sub

    Private Sub ComboBox9_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox7.TextChanged
        lblabmrep1.Text = ComboBox9.Text
    End Sub

    Private Sub ComboBox10_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox7.TextChanged
        lblabmrep2.Text = ComboBox10.Text
    End Sub

    Private Sub ComboBox11_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox7.TextChanged
        lblgasrep1.Text = ComboBox11.Text
    End Sub

    Private Sub ComboBox12_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox7.TextChanged
        lblgasrep2.Text = ComboBox12.Text
    End Sub

    Private Sub ComboBox13_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox7.TextChanged
        lblhumssrep1.Text = ComboBox13.Text
    End Sub

    Private Sub ComboBox14_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox7.TextChanged
        lblhumssrep2.Text = ComboBox14.Text
    End Sub

    Private Sub ComboBox15_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox7.TextChanged
        lblictrep1.Text = ComboBox15.Text
    End Sub

    Private Sub ComboBox16_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox7.TextChanged
        lblictrep2.Text = ComboBox16.Text
    End Sub

    Private Sub ComboBox17_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox7.TextChanged
        lblstemrep1.Text = ComboBox17.Text
    End Sub

    Private Sub ComboBox18_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox7.TextChanged
        lblstemrep2.Text = ComboBox18.Text
    End Sub

    Private Sub ComboBox19_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox7.TextChanged
        lblsportsrep1.Text = ComboBox19.Text
    End Sub

    Private Sub ComboBox20_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox7.TextChanged
        lblsportsrep2.Text = ComboBox20.Text
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sql As String
        Dim Result As Integer = MessageBox.Show("Are you sure you want to submit your votes?", "Submit Votes", MessageBoxButtons.YesNo)
        If Result = DialogResult.No Then

        End If
        If Result = DialogResult.Yes Then
            If ComboBox3.Text = "-------------Select Candidate--------------" Then
                MsgBox("Please fill all entries")
                With ComboBox3
                    .Focus()
                    .SelectAll()
                End With
                Exit Sub
            End If
            If ComboBox4.Text = "-------------Select Candidate--------------" Then
                MsgBox("Please fill all entries")
                With ComboBox4
                    .Focus()
                    .SelectAll()
                End With
                Exit Sub
            End If
            If ComboBox5.Text = "-------------Select Candidate--------------" Then
                MsgBox("Please fill all entries")
                With ComboBox5
                    .Focus()
                    .SelectAll()
                End With
                Exit Sub
            End If
            If ComboBox6.Text = "-------------Select Candidate--------------" Then
                MsgBox("Please fill all entries")
                With ComboBox6
                    .Focus()
                    .SelectAll()
                End With
                Exit Sub
            End If
            If ComboBox7.Text = "-------------Select Candidate--------------" Then
                MsgBox("Please fill all entries")
                With ComboBox7
                    .Focus()
                    .SelectAll()
                End With
                Exit Sub
            End If
            If ComboBox8.Text = "-------------Select Candidate--------------" Then
                MsgBox("Please fill all entries")
                With ComboBox8
                    .Focus()
                    .SelectAll()
                End With
                Exit Sub
            End If
            If ComboBox9.Text = "-------------Select Candidate--------------" Then
                MsgBox("Please fill all entries")
                With ComboBox9
                    .Focus()
                    .SelectAll()
                End With
                Exit Sub
            End If
            If ComboBox10.Text = "-------------Select Candidate--------------" Then
                MsgBox("Please fill all entries")
                With ComboBox10
                    .Focus()
                    .SelectAll()
                End With
                Exit Sub
            End If
            If ComboBox11.Text = "-------------Select Candidate--------------" Then
                MsgBox("Please fill all entries")
                With ComboBox11
                    .Focus()
                    .SelectAll()
                End With
                Exit Sub
            End If
            If ComboBox12.Text = "-------------Select Candidate--------------" Then
                MsgBox("Please fill all entries")
                With ComboBox12
                    .Focus()
                    .SelectAll()
                End With
                Exit Sub
            End If
            If ComboBox13.Text = "-------------Select Candidate--------------" Then
                MsgBox("Please fill all entries")
                With ComboBox13
                    .Focus()
                    .SelectAll()
                End With
                Exit Sub
            End If
            If ComboBox14.Text = "-------------Select Candidate--------------" Then
                MsgBox("Please fill all entries")
                With ComboBox14
                    .Focus()
                    .SelectAll()
                End With
                Exit Sub
            End If
            If ComboBox15.Text = "-------------Select Candidate--------------" Then
                MsgBox("Please fill all entries")
                With ComboBox15
                    .Focus()
                    .SelectAll()
                End With
                Exit Sub
            End If
            If ComboBox16.Text = "-------------Select Candidate--------------" Then
                MsgBox("Please fill all entries")
                With ComboBox16
                    .Focus()
                    .SelectAll()
                End With
                Exit Sub
            End If
            If ComboBox17.Text = "-------------Select Candidate--------------" Then
                MsgBox("Please fill all entries")
                With ComboBox17
                    .Focus()
                    .SelectAll()
                End With
                Exit Sub
            End If
            If ComboBox18.Text = "-------------Select Candidate--------------" Then
                MsgBox("Please fill all entries")
                With ComboBox18
                    .Focus()
                    .SelectAll()
                End With
                Exit Sub
            End If
            If ComboBox19.Text = "-------------Select Candidate--------------" Then
                MsgBox("Please fill all entries")
                With ComboBox19
                    .Focus()
                    .SelectAll()
                End With
                Exit Sub
            End If
            If ComboBox20.Text = "-------------Select Candidate--------------" Then
                MsgBox("Please fill all entries")
                With ComboBox20
                    .Focus()
                    .SelectAll()
                End With
                Exit Sub
            End If

            sql = "select * from tblCandidate where cand_name ='" & lblSec.Text & "'"
            ejbfindthis(sql)
            VoteScore()

            sql = "select * from tblCandidate where cand_name ='" & lblasec.Text & "'"
            ejbfindthis(sql)
            VoteScore()

            sql = "select * from tblCandidate where cand_name ='" & lbltreas.Text & "'"
            ejbfindthis(sql)
            VoteScore()

            sql = "select * from tblCandidate where cand_name ='" & lblatreas.Text & "'"
            ejbfindthis(sql)
            VoteScore()

            sql = "select * from tblCandidate where cand_name ='" & lblsenpro.Text & "'"
            ejbfindthis(sql)
            VoteScore()

            sql = "select * from tblCandidate where cand_name ='" & lblpo.Text & "'"
            ejbfindthis(sql)
            VoteScore()

            sql = "select * from tblCandidate where cand_name ='" & lblabmrep1.Text & "'"
            ejbfindthis(sql)
            VoteScore()

            sql = "select * from tblCandidate where cand_name ='" & lblabmrep2.Text & "'"
            ejbfindthis(sql)
            VoteScore()

            sql = "select * from tblCandidate where cand_name ='" & lblgasrep1.Text & "'"
            ejbfindthis(sql)
            VoteScore()

            sql = "select * from tblCandidate where cand_name ='" & lblgasrep2.Text & "'"
            ejbfindthis(sql)
            VoteScore()

            sql = "select * from tblCandidate where cand_name ='" & lblhumssrep1.Text & "'"
            ejbfindthis(sql)
            VoteScore()

            sql = "select * from tblCandidate where cand_name ='" & lblhumssrep2.Text & "'"
            ejbfindthis(sql)
            VoteScore()

            sql = "select * from tblCandidate where cand_name ='" & lblictrep1.Text & "'"
            ejbfindthis(sql)
            VoteScore()

            sql = "select * from tblCandidate where cand_name ='" & lblictrep2.Text & "'"
            ejbfindthis(sql)
            VoteScore()

            sql = "select * from tblCandidate where cand_name ='" & lblstemrep1.Text & "'"
            ejbfindthis(sql)
            VoteScore()

            sql = "select * from tblCandidate where cand_name ='" & lblstemrep2.Text & "'"
            ejbfindthis(sql)
            VoteScore()

            sql = "select * from tblCandidate where cand_name ='" & lblsportsrep1.Text & "'"
            ejbfindthis(sql)
            VoteScore()

            sql = "select * from tblCandidate where cand_name ='" & lblsportsrep2.Text & "'"
            ejbfindthis(sql)
            VoteScore()
            Me.Close()
            Registration.Show()
            MsgBox("Congratulations, your vote is counted. Thank you!")
        End If
    End Sub

    Private Sub MainBallot_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ejbselect("select distinct [cand_name] from tblCandidate where candidacy = 'Secretary' and a_y ='" & StartVote.ComboBox1.Text & "'")
        fillcombobox(ComboBox3)

        ejbselect("select distinct [cand_name] from tblCandidate where candidacy = 'Assistant Secretary' and a_y ='" & StartVote.ComboBox1.Text & "'")
        fillcombobox(ComboBox4)

        ejbselect("select distinct [cand_name] from tblCandidate where candidacy = 'Treasurer' and a_y ='" & StartVote.ComboBox1.Text & "'")
        fillcombobox(ComboBox5)

        ejbselect("select distinct [cand_name] from tblCandidate where candidacy = 'Assistant Treasurer' and a_y ='" & StartVote.ComboBox1.Text & "'")
        fillcombobox(ComboBox6)

        ejbselect("select distinct [cand_name] from tblCandidate where candidacy = 'P.R.O.' and a_y ='" & StartVote.ComboBox1.Text & "'")
        fillcombobox(ComboBox7)

        ejbselect("select distinct [cand_name] from tblCandidate where candidacy = 'P.O.' and a_y ='" & StartVote.ComboBox1.Text & "'")
        fillcombobox(ComboBox8)

        ejbselect("select distinct [cand_name] from tblCandidate where candidacy = 'ABM Grade 11 Representative' and a_y ='" & StartVote.ComboBox1.Text & "'")
        fillcombobox(ComboBox9)

        ejbselect("select distinct [cand_name] from tblCandidate where candidacy = 'ABM Grade 12 Representative' and a_y ='" & StartVote.ComboBox1.Text & "'")
        fillcombobox(ComboBox10)

        ejbselect("select distinct [cand_name] from tblCandidate where candidacy = 'GAS Grade 11 Representative' and a_y ='" & StartVote.ComboBox1.Text & "'")
        fillcombobox(ComboBox11)

        ejbselect("select distinct [cand_name] from tblCandidate where candidacy = 'GAS Grade 12 Representative' and a_y ='" & StartVote.ComboBox1.Text & "'")
        fillcombobox(ComboBox12)

        ejbselect("select distinct [cand_name] from tblCandidate where candidacy = 'HUMSS Grade 11 Representative' and a_y ='" & StartVote.ComboBox1.Text & "'")
        fillcombobox(ComboBox13)

        ejbselect("select distinct [cand_name] from tblCandidate where candidacy = 'HUMSS Grade 12 Representative' and a_y ='" & StartVote.ComboBox1.Text & "'")
        fillcombobox(ComboBox14)

        ejbselect("select distinct [cand_name] from tblCandidate where candidacy = 'ICT Grade 11 Representative' and a_y ='" & StartVote.ComboBox1.Text & "'")
        fillcombobox(ComboBox15)

        ejbselect("select distinct [cand_name] from tblCandidate where candidacy = 'ICT Grade 12 Representative' and a_y ='" & StartVote.ComboBox1.Text & "'")
        fillcombobox(ComboBox16)

        ejbselect("select distinct [cand_name] from tblCandidate where candidacy = 'STEM Grade 11 Representative' and a_y ='" & StartVote.ComboBox1.Text & "'")
        fillcombobox(ComboBox17)

        ejbselect("select distinct [cand_name] from tblCandidate where candidacy = 'STEM Grade 12 Representative' and a_y ='" & StartVote.ComboBox1.Text & "'")
        fillcombobox(ComboBox18)

        ejbselect("select distinct [cand_name] from tblCandidate where candidacy = 'SPORTS Grade 11 Representative' and a_y ='" & StartVote.ComboBox1.Text & "'")
        fillcombobox(ComboBox19)

        ejbselect("select distinct [cand_name] from tblCandidate where candidacy = 'SPORTS Grade 12 Representative' and a_y ='" & StartVote.ComboBox1.Text & "'")
        fillcombobox(ComboBox20)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub lblPres_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub lblatreas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblatreas.Click

    End Sub

    Private Sub lblsenpro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblsenpro.Click

    End Sub

    Private Sub Label19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label19.Click

    End Sub

    Private Sub Label18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label18.Click

    End Sub

    Private Sub Label16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label16.Click

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged

    End Sub

    Private Sub ComboBox7_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox7.SelectedIndexChanged

    End Sub

    Private Sub lblpo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblpo.Click

    End Sub

    Private Sub lblabmrep1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblabmrep1.Click

    End Sub

    Private Sub lblsportsrep2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblsportsrep2.Click

    End Sub

    Private Sub lblSec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblSec.Click

    End Sub

    Private Sub lblasec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblasec.Click

    End Sub

    Private Sub lbltreas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbltreas.Click

    End Sub

    Private Sub lblabmrep2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblabmrep2.Click

    End Sub

    Private Sub lblgasrep1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblgasrep1.Click

    End Sub

    Private Sub lblgasrep2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblgasrep2.Click

    End Sub

    Private Sub lblhumssrep1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblhumssrep1.Click

    End Sub

    Private Sub lblhumssrep2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblhumssrep2.Click

    End Sub

    Private Sub lblictrep1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblictrep1.Click

    End Sub

    Private Sub lblictrep2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblictrep2.Click

    End Sub

    Private Sub lblstemrep1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblstemrep1.Click

    End Sub

    Private Sub lblstemrep2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblstemrep2.Click

    End Sub

    Private Sub lblsportsrep1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblsportsrep1.Click

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub ComboBox8_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox8.SelectedIndexChanged
        lblpo.Text = ComboBox8.Text
    End Sub

    Private Sub ComboBox9_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox9.SelectedIndexChanged
        lblabmrep1.Text = ComboBox9.Text
    End Sub

    Private Sub ComboBox10_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox10.SelectedIndexChanged
        lblabmrep2.Text = ComboBox10.Text
    End Sub

    Private Sub ComboBox11_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox11.LostFocus

    End Sub

    Private Sub ComboBox11_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox11.SelectedIndexChanged
        lblgasrep1.Text = ComboBox11.Text
    End Sub

    Private Sub ComboBox12_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox12.SelectedIndexChanged
        lblgasrep2.Text = ComboBox12.Text
    End Sub

    Private Sub ComboBox13_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox13.SelectedIndexChanged
        lblhumssrep1.Text = ComboBox13.Text
    End Sub

    Private Sub ComboBox14_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox14.SelectedIndexChanged
        lblhumssrep2.Text = ComboBox14.Text
    End Sub

    Private Sub ComboBox15_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox15.SelectedIndexChanged
        lblictrep1.Text = ComboBox15.Text
    End Sub

    Private Sub ComboBox16_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox16.SelectedIndexChanged
        lblictrep2.Text = ComboBox16.Text
    End Sub

    Private Sub ComboBox17_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox17.SelectedIndexChanged
        lblstemrep1.Text = ComboBox17.Text
    End Sub

    Private Sub ComboBox18_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox18.SelectedIndexChanged
        lblstemrep2.Text = ComboBox18.Text
    End Sub

    Private Sub ComboBox19_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox19.SelectedIndexChanged
        lblsportsrep1.Text = ComboBox19.Text
    End Sub

    Private Sub ComboBox20_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox20.SelectedIndexChanged
        lblsportsrep2.Text = ComboBox20.Text
    End Sub

    Private Sub GroupBox4_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub GroupBox5_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox5.Enter

    End Sub

    Private Sub GroupBox7_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox7.Enter

    End Sub

    Private Sub GroupBox6_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox6.Enter

    End Sub

    Private Sub GroupBox1_Enter_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub GroupBox9_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox9.Enter

    End Sub

    Private Sub GroupBox10_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox10.Enter

    End Sub

    Private Sub GroupBox11_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox11.Enter

    End Sub

    Private Sub GroupBox12_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox12.Enter

    End Sub

    Private Sub GroupBox13_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox13.Enter

    End Sub

    Private Sub GroupBox14_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox14.Enter

    End Sub

    Private Sub GroupBox15_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox15.Enter

    End Sub

    Private Sub GroupBox16_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox16.Enter

    End Sub

    Private Sub GroupBox17_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox17.Enter

    End Sub

    Private Sub GroupBox18_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox18.Enter

    End Sub

    Private Sub GroupBox19_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox19.Enter

    End Sub

    Private Sub GroupBox20_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox20.Enter

    End Sub

    Private Sub Button1_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseHover
        Button1.Image = My.Resources.LOGIN
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        Button1.Image = My.Resources._default

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class