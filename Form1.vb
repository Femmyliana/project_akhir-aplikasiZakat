Imports System.Data.SqlClient

Public Class Form1
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
        Dim A As Double
        Dim B As Double
        Dim akumulasi As Double

        A = (12.06 / 12) ^ (12 * tb_periode.Text)
        B = ((((1 * A) - 1) / A) * (12 / 0.06))
        akumulasi = zakat2 / B

        tb_akumulasi.Text = FormatCurrency(akumulasi)


    End Sub
End Class
