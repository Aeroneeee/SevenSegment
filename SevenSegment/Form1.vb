Public Class Form1

    Private counter As Integer = 0
    Private Sub Form1_Load(sender As Object, ev As EventArgs) Handles MyBase.Load

        Timer1.Interval = TimeSpan.FromSeconds(1).TotalMilliseconds
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, ev As EventArgs) Handles Timer1.Tick

        If counter = 0 Then
            a.Visible = True
            b.Visible = True
            c.Visible = True
            d.Visible = True
            e.Visible = True
            f.Visible = True
            g.Visible = False
        End If

        If counter = 1 Then
            a.Visible = False
            b.Visible = True
            c.Visible = True
            d.Visible = False
            e.Visible = False
            f.Visible = False
            g.Visible = False
        End If

        If counter = 2 Then
            a.Visible = True
            b.Visible = True
            c.Visible = False
            d.Visible = True
            e.Visible = True
            f.Visible = False
            g.Visible = True
        End If

        If counter = 3 Then
            a.Visible = True
            b.Visible = True
            c.Visible = True
            d.Visible = True
            e.Visible = False
            f.Visible = False
            g.Visible = True
        End If

        If counter = 4 Then
            a.Visible = False
            b.Visible = True
            c.Visible = True
            d.Visible = False
            e.Visible = False
            f.Visible = True
            g.Visible = True
        End If

        If counter = 5 Then
            a.Visible = True
            b.Visible = False
            c.Visible = True
            d.Visible = True
            e.Visible = True
            f.Visible = False
            g.Visible = True
        End If

        If counter = 6 Then
            a.Visible = True
            b.Visible = False
            c.Visible = True
            d.Visible = True
            e.Visible = True
            f.Visible = True
            g.Visible = True
        End If

        If counter = 7 Then
            a.Visible = True
            b.Visible = True
            c.Visible = True
            d.Visible = False
            e.Visible = False
            f.Visible = False
            g.Visible = False
        End If

        If counter = 8 Then
            a.Visible = True
            b.Visible = True
            c.Visible = True
            d.Visible = True
            e.Visible = True
            f.Visible = True
            g.Visible = True
        End If

        If counter = 9 Then
            a.Visible = True
            b.Visible = True
            c.Visible = True
            d.Visible = True
            e.Visible = False
            f.Visible = True
            g.Visible = True
        End If

        If counter = 9 Then
            counter = 0
        Else
            counter += 1
        End If

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles e.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles b.Click

    End Sub

End Class
