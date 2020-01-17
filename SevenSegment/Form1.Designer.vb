<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.d = New System.Windows.Forms.PictureBox()
        Me.g = New System.Windows.Forms.PictureBox()
        Me.a = New System.Windows.Forms.PictureBox()
        Me.c = New System.Windows.Forms.PictureBox()
        Me.e = New System.Windows.Forms.PictureBox()
        Me.b = New System.Windows.Forms.PictureBox()
        Me.f = New System.Windows.Forms.PictureBox()
        CType(Me.d, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.g, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.a, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.e, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.b, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.f, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10000
        '
        'd
        '
        Me.d.Image = Global.SevenSegment.My.Resources.Resources._7seeeg
        Me.d.Location = New System.Drawing.Point(35, 510)
        Me.d.Name = "d"
        Me.d.Size = New System.Drawing.Size(235, 35)
        Me.d.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.d.TabIndex = 6
        Me.d.TabStop = False
        '
        'g
        '
        Me.g.Image = Global.SevenSegment.My.Resources.Resources._7seeeg
        Me.g.Location = New System.Drawing.Point(32, 260)
        Me.g.Name = "g"
        Me.g.Size = New System.Drawing.Size(235, 35)
        Me.g.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.g.TabIndex = 5
        Me.g.TabStop = False
        '
        'a
        '
        Me.a.Image = Global.SevenSegment.My.Resources.Resources._7seeeg
        Me.a.Location = New System.Drawing.Point(36, 6)
        Me.a.Name = "a"
        Me.a.Size = New System.Drawing.Size(235, 35)
        Me.a.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.a.TabIndex = 4
        Me.a.TabStop = False
        '
        'c
        '
        Me.c.Image = Global.SevenSegment.My.Resources.Resources._7seeg
        Me.c.Location = New System.Drawing.Point(263, 285)
        Me.c.Name = "c"
        Me.c.Size = New System.Drawing.Size(35, 235)
        Me.c.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.c.TabIndex = 3
        Me.c.TabStop = False
        '
        'e
        '
        Me.e.Image = Global.SevenSegment.My.Resources.Resources._7seeg
        Me.e.Location = New System.Drawing.Point(6, 285)
        Me.e.Name = "e"
        Me.e.Size = New System.Drawing.Size(35, 235)
        Me.e.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.e.TabIndex = 2
        Me.e.TabStop = False
        '
        'b
        '
        Me.b.Image = Global.SevenSegment.My.Resources.Resources._7seeg
        Me.b.Location = New System.Drawing.Point(263, 33)
        Me.b.Name = "b"
        Me.b.Size = New System.Drawing.Size(35, 235)
        Me.b.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.b.TabIndex = 1
        Me.b.TabStop = False
        '
        'f
        '
        Me.f.Image = Global.SevenSegment.My.Resources.Resources._7seeg
        Me.f.Location = New System.Drawing.Point(6, 33)
        Me.f.Name = "f"
        Me.f.Size = New System.Drawing.Size(35, 235)
        Me.f.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.f.TabIndex = 0
        Me.f.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(306, 550)
        Me.Controls.Add(Me.d)
        Me.Controls.Add(Me.g)
        Me.Controls.Add(Me.a)
        Me.Controls.Add(Me.c)
        Me.Controls.Add(Me.e)
        Me.Controls.Add(Me.b)
        Me.Controls.Add(Me.f)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        CType(Me.d, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.g, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.a, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.e, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.b, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.f, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents f As PictureBox
    Friend WithEvents b As PictureBox
    Friend WithEvents e As PictureBox
    Public WithEvents Timer1 As Timer
    Friend WithEvents c As PictureBox
    Friend WithEvents a As PictureBox
    Friend WithEvents g As PictureBox
    Friend WithEvents d As PictureBox
End Class
