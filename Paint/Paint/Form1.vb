Public Class Form1
    Dim mouse As Boolean = False
    Dim draw As System.Drawing.Graphics
    Dim PxPos As Integer
    Dim PyPos As Integer
    Dim xPos As Integer
    Dim yPos As Integer
    Dim radius As Integer = 3
    Dim MyBrush As New SolidBrush(Color.Black)


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub








    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        Dim draw As System.Drawing.Graphics
        draw = Me.CreateGraphics

        PxPos = xPos
        PyPos = yPos

        xPos = Me.MousePosition.X - Me.Location.X - 15
        yPos = Me.MousePosition.Y - Me.Location.Y - 40


        Label1.Text = Me.MousePosition.X

        Label2.Text = Me.MousePosition.Y

        Dim mouseDown As Integer = MouseButtons

        If mouse = True Then
            draw.DrawLine(New Pen(MyBrush, radius), PxPos, PyPos, xPos, yPos)
        End If
    End Sub

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        mouse = True
    End Sub

    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        mouse = False
    End Sub

    Private Sub Form1_MouseWheel(sender As Object, e As MouseEventArgs) Handles Me.MouseWheel
        radius += 1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        MyBrush.Color = Color.Red
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        MyBrush.Color = Color.LawnGreen
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        MyBrush.Color = Color.SpringGreen
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ColorDialog1.ShowDialog()
        MyBrush.Color = ColorDialog1.Color
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        radius = 3
    End Sub
End Class
