Public Class Form1
    Dim mybrush As New SolidBrush(Color.Black)
    Dim xPos As Integer
    Dim yPos As Integer
    Dim PxPos As Integer
    Dim PyPos As Integer
    Dim radius As Integer = 3
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        Dim draw As System.Drawing.Graphics
        draw = Me.CreateGraphics
        Label1.Text = xPos
        Label2.Text = yPos
        PxPos = xPos
        PyPos = yPos

        xPos = Me.MousePosition.X - Me.Location.X - 15
        yPos = Me.MousePosition.Y - Me.Location.Y - 40



        If mouse = True Then
            draw.DrawLine(New Pen(mybrush, radius), PxPos, PyPos, xPos, yPos)
        End If
    End Sub
    Dim mouse As Boolean = False
    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        mouse = True
    End Sub

    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        mouse = False
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        mybrush.Color = Color.Red
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        mybrush.Color = Color.Orange
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)
        mybrush.Color = Color.Yellow
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        mybrush.Color = Color.Green
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        mybrush.Color = Color.Blue
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        mybrush.Color = Color.Purple
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        mybrush.Color = Color.White
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        ColorDialog1.ShowDialog()
        mybrush.Color = ColorDialog1.Color
    End Sub

    Private Sub Form1_MouseWheel(sender As Object, e As MouseEventArgs) Handles Me.MouseWheel
        radius += 1
    End Sub
End Class
