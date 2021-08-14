<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SFF
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SFF))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.CORRIGIR_BTN = New System.Windows.Forms.Button()
        Me.REVELAR_BTN = New System.Windows.Forms.Button()
        Me.TROCAR_SENHA_LNK = New System.Windows.Forms.LinkLabel()
        Me.ESCONDER_BTN = New System.Windows.Forms.Button()
        Me.REVELAR_BGW = New System.ComponentModel.BackgroundWorker()
        Me.ESCONDER_BGW = New System.ComponentModel.BackgroundWorker()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Processo_lbl = New System.Windows.Forms.Label()
        Me.FilesNames_lbl = New System.Windows.Forms.Label()
        Me.FUNCAO_LBL = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(324, 22)
        Me.Panel1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Silver
        Me.Label3.Location = New System.Drawing.Point(34, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "SFF - Secure File In Folder."
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureBox2.Image = Global.SFF.My.Resources.Resources.SFF1
        Me.PictureBox2.Location = New System.Drawing.Point(12, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.SFF.My.Resources.Resources.Close_8x8
        Me.PictureBox1.Location = New System.Drawing.Point(307, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(8, 8)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI Symbol", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Black
        Me.TextBox1.Location = New System.Drawing.Point(23, 56)
        Me.TextBox1.MaxLength = 6
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(279, 39)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(20, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Password:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button1.Location = New System.Drawing.Point(24, 145)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 50)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Symbol", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(21, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(198, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "ACESSE SEUS ARQUIVOS."
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button2.Location = New System.Drawing.Point(121, 145)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(85, 50)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button3.Location = New System.Drawing.Point(217, 145)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(85, 50)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button4.Location = New System.Drawing.Point(25, 204)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(85, 50)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button5.Location = New System.Drawing.Point(121, 204)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(85, 50)
        Me.Button5.TabIndex = 8
        Me.Button5.Text = "Button5"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'CORRIGIR_BTN
        '
        Me.CORRIGIR_BTN.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CORRIGIR_BTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CORRIGIR_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CORRIGIR_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CORRIGIR_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CORRIGIR_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CORRIGIR_BTN.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.CORRIGIR_BTN.Location = New System.Drawing.Point(217, 204)
        Me.CORRIGIR_BTN.Name = "CORRIGIR_BTN"
        Me.CORRIGIR_BTN.Size = New System.Drawing.Size(85, 50)
        Me.CORRIGIR_BTN.TabIndex = 9
        Me.CORRIGIR_BTN.Text = "«"
        Me.CORRIGIR_BTN.UseVisualStyleBackColor = False
        '
        'REVELAR_BTN
        '
        Me.REVELAR_BTN.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.REVELAR_BTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.REVELAR_BTN.Enabled = False
        Me.REVELAR_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.REVELAR_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.REVELAR_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.REVELAR_BTN.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.REVELAR_BTN.Location = New System.Drawing.Point(25, 263)
        Me.REVELAR_BTN.Name = "REVELAR_BTN"
        Me.REVELAR_BTN.Size = New System.Drawing.Size(132, 50)
        Me.REVELAR_BTN.TabIndex = 10
        Me.REVELAR_BTN.Text = "◆ REVELAR"
        Me.REVELAR_BTN.UseVisualStyleBackColor = False
        '
        'TROCAR_SENHA_LNK
        '
        Me.TROCAR_SENHA_LNK.AutoSize = True
        Me.TROCAR_SENHA_LNK.BackColor = System.Drawing.Color.Transparent
        Me.TROCAR_SENHA_LNK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TROCAR_SENHA_LNK.LinkColor = System.Drawing.Color.Cyan
        Me.TROCAR_SENHA_LNK.Location = New System.Drawing.Point(230, 116)
        Me.TROCAR_SENHA_LNK.Name = "TROCAR_SENHA_LNK"
        Me.TROCAR_SENHA_LNK.Size = New System.Drawing.Size(72, 13)
        Me.TROCAR_SENHA_LNK.TabIndex = 11
        Me.TROCAR_SENHA_LNK.TabStop = True
        Me.TROCAR_SENHA_LNK.Text = "Trocar Senha"
        '
        'ESCONDER_BTN
        '
        Me.ESCONDER_BTN.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ESCONDER_BTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ESCONDER_BTN.Enabled = False
        Me.ESCONDER_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ESCONDER_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ESCONDER_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ESCONDER_BTN.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ESCONDER_BTN.Location = New System.Drawing.Point(170, 263)
        Me.ESCONDER_BTN.Name = "ESCONDER_BTN"
        Me.ESCONDER_BTN.Size = New System.Drawing.Size(132, 50)
        Me.ESCONDER_BTN.TabIndex = 12
        Me.ESCONDER_BTN.Text = "◇ ESCONDER"
        Me.ESCONDER_BTN.UseVisualStyleBackColor = False
        '
        'REVELAR_BGW
        '
        Me.REVELAR_BGW.WorkerReportsProgress = True
        Me.REVELAR_BGW.WorkerSupportsCancellation = True
        '
        'ESCONDER_BGW
        '
        Me.ESCONDER_BGW.WorkerReportsProgress = True
        Me.ESCONDER_BGW.WorkerSupportsCancellation = True
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = Global.SFF.My.Resources.Resources.SFF_32X32
        Me.PictureBox3.Location = New System.Drawing.Point(272, 23)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox3.TabIndex = 13
        Me.PictureBox3.TabStop = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ProgressBar1.Location = New System.Drawing.Point(23, 56)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(279, 39)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 14
        Me.ProgressBar1.Visible = False
        '
        'Processo_lbl
        '
        Me.Processo_lbl.AutoSize = True
        Me.Processo_lbl.BackColor = System.Drawing.Color.Transparent
        Me.Processo_lbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Processo_lbl.Location = New System.Drawing.Point(185, 36)
        Me.Processo_lbl.Name = "Processo_lbl"
        Me.Processo_lbl.Size = New System.Drawing.Size(71, 13)
        Me.Processo_lbl.TabIndex = 15
        Me.Processo_lbl.Text = "Processo: 0%"
        Me.Processo_lbl.Visible = False
        '
        'FilesNames_lbl
        '
        Me.FilesNames_lbl.AutoSize = True
        Me.FilesNames_lbl.BackColor = System.Drawing.Color.Transparent
        Me.FilesNames_lbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.FilesNames_lbl.Location = New System.Drawing.Point(22, 98)
        Me.FilesNames_lbl.Name = "FilesNames_lbl"
        Me.FilesNames_lbl.Size = New System.Drawing.Size(54, 13)
        Me.FilesNames_lbl.TabIndex = 16
        Me.FilesNames_lbl.Text = "Arquivos: "
        Me.FilesNames_lbl.Visible = False
        '
        'FUNCAO_LBL
        '
        Me.FUNCAO_LBL.AutoSize = True
        Me.FUNCAO_LBL.BackColor = System.Drawing.Color.Transparent
        Me.FUNCAO_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FUNCAO_LBL.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.FUNCAO_LBL.Location = New System.Drawing.Point(97, 35)
        Me.FUNCAO_LBL.Name = "FUNCAO_LBL"
        Me.FUNCAO_LBL.Size = New System.Drawing.Size(83, 13)
        Me.FUNCAO_LBL.TabIndex = 17
        Me.FUNCAO_LBL.Text = "ESCONDENDO"
        Me.FUNCAO_LBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.FUNCAO_LBL.Visible = False
        '
        'SFF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.BackgroundImage = Global.SFF.My.Resources.Resources.header_bg
        Me.ClientSize = New System.Drawing.Size(324, 324)
        Me.ControlBox = False
        Me.Controls.Add(Me.FUNCAO_LBL)
        Me.Controls.Add(Me.FilesNames_lbl)
        Me.Controls.Add(Me.Processo_lbl)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.ESCONDER_BTN)
        Me.Controls.Add(Me.TROCAR_SENHA_LNK)
        Me.Controls.Add(Me.REVELAR_BTN)
        Me.Controls.Add(Me.CORRIGIR_BTN)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SFF"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SFF - Secure File In Folder."
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents CORRIGIR_BTN As System.Windows.Forms.Button
    Friend WithEvents REVELAR_BTN As System.Windows.Forms.Button
    Friend WithEvents TROCAR_SENHA_LNK As System.Windows.Forms.LinkLabel
    Public WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ESCONDER_BTN As System.Windows.Forms.Button
    Friend WithEvents REVELAR_BGW As System.ComponentModel.BackgroundWorker
    Friend WithEvents ESCONDER_BGW As System.ComponentModel.BackgroundWorker
    Public WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Processo_lbl As System.Windows.Forms.Label
    Friend WithEvents FilesNames_lbl As System.Windows.Forms.Label
    Friend WithEvents FUNCAO_LBL As System.Windows.Forms.Label

End Class
