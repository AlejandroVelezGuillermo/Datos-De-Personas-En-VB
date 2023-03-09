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
        GuardadBtn = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        dtpFechaDeNacimiento = New DateTimePicker()
        txtNombre = New TextBox()
        txtTelefono = New TextBox()
        txtCorreo = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' GuardadBtn
        ' 
        GuardadBtn.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        GuardadBtn.Location = New Point(459, 260)
        GuardadBtn.Margin = New Padding(3, 4, 3, 4)
        GuardadBtn.Name = "GuardadBtn"
        GuardadBtn.Size = New Size(125, 29)
        GuardadBtn.TabIndex = 0
        GuardadBtn.Text = "GUARDAD"
        GuardadBtn.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(41, 103)
        Label1.Name = "Label1"
        Label1.Size = New Size(191, 28)
        Label1.TabIndex = 1
        Label1.Text = "Nombre Completo:"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(41, 160)
        Label2.Name = "Label2"
        Label2.Size = New Size(99, 28)
        Label2.TabIndex = 2
        Label2.Text = "Telefono:"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(41, 207)
        Label3.Name = "Label3"
        Label3.Size = New Size(80, 28)
        Label3.TabIndex = 3
        Label3.Text = "Correo:"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(41, 257)
        Label4.Name = "Label4"
        Label4.Size = New Size(219, 28)
        Label4.TabIndex = 4
        Label4.Text = "Fecha De Nacimiento:"' 
        ' dtpFechaDeNacimiento
        ' 
        dtpFechaDeNacimiento.Format = DateTimePickerFormat.Short
        dtpFechaDeNacimiento.Location = New Point(302, 259)
        dtpFechaDeNacimiento.Margin = New Padding(3, 4, 3, 4)
        dtpFechaDeNacimiento.Name = "dtpFechaDeNacimiento"
        dtpFechaDeNacimiento.Size = New Size(151, 27)
        dtpFechaDeNacimiento.TabIndex = 5
        ' 
        ' txtNombre
        ' 
        txtNombre.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtNombre.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        txtNombre.Location = New Point(302, 104)
        txtNombre.Margin = New Padding(3, 4, 3, 4)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(614, 27)
        txtNombre.TabIndex = 6
        ' 
        ' txtTelefono
        ' 
        txtTelefono.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtTelefono.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        txtTelefono.Location = New Point(302, 164)
        txtTelefono.Margin = New Padding(3, 4, 3, 4)
        txtTelefono.Name = "txtTelefono"
        txtTelefono.Size = New Size(614, 27)
        txtTelefono.TabIndex = 7
        ' 
        ' txtCorreo
        ' 
        txtCorreo.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtCorreo.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        txtCorreo.Location = New Point(302, 211)
        txtCorreo.Margin = New Padding(3, 4, 3, 4)
        txtCorreo.Name = "txtCorreo"
        txtCorreo.Size = New Size(614, 27)
        txtCorreo.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        Label5.Location = New Point(73, 383)
        Label5.Name = "Label5"
        Label5.Size = New Size(0, 20)
        Label5.TabIndex = 9
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(12, 9)
        Label6.Name = "Label6"
        Label6.Size = New Size(904, 81)
        Label6.TabIndex = 10
        Label6.Text = "BASE DE DATOS DE PERSONAS"' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Teal
        ClientSize = New Size(933, 600)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(txtCorreo)
        Controls.Add(txtTelefono)
        Controls.Add(txtNombre)
        Controls.Add(dtpFechaDeNacimiento)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(GuardadBtn)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GuardadBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpFechaDeNacimiento As DateTimePicker
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
