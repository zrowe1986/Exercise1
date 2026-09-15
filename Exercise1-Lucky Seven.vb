Imports System.Drawing.Text

Public Class Form1

    Dim WINS As Integer

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        Close()
    End Sub

    Private Sub btnSpin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSpin.Click

        PictureBox1.Visible = False
        Label1.Text = CStr(Int(Rnd() * 10))
        Label2.Text = CStr(Int(Rnd() * 10))
        Label3.Text = CStr(Int(Rnd() * 10))
        'IF ANY CAPTION IS 7 DISPLAY PICTURE AND BEEP
        If (Label1.Text = "7" Or Label2.Text = "7" Or Label3.Text = "7") Then
            PictureBox1.Visible = True
            Beep()
            WINS = WINS + 1
            lblWins.Text = "Wins" & WINS
        Else
            PictureBox1.Visible = False

        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class