Imports System.Runtime.InteropServices

Public Class Pantalla_Principal

#Region "Fucionalidades del Formulario"
    'RESIZE DEL FORMULARIO- CAMBIAR TAMAÑO
    Dim cGrip As Integer = 10

    Protected Overrides Sub WndProc(ByRef m As Message)
        If (m.Msg = 132) Then
            Dim pos As Point = New Point((m.LParam.ToInt32 And 65535), (m.LParam.ToInt32 + 16))
            pos = Me.PointToClient(pos)
            If ((pos.X _
                        >= (Me.ClientSize.Width - cGrip)) _
                        AndAlso (pos.Y _
                        >= (Me.ClientSize.Height - cGrip))) Then
                m.Result = CType(17, IntPtr)
                Return
            End If
        End If
        MyBase.WndProc(m)
    End Sub



    '----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 

    Dim sizeGripRectangle As Rectangle
    Dim tolerance As Integer = 15

    Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
        MyBase.OnSizeChanged(e)
        Dim region = New Region(New Rectangle(0, 0, Me.ClientRectangle.Width, Me.ClientRectangle.Height))
        sizeGripRectangle = New Rectangle((Me.ClientRectangle.Width - tolerance), (Me.ClientRectangle.Height - tolerance), tolerance, tolerance)
        region.Exclude(sizeGripRectangle)
        Me.Pnl_Principal.Region = region
        Me.Invalidate()
    End Sub

    '----------------COLOR Y GRIP DE RECTANGULO INFERIOR
    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim blueBrush As SolidBrush = New SolidBrush(Color.FromArgb(244, 244, 244))
        e.Graphics.FillRectangle(blueBrush, sizeGripRectangle)
        MyBase.OnPaint(e)
        ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle)
    End Sub


    'ARRASTRAR FORMULARIO
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    'Arrastrar el formulario con la barra
    Private Sub Pnl_Cabecer_MouseMove(sender As Object, e As MouseEventArgs) Handles Pnl_Cabecera.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)

    End Sub

    'Botones de Barra
    Private Sub Btn_cerrar_Click(sender As Object, e As EventArgs) Handles Btn_cerrar.Click
        Application.Exit()
    End Sub

    Dim lx, ly As Integer
    Dim sw, sh As Integer

    Private Sub Btn_maxi_Click(sender As Object, e As EventArgs) Handles Btn_maxi.Click
        lx = Me.Location.X
        ly = Me.Location.Y
        sw = Me.Size.Width
        sh = Me.Size.Height

        Btn_maxi.Visible = False
        Btn_restaurar.Visible = True
        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location
    End Sub

    Private Sub Btn_restaurar_Click(sender As Object, e As EventArgs) Handles Btn_restaurar.Click

        Btn_restaurar.Visible = False
        Btn_maxi.Visible = True
        Me.Size = New Size(sw, sh)
        Me.Location = New Point(lx, ly)
    End Sub

    Private Sub Btn_mini_Click(sender As Object, e As EventArgs) Handles Btn_mini.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


    Private Sub Tm_Ocultar_Tick(sender As Object, e As EventArgs) Handles Tm_Ocultar.Tick

        If Pnl_Menu.Width <= 60 Then
            Me.Tm_Ocultar.Enabled = False
        Else
            Me.Pnl_Menu.Width = Pnl_Menu.Width - 20

        End If

    End Sub


    Private Sub Tm_Mostrar_Tick(sender As Object, e As EventArgs) Handles Tm_Mostrar.Tick
        If Pnl_Menu.Width >= 220 Then
            Me.Tm_Mostrar.Enabled = False
        Else
            Me.Pnl_Menu.Width = Pnl_Menu.Width + 20

        End If
    End Sub

    Private Sub Btn_Menu_Click(sender As Object, e As EventArgs) Handles Btn_Menu.Click
        If Pnl_Menu.Width = 220 Then
            Tm_Ocultar.Enabled = True

        ElseIf Pnl_Menu.Width = 60 Then
            Tm_Mostrar.Enabled = True
        End If
    End Sub


#End Region


    'Metodo Abrir Formulario
    Private Sub AbrirFormEnPanel(Of Miform As {Form, New})()
        Dim Formulario As Form
        Formulario = Pnl_Contenedor.Controls.OfType(Of Miform)().FirstOrDefault() 'Busca el formulario en la coleccion
        'si form no fue encontrdo / no existe
        If Formulario Is Nothing Then
            Formulario = New Miform()
            Formulario.TopLevel = False
            Formulario.FormBorderStyle = FormBorderStyle.None
            Formulario.Dock = DockStyle.Fill
            Pnl_Contenedor.Controls.Add(Formulario)
            Pnl_Contenedor.Tag = Formulario
            AddHandler Formulario.FormClosed, AddressOf Me.CerrarFormulario
            Formulario.Show()
            Formulario.BringToFront()
        Else
            Formulario.BringToFront()
        End If
    End Sub


    Private Sub Btn_Archivar_Click(sender As Object, e As EventArgs) Handles Btn_Archivar.Click
        AbrirFormEnPanel(Of Form_Archivar)()
        Btn_Archivar.BackColor = Color.FromArgb(13, 93, 142)
    End Sub

    Private Sub Btn_Prestamo_Click(sender As Object, e As EventArgs) Handles Btn_Prestamo.Click
        AbrirFormEnPanel(Of Form_Prestamo)()
        Btn_Prestamo.BackColor = Color.FromArgb(13, 93, 142)
    End Sub

    Private Sub Btn_Lista_Click(sender As Object, e As EventArgs) Handles Btn_Lista.Click
        AbrirFormEnPanel(Of Form_Lista)()
        Btn_Lista.BackColor = Color.FromArgb(13, 93, 142)
    End Sub

    Private Sub Btn_Reservar_Click(sender As Object, e As EventArgs) Handles Btn_Reservar.Click
        AbrirFormEnPanel(Of Form_Reservar)()
        Btn_Reservar.BackColor = Color.FromArgb(13, 93, 142)
    End Sub

    Private Sub Btn_Estadistica_Click(sender As Object, e As EventArgs) Handles Btn_Estadistica.Click
        AbrirFormEnPanel(Of Form_Estadistica)()
        Btn_Estadistica.BackColor = Color.FromArgb(13, 93, 142)
    End Sub

    'Metodo al cerrar Forms
    Private Sub CerrarFormulario(ByVal sender As Object, ByVal e As FormClosedEventArgs)
        'Condicion si Forms esta abierto
        If (Application.OpenForms("Form_Prestamo") Is Nothing) Then
            Btn_Archivar.BackColor = Color.FromArgb(37, 46, 59)
        End If
        If (Application.OpenForms("Form_Prestamo") Is Nothing) Then
            Btn_Prestamo.BackColor = Color.FromArgb(37, 46, 59)
        End If
        If (Application.OpenForms("Form_Lista") Is Nothing) Then
            Btn_Lista.BackColor = Color.FromArgb(37, 46, 59)
        End If
        If (Application.OpenForms("Form_Reservar") Is Nothing) Then
            Btn_Reservar.BackColor = Color.FromArgb(37, 46, 59)
        End If
        If (Application.OpenForms("Form_Reservar") Is Nothing) Then
            Btn_Estadistica.BackColor = Color.FromArgb(37, 46, 59)
        End If
    End Sub


End Class
