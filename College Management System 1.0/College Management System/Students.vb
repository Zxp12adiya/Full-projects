Imports System.Data.SqlClient
Public Class Students
    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Full Projects\College Management System 1.0\College Management System\CMSDatabase.mdf;Integrated Security=True")
    Private Sub Students_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillDepartment()
        DisplayStudents()
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub
    Private Sub FillDepartment()
        Con.Open()
        Dim query = "select * from DepartmentsTbl"
        Dim cmd As New SqlCommand(query, Con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim Tbl As New DataTable()
        adapter.Fill(Tbl)
        StDepartmentCb.DataSource = Tbl
        StDepartmentCb.DisplayMember = "DeptName"
        StDepartmentCb.ValueMember = "DeptName"
        Con.Close()
    End Sub
    Private Sub DisplayStudents()
        Con.Open()
        Dim query = "select * from StudentsTbl"
        Dim adapter As SqlDataAdapter
        Dim cmd = New SqlCommand(query, Con)
        adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        StudentsDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Private Sub NoDueList()
        Con.Open()
        Dim query = "select * from StudentsTbl where StFees < 100000"
        Dim adapter As SqlDataAdapter
        Dim cmd = New SqlCommand(query, Con)
        adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        StudentsDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Private Sub Reset()
        StNameTb.Text = ""
        StFeesTb.Text = ""
        StMobileNoTb.Text = ""
        StGenderCb.SelectedIndex = 0
        StDepartmentCb.SelectedIndex = 0
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If StNameTb.Text = "" Or StFeesTb.Text = "" Or StMobileNoTb.Text = "" Or StGenderCb.SelectedIndex = -1 Or StDepartmentCb.SelectedIndex = -1 Then
            MsgBox("Missing Information .... !")
        Else
            Try
                Con.Open()
                Dim query = "insert into StudentsTbl values('" & StNameTb.Text & "','" & StGenderCb.SelectedItem.ToString() & "','" & StDOB.Value.Date & "','" & StMobileNoTb.Text & "','" & StDepartmentCb.SelectedValue.ToString() & "'," & StFeesTb.Text & ")"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Student saved Successfully")
                Con.Close()
                DisplayStudents()
                Reset()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Dim Key = 0
    Private Sub StudentsDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles StudentsDGV.CellContentClick
        Dim row As DataGridViewRow = StudentsDGV.Rows(e.RowIndex)
        StNameTb.Text = row.Cells(1).Value.ToString
        StGenderCb.SelectedItem = row.Cells(2).Value.ToString
        StDOB.Text = row.Cells(3).Value.ToString
        StMobileNoTb.Text = row.Cells(4).Value.ToString
        StDepartmentCb.SelectedValue = row.Cells(5).Value.ToString
        StFeesTb.Text = row.Cells(6).Value.ToString
        If StNameTb.Text = "" Then
            Key = 0
        Else
            Key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If StNameTb.Text = "" Or StFeesTb.Text = "" Or StMobileNoTb.Text = "" Or StGenderCb.SelectedIndex = -1 Or StDepartmentCb.SelectedIndex = -1 Then
            MsgBox("Missing Information .... !")
        Else
            Try
                Con.Open()
                Dim query = "update StudentsTbl set StName='" & StNameTb.Text & "',StGender='" & StGenderCb.SelectedItem.ToString() & "',StDOB='" & StDOB.Text & "',StPhone='" & StMobileNoTb.Text & "',StDept='" & StDepartmentCb.SelectedValue.ToString() & "',StFees=" & StFeesTb.Text & " where StId=" & Key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Student updated Successfully")
                Con.Close()
                DisplayStudents()
                Reset()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If Key = 0 Then
            MsgBox("Please Select the Student to Delete")
        Else
            Try
                Con.Open()
                Dim query = "delete from StudentsTbl where StId=" & Key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Student Deleted Successfully")
                Con.Close()
                DisplayStudents()
                Reset()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Reset()
    End Sub

    Private Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnReload.Click
        DisplayStudents()
    End Sub

    Private Sub btnNoDueList_Click(sender As Object, e As EventArgs) Handles btnNoDueList.Click
        NoDueList()
    End Sub

    Private Sub StDepartmentCb_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles StDepartmentCb.SelectionChangeCommitted

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