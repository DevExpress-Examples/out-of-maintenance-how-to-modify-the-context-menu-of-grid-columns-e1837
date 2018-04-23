using System.Windows;
using DevExpress.Xpf.Bars;
using DevExpress.Xpf.Grid;

namespace ShowGridMenu {

    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
        }

       #region #ShowGridMenu
        private void TableView_ShowGridMenu(object sender, GridMenuEventArgs e) {
            // Check whether this event was raised for a column's context menu.
            if (e.MenuType != GridMenuType.Column) return;

            // Remove the Column Chooser menu item.
            e.Customizations.Add(new RemoveBarItemAndLinkAction() { 
                ItemName = DefaultColumnMenuItemNames.ColumnChooser });

            // Create a custom menu item and add it to the context menu.
            BarButtonItem bi = new BarButtonItem();
            bi.Name = "customItem";
            bi.Content = "Custom Item";
            bi.ItemClick += new ItemClickEventHandler(customItem_ItemClick);
            e.Customizations.Add(bi);
        }

        private void customItem_ItemClick(object sender, ItemClickEventArgs e) {
            // Implement the custom action.
            // ...
        }
       #endregion #ShowGridMenu

    }
}
