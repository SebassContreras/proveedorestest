<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.checconndb = New System.Windows.Forms.CheckBox()
        Me.AddProv = New System.Windows.Forms.Button()
        Me.lbsocial = New System.Windows.Forms.Label()
        Me.razontxt = New System.Windows.Forms.TextBox()
        Me.locatxt = New System.Windows.Forms.TextBox()
        Me.locatxt2 = New System.Windows.Forms.Label()
        Me.ciftxt = New System.Windows.Forms.TextBox()
        Me.ciftxt1 = New System.Windows.Forms.Label()
        Me.protxt = New System.Windows.Forms.TextBox()
        Me.protxt1 = New System.Windows.Forms.Label()
        Me.cptxt = New System.Windows.Forms.TextBox()
        Me.cptxt2 = New System.Windows.Forms.Label()
        Me.paistxt = New System.Windows.Forms.TextBox()
        Me.paistxt1 = New System.Windows.Forms.Label()
        Me.dbProveedores = New System.Windows.Forms.DataGridView()
        Me.RazonSocial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cif = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoPostal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Localidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Provincia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pais = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.buscarbtn = New System.Windows.Forms.Button()
        CType(Me.dbProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'checconndb
        '
        Me.checconndb.AutoSize = True
        Me.checconndb.Location = New System.Drawing.Point(12, 12)
        Me.checconndb.Name = "checconndb"
        Me.checconndb.Size = New System.Drawing.Size(101, 19)
        Me.checconndb.TabIndex = 1
        Me.checconndb.Text = "Desconectado"
        Me.checconndb.UseVisualStyleBackColor = True
        '
        'AddProv
        '
        Me.AddProv.Location = New System.Drawing.Point(620, 64)
        Me.AddProv.Name = "AddProv"
        Me.AddProv.Size = New System.Drawing.Size(128, 30)
        Me.AddProv.TabIndex = 2
        Me.AddProv.Text = "Agregar Proveedor"
        Me.AddProv.UseVisualStyleBackColor = True
        '
        'lbsocial
        '
        Me.lbsocial.AutoSize = True
        Me.lbsocial.Location = New System.Drawing.Point(7, 51)
        Me.lbsocial.Name = "lbsocial"
        Me.lbsocial.Size = New System.Drawing.Size(73, 15)
        Me.lbsocial.TabIndex = 3
        Me.lbsocial.Text = "Razon Social"
        '
        'razontxt
        '
        Me.razontxt.Location = New System.Drawing.Point(7, 69)
        Me.razontxt.Name = "razontxt"
        Me.razontxt.Size = New System.Drawing.Size(180, 23)
        Me.razontxt.TabIndex = 4
        '
        'locatxt
        '
        Me.locatxt.Location = New System.Drawing.Point(7, 121)
        Me.locatxt.Name = "locatxt"
        Me.locatxt.Size = New System.Drawing.Size(180, 23)
        Me.locatxt.TabIndex = 6
        '
        'locatxt2
        '
        Me.locatxt2.AutoSize = True
        Me.locatxt2.Location = New System.Drawing.Point(7, 103)
        Me.locatxt2.Name = "locatxt2"
        Me.locatxt2.Size = New System.Drawing.Size(58, 15)
        Me.locatxt2.TabIndex = 5
        Me.locatxt2.Text = "Localidad"
        '
        'ciftxt
        '
        Me.ciftxt.Location = New System.Drawing.Point(207, 69)
        Me.ciftxt.Name = "ciftxt"
        Me.ciftxt.Size = New System.Drawing.Size(180, 23)
        Me.ciftxt.TabIndex = 8
        '
        'ciftxt1
        '
        Me.ciftxt1.AutoSize = True
        Me.ciftxt1.Location = New System.Drawing.Point(207, 51)
        Me.ciftxt1.Name = "ciftxt1"
        Me.ciftxt1.Size = New System.Drawing.Size(24, 15)
        Me.ciftxt1.TabIndex = 7
        Me.ciftxt1.Text = "CIF"
        '
        'protxt
        '
        Me.protxt.Location = New System.Drawing.Point(207, 121)
        Me.protxt.Name = "protxt"
        Me.protxt.Size = New System.Drawing.Size(180, 23)
        Me.protxt.TabIndex = 10
        '
        'protxt1
        '
        Me.protxt1.AutoSize = True
        Me.protxt1.Location = New System.Drawing.Point(207, 103)
        Me.protxt1.Name = "protxt1"
        Me.protxt1.Size = New System.Drawing.Size(56, 15)
        Me.protxt1.TabIndex = 9
        Me.protxt1.Text = "Provincia"
        '
        'cptxt
        '
        Me.cptxt.Location = New System.Drawing.Point(405, 69)
        Me.cptxt.Name = "cptxt"
        Me.cptxt.Size = New System.Drawing.Size(180, 23)
        Me.cptxt.TabIndex = 12
        '
        'cptxt2
        '
        Me.cptxt2.AutoSize = True
        Me.cptxt2.Location = New System.Drawing.Point(405, 51)
        Me.cptxt2.Name = "cptxt2"
        Me.cptxt2.Size = New System.Drawing.Size(81, 15)
        Me.cptxt2.TabIndex = 11
        Me.cptxt2.Text = "Codigo Postal"
        '
        'paistxt
        '
        Me.paistxt.Location = New System.Drawing.Point(405, 121)
        Me.paistxt.Name = "paistxt"
        Me.paistxt.Size = New System.Drawing.Size(180, 23)
        Me.paistxt.TabIndex = 14
        '
        'paistxt1
        '
        Me.paistxt1.AutoSize = True
        Me.paistxt1.Location = New System.Drawing.Point(405, 103)
        Me.paistxt1.Name = "paistxt1"
        Me.paistxt1.Size = New System.Drawing.Size(28, 15)
        Me.paistxt1.TabIndex = 13
        Me.paistxt1.Text = "Pais"
        '
        'dbProveedores
        '
        Me.dbProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dbProveedores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RazonSocial, Me.Cif, Me.CodigoPostal, Me.Localidad, Me.Provincia, Me.Pais})
        Me.dbProveedores.Location = New System.Drawing.Point(12, 182)
        Me.dbProveedores.Name = "dbProveedores"
        Me.dbProveedores.RowTemplate.Height = 25
        Me.dbProveedores.Size = New System.Drawing.Size(666, 150)
        Me.dbProveedores.TabIndex = 15
        '
        'RazonSocial
        '
        Me.RazonSocial.HeaderText = "Razon Social"
        Me.RazonSocial.Name = "RazonSocial"
        '
        'Cif
        '
        Me.Cif.HeaderText = "CIF"
        Me.Cif.Name = "Cif"
        '
        'CodigoPostal
        '
        Me.CodigoPostal.HeaderText = "Codigo Postal"
        Me.CodigoPostal.Name = "CodigoPostal"
        '
        'Localidad
        '
        Me.Localidad.HeaderText = "Localidad"
        Me.Localidad.Name = "Localidad"
        '
        'Provincia
        '
        Me.Provincia.HeaderText = "Provincia"
        Me.Provincia.Name = "Provincia"
        '
        'Pais
        '
        Me.Pais.HeaderText = "Pais"
        Me.Pais.Name = "Pais"
        '
        'buscarbtn
        '
        Me.buscarbtn.Location = New System.Drawing.Point(629, 120)
        Me.buscarbtn.Name = "buscarbtn"
        Me.buscarbtn.Size = New System.Drawing.Size(103, 24)
        Me.buscarbtn.TabIndex = 16
        Me.buscarbtn.Text = "Buscar"
        Me.buscarbtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.buscarbtn)
        Me.Controls.Add(Me.dbProveedores)
        Me.Controls.Add(Me.paistxt)
        Me.Controls.Add(Me.paistxt1)
        Me.Controls.Add(Me.cptxt)
        Me.Controls.Add(Me.cptxt2)
        Me.Controls.Add(Me.protxt)
        Me.Controls.Add(Me.protxt1)
        Me.Controls.Add(Me.ciftxt)
        Me.Controls.Add(Me.ciftxt1)
        Me.Controls.Add(Me.locatxt)
        Me.Controls.Add(Me.locatxt2)
        Me.Controls.Add(Me.razontxt)
        Me.Controls.Add(Me.lbsocial)
        Me.Controls.Add(Me.AddProv)
        Me.Controls.Add(Me.checconndb)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dbProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents checconndb As CheckBox
    Friend WithEvents AddProv As Button
    Friend WithEvents lbsocial As Label
    Friend WithEvents razontxt As TextBox
    Friend WithEvents locatxt As TextBox
    Friend WithEvents locatxt2 As Label
    Friend WithEvents ciftxt As TextBox
    Friend WithEvents ciftxt1 As Label
    Friend WithEvents protxt As TextBox
    Friend WithEvents protxt1 As Label
    Friend WithEvents cptxt As TextBox
    Friend WithEvents cptxt2 As Label
    Friend WithEvents paistxt As TextBox
    Friend WithEvents paistxt1 As Label
    Friend WithEvents dbProveedores As DataGridView
    Friend WithEvents RazonSocial As DataGridViewTextBoxColumn
    Friend WithEvents Cif As DataGridViewTextBoxColumn
    Friend WithEvents CodigoPostal As DataGridViewTextBoxColumn
    Friend WithEvents Localidad As DataGridViewTextBoxColumn
    Friend WithEvents Provincia As DataGridViewTextBoxColumn
    Friend WithEvents Pais As DataGridViewTextBoxColumn
    Friend WithEvents buscarbtn As Button
End Class
