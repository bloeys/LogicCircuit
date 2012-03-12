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
	using System.Xml;
	using LogicCircuit.DataPersistent;

	// Defines the shape of the table Splitter
	internal partial struct SplitterData {
		public Guid SplitterId;
		private int fieldBitWidth;
		public int BitWidth {
			get { return this.fieldBitWidth; }
			set { this.fieldBitWidth = BasePin.CheckBitWidth(value); }
		}
		private int fieldPinCount;
		public int PinCount {
			get { return this.fieldPinCount; }
			set { this.fieldPinCount = BasePin.CheckBitWidth(value); }
		}
		public bool Clockwise;
		internal Splitter Splitter;

		private interface IFieldSerializer {
			bool NeedToSave(ref SplitterData data);
			string GetTextValue(ref SplitterData data);
			void SetDefault(ref SplitterData data);
			void SetTextValue(ref SplitterData data, string text);
		}

		// Field accessors

		// Accessor of the SplitterId field
		public sealed class SplitterIdField : IField<SplitterData, Guid>, IFieldSerializer {
			public static readonly SplitterIdField Field = new SplitterIdField();
			private SplitterIdField() {}
			public string Name { get { return "SplitterId"; } }
			public int Order { get; set; }
			public Guid DefaultValue { get { return default(Guid); } }
			public Guid GetValue(ref SplitterData record) {
				return record.SplitterId;
			}
			public void SetValue(ref SplitterData record, Guid value) {
				record.SplitterId = value;
			}
			public int Compare(ref SplitterData l, ref SplitterData r) {
				return l.SplitterId.CompareTo(r.SplitterId);
			}
			public int Compare(Guid l, Guid r) {
				return l.CompareTo(r);
			}

			// Implementation of interface IFieldSerializer
			bool IFieldSerializer.NeedToSave(ref SplitterData data) {
				return this.Compare(data.SplitterId, this.DefaultValue) != 0;
			}
			string IFieldSerializer.GetTextValue(ref SplitterData data) {
				return string.Format(CultureInfo.InvariantCulture, "{0}", data.SplitterId);
			}
			void IFieldSerializer.SetDefault(ref SplitterData data) {
				data.SplitterId = this.DefaultValue;
			}
			void IFieldSerializer.SetTextValue(ref SplitterData data, string text) {
				data.SplitterId = new Guid(text);
			}
		}

		// Accessor of the BitWidth field
		public sealed class BitWidthField : IField<SplitterData, int>, IFieldSerializer {
			public static readonly BitWidthField Field = new BitWidthField();
			private BitWidthField() {}
			public string Name { get { return "BitWidth"; } }
			public int Order { get; set; }
			public int DefaultValue { get { return default(int); } }
			public int GetValue(ref SplitterData record) {
				return record.BitWidth;
			}
			public void SetValue(ref SplitterData record, int value) {
				record.BitWidth = value;
			}
			public int Compare(ref SplitterData l, ref SplitterData r) {
				return Math.Sign((long)l.BitWidth - (long)r.BitWidth);
			}
			public int Compare(int l, int r) {
				return Math.Sign((long)l - (long)r);
			}

			// Implementation of interface IFieldSerializer
			bool IFieldSerializer.NeedToSave(ref SplitterData data) {
				return this.Compare(data.BitWidth, this.DefaultValue) != 0;
			}
			string IFieldSerializer.GetTextValue(ref SplitterData data) {
				return string.Format(CultureInfo.InvariantCulture, "{0}", data.BitWidth);
			}
			void IFieldSerializer.SetDefault(ref SplitterData data) {
				data.BitWidth = this.DefaultValue;
			}
			void IFieldSerializer.SetTextValue(ref SplitterData data, string text) {
				data.BitWidth = int.Parse(text, CultureInfo.InvariantCulture);
			}
		}

		// Accessor of the PinCount field
		public sealed class PinCountField : IField<SplitterData, int>, IFieldSerializer {
			public static readonly PinCountField Field = new PinCountField();
			private PinCountField() {}
			public string Name { get { return "PinCount"; } }
			public int Order { get; set; }
			public int DefaultValue { get { return default(int); } }
			public int GetValue(ref SplitterData record) {
				return record.PinCount;
			}
			public void SetValue(ref SplitterData record, int value) {
				record.PinCount = value;
			}
			public int Compare(ref SplitterData l, ref SplitterData r) {
				return Math.Sign((long)l.PinCount - (long)r.PinCount);
			}
			public int Compare(int l, int r) {
				return Math.Sign((long)l - (long)r);
			}

			// Implementation of interface IFieldSerializer
			bool IFieldSerializer.NeedToSave(ref SplitterData data) {
				return this.Compare(data.PinCount, this.DefaultValue) != 0;
			}
			string IFieldSerializer.GetTextValue(ref SplitterData data) {
				return string.Format(CultureInfo.InvariantCulture, "{0}", data.PinCount);
			}
			void IFieldSerializer.SetDefault(ref SplitterData data) {
				data.PinCount = this.DefaultValue;
			}
			void IFieldSerializer.SetTextValue(ref SplitterData data, string text) {
				data.PinCount = int.Parse(text, CultureInfo.InvariantCulture);
			}
		}

		// Accessor of the Clockwise field
		public sealed class ClockwiseField : IField<SplitterData, bool>, IFieldSerializer {
			public static readonly ClockwiseField Field = new ClockwiseField();
			private ClockwiseField() {}
			public string Name { get { return "Clockwise"; } }
			public int Order { get; set; }
			public bool DefaultValue { get { return default(bool); } }
			public bool GetValue(ref SplitterData record) {
				return record.Clockwise;
			}
			public void SetValue(ref SplitterData record, bool value) {
				record.Clockwise = value;
			}
			public int Compare(ref SplitterData l, ref SplitterData r) {
				return l.Clockwise.CompareTo(r.Clockwise);
			}
			public int Compare(bool l, bool r) {
				return l.CompareTo(r);
			}

			// Implementation of interface IFieldSerializer
			bool IFieldSerializer.NeedToSave(ref SplitterData data) {
				return this.Compare(data.Clockwise, this.DefaultValue) != 0;
			}
			string IFieldSerializer.GetTextValue(ref SplitterData data) {
				return string.Format(CultureInfo.InvariantCulture, "{0}", data.Clockwise);
			}
			void IFieldSerializer.SetDefault(ref SplitterData data) {
				data.Clockwise = this.DefaultValue;
			}
			void IFieldSerializer.SetTextValue(ref SplitterData data, string text) {
				data.Clockwise = bool.Parse(text);
			}
		}

		// Special field used to access items wrapper of this record from record.
		// This is used when no other universes is used
		internal sealed class SplitterField : IField<SplitterData, Splitter> {
			public static readonly SplitterField Field = new SplitterField();
			private SplitterField() {}
			public string Name { get { return "SplitterWrapper"; } }
			public int Order { get; set; }
			public Splitter DefaultValue { get { return null; } }
			public Splitter GetValue(ref SplitterData record) {
				return record.Splitter;
			}
			public void SetValue(ref SplitterData record, Splitter value) {
				record.Splitter = value;
			}
			public int Compare(ref SplitterData l, ref SplitterData r) {
				return this.Compare(l.Splitter, r.Splitter);
			}
			public int Compare(Splitter l, Splitter r) {
				if(object.ReferenceEquals(l, r)) return 0;
				if(l == null) return -1;
				if(r == null) return 1;
				return l.SplitterRowId.CompareTo(r.SplitterRowId);
			}
		}

		private static IField<SplitterData>[] fields = {
			SplitterIdField.Field,
			BitWidthField.Field,
			PinCountField.Field,
			ClockwiseField.Field,
			SplitterField.Field
		};

		// Creates table.
		public static TableSnapshot<SplitterData> CreateTable(StoreSnapshot store) {
			TableSnapshot<SplitterData> table = new TableSnapshot<SplitterData>(store, "Splitter", SplitterData.fields);
			// Create all but foreign keys of the table
			table.MakeUnique("PK_Splitter", SplitterData.SplitterIdField.Field , true);
			// Return created table
			return table;
		}

		// Creates all foreign keys of the table
		public static void CreateForeignKeys(StoreSnapshot store) {
			TableSnapshot<SplitterData> table = (TableSnapshot<SplitterData>)store.Table("Splitter");
			table.CreateForeignKey("PK_Splitter", store.Table("Circuit"), SplitterData.SplitterIdField.Field, ForeignKeyAction.Cascade, false);
		}

		// Serializer of the table
		public static void Save(TableSnapshot<SplitterData> table, XmlElement root) {
			XmlDocument xml = root.OwnerDocument;
			foreach(RowId rowId in table.Rows) {
				SplitterData data;
				table.GetData(rowId, out data);
				XmlElement node = xml.CreateElement(root.Prefix, table.Name, root.NamespaceURI);
				root.AppendChild(node);
				foreach(IField<SplitterData> field in table.Fields) {
					IFieldSerializer serializer = field as IFieldSerializer;
					if(serializer != null && serializer.NeedToSave(ref data)) {
						XmlElement e = xml.CreateElement(root.Prefix, field.Name, root.NamespaceURI);
						node.AppendChild(e);
						e.AppendChild(xml.CreateTextNode(serializer.GetTextValue(ref data)));
					}
				}
			}
		}

		public static RowId Load(TableSnapshot<SplitterData> table, XmlReader reader) {
			Debug.Assert(reader.NodeType == XmlNodeType.Element);
			Debug.Assert(reader.LocalName == table.Name);
			Debug.Assert(!reader.IsEmptyElement);

			SplitterData data = new SplitterData();
			// Initialize 'data' with default values: 
			for (int i = 0; i < SplitterData.fields.Length; i ++) {
				IFieldSerializer serializer = SplitterData.fields[i] as IFieldSerializer;
				if (serializer != null) {
					serializer.SetDefault(ref data);
				}
			}

			reader.Read();
			int fieldDepth = reader.Depth;
			object ns = reader.NamespaceURI;

			// Read through all fields of this record
			int hintIndex = 0;
			while (reader.Depth == fieldDepth) {
				if (reader.NodeType == XmlNodeType.Element && (object) reader.NamespaceURI == ns) {
					// We are position on field element
					string fieldName  = reader.LocalName;
					string fieldValue = ReadElementText(reader);     // reads the text and moved the reader to pass this element
					IFieldSerializer serializer = SplitterData.FindField(fieldName, ref hintIndex);
					if (serializer != null) {
						serializer.SetTextValue(ref data, fieldValue);
					}
				}else {
					reader.Skip();     // skip everything else
				}
				Debug.Assert(reader.Depth == fieldDepth || reader.Depth == fieldDepth - 1, 
					"after reading the field we should be on fieldDepth or on fieldDepth - 1 if reach EndElement tag"
				);
			}
			// insert 'data' into the table
			return table.Insert(ref data);
		}

		private static string ReadElementText(XmlReader reader) {
			Debug.Assert(reader.NodeType == XmlNodeType.Element);
			string result;
			if (reader.IsEmptyElement) {
				result = string.Empty;
			} else {
				int fieldDepth = reader.Depth;
				reader.Read();                        // descend to the first child
				result = reader.ReadContentAsString();

				// Skip what ever we can meet here.
				while (fieldDepth < reader.Depth) {
					reader.Skip();
				}
				// Find ourselves on the EndElement tag.
				Debug.Assert(reader.Depth == fieldDepth);
				Debug.Assert(reader.NodeType == XmlNodeType.EndElement); 
			}
			
			// Skip EndElement or empty element.
			reader.Read();
			return result;
		}

		private static IFieldSerializer FindField(string name, ref int hint) {
			// We serialize/deserialize fields in the same order so result would always be at hint position or after it if hint is skipped during the serialization
			Debug.Assert(0 <= hint && hint <= SplitterData.fields.Length);
			for (int i = hint; i < SplitterData.fields.Length; i ++) {
				if (SplitterData.fields[i].Name == name) {
					hint = i + 1;
					return SplitterData.fields[i] as IFieldSerializer;
				}
			}

			// We don't find the field in expected place. Lets look the beginning of the list in case it is out of order
			for (int i = 0; i < hint; i ++) {
				if (SplitterData.fields[i].Name == name) {
					return SplitterData.fields[i] as IFieldSerializer;
				}
			}

			// Ups. Still don't find. 
			return null;
		}
	}


	// Class wrapper for a record.
	partial class Splitter : Circuit {

		// RowId of the wrapped record
		internal RowId SplitterRowId { get; private set; }

		// Constructor
		public Splitter(CircuitProject store, RowId rowIdSplitter, RowId rowIdCircuit) : base(store, rowIdCircuit) {
			Debug.Assert(!rowIdSplitter.IsEmpty);
			this.SplitterRowId = rowIdSplitter;
			// Link back to record. Assuming that a transaction is started
			this.Table.SetField(this.SplitterRowId, SplitterData.SplitterField.Field, this);
			this.InitializeSplitter();
		}

		partial void InitializeSplitter();

		// Gets table storing this item.
		private TableSnapshot<SplitterData> Table { get { return this.CircuitProject.SplitterSet.Table; } }


		//Properties of Splitter

		// Gets value of the SplitterId field.
		public Guid SplitterId {
			get { return this.Table.GetField(this.SplitterRowId, SplitterData.SplitterIdField.Field); }
		}

		// Gets or sets value of the BitWidth field.
		public int BitWidth {
			get { return this.Table.GetField(this.SplitterRowId, SplitterData.BitWidthField.Field); }
			set { this.Table.SetField(this.SplitterRowId, SplitterData.BitWidthField.Field, value); }
		}

		// Gets or sets value of the PinCount field.
		public int PinCount {
			get { return this.Table.GetField(this.SplitterRowId, SplitterData.PinCountField.Field); }
			set { this.Table.SetField(this.SplitterRowId, SplitterData.PinCountField.Field, value); }
		}

		// Gets or sets value of the Clockwise field.
		public bool Clockwise {
			get { return this.Table.GetField(this.SplitterRowId, SplitterData.ClockwiseField.Field); }
			set { this.Table.SetField(this.SplitterRowId, SplitterData.ClockwiseField.Field, value); }
		}


		internal void NotifyChanged(TableChange<SplitterData> change) {
			if(this.HasListener) {
				SplitterData oldData, newData;
				change.GetOldData(out oldData);
				change.GetNewData(out newData);
				if(SplitterData.SplitterIdField.Field.Compare(ref oldData, ref newData) != 0) {
					this.NotifyPropertyChanged("SplitterId");
				}
				if(SplitterData.BitWidthField.Field.Compare(ref oldData, ref newData) != 0) {
					this.NotifyPropertyChanged("BitWidth");
				}
				if(SplitterData.PinCountField.Field.Compare(ref oldData, ref newData) != 0) {
					this.NotifyPropertyChanged("PinCount");
				}
				if(SplitterData.ClockwiseField.Field.Compare(ref oldData, ref newData) != 0) {
					this.NotifyPropertyChanged("Clockwise");
				}
			}
			this.OnSplitterChanged();
		}

		partial void OnSplitterChanged();
	}


	// Wrapper for table Splitter.
	partial class SplitterSet : INotifyCollectionChanged, IEnumerable<Splitter> {

		public event NotifyCollectionChangedEventHandler CollectionChanged;

		internal TableSnapshot<SplitterData> Table { get; private set; }

		// Gets StoreSnapshot this set belongs to.
		public CircuitProject CircuitProject { get { return (CircuitProject)this.Table.StoreSnapshot; } }

		// Constructor
		public SplitterSet(CircuitProject store) {
			ITableSnapshot table = store.Table("Splitter");
			if(table != null) {
				Debug.Assert(store.IsFrozen, "The store should be frozen");
				this.Table = (TableSnapshot<SplitterData>)table;
			} else {
				Debug.Assert(!store.IsFrozen, "In order to create table, the store should not be frozen");
				this.Table = SplitterData.CreateTable(store);
			}
			this.InitializeSplitterSet();
		}

		partial void InitializeSplitterSet();

		//internal void Register() {
		//	foreach(RowId rowId in this.Table.Rows) {
		//		this.FindOrCreate(rowId);
		//	}
		//}


		// gets items wrapper by RowId
		public Splitter Find(RowId rowId) {
			if(!rowId.IsEmpty) {
				return this.Table.GetField(rowId, SplitterData.SplitterField.Field);
			}
			return null;
		}

		private void Delete(RowId rowId) {
		}

		// gets items wrapper by RowId
		private IEnumerable<Splitter> Select(IEnumerable<RowId> rows) {
			foreach(RowId rowId in rows) {
				Splitter item = this.Find(rowId);
				Debug.Assert(item != null, "What is the reason for the item not to be found?");
				yield return item;
			}
		}

		// Create wrapper for the row and register it in the dictionary
		private Splitter Create(RowId rowId, RowId CircuitRowId) {
			Splitter item = new Splitter(this.CircuitProject, rowId, CircuitRowId);
			return item;
		}

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling")]
		internal Splitter FindOrCreate(RowId rowId) {
			Debug.Assert(!rowId.IsEmpty && !this.Table.IsDeleted(rowId), "Bad RowId");
			Splitter item;
			if((item = this.Find(rowId)) != null) {
				Debug.Assert(!item.IsDeleted(), "Deleted item should not be present in the dictionary");
				return item;
			}
			Guid primaryKeyValue = this.Table.GetField(rowId, SplitterData.SplitterIdField.Field);


			TableSnapshot<CircuitData> tableCircuit = (TableSnapshot<CircuitData>)this.CircuitProject.Table("Circuit");
			return this.Create(rowId, tableCircuit.Find(CircuitData.CircuitIdField.Field, primaryKeyValue));
		}

		// Creates Splitter wrapper
		private Splitter CreateItem(
			// Fields of Splitter table
			Guid SplitterId,
			int BitWidth,
			int PinCount,
			bool Clockwise
			// Fields of Circuit table

		) {
			TableSnapshot<CircuitData> tableCircuit = (TableSnapshot<CircuitData>)this.CircuitProject.Table("Circuit");
			CircuitData dataCircuit = new CircuitData() {
				CircuitId = SplitterId
			};
			RowId rowIdCircuit = tableCircuit.Insert(ref dataCircuit);

			SplitterData dataSplitter = new SplitterData() {
				SplitterId = SplitterId,
				BitWidth = BitWidth,
				PinCount = PinCount,
				Clockwise = Clockwise,
			};
			return this.Create(this.Table.Insert(ref dataSplitter), rowIdCircuit);
		}

		// Search helpers

		// Finds Splitter by SplitterId
		public Splitter FindBySplitterId(Guid splitterId) {
			return this.Find(this.Table.Find(SplitterData.SplitterIdField.Field, splitterId));
		}

		public IEnumerator<Splitter> GetEnumerator() {
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

		internal List<Splitter> UpdateSet(int oldVersion, int newVersion) {
			IEnumerator<TableChange<SplitterData>> change = this.Table.GetVersionChangeChanges(oldVersion, newVersion);
			if(change != null) {
				bool handlerAttached = (this.CollectionChanged != null);
				List<Splitter> del = (handlerAttached) ? new List<Splitter>() : null;
				while(change.MoveNext()) {
					switch(change.Current.Action) {
					case SnapTableAction.Insert:
						this.FindOrCreate(change.Current.RowId);
						Debug.Assert(this.Find(change.Current.RowId) != null, "Why the item was not created?");
						break;
					case SnapTableAction.Delete:
						if(handlerAttached) {
							Splitter item = change.Current.GetOldField(SplitterData.SplitterField.Field);
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

		internal void NotifyVersionChanged(int oldVersion, int newVersion, List<Splitter> deleted) {
			IEnumerator<TableChange<SplitterData>> change = this.Table.GetVersionChangeChanges(oldVersion, newVersion);
			if(change != null) {
				bool handlerAttached = (this.CollectionChanged != null);
				List<Splitter> add = (handlerAttached) ? new List<Splitter>() : null;
				this.StartNotifySplitterSetChanged(oldVersion, newVersion);
				while(change.MoveNext()) {
					this.NotifySplitterSetChanged(change.Current);
					switch(change.Current.Action) {
					case SnapTableAction.Insert:
						Debug.Assert(this.Find(change.Current.RowId) != null, "Why the item was not created?");
						if(handlerAttached) {
							add.Add(this.Find(change.Current.RowId));
						}
						break;
					case SnapTableAction.Delete:
						Debug.Assert(change.Current.GetOldField(SplitterData.SplitterField.Field).IsDeleted(), "Why the item still exists?");
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
				this.EndNotifySplitterSetChanged();
			}
		}

		partial void StartNotifySplitterSetChanged(int oldVersion, int newVersion);
		partial void EndNotifySplitterSetChanged();
		partial void NotifySplitterSetChanged(TableChange<SplitterData> change);

		internal void NotifyRolledBack(int version) {
			if(this.Table.WasAffected(version)) {
				IEnumerator<RowId> change = this.Table.GetRolledBackChanges(version);
				if(change != null) {
					while(change.MoveNext()) {
						RowId rowId = change.Current;
						if(this.Table.IsDeleted(rowId)) {
							this.Delete(rowId);
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
