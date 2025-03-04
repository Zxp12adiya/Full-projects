Imports System.Data.SqlClient
Public Class Fees_Deposit
    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Full Projects\College Management System 1.0\College Management System\CMSDatabase.mdf;Integrated Security=True")
    Private Sub Fees_Deposit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayPayments()
        FillStudents()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub
    Private Sub FillStudents()
        Con.Open()
        Dim query = "select * from StudentsTbl"
        Dim cmd As New SqlCommand(query, Con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim Tbl As New DataTable()
        adapter.Fill(Tbl)
        StIdCb.DataSource = Tbl
        StIdCb.DisplayMember = "StId"
        StIdCb.ValueMember = "StId"
        Con.Close()
    End Sub
    Private Sub DisplayPayments()
        Con.Open()
        Dim query = "select * from FeesTbl"
        Dim adapter As SqlDataAdapter
        Dim cmd = New SqlCommand(query, Con)
        adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        FeesDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Private Sub Reset()
        AmountTb.Text = ""
        StNameTb.Text = ""
        StIdCb.SelectedIndex = -1
    End Sub
    Private Sub UpdateStudents()
        Try
            Con.Open()
            Dim query = "update StudentsTbl set StFees=" & AmountTb.Text & " where StId=" & StIdCb.SelectedValue.ToString() & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Fees updated Successfully")
            Con.Close()
            DisplayPayments()
            Reset()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub GetStName()
        Con.Open()
        Dim query = "select * from StudentsTbl where StId=" & StIdCb.SelectedValue.ToString() & ""
        Dim cmd As New SqlCommand(query, Con)
        Dim dt As New DataTable
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader()
        While reader.Read
            StNameTb.Text = reader(1).ToString()
        End While
        Con.Close()
    End Sub
    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        If StNameTb.Text = "" Or AmountTb.Text = "" Then
            MsgBox("Missing Information .... !")
        ElseIf Convert.ToInt32(AmountTb.Text) > 100000 Or Convert.ToInt32(AmountTb.Text) < 1 Then
            MsgBox("Wrong Amount")
        Else
            Try
                Con.Open()
                Dim query = "insert into FeesTbl values(" & StIdCb.SelectedValue.ToString() & ",'" & StNameTb.Text & "','" & Period.Value.Date & "'," & AmountTb.Text & ")"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Fees Paid Successfully")
                Con.Close()
                DisplayPayments()
                UpdateStudents()
                Reset()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub StIdCb_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles StIdCb.SelectionChangeCommitted
        GetStName()
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