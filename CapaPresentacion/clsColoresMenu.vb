Public Class clsColoresMenu
    Inherits ProfessionalColorTable

    Private ReadOnly azul As Color = Color.FromArgb(7, 47, 204)
    Private ReadOnly azulHover As Color = Color.FromArgb(5, 36, 160)
    Private ReadOnly seleccion As Color = Color.FromArgb(238, 243, 251)
    Private ReadOnly blanco As Color = Color.White

    Public Overrides ReadOnly Property MenuStripGradientBegin As Color
        Get
            Return azul
        End Get
    End Property

    Public Overrides ReadOnly Property MenuStripGradientEnd As Color
        Get
            Return azul
        End Get
    End Property

    Public Overrides ReadOnly Property ToolStripGradientBegin As Color
        Get
            Return azul
        End Get
    End Property

    Public Overrides ReadOnly Property ToolStripGradientMiddle As Color
        Get
            Return azul
        End Get
    End Property

    Public Overrides ReadOnly Property ToolStripGradientEnd As Color
        Get
            Return azul
        End Get
    End Property

    Public Overrides ReadOnly Property MenuItemSelected As Color
        Get
            Return seleccion
        End Get
    End Property

    Public Overrides ReadOnly Property MenuItemSelectedGradientBegin As Color
        Get
            Return seleccion
        End Get
    End Property

    Public Overrides ReadOnly Property MenuItemSelectedGradientEnd As Color
        Get
            Return seleccion
        End Get
    End Property

    Public Overrides ReadOnly Property MenuItemPressedGradientBegin As Color
        Get
            Return azulHover
        End Get
    End Property

    Public Overrides ReadOnly Property MenuItemPressedGradientMiddle As Color
        Get
            Return azulHover
        End Get
    End Property

    Public Overrides ReadOnly Property MenuItemPressedGradientEnd As Color
        Get
            Return azulHover
        End Get
    End Property

    Public Overrides ReadOnly Property MenuItemBorder As Color
        Get
            Return seleccion
        End Get
    End Property

    Public Overrides ReadOnly Property MenuBorder As Color
        Get
            Return blanco
        End Get
    End Property

    Public Overrides ReadOnly Property ToolStripBorder As Color
        Get
            Return azul
        End Get
    End Property

    Public Overrides ReadOnly Property ToolStripDropDownBackground As Color
        Get
            Return blanco
        End Get
    End Property

    Public Overrides ReadOnly Property ImageMarginGradientBegin As Color
        Get
            Return blanco
        End Get
    End Property

    Public Overrides ReadOnly Property ImageMarginGradientMiddle As Color
        Get
            Return blanco
        End Get
    End Property

    Public Overrides ReadOnly Property ImageMarginGradientEnd As Color
        Get
            Return blanco
        End Get
    End Property

    Public Overrides ReadOnly Property SeparatorDark As Color
        Get
            Return blanco
        End Get
    End Property

    Public Overrides ReadOnly Property SeparatorLight As Color
        Get
            Return blanco
        End Get
    End Property
End Class

Public Class clsRenderMenu
    Inherits ToolStripProfessionalRenderer

    Private ReadOnly azul As Color = Color.FromArgb(7, 47, 204)
    Private ReadOnly azulHover As Color = Color.FromArgb(5, 36, 160)
    Private ReadOnly seleccion As Color = Color.FromArgb(238, 243, 251)

    Public Sub New()
        MyBase.New(New clsColoresMenu())
    End Sub

    Protected Overrides Sub OnRenderToolStripBackground(e As ToolStripRenderEventArgs)
        Dim fondo As Color = azul
        If TypeOf e.ToolStrip Is ToolStripDropDown Then
            fondo = Color.White
        End If
        Using brocha As New SolidBrush(fondo)
            e.Graphics.FillRectangle(brocha, e.AffectedBounds)
        End Using
    End Sub

    Protected Overrides Sub OnRenderToolStripBorder(e As ToolStripRenderEventArgs)
        ' Sin el borde gris del menú del sistema.
    End Sub

    Protected Overrides Sub OnRenderImageMargin(e As ToolStripRenderEventArgs)
        Using brocha As New SolidBrush(Color.White)
            e.Graphics.FillRectangle(brocha, e.AffectedBounds)
        End Using
    End Sub

    Protected Overrides Sub OnRenderMenuItemBackground(e As ToolStripItemRenderEventArgs)
        Dim rect As New Rectangle(Point.Empty, e.Item.Size)
        If e.Item.IsOnDropDown Then
            Dim fondo As Color = Color.White
            If e.Item.Selected Then
                fondo = seleccion
            End If
            Using brocha As New SolidBrush(fondo)
                e.Graphics.FillRectangle(brocha, rect)
            End Using
            Return
        End If

        If e.Item.Name = "mnuMarca" Then
            Using brocha As New SolidBrush(azul)
                e.Graphics.FillRectangle(brocha, rect)
            End Using
            Return
        End If

        Dim activo As Boolean = e.Item.BackColor.ToArgb() = azulHover.ToArgb()
        Dim colorBarra As Color = azul
        If e.Item.Selected OrElse e.Item.Pressed OrElse activo Then
            colorBarra = azulHover
        End If
        Using brocha As New SolidBrush(colorBarra)
            e.Graphics.FillRectangle(brocha, rect)
        End Using
        If activo AndAlso e.Item.Height > 4 Then
            Using lapiz As New Pen(Color.White, 2)
                Dim y As Integer = e.Item.Height - 2
                e.Graphics.DrawLine(lapiz, 10, y, e.Item.Width - 10, y)
            End Using
        End If
    End Sub
End Class
