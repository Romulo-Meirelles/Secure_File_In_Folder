Imports System.IO
Imports System.Security.Cryptography.X509Certificates
Imports System.Security.Cryptography
Imports System.Text

Public Class SFF
    Dim LOCAT As Point
    ReadOnly Numbers As String() = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"}
    Private ContainPassword As New List(Of String)
    Private TOTALFILESPROCESSE As Integer

    Private Sub SFF_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Text = "SFF - Security File In Folder. Version " & My.Application.Info.Version.ToString
        Me.Label3.Text = "SFF - Security File In Folder. Version " & My.Application.Info.Version.ToString
        Call SetNumberButton()

        If System.IO.File.Exists(My.Application.Info.DirectoryPath & "\Base.00") Then

        Else
            Me.Hide()
            CreatePassword.ShowDialog()
        End If
    End Sub

    Public Sub SetNumberButton()
        Dim N As List(Of String) = New List(Of String)(Numbers)
        Dim B(9) As String

        For i As Integer = N.Count - 1 To 0 Step -1
            Dim Rand As Random = New Random
            Dim Count As Integer = Rand.Next(N.Count)
            Dim Indicator As String = N(Count)
            N.RemoveAt(Count)
            B(i) = Indicator
            Threading.Thread.Sleep(10)
        Next

        Button1.Text = B(0).ToString & " ou " & B(1).ToString
        Button2.Text = B(2).ToString & " ou " & B(3).ToString
        Button3.Text = B(4).ToString & " ou " & B(5).ToString
        Button4.Text = B(6).ToString & " ou " & B(7).ToString
        Button5.Text = B(8).ToString & " ou " & B(9).ToString
    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If ContainPassword.Count >= 6 Then
        Else
            ContainPassword.Add(Button1.Text)
            TextBox1.Text += "*"
        End If

        If TextBox1.Text.Length = 6 Then
            TextBox1.ForeColor = Color.Green
        Else
            TextBox1.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Button2_Click_1(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If ContainPassword.Count >= 6 Then
        Else
            ContainPassword.Add(Button2.Text)
            TextBox1.Text += "*"
        End If

        If TextBox1.Text.Length = 6 Then
            TextBox1.ForeColor = Color.Green
        Else
            TextBox1.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        If ContainPassword.Count >= 6 Then
        Else
            ContainPassword.Add(Button3.Text)
            TextBox1.Text += "*"
        End If

        If TextBox1.Text.Length = 6 Then
            TextBox1.ForeColor = Color.Green
        Else
            TextBox1.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        If ContainPassword.Count >= 6 Then
        Else
            ContainPassword.Add(Button4.Text)
            TextBox1.Text += "*"
        End If

        If TextBox1.Text.Length = 6 Then
            TextBox1.ForeColor = Color.Green
        Else
            TextBox1.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        If ContainPassword.Count >= 6 Then
        Else
            ContainPassword.Add(Button5.Text)
            TextBox1.Text += "*"
        End If

        If TextBox1.Text.Length = 6 Then
            TextBox1.ForeColor = Color.Green
        Else
            TextBox1.ForeColor = Color.Black
        End If
    End Sub
    Private Sub FilesNames(ByVal Name As String)
        Invoke(Sub()
                   FilesNames_lbl.Text = "Arquivos: " & Name
               End Sub)
    End Sub
    Private Sub CORRIGIR_BTN_Click(sender As System.Object, e As System.EventArgs) Handles CORRIGIR_BTN.Click

        If CORRIGIR_BTN.Text = "■ PARAR" Then

            If REVELAR_BGW.IsBusy = True Then
                REVELAR_BGW.CancelAsync()
                REVELAR_BGW.Dispose()
            ElseIf ESCONDER_BGW.IsBusy = True Then
                ESCONDER_BGW.CancelAsync()
                ESCONDER_BGW.Dispose()
            End If
            Exit Sub
        End If

        If TextBox1.Text.Length <> 0 Then
            Dim i = ContainPassword.Count - 1
            ContainPassword.RemoveAt(i)
            TextBox1.Text = TextBox1.Text.Substring(0, TextBox1.Text.Length - 1)
        End If

        If TextBox1.Text.Length = 6 Then
            TextBox1.ForeColor = Color.Green
        Else
            TextBox1.ForeColor = Color.Black
        End If
    End Sub
    Private Sub REVELAR_BTN_Click(sender As System.Object, e As System.EventArgs) Handles REVELAR_BTN.Click
        Dim PATH As String = My.Application.Info.DirectoryPath

        If System.IO.File.Exists(PATH & "\Base.00") Then

        Else
            Me.Hide()
            CreatePassword.ShowDialog()
        End If

        Dim PASS As String = Encoding.Default.GetString(AESD(System.IO.File.ReadAllBytes(PATH & "\Base.00")))

        For I As Integer = 0 To ContainPassword.Count - 1
            If ContainPassword.Item(I).Contains(PASS(I)) Then
            Else
                MessageBox.Show("PASSWORD INCORRETO!", "INCORRETO NEGADO.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TextBox1.Clear()
                ContainPassword.Clear()
                Exit Sub
            End If
        Next

        ProgressBar1.Visible = True
        REVELAR_BGW.WorkerSupportsCancellation = True
        Call REVELAR_BGW.RunWorkerAsync()
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        TROCAR_SENHA_LNK.Enabled = False
        REVELAR_BTN.Enabled = False
        ESCONDER_BTN.Enabled = False
        Processo_lbl.Visible = True
        FilesNames_lbl.Visible = True
        Processo_lbl.Text = "Processo: 0%"
        FilesNames_lbl.Text = "Arquivos: "
        FUNCAO_LBL.Text = "REVELANDO"
        FUNCAO_LBL.ForeColor = Color.DeepSkyBlue
        FUNCAO_LBL.Visible = True
        CORRIGIR_BTN.Text = "■ PARAR" : CORRIGIR_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    End Sub
    Private Sub REVELAR_BGW_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles REVELAR_BGW.DoWork
        On Error Resume Next
        Dim PATH As String = My.Application.Info.DirectoryPath
        Dim EXTENSION_EXCLUDE() As String = {"*.00", "*.EXE", "*.SYS", "*.INI", "*.DLL", "*.BAT", "*.CAB", "*.ACCDB", "*.BIN", "*.OCX", "*.PDB"}
        Dim AllFiles() As String = Directory.GetFiles(PATH & "\", "*.*", SearchOption.AllDirectories)
        Dim FILETOEXCLUDE As List(Of String) = New List(Of String)

        For i = 0 To EXTENSION_EXCLUDE.Length - 1
            For Each FOUNDFILE As String In Directory.GetFiles(PATH & "\", EXTENSION_EXCLUDE(i), SearchOption.AllDirectories)
                FILETOEXCLUDE.Add(FOUNDFILE)
            Next
        Next

        Dim CORRECTFILES() As String = AllFiles.Except(FILETOEXCLUDE).ToArray

        For i As Integer = 0 To CORRECTFILES.Length - 1
            SetAttr(CORRECTFILES(i), FileAttribute.Normal)
            AES_Decrypt(CORRECTFILES(i))
            REVELAR_BGW.ReportProgress(i / CORRECTFILES.Length * 100)
            FilesNames(New IO.FileInfo(CORRECTFILES(i)).Name)
        Next
    End Sub
    Private Sub REVELAR_BGW_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles REVELAR_BGW.ProgressChanged
        Invoke(Sub()
                   Me.ProgressBar1.Value = e.ProgressPercentage
                   Processo_lbl.Text = "Processo: " & e.ProgressPercentage & "%"
               End Sub)
    End Sub
    Private Sub REVELAR_BGW_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles REVELAR_BGW.RunWorkerCompleted
        If (e.Cancelled = True) Then

            MessageBox.Show("OPERAÇÃO CANCELADA PELO USUÁRIO!", "CANCELADO.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ProgressBar1.Value = 0
            TOTALFILESPROCESSE = 0
            ProgressBar1.Maximum = 0
            ProgressBar1.Visible = False
            TextBox1.Clear()
            ContainPassword.Clear()
            Button1.Enabled = True
            Button2.Enabled = True
            Button3.Enabled = True
            Button4.Enabled = True
            Button5.Enabled = True
            Processo_lbl.Visible = False
            FilesNames_lbl.Visible = False
            FUNCAO_LBL.Visible = False
            TROCAR_SENHA_LNK.Enabled = True
            CORRIGIR_BTN.Text = "«" : CORRIGIR_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Call SetNumberButton()
        Else
            My.Computer.Audio.Play(My.Resources.Sound, AudioPlayMode.Background)
            MessageBox.Show("ARQUIVOS DECRIPTADO COM SUCESSO!", "ARQUIVOS INSEGUROS.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ProgressBar1.Value = 0
            ProgressBar1.Visible = False
            TextBox1.Clear()
            ContainPassword.Clear()
            Button1.Enabled = True
            Button2.Enabled = True
            Button3.Enabled = True
            Button4.Enabled = True
            Button5.Enabled = True
            Processo_lbl.Visible = False
            FilesNames_lbl.Visible = False
            FUNCAO_LBL.Visible = False
            TROCAR_SENHA_LNK.Enabled = True
            CORRIGIR_BTN.Text = "«" : CORRIGIR_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Call SetNumberButton()
        End If
    End Sub
    Private Sub ESCONDER_BTN_Click(sender As System.Object, e As System.EventArgs) Handles ESCONDER_BTN.Click
        Dim PATH As String = My.Application.Info.DirectoryPath

        If System.IO.File.Exists(PATH & "\Base.00") Then

        Else
            Me.Hide()
            CreatePassword.ShowDialog()
        End If

        Dim PASS As String = Encoding.Default.GetString(AESD(System.IO.File.ReadAllBytes(PATH & "\Base.00")))

        For I As Integer = 0 To ContainPassword.Count - 1
            If ContainPassword.Item(I).Contains(PASS(I)) Then
            Else
                MessageBox.Show("PASSWORD INCORRETO!", "INCORRETO NEGADO.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TextBox1.Clear()
                ContainPassword.Clear()
                Exit Sub
            End If
        Next

        ProgressBar1.Visible = True
        ESCONDER_BGW.WorkerSupportsCancellation = True
        Call ESCONDER_BGW.RunWorkerAsync()
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        TROCAR_SENHA_LNK.Enabled = False
        REVELAR_BTN.Enabled = False
        ESCONDER_BTN.Enabled = False
        Processo_lbl.Visible = True
        FilesNames_lbl.Visible = True
        Processo_lbl.Text = "Processo: 0%"
        FilesNames_lbl.Text = "Arquivos: "
        FUNCAO_LBL.Text = "ESCONDENDO"
        FUNCAO_LBL.ForeColor = Color.LimeGreen
        FUNCAO_LBL.Visible = True
        CORRIGIR_BTN.Text = "■ PARAR" : CORRIGIR_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    End Sub
    Private Sub ESCONDER_BGW_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles ESCONDER_BGW.DoWork
        On Error Resume Next
        Dim PATH As String = My.Application.Info.DirectoryPath
        Dim EXTENSION_EXCLUDE() As String = {"*.00", "*.EXE", "*.SYS", "*.INI", "*.DLL", "*.BAT", "*.CAB", "*.ACCDB", "*.BIN", "*.OCX", "*.PDB"}
        Dim AllFiles() As String = Directory.GetFiles(PATH & "\", "*.*", SearchOption.AllDirectories)
        Dim FILETOEXCLUDE As List(Of String) = New List(Of String)

        For i = 0 To EXTENSION_EXCLUDE.Length - 1
            For Each FOUNDFILE As String In Directory.GetFiles(PATH & "\", EXTENSION_EXCLUDE(i), SearchOption.AllDirectories)
                FILETOEXCLUDE.Add(FOUNDFILE)
            Next
        Next

        Dim CORRECTFILES() As String = AllFiles.Except(FILETOEXCLUDE).ToArray

        For i As Integer = 0 To CORRECTFILES.Length - 1
            AES_Encrypt(CORRECTFILES(i))
            SetAttr(CORRECTFILES(i), FileAttribute.Hidden)
            ESCONDER_BGW.ReportProgress(i / CORRECTFILES.Length * 100)
            FilesNames(New IO.FileInfo(CORRECTFILES(i)).Name)
        Next
    End Sub
    Private Sub ESCONDER_BGW_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles ESCONDER_BGW.ProgressChanged
        Invoke(Sub()
                   Me.ProgressBar1.Value = e.ProgressPercentage
                   Processo_lbl.Text = "Processo: " & e.ProgressPercentage & "%"
               End Sub)
    End Sub
    Private Sub ESCONDER_BGW_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles ESCONDER_BGW.RunWorkerCompleted

        If (e.Cancelled = True) Then
            MessageBox.Show("OPERAÇÃO CANCELADA PELO USUÁRIO!", "CANCELADO.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ProgressBar1.Value = 0
            TOTALFILESPROCESSE = 0
            ProgressBar1.Maximum = 0
            ProgressBar1.Visible = False
            TextBox1.Clear()
            ContainPassword.Clear()
            Button1.Enabled = True
            Button2.Enabled = True
            Button3.Enabled = True
            Button4.Enabled = True
            Button5.Enabled = True
            Processo_lbl.Visible = False
            FilesNames_lbl.Visible = False
            FUNCAO_LBL.Visible = False
            TROCAR_SENHA_LNK.Enabled = True
            CORRIGIR_BTN.Text = "«" : CORRIGIR_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Call SetNumberButton()
        Else
            My.Computer.Audio.Play(My.Resources.Sound, AudioPlayMode.Background)
            MessageBox.Show("ARQUIVOS ENCRIPTADO COM SUCESSO!", "ARQUIVOS SEGURO.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ProgressBar1.Value = 0
            ProgressBar1.Visible = False
            TextBox1.Clear()
            ContainPassword.Clear()
            Button1.Enabled = True
            Button2.Enabled = True
            Button3.Enabled = True
            Button4.Enabled = True
            Button5.Enabled = True
            Processo_lbl.Visible = False
            FilesNames_lbl.Visible = False
            FUNCAO_LBL.Visible = False
            TROCAR_SENHA_LNK.Enabled = True
            CORRIGIR_BTN.Text = "«" : CORRIGIR_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Call SetNumberButton()
        End If
    End Sub
    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        Try
            ESCONDER_BGW.CancelAsync()
            REVELAR_BGW.CancelAsync()
            End
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        End
    End Sub
    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text.Length >= 6 Then
            REVELAR_BTN.Enabled = True
            ESCONDER_BTN.Enabled = True
        Else
            REVELAR_BTN.Enabled = False
            ESCONDER_BTN.Enabled = False
        End If
    End Sub
    Private Sub TROCAR_SENHA_LNK_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles TROCAR_SENHA_LNK.LinkClicked
        If System.IO.File.Exists(My.Application.Info.DirectoryPath & "\Base.00") Then
            Me.Hide()
            TradePassword.ShowDialog()
        Else
            Me.Hide()
            CreatePassword.ShowDialog()
        End If
    End Sub
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
    Private Sub PictureBox3_Click(sender As Object, e As System.EventArgs) Handles PictureBox3.Click
        About.Show()
    End Sub
    Private Sub PictureBox3_MouseLeave(sender As Object, e As System.EventArgs) Handles PictureBox3.MouseLeave
        About.Close()
    End Sub
End Class
