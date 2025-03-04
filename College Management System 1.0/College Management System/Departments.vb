Imports System.Data.SqlClient
Public Class Departments
    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Full Projects\College Management System 1.0\College Management System\CMSDatabase.mdf;Integrated Security=True")
    Private Sub Departments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayDepartments()
    End Sub
    Private Sub DisplayDepartments()
        Con.Open()
        Dim query = "select * from DepartmentsTbl"
        Dim adapter As SqlDataAdapter
        Dim cmd = New SqlCommand(query, Con)
        adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        DepartmentsDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Private Sub Reset()
        DeptNameTb.Text = ""
        DeptDescTb.Text = ""
        DeptDurationTb.Text = ""
    End Sub
    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Application.Exit()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If DeptNameTb.Text = "" Or DeptDescTb.Text = "" Or DeptDurationTb.Text = "" Then
            MsgBox("Missing Information .... !")
        Else
            Try
                Con.Open()
                Dim query = "insert into DepartmentsTbl values('" & DeptNameTb.Text & "','" & DeptDescTb.Text & "'," & DeptDurationTb.Text & ")"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Deparment saved Successfully")
                Con.Close()
                DisplayDepartments()
                Reset()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If DeptNameTb.Text = "" Or DeptDescTb.Text = "" Or DeptDurationTb.Text = "" Then
            MsgBox("Missing Information .... !")
        Else
            Try
                Con.Open()
                Dim query = "update DepartmentsTbl set DeptName='" & DeptNameTb.Text & "',DeptDesc='" & DeptDescTb.Text & "',DeptDur=" & DeptDurationTb.Text & " where DeptId=" & Key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Deparment updated Successfully")
                Con.Close()
                DisplayDepartments()
                Reset()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Dim Key = 0
    Private Sub DepartmentsDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DepartmentsDGV.CellContentClick
        Dim row As DataGridViewRow = DepartmentsDGV.Rows(e.RowIndex)
        DeptNameTb.Text = row.Cells(1).Value.ToString
        DeptDescTb.Text = row.Cells(2).Value.ToString
        DeptDurationTb.Text = row.Cells(3).Value.ToString
        If DeptNameTb.Text = "" Then
            Key = 0
        Else
            Key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If Key = 0 Then
            MsgBox("Please Select the Department to Delete")
        Else
            Try
                Con.Open()
                Dim query = "delete from DepartmentsTbl where DeptId=" & Key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Deparment Deleted Successfully")
                Con.Close()
                DisplayDepartments()
                Reset()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Reset()
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

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Dim Obj = New Dashboard()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub lblDashboard_Click(sender As Object, e As EventArgs) Handles lblDashboard.Click
        Dim Obj = New Dashboard()
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