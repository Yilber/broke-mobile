﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ResetScreen
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ResetBtn = New System.Windows.Forms.Button()
        Me.Username = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnAboutUs = New System.Windows.Forms.Button()
        Me.btnShoppingCart = New System.Windows.Forms.Button()
        Me.btnHistory = New System.Windows.Forms.Button()
        Me.btnProducts = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(303, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ResetBtn
        '
        Me.ResetBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ResetBtn.AutoSize = True
        Me.ResetBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ResetBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.ResetBtn.ForeColor = System.Drawing.Color.White
        Me.ResetBtn.Location = New System.Drawing.Point(360, 160)
        Me.ResetBtn.Name = "ResetBtn"
        Me.ResetBtn.Size = New System.Drawing.Size(75, 27)
        Me.ResetBtn.TabIndex = 1
        Me.ResetBtn.Text = "Reset"
        Me.ResetBtn.UseVisualStyleBackColor = False
        '
        'Username
        '
        Me.Username.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Username.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Username.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Username.Location = New System.Drawing.Point(382, 129)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(100, 21)
        Me.Username.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(323, 96)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 24)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Password Reset"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Panel1.Controls.Add(Me.btnHome)
        Me.Panel1.Controls.Add(Me.btnAboutUs)
        Me.Panel1.Controls.Add(Me.btnShoppingCart)
        Me.Panel1.Controls.Add(Me.btnHistory)
        Me.Panel1.Controls.Add(Me.btnProducts)
        Me.Panel1.Location = New System.Drawing.Point(12, 273)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(770, 85)
        Me.Panel1.TabIndex = 8
        '
        'btnHome
        '
        Me.btnHome.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btnHome.Location = New System.Drawing.Point(650, 15)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(100, 50)
        Me.btnHome.TabIndex = 4
        Me.btnHome.Text = "Login"
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'btnAboutUs
        '
        Me.btnAboutUs.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAboutUs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAboutUs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAboutUs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btnAboutUs.Location = New System.Drawing.Point(500, 15)
        Me.btnAboutUs.Name = "btnAboutUs"
        Me.btnAboutUs.Size = New System.Drawing.Size(100, 50)
        Me.btnAboutUs.TabIndex = 3
        Me.btnAboutUs.Text = "About Us"
        Me.btnAboutUs.UseVisualStyleBackColor = False
        '
        'btnShoppingCart
        '
        Me.btnShoppingCart.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnShoppingCart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShoppingCart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShoppingCart.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btnShoppingCart.Location = New System.Drawing.Point(350, 15)
        Me.btnShoppingCart.Name = "btnShoppingCart"
        Me.btnShoppingCart.Size = New System.Drawing.Size(100, 50)
        Me.btnShoppingCart.TabIndex = 2
        Me.btnShoppingCart.Text = "Shopping Cart"
        Me.btnShoppingCart.UseVisualStyleBackColor = False
        '
        'btnHistory
        '
        Me.btnHistory.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnHistory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHistory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btnHistory.Location = New System.Drawing.Point(200, 15)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.Size = New System.Drawing.Size(100, 50)
        Me.btnHistory.TabIndex = 1
        Me.btnHistory.Text = "History"
        Me.btnHistory.UseVisualStyleBackColor = False
        '
        'btnProducts
        '
        Me.btnProducts.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnProducts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProducts.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProducts.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btnProducts.Location = New System.Drawing.Point(50, 15)
        Me.btnProducts.Name = "btnProducts"
        Me.btnProducts.Size = New System.Drawing.Size(100, 50)
        Me.btnProducts.TabIndex = 0
        Me.btnProducts.Text = "Products"
        Me.btnProducts.UseVisualStyleBackColor = False
        '
        'ResetScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(793, 370)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Username)
        Me.Controls.Add(Me.ResetBtn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.Maroon
        Me.Name = "ResetScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ResetScreen"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ResetBtn As Button
    Friend WithEvents Username As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnHome As Button
    Friend WithEvents btnAboutUs As Button
    Friend WithEvents btnShoppingCart As Button
    Friend WithEvents btnHistory As Button
    Friend WithEvents btnProducts As Button
End Class
