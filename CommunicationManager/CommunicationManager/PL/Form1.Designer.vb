<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnDesconectar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDb = New System.Windows.Forms.TextBox()
        Me.btnConectar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtHost = New System.Windows.Forms.TextBox()
        Me.gbxAcciones = New System.Windows.Forms.GroupBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.btnEncuestaCliente = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnMotivos = New System.Windows.Forms.Button()
        Me.btnPrueba = New System.Windows.Forms.Button()
        Me.btnDialogos = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cbxSucursal = New System.Windows.Forms.ComboBox()
        Me.cbxUsuario = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.gbxAcciones.SuspendLayout
        Me.SuspendLayout
        '
        'btnDesconectar
        '
        Me.btnDesconectar.Enabled = false
        Me.btnDesconectar.Location = New System.Drawing.Point(125, 116)
        Me.btnDesconectar.Name = "btnDesconectar"
        Me.btnDesconectar.Size = New System.Drawing.Size(97, 23)
        Me.btnDesconectar.TabIndex = 22
        Me.btnDesconectar.Text = "DESCONECTAR"
        Me.btnDesconectar.UseVisualStyleBackColor = true
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Location = New System.Drawing.Point(19, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Password"
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(89, 90)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(133, 20)
        Me.txtPass.TabIndex = 20
        Me.txtPass.Text = "4ntu4ny0y3r14s"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(19, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "User"
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(89, 64)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(133, 20)
        Me.txtUser.TabIndex = 18
        Me.txtUser.Text = "antuansis"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(19, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Database"
        '
        'txtDb
        '
        Me.txtDb.Location = New System.Drawing.Point(89, 38)
        Me.txtDb.Name = "txtDb"
        Me.txtDb.Size = New System.Drawing.Size(133, 20)
        Me.txtDb.TabIndex = 16
        Me.txtDb.Text = "antuan"
        '
        'btnConectar
        '
        Me.btnConectar.Location = New System.Drawing.Point(41, 116)
        Me.btnConectar.Name = "btnConectar"
        Me.btnConectar.Size = New System.Drawing.Size(78, 23)
        Me.btnConectar.TabIndex = 15
        Me.btnConectar.Text = "CONECTAR"
        Me.btnConectar.UseVisualStyleBackColor = true
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(19, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Host"
        '
        'txtHost
        '
        Me.txtHost.Location = New System.Drawing.Point(89, 12)
        Me.txtHost.Name = "txtHost"
        Me.txtHost.Size = New System.Drawing.Size(133, 20)
        Me.txtHost.TabIndex = 13
        Me.txtHost.Text = "yugoo2.com.ar"
        '
        'gbxAcciones
        '
        Me.gbxAcciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.gbxAcciones.Controls.Add(Me.Button6)
        Me.gbxAcciones.Controls.Add(Me.Button5)
        Me.gbxAcciones.Controls.Add(Me.btnEncuestaCliente)
        Me.gbxAcciones.Controls.Add(Me.Button4)
        Me.gbxAcciones.Controls.Add(Me.Button3)
        Me.gbxAcciones.Controls.Add(Me.Button2)
        Me.gbxAcciones.Controls.Add(Me.btnMotivos)
        Me.gbxAcciones.Controls.Add(Me.btnPrueba)
        Me.gbxAcciones.Controls.Add(Me.btnDialogos)
        Me.gbxAcciones.Controls.Add(Me.Button1)
        Me.gbxAcciones.Enabled = false
        Me.gbxAcciones.Location = New System.Drawing.Point(12, 220)
        Me.gbxAcciones.Name = "gbxAcciones"
        Me.gbxAcciones.Size = New System.Drawing.Size(205, 308)
        Me.gbxAcciones.TabIndex = 23
        Me.gbxAcciones.TabStop = false
        Me.gbxAcciones.Text = "Acciones"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(10, 194)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(180, 23)
        Me.Button6.TabIndex = 6
        Me.Button6.Text = "Tareas"
        Me.Button6.UseVisualStyleBackColor = true
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(10, 164)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(180, 23)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "Administrador de tareas"
        Me.Button5.UseVisualStyleBackColor = true
        '
        'btnEncuestaCliente
        '
        Me.btnEncuestaCliente.Location = New System.Drawing.Point(10, 135)
        Me.btnEncuestaCliente.Name = "btnEncuestaCliente"
        Me.btnEncuestaCliente.Size = New System.Drawing.Size(180, 23)
        Me.btnEncuestaCliente.TabIndex = 5
        Me.btnEncuestaCliente.Text = "Encuesta Cliente"
        Me.btnEncuestaCliente.UseVisualStyleBackColor = true
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(10, 106)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(180, 23)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Frm Generar Encuesta"
        Me.Button4.UseVisualStyleBackColor = true
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(10, 77)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(180, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Frm Preguntas"
        Me.Button3.UseVisualStyleBackColor = true
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(10, 48)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(180, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Frm Encuestas"
        Me.Button2.UseVisualStyleBackColor = true
        '
        'btnMotivos
        '
        Me.btnMotivos.Location = New System.Drawing.Point(103, 223)
        Me.btnMotivos.Name = "btnMotivos"
        Me.btnMotivos.Size = New System.Drawing.Size(87, 23)
        Me.btnMotivos.TabIndex = 0
        Me.btnMotivos.Text = "Motivos"
        Me.btnMotivos.UseVisualStyleBackColor = true
        '
        'btnPrueba
        '
        Me.btnPrueba.Location = New System.Drawing.Point(10, 252)
        Me.btnPrueba.Name = "btnPrueba"
        Me.btnPrueba.Size = New System.Drawing.Size(87, 23)
        Me.btnPrueba.TabIndex = 0
        Me.btnPrueba.Text = "Prueba"
        Me.btnPrueba.UseVisualStyleBackColor = true
        '
        'btnDialogos
        '
        Me.btnDialogos.Location = New System.Drawing.Point(10, 223)
        Me.btnDialogos.Name = "btnDialogos"
        Me.btnDialogos.Size = New System.Drawing.Size(87, 23)
        Me.btnDialogos.TabIndex = 0
        Me.btnDialogos.Text = "Diálogos"
        Me.btnDialogos.UseVisualStyleBackColor = true
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(10, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(180, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "FrmComunicacion"
        Me.Button1.UseVisualStyleBackColor = true
        '
        'cbxSucursal
        '
        Me.cbxSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxSucursal.FormattingEnabled = true
        Me.cbxSucursal.Location = New System.Drawing.Point(96, 145)
        Me.cbxSucursal.Name = "cbxSucursal"
        Me.cbxSucursal.Size = New System.Drawing.Size(121, 21)
        Me.cbxSucursal.TabIndex = 24
        '
        'cbxUsuario
        '
        Me.cbxUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxUsuario.FormattingEnabled = true
        Me.cbxUsuario.Location = New System.Drawing.Point(96, 172)
        Me.cbxUsuario.Name = "cbxUsuario"
        Me.cbxUsuario.Size = New System.Drawing.Size(121, 21)
        Me.cbxUsuario.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Location = New System.Drawing.Point(38, 175)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "usuario"
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Location = New System.Drawing.Point(44, 153)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "sucursal"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(238, 530)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbxUsuario)
        Me.Controls.Add(Me.cbxSucursal)
        Me.Controls.Add(Me.gbxAcciones)
        Me.Controls.Add(Me.btnDesconectar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDb)
        Me.Controls.Add(Me.btnConectar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtHost)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.gbxAcciones.ResumeLayout(false)
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents btnDesconectar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDb As System.Windows.Forms.TextBox
    Friend WithEvents btnConectar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtHost As System.Windows.Forms.TextBox
    Friend WithEvents gbxAcciones As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents btnEncuestaCliente As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents btnDialogos As System.Windows.Forms.Button
    Friend WithEvents cbxSucursal As System.Windows.Forms.ComboBox
    Friend WithEvents cbxUsuario As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnMotivos As System.Windows.Forms.Button
    Friend WithEvents btnPrueba As Button
End Class
