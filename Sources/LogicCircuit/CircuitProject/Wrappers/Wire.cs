﻿// This file is generated by ItemWrapper.Generator. Do not modify this file as it will be regenerated
namespace LogicCircuit {
	using System;
	using System.Collections.Generic;
	using System.Collections.Specialized;
	using System.ComponentModel;
	using System.Diagnostics;
	using System.Globalization;
	using System.Linq;
	using System.Text;
	using LogicCircuit.DataPersistent;

	// Defines the shape of the table Wire
	internal partial struct WireData {
		public Guid WireId;
		public Guid LogicalCircuitId;
		public int X1;
		public int Y1;
		public int X2;
		public int Y2;
		internal Wire Wire;
		// Field accessors
		// Accessor of the WireId field
		public sealed class WireIdField : IField<WireData, Guid>, IFieldSerializer<WireData> {
			public static readonly WireIdField Field = new WireIdField();
			private WireIdField() {}
			public string Name { get { return "WireId"; } }
			public int Order { get; set; }
			public Guid DefaultValue { get { return default(Guid); } }
			public Guid GetValue(ref WireData record) {
				return record.WireId;
			}
			public void SetValue(ref WireData record, Guid value) {
				record.WireId = value;
			}
			public int Compare(ref WireData l, ref WireData r) {
				return l.WireId.CompareTo(r.WireId);
			}
			public int Compare(Guid l, Guid r) {
				return l.CompareTo(r);
			}

			// Implementation of interface IFieldSerializer<WireData>
			bool IFieldSerializer<WireData>.NeedToSave(ref WireData data) {
				return this.Compare(data.WireId, this.DefaultValue) != 0;
			}
			string IFieldSerializer<WireData>.GetTextValue(ref WireData data) {
				return string.Format(CultureInfo.InvariantCulture, "{0}", data.WireId);
			}
			void IFieldSerializer<WireData>.SetDefault(ref WireData data) {
				data.WireId = this.DefaultValue;
			}
			void IFieldSerializer<WireData>.SetTextValue(ref WireData data, string text) {
				data.WireId = new Guid(text);
			}
		}

		// Accessor of the LogicalCircuitId field
		public sealed class LogicalCircuitIdField : IField<WireData, Guid>, IFieldSerializer<WireData> {
			public static readonly LogicalCircuitIdField Field = new LogicalCircuitIdField();
			private LogicalCircuitIdField() {}
			public string Name { get { return "LogicalCircuitId"; } }
			public int Order { get; set; }
			public Guid DefaultValue { get { return default(Guid); } }
			public Guid GetValue(ref WireData record) {
				return record.LogicalCircuitId;
			}
			public void SetValue(ref WireData record, Guid value) {
				record.LogicalCircuitId = value;
			}
			public int Compare(ref WireData l, ref WireData r) {
				return l.LogicalCircuitId.CompareTo(r.LogicalCircuitId);
			}
			public int Compare(Guid l, Guid r) {
				return l.CompareTo(r);
			}

			// Implementation of interface IFieldSerializer<WireData>
			bool IFieldSerializer<WireData>.NeedToSave(ref WireData data) {
				return this.Compare(data.LogicalCircuitId, this.DefaultValue) != 0;
			}
			string IFieldSerializer<WireData>.GetTextValue(ref WireData data) {
				return string.Format(CultureInfo.InvariantCulture, "{0}", data.LogicalCircuitId);
			}
			void IFieldSerializer<WireData>.SetDefault(ref WireData data) {
				data.LogicalCircuitId = this.DefaultValue;
			}
			void IFieldSerializer<WireData>.SetTextValue(ref WireData data, string text) {
				data.LogicalCircuitId = new Guid(text);
			}
		}

		// Accessor of the X1 field
		public sealed class X1Field : IField<WireData, int>, IFieldSerializer<WireData> {
			public static readonly X1Field Field = new X1Field();
			private X1Field() {}
			public string Name { get { return "X1"; } }
			public int Order { get; set; }
			public int DefaultValue { get { return default(int); } }
			public int GetValue(ref WireData record) {
				return record.X1;
			}
			public void SetValue(ref WireData record, int value) {
				record.X1 = value;
			}
			public int Compare(ref WireData l, ref WireData r) {
				return Math.Sign((long)l.X1 - (long)r.X1);
			}
			public int Compare(int l, int r) {
				return Math.Sign((long)l - (long)r);
			}

