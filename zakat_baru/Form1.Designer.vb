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
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Nomor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sisa_hutang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Akumulasi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tb_inputgaji
        '
        Me.tb_inputgaji.Location = New System.Drawing.Point(43, 61)
        Me.tb_inputgaji.Name = "tb_inputgaji"
        Me.tb_inputgaji.Size = New System.Drawing.Size(129, 20)
        Me.tb_inputgaji.TabIndex = 0
        '
        'tb_persentase
        '
        Me.tb_persentase.Location = New System.Drawing.Point(184, 61)
        Me.tb_persentase.Name = "tb_persentase"
        Me.tb_persentase.Size = New System.Drawing.Size(54, 20)
        Me.tb_persentase.TabIndex = 1
        '
        'tb_periode
        '
        Me.tb_periode.Location = New System.Drawing.Point(267, 61)
        Me.tb_periode.Name = "tb_periode"
        Me.tb_periode.Size = New System.Drawing.Size(54, 20)
        Me.tb_periode.TabIndex = 2
        '
        'Bt_hitung
        '
        Me.Bt_hitung.Location = New System.Drawing.Point(338, 61)
        Me.Bt_hitung.Name = "Bt_hitung"
        Me.Bt_hitung.Size = New System.Drawing.Size(75, 23)
        Me.Bt_hitung.TabIndex = 3
        Me.Bt_hitung.Text = "Hitung"
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
        Me.tb_zakat1.Location = New System.Drawing.Point(43, 184)
        Me.tb_zakat1.Name = "tb_zakat1"
        Me.tb_zakat1.Size = New System.Drawing.Size(99, 20)
        Me.tb_zakat1.TabIndex = 5
        '
        'tb_zakat3
        '
        Me.tb_zakat3.Location = New System.Drawing.Point(43, 227)
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
        Me.tb_zakat2.Location = New System.Drawing.Point(232, 184)
        Me.tb_zakat2.Name = "tb_zakat2"
        Me.tb_zakat2.Size = New System.Drawing.Size(99, 20)
        Me.tb_zakat2.TabIndex = 8
        '
        'tb_zakat4
        '
        Me.tb_zakat4.Location = New System.Drawing.Point(232, 227)
        Me.tb_zakat4.Name = "tb_zakat4"
        Me.tb_zakat4.Size = New System.Drawing.Size(99, 20)
        Me.tb_zakat4.TabIndex = 9
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nomor, Me.Sisa_hutang, Me.Akumulasi})
        Me.DataGridView1.Location = New System.Drawing.Point(426, 40)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(332, 381)
        Me.DataGridView1.TabIndex = 10
        '
        'bt_akumulasi
        '
        Me.bt_akumulasi.Location = New System.Drawing.Point(43, 267)
        Me.bt_akumulasi.Name = "bt_akumulasi"
        Me.bt_akumulasi.Size = New System.Drawing.Size(140, 23)
        Me.bt_akumulasi.TabIndex = 11
        Me.bt_akumulasi.Text = "Akumulasi"
        Me.bt_akumulasi.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(43, 314)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(140, 23)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Atur Ulang"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'tb_akumulasi
        '
        Me.tb_akumulasi.Location = New System.Drawing.Point(230, 267)
        Me.tb_akumulasi.Multiline = True
        Me.tb_akumulasi.Name = "tb_akumulasi"
        Me.tb_akumulasi.Size = New System.Drawing.Size(143, 35)
        Me.tb_akumulasi.TabIndex = 13
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(147, 229)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 13)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "/bulan"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(146, 187)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "/tahun"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(146, 144)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "/tahun"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(40, 210)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(35, 13)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "Zakat"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(40, 167)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(35, 13)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "Zakat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 124)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 13)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Gaji"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(230, 210)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Zakat"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(230, 167)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Zakat"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(230, 124)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 13)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Gaji"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(336, 231)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "/bulan"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(335, 188)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "/tahun"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(335, 145)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "/tahun"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(265, 40)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 13)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "Periode ke-"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(182, 40)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(73, 13)
        Me.Label12.TabIndex = 41
        Me.Label12.Text = "Kenaikan Gaji"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(182, 26)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(60, 13)
        Me.Label15.TabIndex = 40
        Me.Label15.Text = "Persentase"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(40, 40)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(112, 13)
        Me.Label16.TabIndex = 39
        Me.Label16.Text = "Masukkan Gaji Anda :"
        '
        'Nomor
        '
        Me.Nomor.HeaderText = "Bulan Ke-"
        Me.Nomor.Name = "Nomor"
        '
        'Sisa_hutang
        '
        Me.Sisa_hutang.HeaderText = "Sisa Hutang"
        Me.Sisa_hutang.Name = "Sisa_hutang"
        '
        'Akumulasi
        '
        Me.Akumulasi.HeaderText = "Akumulasi"
        Me.Akumulasi.Name = "Akumulasi"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(805, 449)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
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
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Nomor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sisa_hutang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Akumulasi As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
