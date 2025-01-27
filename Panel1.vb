Imports System.Windows.Forms
Imports System.Drawing
Imports System.Media

Public Class Panel1
    Inherits Panel

    ' Variabel untuk arah dan kecepatan pergerakan
    Private direction As Integer = 5 ' Positif = kanan, Negatif = kiri
    Private direction2 As Integer = -5
    Private PictureBox1 As New PictureBox() ' Membuat objek PictureBox
    Private PictureBox2 As New PictureBox() ' Membuat objek PictureBox
    Private TimerAnimasiAwan As New Timer() ' Membuat objek Timer

    ' Constructor untuk Panel1
    Public Sub New()
        ' Set Dock property agar panel memenuhi form
        Me.Dock = DockStyle.Fill

        ' Tambahkan gambar latar dari resource properties
        Me.BackgroundImage = My.Resources.backgroundColorForest ' Ganti 'MyBackgroundImage' dengan nama file gambar yang ada di Resources
        Me.BackgroundImageLayout = ImageLayout.Stretch ' Supaya gambar memenuhi panel secara penuh

        ' Atur properti PictureBox1
        PictureBox1.Image = My.Resources.cloud2 ' Pastikan Anda sudah menambahkan gambar awan ke resource
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage ' Menyesuaikan ukuran gambar
        PictureBox1.Width = 150 ' Lebar gambar
        PictureBox1.Height = 100 ' Tinggi gambar
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Left = 0 ' Posisi awal di kiri panel
        PictureBox1.Top = (Me.Height - PictureBox1.Height) / 2 ' Posisikan di tengah vertikal panel
        Me.Controls.Add(PictureBox1) ' Menambahkan PictureBox ke dalam Panel

        ' Atur Timer1
        TimerAnimasiAwan.Interval = 50 ' Interval animasi (kecepatan gerakan)
        AddHandler TimerAnimasiAwan.Tick, AddressOf Timer1_Tick ' Menambahkan event handler untuk timer tick
        TimerAnimasiAwan.Start() ' Mulai timer


        ' Atur properti PictureBox1
        PictureBox2.Image = My.Resources.cloud4 ' Pastikan Anda sudah menambahkan gambar awan ke resource
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage ' Menyesuaikan ukuran gambar
        PictureBox2.Width = 150 ' Lebar gambar
        PictureBox2.Height = 400 ' Tinggi gambar
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Padding = New Padding(0, 300, 0, 0) ' Menambahkan padding 100px dari atas
        PictureBox2.Left = Me.Width
        PictureBox2.Top = (Me.Height - PictureBox2.Height) / 2 ' Posisikan di tengah vertikal panel
        Me.Controls.Add(PictureBox2) ' Menambahkan PictureBox ke dalam Panel

        ' Atur Timer1
        TimerAnimasiAwan.Interval = 50 ' Interval animasi (kecepatan gerakan)
        AddHandler TimerAnimasiAwan.Tick, AddressOf Timer1_Tick ' Menambahkan event handler untuk timer tick
        TimerAnimasiAwan.Start() ' Mulai timer
    End Sub

    ' Event Timer1_Tick untuk pergerakan gambar
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs)
        ' Periksa batas kanan dan kiri dari Panel1
        If PictureBox1.Left + PictureBox1.Width >= Me.Width Then
            direction = -5 ' Ubah arah ke kiri
        ElseIf PictureBox1.Left <= 0 Then
            direction = 5 ' Ubah arah ke kanan
        End If
        ' Gerakkan PictureBox
        PictureBox1.Left += direction

        ' Periksa batas kanan dan kiri dari Panel1 untuk PictureBox2
        If PictureBox2.Left <= 0 Then
            direction2 = 5 ' Ubah arah ke kanan untuk PictureBox2
        ElseIf PictureBox2.Left + PictureBox2.Width >= Me.Width Then
            direction2 = -5 ' Ubah arah ke kiri untuk PictureBox2
        End If
        ' Gerakkan PictureBox2
        PictureBox2.Left += direction2

        ' Tambahkan judul yang berada di tengah-tengah panel
        Dim titleLabel As New Label()
        titleLabel.Name = "TitleLabel"
        titleLabel.Text = "Game Pilih Angka"
        titleLabel.Font = New Font("Arial", 36, FontStyle.Bold)
        titleLabel.ForeColor = Color.ForestGreen
        titleLabel.BackColor = Color.Transparent
        titleLabel.BackColor = Color.Transparent
        titleLabel.AutoSize = False ' Matikan AutoSize
        titleLabel.Width = 800 ' Lebar label 100% dari panel
        titleLabel.Height = 80 ' Sesuaikan tinggi label sesuai kebutuhan
        titleLabel.TextAlign = ContentAlignment.MiddleCenter
        titleLabel.Location = New Point(0, 100)
        Me.Controls.Add(titleLabel)
        titleLabel.BringToFront()

        ' Tambahkan tombol Materi
        Dim materiButton As New Button()
        materiButton.Text = "Materi"
        materiButton.Font = New Font("Arial", 14, FontStyle.Regular)
        materiButton.Size = New Size(200, 50)
        materiButton.Location = New Point((Me.Width - materiButton.Width) \ 2, 300)
        materiButton.Anchor = AnchorStyles.Top
        materiButton.Cursor = Cursors.Hand
        AddHandler materiButton.Click, AddressOf MateriButton_Click
        Me.Controls.Add(materiButton)

        ' Tambahkan tombol Mulai Game
        Dim startButton As New Button()
        startButton.Text = "Mulai Game"
        startButton.Font = New Font("Arial", 14, FontStyle.Bold)
        startButton.Size = New Size(200, 50)
        startButton.Location = New Point((Me.Width - startButton.Width) \ 2, 370)
        startButton.Anchor = AnchorStyles.Top
        startButton.BackColor = Color.ForestGreen ' Set warna latar belakang tombol menjadi hijau
        startButton.ForeColor = Color.White
        startButton.Cursor = Cursors.Hand
        startButton.FlatStyle = FlatStyle.Flat ' Set FlatStyle untuk menghilangkan border
        startButton.FlatAppearance.BorderSize = 0 ' Hilangkan border sepenuhnya
        startButton.Cursor = Cursors.Hand
        AddHandler startButton.Click, AddressOf StartButton_Click
        Me.Controls.Add(startButton)
    End Sub

    ' Event handler untuk tombol Materi
    Private Sub MateriButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Menyembunyikan Panel1 dan menampilkan Panel2
        Dim form As Form1 = CType(Me.Parent, Form1)
        Me.Hide() ' Sembunyikan Panel1
        form.StopMusic() ' Hentikan musik
        form.panel2.Show() ' Tampilkan Panel2
    End Sub

    ' Event handler untuk tombol Mulai Game
    Private Sub StartButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Menyembunyikan Panel1 dan menampilkan Panel2
        Dim form As Form1 = CType(Me.Parent, Form1)
        Me.Hide() ' Sembunyikan Panel1
        form.StopMusic() ' Hentikan musik
        form.panel3.Show() ' Tampilkan Panel2

        Try
            ' Memutar audio pertama dari resource
            Dim audio1 As System.IO.Stream = My.Resources.introGame
            Dim player1 As New SoundPlayer(audio1)
            player1.PlaySync() ' Tunggu hingga audio pertama selesai

            ' Memutar audio kedua dari resource
            Dim audio2 As System.IO.Stream = My.Resources.Lima
            Dim player2 As New SoundPlayer(audio2)
            player2.PlaySync() ' Tunggu hingga audio kedua selesai
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Audio Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


End Class

