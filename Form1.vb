Imports System.Windows.Forms
Imports System.Drawing
Imports System.Media

Public Class Form1
    ' Deklarasi Panel1, Panel2, dan SoundPlayer
    Public panel1 As Panel1
    Public panel2 As Panel2
    Public panel3 As Panel3
    Public player As SoundPlayer
    Public WithEvents panel1EventAnimasi As New Panel1()

    ' Constructor untuk Form1
    Public Sub New()
        ' Inisialisasi Panel1, Panel2, dan SoundPlayer
        InitializeComponent()

        panel1 = New Panel1()
        panel2 = New Panel2()
        panel3 = New Panel3()
        player = New SoundPlayer(My.Resources.Bg_Sound) ' Ganti dengan nama resource audio Anda

        ' Menambahkan Panel1 ke Form1
        Me.Controls.Add(panel1)

        ' Menambahkan Panel2 ke Form1, tapi sembunyikan dulu
        Me.Controls.Add(panel2)
        panel2.Hide()

        Me.Controls.Add(panel3)
        panel3.Hide()
    End Sub

    ' Event handler untuk Form Load
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' Mulai musik saat Form1 di-load
        StartMusic()
    End Sub

    ' Event handler untuk memulai musik saat Panel1 ditampilkan
    Public Sub StartMusic()
        If Not player.IsLoadCompleted Then
            player.Load()
        End If
        player.PlayLooping() ' Memainkan musik secara berulang
    End Sub

    ' Event handler untuk menghentikan musik saat berpindah ke Panel2
    Public Sub StopMusic()
        player.Stop() ' Menghentikan musik
    End Sub
End Class
