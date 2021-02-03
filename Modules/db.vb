Module db

    Public Function myconn() As OleDb.OleDbConnection
        Return New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\Documents\VotingSoftwareDb.mdb")
    End Function

End Module
