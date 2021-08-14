Imports System.Text

Public Class TradePassword
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

    Private Sub TROCAR_BTN_BTN_Click(sender As System.Object, e As System.EventArgs) Handles TROCAR_BTN.Click

        Dim PATH As String = My.Application.Info.DirectoryPath

        If Not System.IO.File.Exists(PATH & "\Base.00") Then
            Me.Hide()
            CreatePassword.ShowDialog()
        Else

            Dim PASS_OLD As String = Encoding.Default.GetString(AESD(System.IO.File.ReadAllBytes(PATH & "\Base.00")))

            If TextBox1.Text <> PASS_OLD Then
                MessageBox.Show("A SENHA ANTIGA NÃO CONDIZ!", "SENHAS INCOMPATÍVEIS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            If TextBox2.Text <> TextBox3.Text Then
                MessageBox.Show("A SENHA SENHA DE SEGURANÇA É DIFERENTE!", "SENHAS DIFERENTES.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            SetAttr(PATH, FileAttribute.Normal)
            Dim PASS As Byte() = Encoding.Default.GetBytes(TextBox2.Text)
            System.IO.File.WriteAllBytes(PATH & "\Base.00", AESE(PASS))
            SetAttr(PATH, FileAttribute.Hidden)
            MessageBox.Show("PASSWORD MODIFICADO COM SUCESSO!", "PASSWORD MODIFICADO.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
            SFF.Show()

        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox2.TextChanged
        Call TextBox3_TextChanged(sender, e)
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged
        Call TextBox3_TextChanged(sender, e)
    End Sub
    Private Sub TextBox3_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox3.TextChanged
        If TextBox1.Text.Length = 6 And TextBox2.Text.Length = 6 And TextBox3.Text.Length = 6 Then
            TROCAR_BTN.Enabled = True
        Else
            TROCAR_BTN.Enabled = False
        End If
    End Sub
End Class