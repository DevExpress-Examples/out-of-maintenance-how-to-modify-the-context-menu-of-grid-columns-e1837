<!-- default file list -->
*Files to look at*:

* [Window1.xaml](./CS/Window1.xaml) (VB: [Window1.xaml.vb](./VB/Window1.xaml.vb))
* [Window1.xaml.cs](./CS/Window1.xaml.cs) (VB: [Window1.xaml.vb](./VB/Window1.xaml.vb))
<!-- default file list end -->
# How to modify the context menu of grid columns


<p>The following example demonstrates how to customize the grid's context menu at runtime. For instance this sample demonstrates how to remove the default 'Show Column Chooser' menu item from the <strong>Column Context Menu</strong>, and add a custom item instead.</p>


<h3>Description</h3>

<p>For this, it is necessary to handle the <strong>GridViewBase.ShowGridMenu</strong> event. In the event handler, all modifications to the list of menu items can be done by changing the <strong>e.Customizations</strong> collection. To remove a specific menu item along with its link use the <strong>RemoveBarItemAndLinkAction</strong> instance, and to add a custom menu item a new <strong>BarButtonItem</strong> object must be added to the <strong>e.Customizations</strong> collection.</p>

<br/>


