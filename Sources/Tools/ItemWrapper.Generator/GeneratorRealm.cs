﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 10.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace ItemWrapper.Generator
{
    using System;
    
    
    #line 1 "C:\Eugene\Projects\LogicCircuit\LogicCircuit\Work\Sources\Tools\ItemWrapper.Generator\GeneratorRealm.tt"
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "10.0.0.0")]
    public partial class GeneratorRealm : Transformation
    {
        public override string TransformText()
        {
            this.Write("namespace ");
            
            #line 2 "C:\Eugene\Projects\LogicCircuit\LogicCircuit\Work\Sources\Tools\ItemWrapper.Generator\GeneratorRealm.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Store.Namespace));
            
            #line default
            #line hidden
            this.Write(" {\r\n\tusing System;\r\n\tusing System.Collections.Generic;\r\n\tusing System.ComponentMo" +
                    "del;\r\n\tusing System.Diagnostics;\r\n\tusing ");
            
            #line 7 "C:\Eugene\Projects\LogicCircuit\LogicCircuit\Work\Sources\Tools\ItemWrapper.Generator\GeneratorRealm.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.StoreNameSpace));
            
            #line default
            #line hidden
            this.Write(";\r\n\r\n\tpartial class ");
            
            #line 9 "C:\Eugene\Projects\LogicCircuit\LogicCircuit\Work\Sources\Tools\ItemWrapper.Generator\GeneratorRealm.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Store.Name));
            
            #line default
            #line hidden
            this.Write(" : StoreSnapshot, INotifyPropertyChanged {\r\n\t\tprivate const string PersistenceNam" +
                    "espace = \"");
            
            #line 10 "C:\Eugene\Projects\LogicCircuit\LogicCircuit\Work\Sources\Tools\ItemWrapper.Generator\GeneratorRealm.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Store.PersistenceNamespace ?? string.Empty));
            
            #line default
            #line hidden
            this.Write("\";\r\n\t\tprivate const string PersistencePrefix = \"");
            
            #line 11 "C:\Eugene\Projects\LogicCircuit\LogicCircuit\Work\Sources\Tools\ItemWrapper.Generator\GeneratorRealm.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Store.PersistencePrefix ?? string.Empty));
            
            #line default
            #line hidden
            this.Write("\";\r\n\r\n\t\tpublic event PropertyChangedEventHandler PropertyChanged;\r\n\r\n");
            
            #line 15 "C:\Eugene\Projects\LogicCircuit\LogicCircuit\Work\Sources\Tools\ItemWrapper.Generator\GeneratorRealm.tt"
if(this.UseDispatcher) {
            
            #line default
            #line hidden
            this.Write("\t\tpublic System.Windows.Threading.Dispatcher Dispatcher { get; set; }\r\n\r\n");
            
            #line 18 "C:\Eugene\Projects\LogicCircuit\LogicCircuit\Work\Sources\Tools\ItemWrapper.Generator\GeneratorRealm.tt"
}
            
            #line default
            #line hidden
            
            #line 19 "C:\Eugene\Projects\LogicCircuit\LogicCircuit\Work\Sources\Tools\ItemWrapper.Generator\GeneratorRealm.tt"
foreach(Table table in this.Store) {
            
            #line default
            #line hidden
            this.Write("\t\tpublic ");
            
            #line 20 "C:\Eugene\Projects\LogicCircuit\LogicCircuit\Work\Sources\Tools\ItemWrapper.Generator\GeneratorRealm.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(table.Name));
            
            #line default
            #line hidden
            this.Write("Set ");
            
            #line 20 "C:\Eugene\Projects\LogicCircuit\LogicCircuit\Work\Sources\Tools\ItemWrapper.Generator\GeneratorRealm.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(table.Name));
            
            #line default
            #line hidden
            this.Write("Set { get; private set; }\r\n");
            
            #line 21 "C:\Eugene\Projects\LogicCircuit\LogicCircuit\Work\Sources\Tools\ItemWrapper.Generator\GeneratorRealm.tt"
}
            
            #line default
            #line hidden
            this.Write("\r\n\t\tpublic bool UpdateInProgress { get; private set; }\r\n\r\n\t\tpublic ");
            
            #line 25 "C:\Eugene\Projects\LogicCircuit\LogicCircuit\Work\Sources\Tools\ItemWrapper.Generator\GeneratorRealm.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Store.Name));
            
            #line default
            #line hidden
            this.Write("() : base() {\r\n\t\t\t// Create all sets\r\n\t\t\tthis.CreateSets();\r\n\r\n\t\t\t// Create forei" +
                    "gn keys\r\n");
            
            #line 30 "C:\Eugene\Projects\LogicCircuit\LogicCircuit\Work\Sources\Tools\ItemWrapper.Generator\GeneratorRealm.tt"
foreach(Table table in this.Store) {
            
            #line default
            #line hidden
            this.Write("\t\t\t");
            
            #line 31 "C:\Eugene\Projects\LogicCircuit\LogicCircuit\Work\Sources\Tools\ItemWrapper.Generator\GeneratorRealm.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(table.Name));
            
            #line default
            #line hidden
            this.Write("Data.CreateForeignKeys(this);\r\n");
            
            #line 32 "C:\Eugene\Projects\LogicCircuit\LogicCircuit\Work\Sources\Tools\ItemWrapper.Generator\GeneratorRealm.tt"
}
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\tthis.FreezeShape();\r\n\t\t\tthis.Init();\r\n\t\t}\r\n");
            
            #line 37 "C:\Eugene\Projects\LogicCircuit\LogicCircuit\Work\Sources\Tools\ItemWrapper.Generator\GeneratorRealm.tt"
if(this.RealmType == RealmType.Multiverse) {
            
            #line default
            #line hidden
            this.Write("\r\n\t\tpublic ");
            
            #line 39 "C:\Eugene\Projects\LogicCircuit\LogicCircuit\Work\Sources\Tools\ItemWrapper.Generator\GeneratorRealm.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Store.Name));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 39 "C:\Eugene\Projects\LogicCircuit\LogicCircuit\Work\Sources\Tools\ItemWrapper.Generator\GeneratorRealm.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Store.Name));
            
            #line default
            #line hidden
            this.Write(" store) : base(store) {\r\n\t\t\t// Create all sets\r\n\t\t\tthis.CreateSets();\r\n\r\n\t\t\t// Re" +
                    "gister existing data\r\n");
            
            #line 44 "C:\Eugene\Projects\LogicCircuit\LogicCircuit\Work\Sources\Tools\ItemWrapper.Generator\GeneratorRealm.tt"
foreach(Table table in this.Store) {
            
            #line default
            #line hidden
            this.Write("\t\t\tthis.");
            
            #line 45 "C:\Eugene\Projects\LogicCircuit\LogicCircuit\Work\Sources\Tools\ItemWrapper.Generator\GeneratorRealm.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(table.Name));
            
            #line default
            #line hidden
            this.Write("Set.Register();\r\n");
            
            #line 46 "C:\Eugene\Projects\LogicCircuit\LogicCircuit\Work\Sources\Tools\ItemWrapper.Generator\GeneratorRealm.tt"
}
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\tthis.Init();\r\n\t\t}\r\n");
            
            #line 50 "C:\Eugene\Projects\LogicCircuit\LogicCircuit\Work\Sources\Tools\ItemWrapper.Generator\GeneratorRealm.tt"
}
            
            #line default
            #line hidden
            this.Write("\r\n\t\tprivate void CreateSets() {\r\n");
            
            #line 53 "C:\Eugene\Projects\LogicCircuit\LogicCircuit\Work\Sources\Tools\ItemWrapper.Generator\GeneratorRealm.tt"
