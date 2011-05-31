
// This file has been generated by the GUI designer. Do not modify.
namespace MonoDevelop.IPhone.Gui
{
	internal partial class IPhoneSigningKeyPanelWidget
	{
		private global::Gtk.VBox vbox1;
		private global::Gtk.Alignment alignment2;
		private global::Gtk.VBox vbox3;
		private global::Gtk.Alignment alignment3;
		private global::Gtk.Table signingTable;
		private global::MonoDevelop.Components.MenuButtonEntry additionalArgsEntry;
		private global::MonoDevelop.Ide.Gui.Components.ProjectFileEntry entitlementsEntry;
		private global::MonoDevelop.MacDev.SigningIdentityCombo identityCombo;
		private global::Gtk.Label label4;
		private global::Gtk.Label label6;
		private global::Gtk.Label label7;
		private global::Gtk.Label label8;
		private global::Gtk.Label label9;
		private global::MonoDevelop.MacDev.SigningIdentityCombo provisioningCombo;
		private global::MonoDevelop.Ide.Gui.Components.ProjectFileEntry resourceRulesEntry;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MonoDevelop.IPhone.Gui.IPhoneSigningKeyPanelWidget
			global::Stetic.BinContainer.Attach (this);
			this.Name = "MonoDevelop.IPhone.Gui.IPhoneSigningKeyPanelWidget";
			// Container child MonoDevelop.IPhone.Gui.IPhoneSigningKeyPanelWidget.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.alignment2 = new global::Gtk.Alignment (0F, 0.5F, 1F, 1F);
			this.alignment2.Name = "alignment2";
			// Container child alignment2.Gtk.Container+ContainerChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.alignment3 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment3.Name = "alignment3";
			// Container child alignment3.Gtk.Container+ContainerChild
			this.signingTable = new global::Gtk.Table (((uint)(5)), ((uint)(2)), false);
			this.signingTable.Name = "signingTable";
			this.signingTable.RowSpacing = ((uint)(6));
			this.signingTable.ColumnSpacing = ((uint)(6));
			// Container child signingTable.Gtk.Table+TableChild
			this.additionalArgsEntry = new global::MonoDevelop.Components.MenuButtonEntry ();
			this.additionalArgsEntry.Name = "additionalArgsEntry";
			this.signingTable.Add (this.additionalArgsEntry);
			global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.signingTable [this.additionalArgsEntry]));
			w1.TopAttach = ((uint)(4));
			w1.BottomAttach = ((uint)(5));
			w1.LeftAttach = ((uint)(1));
			w1.RightAttach = ((uint)(2));
			w1.YOptions = ((global::Gtk.AttachOptions)(0));
			// Container child signingTable.Gtk.Table+TableChild
			this.entitlementsEntry = new global::MonoDevelop.Ide.Gui.Components.ProjectFileEntry ();
			this.entitlementsEntry.Name = "entitlementsEntry";
			this.entitlementsEntry.VerifyFileExistsInProject = false;
			this.entitlementsEntry.EntryIsEditable = false;
			this.signingTable.Add (this.entitlementsEntry);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.signingTable [this.entitlementsEntry]));
			w2.TopAttach = ((uint)(2));
			w2.BottomAttach = ((uint)(3));
			w2.LeftAttach = ((uint)(1));
			w2.RightAttach = ((uint)(2));
			w2.YOptions = ((global::Gtk.AttachOptions)(0));
			// Container child signingTable.Gtk.Table+TableChild
			this.identityCombo = new global::MonoDevelop.MacDev.SigningIdentityCombo ();
			this.identityCombo.Name = "identityCombo";
			this.signingTable.Add (this.identityCombo);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.signingTable [this.identityCombo]));
			w3.LeftAttach = ((uint)(1));
			w3.RightAttach = ((uint)(2));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child signingTable.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.Xalign = 0F;
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("_Identity:");
			this.label4.UseUnderline = true;
			this.signingTable.Add (this.label4);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.signingTable [this.label4]));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child signingTable.Gtk.Table+TableChild
			this.label6 = new global::Gtk.Label ();
			this.label6.Name = "label6";
			this.label6.Xalign = 0F;
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("_Provisioning profile:");
			this.label6.UseUnderline = true;
			this.signingTable.Add (this.label6);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.signingTable [this.label6]));
			w5.TopAttach = ((uint)(1));
			w5.BottomAttach = ((uint)(2));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child signingTable.Gtk.Table+TableChild
			this.label7 = new global::Gtk.Label ();
			this.label7.Name = "label7";
			this.label7.Xalign = 0F;
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString ("Custom _entitlements:");
			this.label7.UseUnderline = true;
			this.signingTable.Add (this.label7);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.signingTable [this.label7]));
			w6.TopAttach = ((uint)(2));
			w6.BottomAttach = ((uint)(3));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child signingTable.Gtk.Table+TableChild
			this.label8 = new global::Gtk.Label ();
			this.label8.Name = "label8";
			this.label8.Xalign = 0F;
			this.label8.LabelProp = global::Mono.Unix.Catalog.GetString ("Custom _resource rules:");
			this.label8.UseUnderline = true;
			this.signingTable.Add (this.label8);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.signingTable [this.label8]));
			w7.TopAttach = ((uint)(3));
			w7.BottomAttach = ((uint)(4));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child signingTable.Gtk.Table+TableChild
			this.label9 = new global::Gtk.Label ();
			this.label9.Name = "label9";
			this.label9.Xalign = 0F;
			this.label9.LabelProp = global::Mono.Unix.Catalog.GetString ("_Additional arguments:");
			this.label9.UseUnderline = true;
			this.signingTable.Add (this.label9);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.signingTable [this.label9]));
			w8.TopAttach = ((uint)(4));
			w8.BottomAttach = ((uint)(5));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child signingTable.Gtk.Table+TableChild
			this.provisioningCombo = new global::MonoDevelop.MacDev.SigningIdentityCombo ();
			this.provisioningCombo.Name = "provisioningCombo";
			this.signingTable.Add (this.provisioningCombo);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.signingTable [this.provisioningCombo]));
			w9.TopAttach = ((uint)(1));
			w9.BottomAttach = ((uint)(2));
			w9.LeftAttach = ((uint)(1));
			w9.RightAttach = ((uint)(2));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child signingTable.Gtk.Table+TableChild
			this.resourceRulesEntry = new global::MonoDevelop.Ide.Gui.Components.ProjectFileEntry ();
			this.resourceRulesEntry.Name = "resourceRulesEntry";
			this.resourceRulesEntry.VerifyFileExistsInProject = false;
			this.resourceRulesEntry.EntryIsEditable = false;
			this.signingTable.Add (this.resourceRulesEntry);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.signingTable [this.resourceRulesEntry]));
			w10.TopAttach = ((uint)(3));
			w10.BottomAttach = ((uint)(4));
			w10.LeftAttach = ((uint)(1));
			w10.RightAttach = ((uint)(2));
			w10.YOptions = ((global::Gtk.AttachOptions)(0));
			this.alignment3.Add (this.signingTable);
			this.vbox3.Add (this.alignment3);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.alignment3]));
			w12.Position = 1;
			w12.Expand = false;
			w12.Fill = false;
			this.alignment2.Add (this.vbox3);
			this.vbox1.Add (this.alignment2);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.alignment2]));
			w14.Position = 1;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.label4.MnemonicWidget = this.identityCombo;
			this.label6.MnemonicWidget = this.provisioningCombo;
			this.label7.MnemonicWidget = this.entitlementsEntry;
			this.label8.MnemonicWidget = this.resourceRulesEntry;
			this.Hide ();
		}
	}
}
