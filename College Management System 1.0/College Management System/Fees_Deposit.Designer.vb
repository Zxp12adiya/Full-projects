<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Fees_Deposit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fees_Deposit))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblLogout = New System.Windows.Forms.Label()
        Me.btnLogout = New Bunifu.Framework.UI.BunifuImageButton()
        Me.lblDashboard = New System.Windows.Forms.Label()
        Me.btnDashboard = New Bunifu.Framework.UI.BunifuImageButton()
        Me.lblDepartments = New System.Windows.Forms.Label()
        Me.btnDepartments = New Bunifu.Framework.UI.BunifuImageButton()
        Me.lblStudents = New System.Windows.Forms.Label()
        Me.lblFeesDeposit = New System.Windows.Forms.Label()
        Me.btnStudents = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnFeesDeposit = New Bunifu.Framework.UI.BunifuImageButton()
        Me.lblCMS = New System.Windows.Forms.Label()
        Me.btnCMS = New Bunifu.Framework.UI.BunifuImageButton()
        Me.lblTeachers = New System.Windows.Forms.Label()
        Me.btnTeachers = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClose = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.StIdCb = New System.Windows.Forms.ComboBox()
        Me.Period = New System.Windows.Forms.DateTimePicker()
        Me.FeesDGV = New Guna.UI.WinForms.GunaDataGridView()
        Me.btnPay = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.AmountTb = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.StNameTb = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.btnLogout, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDashboard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDepartments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnFeesDeposit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCMS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnTeachers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.FeesDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Menu
        Me.Panel1.Controls.Add(Me.lblLogout)
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Controls.Add(Me.lblDashboard)
        Me.Panel1.Controls.Add(Me.btnDashboard)
        Me.Panel1.Controls.Add(Me.lblDepartments)
        Me.Panel1.Controls.Add(Me.btnDepartments)
        Me.Panel1.Controls.Add(Me.lblStudents)
        Me.Panel1.Controls.Add(Me.lblFeesDeposit)
        Me.Panel1.Controls.Add(Me.btnStudents)
        Me.Panel1.Controls.Add(Me.btnFeesDeposit)
        Me.Panel1.Controls.Add(Me.lblCMS)
        Me.Panel1.Controls.Add(Me.btnCMS)
        Me.Panel1.Controls.Add(Me.lblTeachers)
        Me.Panel1.Controls.Add(Me.btnTeachers)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(275, 768)
        Me.Panel1.TabIndex = 2
        '
        'lblLogout
        '
        Me.lblLogout.AutoSize = True
        Me.lblLogout.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogout.Location = New System.Drawing.Point(84, 715)
        Me.lblLogout.Name = "lblLogout"
        Me.lblLogout.Size = New System.Drawing.Size(61, 19)
        Me.lblLogout.TabIndex = 8
        Me.lblLogout.Text = "Logout"
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Transparent
        Me.btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), System.Drawing.Image)
        Me.btnLogout.ImageActive = Nothing
        Me.btnLogout.Location = New System.Drawing.Point(3, 689)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(75, 75)
        Me.btnLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnLogout.TabIndex = 6
        Me.btnLogout.TabStop = False
        Me.btnLogout.Zoom = 10
        '
        'lblDashboard
        '
        Me.lblDashboard.AutoSize = True
        Me.lblDashboard.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDashboard.Location = New System.Drawing.Point(84, 542)
        Me.lblDashboard.Name = "lblDashboard"
        Me.lblDashboard.Size = New System.Drawing.Size(95, 19)
        Me.lblDashboard.TabIndex = 8
        Me.lblDashboard.Text = "Dashboard"
        '
        'btnDashboard
        '
        Me.btnDashboard.BackColor = System.Drawing.Color.Transparent
        Me.btnDashboard.Image = CType(resources.GetObject("btnDashboard.Image"), System.Drawing.Image)
        Me.btnDashboard.ImageActive = Nothing
        Me.btnDashboard.Location = New System.Drawing.Point(3, 516)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(75, 75)
        Me.btnDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnDashboard.TabIndex = 6
        Me.btnDashboard.TabStop = False
        Me.btnDashboard.Zoom = 10
        '
        'lblDepartments
        '
        Me.lblDepartments.AutoSize = True
        Me.lblDepartments.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepartments.Location = New System.Drawing.Point(84, 443)
        Me.lblDepartments.Name = "lblDepartments"
        Me.lblDepartments.Size = New System.Drawing.Size(107, 19)
        Me.lblDepartments.TabIndex = 8
        Me.lblDepartments.Text = "Departments"
        '
        'btnDepartments
        '
        Me.btnDepartments.BackColor = System.Drawing.Color.Transparent
        Me.btnDepartments.Image = CType(resources.GetObject("btnDepartments.Image"), System.Drawing.Image)
        Me.btnDepartments.ImageActive = Nothing
        Me.btnDepartments.Location = New System.Drawing.Point(3, 417)
        Me.btnDepartments.Name = "btnDepartments"
        Me.btnDepartments.Size = New System.Drawing.Size(75, 75)
        Me.btnDepartments.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnDepartments.TabIndex = 6
        Me.btnDepartments.TabStop = False
        Me.btnDepartments.Zoom = 10
        '
        'lblStudents
        '
        Me.lblStudents.AutoSize = True
        Me.lblStudents.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudents.Location = New System.Drawing.Point(84, 241)
        Me.lblStudents.Name = "lblStudents"
        Me.lblStudents.Size = New System.Drawing.Size(72, 19)
        Me.lblStudents.TabIndex = 8
        Me.lblStudents.Text = "Students"
        '
        'lblFeesDeposit
        '
        Me.lblFeesDeposit.AutoSize = True
        Me.lblFeesDeposit.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFeesDeposit.Location = New System.Drawing.Point(84, 342)
        Me.lblFeesDeposit.Name = "lblFeesDeposit"
        Me.lblFeesDeposit.Size = New System.Drawing.Size(103, 19)
        Me.lblFeesDeposit.TabIndex = 8
        Me.lblFeesDeposit.Text = "Fees Deposit"
        '
        'btnStudents
        '
        Me.btnStudents.BackColor = System.Drawing.Color.Transparent
        Me.btnStudents.Image = CType(resources.GetObject("btnStudents.Image"), System.Drawing.Image)
        Me.btnStudents.ImageActive = Nothing
        Me.btnStudents.Location = New System.Drawing.Point(3, 215)
        Me.btnStudents.Name = "btnStudents"
        Me.btnStudents.Size = New System.Drawing.Size(75, 75)
        Me.btnStudents.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnStudents.TabIndex = 6
        Me.btnStudents.TabStop = False
        Me.btnStudents.Zoom = 10
        '
        'btnFeesDeposit
        '
        Me.btnFeesDeposit.BackColor = System.Drawing.Color.Transparent
        Me.btnFeesDeposit.Image = CType(resources.GetObject("btnFeesDeposit.Image"), System.Drawing.Image)
        Me.btnFeesDeposit.ImageActive = Nothing
        Me.btnFeesDeposit.Location = New System.Drawing.Point(3, 316)
        Me.btnFeesDeposit.Name = "btnFeesDeposit"
        Me.btnFeesDeposit.Size = New System.Drawing.Size(75, 75)
        Me.btnFeesDeposit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnFeesDeposit.TabIndex = 6
        Me.btnFeesDeposit.TabStop = False
        Me.btnFeesDeposit.Zoom = 10
        '
        'lblCMS
        '
        Me.lblCMS.AutoSize = True
        Me.lblCMS.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCMS.Location = New System.Drawing.Point(84, 39)
        Me.lblCMS.Name = "lblCMS"
        Me.lblCMS.Size = New System.Drawing.Size(129, 19)
        Me.lblCMS.TabIndex = 8
        Me.lblCMS.Text = "DR MPS College"
        '
        'btnCMS
        '
        Me.btnCMS.BackColor = System.Drawing.Color.Transparent
        Me.btnCMS.Image = CType(resources.GetObject("btnCMS.Image"), System.Drawing.Image)
        Me.btnCMS.ImageActive = Nothing
        Me.btnCMS.Location = New System.Drawing.Point(3, 13)
        Me.btnCMS.Name = "btnCMS"
        Me.btnCMS.Size = New System.Drawing.Size(75, 75)
        Me.btnCMS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnCMS.TabIndex = 6
        Me.btnCMS.TabStop = False
        Me.btnCMS.Zoom = 10
        '
        'lblTeachers
        '
        Me.lblTeachers.AutoSize = True
        Me.lblTeachers.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeachers.Location = New System.Drawing.Point(84, 140)
        Me.lblTeachers.Name = "lblTeachers"
        Me.lblTeachers.Size = New System.Drawing.Size(78, 19)
        Me.lblTeachers.TabIndex = 8
        Me.lblTeachers.Text = "Teachers"
        '
        'btnTeachers
        '
        Me.btnTeachers.BackColor = System.Drawing.Color.Transparent
        Me.btnTeachers.Image = CType(resources.GetObject("btnTeachers.Image"), System.Drawing.Image)
        Me.btnTeachers.ImageActive = Nothing
        Me.btnTeachers.Location = New System.Drawing.Point(3, 114)
        Me.btnTeachers.Name = "btnTeachers"
        Me.btnTeachers.Size = New System.Drawing.Size(75, 75)
        Me.btnTeachers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnTeachers.TabIndex = 6
        Me.btnTeachers.TabStop = False
        Me.btnTeachers.Zoom = 10
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.btnClose)
        Me.Panel2.Controls.Add(Me.BunifuImageButton2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(275, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1005, 100)
        Me.Panel2.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(339, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(331, 26)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "College Management System"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(87, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 19)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Fees Deposit"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageActive = Nothing
        Me.btnClose.Location = New System.Drawing.Point(963, 2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(40, 40)
        Me.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnClose.TabIndex = 8
        Me.btnClose.TabStop = False
        Me.btnClose.Zoom = 10
        '
        'BunifuImageButton2
        '
        Me.BunifuImageButton2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton2.Image = CType(resources.GetObject("BunifuImageButton2.Image"), System.Drawing.Image)
        Me.BunifuImageButton2.ImageActive = Nothing
        Me.BunifuImageButton2.Location = New System.Drawing.Point(6, 13)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Size = New System.Drawing.Size(75, 75)
        Me.BunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton2.TabIndex = 9
        Me.BunifuImageButton2.TabStop = False
        Me.BunifuImageButton2.Zoom = 10
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.StIdCb)
        Me.Panel3.Controls.Add(Me.Period)
        Me.Panel3.Controls.Add(Me.FeesDGV)
        Me.Panel3.Controls.Add(Me.btnPay)
        Me.Panel3.Controls.Add(Me.AmountTb)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.StNameTb)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(275, 100)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1005, 668)
        Me.Panel3.TabIndex = 10
        '
        'StIdCb
        '
        Me.StIdCb.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StIdCb.FormattingEnabled = True
        Me.StIdCb.Location = New System.Drawing.Point(28, 51)
        Me.StIdCb.Name = "StIdCb"
        Me.StIdCb.Size = New System.Drawing.Size(141, 27)
        Me.StIdCb.TabIndex = 18
        '
        'Period
        '
        Me.Period.CalendarFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Period.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Period.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Period.Location = New System.Drawing.Point(551, 52)
        Me.Period.Name = "Period"
        Me.Period.Size = New System.Drawing.Size(174, 27)
        Me.Period.TabIndex = 17
        '
        'FeesDGV
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.FeesDGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.FeesDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.FeesDGV.BackgroundColor = System.Drawing.Color.White
        Me.FeesDGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FeesDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.FeesDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FeesDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.FeesDGV.ColumnHeadersHeight = 30
        Me.FeesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.FeesDGV.DefaultCellStyle = DataGridViewCellStyle3
        Me.FeesDGV.EnableHeadersVisualStyles = False
        Me.FeesDGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FeesDGV.Location = New System.Drawing.Point(28, 202)
        Me.FeesDGV.Name = "FeesDGV"
        Me.FeesDGV.ReadOnly = True
        Me.FeesDGV.RowHeadersVisible = False
        Me.FeesDGV.RowTemplate.Height = 24
        Me.FeesDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.FeesDGV.Size = New System.Drawing.Size(946, 419)
        Me.FeesDGV.TabIndex = 16
        Me.FeesDGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.FeesDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.FeesDGV.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.FeesDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.FeesDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.FeesDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.FeesDGV.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.FeesDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FeesDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FeesDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.FeesDGV.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.FeesDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.FeesDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.FeesDGV.ThemeStyle.HeaderStyle.Height = 30
        Me.FeesDGV.ThemeStyle.ReadOnly = True
        Me.FeesDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.FeesDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.FeesDGV.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.FeesDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.FeesDGV.ThemeStyle.RowsStyle.Height = 24
        Me.FeesDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FeesDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'btnPay
        '
        Me.btnPay.AnimationHoverSpeed = 0.07!
        Me.btnPay.AnimationSpeed = 0.03!
        Me.btnPay.BaseColor = System.Drawing.SystemColors.Menu
        Me.btnPay.BorderColor = System.Drawing.Color.Black
        Me.btnPay.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnPay.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnPay.CheckedForeColor = System.Drawing.Color.White
        Me.btnPay.CheckedImage = CType(resources.GetObject("btnPay.CheckedImage"), System.Drawing.Image)
        Me.btnPay.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnPay.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnPay.FocusedColor = System.Drawing.Color.Empty
        Me.btnPay.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPay.ForeColor = System.Drawing.Color.Black
        Me.btnPay.Image = CType(resources.GetObject("btnPay.Image"), System.Drawing.Image)
        Me.btnPay.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnPay.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnPay.Location = New System.Drawing.Point(416, 109)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPay.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnPay.OnHoverForeColor = System.Drawing.Color.White
        Me.btnPay.OnHoverImage = Nothing
        Me.btnPay.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnPay.OnPressedColor = System.Drawing.Color.Black
        Me.btnPay.Size = New System.Drawing.Size(150, 40)
        Me.btnPay.TabIndex = 15
        Me.btnPay.Text = "Pay"
        Me.btnPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AmountTb
        '
        Me.AmountTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AmountTb.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AmountTb.Location = New System.Drawing.Point(798, 52)
        Me.AmountTb.Name = "AmountTb"
        Me.AmountTb.Size = New System.Drawing.Size(176, 27)
        Me.AmountTb.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(548, 14)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 19)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Date"
        '
        'StNameTb
        '
        Me.StNameTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.StNameTb.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StNameTb.Location = New System.Drawing.Point(234, 52)
        Me.StNameTb.Name = "StNameTb"
        Me.StNameTb.Size = New System.Drawing.Size(249, 27)
        Me.StNameTb.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(794, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 19)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Amount"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(429, 163)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 19)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Payments List"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(230, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 19)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Student's Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 19)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Student's ID"
        '
        'Fees_Deposit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1280, 768)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Fees_Deposit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fees_Deposit"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.btnLogout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDashboard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDepartments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnStudents, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnFeesDeposit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCMS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnTeachers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.FeesDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblLogout As Label
    Friend WithEvents btnLogout As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents lblDashboard As Label
    Friend WithEvents btnDashboard As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents lblDepartments As Label
    Friend WithEvents btnDepartments As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents lblStudents As Label
    Friend WithEvents lblFeesDeposit As Label
    Friend WithEvents btnStudents As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnFeesDeposit As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents lblCMS As Label
    Friend WithEvents btnCMS As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents lblTeachers As Label
    Friend WithEvents btnTeachers As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnClose As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton2 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents StIdCb As ComboBox
    Friend WithEvents Period As DateTimePicker
    Friend WithEvents FeesDGV As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents btnPay As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents AmountTb As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents StNameTb As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
End Class