foreach(Table table in this.Store) {
            
            #line default
            #line hidden
            this.Write("\t\t\tthis.");
            
            #line 54 "C:\Eugene\Projects\LogicCircuit\LogicCircuit\Work\Sources\Tools\ItemWrapper.Generator\GeneratorRealm.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(table.Name));
            
            #line default
            #line hidden
            this.Write("Set = new ");
            
            #line 54 "C:\Eugene\Projects\LogicCircuit\LogicCircuit\Work\Sources\Tools\ItemWrapper.Generator\GeneratorRealm.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(table.Name));
            
            #line default
            #line hidden
            this.Write("Set(this);\r\n");
            
            #line 55 "C:\Eugene\Projects\LogicCircuit\LogicCircuit\Work\Sources\Tools\ItemWrapper.Generator\GeneratorRealm.tt"
}
            
            #line default
            #line hidden
            this.Write(@"		}

		private void Init() {
			this.VersionChanged += new EventHandler<VersionChangeEventArgs>(this.StoreVersionChanged);
			this.LatestVersionChanged += new EventHandler(this.StoreLatestVersionChanged);
			this.RolledBack += new EventHandler<RolledBackEventArgs>(this.StoreRolledBack);
		}

		private void NotifyPropertyChanged(string name) {
			PropertyChangedEventHandler handler = this.PropertyChanged;
			if(handler != null) {
");
            
            #line 67 "C:\Eugene\Projects\LogicCircuit\LogicCircuit\Work\Sources\Tools\ItemWrapper.Generator\GeneratorRealm.tt"
if(this.UseDispatcher) {
            
            #line default
            #line hidden
            this.Write(@"				System.Windows.Threading.Dispatcher dispatcher = this.Dispatcher;
				if(dispatcher != null && dispatcher.Thread != System.Threading.Thread.CurrentThread) {
					dispatcher.BeginInvoke(new Action<string>(this.NotifyPropertyChanged), name);
					return;
				}
");
            
            #line 73 "C:\Eugene\Projects\LogicCircuit\LogicCircuit\Work\Sources\Tools\ItemWrapper.Generator\GeneratorRealm.tt"
}
            
            #line default
            #line hidden
            this.Write(@"				handler(this, new PropertyChangedEventArgs(name));
			}
		}

		private void StoreVersionChanged(object sender, VersionChangeEventArgs e) {
			try {
				this.UpdateInProgress = true;
				int oldVersion = e.OldVersion;
				int newVersion = e.NewVersion;
");
            
            #line 83 "C:\Eugene\Projects\LogicCircuit\LogicCircuit\Work\Sources\Tools\ItemWrapper.Generator\GeneratorRealm.tt"
foreach(Table table in this.Store) {
            
            #line default
            #line hidden
            this.Write("\t\t\t\tList<");
            
            #line 84 "C:\Eugene\Projects\LogicCircuit\LogicCircuit\Work\Sources\Tools\ItemWrapper.Generator\GeneratorRealm.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(table.Name));
            
            #line default
            #line hidden
            this.Write("> deleted");
            
            #line 84 "C:\Eugene\Projects\LogicCircuit\LogicCircuit\Work\Sources\Tools\ItemWrapper.Generator\GeneratorRealm.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(table.Name));
            
            #line default
            #line hidden
            this.Write(" = this.");
            
            #line 84 "C:\Eugene\Projects\LogicCircuit\LogicCircuit\Work\Sources\Tools\ItemWrapper.Generator\GeneratorRealm.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(table.Name));
            
            #line default
            #line hidden
            this.Write("Set.UpdateSet(oldVersion, newVersion);\r\n");
            
            #line 85 "C:\Eugene\Projects\LogicCircuit\LogicCircuit\Work\Sources\Tools\ItemWrapper.Generator\GeneratorRealm.tt"
}
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 87 "C:\Eugene\Projects\LogicCircuit\LogicCircuit\Work\Sources\Tools\ItemWrapper.Generator\GeneratorRealm.tt"
foreach(Table table in this.Store) {
            
            #line default
            #line hidden
            this.Write("\t\t\t\tthis.");
            
            #line 88 "C:\Eugene\Projects\LogicCircuit\LogicCircuit\Work\Sources\Tools\ItemWrapper.Generator\GeneratorRealm.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(table.Name));
            
            #line default
            #line hidden
            this.Write("Set.NotifyVersionChanged(oldVersion, newVersion, deleted");
            
            #line 88 "C:\Eugene\Projects\LogicCircuit\LogicCircuit\Work\Sources\Tools\ItemWrapper.Generator\GeneratorRealm.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(table.Name));
            
            #line default
            #line hidden
            this.Write(");\r\n");
            
            #line 89 "C:\Eugene\Projects\LogicCircuit\LogicCircuit\Work\Sources\Tools\ItemWrapper.Generator\GeneratorRealm.tt"
}
            
            #line default
            #line hidden
            this.Write(@"
				this.NotifyPropertyChanged(""Version"");
			} finally {
				this.UpdateInProgress = false;
			}
		}

		private void StoreLatestVersionChanged(object sender, EventArgs e) {
			this.NotifyPropertyChanged(""LatestAvailableVersion"");
		}

		private void StoreRolledBack(object sender, RolledBackEventArgs e) {
			int version = e.Version;
");
            
            #line 103 "C:\Eugene\Projects\LogicCircuit\LogicCircuit\Work\Sources\Tools\ItemWrapper.Generator\GeneratorRealm.tt"
foreach(Table table in this.Store) {
            
            #line default
            #line hidden
            this.Write("\t\t\tthis.");
            
            #line 104 "C:\Eugene\Projects\LogicCircuit\LogicCircuit\Work\Sources\Tools\ItemWrapper.Generator\GeneratorRealm.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(table.Name));
            
            #line default
            #line hidden
            this.Write("Set.NotifyRolledBack(version);\r\n");
            
            #line 105 "C:\Eugene\Projects\LogicCircuit\LogicCircuit\Work\Sources\Tools\ItemWrapper.Generator\GeneratorRealm.tt"
}
            
            #line default
            #line hidden
            this.Write("\t\t}\r\n\t}\r\n}\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