			// Implementation of interface IFieldSerializer<WireData>
			bool IFieldSerializer<WireData>.NeedToSave(ref WireData data) {
				return this.Compare(data.X1, this.DefaultValue) != 0;
			}
			string IFieldSerializer<WireData>.GetTextValue(ref WireData data) {
				return string.Format(CultureInfo.InvariantCulture, "{0}", data.X1);
			}
			void IFieldSerializer<WireData>.SetDefault(ref WireData data) {
				data.X1 = this.DefaultValue;
			}
			void IFieldSerializer<WireData>.SetTextValue(ref WireData data, string text) {
				data.X1 = int.Parse(text, CultureInfo.InvariantCulture);
			}
		}

		// Accessor of the Y1 field
		public sealed class Y1Field : IField<WireData, int>, IFieldSerializer<WireData> {
			public static readonly Y1Field Field = new Y1Field();
			private Y1Field() {}
			public string Name { get { return "Y1"; } }
			public int Order { get; set; }
			public int DefaultValue { get { return default(int); } }
			public int GetValue(ref WireData record) {
				return record.Y1;
			}
			public void SetValue(ref WireData record, int value) {
				record.Y1 = value;
			}
			public int Compare(ref WireData l, ref WireData r) {
				return Math.Sign((long)l.Y1 - (long)r.Y1);
			}
			public int Compare(int l, int r) {
				return Math.Sign((long)l - (long)r);
			}

			// Implementation of interface IFieldSerializer<WireData>
			bool IFieldSerializer<WireData>.NeedToSave(ref WireData data) {
				return this.Compare(data.Y1, this.DefaultValue) != 0;
			}
			string IFieldSerializer<WireData>.GetTextValue(ref WireData data) {
				return string.Format(CultureInfo.InvariantCulture, "{0}", data.Y1);
			}
			void IFieldSerializer<WireData>.SetDefault(ref WireData data) {
				data.Y1 = this.DefaultValue;
			}
			void IFieldSerializer<WireData>.SetTextValue(ref WireData data, string text) {
				data.Y1 = int.Parse(text, CultureInfo.InvariantCulture);
			}
		}

		// Accessor of the X2 field
		public sealed class X2Field : IField<WireData, int>, IFieldSerializer<WireData> {
			public static readonly X2Field Field = new X2Field();
			private X2Field() {}
			public string Name { get { return "X2"; } }
			public int Order { get; set; }
			public int DefaultValue { get { return default(int); } }
			public int GetValue(ref WireData record) {
				return record.X2;
			}
			public void SetValue(ref WireData record, int value) {
				record.X2 = value;
			}
			public int Compare(ref WireData l, ref WireData r) {
				return Math.Sign((long)l.X2 - (long)r.X2);
			}
			public int Compare(int l, int r) {
				return Math.Sign((long)l - (long)r);
			}

			// Implementation of interface IFieldSerializer<WireData>
			bool IFieldSerializer<WireData>.NeedToSave(ref WireData data) {
				return this.Compare(data.X2, this.DefaultValue) != 0;
			}
			string IFieldSerializer<WireData>.GetTextValue(ref WireData data) {
				return string.Format(CultureInfo.InvariantCulture, "{0}", data.X2);
			}
			void IFieldSerializer<WireData>.SetDefault(ref WireData data) {
				data.X2 = this.DefaultValue;
			}
			void IFieldSerializer<WireData>.SetTextValue(ref WireData data, string text) {
				data.X2 = int.Parse(text, CultureInfo.InvariantCulture);
			}
		}

		// Accessor of the Y2 field
		public sealed class Y2Field : IField<WireData, int>, IFieldSerializer<WireData> {
			public static readonly Y2Field Field = new Y2Field();
			private Y2Field() {}
			public string Name { get { return "Y2"; } }
			public int Order { get; set; }
			public int DefaultValue { get { return default(int); } }
			public int GetValue(ref WireData record) {
				return record.Y2;
			}
			public void SetValue(ref WireData record, int value) {
				record.Y2 = value;
			}
			public int Compare(ref WireData l, ref WireData r) {
				return Math.Sign((long)l.Y2 - (long)r.Y2);
			}
			public int Compare(int l, int r) {
				return Math.Sign((long)l - (long)r);
			}

