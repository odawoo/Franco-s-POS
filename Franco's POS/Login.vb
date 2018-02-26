Imports MySql.Data.MySqlClient

Public Class Login

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Try

            sql = "SELECT * FROM `profiles` WHERE username = '" & txtusername.Text & "' And password = '" & txtpassword.Text & "'"
            DbConn()

            cmd = New MySqlCommand(sql, conn)

            dr = cmd.ExecuteReader()

            If (dr.Read = True) Then

                Dim MainForm = New MainForm
                MainForm.lblempid.Text = dr("employeeid")
                MainForm.lbllastname.Text = dr("lastname")
                MainForm.Show()
                Me.Hide()

            ElseIf (txtusername.Text = "" And txtpassword.Text = "") Then

                starusername.Text = "*"
                starpassword.Text = "*"
                MsgBox("Please Fill In Any Blank Spaces")

            ElseIf (dr.Read = False) Then

                MsgBox("Please Enter Valid Username Or Password")

            End If

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
        cmd.Dispose()
        conn.Close()
        conn.Dispose()

    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        Application.Exit()

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class