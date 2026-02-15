Imports System.IO
Imports System.Data

Public Class Form1
    Dim tabelAbsen As New DataTable()
    Dim fileMahasiswa As String = "daftar_mahasiswa.txt"
    Dim fileAbsensi As String = "riwayat_absensi.txt"
    Dim listMahasiswa As New List(Of String)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PersiapkanTabel()
        MuatDaftarMahasiswa()
        MuatRiwayatAbsen()
    End Sub

    Private Sub PersiapkanTabel()
        tabelAbsen.Columns.Add("Nama", GetType(String))
        tabelAbsen.Columns.Add("Waktu", GetType(String))
        dgvAbsensi.DataSource = tabelAbsen
        dgvAbsensi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub btnDaftar_Click(sender As Object, e As EventArgs) Handles btnDaftar.Click
        Dim namaBaru As String = txtDaftarNama.Text.Trim()

        If namaBaru = "" Then
            MessageBox.Show("Nama tidak boleh kosong!", "Peringatan")
        ElseIf listMahasiswa.Contains(namaBaru) Then
            MessageBox.Show("Mahasiswa ini sudah terdaftar dalam sistem.")
        Else
            listMahasiswa.Add(namaBaru)
            SimpanMahasiswaKeFile()
            UpdateTampilanList()
            txtDaftarNama.Clear()
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If lstMahasiswa.SelectedIndex <> -1 Then
            Dim namaDihapus As String = lstMahasiswa.SelectedItem.ToString()

            Dim konfirmasi = MessageBox.Show("Hapus '" & namaDihapus & "'? Semua riwayat absennya juga akan dihapus.",
                                             "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If konfirmasi = DialogResult.Yes Then
                listMahasiswa.Remove(namaDihapus)
                SimpanMahasiswaKeFile()

                For i As Integer = tabelAbsen.Rows.Count - 1 To 0 Step -1
                    If tabelAbsen.Rows(i)("Nama").ToString() = namaDihapus Then
                        tabelAbsen.Rows.RemoveAt(i)
                    End If
                Next

                SimpanAbsenKeFile()
                UpdateTampilanList()
            End If
        Else
            MessageBox.Show("Pilih nama di daftar terlebih dahulu untuk dihapus.")
        End If
    End Sub

    Private Sub btnAbsen_Click(sender As Object, e As EventArgs) Handles btnAbsen.Click
        Dim namaInput As String = txtAbsenNama.Text.Trim()

        If listMahasiswa.Contains(namaInput) Then
            Dim waktu As String = DateTime.Now.ToString("HH:mm:ss")
            tabelAbsen.Rows.Add(namaInput, waktu)
            SimpanAbsenKeFile()
            txtAbsenNama.Clear()
        Else
            MessageBox.Show("Maaf, '" & namaInput & "' tidak terdaftar. Silakan daftar dulu!", "Akses Ditolak")
        End If
    End Sub

    Private Sub UpdateTampilanList()
        lstMahasiswa.Items.Clear()
        For Each mhs In listMahasiswa
            lstMahasiswa.Items.Add(mhs)
        Next
    End Sub

    Private Sub MuatDaftarMahasiswa()
        If File.Exists(fileMahasiswa) Then
            Dim baris As String() = File.ReadAllLines(fileMahasiswa)
            For Each n In baris
                If Not String.IsNullOrWhiteSpace(n) Then listMahasiswa.Add(n)
            Next
            UpdateTampilanList()
        End If
    End Sub

    Private Sub MuatRiwayatAbsen()
        If File.Exists(fileAbsensi) Then
            Dim baris As String() = File.ReadAllLines(fileAbsensi)
            For Each b In baris
                Dim data = b.Split("|"c)
                If data.Length = 2 Then tabelAbsen.Rows.Add(data(0), data(1))
            Next
        End If
    End Sub

    Private Sub SimpanMahasiswaKeFile()
        File.WriteAllLines(fileMahasiswa, listMahasiswa)
    End Sub

    Private Sub SimpanAbsenKeFile()
        Using sw As New StreamWriter(fileAbsensi)
            For Each row As DataRow In tabelAbsen.Rows
                sw.WriteLine(row("Nama").ToString() & "|" & row("Waktu").ToString())
            Next
        End Using
    End Sub
End Class