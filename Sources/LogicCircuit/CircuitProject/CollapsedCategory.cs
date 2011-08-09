﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace LogicCircuit {
	public partial class CollapsedCategory {
	}

	public partial class CollapsedCategorySet {
		public void Load(XmlNodeList list) {
			CollapsedCategoryData.Load(this.Table, list, rowId => this.Create(rowId));
		}

		public bool IsCollapsed(string name) {
			return this.Find(name) != null;
		}

		public void SetCollapsed(string name, bool value) {
			CollapsedCategory collapsed = this.Find(name);
			if(value && collapsed == null) {
				this.CircuitProject.InOmitTransaction(() => this.CreateItem(name));
			} else if(!value && collapsed != null) {
				this.CircuitProject.InOmitTransaction(() => collapsed.Delete());
			}
		}

		public void Purge() {
			HashSet<string> category = new HashSet<string>(this.CircuitProject.LogicalCircuitSet.Select(c => c.Category));
			List<CollapsedCategory> list = this.Where(c => !category.Contains(c.Name)).ToList();
			foreach(CollapsedCategory collapsed in list) {
				collapsed.Delete();
			}
		}
	}
}