Imports System.Data.Odbc
Public Class Login

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then

            MessageBox.Show("Username dan Password Tidak Boleh Kosong", "AYAT", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            Call koneksi()
            Cmd = New OdbcCommand("select * from tb_user where username='" & TextBox1.Text & "' and password='" & TextBox2.Text & "'", conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                Me.Hide()
                index.Show()
            Else
                MessageBox.Show("Password dan Username Salah, Harap Periksa Kembali!!!", "Gagal Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox2.PasswordChar = ""
        Else
            TextBox2.PasswordChar = "*"
        End If
    End Sub
End Class
