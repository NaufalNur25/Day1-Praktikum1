<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPraktikum1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        TxtNama = New TextBox()
        CbJenisKelamin = New ComboBox()
        CbProgramStudi = New ComboBox()
        BtTampilkan = New Button()
        Label4 = New Label()
        TanggalLahir = New DateTimePicker()
        TxtNpm = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(76, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 20)
        Label1.TabIndex = 0
        Label1.Text = "Nama"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(76, 87)
        Label2.Name = "Label2"
        Label2.Size = New Size(98, 20)
        Label2.TabIndex = 1
        Label2.Text = "Jenis Kelamin"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(76, 141)
        Label3.Name = "Label3"
        Label3.Size = New Size(104, 20)
        Label3.TabIndex = 2
        Label3.Text = "Program Studi"
        ' 
        ' TxtNama
        ' 
        TxtNama.CharacterCasing = CharacterCasing.Upper
        TxtNama.Location = New Point(220, 30)
        TxtNama.Name = "TxtNama"
        TxtNama.Size = New Size(171, 27)
        TxtNama.TabIndex = 3
        ' 
        ' CbJenisKelamin
        ' 
        CbJenisKelamin.DropDownStyle = ComboBoxStyle.DropDownList
        CbJenisKelamin.FormattingEnabled = True
        CbJenisKelamin.Items.AddRange(New Object() {"Laki-laki", "Perempuan"})
        CbJenisKelamin.Location = New Point(220, 84)
        CbJenisKelamin.Name = "CbJenisKelamin"
        CbJenisKelamin.Size = New Size(327, 28)
        CbJenisKelamin.TabIndex = 4
        ' 
        ' CbProgramStudi
        ' 
        CbProgramStudi.DropDownStyle = ComboBoxStyle.DropDownList
        CbProgramStudi.FormattingEnabled = True
        CbProgramStudi.Items.AddRange(New Object() {"S1 - Teknik Informatika", "S1 - Sistem Informasi", "D4 - Komputerisasi Akuntansi", "D3 - Komputerisasi Akuntansi", "D4 - Manajemen Informatika", "D4 - Sistem Komputer "})
        CbProgramStudi.Location = New Point(220, 138)
        CbProgramStudi.Name = "CbProgramStudi"
        CbProgramStudi.Size = New Size(327, 28)
        CbProgramStudi.TabIndex = 5
        ' 
        ' BtTampilkan
        ' 
        BtTampilkan.Enabled = False
        BtTampilkan.Location = New Point(76, 246)
        BtTampilkan.Name = "BtTampilkan"
        BtTampilkan.Size = New Size(471, 48)
        BtTampilkan.TabIndex = 6
        BtTampilkan.Text = "Tampilkan Pesan"
        BtTampilkan.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(77, 195)
        Label4.Name = "Label4"
        Label4.Size = New Size(97, 20)
        Label4.TabIndex = 7
        Label4.Text = "Tanggal Lahir"
        ' 
        ' TanggalLahir
        ' 
        TanggalLahir.Location = New Point(220, 190)
        TanggalLahir.MaxDate = New Date(2024, 3, 18, 0, 0, 0, 0)
        TanggalLahir.MinDate = New Date(1800, 1, 1, 0, 0, 0, 0)
        TanggalLahir.Name = "TanggalLahir"
        TanggalLahir.Size = New Size(327, 27)
        TanggalLahir.TabIndex = 8
        TanggalLahir.Value = New Date(2009, 12, 31, 0, 0, 0, 0)
        ' 
        ' TxtNpm
        ' 
        TxtNpm.Location = New Point(392, 30)
        TxtNpm.MaxLength = 9
        TxtNpm.Name = "TxtNpm"
        TxtNpm.PlaceholderText = "NPM"
        TxtNpm.Size = New Size(155, 27)
        TxtNpm.TabIndex = 9
        ' 
        ' FrmPraktikum1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(629, 316)
        Controls.Add(TxtNpm)
        Controls.Add(TanggalLahir)
        Controls.Add(Label4)
        Controls.Add(BtTampilkan)
        Controls.Add(CbProgramStudi)
        Controls.Add(CbJenisKelamin)
        Controls.Add(TxtNama)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "FrmPraktikum1"
        Text = "Praktikum 1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents CbJenisKelamin As ComboBox
    Friend WithEvents CbProgramStudi As ComboBox
    Friend WithEvents BtTampilkan As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents TanggalLahir As DateTimePicker
    Friend WithEvents TxtNpm As TextBox

End Class