			// Implementation of interface IFieldSerializer<WireData>
			bool IFieldSerializer<WireData>.NeedToSave(ref WireData data) {
				return this.Compare(data.Y2, this.DefaultValue) != 0;
			}
			string IFieldSerializer<WireData>.GetTextValue(ref WireData data) {
				return string.Format(CultureInfo.InvariantCulture, "{0}", data.Y2);
			}
			void IFieldSerializer<WireData>.SetDefault(ref WireData data) {
				data.Y2 = this.DefaultValue;
			}
			void IFieldSerializer<WireData>.SetTextValue(ref WireData data, string text) {
				data.Y2 = int.Parse(text, CultureInfo.InvariantCulture);
			}
		}

		// Special field used to access items wrapper of this record from record.
		// This is used when no other universes is used
		internal sealed class WireField : IField<WireData, Wire> {
			public static readonly WireField Field = new WireField();
			private WireField() {}
			public string Name { get { return "WireWrapper"; } }
			public int Order { get; set; }
			public Wire DefaultValue { get { return null; } }
			public Wire GetValue(ref WireData record) {
				return record.Wire;
			}
			public void SetValue(ref WireData record, Wire value) {
				record.Wire = value;
			}
			public int Compare(ref WireData l, ref WireData r) {
				return this.Compare(l.Wire, r.Wire);
			}
			public int Compare(Wire l, Wire r) {
				if(object.ReferenceEquals(l, r)) return 0;
				if(l == null) return -1;
				if(r == null) return 1;
				return l.WireRowId.CompareTo(r.WireRowId);
			}
		}

		private static IField<WireData>[] fields = {
			WireIdField.Field,
			LogicalCircuitIdField.Field,
			X1Field.Field,
			Y1Field.Field,
			X2Field.Field,
			Y2Field.Field,
			WireField.Field
		};

		// Creates table.
		public static TableSnapshot<WireData> CreateTable(StoreSnapshot store) {
			TableSnapshot<WireData> table = new TableSnapshot<WireData>(store, "Wire", WireData.fields);
			// Create all but foreign keys of the table
			table.MakeUnique("PK_Wire", WireData.WireIdField.Field , true);
			table.CreateIndex("IX_LogicalCircuit_Wire", WireData.LogicalCircuitIdField.Field );
			// Return created table
			return table;
		}

		// Creates all foreign keys of the table
		public static void CreateForeignKeys(StoreSnapshot store) {
			TableSnapshot<WireData> table = (TableSnapshot<WireData>)store.Table("Wire");
			table.CreateForeignKey("FK_LogicalCircuit_Wire", store.Table("LogicalCircuit"), WireData.LogicalCircuitIdField.Field, ForeignKeyAction.Cascade, false);
		}
	}

	// Class wrapper for a record.
	partial class Wire : Symbol {

		// RowId of the wrapped record
		internal RowId WireRowId { get; private set; }
		// Store this wrapper belongs to
		public CircuitProject CircuitProject { get; private set; }

		// Constructor
		public Wire(CircuitProject store, RowId rowIdWire) {
			Debug.Assert(!rowIdWire.IsEmpty);
			this.CircuitProject = store;
			this.WireRowId = rowIdWire;
			// Link back to record. Assuming that a transaction is started
			this.Table.SetField(this.WireRowId, WireData.WireField.Field, this);
			this.InitializeWire();
		}

		partial void InitializeWire();

		// Gets table storing this item.
		private TableSnapshot<WireData> Table { get { return this.CircuitProject.WireSet.Table; } }

		// Deletes object
		public virtual void Delete() {
			this.Table.Delete(this.WireRowId);
		}

		// Checks if the item is deleted
		public bool IsDeleted() {
			return this.Table.IsDeleted(this.WireRowId);
		}

		//Properties of Wire

		// Gets value of the WireId field.
		public Guid WireId {
			get { return this.Table.GetField(this.WireRowId, WireData.WireIdField.Field); }
		}

		// Gets or sets the value referred by the foreign key on field LogicalCircuitId
		protected override LogicalCircuit SymbolLogicalCircuit {
			get { return this.CircuitProject.LogicalCircuitSet.FindByLogicalCircuitId(this.Table.GetField(this.WireRowId, WireData.LogicalCircuitIdField.Field)); }
			set { this.Table.SetField(this.WireRowId, WireData.LogicalCircuitIdField.Field, value.LogicalCircuitId); }
		}

		// Gets or sets value of the X1 field.
		public int X1 {
			get { return this.Table.GetField(this.WireRowId, WireData.X1Field.Field); }
			set { this.Table.SetField(this.WireRowId, WireData.X1Field.Field, value); }
		}

