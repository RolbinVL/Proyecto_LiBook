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
        Me.Pnl_Barra = New System.Windows.Forms.Panel()
        Me.Btn_Restaurar = New System.Windows.Forms.Button()
        Me.Btn_Maxi = New System.Windows.Forms.Button()
        Me.Btn_Mini = New System.Windows.Forms.Button()
        Me.Btn_Cerrar = New System.Windows.Forms.Button()
        Me.Pnl_Menu = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Btn_Estadistica = New System.Windows.Forms.Button()
        Me.Btn_Reservar = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Btn_Lista = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Btn_Prestamo = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Btn_Archivo = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Btn_menu = New System.Windows.Forms.PictureBox()
        Me.Pnl_Contenedor = New System.Windows.Forms.Panel()
        Me.Tm_OcultarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.Tm_MostrarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.Pnl_Barra.SuspendLayout()
        Me.Pnl_Menu.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Btn_menu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pnl_Barra
        '
        Me.Pnl_Barra.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Pnl_Barra.Controls.Add(Me.Btn_Restaurar)
        Me.Pnl_Barra.Controls.Add(Me.Btn_Maxi)
        Me.Pnl_Barra.Controls.Add(Me.Btn_Mini)
        Me.Pnl_Barra.Controls.Add(Me.Btn_Cerrar)
        Me.Pnl_Barra.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pnl_Barra.Location = New System.Drawing.Point(0, 0)
        Me.Pnl_Barra.Name = "Pnl_Barra"
        Me.Pnl_Barra.Size = New System.Drawing.Size(1100, 40)
        Me.Pnl_Barra.TabIndex = 0
        '
        'Btn_Restaurar
        '
        Me.Btn_Restaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Restaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Restaurar.FlatAppearance.BorderSize = 0
        Me.Btn_Restaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Btn_Restaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue
        Me.Btn_Restaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Restaurar.Image = Global.LiBook.My.Resources.Resources.Icono_Restaurar
        Me.Btn_Restaurar.Location = New System.Drawing.Point(1014, 0)
        Me.Btn_Restaurar.Name = "Btn_Restaurar"
        Me.Btn_Restaurar.Size = New System.Drawing.Size(40, 40)
        Me.Btn_Restaurar.TabIndex = 3
        Me.Btn_Restaurar.UseVisualStyleBackColor = True
        Me.Btn_Restaurar.Visible = False
        '
        'Btn_Maxi
        '
        Me.Btn_Maxi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Maxi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Maxi.FlatAppearance.BorderSize = 0
        Me.Btn_Maxi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Btn_Maxi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue
        Me.Btn_Maxi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Maxi.Image = Global.LiBook.My.Resources.Resources.Icono_Maximizar
        Me.Btn_Maxi.Location = New System.Drawing.Point(1014, 0)
        Me.Btn_Maxi.Name = "Btn_Maxi"
        Me.Btn_Maxi.Size = New System.Drawing.Size(40, 40)
        Me.Btn_Maxi.TabIndex = 2
        Me.Btn_Maxi.UseVisualStyleBackColor = True
        '
        'Btn_Mini
        '
        Me.Btn_Mini.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Mini.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Mini.FlatAppearance.BorderSize = 0
        Me.Btn_Mini.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Btn_Mini.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue
        Me.Btn_Mini.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Mini.Image = Global.LiBook.My.Resources.Resources.Icono_Minimizar
        Me.Btn_Mini.Location = New System.Drawing.Point(968, 0)
        Me.Btn_Mini.Name = "Btn_Mini"
        Me.Btn_Mini.Size = New System.Drawing.Size(40, 40)
        Me.Btn_Mini.TabIndex = 1
        Me.Btn_Mini.UseVisualStyleBackColor = True
        '
        'Btn_Cerrar
        '
        Me.Btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Cerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Cerrar.FlatAppearance.BorderSize = 0
        Me.Btn_Cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Btn_Cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Cerrar.Image = Global.LiBook.My.Resources.Resources.Icono_cerrar_FN
        Me.Btn_Cerrar.Location = New System.Drawing.Point(1060, 0)
        Me.Btn_Cerrar.Name = "Btn_Cerrar"
        Me.Btn_Cerrar.Size = New System.Drawing.Size(40, 40)
        Me.Btn_Cerrar.TabIndex = 0
        Me.Btn_Cerrar.UseVisualStyleBackColor = True
        '
        'Pnl_Menu
        '
        Me.Pnl_Menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Pnl_Menu.Controls.Add(Me.Panel5)
        Me.Pnl_Menu.Controls.Add(Me.Panel4)
        Me.Pnl_Menu.Controls.Add(Me.Btn_Estadistica)
        Me.Pnl_Menu.Controls.Add(Me.Btn_Reservar)
        Me.Pnl_Menu.Controls.Add(Me.Panel3)
        Me.Pnl_Menu.Controls.Add(Me.Btn_Lista)
        Me.Pnl_Menu.Controls.Add(Me.Panel2)
        Me.Pnl_Menu.Controls.Add(Me.Btn_Prestamo)
        Me.Pnl_Menu.Controls.Add(Me.Panel1)
        Me.Pnl_Menu.Controls.Add(Me.Btn_Archivo)
        Me.Pnl_Menu.Controls.Add(Me.PictureBox1)
        Me.Pnl_Menu.Controls.Add(Me.Btn_menu)
        Me.Pnl_Menu.Dock = System.Windows.Forms.DockStyle.Left
        Me.Pnl_Menu.Location = New System.Drawing.Point(0, 40)
        Me.Pnl_Menu.Name = "Pnl_Menu"
        Me.Pnl_Menu.Size = New System.Drawing.Size(220, 540)
        Me.Pnl_Menu.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Panel5.Location = New System.Drawing.Point(0, 384)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(5, 55)
        Me.Panel5.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Panel4.Location = New System.Drawing.Point(0, 324)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(5, 55)
        Me.Panel4.TabIndex = 7
        '
        'Btn_Estadistica
        '
        Me.Btn_Estadistica.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Estadistica.FlatAppearance.BorderSize = 0
        Me.Btn_Estadistica.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue
        Me.Btn_Estadistica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Btn_Estadistica.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Estadistica.Font = New System.Drawing.Font("Lucida Sans Typewriter", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Estadistica.ForeColor = System.Drawing.Color.White
        Me.Btn_Estadistica.Image = Global.LiBook.My.Resources.Resources.icons8_gráfico_combinado_50
        Me.Btn_Estadistica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Estadistica.Location = New System.Drawing.Point(0, 385)
        Me.Btn_Estadistica.Name = "Btn_Estadistica"
        Me.Btn_Estadistica.Size = New System.Drawing.Size(220, 55)
        Me.Btn_Estadistica.TabIndex = 4
        Me.Btn_Estadistica.Text = "  Estadistica"
        Me.Btn_Estadistica.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Estadistica.UseVisualStyleBackColor = True
        '
        'Btn_Reservar
        '
        Me.Btn_Reservar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Reservar.FlatAppearance.BorderSize = 0
        Me.Btn_Reservar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue
        Me.Btn_Reservar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Btn_Reservar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Reservar.Font = New System.Drawing.Font("Lucida Sans Typewriter", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Reservar.ForeColor = System.Drawing.Color.White
        Me.Btn_Reservar.Image = Global.LiBook.My.Resources.Resources.icons8_reserva_50
        Me.Btn_Reservar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Reservar.Location = New System.Drawing.Point(0, 324)
        Me.Btn_Reservar.Name = "Btn_Reservar"
        Me.Btn_Reservar.Size = New System.Drawing.Size(220, 55)
        Me.Btn_Reservar.TabIndex = 8
        Me.Btn_Reservar.Text = "  Reservar"
        Me.Btn_Reservar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Reservar.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Panel3.Location = New System.Drawing.Point(0, 261)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(5, 55)
        Me.Panel3.TabIndex = 5
        '
        'Btn_Lista
        '
        Me.Btn_Lista.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Lista.FlatAppearance.BorderSize = 0
        Me.Btn_Lista.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue
        Me.Btn_Lista.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Btn_Lista.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Lista.Font = New System.Drawing.Font("Lucida Sans Typewriter", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Lista.ForeColor = System.Drawing.Color.White
        Me.Btn_Lista.Image = Global.LiBook.My.Resources.Resources.icons8_lista_de_verificación_50
        Me.Btn_Lista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Lista.Location = New System.Drawing.Point(0, 262)
        Me.Btn_Lista.Name = "Btn_Lista"
        Me.Btn_Lista.Size = New System.Drawing.Size(220, 55)
        Me.Btn_Lista.TabIndex = 6
        Me.Btn_Lista.Text = "  Lista"
        Me.Btn_Lista.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Lista.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Panel2.Location = New System.Drawing.Point(0, 200)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(5, 55)
        Me.Panel2.TabIndex = 3
        '
        'Btn_Prestamo
        '
        Me.Btn_Prestamo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Prestamo.FlatAppearance.BorderSize = 0
        Me.Btn_Prestamo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue
        Me.Btn_Prestamo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Btn_Prestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Prestamo.Font = New System.Drawing.Font("Lucida Sans Typewriter", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Prestamo.ForeColor = System.Drawing.Color.White
        Me.Btn_Prestamo.Image = Global.LiBook.My.Resources.Resources.icons8_estante_de_libro_50
        Me.Btn_Prestamo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Prestamo.Location = New System.Drawing.Point(0, 201)
        Me.Btn_Prestamo.Name = "Btn_Prestamo"
        Me.Btn_Prestamo.Size = New System.Drawing.Size(220, 55)
        Me.Btn_Prestamo.TabIndex = 4
        Me.Btn_Prestamo.Text = "  Prestamo"
        Me.Btn_Prestamo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Prestamo.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Panel1.Location = New System.Drawing.Point(0, 138)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(5, 55)
        Me.Panel1.TabIndex = 0
        '
        'Btn_Archivo
        '
        Me.Btn_Archivo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Archivo.FlatAppearance.BorderSize = 0
        Me.Btn_Archivo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue
        Me.Btn_Archivo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Btn_Archivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Archivo.Font = New System.Drawing.Font("Lucida Sans Typewriter", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Archivo.ForeColor = System.Drawing.Color.White
        Me.Btn_Archivo.Image = Global.LiBook.My.Resources.Resources.icons8_cabinete_de_archivos_50
        Me.Btn_Archivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Archivo.Location = New System.Drawing.Point(0, 139)
        Me.Btn_Archivo.Name = "Btn_Archivo"
        Me.Btn_Archivo.Size = New System.Drawing.Size(220, 55)
        Me.Btn_Archivo.TabIndex = 2
        Me.Btn_Archivo.Text = "  Archivo"
        Me.Btn_Archivo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Archivo.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.LiBook.My.Resources.Resources.cfae2360_a1fa_4bbe_9cef_08b9689af0351
        Me.PictureBox1.Location = New System.Drawing.Point(-23, 45)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(234, 69)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Btn_menu
        '
        Me.Btn_menu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_menu.Image = Global.LiBook.My.Resources.Resources.Mobile_Menu_Icon
        Me.Btn_menu.Location = New System.Drawing.Point(166, 1)
        Me.Btn_menu.Name = "Btn_menu"
        Me.Btn_menu.Size = New System.Drawing.Size(49, 38)
        Me.Btn_menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Btn_menu.TabIndex = 0
        Me.Btn_menu.TabStop = False
        '
        'Pnl_Contenedor
        '
        Me.Pnl_Contenedor.Cursor = System.Windows.Forms.Cursors.Default
        Me.Pnl_Contenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pnl_Contenedor.ForeColor = System.Drawing.Color.Lime
        Me.Pnl_Contenedor.Location = New System.Drawing.Point(220, 40)
        Me.Pnl_Contenedor.Name = "Pnl_Contenedor"
        Me.Pnl_Contenedor.Size = New System.Drawing.Size(880, 540)
        Me.Pnl_Contenedor.TabIndex = 2
        '
        'Tm_OcultarMenu
        '
        '
        'Tm_MostrarMenu
        '
        '
        'Pantalla_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1100, 580)
        Me.Controls.Add(Me.Pnl_Contenedor)
        Me.Controls.Add(Me.Pnl_Menu)
        Me.Controls.Add(Me.Pnl_Barra)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Pantalla_Principal"
        Me.Text = "Fm_menu"
        Me.Pnl_Barra.ResumeLayout(False)
        Me.Pnl_Menu.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Btn_menu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Pnl_Barra As Panel
    Friend WithEvents Pnl_Menu As Panel
    Friend WithEvents Pnl_Contenedor As Panel
    Friend WithEvents Btn_Cerrar As Button
    Friend WithEvents Btn_Maxi As Button
    Friend WithEvents Btn_Mini As Button
    Friend WithEvents Btn_Restaurar As Button
    Friend WithEvents Btn_menu As PictureBox
    Friend WithEvents Tm_OcultarMenu As Timer
    Friend WithEvents Tm_MostrarMenu As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Btn_Archivo As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Btn_Estadistica As Button
    Friend WithEvents Btn_Reservar As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Btn_Lista As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Btn_Prestamo As Button
End Class
