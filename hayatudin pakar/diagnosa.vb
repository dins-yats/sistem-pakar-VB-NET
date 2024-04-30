Public Class diagnosa
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If CheckBox1.Checked = True And
            CheckBox7.Checked = True And
            CheckBox8.Checked = True And
            CheckBox9.Checked = True Then
            TextBox1.Text = " Penyakit Asma"
            TextBox2.Text = " Menjalani vaksinasi influenza dan pneumonia secara teratur Mengetahui pemicu munculnya gejala asma dan menghindarinya Melakukan pemeriksaan ke dokter bila gejala tidak juga membaik setelah menjalani pengobatan"
        End If
        If CheckBox3.Checked = True And
            CheckBox4.Checked = True And
            CheckBox5.Checked = True And
            CheckBox6.Checked = True Then
            TextBox1.Text = " Penyakit Flu"
            TextBox2.Text = " Flu ringan bisa diatasi dengan banyak beristirahat, mengonsumsi makanan sehat yang mengandung vitamin C, dan banyak minum. Namun, bila gejalanya berat,segera lakukan pemeriksaan ke dokter agar diberikan obat untuk mempercepat kesembuhan dan mencegah komplikasi."


        End If
        If CheckBox15.Checked = True And
            CheckBox14.Checked = True And
            CheckBox17.Checked = True And
            CheckBox18.Checked = True Then
            TextBox1.Text = " Penyakit Kolera"
            TextBox2.Text = " Obat antibiotik dan Suplemen zinc"
        End If

        If CheckBox6.Checked = True And
         CheckBox11.Checked = True And
         CheckBox17.Checked = True And
         CheckBox17.Checked = True And
         CheckBox3.Checked = True Then
            TextBox1.Text = " Penyakit Muntaber"
            TextBox2.Text = " Paracetamol atau ibuprofen untuk meredakan nyeri ,Dimenhydrinate atau meclizine untuk meredakan mual,Loperamide atau bismuth subsalicylate, untuk meredakan diare"
        End If


        If CheckBox3.Checked = True And
            CheckBox7.Checked = True And
            CheckBox10.Checked = True And
            CheckBox12.Checked = True And
            CheckBox13.Checked = True And
            CheckBox14.Checked = True And
            CheckBox15.Checked = True And
            CheckBox16.Checked = True Then
            TextBox1.Text = " SARS"
            TextBox2.Text = " belum ditemukan obat yang bisa menyembuhkan SARS hingga saat ini. Jadi tujuan pengobatan SARS dilakukan adalah untuk membantu meningkatkan sistem kekebalan tubuh kamu, sehingga mampu menjinakkan virus tersebut. Pengobatan yang biasanya dilakukan, antara lain dengan memastikan ventilasi memadai, memberikan oksigen, fisioterapi, antiobiotik, dan obat-obatan antivirus. "
        End If
    End Sub


    Sub awal()
        CheckBox1.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        CheckBox6.Checked = False
        CheckBox7.Checked = False
        CheckBox8.Checked = False
        CheckBox9.Checked = False
        CheckBox10.Checked = False
        CheckBox11.Checked = False
        CheckBox12.Checked = False
        CheckBox13.Checked = False
        CheckBox14.Checked = False
        CheckBox15.Checked = False
        CheckBox16.Checked = False
        CheckBox17.Checked = False
        CheckBox18.Checked = False
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call awal()
    End Sub

    Private Sub CheckBox7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox7.CheckedChanged

    End Sub




    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub
    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class