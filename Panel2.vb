Imports System.Windows.Forms
Imports System.Drawing
Imports System.Media

Public Class Panel2
    Inherits Panel

    ' Constructor untuk Panel2
    Public Sub New()
        ' Set Dock property agar panel memenuhi form
        Me.Dock = DockStyle.Fill

        ' Anda bisa menambahkan elemen lain sesuai kebutuhan untuk Panel2
        Me.BackColor = Color.LightBlue ' Contoh: Mengubah warna background Panel2

        ' Tambahkan elemen lain sesuai dengan kebutuhan game
        Dim materiLabel As New Label()
        materiLabel.Name = "materiLabel"
        materiLabel.Text = "Ini adalah Materi Game"
        materiLabel.Font = New Font("Arial", 24, FontStyle.Bold)
        materiLabel.ForeColor = Color.ForestGreen
        materiLabel.BackColor = Color.Transparent
        materiLabel.AutoSize = False ' Matikan AutoSize
        materiLabel.Width = 800 ' Lebar label 100% dari panel
        materiLabel.Height = 60 ' Sesuaikan tinggi label sesuai kebutuhan
        materiLabel.TextAlign = ContentAlignment.MiddleCenter
        materiLabel.Location = New Point(0, 30)
        Me.Controls.Add(materiLabel)

        ' Membuat tombol 1, 2, 3, 4, 5
        Dim btnSatu As New Button()
        btnSatu.Text = "1"
        btnSatu.Size = New Size(100, 100)
        btnSatu.BackColor = Color.Brown
        btnSatu.ForeColor = Color.White
        btnSatu.Cursor = Cursors.Hand
        ' Tambahkan handler untuk MouseEnter dan MouseLeave
        AddHandler btnSatu.MouseEnter, Sub(sender, e)
                                           btnSatu.Font = New Font(btnSatu.Font.FontFamily, 40, FontStyle.Bold) ' Perbesar font
                                           btnSatu.BackColor = Color.DarkRed ' Ubah warna juga (opsional)
                                       End Sub
        AddHandler btnSatu.MouseLeave, Sub(sender, e)
                                           btnSatu.Font = New Font(btnSatu.Font.FontFamily, 36, FontStyle.Bold) ' Kembalikan font ke default
                                           btnSatu.BackColor = Color.Brown ' Kembalikan warna
                                       End Sub
        AddHandler btnSatu.Click, AddressOf BtnSatu_Click
        Me.Controls.Add(btnSatu)

        Dim btnDua As New Button()
        btnDua.Text = "2"
        btnDua.Size = New Size(100, 100)
        btnDua.BackColor = Color.Brown
        btnDua.ForeColor = Color.White
        btnDua.Cursor = Cursors.Hand
        ' Tambahkan handler untuk MouseEnter dan MouseLeave
        AddHandler btnDua.MouseEnter, Sub(sender, e)
                                          btnDua.Font = New Font(btnDua.Font.FontFamily, 40, FontStyle.Bold) ' Perbesar font
                                          btnDua.BackColor = Color.DarkRed ' Ubah warna juga (opsional)
                                      End Sub
        AddHandler btnDua.MouseLeave, Sub(sender, e)
                                          btnDua.Font = New Font(btnDua.Font.FontFamily, 36, FontStyle.Bold) ' Kembalikan font ke default
                                          btnDua.BackColor = Color.Brown ' Kembalikan warna
                                      End Sub
        AddHandler btnDua.Click, AddressOf BtnDua_Click
        Me.Controls.Add(btnDua)

        Dim btnTiga As New Button()
        btnTiga.Text = "3"
        btnTiga.Size = New Size(100, 100)
        btnTiga.BackColor = Color.Brown
        btnTiga.ForeColor = Color.White
        btnTiga.Cursor = Cursors.Hand
        ' Tambahkan handler untuk MouseEnter dan MouseLeave
        AddHandler btnTiga.MouseEnter, Sub(sender, e)
                                           btnTiga.Font = New Font(btnTiga.Font.FontFamily, 40, FontStyle.Bold) ' Perbesar font
                                           btnTiga.BackColor = Color.DarkRed ' Ubah warna juga (opsional)
                                       End Sub
        AddHandler btnTiga.MouseLeave, Sub(sender, e)
                                           btnTiga.Font = New Font(btnTiga.Font.FontFamily, 36, FontStyle.Bold) ' Kembalikan font ke default
                                           btnTiga.BackColor = Color.Brown ' Kembalikan warna
                                       End Sub
        AddHandler btnTiga.Click, AddressOf BtnTiga_Click
        Me.Controls.Add(btnTiga)

        Dim btnEmpat As New Button()
        btnEmpat.Text = "4"
        btnEmpat.Size = New Size(100, 100)
        btnEmpat.BackColor = Color.Brown
        btnEmpat.ForeColor = Color.White
        btnEmpat.Cursor = Cursors.Hand
        ' Tambahkan handler untuk MouseEnter dan MouseLeave
        AddHandler btnEmpat.MouseEnter, Sub(sender, e)
                                            btnEmpat.Font = New Font(btnEmpat.Font.FontFamily, 40, FontStyle.Bold) ' Perbesar font
                                            btnEmpat.BackColor = Color.DarkRed ' Ubah warna juga (opsional)
                                        End Sub
        AddHandler btnEmpat.MouseLeave, Sub(sender, e)
                                            btnEmpat.Font = New Font(btnEmpat.Font.FontFamily, 36, FontStyle.Bold) ' Kembalikan font ke default
                                            btnEmpat.BackColor = Color.Brown ' Kembalikan warna
                                        End Sub
        AddHandler btnEmpat.Click, AddressOf BtnEmpat_Click
        Me.Controls.Add(btnEmpat)

        Dim btnLima As New Button()
        btnLima.Text = "5"
        btnLima.Size = New Size(100, 100)
        btnLima.BackColor = Color.Brown
        btnLima.ForeColor = Color.White
        btnLima.Cursor = Cursors.Hand
        ' Tambahkan handler untuk MouseEnter dan MouseLeave
        AddHandler btnLima.MouseEnter, Sub(sender, e)
                                           btnLima.Font = New Font(btnLima.Font.FontFamily, 40, FontStyle.Bold) ' Perbesar font
                                           btnLima.BackColor = Color.DarkRed ' Ubah warna juga (opsional)
                                       End Sub
        AddHandler btnLima.MouseLeave, Sub(sender, e)
                                           btnLima.Font = New Font(btnLima.Font.FontFamily, 36, FontStyle.Bold) ' Kembalikan font ke default
                                           btnLima.BackColor = Color.Brown ' Kembalikan warna
                                       End Sub
        AddHandler btnLima.Click, AddressOf BtnLima_Click
        Me.Controls.Add(btnLima)

        ' Membuat tombol keenam sampai kesepuluh
        Dim btnEnam As New Button()
        btnEnam.Text = "6"
        btnEnam.Size = New Size(100, 100)
        btnEnam.BackColor = Color.Brown
        btnEnam.ForeColor = Color.White
        btnEnam.Cursor = Cursors.Hand
        ' Tambahkan handler untuk MouseEnter dan MouseLeave
        AddHandler btnEnam.MouseEnter, Sub(sender, e)
                                           btnEnam.Font = New Font(btnEnam.Font.FontFamily, 40, FontStyle.Bold) ' Perbesar font
                                           btnEnam.BackColor = Color.DarkRed ' Ubah warna juga (opsional)
                                       End Sub
        AddHandler btnEnam.MouseLeave, Sub(sender, e)
                                           btnEnam.Font = New Font(btnEnam.Font.FontFamily, 36, FontStyle.Bold) ' Kembalikan font ke default
                                           btnEnam.BackColor = Color.Brown ' Kembalikan warna
                                       End Sub
        AddHandler btnEnam.Click, AddressOf BtnEnam_Click
        Me.Controls.Add(btnEnam)

        Dim btnTujuh As New Button()
        btnTujuh.Text = "7"
        btnTujuh.Size = New Size(100, 100)
        btnTujuh.BackColor = Color.Brown
        btnTujuh.ForeColor = Color.White
        btnTujuh.Cursor = Cursors.Hand
        ' Tambahkan handler untuk MouseEnter dan MouseLeave
        AddHandler btnTujuh.MouseEnter, Sub(sender, e)
                                            btnTujuh.Font = New Font(btnTujuh.Font.FontFamily, 40, FontStyle.Bold) ' Perbesar font
                                            btnTujuh.BackColor = Color.DarkRed ' Ubah warna juga (opsional)
                                        End Sub
        AddHandler btnTujuh.MouseLeave, Sub(sender, e)
                                            btnTujuh.Font = New Font(btnTujuh.Font.FontFamily, 36, FontStyle.Bold) ' Kembalikan font ke default
                                            btnTujuh.BackColor = Color.Brown ' Kembalikan warna
                                        End Sub
        AddHandler btnTujuh.Click, AddressOf BtnTujuh_Click
        Me.Controls.Add(btnTujuh)

        Dim btnDelapan As New Button()
        btnDelapan.Text = "8"
        btnDelapan.Size = New Size(100, 100)
        btnDelapan.BackColor = Color.Brown
        btnDelapan.ForeColor = Color.White
        btnDelapan.Cursor = Cursors.Hand
        ' Tambahkan handler untuk MouseEnter dan MouseLeave
        AddHandler btnDelapan.MouseEnter, Sub(sender, e)
                                              btnDelapan.Font = New Font(btnDelapan.Font.FontFamily, 40, FontStyle.Bold) ' Perbesar font
                                              btnDelapan.BackColor = Color.DarkRed ' Ubah warna juga (opsional)
                                          End Sub
        AddHandler btnDelapan.MouseLeave, Sub(sender, e)
                                              btnDelapan.Font = New Font(btnDelapan.Font.FontFamily, 36, FontStyle.Bold) ' Kembalikan font ke default
                                              btnDelapan.BackColor = Color.Brown ' Kembalikan warna
                                          End Sub
        AddHandler btnDelapan.Click, AddressOf BtnDelapan_Click
        Me.Controls.Add(btnDelapan)

        Dim btnSembilan As New Button()
        btnSembilan.Text = "9"
        btnSembilan.Size = New Size(100, 100)
        btnSembilan.BackColor = Color.Brown
        btnSembilan.ForeColor = Color.White
        btnSembilan.Cursor = Cursors.Hand
        ' Tambahkan handler untuk MouseEnter dan MouseLeave
        AddHandler btnSembilan.MouseEnter, Sub(sender, e)
                                               btnSembilan.Font = New Font(btnSembilan.Font.FontFamily, 40, FontStyle.Bold) ' Perbesar font
                                               btnSembilan.BackColor = Color.DarkRed ' Ubah warna juga (opsional)
                                           End Sub
        AddHandler btnSembilan.MouseLeave, Sub(sender, e)
                                               btnSembilan.Font = New Font(btnSembilan.Font.FontFamily, 36, FontStyle.Bold) ' Kembalikan font ke default
                                               btnSembilan.BackColor = Color.Brown ' Kembalikan warna
                                           End Sub
        AddHandler btnSembilan.Click, AddressOf BtnSembilan_Click
        Me.Controls.Add(btnSembilan)

        Dim btnSepuluh As New Button()
        btnSepuluh.Text = "10"
        btnSepuluh.Size = New Size(100, 100)
        btnSepuluh.BackColor = Color.Brown
        btnSepuluh.ForeColor = Color.White
        btnSepuluh.Cursor = Cursors.Hand
        ' Tambahkan handler untuk MouseEnter dan MouseLeave
        AddHandler btnSepuluh.MouseEnter, Sub(sender, e)
                                              btnSepuluh.Font = New Font(btnSepuluh.Font.FontFamily, 40, FontStyle.Bold) ' Perbesar font
                                              btnSepuluh.BackColor = Color.DarkRed ' Ubah warna juga (opsional)
                                          End Sub
        AddHandler btnSepuluh.MouseLeave, Sub(sender, e)
                                              btnSepuluh.Font = New Font(btnSepuluh.Font.FontFamily, 36, FontStyle.Bold) ' Kembalikan font ke default
                                              btnSepuluh.BackColor = Color.Brown ' Kembalikan warna
                                          End Sub
        AddHandler btnSepuluh.Click, AddressOf BtnSepuluh_Click
        Me.Controls.Add(btnSepuluh)



        btnSatu.Location = New Point(120, 120)   ' Tombol pertama di posisi 150, 120
        btnDua.Location = New Point(240, 120)    ' Tombol kedua di sebelah kanan tombol pertama
        btnTiga.Location = New Point(360, 120)   ' Tombol ketiga di sebelah kanan tombol kedua
        btnEmpat.Location = New Point(480, 120)  ' Tombol keempat di sebelah kanan tombol ketiga
        btnLima.Location = New Point(600, 120)

        btnEnam.Location = New Point(120, 240)   ' Tombol pertama di posisi 150, 120
        btnTujuh.Location = New Point(240, 240)    ' Tombol kedua di sebelah kanan tombol pertama
        btnDelapan.Location = New Point(360, 240)   ' Tombol ketiga di sebelah kanan tombol kedua
        btnSembilan.Location = New Point(480, 240)  ' Tombol keempat di sebelah kanan tombol ketiga
        btnSepuluh.Location = New Point(600, 240)

        btnSatu.Font = New Font("Arial", 36, FontStyle.Bold)   ' Ukuran font 36 untuk tombol pertama
        btnDua.Font = New Font("Arial", 36, FontStyle.Bold)    ' Ukuran font 36 untuk tombol kedua
        btnTiga.Font = New Font("Arial", 36, FontStyle.Bold)   ' Ukuran font 36 untuk tombol ketiga
        btnEmpat.Font = New Font("Arial", 36, FontStyle.Bold)  ' Ukuran font 36 untuk tombol keempat
        btnLima.Font = New Font("Arial", 36, FontStyle.Bold)

        btnEnam.Font = New Font("Arial", 36, FontStyle.Bold)   ' Ukuran font 36 untuk tombol pertama
        btnTujuh.Font = New Font("Arial", 36, FontStyle.Bold)    ' Ukuran font 36 untuk tombol kedua
        btnDelapan.Font = New Font("Arial", 36, FontStyle.Bold)   ' Ukuran font 36 untuk tombol ketiga
        btnSembilan.Font = New Font("Arial", 36, FontStyle.Bold)  ' Ukuran font 36 untuk tombol keempat
        btnSepuluh.Font = New Font("Arial", 36, FontStyle.Bold)

        ' Tambahkan tombol untuk kembali ke Panel1
        Dim backButton As New Button()
        backButton.Text = "Kembali"
        backButton.Font = New Font("Arial", 14, FontStyle.Regular)
        backButton.Size = New Size(200, 50)
        backButton.Location = New Point(20, 500)
        backButton.BackColor = Color.ForestGreen ' Set warna latar belakang tombol menjadi hijau
        backButton.ForeColor = Color.White
        backButton.FlatStyle = FlatStyle.Flat ' Set FlatStyle untuk menghilangkan border
        backButton.FlatAppearance.BorderSize = 0 ' Hilangkan border sepenuhnya
        backButton.Cursor = Cursors.Hand
        AddHandler backButton.Click, AddressOf BackButton_Click
        Me.Controls.Add(backButton)
    End Sub

    ' Event handler untuk tombol kembali
    Private Sub BackButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim form As Form1 = CType(Me.Parent, Form1)
        Me.Hide() ' Sembunyikan Panel2
        form.panel1.Show() ' Tampilkan Panel1
        form.StartMusic() ' Mulai musik lagi di Panel1
    End Sub

    Private Sub BtnSatu_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim player As New SoundPlayer(My.Resources.Satu)
        player.Play()
    End Sub

    Private Sub BtnDua_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim player As New SoundPlayer(My.Resources.Dua)
        player.Play()
    End Sub

    Private Sub BtnTiga_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim player As New SoundPlayer(My.Resources.Tiga)
        player.Play()
    End Sub

    Private Sub BtnEmpat_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim player As New SoundPlayer(My.Resources.Empat)
        player.Play()
    End Sub

    Private Sub BtnLima_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim player As New SoundPlayer(My.Resources.Lima)
        player.Play()
    End Sub

    Private Sub BtnEnam_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim player As New SoundPlayer(My.Resources.Enam)
        player.Play()
    End Sub

    Private Sub BtnTujuh_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim player As New SoundPlayer(My.Resources.Tujuh)
        player.Play()
    End Sub

    Private Sub BtnDelapan_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim player As New SoundPlayer(My.Resources.Delapan)
        player.Play()
    End Sub

    Private Sub BtnSembilan_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim player As New SoundPlayer(My.Resources.Sembilan)
        player.Play()
    End Sub

    Private Sub BtnSepuluh_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim player As New SoundPlayer(My.Resources.Sepuluh)
        player.Play()
    End Sub

End Class
