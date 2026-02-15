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
        Me.txtDaftarNama = New System.Windows.Forms.TextBox()
        Me.btnDaftar = New System.Windows.Forms.Button()
        Me.dgvAbsensi = New System.Windows.Forms.DataGridView()
        Me.btnAbsen = New System.Windows.Forms.Button()
        Me.txtAbsenNama = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstMahasiswa = New System.Windows.Forms.ListBox()
        Me.btnHapus = New System.Windows.Forms.Button()
        CType(Me.dgvAbsensi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDaftarNama
        '
        Me.txtDaftarNama.Location = New System.Drawing.Point(216, 26)
        Me.txtDaftarNama.Name = "txtDaftarNama"
        Me.txtDaftarNama.Size = New System.Drawing.Size(218, 26)
        Me.txtDaftarNama.TabIndex = 0
        '
        'btnDaftar
        '
        Me.btnDaftar.Location = New System.Drawing.Point(557, 22)
        Me.btnDaftar.Name = "btnDaftar"
        Me.btnDaftar.Size = New System.Drawing.Size(151, 35)
        Me.btnDaftar.TabIndex = 1
        Me.btnDaftar.Text = "Simpan"
        Me.btnDaftar.UseVisualStyleBackColor = True
        '
        'dgvAbsensi
        '
        Me.dgvAbsensi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAbsensi.Location = New System.Drawing.Point(12, 332)
        Me.dgvAbsensi.Name = "dgvAbsensi"
        Me.dgvAbsensi.RowHeadersWidth = 62
        Me.dgvAbsensi.RowTemplate.Height = 28
        Me.dgvAbsensi.Size = New System.Drawing.Size(803, 201)
        Me.dgvAbsensi.TabIndex = 4
        '
        'btnAbsen
        '
        Me.btnAbsen.Location = New System.Drawing.Point(557, 159)
        Me.btnAbsen.Name = "btnAbsen"
        Me.btnAbsen.Size = New System.Drawing.Size(151, 35)
        Me.btnAbsen.TabIndex = 5
        Me.btnAbsen.Text = "Simpan"
        Me.btnAbsen.UseVisualStyleBackColor = True
        '
        'txtAbsenNama
        '
        Me.txtAbsenNama.Location = New System.Drawing.Point(216, 159)
        Me.txtAbsenNama.Name = "txtAbsenNama"
        Me.txtAbsenNama.Size = New System.Drawing.Size(218, 26)
        Me.txtAbsenNama.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Masukan Nama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Absen"
        '
        'lstMahasiswa
        '
        Me.lstMahasiswa.FormattingEnabled = True
        Me.lstMahasiswa.ItemHeight = 20
        Me.lstMahasiswa.Location = New System.Drawing.Point(812, 332)
        Me.lstMahasiswa.Name = "lstMahasiswa"
        Me.lstMahasiswa.Size = New System.Drawing.Size(373, 204)
        Me.lstMahasiswa.TabIndex = 9
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(1034, 542)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(151, 35)
        Me.btnHapus.TabIndex = 10
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1181, 706)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.lstMahasiswa)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAbsenNama)
        Me.Controls.Add(Me.btnAbsen)
        Me.Controls.Add(Me.dgvAbsensi)
        Me.Controls.Add(Me.btnDaftar)
        Me.Controls.Add(Me.txtDaftarNama)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgvAbsensi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDaftarNama As TextBox
    Friend WithEvents btnDaftar As Button
    Friend WithEvents dgvAbsensi As DataGridView
    Friend WithEvents btnAbsen As Button
    Friend WithEvents txtAbsenNama As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lstMahasiswa As ListBox
    Friend WithEvents btnHapus As Button
End Class