		// Gets or sets value of the Y1 field.
		public int Y1 {
			get { return this.Table.GetField(this.WireRowId, WireData.Y1Field.Field); }
			set { this.Table.SetField(this.WireRowId, WireData.Y1Field.Field, value); }
		}

		// Gets or sets value of the X2 field.
		public int X2 {
			get { return this.Table.GetField(this.WireRowId, WireData.X2Field.Field); }
			set { this.Table.SetField(this.WireRowId, WireData.X2Field.Field, value); }
		}

		// Gets or sets value of the Y2 field.
		public int Y2 {
			get { return this.Table.GetField(this.WireRowId, WireData.Y2Field.Field); }
			set { this.Table.SetField(this.WireRowId, WireData.Y2Field.Field, value); }
		}


		internal void NotifyChanged(TableChange<WireData> change) {
			if(this.HasListener) {
				WireData oldData, newData;
				change.GetOldData(out oldData);
				change.GetNewData(out newData);
				if(WireData.WireIdField.Field.Compare(ref oldData, ref newData) != 0) {
					this.NotifyPropertyChanged("WireId");
				}
				if(WireData.LogicalCircuitIdField.Field.Compare(ref oldData, ref newData) != 0) {
					this.NotifyPropertyChanged("LogicalCircuit");
				}
				if(WireData.X1Field.Field.Compare(ref oldData, ref newData) != 0) {
					this.NotifyPropertyChanged("X1");
				}
				if(WireData.Y1Field.Field.Compare(ref oldData, ref newData) != 0) {
					this.NotifyPropertyChanged("Y1");
				}
				if(WireData.X2Field.Field.Compare(ref oldData, ref newData) != 0) {
					this.NotifyPropertyChanged("X2");
				}
				if(WireData.Y2Field.Field.Compare(ref oldData, ref newData) != 0) {
					this.NotifyPropertyChanged("Y2");
				}
			}
			this.OnWireChanged();
		}

		partial void OnWireChanged();
	}


	// Wrapper for table Wire.
	partial class WireSet : INotifyCollectionChanged, IEnumerable<Wire> {

		public event NotifyCollectionChangedEventHandler CollectionChanged;

		internal TableSnapshot<WireData> Table { get; private set; }

		// Gets StoreSnapshot this set belongs to.
		public CircuitProject CircuitProject { get { return (CircuitProject)this.Table.StoreSnapshot; } }

		// Constructor
		public WireSet(CircuitProject store) {
			ITableSnapshot table = store.Table("Wire");
			if(table != null) {
				Debug.Assert(store.IsFrozen, "The store should be frozen");
				this.Table = (TableSnapshot<WireData>)table;
			} else {
				Debug.Assert(!store.IsFrozen, "In order to create table, the store should not be frozen");
				this.Table = WireData.CreateTable(store);
			}
			this.InitializeWireSet();
		}

		partial void InitializeWireSet();

		//internal void Register() {
		//	foreach(RowId rowId in this.Table.Rows) {
		//		this.FindOrCreate(rowId);
		//	}
		//}


		// gets items wrapper by RowId
		public Wire Find(RowId rowId) {
			if(!rowId.IsEmpty) {
				return this.Table.GetField(rowId, WireData.WireField.Field);
			}
			return null;
		}


		// gets items wrapper by RowId
		private IEnumerable<Wire> Select(IEnumerable<RowId> rows) {
			foreach(RowId rowId in rows) {
				Wire item = this.Find(rowId);
				Debug.Assert(item != null, "What is the reason for the item not to be found?");
				yield return item;
			}
		}

		// Create wrapper for the row and register it in the dictionary
		private Wire Create(RowId rowId) {
			Wire item = new Wire(this.CircuitProject, rowId);
			return item;
		}

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling")]
		internal Wire FindOrCreate(RowId rowId) {
			Debug.Assert(!rowId.IsEmpty && !this.Table.IsDeleted(rowId), "Bad RowId");
			Wire item;
			if((item = this.Find(rowId)) != null) {
				Debug.Assert(!item.IsDeleted(), "Deleted item should not be present in the dictionary");
				return item;
			}

			return this.Create(rowId);
		}

		// Creates Wire wrapper
		private Wire CreateItem(
			// Fields of Wire table
			Guid WireId,
			LogicalCircuit LogicalCircuit,
			int X1,
			int Y1,
			int X2,
			int Y2
		) {
			WireData dataWire = new WireData() {
				WireId = WireId,
				LogicalCircuitId = (LogicalCircuit != null) ? LogicalCircuit.LogicalCircuitId : WireData.LogicalCircuitIdField.Field.DefaultValue,
				X1 = X1,
				Y1 = Y1,
				X2 = X2,
				Y2 = Y2,
			};
			return this.Create(this.Table.Insert(ref dataWire));
		}

