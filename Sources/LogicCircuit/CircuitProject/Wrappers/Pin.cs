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

	// Defines the shape of the table Pin
	internal partial struct PinData {
		public Guid PinId;
		public Guid CircuitId;
		private int fieldBitWidth;
		public int BitWidth {
			get { return this.fieldBitWidth; }
			set { this.fieldBitWidth = BasePin.CheckBitWidth(value); }
		}
		public PinType PinType;
		public PinSide PinSide;
		public bool Inverted;
		public string Name;
		public string Note;
		public string Notation;
		internal Pin Pin;

		private interface IFieldSerializer {
			bool NeedToSave(ref PinData data);
			string GetTextValue(ref PinData data);
			void SetDefault(ref PinData data);
			void SetTextValue(ref PinData data, string text);
		}

		// Field accessors

		// Accessor of the PinId field
		public sealed class PinIdField : IField<PinData, Guid>, IFieldSerializer {
			public static readonly PinIdField Field = new PinIdField();
			private PinIdField() {}
			public string Name { get { return "PinId"; } }
			public int Order { get; set; }
			public Guid DefaultValue { get { return default(Guid); } }
			public Guid GetValue(ref PinData record) {
				return record.PinId;
			}
			public void SetValue(ref PinData record, Guid value) {
				record.PinId = value;
			}
			public int Compare(ref PinData l, ref PinData r) {
				return l.PinId.CompareTo(r.PinId);
			}
			public int Compare(Guid l, Guid r) {
				return l.CompareTo(r);
			}

			// Implementation of interface IFieldSerializer
			bool IFieldSerializer.NeedToSave(ref PinData data) {
				return this.Compare(data.PinId, this.DefaultValue) != 0;
			}
			string IFieldSerializer.GetTextValue(ref PinData data) {
				return string.Format(CultureInfo.InvariantCulture, "{0}", data.PinId);
			}
			void IFieldSerializer.SetDefault(ref PinData data) {
				data.PinId = this.DefaultValue;
			}
			void IFieldSerializer.SetTextValue(ref PinData data, string text) {
				data.PinId = new Guid(text);
			}
		}

		// Accessor of the CircuitId field
		public sealed class CircuitIdField : IField<PinData, Guid>, IFieldSerializer {
			public static readonly CircuitIdField Field = new CircuitIdField();
			private CircuitIdField() {}
			public string Name { get { return "CircuitId"; } }
			public int Order { get; set; }
			public Guid DefaultValue { get { return default(Guid); } }
			public Guid GetValue(ref PinData record) {
				return record.CircuitId;
			}
			public void SetValue(ref PinData record, Guid value) {
				record.CircuitId = value;
			}
			public int Compare(ref PinData l, ref PinData r) {
				return l.CircuitId.CompareTo(r.CircuitId);
			}
			public int Compare(Guid l, Guid r) {
				return l.CompareTo(r);
			}

			// Implementation of interface IFieldSerializer
			bool IFieldSerializer.NeedToSave(ref PinData data) {
				return this.Compare(data.CircuitId, this.DefaultValue) != 0;
			}
			string IFieldSerializer.GetTextValue(ref PinData data) {
				return string.Format(CultureInfo.InvariantCulture, "{0}", data.CircuitId);
			}
			void IFieldSerializer.SetDefault(ref PinData data) {
				data.CircuitId = this.DefaultValue;
			}
			void IFieldSerializer.SetTextValue(ref PinData data, string text) {
				data.CircuitId = new Guid(text);
			}
		}

		// Accessor of the BitWidth field
		public sealed class BitWidthField : IField<PinData, int>, IFieldSerializer {
			public static readonly BitWidthField Field = new BitWidthField();
			private BitWidthField() {}
			public string Name { get { return "BitWidth"; } }
			public int Order { get; set; }
			public int DefaultValue { get { return 1; } }
			public int GetValue(ref PinData record) {
				return record.BitWidth;
			}
			public void SetValue(ref PinData record, int value) {
				record.BitWidth = value;
			}
			public int Compare(ref PinData l, ref PinData r) {
				return Math.Sign((long)l.BitWidth - (long)r.BitWidth);
			}
			public int Compare(int l, int r) {
				return Math.Sign((long)l - (long)r);
			}

			// Implementation of interface IFieldSerializer
			bool IFieldSerializer.NeedToSave(ref PinData data) {
				return this.Compare(data.BitWidth, this.DefaultValue) != 0;
			}
			string IFieldSerializer.GetTextValue(ref PinData data) {
				return string.Format(CultureInfo.InvariantCulture, "{0}", data.BitWidth);
			}
			void IFieldSerializer.SetDefault(ref PinData data) {
				data.BitWidth = this.DefaultValue;
			}
			void IFieldSerializer.SetTextValue(ref PinData data, string text) {
				data.BitWidth = int.Parse(text);
			}
		}

		// Accessor of the PinType field
		public sealed class PinTypeField : IField<PinData, PinType>, IFieldSerializer {
			public static readonly PinTypeField Field = new PinTypeField();
			private PinTypeField() {}
			public string Name { get { return "PinType"; } }
			public int Order { get; set; }
			public PinType DefaultValue { get { return PinType.Input; } }
			public PinType GetValue(ref PinData record) {
				return record.PinType;
			}
			public void SetValue(ref PinData record, PinType value) {
				record.PinType = value;
			}
			public int Compare(ref PinData l, ref PinData r) {
				return l.PinType.CompareTo(r.PinType);
			}
			public int Compare(PinType l, PinType r) {
				return l.CompareTo(r);
			}

			// Implementation of interface IFieldSerializer
			bool IFieldSerializer.NeedToSave(ref PinData data) {
				return this.Compare(data.PinType, this.DefaultValue) != 0;
			}
			string IFieldSerializer.GetTextValue(ref PinData data) {
				return string.Format(CultureInfo.InvariantCulture, "{0}", data.PinType);
			}
			void IFieldSerializer.SetDefault(ref PinData data) {
				data.PinType = this.DefaultValue;
			}
			void IFieldSerializer.SetTextValue(ref PinData data, string text) {
				data.PinType = (PinType)Enum.Parse(typeof(PinType), text);
			}
		}

		// Accessor of the PinSide field
		public sealed class PinSideField : IField<PinData, PinSide>, IFieldSerializer {
			public static readonly PinSideField Field = new PinSideField();
			private PinSideField() {}
			public string Name { get { return "PinSide"; } }
			public int Order { get; set; }
			public PinSide DefaultValue { get { return PinSide.Left; } }
			public PinSide GetValue(ref PinData record) {
				return record.PinSide;
			}
			public void SetValue(ref PinData record, PinSide value) {
				record.PinSide = value;
			}
			public int Compare(ref PinData l, ref PinData r) {
				return l.PinSide.CompareTo(r.PinSide);
			}
			public int Compare(PinSide l, PinSide r) {
				return l.CompareTo(r);
			}

			// Implementation of interface IFieldSerializer
			bool IFieldSerializer.NeedToSave(ref PinData data) {
				return this.Compare(data.PinSide, this.DefaultValue) != 0;
			}
			string IFieldSerializer.GetTextValue(ref PinData data) {
				return string.Format(CultureInfo.InvariantCulture, "{0}", data.PinSide);
			}
			void IFieldSerializer.SetDefault(ref PinData data) {
				data.PinSide = this.DefaultValue;
			}
			void IFieldSerializer.SetTextValue(ref PinData data, string text) {
				data.PinSide = (PinSide)Enum.Parse(typeof(PinSide), text);
			}
		}

		// Accessor of the Inverted field
		public sealed class InvertedField : IField<PinData, bool>, IFieldSerializer {
			public static readonly InvertedField Field = new InvertedField();
			private InvertedField() {}
			public string Name { get { return "Inverted"; } }
			public int Order { get; set; }
			public bool DefaultValue { get { return false; } }
			public bool GetValue(ref PinData record) {
				return record.Inverted;
			}
			public void SetValue(ref PinData record, bool value) {
				record.Inverted = value;
			}
			public int Compare(ref PinData l, ref PinData r) {
				return l.Inverted.CompareTo(r.Inverted);
			}
			public int Compare(bool l, bool r) {
				return l.CompareTo(r);
			}

			// Implementation of interface IFieldSerializer
			bool IFieldSerializer.NeedToSave(ref PinData data) {
				return this.Compare(data.Inverted, this.DefaultValue) != 0;
			}
			string IFieldSerializer.GetTextValue(ref PinData data) {
				return string.Format(CultureInfo.InvariantCulture, "{0}", data.Inverted);
			}
			void IFieldSerializer.SetDefault(ref PinData data) {
				data.Inverted = this.DefaultValue;
			}
			void IFieldSerializer.SetTextValue(ref PinData data, string text) {
				data.Inverted = bool.Parse(text);
			}
		}

		// Accessor of the Name field
		public sealed class NameField : IField<PinData, string>, IFieldSerializer {
			public static readonly NameField Field = new NameField();
			private NameField() {}
			public string Name { get { return "Name"; } }
			public int Order { get; set; }
			public string DefaultValue { get { return null; } }
			public string GetValue(ref PinData record) {
				return record.Name;
			}
			public void SetValue(ref PinData record, string value) {
				record.Name = value;
			}
			public int Compare(ref PinData l, ref PinData r) {
				return StringComparer.Ordinal.Compare(l.Name, r.Name);
			}
			public int Compare(string l, string r) {
				return StringComparer.Ordinal.Compare(l, r);
			}

			// Implementation of interface IFieldSerializer
			bool IFieldSerializer.NeedToSave(ref PinData data) {
				return this.Compare(data.Name, this.DefaultValue) != 0;
			}
			string IFieldSerializer.GetTextValue(ref PinData data) {
				return string.Format(CultureInfo.InvariantCulture, "{0}", data.Name);
			}
			void IFieldSerializer.SetDefault(ref PinData data) {
				data.Name = this.DefaultValue;
			}
			void IFieldSerializer.SetTextValue(ref PinData data, string text) {
				data.Name = text;
			}
		}

		// Accessor of the Note field
		public sealed class NoteField : IField<PinData, string>, IFieldSerializer {
			public static readonly NoteField Field = new NoteField();
			private NoteField() {}
			public string Name { get { return "Note"; } }
			public int Order { get; set; }
			public string DefaultValue { get { return ""; } }
			public string GetValue(ref PinData record) {
				return record.Note;
			}
			public void SetValue(ref PinData record, string value) {
				record.Note = value;
			}
			public int Compare(ref PinData l, ref PinData r) {
				return StringComparer.Ordinal.Compare(l.Note, r.Note);
			}
			public int Compare(string l, string r) {
				return StringComparer.Ordinal.Compare(l, r);
			}

			// Implementation of interface IFieldSerializer
			bool IFieldSerializer.NeedToSave(ref PinData data) {
				return this.Compare(data.Note, this.DefaultValue) != 0;
			}
			string IFieldSerializer.GetTextValue(ref PinData data) {
				return string.Format(CultureInfo.InvariantCulture, "{0}", data.Note);
			}
			void IFieldSerializer.SetDefault(ref PinData data) {
				data.Note = this.DefaultValue;
			}
			void IFieldSerializer.SetTextValue(ref PinData data, string text) {
				data.Note = text;
			}
		}

		// Accessor of the Notation field
		public sealed class NotationField : IField<PinData, string>, IFieldSerializer {
			public static readonly NotationField Field = new NotationField();
			private NotationField() {}
			public string Name { get { return "Notation"; } }
			public int Order { get; set; }
			public string DefaultValue { get { return ""; } }
			public string GetValue(ref PinData record) {
				return record.Notation;
			}
			public void SetValue(ref PinData record, string value) {
				record.Notation = value;
			}
			public int Compare(ref PinData l, ref PinData r) {
				return StringComparer.Ordinal.Compare(l.Notation, r.Notation);
			}
			public int Compare(string l, string r) {
				return StringComparer.Ordinal.Compare(l, r);
			}

			// Implementation of interface IFieldSerializer
			bool IFieldSerializer.NeedToSave(ref PinData data) {
				return this.Compare(data.Notation, this.DefaultValue) != 0;
			}
			string IFieldSerializer.GetTextValue(ref PinData data) {
				return string.Format(CultureInfo.InvariantCulture, "{0}", data.Notation);
			}
			void IFieldSerializer.SetDefault(ref PinData data) {
				data.Notation = this.DefaultValue;
			}
			void IFieldSerializer.SetTextValue(ref PinData data, string text) {
				data.Notation = text;
			}
		}

		// Special field used to access items wrapper of this record from record.
		// This is used when no other universes is used
		internal sealed class PinField : IField<PinData, Pin> {
			public static readonly PinField Field = new PinField();
			private PinField() {}
			public string Name { get { return "PinWrapper"; } }
			public int Order { get; set; }
			public Pin DefaultValue { get { return null; } }
			public Pin GetValue(ref PinData record) {
				return record.Pin;
			}
			public void SetValue(ref PinData record, Pin value) {
				record.Pin = value;
			}
			public int Compare(ref PinData l, ref PinData r) {
				return this.Compare(l.Pin, r.Pin);
			}
			public int Compare(Pin l, Pin r) {
				if(object.ReferenceEquals(l, r)) return 0;
				if(l == null) return -1;
				if(r == null) return 1;
				return l.PinRowId.CompareTo(r.PinRowId);
			}
		}

		// Creates table.
		public static TableSnapshot<PinData> CreateTable(StoreSnapshot store) {
			TableSnapshot<PinData> table = new TableSnapshot<PinData>(store, "Pin"
				,PinIdField.Field
				,CircuitIdField.Field
				,BitWidthField.Field
				,PinTypeField.Field
				,PinSideField.Field
				,InvertedField.Field
				,NameField.Field
				,NoteField.Field
				,NotationField.Field
				,PinField.Field
			);
			// Create all but foreign keys of the table
			table.MakeUnique("PK_Pin", PinData.PinIdField.Field , true);
			table.MakeUnique("AK_Pin_Name", PinData.CircuitIdField.Field, PinData.NameField.Field);
			// Return created table
			return table;
		}

		// Creates all foreign keys of the table
		public static void CreateForeignKeys(StoreSnapshot store) {
			TableSnapshot<PinData> table = (TableSnapshot<PinData>)store.Table("Pin");
			table.CreateForeignKey("PK_Pin", store.Table("Circuit"), PinData.PinIdField.Field, ForeignKeyAction.Cascade, false);
			table.CreateForeignKey("FK_Circuit_Pin", store.Table("Circuit"), PinData.CircuitIdField.Field, ForeignKeyAction.Cascade, false);
		}

		// Serializer of the table
		public static void Save(TableSnapshot<PinData> table, XmlElement root) {
			XmlDocument xml = root.OwnerDocument;
			foreach(RowId rowId in table.Rows) {
				PinData data;
				table.GetData(rowId, out data);
				XmlElement node = xml.CreateElement(root.Prefix, table.Name, root.NamespaceURI);
				root.AppendChild(node);
				foreach(IField<PinData> field in table.Fields) {
					IFieldSerializer serializer = field as IFieldSerializer;
					if(serializer != null && serializer.NeedToSave(ref data)) {
						XmlElement e = xml.CreateElement(root.Prefix, field.Name, root.NamespaceURI);
						node.AppendChild(e);
						e.AppendChild(xml.CreateTextNode(serializer.GetTextValue(ref data)));
					}
				}
			}
		}

		public static void Load(TableSnapshot<PinData> table, XmlNodeList list, Action<RowId> register) {
			Dictionary<string, IFieldSerializer> field = new Dictionary<string, IFieldSerializer>();
			foreach(IField<PinData> f in table.Fields) {
				IFieldSerializer serializer = f as IFieldSerializer;
				if(serializer != null) {
					field.Add(f.Name, serializer);
				}
			}
			foreach(XmlElement node in list) {
				Debug.Assert(node.LocalName == table.Name);
				PinData data = new PinData();
				foreach(IFieldSerializer serializer in field.Values) {
					serializer.SetDefault(ref data);
				}
				foreach(XmlNode child in node.ChildNodes) {
					XmlElement c = child as XmlElement;
					IFieldSerializer serializer;
					if(c != null && c.NamespaceURI == node.NamespaceURI && field.TryGetValue(c.LocalName, out serializer)) {
						serializer.SetTextValue(ref data, c.InnerText);
					}
				}
				RowId rowId = table.Insert(ref data);
				if(register != null) {
					register(rowId);
				}
			}
		}
	}


	// Class wrapper for a record.
	partial class Pin : BasePin {

		// RowId of the wrapped record
		internal RowId PinRowId { get; private set; }

		// Constructor
		public Pin(CircuitProject store, RowId PinRowId, RowId CircuitRowId) : base(store, CircuitRowId) {
			Debug.Assert(!PinRowId.IsEmpty);
			this.PinRowId = PinRowId;
			// Link back to record. Assuming that a transaction is started
			this.Table.SetField(this.PinRowId, PinData.PinField.Field, this);
			this.InitializePin();
		}

		partial void InitializePin();

		// Gets table storing this item.
		private TableSnapshot<PinData> Table { get { return this.CircuitProject.PinSet.Table; } }


		//Properties of Pin

		// Gets value of the PinId field.
		public Guid PinId {
			get { return this.Table.GetField(this.PinRowId, PinData.PinIdField.Field); }
		}

		// Gets or sets the value reffered by the foreign key on field CircuitId
		public Circuit Circuit {
			get { return this.CircuitProject.CircuitSet.Find(this.Table.GetField(this.PinRowId, PinData.CircuitIdField.Field)); }
			set { this.Table.SetField(this.PinRowId, PinData.CircuitIdField.Field, value.CircuitId); }
		}

		// Gets or sets value of the BitWidth field.
		public override int BitWidth {
			get { return this.Table.GetField(this.PinRowId, PinData.BitWidthField.Field); }
			set { this.Table.SetField(this.PinRowId, PinData.BitWidthField.Field, value); }
		}

		// Gets or sets value of the PinType field.
		public override PinType PinType {
			get { return this.Table.GetField(this.PinRowId, PinData.PinTypeField.Field); }
			set { this.Table.SetField(this.PinRowId, PinData.PinTypeField.Field, value); }
		}

		// Gets or sets value of the PinSide field.
		public override PinSide PinSide {
			get { return this.Table.GetField(this.PinRowId, PinData.PinSideField.Field); }
			set { this.Table.SetField(this.PinRowId, PinData.PinSideField.Field, value); }
		}

		// Gets or sets value of the Inverted field.
		public override bool Inverted {
			get { return this.Table.GetField(this.PinRowId, PinData.InvertedField.Field); }
			set { this.Table.SetField(this.PinRowId, PinData.InvertedField.Field, value); }
		}

		// Gets or sets value of the Name field.
		public override string Name {
			get { return this.Table.GetField(this.PinRowId, PinData.NameField.Field); }
			set { this.Table.SetField(this.PinRowId, PinData.NameField.Field, value); }
		}

		// Gets or sets value of the Note field.
		public override string Note {
			get { return this.Table.GetField(this.PinRowId, PinData.NoteField.Field); }
			set { this.Table.SetField(this.PinRowId, PinData.NoteField.Field, value); }
		}

		// Gets or sets value of the Notation field.
		public override string Notation {
			get { return this.Table.GetField(this.PinRowId, PinData.NotationField.Field); }
			set { this.Table.SetField(this.PinRowId, PinData.NotationField.Field, value); }
		}


		internal void NotifyChanged(TableChange<PinData> change) {
			if(this.HasListener) {
				PinData oldData, newData;
				change.GetOldData(out oldData);
				change.GetNewData(out newData);
				if(PinData.PinIdField.Field.Compare(ref oldData, ref newData) != 0) {
					this.NotifyPropertyChanged("PinId");
				}
				if(PinData.CircuitIdField.Field.Compare(ref oldData, ref newData) != 0) {
					this.NotifyPropertyChanged("Circuit");
				}
				if(PinData.BitWidthField.Field.Compare(ref oldData, ref newData) != 0) {
					this.NotifyPropertyChanged("BitWidth");
				}
				if(PinData.PinTypeField.Field.Compare(ref oldData, ref newData) != 0) {
					this.NotifyPropertyChanged("PinType");
				}
				if(PinData.PinSideField.Field.Compare(ref oldData, ref newData) != 0) {
					this.NotifyPropertyChanged("PinSide");
				}
				if(PinData.InvertedField.Field.Compare(ref oldData, ref newData) != 0) {
					this.NotifyPropertyChanged("Inverted");
				}
				if(PinData.NameField.Field.Compare(ref oldData, ref newData) != 0) {
					this.NotifyPropertyChanged("Name");
				}
				if(PinData.NoteField.Field.Compare(ref oldData, ref newData) != 0) {
					this.NotifyPropertyChanged("Note");
				}
				if(PinData.NotationField.Field.Compare(ref oldData, ref newData) != 0) {
					this.NotifyPropertyChanged("Notation");
				}
			}
			this.OnPinChanged();
		}

		partial void OnPinChanged();
	}


	// Wrapper for table Pin.
	partial class PinSet : INotifyCollectionChanged, IEnumerable<Pin> {

		public event NotifyCollectionChangedEventHandler CollectionChanged;

		internal TableSnapshot<PinData> Table { get; private set; }

		// Gets StoreSnapshot this set belongs to.
		public CircuitProject CircuitProject { get { return (CircuitProject)this.Table.StoreSnapshot; } }

		// Constructor
		public PinSet(CircuitProject store) {
			ITableSnapshot table = store.Table("Pin");
			if(table != null) {
				Debug.Assert(store.IsFrozen, "The store should be frozen");
				this.Table = (TableSnapshot<PinData>)table;
			} else {
				Debug.Assert(!store.IsFrozen, "In order to create table, the store should not be frozen");
				this.Table = PinData.CreateTable(store);
			}
			this.InitializePinSet();
		}

		partial void InitializePinSet();

		internal void Register() {
			foreach(RowId rowId in this.Table.Rows) {
				this.FindOrCreate(rowId);
			}
		}


		// gets items wrapper by RowId
		public Pin Find(RowId rowId) {
			if(!rowId.IsEmpty) {
				return this.Table.GetField(rowId, PinData.PinField.Field);
			}
			return null;
		}

		private void Delete(RowId rowId) {
		}

		// gets items wrapper by RowId
		private IEnumerable<Pin> Select(IEnumerable<RowId> rows) {
			foreach(RowId rowId in rows) {
				Pin item = this.Find(rowId);
				Debug.Assert(item != null, "What is the reason for the item not to be found?");
				yield return item;
			}
		}

		// Create wrapper for the row and register it in the dictionary
		private Pin Create(RowId rowId, RowId CircuitRowId) {
			Pin item = new Pin(this.CircuitProject, rowId, CircuitRowId);
			return item;
		}

		internal Pin FindOrCreate(RowId rowId) {
			Debug.Assert(!rowId.IsEmpty && !this.Table.IsDeleted(rowId), "Bad RowId");
			Pin item;
			if((item = this.Find(rowId)) != null) {
				Debug.Assert(!item.IsDeleted(), "Deleted item should not be present in the dictionary");
				return item;
			}
			Guid primaryKeyValue = this.Table.GetField(rowId, PinData.PinIdField.Field);


			TableSnapshot<CircuitData> tableCircuit = (TableSnapshot<CircuitData>)this.CircuitProject.Table("Circuit");
			return this.Create(rowId, tableCircuit.Find(CircuitData.CircuitIdField.Field, primaryKeyValue));
		}

		// Creates Pin wrapper
		private Pin CreateItem(
			// Fields of Pin table
			Guid PinId,
			Circuit Circuit,
			int BitWidth,
			PinType PinType,
			PinSide PinSide,
			bool Inverted,
			string Name,
			string Note,
			string Notation
			// Fields of Circuit table

		) {
			TableSnapshot<CircuitData> tableCircuit = (TableSnapshot<CircuitData>)this.CircuitProject.Table("Circuit");
			CircuitData dataCircuit = new CircuitData() {
				CircuitId = PinId
			};
			RowId rowIdCircuit = tableCircuit.Insert(ref dataCircuit);

			PinData dataPin = new PinData() {
				PinId = PinId,
				CircuitId = (Circuit != null) ? Circuit.CircuitId : PinData.CircuitIdField.Field.DefaultValue,
				BitWidth = BitWidth,
				PinType = PinType,
				PinSide = PinSide,
				Inverted = Inverted,
				Name = Name,
				Note = Note,
				Notation = Notation,
			};
			return this.Create(this.Table.Insert(ref dataPin), rowIdCircuit);
		}

		// Search helpers

		// Finds Pin by PinId
		public Pin FindByPinId(Guid PinId) {
			return this.Find(this.Table.Find(PinData.PinIdField.Field, PinId));
		}

		// Finds Pin by Circuit and Name
		public Pin FindByCircuitAndName(Circuit Circuit, string Name) {
			return this.Find(
				this.Table.Find(
					PinData.CircuitIdField.Field, PinData.NameField.Field,
					Circuit.CircuitId, Name
				)
			);
		}

		// Selects Pin by Circuit
		public IEnumerable<Pin> SelectByCircuit(Circuit Circuit) {
			return this.Select(this.Table.Select(PinData.CircuitIdField.Field, Circuit.CircuitId));
		}

		public IEnumerator<Pin> GetEnumerator() {
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

		internal List<Pin> UpdateSet(int oldVersion, int newVersion) {
			IEnumerator<TableChange<PinData>> change = this.Table.GetVersionChangeChanges(oldVersion, newVersion);
			if(change != null) {
				bool handlerAttached = (this.CollectionChanged != null);
				List<Pin> del = (handlerAttached) ? new List<Pin>() : null;
				while(change.MoveNext()) {
					switch(change.Current.Action) {
					case SnapTableAction.Insert:
						this.FindOrCreate(change.Current.RowId);
						Debug.Assert(this.Find(change.Current.RowId) != null, "Why the item was not created?");
						break;
					case SnapTableAction.Delete:
						if(handlerAttached) {
							Pin item = change.Current.GetOldField(PinData.PinField.Field);
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

		internal void NotifyVersionChanged(int oldVersion, int newVersion, List<Pin> deleted) {
			IEnumerator<TableChange<PinData>> change = this.Table.GetVersionChangeChanges(oldVersion, newVersion);
			if(change != null) {
				bool handlerAttached = (this.CollectionChanged != null);
				List<Pin> add = (handlerAttached) ? new List<Pin>() : null;
				this.StartNotifyPinSetChanged(oldVersion, newVersion);
				while(change.MoveNext()) {
					this.NotifyPinSetChanged(change.Current);
					switch(change.Current.Action) {
					case SnapTableAction.Insert:
						Debug.Assert(this.Find(change.Current.RowId) != null, "Why the item was not created?");
						if(handlerAttached) {
							add.Add(this.Find(change.Current.RowId));
						}
						break;
					case SnapTableAction.Delete:
						Debug.Assert(change.Current.GetOldField(PinData.PinField.Field).IsDeleted(), "Why the item still exists?");
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
				this.EndNotifyPinSetChanged();
			}
		}

		partial void StartNotifyPinSetChanged(int oldVersion, int newVersion);
		partial void EndNotifyPinSetChanged();
		partial void NotifyPinSetChanged(TableChange<PinData> change);

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

		private class Enumerator : IEnumerator<Pin> {
			private PinSet set;
			private IEnumerator<RowId> enumerator;
			public Enumerator(PinSet set, IEnumerator<RowId> enumerator) {
				this.set = set;
				this.enumerator = enumerator;
			}

			public bool MoveNext() {
				return this.enumerator.MoveNext();
			}

			public Pin Current { get { return this.set.Find(this.enumerator.Current); } }
			object System.Collections.IEnumerator.Current { get { return this.Current; } }

			public void Dispose() {
			}

			public void Reset() {
				throw new NotSupportedException();
			}
		}
	}

}
