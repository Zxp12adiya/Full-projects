<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Students
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Students))
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
        Me.StDOB = New System.Windows.Forms.DateTimePicker()
        Me.StDepartmentCb = New System.Windows.Forms.ComboBox()
        Me.StGenderCb = New System.Windows.Forms.ComboBox()
        Me.StudentsDGV = New Guna.UI.WinForms.GunaDataGridView()
        Me.btnReload = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnReset = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnDelete = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnUpdate = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnNoDueList = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnSave = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.StFeesTb = New System.Windows.Forms.TextBox()
        Me.StMobileNoTb = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.StNameTb = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
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
        CType(Me.StudentsDGV, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.TabIndex = 3
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
        Me.lblStudents.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudents.Location = New System.Drawing.Point(84, 241)
        Me.lblStudents.Name = "lblStudents"
        Me.lblStudents.Size = New System.Drawing.Size(72, 19)
        Me.lblStudents.TabIndex = 8
        Me.lblStudents.Text = "Students"
        '
        'lblFeesDeposit
        '
        Me.lblFeesDeposit.AutoSize = True
        Me.lblFeesDeposit.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.lblCMS.Size = New System.Drawing.Size(127, 19)
        Me.lblCMS.TabIndex = 8
        Me.lblCMS.Text = "DR MPS college"
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
        Me.Panel2.TabIndex = 10
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
        Me.Label1.Size = New System.Drawing.Size(72, 19)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Students"
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
        Me.Panel3.Controls.Add(Me.StDOB)
        Me.Panel3.Controls.Add(Me.StDepartmentCb)
        Me.Panel3.Controls.Add(Me.StGenderCb)
        Me.Panel3.Controls.Add(Me.StudentsDGV)
        Me.Panel3.Controls.Add(Me.btnReload)
        Me.Panel3.Controls.Add(Me.btnReset)
        Me.Panel3.Controls.Add(Me.btnDelete)
        Me.Panel3.Controls.Add(Me.btnUpdate)
        Me.Panel3.Controls.Add(Me.btnNoDueList)
        Me.Panel3.Controls.Add(Me.btnSave)
        Me.Panel3.Controls.Add(Me.StFeesTb)
        Me.Panel3.Controls.Add(Me.StMobileNoTb)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.StNameTb)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(275, 100)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1005, 668)
        Me.Panel3.TabIndex = 11
        '
        'StDOB
        '
        Me.StDOB.CalendarFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StDOB.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StDOB.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.StDOB.Location = New System.Drawing.Point(533, 49)
        Me.StDOB.Name = "StDOB"
        Me.StDOB.Size = New System.Drawing.Size(174, 27)
        Me.StDOB.TabIndex = 18
        '
        'StDepartmentCb
        '
        Me.StDepartmentCb.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StDepartmentCb.FormattingEnabled = True
        Me.StDepartmentCb.Items.AddRange(New Object() {"Male", "Female"})
        Me.StDepartmentCb.Location = New System.Drawing.Point(313, 131)
        Me.StDepartmentCb.Name = "StDepartmentCb"
        Me.StDepartmentCb.Size = New System.Drawing.Size(157, 27)
        Me.StDepartmentCb.TabIndex = 17
        '
        'StGenderCb
        '
        Me.StGenderCb.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StGenderCb.FormattingEnabled = True
        Me.StGenderCb.Items.AddRange(New Object() {"Male", "Female"})
        Me.StGenderCb.Location = New System.Drawing.Point(313, 48)
        Me.StGenderCb.Name = "StGenderCb"
        Me.StGenderCb.Size = New System.Drawing.Size(157, 27)
        Me.StGenderCb.TabIndex = 17
        '
        'StudentsDGV
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.StudentsDGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.StudentsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.StudentsDGV.BackgroundColor = System.Drawing.Color.White
        Me.StudentsDGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.StudentsDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.StudentsDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.StudentsDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.StudentsDGV.ColumnHeadersHeight = 30
        Me.StudentsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.StudentsDGV.DefaultCellStyle = DataGridViewCellStyle3
        Me.StudentsDGV.EnableHeadersVisualStyles = False
        Me.StudentsDGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.StudentsDGV.Location = New System.Drawing.Point(28, 272)
        Me.StudentsDGV.Name = "StudentsDGV"
        Me.StudentsDGV.ReadOnly = True
        Me.StudentsDGV.RowHeadersVisible = False
        Me.StudentsDGV.RowTemplate.Height = 24
        Me.StudentsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.StudentsDGV.Size = New System.Drawing.Size(946, 349)
        Me.StudentsDGV.TabIndex = 16
        Me.StudentsDGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.StudentsDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.StudentsDGV.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.StudentsDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.StudentsDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.StudentsDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.StudentsDGV.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.StudentsDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.StudentsDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.StudentsDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.StudentsDGV.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.StudentsDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.StudentsDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.StudentsDGV.ThemeStyle.HeaderStyle.Height = 30
        Me.StudentsDGV.ThemeStyle.ReadOnly = True
        Me.StudentsDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.StudentsDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.StudentsDGV.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.StudentsDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.StudentsDGV.ThemeStyle.RowsStyle.Height = 24
        Me.StudentsDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.StudentsDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'btnReload
        '
        Me.btnReload.AnimationHoverSpeed = 0.07!
        Me.btnReload.AnimationSpeed = 0.03!
        Me.btnReload.BaseColor = System.Drawing.SystemColors.Menu
        Me.btnReload.BorderColor = System.Drawing.Color.Black
        Me.btnReload.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnReload.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnReload.CheckedForeColor = System.Drawing.Color.White
        Me.btnReload.CheckedImage = CType(resources.GetObject("btnReload.CheckedImage"), System.Drawing.Image)
        Me.btnReload.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnReload.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnReload.FocusedColor = System.Drawing.Color.Empty
        Me.btnReload.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReload.ForeColor = System.Drawing.Color.Black
        Me.btnReload.Image = CType(resources.GetObject("btnReload.Image"), System.Drawing.Image)
        Me.btnReload.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnReload.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnReload.Location = New System.Drawing.Point(843, 179)
        Me.btnReload.Name = "btnReload"
        Me.btnReload.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnReload.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnReload.OnHoverForeColor = System.Drawing.Color.White
        Me.btnReload.OnHoverImage = Nothing
        Me.btnReload.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnReload.OnPressedColor = System.Drawing.Color.Black
        Me.btnReload.Size = New System.Drawing.Size(140, 40)
        Me.btnReload.TabIndex = 15
        Me.btnReload.Text = "Reload"
        Me.btnReload.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnReset
        '
        Me.btnReset.AnimationHoverSpeed = 0.07!
        Me.btnReset.AnimationSpeed = 0.03!
        Me.btnReset.BaseColor = System.Drawing.SystemColors.Menu
        Me.btnReset.BorderColor = System.Drawing.Color.Black
        Me.btnReset.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnReset.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnReset.CheckedForeColor = System.Drawing.Color.White
        Me.btnReset.CheckedImage = CType(resources.GetObject("btnReset.CheckedImage"), System.Drawing.Image)
        Me.btnReset.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnReset.FocusedColor = System.Drawing.Color.Empty
        Me.btnReset.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.Black
        Me.btnReset.Image = CType(resources.GetObject("btnReset.Image"), System.Drawing.Image)
        Me.btnReset.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnReset.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnReset.Location = New System.Drawing.Point(683, 179)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnReset.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnReset.OnHoverForeColor = System.Drawing.Color.White
        Me.btnReset.OnHoverImage = Nothing
        Me.btnReset.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnReset.OnPressedColor = System.Drawing.Color.Black
        Me.btnReset.Size = New System.Drawing.Size(140, 40)
        Me.btnReset.TabIndex = 15
        Me.btnReset.Text = "Reset"
        Me.btnReset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnDelete
        '
        Me.btnDelete.AnimationHoverSpeed = 0.07!
        Me.btnDelete.AnimationSpeed = 0.03!
        Me.btnDelete.BaseColor = System.Drawing.SystemColors.Menu
        Me.btnDelete.BorderColor = System.Drawing.Color.Black
        Me.btnDelete.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnDelete.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnDelete.CheckedForeColor = System.Drawing.Color.White
        Me.btnDelete.CheckedImage = CType(resources.GetObject("btnDelete.CheckedImage"), System.Drawing.Image)
        Me.btnDelete.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnDelete.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnDelete.FocusedColor = System.Drawing.Color.Empty
        Me.btnDelete.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Black
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnDelete.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnDelete.Location = New System.Drawing.Point(521, 179)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDelete.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnDelete.OnHoverForeColor = System.Drawing.Color.White
        Me.btnDelete.OnHoverImage = Nothing
        Me.btnDelete.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnDelete.OnPressedColor = System.Drawing.Color.Black
        Me.btnDelete.Size = New System.Drawing.Size(140, 40)
        Me.btnDelete.TabIndex = 15
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnUpdate
        '
        Me.btnUpdate.AnimationHoverSpeed = 0.07!
        Me.btnUpdate.AnimationSpeed = 0.03!
        Me.btnUpdate.BaseColor = System.Drawing.SystemColors.Menu
        Me.btnUpdate.BorderColor = System.Drawing.Color.Black
        Me.btnUpdate.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnUpdate.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnUpdate.CheckedForeColor = System.Drawing.Color.White
        Me.btnUpdate.CheckedImage = CType(resources.GetObject("btnUpdate.CheckedImage"), System.Drawing.Image)
        Me.btnUpdate.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnUpdate.FocusedColor = System.Drawing.Color.Empty
        Me.btnUpdate.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.Black
        Me.btnUpdate.Image = CType(resources.GetObject("btnUpdate.Image"), System.Drawing.Image)
        Me.btnUpdate.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnUpdate.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnUpdate.Location = New System.Drawing.Point(357, 179)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUpdate.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnUpdate.OnHoverForeColor = System.Drawing.Color.White
        Me.btnUpdate.OnHoverImage = Nothing
        Me.btnUpdate.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnUpdate.OnPressedColor = System.Drawing.Color.Black
        Me.btnUpdate.Size = New System.Drawing.Size(140, 40)
        Me.btnUpdate.TabIndex = 15
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnNoDueList
        '
        Me.btnNoDueList.AnimationHoverSpeed = 0.07!
        Me.btnNoDueList.AnimationSpeed = 0.03!
        Me.btnNoDueList.BaseColor = System.Drawing.SystemColors.Menu
        Me.btnNoDueList.BorderColor = System.Drawing.Color.Black
        Me.btnNoDueList.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnNoDueList.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnNoDueList.CheckedForeColor = System.Drawing.Color.White
        Me.btnNoDueList.CheckedImage = CType(resources.GetObject("btnNoDueList.CheckedImage"), System.Drawing.Image)
        Me.btnNoDueList.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnNoDueList.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnNoDueList.FocusedColor = System.Drawing.Color.Empty
        Me.btnNoDueList.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNoDueList.ForeColor = System.Drawing.Color.Black
        Me.btnNoDueList.Image = CType(resources.GetObject("btnNoDueList.Image"), System.Drawing.Image)
        Me.btnNoDueList.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnNoDueList.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnNoDueList.Location = New System.Drawing.Point(28, 179)
        Me.btnNoDueList.Name = "btnNoDueList"
        Me.btnNoDueList.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNoDueList.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnNoDueList.OnHoverForeColor = System.Drawing.Color.White
        Me.btnNoDueList.OnHoverImage = Nothing
        Me.btnNoDueList.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnNoDueList.OnPressedColor = System.Drawing.Color.Black
        Me.btnNoDueList.Size = New System.Drawing.Size(140, 40)
        Me.btnNoDueList.TabIndex = 15
        Me.btnNoDueList.Text = "No Due"
        Me.btnNoDueList.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSave
        '
        Me.btnSave.AnimationHoverSpeed = 0.07!
        Me.btnSave.AnimationSpeed = 0.03!
        Me.btnSave.BaseColor = System.Drawing.SystemColors.Menu
        Me.btnSave.BorderColor = System.Drawing.Color.Black
        Me.btnSave.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnSave.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnSave.CheckedForeColor = System.Drawing.Color.White
        Me.btnSave.CheckedImage = CType(resources.GetObject("btnSave.CheckedImage"), System.Drawing.Image)
        Me.btnSave.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnSave.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnSave.FocusedColor = System.Drawing.Color.Empty
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnSave.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnSave.Location = New System.Drawing.Point(194, 179)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSave.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnSave.OnHoverForeColor = System.Drawing.Color.White
        Me.btnSave.OnHoverImage = Nothing
        Me.btnSave.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnSave.OnPressedColor = System.Drawing.Color.Black
        Me.btnSave.Size = New System.Drawing.Size(140, 40)
        Me.btnSave.TabIndex = 15
        Me.btnSave.Text = "Save"
        Me.btnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'StFeesTb
        '
        Me.StFeesTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.StFeesTb.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StFeesTb.Location = New System.Drawing.Point(534, 132)
        Me.StFeesTb.Name = "StFeesTb"
        Me.StFeesTb.Size = New System.Drawing.Size(189, 27)
        Me.StFeesTb.TabIndex = 14
        '
        'StMobileNoTb
        '
        Me.StMobileNoTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.StMobileNoTb.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StMobileNoTb.Location = New System.Drawing.Point(775, 49)
        Me.StMobileNoTb.Name = "StMobileNoTb"
        Me.StMobileNoTb.Size = New System.Drawing.Size(189, 27)
        Me.StMobileNoTb.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(530, 97)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 19)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Annual Fees"
        '
        'StNameTb
        '
        Me.StNameTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.StNameTb.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StNameTb.Location = New System.Drawing.Point(41, 49)
        Me.StNameTb.Name = "StNameTb"
        Me.StNameTb.Size = New System.Drawing.Size(216, 27)
        Me.StNameTb.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(771, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 19)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Mobile No"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(437, 233)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 19)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Sudents List"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(309, 97)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(107, 19)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Departments"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(529, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 19)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Date of Birth"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(309, 14)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 19)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Gender"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(37, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 19)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Student's Name"
        '
        'Students
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
        Me.Name = "Students"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Students"
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
        CType(Me.StudentsDGV, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents StGenderCb As ComboBox
    Friend WithEvents StudentsDGV As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents btnReset As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnDelete As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnUpdate As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnSave As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents StMobileNoTb As TextBox
    Friend WithEvents StNameTb As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents StDOB As DateTimePicker
    Friend WithEvents StDepartmentCb As ComboBox
    Friend WithEvents btnReload As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnNoDueList As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents StFeesTb As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class
