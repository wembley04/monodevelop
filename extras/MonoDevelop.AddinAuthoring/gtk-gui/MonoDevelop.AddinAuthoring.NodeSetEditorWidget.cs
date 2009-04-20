// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MonoDevelop.AddinAuthoring {
    
    
    public partial class NodeSetEditorWidget {
        
        private Gtk.HBox hbox4;
        
        private Gtk.ScrolledWindow GtkScrolledWindow;
        
        private Gtk.TreeView tree;
        
        private Gtk.VBox buttonBox;
        
        private Gtk.Button addNodeButton;
        
        private Gtk.Button addSetButton;
        
        private Gtk.Button removeNodeButton;
        
        private Gtk.Button editNodeButton;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget MonoDevelop.AddinAuthoring.NodeSetEditorWidget
            Stetic.BinContainer.Attach(this);
            this.Name = "MonoDevelop.AddinAuthoring.NodeSetEditorWidget";
            // Container child MonoDevelop.AddinAuthoring.NodeSetEditorWidget.Gtk.Container+ContainerChild
            this.hbox4 = new Gtk.HBox();
            this.hbox4.Name = "hbox4";
            this.hbox4.Spacing = 6;
            // Container child hbox4.Gtk.Box+BoxChild
            this.GtkScrolledWindow = new Gtk.ScrolledWindow();
            this.GtkScrolledWindow.Name = "GtkScrolledWindow";
            this.GtkScrolledWindow.ShadowType = ((Gtk.ShadowType)(1));
            // Container child GtkScrolledWindow.Gtk.Container+ContainerChild
            this.tree = new Gtk.TreeView();
            this.tree.CanFocus = true;
            this.tree.Name = "tree";
            this.GtkScrolledWindow.Add(this.tree);
            this.hbox4.Add(this.GtkScrolledWindow);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.hbox4[this.GtkScrolledWindow]));
            w2.Position = 0;
            // Container child hbox4.Gtk.Box+BoxChild
            this.buttonBox = new Gtk.VBox();
            this.buttonBox.Name = "buttonBox";
            this.buttonBox.Spacing = 6;
            // Container child buttonBox.Gtk.Box+BoxChild
            this.addNodeButton = new Gtk.Button();
            this.addNodeButton.CanFocus = true;
            this.addNodeButton.Name = "addNodeButton";
            this.addNodeButton.UseUnderline = true;
            // Container child addNodeButton.Gtk.Container+ContainerChild
            Gtk.Alignment w3 = new Gtk.Alignment(0.5F, 0.5F, 0F, 0F);
            // Container child GtkAlignment.Gtk.Container+ContainerChild
            Gtk.HBox w4 = new Gtk.HBox();
            w4.Spacing = 2;
            // Container child GtkHBox.Gtk.Container+ContainerChild
            Gtk.Image w5 = new Gtk.Image();
            w5.Pixbuf = Stetic.IconLoader.LoadIcon(this, "gtk-add", Gtk.IconSize.Menu, 16);
            w4.Add(w5);
            // Container child GtkHBox.Gtk.Container+ContainerChild
            Gtk.Label w7 = new Gtk.Label();
            w7.LabelProp = Mono.Addins.AddinManager.CurrentLocalizer.GetString("_Add Node Type...");
            w7.UseUnderline = true;
            w4.Add(w7);
            w3.Add(w4);
            this.addNodeButton.Add(w3);
            this.buttonBox.Add(this.addNodeButton);
            Gtk.Box.BoxChild w11 = ((Gtk.Box.BoxChild)(this.buttonBox[this.addNodeButton]));
            w11.Position = 0;
            w11.Expand = false;
            w11.Fill = false;
            // Container child buttonBox.Gtk.Box+BoxChild
            this.addSetButton = new Gtk.Button();
            this.addSetButton.CanFocus = true;
            this.addSetButton.Name = "addSetButton";
            this.addSetButton.UseUnderline = true;
            // Container child addSetButton.Gtk.Container+ContainerChild
            Gtk.Alignment w12 = new Gtk.Alignment(0.5F, 0.5F, 0F, 0F);
            // Container child GtkAlignment.Gtk.Container+ContainerChild
            Gtk.HBox w13 = new Gtk.HBox();
            w13.Spacing = 2;
            // Container child GtkHBox.Gtk.Container+ContainerChild
            Gtk.Image w14 = new Gtk.Image();
            w14.Pixbuf = Stetic.IconLoader.LoadIcon(this, "gtk-add", Gtk.IconSize.Menu, 16);
            w13.Add(w14);
            // Container child GtkHBox.Gtk.Container+ContainerChild
            Gtk.Label w16 = new Gtk.Label();
            w16.LabelProp = Mono.Addins.AddinManager.CurrentLocalizer.GetString("Add Node _Set...");
            w16.UseUnderline = true;
            w13.Add(w16);
            w12.Add(w13);
            this.addSetButton.Add(w12);
            this.buttonBox.Add(this.addSetButton);
            Gtk.Box.BoxChild w20 = ((Gtk.Box.BoxChild)(this.buttonBox[this.addSetButton]));
            w20.Position = 1;
            w20.Expand = false;
            w20.Fill = false;
            // Container child buttonBox.Gtk.Box+BoxChild
            this.removeNodeButton = new Gtk.Button();
            this.removeNodeButton.CanFocus = true;
            this.removeNodeButton.Name = "removeNodeButton";
            this.removeNodeButton.UseStock = true;
            this.removeNodeButton.UseUnderline = true;
            this.removeNodeButton.Label = "gtk-remove";
            this.buttonBox.Add(this.removeNodeButton);
            Gtk.Box.BoxChild w21 = ((Gtk.Box.BoxChild)(this.buttonBox[this.removeNodeButton]));
            w21.Position = 2;
            w21.Expand = false;
            w21.Fill = false;
            // Container child buttonBox.Gtk.Box+BoxChild
            this.editNodeButton = new Gtk.Button();
            this.editNodeButton.CanFocus = true;
            this.editNodeButton.Name = "editNodeButton";
            this.editNodeButton.UseStock = true;
            this.editNodeButton.UseUnderline = true;
            this.editNodeButton.Label = "gtk-edit";
            this.buttonBox.Add(this.editNodeButton);
            Gtk.Box.BoxChild w22 = ((Gtk.Box.BoxChild)(this.buttonBox[this.editNodeButton]));
            w22.Position = 3;
            w22.Expand = false;
            w22.Fill = false;
            this.hbox4.Add(this.buttonBox);
            Gtk.Box.BoxChild w23 = ((Gtk.Box.BoxChild)(this.hbox4[this.buttonBox]));
            w23.Position = 1;
            w23.Expand = false;
            w23.Fill = false;
            this.Add(this.hbox4);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.Show();
            this.addNodeButton.Clicked += new System.EventHandler(this.OnAddNodeButtonClicked);
            this.addSetButton.Clicked += new System.EventHandler(this.OnAddSetButtonClicked);
            this.removeNodeButton.Clicked += new System.EventHandler(this.OnRemoveNodeButtonClicked);
            this.editNodeButton.Clicked += new System.EventHandler(this.OnEditNodeButtonClicked);
        }
    }
}
