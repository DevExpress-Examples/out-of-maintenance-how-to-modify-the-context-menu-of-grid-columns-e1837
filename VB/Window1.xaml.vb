Imports System.Windows
Imports DevExpress.Xpf.Bars
Imports DevExpress.Xpf.Grid

Namespace ShowGridMenu

    Public Partial Class Window1
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub

'#Region "#ShowGridMenu"
        Private Sub TableView_ShowGridMenu(ByVal sender As Object, ByVal e As GridMenuEventArgs)
            ' Check whether this event was raised for a column's context menu.
            If e.MenuType <> GridMenuType.Column Then Return
            ' Remove the Column Chooser menu item.
            e.Customizations.Add(New RemoveBarItemAndLinkAction() With {.ItemName = DefaultColumnMenuItemNamesBase.ColumnChooser})
            ' Create a custom menu item and add it to the context menu.
            Dim bi As BarButtonItem = New BarButtonItem()
            bi.Name = "customItem"
            bi.Content = "Custom Item"
            AddHandler bi.ItemClick, New ItemClickEventHandler(AddressOf customItem_ItemClick)
            e.Customizations.Add(bi)
        End Sub

        Private Sub customItem_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        ' Implement the custom action.
        ' ...
        End Sub
'#End Region  ' #ShowGridMenu
    End Class
End Namespace
