Imports System.Windows.Forms
Imports System.Drawing
Imports System.Media

Public Class Panel3
    Inherits Panel

    Private labelSoal As Label
    Private scoreLabel As Label
    Private btnAnswer1 As Button
    Private btnAnswer2 As Button
    Private btnAnswer3 As Button
    Private btnAnswer4 As Button
    Private score As Integer
    Private currentQuestion As Integer
    Private soundPlayer As SoundPlayer
    Private panel4 As Panel

    Public Sub New()
        Me.Dock = DockStyle.Fill

        ' Mengatur gambar latar
        Me.BackgroundImage = My.Resources.backgroundColorForest ' Ganti 'backgroundColorForest' dengan gambar yang diinginkan
        Me.BackgroundImageLayout = ImageLayout.Stretch

        ' Inisialisasi score
        score = 0
        currentQuestion = 0

        ' Label untuk menampilkan soal
        labelSoal = New Label()
        labelSoal.Size = New Size(400, 30)
        labelSoal.Location = New Point(50, 50)
        labelSoal.Font = New Font("Arial", 14)
        labelSoal.Text = "Game dimulai!"
        labelSoal.BackColor = Color.Transparent
        Me.Controls.Add(labelSoal)

        ' Label untuk menampilkan skor
        scoreLabel = New Label()
        scoreLabel.Size = New Size(200, 30)
        scoreLabel.Location = New Point(50, 100)
        scoreLabel.Font = New Font("Arial", 14)
        scoreLabel.Text = "Score: " & score
        scoreLabel.BackColor = Color.Transparent
        Me.Controls.Add(scoreLabel)

        ' Tombol pilihan angka
        btnAnswer1 = New Button()
        btnAnswer1.Size = New Size(100, 40)
        btnAnswer1.Location = New Point(50, 150)
        btnAnswer1.Text = "1"
        AddHandler btnAnswer1.Click, AddressOf AnswerClick
        Me.Controls.Add(btnAnswer1)

        btnAnswer2 = New Button()
        btnAnswer2.Size = New Size(100, 40)
        btnAnswer2.Location = New Point(150, 150)
        btnAnswer2.Text = "2"
        AddHandler btnAnswer2.Click, AddressOf AnswerClick
        Me.Controls.Add(btnAnswer2)

        btnAnswer3 = New Button()
        btnAnswer3.Size = New Size(100, 40)
        btnAnswer3.Location = New Point(250, 150)
        btnAnswer3.Text = "3"
        AddHandler btnAnswer3.Click, AddressOf AnswerClick
        Me.Controls.Add(btnAnswer3)

        btnAnswer4 = New Button()
        btnAnswer4.Size = New Size(100, 40)
        btnAnswer4.Location = New Point(350, 150)
        btnAnswer4.Text = "4"
        AddHandler btnAnswer4.Click, AddressOf AnswerClick
        Me.Controls.Add(btnAnswer4)

        ' Mulai game otomatis
        StartGame()
    End Sub

    Private Sub StartGame()
        ' Mulai game dan tampilkan soal pertama
        currentQuestion = 1
        ' Putar suara sebelum soal tampil
        soundPlayer = New SoundPlayer(My.Resources.Lima) ' Ganti dengan suara untuk soal pertama
        soundPlayer.Play()
        ShowQuestion()
    End Sub

    Private Sub ShowQuestion()
        ' Menampilkan soal dan suara untuk soal
        Select Case currentQuestion
            Case 1
                labelSoal.Text = "Dengarkan dan pilih angka yang benar"
                soundPlayer = New SoundPlayer(My.Resources.Lima) ' Ganti 'soal1' dengan file suara soal
                soundPlayer.Play()
                btnAnswer1.Text = "5"
                btnAnswer2.Text = "4"
                btnAnswer3.Text = "6"
                btnAnswer4.Text = "7"
            Case 2
                labelSoal.Text = "Dengarkan dan pilih angka yang benar"
                soundPlayer = New SoundPlayer(My.Resources.Delapan) ' Ganti 'soal2' dengan file suara soal
                soundPlayer.Play()
                btnAnswer1.Text = "7"
                btnAnswer2.Text = "8"
                btnAnswer3.Text = "9"
                btnAnswer4.Text = "10"
            Case 3
                labelSoal.Text = "Dengarkan dan pilih angka yang benar"
                soundPlayer = New SoundPlayer(My.Resources.Tiga) ' Ganti 'soal3' dengan file suara soal
                soundPlayer.Play()
                btnAnswer1.Text = "2"
                btnAnswer2.Text = "3"
                btnAnswer3.Text = "4"
                btnAnswer4.Text = "5"
            Case 4
                labelSoal.Text = "Dengarkan dan pilih angka yang benar"
                soundPlayer = New SoundPlayer(My.Resources.Enam) ' Ganti 'soal4' dengan file suara soal
                soundPlayer.Play()
                btnAnswer1.Text = "5"
                btnAnswer2.Text = "8"
                btnAnswer3.Text = "7"
                btnAnswer4.Text = "6"
            Case 5
                labelSoal.Text = "Dengarkan dan pilih angka yang benar"
                soundPlayer = New SoundPlayer(My.Resources.Sembilan) ' Ganti 'soal5' dengan file suara soal
                soundPlayer.Play()
                btnAnswer1.Text = "8"
                btnAnswer2.Text = "10"
                btnAnswer3.Text = "9"
                btnAnswer4.Text = "11"
        End Select
    End Sub

    Private Sub AnswerClick(ByVal sender As Object, ByVal e As EventArgs)
        ' Cek apakah jawabannya benar
        Dim btn As Button = CType(sender, Button)
        Dim correctAnswer As String = ""

        ' Menentukan jawaban yang benar berdasarkan soal yang sedang tampil
        Select Case currentQuestion
            Case 1
                correctAnswer = "5"
            Case 2
                correctAnswer = "8"
            Case 3
                correctAnswer = "3"
            Case 4
                correctAnswer = "6"
            Case 5
                correctAnswer = "9"
        End Select

        ' Jika jawabannya benar, tambahkan score
        If btn.Text = correctAnswer Then
            score += 1
            MessageBox.Show("Jawaban benar! Skor: " & score)
        Else
            MessageBox.Show("Jawaban salah!")
        End If

        ' Update skor
        scoreLabel.Text = "Score: " & score

        ' Pindah ke soal berikutnya atau tampilkan panel 4 jika sudah selesai
        If currentQuestion < 5 Then
            currentQuestion += 1
            ShowQuestion()
        Else
            ShowPanel4()
        End If
    End Sub

    Private Sub ShowPanel4()
        ' Sembunyikan Panel3
        Me.Visible = False

        ' Membuat Panel4 dan menambahkannya ke form
        panel4 = New Panel()
        panel4.Dock = DockStyle.Fill
        panel4.BackgroundImage = Me.BackgroundImage
        panel4.BackgroundImageLayout = ImageLayout.Stretch

        ' Menampilkan skor akhir
        Dim finalScoreLabel As New Label()
        finalScoreLabel.Text = "Skor Akhir: " & score
        finalScoreLabel.Font = New Font("Arial", 14)
        finalScoreLabel.Size = New Size(200, 30)
        finalScoreLabel.Location = New Point(50, 50)
        finalScoreLabel.BackColor = Color.Transparent
        panel4.Controls.Add(finalScoreLabel)

        ' Menambahkan tombol Main Lagi
        Dim btnMainLagi As New Button()
        btnMainLagi.Text = "Main Lagi"
        btnMainLagi.Size = New Size(100, 40)
        btnMainLagi.Location = New Point(50, 100)
        AddHandler btnMainLagi.Click, AddressOf MainLagiClick
        panel4.Controls.Add(btnMainLagi)

        ' Menambahkan tombol Quit
        Dim btnQuit As New Button()
        btnQuit.Text = "Quit"
        btnQuit.Size = New Size(100, 40)
        btnQuit.Location = New Point(200, 100)
        AddHandler btnQuit.Click, AddressOf QuitClick
        panel4.Controls.Add(btnQuit)

        ' Menambahkan panel4 ke form
        Me.Parent.Controls.Add(panel4)
    End Sub

    Private Sub MainLagiClick(ByVal sender As Object, ByVal e As EventArgs)
        ' Reset game dan tampilkan Panel3 lagi
        score = 0
        currentQuestion = 1 ' Langsung ke soal pertama
        scoreLabel.Text = "Score: " & score
        Me.Visible = True
        panel4.Visible = False
        ShowQuestion() ' Langsung tampilkan soal pertama
    End Sub

    Private Sub QuitClick(ByVal sender As Object, ByVal e As EventArgs)
        ' Keluar dari aplikasi
        Application.Exit()
    End Sub
End Class
