Imports System.Runtime.InteropServices

Public Class Pantalla_Principal
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub




    Private Sub Pantalla_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_Cerrar.Click
        Me.Close()
    End Sub

    Private Sub Btn_Maxi_Click(sender As Object, e As EventArgs) Handles Btn_Maxi.Click
        Btn_Maxi.Visible = False
        Btn_Restaurar.Visible = True
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Btn_Restaurar_Click(sender As Object, e As EventArgs) Handles Btn_Restaurar.Click
        Btn_Restaurar.Visible = False
        Btn_Maxi.Visible = True
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Btn_Mini_Click(sender As Object, e As EventArgs) Handles Btn_Mini.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Pnl_Barra_Paint(sender As Object, e As PaintEventArgs) Handles Pnl_Barra.Paint
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Tm_OcultarMenu_Tick(sender As Object, e As EventArgs) Handles Tm_OcultarMenu.Tick
        If Pnl_Menu.Width <= 60 Then
            Me.Tm_OcultarMenu.Enabled = False
        Else
            Me.Pnl_Menu.Width = Pnl_Menu.Width - 40

        End If
    End Sub

    Private Sub Tm_MostrarMenu_Tick(sender As Object, e As EventArgs) Handles Tm_MostrarMenu.Tick
        If Pnl_Menu.Width >= 220 Then
            Me.Tm_MostrarMenu.Enabled = False
        Else
            Me.Pnl_Menu.Width = Pnl_Menu.Width + 40

        End If
    End Sub

    Private Sub Btn_menu_Click(sender As Object, e As EventArgs) Handles Btn_menu.Click
        If Pnl_Menu.Width = 220 Then
            Tm_OcultarMenu.Enabled = True
        ElseIf Pnl_Menu.Width = 60 Then
            Tm_MostrarMenu.Enabled = True
        End If


    End Sub

    Private Sub AbrirFomEnPanel(ByVal formhijo As Object)
        If Me.Pnl_Contenedor.Controls.Count > 0 Then
            Me.Pnl_Contenedor.Controls.RemoveAt(0)
        End If
        Dim fh As Form = TryCast(formhijo, Form)
        fh.TopLevel = False
        fh.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        fh.Dock = DockStyle.Fill
        Me.Pnl_Contenedor.Controls.Add(fh)
        fh.Show()

    End Sub

    Private Sub Btn_Archivo_Click(sender As Object, e As EventArgs) Handles Btn_Archivo.Click
        AbrirFomEnPanel(New Pantalla_Archivo)
    End Sub
End Class
