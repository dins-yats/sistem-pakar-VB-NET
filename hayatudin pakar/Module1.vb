Imports System.Data.Odbc
Module Module1
    Public conn As OdbcConnection
    Public Da As OdbcDataAdapter
    Public Ds As DataSet
    Public Rd As OdbcDataReader
    Public Cmd As OdbcCommand
    Public MyDB As String
    Public Sub koneksi()
        MyDB = "driver={mysql ODBC 3.51 Driver};database=db_pakar;server=localhost;uid=root"
        conn = New OdbcConnection(MyDB)
        If conn.State = ConnectionState.Closed Then conn.Open()
    End Sub
End Module
