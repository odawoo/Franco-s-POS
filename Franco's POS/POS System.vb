Imports MySql.Data.MySqlClient

Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports System.IO

Public Class POS_System

    Const VAT = 0.16

    Dim saveFileDialog1 As New SaveFileDialog()

    Public Sub ExportDataToPDFTable()

        Try

            Dim R = New Receipt

            Dim paragraph As New Paragraph
            Dim paragragh2 As New Paragraph
            Dim paragragh3 As New Paragraph
            Dim paragragh4 As New Paragraph
            Dim paragragh5 As New Paragraph
            Dim paragragh6 As New Paragraph
            Dim paragragh7 As New Paragraph
            Dim paragragh8 As New Paragraph
            Dim paragragh9 As New Paragraph
            Dim paragragh10 As New Paragraph
            Dim paragragh11 As New Paragraph
            Dim paragragh12 As New Paragraph
            Dim paragragh13 As New Paragraph
            Dim doc As New Document(PageSize.A6)
            Dim write As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(saveFileDialog1.FileName + ".pdf", FileMode.Create))
            doc.Open()


            Dim font12BoldBlack As New Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12.0F, iTextSharp.text.Font.UNDERLINE Or iTextSharp.text.Font.BOLDITALIC, BaseColor.BLACK)
            Dim font12Bold As New Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12.0F, iTextSharp.text.Font.BOLDITALIC, BaseColor.BLACK)
            Dim font12Normal As New Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12.0F, iTextSharp.text.Font.NORMAL, BaseColor.BLACK)

            paragraph = New Paragraph(New Chunk("Franco's Hardware Store
    Nairobi, Kenya
    Nairobi Rd.
    P.O. Box 00000-00100



    ", font12Bold))
            paragraph.Alignment = Element.ALIGN_CENTER
            paragraph.SpacingAfter = 5.0F
            doc.Add(paragraph)

            paragragh2 = New Paragraph(New Chunk("Cash Sale # :           " + txttransactionid.Text, font12Normal))
            paragraph.Alignment = Element.ALIGN_LEFT
            paragraph.SpacingAfter = 2.0F
            doc.Add(paragragh2)

            paragragh3 = New Paragraph(New Chunk("                      "))
            paragraph.Alignment = Element.ALIGN_LEFT
            paragraph.SpacingAfter = 2.0F
            doc.Add(paragragh3)

            paragragh4 = New Paragraph(New Chunk("_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _"))
            paragraph.Alignment = Element.ALIGN_LEFT
            paragraph.SpacingAfter = 0.0F
            doc.Add(paragragh4)

            paragragh5 = New Paragraph(New Chunk("                      "))
            paragraph.Alignment = Element.ALIGN_LEFT
            paragraph.SpacingAfter = 2.0F
            doc.Add(paragragh3)

            paragragh6 = New Paragraph(New Chunk("Total :                          " + "Ksh." + txttotal.Text, font12Normal))
            paragraph.Alignment = Element.ALIGN_LEFT
            paragraph.SpacingAfter = 2.0F
            doc.Add(paragragh6)

            paragragh7 = New Paragraph(New Chunk("Amount Received :     " + "Ksh." + txtar.Text, font12Normal))
            paragraph.Alignment = Element.ALIGN_LEFT
            paragraph.SpacingAfter = 2.0F
            doc.Add(paragragh7)

            paragragh8 = New Paragraph(New Chunk("Balance :                     " + "Ksh." + txtchange.Text, font12Normal))
            paragraph.Alignment = Element.ALIGN_LEFT
            paragraph.SpacingAfter = 2.0F
            doc.Add(paragragh8)

            paragragh9 = New Paragraph(New Chunk("_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _"))
            paragraph.Alignment = Element.ALIGN_LEFT
            paragraph.SpacingAfter = 2.0F
            doc.Add(paragragh9)

            paragragh10 = New Paragraph(New Chunk("RATE    VATABLE AMT       VAT AMT", font12Normal))
            paragraph.Alignment = Element.ALIGN_LEFT
            paragraph.SpacingAfter = 2.0F
            doc.Add(paragragh10)

            paragragh11 = New Paragraph(New Chunk("16%" + "             " + "Ksh." + txtsubtotal.Text + "               " + "Ksh." + txtvat.Text, font12Normal))
            paragraph.Alignment = Element.ALIGN_LEFT
            paragraph.SpacingAfter = 2.0F
            doc.Add(paragragh11)

            paragragh12 = New Paragraph(New Chunk("_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _"))
            paragraph.Alignment = Element.ALIGN_LEFT
            paragraph.SpacingAfter = 2.0F
            doc.Add(paragragh12)

            paragragh13 = New Paragraph(New Chunk("Prices Inclusive Of VAT Where Applicable"))
            paragraph.Alignment = Element.ALIGN_LEFT
            paragraph.SpacingAfter = 2.0F
            doc.Add(paragragh13)

            doc.Close()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub


    Private Sub Btncheckout_Click(sender As Object, e As EventArgs) Handles btncheckout.Click

        Dim AT = New AllTransactions

        Try

            sql = "UPDATE alltransactions SET amountreceived=@ar, balance=@b WHERE transactionid=@tid"
            DbConn()

            cmd = New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@tid", txttransactionid.Text)
            cmd.Parameters.AddWithValue("@ar", txtar.Text)
            cmd.Parameters.AddWithValue("@b", txtchange.Text)

            Dim n As Integer

            n = cmd.ExecuteNonQuery()

            If (n > 0 = True) Then


                saveFileDialog1.ShowDialog()
                If saveFileDialog1.FileName = "" Then
                    MsgBox("Enter Filename to create PDF")
                    Exit Sub
                Else
                    ExportDataToPDFTable()
                    MsgBox("PDF Created Successfully")
                End If


                sql = "DELETE FROM `transactions` WHERE transactionid=@tid"
                DbConn()
                cmd = New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@tid", txttransactionid.Text)

                Dim i As Integer

                i = cmd.ExecuteNonQuery()

                If (i > 0 = True) Then

                    DataGridCheckout()

                    sql = "DELETE FROM `receipts` WHERE transactionid=@tid"
                    DbConn()
                    cmd = New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@tid", txttransactionid.Text)

                    txttransactionid.Clear()
                    txtsubtotal.Clear()
                    txtvat.Clear()
                    txttotal.Clear()
                    txtar.Clear()
                    txtchange.Clear()
                    Me.Refresh()

                Else

                    MsgBox("Unfortunately the item could not be deleted.Please try again.")

                End If

            End If


            cmd.Dispose()
            conn.Close()
            conn.Dispose()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Public Sub GetTransactionID()

        Try

            sql = "SELECT `transactionid` FROM `alltransactions` ORDER BY transactionid desc"
            DbConn()
            cmd = New MySqlCommand(sql, conn)

            Dim number As Integer
            If IsDBNull(cmd.ExecuteScalar) Then

                number = 1000
                txttransactionid.Text = number

            Else

                number = cmd.ExecuteScalar + 1
                txttransactionid.Text = number

            End If
            cmd.Dispose()
            conn.Close()
            conn.Dispose()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Sub DataGridCheckout()

        Try

            sql = "SELECT * FROM transactions"
            DbConn()

            cmd = New MySqlCommand(sql, conn)
            da = New MySqlDataAdapter
            dtable = New DataTable
            bsrc = New BindingSource

            da.SelectCommand = cmd
            da.Fill(dtable)
            bsrc.DataSource = dtable
            DataGridView5.DataSource = bsrc
            da.Update(dtable)

            cmd.Dispose()
            conn.Close()
            conn.Dispose()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Sub DataGridPOS()

        Try

            sql = "SELECT * FROM products"
            DbConn()

            cmd = New MySqlCommand(sql, conn)
            da = New MySqlDataAdapter
            dtable = New DataTable
            bsrc = New BindingSource

            da.SelectCommand = cmd
            da.Fill(dtable)
            bsrc.DataSource = dtable
            DataGridView4.DataSource = bsrc
            da.Update(dtable)

            cmd.Dispose()
            conn.Close()
            conn.Dispose()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub POS_System_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GetTransactionID()
        DataGridPOS()
        DataGridCheckout()

        DbConn()


    End Sub

    Private Sub DataGridView4_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView4.CellClick

        Dim row As DataGridViewRow = DataGridView4.CurrentRow

        Try

            txtproductid.Text = row.Cells(0).Value.ToString()
            txtproductname.Text = row.Cells(1).Value.ToString()
            txtproductdescription.Text = row.Cells(2).Value.ToString()
            txtbrandname.Text = row.Cells(3).Value.ToString()
            txtcategoryname.Text = row.Cells(4).Value.ToString()
            txtprice.Text = row.Cells(6).Value.ToString()
            txtqty.Text = row.Cells(7).Value.ToString()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles btn0.Click

        If txtPquantity.Text = "0" Then
        Else txtPquantity.Text = txtPquantity.Text + "0"
        End If

    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click

        If txtPquantity.Text = "1" Then
        Else txtPquantity.Text = txtPquantity.Text + "1"
        End If

    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click

        If txtPquantity.Text = "2" Then
        Else txtPquantity.Text = txtPquantity.Text + "2"
        End If

    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click

        If txtPquantity.Text = "3" Then
        Else txtPquantity.Text = txtPquantity.Text + "3"
        End If

    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click

        If txtPquantity.Text = "4" Then
        Else txtPquantity.Text = txtPquantity.Text + "4"
        End If

    End Sub

    Private Sub Btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click

        If txtPquantity.Text = "5" Then
        Else txtPquantity.Text = txtPquantity.Text + "5"
        End If

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btn6.Click

        If txtPquantity.Text = "6" Then
        Else txtPquantity.Text = txtPquantity.Text + "6"
        End If

    End Sub

    Private Sub Btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click

        If txtPquantity.Text = "7" Then
        Else txtPquantity.Text = txtPquantity.Text + "7"
        End If

    End Sub

    Private Sub Btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click

        If txtPquantity.Text = "8" Then
        Else txtPquantity.Text = txtPquantity.Text + "8"
        End If

    End Sub

    Private Sub Btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click

        If txtPquantity.Text = "9" Then
        Else txtPquantity.Text = txtPquantity.Text + "9"
        End If

    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click

        Me.Hide()
        Dim Main = New MainForm
        Main.Show()

    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click

        Try

            sql = "DELETE FROM `transactions` WHERE productid=@pid"
            DbConn()

            cmd = New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@pid", txtproductid.Text)

            Dim i As Integer

            i = cmd.ExecuteNonQuery()

            If (i > 0 = True) Then

                txtproductid.Clear()
                txtproductname.Clear()
                txtproductdescription.Clear()
                txtbrandname.ResetText()
                txtcategoryname.ResetText()
                txtprice.Clear()
                txtPquantity.Clear()
                txtsubtotal.Refresh()
                txtvat.Refresh()
                txttotal.Refresh()
                DataGridCheckout()

            Else

                MsgBox("Unfortunately the item could not be deleted.Please try again.")

            End If
            cmd.Dispose()
            conn.Close()
            conn.Dispose()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click

        txtPquantity.Clear()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click

        Try

            sql = "UPDATE products SET quantity=@qty WHERE productid=@pid"
            DbConn()
            cmd = New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@pid", txtproductid.Text)
            cmd.Parameters.AddWithValue("@qty", (txtqty.Text - txtPquantity.Text))
            cmd.ExecuteNonQuery()
            DataGridPOS()


            sql = "INSERT INTO `transactions`(`transactionid`, `productid`, `product`, `brandname`, `categoryname`, `quantity`, `price`, `st.price`) VALUES (@tid, @pid, @pname, @bname, @cname, @quantity, @sprice, @stprice)"
            DbConn()
            cmd = New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@tid", txttransactionid.Text)
            cmd.Parameters.AddWithValue("@pid", txtproductid.Text)
            cmd.Parameters.AddWithValue("@pname", txtproductname.Text)
            cmd.Parameters.AddWithValue("@bname", txtbrandname.Text)
            cmd.Parameters.AddWithValue("@cname", txtcategoryname.Text)
            cmd.Parameters.AddWithValue("@sprice", txtprice.Text)
            cmd.Parameters.AddWithValue("@quantity", txtPquantity.Text)
            cmd.Parameters.AddWithValue("@stprice", (txtPquantity.Text * txtprice.Text))

            Dim a As Integer

            a = cmd.ExecuteNonQuery()

            If (a > 0 = True) Then

                DataGridCheckout()

                Dim sum1 As Integer = 0
                For i As Integer = 0 To DataGridView5.Rows.Count() - 1 Step +1
                    sum1 = sum1 + DataGridView5.Rows(i).Cells(8).Value
                Next
                txtsubtotal.Text = sum1.ToString()
                txtvat.Text = (txtsubtotal.Text * 0.16)
                Dim sum As Integer = 0
                For i As Integer = 0 To DataGridView5.Rows.Count() - 1 Step +1
                    sum = sum + DataGridView5.Rows(i).Cells(8).Value + (txtvat.Text / 2)
                Next
                txttotal.Text = sum.ToString()


                sql = "INSERT INTO `alltransactions`(`transactionid`, `productid`, `productname`, `productbrand`, `productcategory`, `price`, `quantity`, `subtotal`, `vat`, `totalprice`) VALUES(@tid, @pid, @pname, @bname, @cname, @price, @quantity, @stotal, @vat, @tprice)"
                DbConn()
                cmd = New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@tid", txttransactionid.Text)
                cmd.Parameters.AddWithValue("@pid", txtproductid.Text)
                cmd.Parameters.AddWithValue("@pname", txtproductname.Text)
                cmd.Parameters.AddWithValue("@bname", txtbrandname.Text)
                cmd.Parameters.AddWithValue("@cname", txtcategoryname.Text)
                cmd.Parameters.AddWithValue("@price", txtprice.Text)
                cmd.Parameters.AddWithValue("@quantity", txtPquantity.Text)
                cmd.Parameters.AddWithValue("@stotal", txtsubtotal.Text)
                cmd.Parameters.AddWithValue("@vat", txtvat.Text)
                cmd.Parameters.AddWithValue("@tprice", txttotal.Text)

                Dim q As Integer
                q = cmd.ExecuteNonQuery
                If (q > 0 = True) Then

                    sql = "INSERT INTO `receipt`(`transactionid`, `productid`, `productname`, `productbrand`, `productcategory`, `price`, `quantity`) VALUES(@tid, @pid, @pname, @bname, @cname, @price, @quantity)"
                    DbConn()
                    cmd = New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@tid", txttransactionid.Text)
                    cmd.Parameters.AddWithValue("@pid", txtproductid.Text)
                    cmd.Parameters.AddWithValue("@pname", txtproductname.Text)
                    cmd.Parameters.AddWithValue("@bname", txtbrandname.Text)
                    cmd.Parameters.AddWithValue("@cname", txtcategoryname.Text)
                    cmd.Parameters.AddWithValue("@price", txtprice.Text)
                    cmd.Parameters.AddWithValue("@quantity", txtPquantity.Text)

                    Dim u As Integer
                    u = cmd.ExecuteNonQuery
                    If (u > 0 = True) Then

                        Receipt.DataGridR()

                    Else

                        MsgBox("Failed")

                    End If
                Else

                    MsgBox("Failed")

                End If

                txtproductid.Clear()
                txtproductname.Clear()
                txtproductdescription.Clear()
                txtproductid.Clear()
                txtbrandname.Clear()
                txtcategoryname.Clear()
                txtPquantity.Clear()
                txtprice.Clear()
                txtqty.Clear()

            Else

                MsgBox("Unfortunately the item could not be added.Please try again.")

            End If
            cmd.Dispose()
            conn.Close()
            conn.Dispose()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try



    End Sub

    Private Sub DataGridView5_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView5.CellClick

        Dim row As DataGridViewRow = DataGridView5.CurrentRow

        Try

            txtproductid.Text = row.Cells(2).Value.ToString()
            txtproductname.Text = row.Cells(3).Value.ToString()
            txtbrandname.Text = row.Cells(4).Value.ToString()
            txtcategoryname.Text = row.Cells(5).Value.ToString()
            txtprice.Text = row.Cells(6).Value.ToString()
            txtPquantity.Text = row.Cells(7).Value.ToString()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Txtar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtar.KeyPress

        Try
            If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "." Then
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        txtchange.Text = txtar.Text - txttotal.Text

    End Sub

    Private Sub txtPquantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPquantity.KeyPress

        Try
            If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub txttransactionid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttransactionid.KeyPress

        Try
            If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click

        Dim r = New Receipt
        r.Show()

    End Sub
End Class