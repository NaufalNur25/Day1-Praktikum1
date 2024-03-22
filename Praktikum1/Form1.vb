Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class FrmPraktikum1
    Private Sub ShowMessage(sender As Object, e As MouseEventArgs) Handles BtTampilkan.MouseClick
        MessageBox.Show($"{TxtNama.Text}, {TxtNpm.Text}{vbCrLf}{CbJenisKelamin.Text}{vbCrLf}{CbProgramStudi.Text}{vbCrLf}{TanggalLahir.Text}, {ConvertBirthDate(TanggalLahir.Text)} Tahun", "Hasil Pengisian", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub InputChecked(sender As Object, e As EventArgs) Handles TxtNama.TextChanged, CbJenisKelamin.TextChanged, CbProgramStudi.TextChanged
        If Not String.IsNullOrWhiteSpace(TxtNama.Text) AndAlso Not String.IsNullOrWhiteSpace(CbJenisKelamin.Text) AndAlso Not String.IsNullOrWhiteSpace(CbProgramStudi.Text) AndAlso Not String.IsNullOrWhiteSpace(TxtNpm.Text) Then
            BtTampilkan.Enabled = True
            Return
        End If

        BtTampilkan.Enabled = False
    End Sub

    Function ConvertBirthDate(TanggalLahir As Date) As Integer
        Dim umur As Integer
        Dim tanggalSekarang As Date = DateTime.Today

        umur = tanggalSekarang.Year - TanggalLahir.Year
        If tanggalSekarang < TanggalLahir.AddYears(umur) Then
            umur -= 1
        End If

        Return umur
    End Function
End Class
