Imports System.Security.Cryptography
Imports System.Text
Public Class CreatePassword
    Dim LOCAT As Point

    Private Sub PictureBox2_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox2.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            LOCAT = e.Location
        End If
    End Sub

    Private Sub PictureBox2_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox2.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += e.Location - LOCAT
        End If
    End Sub

    Private Sub Label3_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Label3.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            LOCAT = e.Location
        End If
    End Sub

    Private Sub Label3_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Label3.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += e.Location - LOCAT
        End If
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            LOCAT = e.Location
        End If
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += e.Location - LOCAT
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        Me.Close()
        SFF.Show()
    End Sub

    Private Sub CRIAR_BTN_Click(sender As System.Object, e As System.EventArgs) Handles CRIAR_BTN.Click
        If System.IO.File.Exists(My.Application.Info.DirectoryPath & "\Base.00") Then
            Me.Hide()
            TradePassword.ShowDialog()
        Else
            Dim PATH As String = My.Application.Info.DirectoryPath & "\Base.00"
            Dim PASS As Byte() = Encoding.Default.GetBytes(TextBox1.Text)
            System.IO.File.WriteAllBytes(PATH, AESE(PASS))
            SetAttr(PATH, FileAttribute.Hidden)
            MessageBox.Show("PASSWORD CRIADO COM SUCESSO!", "PASSWORD CRIADO.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            SFF.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text.Length >= 6 Then
            CRIAR_BTN.Enabled = True
        Else
            CRIAR_BTN.Enabled = False
        End If
    End Sub
End Class