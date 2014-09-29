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

	// Defines the shape of the table Sensor
	internal partial struct SensorData {
		public Guid SensorId;
		public SensorType SensorType;
		private int fieldBitWidth;
		public int BitWidth {
			get { return this.fieldBitWidth; }
			set { this.fieldBitWidth = BasePin.CheckBitWidth(value); }
		}
		public PinSide PinSide;
		public string Notation;
		public string Data;
		public string Note;
		internal Sensor Sensor;
		// Field accessors
		// Accessor of the SensorId field
		public sealed class SensorIdField : IField<SensorData, Guid>, IFieldSerializer<SensorData> {
			public static readonly SensorIdField Field = new SensorIdField();
			private SensorIdField() {}
			public string Name { get { return "SensorId"; } }
			public int Order { get; set; }
			public Guid DefaultValue { get { return default(Guid); } }
			public Guid GetValue(ref SensorData record) {
				return record.SensorId;
			}
			public void SetValue(ref SensorData record, Guid value) {
				record.SensorId = value;
			}
			public int Compare(ref SensorData l, ref SensorData r) {
				return l.SensorId.CompareTo(r.SensorId);
			}
			public int Compare(Guid l, Guid r) {
				return l.CompareTo(r);
			}

			// Implementation of interface IFieldSerializer<SensorData>
			bool IFieldSerializer<SensorData>.NeedToSave(ref SensorData data) {
				return this.Compare(data.SensorId, this.DefaultValue) != 0;
			}
			string IFieldSerializer<SensorData>.GetTextValue(ref SensorData data) {
				return string.Format(CultureInfo.InvariantCulture, "{0}", data.SensorId);
			}
			void IFieldSerializer<SensorData>.SetDefault(ref SensorData data) {
				data.SensorId = this.DefaultValue;
			}
			void IFieldSerializer<SensorData>.SetTextValue(ref SensorData data, string text) {
				data.SensorId = new Guid(text);
			}
		}

		// Accessor of the SensorType field
		public sealed class SensorTypeField : IField<SensorData, SensorType>, IFieldSerializer<SensorData> {
			public static readonly SensorTypeField Field = new SensorTypeField();
			private SensorTypeField() {}
			public string Name { get { return "SensorType"; } }
			public int Order { get; set; }
			public SensorType DefaultValue { get { return SensorType.Random; } }
			public SensorType GetValue(ref SensorData record) {
				return record.SensorType;
			}
			public void SetValue(ref SensorData record, SensorType value) {
				record.SensorType = value;
			}
			public int Compare(ref SensorData l, ref SensorData r) {
				return l.SensorType.CompareTo(r.SensorType);
			}
			public int Compare(SensorType l, SensorType r) {
				return l.CompareTo(r);
			}

			// Implementation of interface IFieldSerializer<SensorData>
			bool IFieldSerializer<SensorData>.NeedToSave(ref SensorData data) {
				return this.Compare(data.SensorType, this.DefaultValue) != 0;
			}
			string IFieldSerializer<SensorData>.GetTextValue(ref SensorData data) {
				return string.Format(CultureInfo.InvariantCulture, "{0}", data.SensorType);
			}
			void IFieldSerializer<SensorData>.SetDefault(ref SensorData data) {
				data.SensorType = this.DefaultValue;
			}
			void IFieldSerializer<SensorData>.SetTextValue(ref SensorData data, string text) {
				data.SensorType = EnumHelper.Parse<SensorType>(text, this.DefaultValue);
			}
		}

		// Accessor of the BitWidth field
		public sealed class BitWidthField : IField<SensorData, int>, IFieldSerializer<SensorData> {
			public static readonly BitWidthField Field = new BitWidthField();
			private BitWidthField() {}
			public string Name { get { return "BitWidth"; } }
			public int Order { get; set; }
			public int DefaultValue { get { return 1; } }
			public int GetValue(ref SensorData record) {
				return record.BitWidth;
			}
			public void SetValue(ref SensorData record, int value) {
				record.BitWidth = value;
			}
			public int Compare(ref SensorData l, ref SensorData r) {
				return Math.Sign((long)l.BitWidth - (long)r.BitWidth);
			}
			public int Compare(int l, int r) {
				return Math.Sign((long)l - (long)r);
			}

			// Implementation of interface IFieldSerializer<SensorData>
			bool IFieldSerializer<SensorData>.NeedToSave(ref SensorData data) {
				return this.Compare(data.BitWidth, this.DefaultValue) != 0;
			}
			string IFieldSerializer<SensorData>.GetTextValue(ref SensorData data) {
				return string.Format(CultureInfo.InvariantCulture, "{0}", data.BitWidth);
			}
			void IFieldSerializer<SensorData>.SetDefault(ref SensorData data) {
				data.BitWidth = this.DefaultValue;
			}
			void IFieldSerializer<SensorData>.SetTextValue(ref SensorData data, string text) {
				data.BitWidth = int.Parse(text, CultureInfo.InvariantCulture);
			}
		}

		// Accessor of the PinSide field
		public sealed class PinSideField : IField<SensorData, PinSide>, IFieldSerializer<SensorData> {
			public static readonly PinSideField Field = new PinSideField();
			private PinSideField() {}
			public string Name { get { return "PinSide"; } }
			public int Order { get; set; }
			public PinSide DefaultValue { get { return PinSide.Right; } }
			public PinSide GetValue(ref SensorData record) {
				return record.PinSide;
			}
			public void SetValue(ref SensorData record, PinSide value) {
				record.PinSide = value;
			}
			public int Compare(ref SensorData l, ref SensorData r) {
				return l.PinSide.CompareTo(r.PinSide);
			}
			public int Compare(PinSide l, PinSide r) {
				return l.CompareTo(r);
			}

			// Implementation of interface IFieldSerializer<SensorData>
			bool IFieldSerializer<SensorData>.NeedToSave(ref SensorData data) {
				return this.Compare(data.PinSide, this.DefaultValue) != 0;
			}
			string IFieldSerializer<SensorData>.GetTextValue(ref SensorData data) {
				return string.Format(CultureInfo.InvariantCulture, "{0}", data.PinSide);
			}
			void IFieldSerializer<SensorData>.SetDefault(ref SensorData data) {
				data.PinSide = this.DefaultValue;
			}
			void IFieldSerializer<SensorData>.SetTextValue(ref SensorData data, string text) {
				data.PinSide = EnumHelper.Parse<PinSide>(text, this.DefaultValue);
			}
		}

		// Accessor of the Notation field
		public sealed class NotationField : IField<SensorData, string>, IFieldSerializer<SensorData> {
			public static readonly NotationField Field = new NotationField();
			private NotationField() {}
			public string Name { get { return "Notation"; } }
			public int Order { get; set; }
			public string DefaultValue { get { return ""; } }
			public string GetValue(ref SensorData record) {
				return record.Notation;
			}
			public void SetValue(ref SensorData record, string value) {
				record.Notation = value;
			}
			public int Compare(ref SensorData l, ref SensorData r) {
				return StringComparer.Ordinal.Compare(l.Notation, r.Notation);
			}
			public int Compare(string l, string r) {
				return StringComparer.Ordinal.Compare(l, r);
			}

			// Implementation of interface IFieldSerializer<SensorData>
			bool IFieldSerializer<SensorData>.NeedToSave(ref SensorData data) {
				return this.Compare(data.Notation, this.DefaultValue) != 0;
			}
			string IFieldSerializer<SensorData>.GetTextValue(ref SensorData data) {
				return string.Format(CultureInfo.InvariantCulture, "{0}", data.Notation);
			}
			void IFieldSerializer<SensorData>.SetDefault(ref SensorData data) {
				data.Notation = this.DefaultValue;
			}
			void IFieldSerializer<SensorData>.SetTextValue(ref SensorData data, string text) {
				data.Notation = text;
			}
		}

		// Accessor of the Data field
		public sealed class DataField : IField<SensorData, string>, IFieldSerializer<SensorData> {
			public static readonly DataField Field = new DataField();
			private DataField() {}
			public string Name { get { return "Data"; } }
			public int Order { get; set; }
			public string DefaultValue { get { return ""; } }
			public string GetValue(ref SensorData record) {
				return record.Data;
			}
			public void SetValue(ref SensorData record, string value) {
				record.Data = value;
			}
			public int Compare(ref SensorData l, ref SensorData r) {
				return StringComparer.Ordinal.Compare(l.Data, r.Data);
			}
			public int Compare(string l, string r) {
				return StringComparer.Ordinal.Compare(l, r);
			}

			// Implementation of interface IFieldSerializer<SensorData>
			bool IFieldSerializer<SensorData>.NeedToSave(ref SensorData data) {
				return this.Compare(data.Data, this.DefaultValue) != 0;
			}
			string IFieldSerializer<SensorData>.GetTextValue(ref SensorData data) {
				return string.Format(CultureInfo.InvariantCulture, "{0}", data.Data);
			}
			void IFieldSerializer<SensorData>.SetDefault(ref SensorData data) {
				data.Data = this.DefaultValue;
			}
			void IFieldSerializer<SensorData>.SetTextValue(ref SensorData data, string text) {
				data.Data = text;
			}
		}

		// Accessor of the Note field
		public sealed class NoteField : IField<SensorData, string>, IFieldSerializer<SensorData> {
			public static readonly NoteField Field = new NoteField();
			private NoteField() {}
			public string Name { get { return "Note"; } }
			public int Order { get; set; }
			public string DefaultValue { get { return ""; } }
			public string GetValue(ref SensorData record) {
				return record.Note;
			}
			public void SetValue(ref SensorData record, string value) {
				record.Note = value;
			}
			public int Compare(ref SensorData l, ref SensorData r) {
				return StringComparer.Ordinal.Compare(l.Note, r.Note);
			}
			public int Compare(string l, string r) {
				return StringComparer.Ordinal.Compare(l, r);
			}

			// Implementation of interface IFieldSerializer<SensorData>
			bool IFieldSerializer<SensorData>.NeedToSave(ref SensorData data) {
				return this.Compare(data.Note, this.DefaultValue) != 0;
			}
			string IFieldSerializer<SensorData>.GetTextValue(ref SensorData data) {
				return string.Format(CultureInfo.InvariantCulture, "{0}", data.Note);
			}
			void IFieldSerializer<SensorData>.SetDefault(ref SensorData data) {
				data.Note = this.DefaultValue;
			}
			void IFieldSerializer<SensorData>.SetTextValue(ref SensorData data, string text) {
				data.Note = text;
			}
		}

		// Special field used to access items wrapper of this record from record.
		// This is used when no other universes is used
		internal sealed class SensorField : IField<SensorData, Sensor> {
			public static readonly SensorField Field = new SensorField();
			private SensorField() {}
			public string Name { get { return "SensorWrapper"; } }
			public int Order { get; set; }
			public Sensor DefaultValue { get { return null; } }
			public Sensor GetValue(ref SensorData record) {
				return record.Sensor;
			}
			public void SetValue(ref SensorData record, Sensor value) {
				record.Sensor = value;
			}
			public int Compare(ref SensorData l, ref SensorData r) {
				return this.Compare(l.Sensor, r.Sensor);
			}
			public int Compare(Sensor l, Sensor r) {
				if(object.ReferenceEquals(l, r)) return 0;
				if(l == null) return -1;
				if(r == null) return 1;
				return l.SensorRowId.CompareTo(r.SensorRowId);
			}
		}

		private static IField<SensorData>[] fields = {
			SensorIdField.Field,
			SensorTypeField.Field,
			BitWidthField.Field,
			PinSideField.Field,
			NotationField.Field,
			DataField.Field,
			NoteField.Field,
			SensorField.Field
		};

		// Creates table.
		public static TableSnapshot<SensorData> CreateTable(StoreSnapshot store) {
			TableSnapshot<SensorData> table = new TableSnapshot<SensorData>(store, "Sensor", SensorData.fields);
			// Create all but foreign keys of the table
			table.MakeUnique("PK_Sensor", SensorData.SensorIdField.Field , true);
			// Return created table
			return table;
		}

		// Creates all foreign keys of the table
		public static void CreateForeignKeys(StoreSnapshot store) {
			TableSnapshot<SensorData> table = (TableSnapshot<SensorData>)store.Table("Sensor");
			table.CreateForeignKey("PK_Sensor", store.Table("Circuit"), SensorData.SensorIdField.Field, ForeignKeyAction.Cascade, false);
		}
	}

	// Class wrapper for a record.
	partial class Sensor : Circuit {

		// RowId of the wrapped record
		internal RowId SensorRowId { get; private set; }

		// Constructor
		public Sensor(CircuitProject store, RowId rowIdSensor, RowId rowIdCircuit) : base(store, rowIdCircuit) {
			Debug.Assert(!rowIdSensor.IsEmpty);
			this.SensorRowId = rowIdSensor;
			// Link back to record. Assuming that a transaction is started
			this.Table.SetField(this.SensorRowId, SensorData.SensorField.Field, this);
			this.InitializeSensor();
		}

		partial void InitializeSensor();

		// Gets table storing this item.
		private TableSnapshot<SensorData> Table { get { return this.CircuitProject.SensorSet.Table; } }


		//Properties of Sensor

		// Gets value of the SensorId field.
		public Guid SensorId {
			get { return this.Table.GetField(this.SensorRowId, SensorData.SensorIdField.Field); }
		}

		// Gets or sets value of the SensorType field.
		public SensorType SensorType {
			get { return this.Table.GetField(this.SensorRowId, SensorData.SensorTypeField.Field); }
			set { this.Table.SetField(this.SensorRowId, SensorData.SensorTypeField.Field, value); }
		}

		// Gets or sets value of the BitWidth field.
		public int BitWidth {
			get { return this.Table.GetField(this.SensorRowId, SensorData.BitWidthField.Field); }
			set { this.Table.SetField(this.SensorRowId, SensorData.BitWidthField.Field, value); }
		}

		// Gets or sets value of the PinSide field.
		public PinSide PinSide {
			get { return this.Table.GetField(this.SensorRowId, SensorData.PinSideField.Field); }
			set { this.Table.SetField(this.SensorRowId, SensorData.PinSideField.Field, value); }
		}

		// Gets or sets value of the Notation field.
		public override string Notation {
			get { return this.Table.GetField(this.SensorRowId, SensorData.NotationField.Field); }
			set { this.Table.SetField(this.SensorRowId, SensorData.NotationField.Field, value); }
		}

		// Gets or sets value of the Data field.
		public string Data {
			get { return this.Table.GetField(this.SensorRowId, SensorData.DataField.Field); }
			set { this.Table.SetField(this.SensorRowId, SensorData.DataField.Field, value); }
		}

		// Gets or sets value of the Note field.
		public override string Note {
			get { return this.Table.GetField(this.SensorRowId, SensorData.NoteField.Field); }
			set { this.Table.SetField(this.SensorRowId, SensorData.NoteField.Field, value); }
		}


		internal void NotifyChanged(TableChange<SensorData> change) {
			if(this.HasListener) {
				SensorData oldData, newData;
				change.GetOldData(out oldData);
				change.GetNewData(out newData);
				if(SensorData.SensorIdField.Field.Compare(ref oldData, ref newData) != 0) {
					this.NotifyPropertyChanged("SensorId");
				}
				if(SensorData.SensorTypeField.Field.Compare(ref oldData, ref newData) != 0) {
					this.NotifyPropertyChanged("SensorType");
				}
				if(SensorData.BitWidthField.Field.Compare(ref oldData, ref newData) != 0) {
					this.NotifyPropertyChanged("BitWidth");
				}
				if(SensorData.PinSideField.Field.Compare(ref oldData, ref newData) != 0) {
					this.NotifyPropertyChanged("PinSide");
				}
				if(SensorData.NotationField.Field.Compare(ref oldData, ref newData) != 0) {
					this.NotifyPropertyChanged("Notation");
				}
				if(SensorData.DataField.Field.Compare(ref oldData, ref newData) != 0) {
					this.NotifyPropertyChanged("Data");
				}
				if(SensorData.NoteField.Field.Compare(ref oldData, ref newData) != 0) {
					this.NotifyPropertyChanged("Note");
				}
			}
			this.OnSensorChanged();
		}

		partial void OnSensorChanged();
	}


	// Wrapper for table Sensor.
	partial class SensorSet : INotifyCollectionChanged, IEnumerable<Sensor> {

		public event NotifyCollectionChangedEventHandler CollectionChanged;

		internal TableSnapshot<SensorData> Table { get; private set; }

		// Gets StoreSnapshot this set belongs to.
		public CircuitProject CircuitProject { get { return (CircuitProject)this.Table.StoreSnapshot; } }

		// Constructor
		public SensorSet(CircuitProject store) {
			ITableSnapshot table = store.Table("Sensor");
			if(table != null) {
				Debug.Assert(store.IsFrozen, "The store should be frozen");
				this.Table = (TableSnapshot<SensorData>)table;
			} else {
				Debug.Assert(!store.IsFrozen, "In order to create table, the store should not be frozen");
				this.Table = SensorData.CreateTable(store);
			}
			this.InitializeSensorSet();
		}

		partial void InitializeSensorSet();

		//internal void Register() {
		//	foreach(RowId rowId in this.Table.Rows) {
		//		this.FindOrCreate(rowId);
		//	}
		//}


		// gets items wrapper by RowId
		public Sensor Find(RowId rowId) {
			if(!rowId.IsEmpty) {
				return this.Table.GetField(rowId, SensorData.SensorField.Field);
			}
			return null;
		}


		// gets items wrapper by RowId
		private IEnumerable<Sensor> Select(IEnumerable<RowId> rows) {
			foreach(RowId rowId in rows) {
				Sensor item = this.Find(rowId);
				Debug.Assert(item != null, "What is the reason for the item not to be found?");
				yield return item;
			}
		}

		// Create wrapper for the row and register it in the dictionary
		private Sensor Create(RowId rowId, RowId CircuitRowId) {
			Sensor item = new Sensor(this.CircuitProject, rowId, CircuitRowId);
			return item;
		}

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling")]
		internal Sensor FindOrCreate(RowId rowId) {
			Debug.Assert(!rowId.IsEmpty && !this.Table.IsDeleted(rowId), "Bad RowId");
			Sensor item;
			if((item = this.Find(rowId)) != null) {
				Debug.Assert(!item.IsDeleted(), "Deleted item should not be present in the dictionary");
				return item;
			}
			Guid primaryKeyValue = this.Table.GetField(rowId, SensorData.SensorIdField.Field);


			TableSnapshot<CircuitData> tableCircuit = (TableSnapshot<CircuitData>)this.CircuitProject.Table("Circuit");
			return this.Create(rowId, tableCircuit.Find(CircuitData.CircuitIdField.Field, primaryKeyValue));
		}

		// Creates Sensor wrapper
		private Sensor CreateItem(
			// Fields of Sensor table
			Guid SensorId,
			SensorType SensorType,
			int BitWidth,
			PinSide PinSide,
			string Notation,
			string Data,
			string Note
			// Fields of Circuit table

		) {
			TableSnapshot<CircuitData> tableCircuit = (TableSnapshot<CircuitData>)this.CircuitProject.Table("Circuit");
			CircuitData dataCircuit = new CircuitData() {
				CircuitId = SensorId
			};
			RowId rowIdCircuit = tableCircuit.Insert(ref dataCircuit);

			SensorData dataSensor = new SensorData() {
				SensorId = SensorId,
				SensorType = SensorType,
				BitWidth = BitWidth,
				PinSide = PinSide,
				Notation = Notation,
				Data = Data,
				Note = Note,
			};
			return this.Create(this.Table.Insert(ref dataSensor), rowIdCircuit);
		}

		// Search helpers

		// Finds Sensor by SensorId
		public Sensor FindBySensorId(Guid sensorId) {
			return this.Find(this.Table.Find(SensorData.SensorIdField.Field, sensorId));
		}

		public IEnumerator<Sensor> GetEnumerator() {
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

		internal List<Sensor> UpdateSet(int oldVersion, int newVersion) {
			IEnumerator<TableChange<SensorData>> change = this.Table.GetVersionChangeChanges(oldVersion, newVersion);
			if(change != null) {
				bool handlerAttached = (this.CollectionChanged != null);
				List<Sensor> del = (handlerAttached) ? new List<Sensor>() : null;
				while(change.MoveNext()) {
					switch(change.Current.Action) {
					case SnapTableAction.Insert:
						this.FindOrCreate(change.Current.RowId);
						Debug.Assert(this.Find(change.Current.RowId) != null, "Why the item was not created?");
						break;
					case SnapTableAction.Delete:
						if(handlerAttached) {
							Sensor item = change.Current.GetOldField(SensorData.SensorField.Field);
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

		internal void NotifyVersionChanged(int oldVersion, int newVersion, List<Sensor> deleted) {
			IEnumerator<TableChange<SensorData>> change = this.Table.GetVersionChangeChanges(oldVersion, newVersion);
			if(change != null) {
				bool handlerAttached = (this.CollectionChanged != null);
				List<Sensor> add = (handlerAttached) ? new List<Sensor>() : null;
				this.StartNotifySensorSetChanged(oldVersion, newVersion);
				while(change.MoveNext()) {
					this.NotifySensorSetChanged(change.Current);
					switch(change.Current.Action) {
					case SnapTableAction.Insert:
						Debug.Assert(this.Find(change.Current.RowId) != null, "Why the item was not created?");
						if(handlerAttached) {
							add.Add(this.Find(change.Current.RowId));
						}
						break;
					case SnapTableAction.Delete:
						Debug.Assert(change.Current.GetOldField(SensorData.SensorField.Field).IsDeleted(), "Why the item still exists?");
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
				this.EndNotifySensorSetChanged();
			}
		}

		partial void StartNotifySensorSetChanged(int oldVersion, int newVersion);
		partial void EndNotifySensorSetChanged();
		partial void NotifySensorSetChanged(TableChange<SensorData> change);

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
