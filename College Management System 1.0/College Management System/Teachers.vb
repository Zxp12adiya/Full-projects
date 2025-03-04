Imports System.Data.SqlClient
Public Class Teachers
    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Full Projects\College Management System 1.0\College Management System\CMSDatabase.mdf;Integrated Security=True")
    Private Sub FillDepartment()
        Con.Open()
        Dim query = "select * from DepartmentsTbl"
        Dim cmd As New SqlCommand(query, Con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim Tbl As New DataTable()
        adapter.Fill(Tbl)
        TDepartmentsCb.DataSource = Tbl
        TDepartmentsCb.DisplayMember = "DeptName"
        TDepartmentsCb.ValueMember = "DeptName"
        Con.Close()
    End Sub
    Private Sub DisplayTeachers()
        Con.Open()
        Dim query = "select * from TeachersTbl"
        Dim adapter As SqlDataAdapter
        Dim cmd = New SqlCommand(query, Con)
        adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        TeachersDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Private Sub Reset()
        TNameTb.Text = ""
        TGenderCb.SelectedIndex = 0
        TMobileNoTb.Text = ""
        TDepartmentsCb.SelectedIndex = 0
        TAddressTb.Text = ""
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If TNameTb.Text = "" Or TAddressTb.Text = "" Or TMobileNoTb.Text = "" Or TGenderCb.SelectedIndex = -1 Or TDepartmentsCb.SelectedIndex = -1 Then
            MsgBox("Missing Information .... !")
        Else
            Try
                Con.Open()
                Dim query = "insert into TeachersTbl values('" & TNameTb.Text & "','" & TGenderCb.SelectedItem.ToString() & "','" & TDOB.Value.Date & "','" & TMobileNoTb.Text & "','" & TDepartmentsCb.SelectedValue.ToString() & "','" & TAddressTb.Text & "')"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Teacher saved Successfully")
                Con.Close()
                DisplayTeachers()
                Reset()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub Teachers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayTeachers()
        FillDepartment()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If TNameTb.Text = "" Or TAddressTb.Text = "" Or TMobileNoTb.Text = "" Or TGenderCb.SelectedIndex = -1 Or TDepartmentsCb.SelectedIndex = -1 Then
            MsgBox("Missing Information .... !")
        Else
            Try
                Con.Open()
                Dim query = "update TeachersTbl set TName='" & TNameTb.Text & "',TGender='" & TGenderCb.SelectedItem.ToString() & "',TDOB='" & TDOB.Text & "',TPhone='" & TMobileNoTb.Text & "',TDept='" & TDepartmentsCb.SelectedValue.ToString() & "',TAdd='" & TAddressTb.Text & "' where TId=" & Key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Teacher updated Successfully")
                Con.Close()
                DisplayTeachers()
                Reset()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If Key = 0 Then
            MsgBox("Please Select the Teacher to Delete")
        Else
            Try
                Con.Open()
                Dim query = "delete from TeachersTbl where TId=" & Key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Teacher Deleted Successfully")
                Con.Close()
                DisplayTeachers()
                Reset()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Reset()
    End Sub
    Dim Key = 0
    Private Sub TeachersDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TeachersDGV.CellContentClick
        Dim row As DataGridViewRow = TeachersDGV.Rows(e.RowIndex)
        TNameTb.Text = row.Cells(1).Value.ToString
        TGenderCb.SelectedItem = row.Cells(2).Value.ToString
        TDOB.Text = row.Cells(3).Value.ToString
        TMobileNoTb.Text = row.Cells(4).Value.ToString
        TDepartmentsCb.SelectedValue = row.Cells(5).Value.ToString
        TAddressTb.Text = row.Cells(6).Value.ToString
        If TNameTb.Text = "" Then
            Key = 0
        Else
            Key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If

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