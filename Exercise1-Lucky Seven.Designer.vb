<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        btnEnd = New Button()
        btnSpin = New Button()
        PictureBox1 = New PictureBox()
        lblWins = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Aquamarine
        Label1.Font = New Font("Stylus BT", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlText
        Label1.Location = New Point(198, 116)
        Label1.Name = "Label1"
        Label1.Size = New Size(194, 132)
        Label1.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Aquamarine
        Label2.Font = New Font("Stylus BT", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ControlText
        Label2.Location = New Point(426, 116)
        Label2.Name = "Label2"
        Label2.Size = New Size(194, 132)
        Label2.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.Aquamarine
        Label3.Font = New Font("Stylus BT", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ControlText
        Label3.Location = New Point(650, 116)
        Label3.Name = "Label3"
        Label3.Size = New Size(194, 132)
        Label3.TabIndex = 2
        ' 
        ' btnEnd
        ' 
        btnEnd.BackColor = SystemColors.ControlLight
        btnEnd.Location = New Point(78, 361)
        btnEnd.Name = "btnEnd"
        btnEnd.Size = New Size(238, 140)
        btnEnd.TabIndex = 3
        btnEnd.Text = "End Program"
        btnEnd.UseVisualStyleBackColor = False
        ' 
        ' btnSpin
        ' 
        btnSpin.BackColor = SystemColors.ControlLight
        btnSpin.Location = New Point(415, 361)
        btnSpin.Name = "btnSpin"
        btnSpin.Size = New Size(442, 140)
        btnSpin.TabIndex = 4
        btnSpin.Text = "Spin"
        btnSpin.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Screenshot_2026_09_14_160746
        PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), Image)
        PictureBox1.Location = New Point(506, 573)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(665, 548)
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        PictureBox1.Visible = False
        ' 
        ' lblWins
        ' 
        lblWins.BackColor = Color.IndianRed
        lblWins.BorderStyle = BorderStyle.FixedSingle
        lblWins.Font = New Font("Stylus BT", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblWins.ForeColor = SystemColors.ControlText
        lblWins.Location = New Point(78, 640)
        lblWins.Name = "lblWins"
        lblWins.Size = New Size(238, 221)
        lblWins.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1732, 1205)
        Controls.Add(lblWins)
        Controls.Add(PictureBox1)
        Controls.Add(btnSpin)
        Controls.Add(btnEnd)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnEnd As Button
    Friend WithEvents btnSpin As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblWins As Label

End Class
