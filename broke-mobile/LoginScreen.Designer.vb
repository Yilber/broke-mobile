<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginScreen
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
        Me.UsernameBox = New System.Windows.Forms.TextBox()
        Me.PasswordBox = New System.Windows.Forms.TextBox()
        Me.LoginBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.WrongPassword = New System.Windows.Forms.Panel()
        Me.PasswordResetBtn = New System.Windows.Forms.Button()
        Me.TryAgainBtn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RegisterBtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.WrongPassword.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsernameBox
        '
        Me.UsernameBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.UsernameBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.UsernameBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.UsernameBox.Location = New System.Drawing.Point(507, 242)
        Me.UsernameBox.Name = "UsernameBox"
        Me.UsernameBox.Size = New System.Drawing.Size(100, 21)
        Me.UsernameBox.TabIndex = 0
        '
        'PasswordBox
        '
        Me.PasswordBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PasswordBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.PasswordBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.PasswordBox.Location = New System.Drawing.Point(507, 269)
        Me.PasswordBox.Name = "PasswordBox"
        Me.PasswordBox.Size = New System.Drawing.Size(100, 21)
        Me.PasswordBox.TabIndex = 1
        Me.PasswordBox.UseSystemPasswordChar = True
        '
        'LoginBtn
        '
        Me.LoginBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LoginBtn.AutoSize = True
        Me.LoginBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LoginBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.LoginBtn.ForeColor = System.Drawing.Color.White
        Me.LoginBtn.Location = New System.Drawing.Point(507, 296)
        Me.LoginBtn.Name = "LoginBtn"
        Me.LoginBtn.Padding = New System.Windows.Forms.Padding(2)
        Me.LoginBtn.Size = New System.Drawing.Size(100, 31)
        Me.LoginBtn.TabIndex = 2
        Me.LoginBtn.Text = "Login"
        Me.LoginBtn.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(410, 242)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(415, 268)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password"
        '
        'WrongPassword
        '
        Me.WrongPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.WrongPassword.BackColor = System.Drawing.Color.White
        Me.WrongPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.WrongPassword.Controls.Add(Me.PasswordResetBtn)
        Me.WrongPassword.Controls.Add(Me.TryAgainBtn)
        Me.WrongPassword.Controls.Add(Me.Label3)
        Me.WrongPassword.Location = New System.Drawing.Point(401, 241)
        Me.WrongPassword.Name = "WrongPassword"
        Me.WrongPassword.Size = New System.Drawing.Size(206, 86)
        Me.WrongPassword.TabIndex = 4
        Me.WrongPassword.Visible = False
        '
        'PasswordResetBtn
        '
        Me.PasswordResetBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PasswordResetBtn.AutoSize = True
        Me.PasswordResetBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.PasswordResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PasswordResetBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.PasswordResetBtn.ForeColor = System.Drawing.Color.White
        Me.PasswordResetBtn.Location = New System.Drawing.Point(106, 39)
        Me.PasswordResetBtn.Name = "PasswordResetBtn"
        Me.PasswordResetBtn.Padding = New System.Windows.Forms.Padding(2)
        Me.PasswordResetBtn.Size = New System.Drawing.Size(82, 31)
        Me.PasswordResetBtn.TabIndex = 1
        Me.PasswordResetBtn.Text = "Reset"
        Me.PasswordResetBtn.UseVisualStyleBackColor = False
        '
        'TryAgainBtn
        '
        Me.TryAgainBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TryAgainBtn.AutoSize = True
        Me.TryAgainBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.TryAgainBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TryAgainBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.TryAgainBtn.ForeColor = System.Drawing.Color.White
        Me.TryAgainBtn.Location = New System.Drawing.Point(18, 39)
        Me.TryAgainBtn.Name = "TryAgainBtn"
        Me.TryAgainBtn.Padding = New System.Windows.Forms.Padding(2)
        Me.TryAgainBtn.Size = New System.Drawing.Size(82, 31)
        Me.TryAgainBtn.TabIndex = 1
        Me.TryAgainBtn.Text = "Try again"
        Me.TryAgainBtn.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(38, 16)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Wrong Password"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RegisterBtn
        '
        Me.RegisterBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RegisterBtn.AutoSize = True
        Me.RegisterBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.RegisterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RegisterBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.RegisterBtn.ForeColor = System.Drawing.Color.White
        Me.RegisterBtn.Location = New System.Drawing.Point(401, 296)
        Me.RegisterBtn.Name = "RegisterBtn"
        Me.RegisterBtn.Padding = New System.Windows.Forms.Padding(2)
        Me.RegisterBtn.Size = New System.Drawing.Size(100, 31)
        Me.RegisterBtn.TabIndex = 2
        Me.RegisterBtn.Text = "Register"
        Me.RegisterBtn.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = Global.broke_mobile.My.Resources.Resources.image_1
        Me.PictureBox1.Location = New System.Drawing.Point(0, 34)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(390, 500)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox2.Image = Global.broke_mobile.My.Resources.Resources.image_14
        Me.PictureBox2.Location = New System.Drawing.Point(618, 34)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(390, 500)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'LoginScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1008, 566)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.WrongPassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RegisterBtn)
        Me.Controls.Add(Me.LoginBtn)
        Me.Controls.Add(Me.PasswordBox)
        Me.Controls.Add(Me.UsernameBox)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "LoginScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.WrongPassword.ResumeLayout(False)
        Me.WrongPassword.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UsernameBox As TextBox
    Friend WithEvents PasswordBox As TextBox
    Friend WithEvents LoginBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents WrongPassword As Panel
    Friend WithEvents TryAgainBtn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents PasswordResetBtn As Button
    Friend WithEvents RegisterBtn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
