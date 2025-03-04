<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLogin = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.imgPassword = New Bunifu.Framework.UI.BunifuImageButton()
        Me.imgUser = New Bunifu.Framework.UI.BunifuImageButton()
        Me.txtPassword = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtUsername = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnLogo = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnClose = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnLock = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.imgPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnLock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkOrange
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.btnLogin)
        Me.Panel1.Controls.Add(Me.imgPassword)
        Me.Panel1.Controls.Add(Me.imgUser)
        Me.Panel1.Controls.Add(Me.txtPassword)
        Me.Panel1.Controls.Add(Me.txtUsername)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.btnLogo)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.btnLock)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(876, 576)
        Me.Panel1.TabIndex = 1
        '
        'btnLogin
        '
        Me.btnLogin.AnimationHoverSpeed = 0.07!
        Me.btnLogin.AnimationSpeed = 0.03!
        Me.btnLogin.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLogin.BorderColor = System.Drawing.Color.Black
        Me.btnLogin.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnLogin.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnLogin.CheckedForeColor = System.Drawing.Color.White
        Me.btnLogin.CheckedImage = CType(resources.GetObject("btnLogin.CheckedImage"), System.Drawing.Image)
        Me.btnLogin.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnLogin.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnLogin.FocusedColor = System.Drawing.Color.Empty
        Me.btnLogin.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Image = CType(resources.GetObject("btnLogin.Image"), System.Drawing.Image)
        Me.btnLogin.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnLogin.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnLogin.Location = New System.Drawing.Point(635, 448)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLogin.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnLogin.OnHoverForeColor = System.Drawing.Color.White
        Me.btnLogin.OnHoverImage = Nothing
        Me.btnLogin.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnLogin.OnPressedColor = System.Drawing.Color.Black
        Me.btnLogin.Size = New System.Drawing.Size(155, 40)
        Me.btnLogin.TabIndex = 13
        Me.btnLogin.Text = "Login"
        Me.btnLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'imgPassword
        '
        Me.imgPassword.BackColor = System.Drawing.Color.Transparent
        Me.imgPassword.Image = CType(resources.GetObject("imgPassword.Image"), System.Drawing.Image)
        Me.imgPassword.ImageActive = Nothing
        Me.imgPassword.Location = New System.Drawing.Point(536, 392)
        Me.imgPassword.Name = "imgPassword"
        Me.imgPassword.Size = New System.Drawing.Size(44, 44)
        Me.imgPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgPassword.TabIndex = 12
        Me.imgPassword.TabStop = False
        Me.imgPassword.Zoom = 10
        '
        'imgUser
        '
        Me.imgUser.BackColor = System.Drawing.Color.Transparent
        Me.imgUser.Image = CType(resources.GetObject("imgUser.Image"), System.Drawing.Image)
        Me.imgUser.ImageActive = Nothing
        Me.imgUser.Location = New System.Drawing.Point(536, 336)
        Me.imgUser.Name = "imgUser"
        Me.imgUser.Size = New System.Drawing.Size(44, 44)
        Me.imgUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgUser.TabIndex = 12
        Me.imgUser.TabStop = False
        Me.imgUser.Zoom = 10
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.White
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPassword.HintForeColor = System.Drawing.Color.Empty
        Me.txtPassword.HintText = "Enter Password"
        Me.txtPassword.isPassword = False
        Me.txtPassword.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtPassword.LineIdleColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtPassword.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtPassword.LineThickness = 3
        Me.txtPassword.Location = New System.Drawing.Point(581, 392)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(264, 48)
        Me.txtPassword.TabIndex = 10
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.White
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsername.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtUsername.HintForeColor = System.Drawing.Color.Empty
        Me.txtUsername.HintText = "Enter Username"
        Me.txtUsername.isPassword = False
        Me.txtUsername.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtUsername.LineIdleColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtUsername.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtUsername.LineThickness = 3
        Me.txtUsername.Location = New System.Drawing.Point(581, 336)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(264, 48)
        Me.txtUsername.TabIndex = 9
        Me.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(305, 547)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(279, 19)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Loading Application ...Please Wait !"
        '
        'btnLogo
        '
        Me.btnLogo.BackColor = System.Drawing.Color.Transparent
        Me.btnLogo.Image = CType(resources.GetObject("btnLogo.Image"), System.Drawing.Image)
        Me.btnLogo.ImageActive = Nothing
        Me.btnLogo.Location = New System.Drawing.Point(640, 80)
        Me.btnLogo.Name = "btnLogo"
        Me.btnLogo.Size = New System.Drawing.Size(150, 150)
        Me.btnLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnLogo.TabIndex = 6
        Me.btnLogo.TabStop = False
        Me.btnLogo.Zoom = 10
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageActive = Nothing
        Me.btnClose.Location = New System.Drawing.Point(834, 2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(40, 40)
        Me.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnClose.TabIndex = 5
        Me.btnClose.TabStop = False
        Me.btnClose.Zoom = 10
        '
        'btnLock
        '
        Me.btnLock.BackColor = System.Drawing.Color.Transparent
        Me.btnLock.Image = CType(resources.GetObject("btnLock.Image"), System.Drawing.Image)
        Me.btnLock.ImageActive = Nothing
        Me.btnLock.Location = New System.Drawing.Point(1, 1)
        Me.btnLock.Name = "btnLock"
        Me.btnLock.Size = New System.Drawing.Size(200, 200)
        Me.btnLock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnLock.TabIndex = 2
        Me.btnLock.TabStop = False
        Me.btnLock.Zoom = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(273, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(414, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DR MPS College Management System"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(226, 514)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(447, 26)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Developed by Aditya,mohit,vivek in 2024"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(900, 600)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.imgPassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnLock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnClose As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnLock As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLogo As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPassword As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtUsername As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents imgUser As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents imgPassword As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnLogin As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Label4 As Label
End Class
