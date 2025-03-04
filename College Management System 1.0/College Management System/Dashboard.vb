Imports System.Data.SqlClient
Public Class Dashboard
    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Full Projects\College Management System 1.0\College Management System\CMSDatabase.mdf;Integrated Security=True")
    Private Sub CountStudents()
        Dim StNum As Integer
        Con.Open()
        Dim sql = "select COUNT(*) from StudentsTbl"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(sql, Con)
        StNum = cmd.ExecuteScalar
        LblNOS.Text = StNum
        Con.Close()
    End Sub
    Private Sub CountTeachers()
        Dim TNum As Integer
        Con.Open()
        Dim sql = "select COUNT(*) from TeachersTbl"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(sql, Con)
        TNum = cmd.ExecuteScalar
        LblNOT.Text = TNum
        Con.Close()
    End Sub
    Private Sub CountDepartments()
        Dim DeptNum As Integer
        Con.Open()
        Dim sql = "select COUNT(*) from DepartmentsTbl"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(sql, Con)
        DeptNum = cmd.ExecuteScalar
        LblNOD.Text = DeptNum
        Con.Close()
    End Sub
    Private Sub SumFees()
        Dim FeesAmount As Integer
        Con.Open()
        Dim sql = "select Sum(Amount) from FeesTbl"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(sql, Con)
        FeesAmount = cmd.ExecuteScalar
        LblNOP.Text = FeesAmount
        Con.Close()
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CountStudents()
        CountTeachers()
        CountDepartments()
        SumFees()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub btnTeachers_Click(sender As Object, e As EventArgs) Handles btnTeachers.Click
        Dim Obj = New Teachers()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub lblTeachers_Click(sender As Object, e As EventArgs) Handles lblTeachers.Click
        Dim Obj = New Teachers()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub btnStudents_Click(sender As Object, e As EventArgs) Handles btnStudents.Click
        Dim Obj = New Students()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub lblStudents_Click(sender As Object, e As EventArgs) Handles lblStudents.Click
        Dim Obj = New Students()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub btnFeesDeposit_Click(sender As Object, e As EventArgs) Handles btnFeesDeposit.Click
        Dim Obj = New Fees_Deposit()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub lblFeesDeposit_Click(sender As Object, e As EventArgs) Handles lblFeesDeposit.Click
        Dim Obj = New Fees_Deposit()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub btnDepartments_Click(sender As Object, e As EventArgs) Handles btnDepartments.Click
        Dim Obj = New Departments()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub lblDepartments_Click(sender As Object, e As EventArgs) Handles lblDepartments.Click
        Dim Obj = New Departments()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim Obj = New Login()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub lblLogout_Click(sender As Object, e As EventArgs) Handles lblLogout.Click
        Dim Obj = New Login()
        Obj.Show()
        Me.Hide()
    End Sub
End Class