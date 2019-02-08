<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.tb_inputgaji = New System.Windows.Forms.TextBox()
        Me.tb_persentase = New System.Windows.Forms.TextBox()
        Me.tb_periode = New System.Windows.Forms.TextBox()
        Me.Bt_hitung = New System.Windows.Forms.Button()
        Me.tb_gaji1 = New System.Windows.Forms.TextBox()
        Me.tb_zakat1 = New System.Windows.Forms.TextBox()
        Me.tb_zakat3 = New System.Windows.Forms.TextBox()
        Me.tb_gaji2 = New System.Windows.Forms.TextBox()
        Me.tb_zakat2 = New System.Windows.Forms.TextBox()
        Me.tb_zakat4 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.bt_akumulasi = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.tb_akumulasi = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tb_inputgaji
        '
        Me.tb_inputgaji.Location = New System.Drawing.Point(43, 42)
        Me.tb_inputgaji.Name = "tb_inputgaji"
        Me.tb_inputgaji.Size = New System.Drawing.Size(178, 20)
        Me.tb_inputgaji.TabIndex = 0
        '
        'tb_persentase
        '
        Me.tb_persentase.Location = New System.Drawing.Point(251, 42)
        Me.tb_persentase.Name = "tb_persentase"
        Me.tb_persentase.Size = New System.Drawing.Size(100, 20)
        Me.tb_persentase.TabIndex = 1
        '
        'tb_periode
        '
        Me.tb_periode.Location = New System.Drawing.Point(371, 42)
        Me.tb_periode.Name = "tb_periode"
        Me.tb_periode.Size = New System.Drawing.Size(99, 20)
        Me.tb_periode.TabIndex = 2
        '
        'Bt_hitung
        '
        Me.Bt_hitung.Location = New System.Drawing.Point(544, 42)
        Me.Bt_hitung.Name = "Bt_hitung"
        Me.Bt_hitung.Size = New System.Drawing.Size(75, 23)
        Me.Bt_hitung.TabIndex = 3
        Me.Bt_hitung.Text = "Button1"
        Me.Bt_hitung.UseVisualStyleBackColor = True
        '
        'tb_gaji1
        '
        Me.tb_gaji1.Location = New System.Drawing.Point(43, 141)
        Me.tb_gaji1.Name = "tb_gaji1"
        Me.tb_gaji1.Size = New System.Drawing.Size(99, 20)
        Me.tb_gaji1.TabIndex = 4
        '
        'tb_zakat1
        '
        Me.tb_zakat1.Location = New System.Drawing.Point(43, 178)
        Me.tb_zakat1.Name = "tb_zakat1"
        Me.tb_zakat1.Size = New System.Drawing.Size(99, 20)
        Me.tb_zakat1.TabIndex = 5
        '
        'tb_zakat3
        '
        Me.tb_zakat3.Location = New System.Drawing.Point(43, 215)
        Me.tb_zakat3.Name = "tb_zakat3"
        Me.tb_zakat3.Size = New System.Drawing.Size(99, 20)
        Me.tb_zakat3.TabIndex = 6
        '
        'tb_gaji2
        '
        Me.tb_gaji2.Location = New System.Drawing.Point(232, 141)
        Me.tb_gaji2.Name = "tb_gaji2"
        Me.tb_gaji2.Size = New System.Drawing.Size(99, 20)
        Me.tb_gaji2.TabIndex = 7
        '
        'tb_zakat2
        '
        Me.tb_zakat2.Location = New System.Drawing.Point(232, 178)
        Me.tb_zakat2.Name = "tb_zakat2"
        Me.tb_zakat2.Size = New System.Drawing.Size(99, 20)
        Me.tb_zakat2.TabIndex = 8
        '
        'tb_zakat4
        '
        Me.tb_zakat4.Location = New System.Drawing.Point(232, 215)
        Me.tb_zakat4.Name = "tb_zakat4"
        Me.tb_zakat4.Size = New System.Drawing.Size(99, 20)
        Me.tb_zakat4.TabIndex = 9
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(410, 141)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(480, 260)
        Me.DataGridView1.TabIndex = 10
        '
        'bt_akumulasi
        '
        Me.bt_akumulasi.Location = New System.Drawing.Point(43, 285)
        Me.bt_akumulasi.Name = "bt_akumulasi"
        Me.bt_akumulasi.Size = New System.Drawing.Size(75, 23)
        Me.bt_akumulasi.TabIndex = 11
        Me.bt_akumulasi.Text = "Akumulasi"
        Me.bt_akumulasi.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(43, 339)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Atur Ulang"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'tb_akumulasi
        '
        Me.tb_akumulasi.Location = New System.Drawing.Point(190, 276)
        Me.tb_akumulasi.Multiline = True
        Me.tb_akumulasi.Name = "tb_akumulasi"
        Me.tb_akumulasi.Size = New System.Drawing.Size(185, 46)
        Me.tb_akumulasi.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(942, 449)
        Me.Controls.Add(Me.tb_akumulasi)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.bt_akumulasi)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.tb_zakat4)
        Me.Controls.Add(Me.tb_zakat2)
        Me.Controls.Add(Me.tb_gaji2)
        Me.Controls.Add(Me.tb_zakat3)
        Me.Controls.Add(Me.tb_zakat1)
        Me.Controls.Add(Me.tb_gaji1)
        Me.Controls.Add(Me.Bt_hitung)
        Me.Controls.Add(Me.tb_periode)
        Me.Controls.Add(Me.tb_persentase)
        Me.Controls.Add(Me.tb_inputgaji)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tb_inputgaji As System.Windows.Forms.TextBox
    Friend WithEvents tb_persentase As System.Windows.Forms.TextBox
    Friend WithEvents tb_periode As System.Windows.Forms.TextBox
    Friend WithEvents Bt_hitung As System.Windows.Forms.Button
    Friend WithEvents tb_gaji1 As System.Windows.Forms.TextBox
    Friend WithEvents tb_zakat1 As System.Windows.Forms.TextBox
    Friend WithEvents tb_zakat3 As System.Windows.Forms.TextBox
    Friend WithEvents tb_gaji2 As System.Windows.Forms.TextBox
    Friend WithEvents tb_zakat2 As System.Windows.Forms.TextBox
    Friend WithEvents tb_zakat4 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents bt_akumulasi As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents tb_akumulasi As System.Windows.Forms.TextBox

End Class
