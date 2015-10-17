<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bintang
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
        Me.Lbl_pola = New System.Windows.Forms.Label()
        Me.Lbl_baris = New System.Windows.Forms.Label()
        Me.Txb_baris = New System.Windows.Forms.TextBox()
        Me.btn_proses = New System.Windows.Forms.Button()
        Me.txb_hasil = New System.Windows.Forms.TextBox()
        Me.Cmb_pola = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Lbl_pola
        '
        Me.Lbl_pola.AutoSize = True
        Me.Lbl_pola.Location = New System.Drawing.Point(13, 19)
        Me.Lbl_pola.Name = "Lbl_pola"
        Me.Lbl_pola.Size = New System.Drawing.Size(34, 13)
        Me.Lbl_pola.TabIndex = 1
        Me.Lbl_pola.Text = "Pola :"
        '
        'Lbl_baris
        '
        Me.Lbl_baris.AutoSize = True
        Me.Lbl_baris.Location = New System.Drawing.Point(13, 65)
        Me.Lbl_baris.Name = "Lbl_baris"
        Me.Lbl_baris.Size = New System.Drawing.Size(36, 13)
        Me.Lbl_baris.TabIndex = 2
        Me.Lbl_baris.Text = "Baris :"
        '
        'Txb_baris
        '
        Me.Txb_baris.Location = New System.Drawing.Point(53, 62)
        Me.Txb_baris.Name = "Txb_baris"
        Me.Txb_baris.Size = New System.Drawing.Size(266, 20)
        Me.Txb_baris.TabIndex = 3
        '
        'btn_proses
        '
        Me.btn_proses.Location = New System.Drawing.Point(325, 60)
        Me.btn_proses.Name = "btn_proses"
        Me.btn_proses.Size = New System.Drawing.Size(114, 23)
        Me.btn_proses.TabIndex = 4
        Me.btn_proses.Text = "Proses"
        Me.btn_proses.UseVisualStyleBackColor = True
        '
        'txb_hasil
        '
        Me.txb_hasil.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txb_hasil.Location = New System.Drawing.Point(16, 108)
        Me.txb_hasil.Multiline = True
        Me.txb_hasil.Name = "txb_hasil"
        Me.txb_hasil.Size = New System.Drawing.Size(423, 305)
        Me.txb_hasil.TabIndex = 5
        '
        'Cmb_pola
        '
        Me.Cmb_pola.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_pola.FormattingEnabled = True
        Me.Cmb_pola.Items.AddRange(New Object() {"Pyramid", "Hollow Pyramid", "Inverted Pyramid", "Hollow Inverted Pyramid"})
        Me.Cmb_pola.Location = New System.Drawing.Point(53, 11)
        Me.Cmb_pola.Name = "Cmb_pola"
        Me.Cmb_pola.Size = New System.Drawing.Size(386, 21)
        Me.Cmb_pola.TabIndex = 2
        '
        'Bintang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 425)
        Me.Controls.Add(Me.Cmb_pola)
        Me.Controls.Add(Me.txb_hasil)
        Me.Controls.Add(Me.btn_proses)
        Me.Controls.Add(Me.Txb_baris)
        Me.Controls.Add(Me.Lbl_baris)
        Me.Controls.Add(Me.Lbl_pola)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Bintang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Problem Bintang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_pola As System.Windows.Forms.Label
    Friend WithEvents Lbl_baris As System.Windows.Forms.Label
    Friend WithEvents Txb_baris As System.Windows.Forms.TextBox
    Friend WithEvents btn_proses As System.Windows.Forms.Button
    Friend WithEvents txb_hasil As System.Windows.Forms.TextBox
    Friend WithEvents Cmb_pola As System.Windows.Forms.ComboBox
End Class