		// Search helpers

		// Finds Wire by WireId
		public Wire Find(Guid wireId) {
			return this.Find(this.Table.Find(WireData.WireIdField.Field, wireId));
		}

		// Selects Wire by LogicalCircuit
		public IEnumerable<Wire> SelectByLogicalCircuit(LogicalCircuit logicalCircuit) {
			return this.Select(this.Table.Select(WireData.LogicalCircuitIdField.Field, logicalCircuit.LogicalCircuitId));
		}

		public IEnumerator<Wire> GetEnumerator() {
			return this.Select(this.Table.Rows).GetEnumerator();
		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
			return this.GetEnumerator();
		}

		private void NotifyCollectionChanged(NotifyCollectionChangedEventArgs arg) {
			NotifyCollectionChangedEventHandler handler = this.CollectionChanged;
			if(handler != null) {
				handler(this, arg);
			}
		}

		internal List<Wire> UpdateSet(int oldVersion, int newVersion) {
			IEnumerator<TableChange<WireData>> change = this.Table.GetVersionChangeChanges(oldVersion, newVersion);
			if(change != null) {
				bool handlerAttached = (this.CollectionChanged != null);
				List<Wire> del = (handlerAttached) ? new List<Wire>() : null;
				while(change.MoveNext()) {
					switch(change.Current.Action) {
					case SnapTableAction.Insert:
						this.FindOrCreate(change.Current.RowId);
						Debug.Assert(this.Find(change.Current.RowId) != null, "Why the item was not created?");
						break;
					case SnapTableAction.Delete:
						if(handlerAttached) {
							Wire item = change.Current.GetOldField(WireData.WireField.Field);
							Debug.Assert(item.IsDeleted());
							del.Add(item);
						}
						break;
					default:
						Debug.Assert(change.Current.Action == SnapTableAction.Update, "Unknown action");
						Debug.Assert(this.Find(change.Current.RowId) != null, "Why the item does not exist during update?");
						break;
					}
				}
				change.Dispose();
				return del;
			}
			return null;
		}

		internal void NotifyVersionChanged(int oldVersion, int newVersion, List<Wire> deleted) {
			IEnumerator<TableChange<WireData>> change = this.Table.GetVersionChangeChanges(oldVersion, newVersion);
			if(change != null) {
				bool handlerAttached = (this.CollectionChanged != null);
				List<Wire> add = (handlerAttached) ? new List<Wire>() : null;
				this.StartNotifyWireSetChanged(oldVersion, newVersion);
				while(change.MoveNext()) {
					this.NotifyWireSetChanged(change.Current);
					switch(change.Current.Action) {
					case SnapTableAction.Insert:
						Debug.Assert(this.Find(change.Current.RowId) != null, "Why the item was not created?");
						if(handlerAttached) {
							add.Add(this.Find(change.Current.RowId));
						}
						break;
					case SnapTableAction.Delete:
						Debug.Assert(change.Current.GetOldField(WireData.WireField.Field).IsDeleted(), "Why the item still exists?");
						break;
					default:
						Debug.Assert(change.Current.Action == SnapTableAction.Update, "Unknown action");
						Debug.Assert(this.Find(change.Current.RowId) != null, "Why the item does not exist during update?");
						this.Find(change.Current.RowId).NotifyChanged(change.Current);
						break;
					}
				}
				change.Dispose();
				if(handlerAttached) {
					if(deleted != null && 0 < deleted.Count) {
						this.NotifyCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, deleted));
					}
					if(0 < add.Count) {
						this.NotifyCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, add));
					}
				}
				this.EndNotifyWireSetChanged();
			}
		}

		partial void StartNotifyWireSetChanged(int oldVersion, int newVersion);
		partial void EndNotifyWireSetChanged();
		partial void NotifyWireSetChanged(TableChange<WireData> change);

		internal void NotifyRolledBack(int version) {
			if(this.Table.WasAffected(version)) {
				IEnumerator<RowId> change = this.Table.GetRolledBackChanges(version);
				if(change != null) {
					while(change.MoveNext()) {
						RowId rowId = change.Current;
						if(this.Table.IsDeleted(rowId)) {
						} else {
							this.FindOrCreate(rowId);
						}
					}
					change.Dispose();
				}
			}
		}
	}

}
