Public Class index

    ''==perintah pindah panel di sidebar/menu==
    Sub switchpanel2(ByVal panel As Form)
        Panel2.Controls.Clear()
        panel.TopLevel = False
        Panel2.Controls.Add(panel)
        panel.Show()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        switchpanel2(Dashboard)
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        switchpanel2(diagnosa)
    End Sub

    Private Sub index_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        switchpanel2(Dashboard)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        MessageBox.Show("HaloPakar merupakan Sistem pakar berbentuk aplikasi desktop yang dibuat untuk memenuhi tugas MK Sistem Pakar Semua data dari HaloPakar bersumber dari para Expert dibidangnya." & vbCrLf & "Aplikasi ini dibuat oleh :" & vbCrLf & "Instagram " & vbCrLf & "@udin_ayat", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub





    Private Sub GantiPasswordToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GantiPasswordToolStripMenuItem.Click
        switchpanel2(asma)
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub PenyakitKoleraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PenyakitKoleraToolStripMenuItem.Click
        switchpanel2(Kolera)
    End Sub

    Private Sub PenyakitSARSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PenyakitSARSToolStripMenuItem.Click
        switchpanel2(sars)
    End Sub

    Private Sub PenyakitFluToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PenyakitFluToolStripMenuItem.Click
        switchpanel2(Flu)
    End Sub

    Private Sub PenyakitMuntaberToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PenyakitMuntaberToolStripMenuItem.Click
        switchpanel2(muntaber)
    End Sub
End Class