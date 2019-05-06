<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pantalla_Principal
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pantalla_Principal))
        Me.Pnl_Principal = New System.Windows.Forms.Panel()
        Me.Pnl_Contenedor = New System.Windows.Forms.Panel()
        Me.Logo = New System.Windows.Forms.PictureBox()
        Me.Pnl_Menu = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Btn_Estadistica = New System.Windows.Forms.Button()
        Me.Btn_Reservar = New System.Windows.Forms.Button()
        Me.Btn_Lista = New System.Windows.Forms.Button()
        Me.Btn_Prestamo = New System.Windows.Forms.Button()
        Me.Btn_Archivar = New System.Windows.Forms.Button()
        Me.Ptb_Logo = New System.Windows.Forms.PictureBox()
        Me.Btn_Menu = New System.Windows.Forms.PictureBox()
        Me.Pnl_Cabecera = New System.Windows.Forms.Panel()
        Me.Btn_restaurar = New System.Windows.Forms.Button()
        Me.Btn_mini = New System.Windows.Forms.Button()
        Me.Btn_maxi = New System.Windows.Forms.Button()
        Me.Btn_cerrar = New System.Windows.Forms.Button()
        Me.Tm_Ocultar = New System.Windows.Forms.Timer(Me.components)
        Me.Tm_Mostrar = New System.Windows.Forms.Timer(Me.components)
        Me.Pnl_Principal.SuspendLayout()
        Me.Pnl_Contenedor.SuspendLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnl_Menu.SuspendLayout()
        CType(Me.Ptb_Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Btn_Menu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnl_Cabecera.SuspendLayout()
        Me.SuspendLayout()
        '
        'Pnl_Principal
        '
        Me.Pnl_Principal.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Pnl_Principal.Controls.Add(Me.Pnl_Contenedor)
        Me.Pnl_Principal.Controls.Add(Me.Pnl_Menu)
        Me.Pnl_Principal.Controls.Add(Me.Pnl_Cabecera)
        Me.Pnl_Principal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pnl_Principal.Location = New System.Drawing.Point(0, 0)
        Me.Pnl_Principal.Name = "Pnl_Principal"
        Me.Pnl_Principal.Size = New System.Drawing.Size(1100, 580)
        Me.Pnl_Principal.TabIndex = 0
        '
        'Pnl_Contenedor
        '
        Me.Pnl_Contenedor.BackColor = System.Drawing.Color.White
        Me.Pnl_Contenedor.Controls.Add(Me.Logo)
        Me.Pnl_Contenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pnl_Contenedor.Location = New System.Drawing.Point(220, 40)
        Me.Pnl_Contenedor.Name = "Pnl_Contenedor"
        Me.Pnl_Contenedor.Size = New System.Drawing.Size(880, 540)
        Me.Pnl_Contenedor.TabIndex = 2
        '
        'Logo
        '
        Me.Logo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Logo.Image = CType(resources.GetObject("Logo.Image"), System.Drawing.Image)
        Me.Logo.Location = New System.Drawing.Point(179, 59)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(547, 330)
        Me.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Logo.TabIndex = 0
        Me.Logo.TabStop = False
        '
        'Pnl_Menu
        '
        Me.Pnl_Menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Pnl_Menu.Controls.Add(Me.Panel5)
        Me.Pnl_Menu.Controls.Add(Me.Panel4)
        Me.Pnl_Menu.Controls.Add(Me.Panel3)
        Me.Pnl_Menu.Controls.Add(Me.Panel2)
        Me.Pnl_Menu.Controls.Add(Me.Panel1)
        Me.Pnl_Menu.Controls.Add(Me.Btn_Estadistica)
        Me.Pnl_Menu.Controls.Add(Me.Btn_Reservar)
        Me.Pnl_Menu.Controls.Add(Me.Btn_Lista)
        Me.Pnl_Menu.Controls.Add(Me.Btn_Prestamo)
        Me.Pnl_Menu.Controls.Add(Me.Btn_Archivar)
        Me.Pnl_Menu.Controls.Add(Me.Ptb_Logo)
        Me.Pnl_Menu.Controls.Add(Me.Btn_Menu)
        Me.Pnl_Menu.Dock = System.Windows.Forms.DockStyle.Left
        Me.Pnl_Menu.Location = New System.Drawing.Point(0, 40)
        Me.Pnl_Menu.Name = "Pnl_Menu"
        Me.Pnl_Menu.Size = New System.Drawing.Size(220, 540)
        Me.Pnl_Menu.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Panel5.Location = New System.Drawing.Point(0, 440)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(5, 55)
        Me.Panel5.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(0, 373)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(5, 55)
        Me.Panel4.TabIndex = 7
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(0, 306)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(5, 55)
        Me.Panel3.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(0, 239)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(5, 55)
        Me.Panel2.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(0, 169)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(5, 55)
        Me.Panel1.TabIndex = 0
        '
        'Btn_Estadistica
        '
        Me.Btn_Estadistica.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Estadistica.FlatAppearance.BorderSize = 0
        Me.Btn_Estadistica.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Btn_Estadistica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Btn_Estadistica.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Estadistica.Font = New System.Drawing.Font("Elephant", 11.25!)
        Me.Btn_Estadistica.ForeColor = System.Drawing.SystemColors.Control
        Me.Btn_Estadistica.Image = Global.LiBook.My.Resources.Resources.icons8_gráfico_combinado_50
        Me.Btn_Estadistica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Estadistica.Location = New System.Drawing.Point(0, 440)
        Me.Btn_Estadistica.Name = "Btn_Estadistica"
        Me.Btn_Estadistica.Size = New System.Drawing.Size(220, 55)
        Me.Btn_Estadistica.TabIndex = 5
        Me.Btn_Estadistica.Text = "  Estadistica"
        Me.Btn_Estadistica.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Estadistica.UseVisualStyleBackColor = True
        '
        'Btn_Reservar
        '
        Me.Btn_Reservar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Reservar.FlatAppearance.BorderSize = 0
        Me.Btn_Reservar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Btn_Reservar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Btn_Reservar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Reservar.Font = New System.Drawing.Font("Elephant", 11.25!)
        Me.Btn_Reservar.ForeColor = System.Drawing.SystemColors.Control
        Me.Btn_Reservar.Image = Global.LiBook.My.Resources.Resources.icons8_reserva_50
        Me.Btn_Reservar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Reservar.Location = New System.Drawing.Point(0, 373)
        Me.Btn_Reservar.Name = "Btn_Reservar"
        Me.Btn_Reservar.Size = New System.Drawing.Size(220, 55)
        Me.Btn_Reservar.TabIndex = 4
        Me.Btn_Reservar.Text = "  Reservar"
        Me.Btn_Reservar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Reservar.UseVisualStyleBackColor = True
        '
        'Btn_Lista
        '
        Me.Btn_Lista.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Lista.FlatAppearance.BorderSize = 0
        Me.Btn_Lista.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Btn_Lista.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Btn_Lista.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Lista.Font = New System.Drawing.Font("Elephant", 11.25!)
        Me.Btn_Lista.ForeColor = System.Drawing.SystemColors.Control
        Me.Btn_Lista.Image = Global.LiBook.My.Resources.Resources.icons8_lista_de_verificación_50
        Me.Btn_Lista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Lista.Location = New System.Drawing.Point(0, 306)
        Me.Btn_Lista.Name = "Btn_Lista"
        Me.Btn_Lista.Size = New System.Drawing.Size(220, 55)
        Me.Btn_Lista.TabIndex = 3
        Me.Btn_Lista.Text = "  Lista"
        Me.Btn_Lista.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Lista.UseVisualStyleBackColor = True
        '
        'Btn_Prestamo
        '
        Me.Btn_Prestamo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Prestamo.FlatAppearance.BorderSize = 0
        Me.Btn_Prestamo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Btn_Prestamo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Btn_Prestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Prestamo.Font = New System.Drawing.Font("Elephant", 11.25!)
        Me.Btn_Prestamo.ForeColor = System.Drawing.SystemColors.Control
        Me.Btn_Prestamo.Image = Global.LiBook.My.Resources.Resources.icons8_estante_de_libro_50
        Me.Btn_Prestamo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Prestamo.Location = New System.Drawing.Point(0, 239)
        Me.Btn_Prestamo.Name = "Btn_Prestamo"
        Me.Btn_Prestamo.Size = New System.Drawing.Size(220, 55)
        Me.Btn_Prestamo.TabIndex = 2
        Me.Btn_Prestamo.Text = "  Prestamo"
        Me.Btn_Prestamo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Prestamo.UseVisualStyleBackColor = True
        '
        'Btn_Archivar
        '
        Me.Btn_Archivar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Archivar.FlatAppearance.BorderSize = 0
        Me.Btn_Archivar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Btn_Archivar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Btn_Archivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Archivar.Font = New System.Drawing.Font("Elephant", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Archivar.ForeColor = System.Drawing.SystemColors.Control
        Me.Btn_Archivar.Image = Global.LiBook.My.Resources.Resources.icons8_cabinete_de_archivos_50
        Me.Btn_Archivar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Archivar.Location = New System.Drawing.Point(0, 169)
        Me.Btn_Archivar.Name = "Btn_Archivar"
        Me.Btn_Archivar.Size = New System.Drawing.Size(220, 55)
        Me.Btn_Archivar.TabIndex = 0
        Me.Btn_Archivar.Text = "  Archivar"
        Me.Btn_Archivar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Archivar.UseVisualStyleBackColor = True
        '
        'Ptb_Logo
        '
        Me.Ptb_Logo.Image = Global.LiBook.My.Resources.Resources.logo
        Me.Ptb_Logo.Location = New System.Drawing.Point(-17, 59)
        Me.Ptb_Logo.Name = "Ptb_Logo"
        Me.Ptb_Logo.Size = New System.Drawing.Size(217, 80)
        Me.Ptb_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Ptb_Logo.TabIndex = 1
        Me.Ptb_Logo.TabStop = False
        '
        'Btn_Menu
        '
        Me.Btn_Menu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Menu.Image = Global.LiBook.My.Resources.Resources.Mobile_Menu_Icon
        Me.Btn_Menu.Location = New System.Drawing.Point(168, 0)
        Me.Btn_Menu.Name = "Btn_Menu"
        Me.Btn_Menu.Size = New System.Drawing.Size(44, 38)
        Me.Btn_Menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Btn_Menu.TabIndex = 0
        Me.Btn_Menu.TabStop = False
        '
        'Pnl_Cabecera
        '
        Me.Pnl_Cabecera.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Pnl_Cabecera.Controls.Add(Me.Btn_restaurar)
        Me.Pnl_Cabecera.Controls.Add(Me.Btn_mini)
        Me.Pnl_Cabecera.Controls.Add(Me.Btn_maxi)
        Me.Pnl_Cabecera.Controls.Add(Me.Btn_cerrar)
        Me.Pnl_Cabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pnl_Cabecera.Location = New System.Drawing.Point(0, 0)
        Me.Pnl_Cabecera.Name = "Pnl_Cabecera"
        Me.Pnl_Cabecera.Size = New System.Drawing.Size(1100, 40)
        Me.Pnl_Cabecera.TabIndex = 0
        '
        'Btn_restaurar
        '
        Me.Btn_restaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_restaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_restaurar.FlatAppearance.BorderSize = 0
        Me.Btn_restaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Btn_restaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.Btn_restaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_restaurar.Image = Global.LiBook.My.Resources.Resources.Icono_Restaurar
        Me.Btn_restaurar.Location = New System.Drawing.Point(1014, 0)
        Me.Btn_restaurar.Name = "Btn_restaurar"
        Me.Btn_restaurar.Size = New System.Drawing.Size(40, 40)
        Me.Btn_restaurar.TabIndex = 3
        Me.Btn_restaurar.UseVisualStyleBackColor = True
        Me.Btn_restaurar.Visible = False
        '
        'Btn_mini
        '
        Me.Btn_mini.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_mini.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_mini.FlatAppearance.BorderSize = 0
        Me.Btn_mini.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Btn_mini.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.Btn_mini.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_mini.Image = Global.LiBook.My.Resources.Resources.Icono_Minimizar
        Me.Btn_mini.Location = New System.Drawing.Point(968, 0)
        Me.Btn_mini.Name = "Btn_mini"
        Me.Btn_mini.Size = New System.Drawing.Size(40, 40)
        Me.Btn_mini.TabIndex = 2
        Me.Btn_mini.UseVisualStyleBackColor = True
        '
        'Btn_maxi
        '
        Me.Btn_maxi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_maxi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_maxi.FlatAppearance.BorderSize = 0
        Me.Btn_maxi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Btn_maxi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.Btn_maxi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_maxi.Image = Global.LiBook.My.Resources.Resources.Icono_Maximizar
        Me.Btn_maxi.Location = New System.Drawing.Point(1014, 0)
        Me.Btn_maxi.Name = "Btn_maxi"
        Me.Btn_maxi.Size = New System.Drawing.Size(40, 40)
        Me.Btn_maxi.TabIndex = 1
        Me.Btn_maxi.UseVisualStyleBackColor = True
        '
        'Btn_cerrar
        '
        Me.Btn_cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_cerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_cerrar.FlatAppearance.BorderSize = 0
        Me.Btn_cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.Btn_cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.Btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_cerrar.Image = Global.LiBook.My.Resources.Resources.Icono_cerrar_FN
        Me.Btn_cerrar.Location = New System.Drawing.Point(1060, 0)
        Me.Btn_cerrar.Name = "Btn_cerrar"
        Me.Btn_cerrar.Size = New System.Drawing.Size(40, 40)
        Me.Btn_cerrar.TabIndex = 0
        Me.Btn_cerrar.UseVisualStyleBackColor = True
        '
        'Tm_Ocultar
        '
        '
        'Tm_Mostrar
        '
        '
        'Pantalla_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1100, 580)
        Me.Controls.Add(Me.Pnl_Principal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(550, 400)
        Me.Name = "Pantalla_Principal"
        Me.Text = "Pantalla Prncipal"
        Me.Pnl_Principal.ResumeLayout(False)
        Me.Pnl_Contenedor.ResumeLayout(False)
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnl_Menu.ResumeLayout(False)
        CType(Me.Ptb_Logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Btn_Menu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnl_Cabecera.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Pnl_Principal As Panel
    Friend WithEvents Pnl_Contenedor As Panel
    Friend WithEvents Pnl_Menu As Panel
    Friend WithEvents Pnl_Cabecera As Panel
    Friend WithEvents Btn_cerrar As Button
    Friend WithEvents Btn_restaurar As Button
    Friend WithEvents Btn_mini As Button
    Friend WithEvents Btn_maxi As Button
    Friend WithEvents Btn_Menu As PictureBox
    Friend WithEvents Tm_Ocultar As Timer
    Friend WithEvents Tm_Mostrar As Timer
    Friend WithEvents Ptb_Logo As PictureBox
    Friend WithEvents Btn_Archivar As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Btn_Estadistica As Button
    Friend WithEvents Btn_Reservar As Button
    Friend WithEvents Btn_Lista As Button
    Friend WithEvents Btn_Prestamo As Button
    Friend WithEvents Logo As PictureBox
End Class
