Public Class scores

    Private Sub scores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ejbselect("Select cand_name as [Candidate Name], candidacy as [Candidacy], cand_score as [Initial Score] From tblCandidate where candidacy = 'President'")
        fillcandidateScore(DataGridView1)

        ejbselect("Select cand_name as [Candidate Name], candidacy as [Candidacy], cand_score as [Initial Score] From tblCandidate where candidacy = 'Vice-President'")
        fillcandidateScore(DataGridView2)

        ejbselect("Select cand_name as [Candidate Name], candidacy as [Candidacy], cand_score as [Initial Score] From tblCandidate where candidacy = 'Secretary'")
        fillcandidateScore(DataGridView3)

        ejbselect("Select cand_name as [Candidate Name], candidacy as [Candidacy], cand_score as [Initial Score] From tblCandidate where candidacy = 'Assistant Secretary'")
        fillcandidateScore(DataGridView4)

        ejbselect("Select cand_name as [Candidate Name], candidacy as [Candidacy], cand_score as [Initial Score] From tblCandidate where candidacy = 'Treasurer'")
        fillcandidateScore(DataGridView5)

        ejbselect("Select cand_name as [Candidate Name], candidacy as [Candidacy], cand_score as [Initial Score] From tblCandidate where candidacy = 'Assistant Treasurer'")
        fillcandidateScore(DataGridView6)

        ejbselect("Select cand_name as [Candidate Name], candidacy as [Candidacy], cand_score as [Initial Score] From tblCandidate where candidacy = 'P.R.O.'")
        fillcandidateScore(DataGridView7)

        ejbselect("Select cand_name as [Candidate Name], candidacy as [Candidacy], cand_score as [Initial Score] From tblCandidate where candidacy = 'P.O.'")
        fillcandidateScore(DataGridView8)

        ejbselect("Select cand_name as [Candidate Name], candidacy as [Candidacy], cand_score as [Initial Score] From tblCandidate where candidacy = 'ABM Grade 11 Representative'")
        fillcandidateScore(DataGridView9)

        ejbselect("Select cand_name as [Candidate Name], candidacy as [Candidacy], cand_score as [Initial Score] From tblCandidate where candidacy = 'ABM Grade 12 Representative'")
        fillcandidateScore(DataGridView10)

        ejbselect("Select cand_name as [Candidate Name], candidacy as [Candidacy], cand_score as [Initial Score] From tblCandidate where candidacy = 'GAS Grade 11 Representative'")
        fillcandidateScore(DataGridView11)

        ejbselect("Select cand_name as [Candidate Name], candidacy as [Candidacy], cand_score as [Initial Score] From tblCandidate where candidacy = 'GAS Grade 12 Representative'")
        fillcandidateScore(DataGridView12)

        ejbselect("Select cand_name as [Candidate Name], candidacy as [Candidacy], cand_score as [Initial Score] From tblCandidate where candidacy = 'HUMSS Grade 11 Representative'")
        fillcandidateScore(DataGridView13)

        ejbselect("Select cand_name as [Candidate Name], candidacy as [Candidacy], cand_score as [Initial Score] From tblCandidate where candidacy = 'HUMSS Grade 12 Representative'")
        fillcandidateScore(DataGridView14)

        ejbselect("Select cand_name as [Candidate Name], candidacy as [Candidacy], cand_score as [Initial Score] From tblCandidate where candidacy = 'ICT Grade 11 Representative'")
        fillcandidateScore(DataGridView15)

        ejbselect("Select cand_name as [Candidate Name], candidacy as [Candidacy], cand_score as [Initial Score] From tblCandidate where candidacy = 'ICT Grade 12 Representative'")
        fillcandidateScore(DataGridView16)

        ejbselect("Select cand_name as [Candidate Name], candidacy as [Candidacy], cand_score as [Initial Score] From tblCandidate where candidacy = 'STEM Grade 11 Representative'")
        fillcandidateScore(DataGridView17)

        ejbselect("Select cand_name as [Candidate Name], candidacy as [Candidacy], cand_score as [Initial Score] From tblCandidate where candidacy = 'STEM Grade 12 Representative'")
        fillcandidateScore(DataGridView18)

        ejbselect("Select cand_name as [Candidate Name], candidacy as [Candidacy], cand_score as [Initial Score] From tblCandidate where candidacy = 'SPORTS Grade 11 Representative'")
        fillcandidateScore(DataGridView19)

        ejbselect("Select cand_name as [Candidate Name], candidacy as [Candidacy], cand_score as [Initial Score] From tblCandidate where candidacy = 'SPORTS Grade 12 Representative'")
        fillcandidateScore(DataGridView20)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView9_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView9.CellContentClick

    End Sub

    Private Sub DataGridView20_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView20.CellContentClick

    End Sub

    Private Sub DataGridView19_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView19.CellContentClick

    End Sub

    Private Sub DataGridView18_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView18.CellContentClick

    End Sub

    Private Sub DataGridView17_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView17.CellContentClick

    End Sub

    Private Sub DataGridView16_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView16.CellContentClick

    End Sub

    Private Sub DataGridView15_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView15.CellContentClick

    End Sub

    Private Sub DataGridView14_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView14.CellContentClick

    End Sub

    Private Sub DataGridView13_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView13.CellContentClick

    End Sub

    Private Sub DataGridView12_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView12.CellContentClick

    End Sub

    Private Sub DataGridView11_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView11.CellContentClick

    End Sub

    Private Sub DataGridView10_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView10.CellContentClick

    End Sub

    Private Sub DataGridView8_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView8.CellContentClick

    End Sub

    Private Sub DataGridView7_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView7.CellContentClick

    End Sub

    Private Sub DataGridView6_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView6.CellContentClick

    End Sub

    Private Sub DataGridView5_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView5.CellContentClick

    End Sub

    Private Sub DataGridView4_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView4.CellContentClick

    End Sub

    Private Sub DataGridView3_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick

    End Sub

    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label16.Click

    End Sub

    Private Sub Label20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label20.Click

    End Sub

    Private Sub Label18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label18.Click

    End Sub

    Private Sub Label19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label19.Click

    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ejbselect("Select cand_name as [Candidate Name], candidacy as [Candidacy], cand_score as [Initial Score] From tblCandidate where candidacy = 'President'")
        fillcandidateScore(DataGridView1)

        ejbselect("Select cand_name as [Candidate Name], candidacy as [Candidacy], cand_score as [Initial Score] From tblCandidate where candidacy = 'Vice-President'")
        fillcandidateScore(DataGridView2)

        ejbselect("Select cand_name as [Candidate Name], candidacy as [Candidacy], cand_score as [Initial Score] From tblCandidate where candidacy = 'Secretary'")
        fillcandidateScore(DataGridView3)

        ejbselect("Select cand_name as [Candidate Name], candidacy as [Candidacy], cand_score as [Initial Score] From tblCandidate where candidacy = 'Assistant Secretary'")
        fillcandidateScore(DataGridView4)

        ejbselect("Select cand_name as [Candidate Name], candidacy as [Candidacy], cand_score as [Initial Score] From tblCandidate where candidacy = 'Treasurer'")
        fillcandidateScore(DataGridView5)

        ejbselect("Select cand_name as [Candidate Name], candidacy as [Candidacy], cand_score as [Initial Score] From tblCandidate where candidacy = 'Assistant Treasurer'")
        fillcandidateScore(DataGridView6)

        ejbselect("Select cand_name as [Candidate Name], candidacy as [Candidacy], cand_score as [Initial Score] From tblCandidate where candidacy = 'P.R.O.'")
        fillcandidateScore(DataGridView7)

        ejbselect("Select cand_name as [Candidate Name], candidacy as [Candidacy], cand_score as [Initial Score] From tblCandidate where candidacy = 'P.O.'")
        fillcandidateScore(DataGridView8)

        ejbselect("Select cand_name as [Candidate Name], candidacy as [Candidacy], cand_score as [Initial Score] From tblCandidate where candidacy = 'ABM Grade 11 Representative'")
        fillcandidateScore(DataGridView9)

        ejbselect("Select cand_name as [Candidate Name], candidacy as [Candidacy], cand_score as [Initial Score] From tblCandidate where candidacy = 'ABM Grade 12 Representative'")
        fillcandidateScore(DataGridView10)

        ejbselect("Select cand_name as [Candidate Name], candidacy as [Candidacy], cand_score as [Initial Score] From tblCandidate where candidacy = 'GAS Grade 11 Representative'")
        fillcandidateScore(DataGridView11)

        ejbselect("Select cand_name as [Candidate Name], candidacy as [Candidacy], cand_score as [Initial Score] From tblCandidate where candidacy = 'GAS Grade 12 Representative'")
        fillcandidateScore(DataGridView12)

        ejbselect("Select cand_name as [Candidate Name], candidacy as [Candidacy], cand_score as [Initial Score] From tblCandidate where candidacy = 'HUMSS Grade 11 Representative'")
        fillcandidateScore(DataGridView13)

        ejbselect("Select cand_name as [Candidate Name], candidacy as [Candidacy], cand_score as [Initial Score] From tblCandidate where candidacy = 'HUMSS Grade 12 Representative'")
        fillcandidateScore(DataGridView14)

        ejbselect("Select cand_name as [Candidate Name], candidacy as [Candidacy], cand_score as [Initial Score] From tblCandidate where candidacy = 'ICT Grade 11 Representative'")
        fillcandidateScore(DataGridView15)

        ejbselect("Select cand_name as [Candidate Name], candidacy as [Candidacy], cand_score as [Initial Score] From tblCandidate where candidacy = 'ICT Grade 12 Representative'")
        fillcandidateScore(DataGridView16)

        ejbselect("Select cand_name as [Candidate Name], candidacy as [Candidacy], cand_score as [Initial Score] From tblCandidate where candidacy = 'STEM Grade 11 Representative'")
        fillcandidateScore(DataGridView17)

        ejbselect("Select cand_name as [Candidate Name], candidacy as [Candidacy], cand_score as [Initial Score] From tblCandidate where candidacy = 'STEM Grade 12 Representative'")
        fillcandidateScore(DataGridView18)

        ejbselect("Select cand_name as [Candidate Name], candidacy as [Candidacy], cand_score as [Initial Score] From tblCandidate where candidacy = 'SPORTS Grade 11 Representative'")
        fillcandidateScore(DataGridView19)

        ejbselect("Select cand_name as [Candidate Name], candidacy as [Candidacy], cand_score as [Initial Score] From tblCandidate where candidacy = 'SPORTS Grade 12 Representative'")
        fillcandidateScore(DataGridView20)
    End Sub

    Private Sub Button1_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseHover
        Button1.Image = My.Resources.cancel2
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
End Class