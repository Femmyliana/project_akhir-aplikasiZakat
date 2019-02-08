Imports System.Data.SqlClient

Public Class Form1

    Sub reset()
        tb_akumulasi.Clear()
        tb_gaji1.Clear()
        tb_gaji2.Clear()
        tb_inputgaji.Clear()
        tb_periode.Clear()
        tb_persentase.Clear()
        tb_zakat1.Clear()
        tb_zakat2.Clear()
        tb_zakat3.Clear()
        tb_zakat4.Clear()
        DataGridView1.Rows.Clear()
    End Sub

    Dim gaji_awal, gaji, gaji_fv, zakat1, zakat3, gaji2, zakat2, zakat4 As Double
    Dim periode As Integer
    Dim tahun As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("id-ID")
        System.Threading.Thread.CurrentThread.CurrentUICulture = New System.Globalization.CultureInfo("id-ID")
        tahun = DateTime.Now.ToString("yyyy")
    End Sub

    Private Sub Bt_hitung_Click(sender As Object, e As EventArgs) Handles Bt_hitung.Click


        Dim periode As Integer

        periode = tb_periode.Text
        tb_zakat2.Text = zakat2

        'gaji awal
        gaji_awal = tb_inputgaji.Text * 12
        tb_gaji1.Text = FormatCurrency(gaji_awal)

        'gaji future value
        gaji_fv = (gaji_awal * tb_persentase.Text / 100) + gaji_awal

        periode = tb_periode.Text
        gaji2 = (gaji_fv * ((1.06) ^ periode))
        tb_gaji2.Text = FormatCurrency(gaji2)

        'zakat sekarang/tahun
        zakat1 = gaji_awal * (2.5 / 100)
        tb_zakat1.Text = FormatCurrency(zakat1)

        'zakat sekarang /bulan
        zakat3 = zakat1 / 12
        tb_zakat3.Text = FormatCurrency(zakat3)

        'zakat future value /tahun
        zakat2 = gaji2 * (2.5 / 100)
        tb_zakat2.Text = FormatCurrency(zakat2)

        'zakat future value /bulan
        zakat4 = zakat2 / 12
        tb_zakat4.Text = FormatCurrency(zakat4)

    End Sub

    Private Sub bt_akumulasi_Click(sender As Object, e As EventArgs) Handles bt_akumulasi.Click

        'validasi
        If tb_periode.Text = "" Or tb_gaji1.Text = "" Or tb_gaji2.Text = "" Or tb_inputgaji.Text = "" Or tb_persentase.Text = "" Or tb_persentase.Text = "" Or tb_zakat1.Text = " " Or tb_zakat2.Text = "" Or tb_zakat3.Text = "" Or tb_zakat4.Text = "" Then
            MsgBox("Pastikan Semua Data Terisi")

        Else

            Dim nomor As Integer = 1
            Dim A As Double
            Dim B As Double
            Dim akumulasi As Double

            DataGridView1.Rows.Add(1)
            DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(0).Value = nomor
            DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(1).Value = FormatCurrency(tb_zakat2.Text)


            A = (12.06 / 12) ^ (12 * tb_periode.Text)
            B = ((((1 * A) - 1) / A) * (12 / 0.06))
            akumulasi = zakat2 / B

            tb_akumulasi.Text = FormatCurrency(akumulasi)
            zakat2 = zakat2 - akumulasi
            DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(2).Value = tb_akumulasi.Text

            While zakat2 > akumulasi
                zakat2 = zakat2 - akumulasi
                nomor = nomor + 1
                DataGridView1.Rows.Add(1)
                DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(0).Value = nomor
                DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(1).Value = FormatCurrency(zakat2)
                DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(2).Value = FormatCurrency(akumulasi)
            End While
            nomor = nomor + 1
            DataGridView1.Rows.Add(1)
            DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(0).Value = nomor
            DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(1).Value = 0
            DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(2).Value = FormatCurrency(akumulasi)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call reset()
    End Sub

 
End Class
