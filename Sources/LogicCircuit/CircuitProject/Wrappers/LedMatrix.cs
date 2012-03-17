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

	// Defines the shape of the table LedMatrix
	internal partial struct LedMatrixData {
		public Guid LedMatrixId;
		public LedMatrixType MatrixType;
		public LedMatrixCellShape CellShape;
		private int fieldRows;
		public int Rows {
			get { return this.fieldRows; }
			set { this.fieldRows = LedMatrix.Check(value); }
		}
		private int fieldColumns;
		public int Columns {
			get { return this.fieldColumns; }
			set { this.fieldColumns = LedMatrix.Check(value); }
		}
		private int fieldColors;
		public int Colors {
			get { return this.fieldColors; }
			set { this.fieldColors = LedMatrix.CheckColors(value); }
		}
		public string Note;
		internal LedMatrix LedMatrix;

		private interface IFieldSerializer {
			bool NeedToSave(ref LedMatrixData data);
			string GetTextValue(ref LedMatrixData data);
			void SetDefault(ref LedMatrixData data);
			void SetTextValue(ref LedMatrixData data, string text);
		}

		// Field accessors

		// Accessor of the LedMatrixId field
		public sealed class LedMatrixIdField : IField<LedMatrixData, Guid>, IFieldSerializer {
			public static readonly LedMatrixIdField Field = new LedMatrixIdField();
			private LedMatrixIdField() {}
			public string Name { get { return "LedMatrixId"; } }
			public int Order { get; set; }
			public Guid DefaultValue { get { return default(Guid); } }
			public Guid GetValue(ref LedMatrixData record) {
				return record.LedMatrixId;
			}
			public void SetValue(ref LedMatrixData record, Guid value) {
				record.LedMatrixId = value;
			}
			public int Compare(ref LedMatrixData l, ref LedMatrixData r) {
				return l.LedMatrixId.CompareTo(r.LedMatrixId);
			}
			public int Compare(Guid l, Guid r) {
				return l.CompareTo(r);
			}

			// Implementation of interface IFieldSerializer
			bool IFieldSerializer.NeedToSave(ref LedMatrixData data) {
				return this.Compare(data.LedMatrixId, this.DefaultValue) != 0;
			}
			string IFieldSerializer.GetTextValue(ref LedMatrixData data) {
				return string.Format(CultureInfo.InvariantCulture, "{0}", data.LedMatrixId);
			}
			void IFieldSerializer.SetDefault(ref LedMatrixData data) {
				data.LedMatrixId = this.DefaultValue;
			}
			void IFieldSerializer.SetTextValue(ref LedMatrixData data, string text) {
				data.LedMatrixId = new Guid(text);
			}
		}

		// Accessor of the MatrixType field
		public sealed class MatrixTypeField : IField<LedMatrixData, LedMatrixType>, IFieldSerializer {
			public static readonly MatrixTypeField Field = new MatrixTypeField();
			private MatrixTypeField() {}
			public string Name { get { return "MatrixType"; } }
			public int Order { get; set; }
			public LedMatrixType DefaultValue { get { return LedMatrixType.Individual; } }
			public LedMatrixType GetValue(ref LedMatrixData record) {
				return record.MatrixType;
			}
			public void SetValue(ref LedMatrixData record, LedMatrixType value) {
				record.MatrixType = value;
			}
			public int Compare(ref LedMatrixData l, ref LedMatrixData r) {
				return l.MatrixType.CompareTo(r.MatrixType);
			}
			public int Compare(LedMatrixType l, LedMatrixType r) {
				return l.CompareTo(r);
			}

			// Implementation of interface IFieldSerializer
			bool IFieldSerializer.NeedToSave(ref LedMatrixData data) {
				return this.Compare(data.MatrixType, this.DefaultValue) != 0;
			}
			string IFieldSerializer.GetTextValue(ref LedMatrixData data) {
				return string.Format(CultureInfo.InvariantCulture, "{0}", data.MatrixType);
			}
			void IFieldSerializer.SetDefault(ref LedMatrixData data) {
				data.MatrixType = this.DefaultValue;
			}
			void IFieldSerializer.SetTextValue(ref LedMatrixData data, string text) {
				data.MatrixType = (LedMatrixType)Enum.Parse(typeof(LedMatrixType), text, true);
			}
		}

		// Accessor of the CellShape field
		public sealed class CellShapeField : IField<LedMatrixData, LedMatrixCellShape>, IFieldSerializer {
			public static readonly CellShapeField Field = new CellShapeField();
			private CellShapeField() {}
			public string Name { get { return "CellShape"; } }
			public int Order { get; set; }
			public LedMatrixCellShape DefaultValue { get { return LedMatrixCellShape.Round; } }
			public LedMatrixCellShape GetValue(ref LedMatrixData record) {
				return record.CellShape;
			}
			public void SetValue(ref LedMatrixData record, LedMatrixCellShape value) {
				record.CellShape = value;
			}
			public int Compare(ref LedMatrixData l, ref LedMatrixData r) {
				return l.CellShape.CompareTo(r.CellShape);
			}
			public int Compare(LedMatrixCellShape l, LedMatrixCellShape r) {
				return l.CompareTo(r);
			}

			// Implementation of interface IFieldSerializer
			bool IFieldSerializer.NeedToSave(ref LedMatrixData data) {
				return this.Compare(data.CellShape, this.DefaultValue) != 0;
			}
			string IFieldSerializer.GetTextValue(ref LedMatrixData data) {
				return string.Format(CultureInfo.InvariantCulture, "{0}", data.CellShape);
			}
			void IFieldSerializer.SetDefault(ref LedMatrixData data) {
				data.CellShape = this.DefaultValue;
			}
			void IFieldSerializer.SetTextValue(ref LedMatrixData data, string text) {
				data.CellShape = (LedMatrixCellShape)Enum.Parse(typeof(LedMatrixCellShape), text, true);
			}
		}

		// Accessor of the Rows field
		public sealed class RowsField : IField<LedMatrixData, int>, IFieldSerializer {
			public static readonly RowsField Field = new RowsField();
			private RowsField() {}
			public string Name { get { return "Rows"; } }
			public int Order { get; set; }
			public int DefaultValue { get { return default(int); } }
			public int GetValue(ref LedMatrixData record) {
				return record.Rows;
			}
			public void SetValue(ref LedMatrixData record, int value) {
				record.Rows = value;
			}
			public int Compare(ref LedMatrixData l, ref LedMatrixData r) {
				return Math.Sign((long)l.Rows - (long)r.Rows);
			}
			public int Compare(int l, int r) {
				return Math.Sign((long)l - (long)r);
			}

			// Implementation of interface IFieldSerializer
			bool IFieldSerializer.NeedToSave(ref LedMatrixData data) {
				return this.Compare(data.Rows, this.DefaultValue) != 0;
			}
			string IFieldSerializer.GetTextValue(ref LedMatrixData data) {
				return string.Format(CultureInfo.InvariantCulture, "{0}", data.Rows);
			}
			void IFieldSerializer.SetDefault(ref LedMatrixData data) {
				data.Rows = this.DefaultValue;
			}
			void IFieldSerializer.SetTextValue(ref LedMatrixData data, string text) {
				data.Rows = int.Parse(text, CultureInfo.InvariantCulture);
			}
		}

		// Accessor of the Columns field
		public sealed class ColumnsField : IField<LedMatrixData, int>, IFieldSerializer {
			public static readonly ColumnsField Field = new ColumnsField();
			private ColumnsField() {}
			public string Name { get { return "Columns"; } }
			public int Order { get; set; }
			public int DefaultValue { get { return default(int); } }
			public int GetValue(ref LedMatrixData record) {
				return record.Columns;
			}
			public void SetValue(ref LedMatrixData record, int value) {
				record.Columns = value;
			}
			public int Compare(ref LedMatrixData l, ref LedMatrixData r) {
				return Math.Sign((long)l.Columns - (long)r.Columns);
			}
			public int Compare(int l, int r) {
				return Math.Sign((long)l - (long)r);
			}

			// Implementation of interface IFieldSerializer
			bool IFieldSerializer.NeedToSave(ref LedMatrixData data) {
				return this.Compare(data.Columns, this.DefaultValue) != 0;
			}
			string IFieldSerializer.GetTextValue(ref LedMatrixData data) {
				return string.Format(CultureInfo.InvariantCulture, "{0}", data.Columns);
			}
			void IFieldSerializer.SetDefault(ref LedMatrixData data) {
				data.Columns = this.DefaultValue;
			}
			void IFieldSerializer.SetTextValue(ref LedMatrixData data, string text) {
				data.Columns = int.Parse(text, CultureInfo.InvariantCulture);
			}
		}

		// Accessor of the Colors field
		public sealed class ColorsField : IField<LedMatrixData, int>, IFieldSerializer {
			public static readonly ColorsField Field = new ColorsField();
			private ColorsField() {}
			public string Name { get { return "Colors"; } }
			public int Order { get; set; }
			public int DefaultValue { get { return 1; } }
			public int GetValue(ref LedMatrixData record) {
				return record.Colors;
			}
			public void SetValue(ref LedMatrixData record, int value) {
				record.Colors = value;
			}
			public int Compare(ref LedMatrixData l, ref LedMatrixData r) {
				return Math.Sign((long)l.Colors - (long)r.Colors);
			}
			public int Compare(int l, int r) {
				return Math.Sign((long)l - (long)r);
			}

			// Implementation of interface IFieldSerializer
			bool IFieldSerializer.NeedToSave(ref LedMatrixData data) {
				return this.Compare(data.Colors, this.DefaultValue) != 0;
			}
			string IFieldSerializer.GetTextValue(ref LedMatrixData data) {
				return string.Format(CultureInfo.InvariantCulture, "{0}", data.Colors);
			}
			void IFieldSerializer.SetDefault(ref LedMatrixData data) {
				data.Colors = this.DefaultValue;
			}
			void IFieldSerializer.SetTextValue(ref LedMatrixData data, string text) {
				data.Colors = int.Parse(text, CultureInfo.InvariantCulture);
			}
		}

		// Accessor of the Note field
		public sealed class NoteField : IField<LedMatrixData, string>, IFieldSerializer {
			public static readonly NoteField Field = new NoteField();
			private NoteField() {}
			public string Name { get { return "Note"; } }
			public int Order { get; set; }
			public string DefaultValue { get { return ""; } }
			public string GetValue(ref LedMatrixData record) {
				return record.Note;
			}
			public void SetValue(ref LedMatrixData record, string value) {
				record.Note = value;
			}
			public int Compare(ref LedMatrixData l, ref LedMatrixData r) {
				return StringComparer.Ordinal.Compare(l.Note, r.Note);
			}
			public int Compare(string l, string r) {
				return StringComparer.Ordinal.Compare(l, r);
			}

			// Implementation of interface IFieldSerializer
			bool IFieldSerializer.NeedToSave(ref LedMatrixData data) {
				return this.Compare(data.Note, this.DefaultValue) != 0;
			}
			string IFieldSerializer.GetTextValue(ref LedMatrixData data) {
				return string.Format(CultureInfo.InvariantCulture, "{0}", data.Note);
			}
			void IFieldSerializer.SetDefault(ref LedMatrixData data) {
				data.Note = this.DefaultValue;
			}
			void IFieldSerializer.SetTextValue(ref LedMatrixData data, string text) {
				data.Note = text;
			}
		}

		// Special field used to access items wrapper of this record from record.
		// This is used when no other universes is used
		internal sealed class LedMatrixField : IField<LedMatrixData, LedMatrix> {
			public static readonly LedMatrixField Field = new LedMatrixField();
			private LedMatrixField() {}
			public string Name { get { return "LedMatrixWrapper"; } }
			public int Order { get; set; }
			public LedMatrix DefaultValue { get { return null; } }
			public LedMatrix GetValue(ref LedMatrixData record) {
				return record.LedMatrix;
			}
			public void SetValue(ref LedMatrixData record, LedMatrix value) {
				record.LedMatrix = value;
			}
			public int Compare(ref LedMatrixData l, ref LedMatrixData r) {
				return this.Compare(l.LedMatrix, r.LedMatrix);
			}
			public int Compare(LedMatrix l, LedMatrix r) {
				if(object.ReferenceEquals(l, r)) return 0;
				if(l == null) return -1;
				if(r == null) return 1;
				return l.LedMatrixRowId.CompareTo(r.LedMatrixRowId);
			}
		}

		private static IField<LedMatrixData>[] fields = {
			LedMatrixIdField.Field,
			MatrixTypeField.Field,
			CellShapeField.Field,
			RowsField.Field,
			ColumnsField.Field,
			ColorsField.Field,
			NoteField.Field,
			LedMatrixField.Field
		};

		// Creates table.
		public static TableSnapshot<LedMatrixData> CreateTable(StoreSnapshot store) {
			TableSnapshot<LedMatrixData> table = new TableSnapshot<LedMatrixData>(store, "LedMatrix", LedMatrixData.fields);
			// Create all but foreign keys of the table
			table.MakeUnique("PK_LedMatrix", LedMatrixData.LedMatrixIdField.Field , true);
			// Return created table
			return table;
		}

		// Creates all foreign keys of the table
		public static void CreateForeignKeys(StoreSnapshot store) {
			TableSnapshot<LedMatrixData> table = (TableSnapshot<LedMatrixData>)store.Table("LedMatrix");
			table.CreateForeignKey("PK_LedMatrix", store.Table("Circuit"), LedMatrixData.LedMatrixIdField.Field, ForeignKeyAction.Cascade, false);
		}

		// Serializer of the table
		public static void Save(TableSnapshot<LedMatrixData> table, XmlWriter writer, string ns) {
			foreach(RowId rowId in table.Rows) {
				LedMatrixData data;
				table.GetData(rowId, out data);
				writer.WriteStartElement(table.Name, ns);
				foreach(IField<LedMatrixData> field in table.Fields) {
					IFieldSerializer serializer = field as IFieldSerializer;
					if(serializer != null && serializer.NeedToSave(ref data)) {
						writer.WriteStartElement(field.Name, ns);
						writer.WriteString(serializer.GetTextValue(ref data));
						writer.WriteEndElement();
					}
				}
				writer.WriteEndElement();
			}
		}

		public static RowId Load(TableSnapshot<LedMatrixData> table, XmlReader reader) {
			Debug.Assert(reader.NodeType == XmlNodeType.Element);
			Debug.Assert(reader.LocalName == table.Name);
			Debug.Assert(!reader.IsEmptyElement);

			LedMatrixData data = new LedMatrixData();
			// Initialize 'data' with default values:
			for (int i = 0; i < LedMatrixData.fields.Length; i ++) {
				IFieldSerializer serializer = LedMatrixData.fields[i] as IFieldSerializer;
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
					IFieldSerializer serializer = LedMatrixData.FindField(fieldName, ref hintIndex);
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
			Debug.Assert(0 <= hint && hint <= LedMatrixData.fields.Length);
			for (int i = hint; i < LedMatrixData.fields.Length; i ++) {
				if (LedMatrixData.fields[i].Name == name) {
					hint = i + 1;
					return LedMatrixData.fields[i] as IFieldSerializer;
				}
			}

			// We don't find the field in expected place. Lets look the beginning of the list in case it is out of order
			for (int i = 0; i < hint; i ++) {
				if (LedMatrixData.fields[i].Name == name) {
					return LedMatrixData.fields[i] as IFieldSerializer;
				}
			}

			// Ups. Still don't find.
			return null;
		}
	}


	// Class wrapper for a record.
	partial class LedMatrix : Circuit {

		// RowId of the wrapped record
		internal RowId LedMatrixRowId { get; private set; }

		// Constructor
		public LedMatrix(CircuitProject store, RowId rowIdLedMatrix, RowId rowIdCircuit) : base(store, rowIdCircuit) {
			Debug.Assert(!rowIdLedMatrix.IsEmpty);
			this.LedMatrixRowId = rowIdLedMatrix;
			// Link back to record. Assuming that a transaction is started
			this.Table.SetField(this.LedMatrixRowId, LedMatrixData.LedMatrixField.Field, this);
			this.InitializeLedMatrix();
		}

		partial void InitializeLedMatrix();

		// Gets table storing this item.
		private TableSnapshot<LedMatrixData> Table { get { return this.CircuitProject.LedMatrixSet.Table; } }


		//Properties of LedMatrix

		// Gets value of the LedMatrixId field.
		public Guid LedMatrixId {
			get { return this.Table.GetField(this.LedMatrixRowId, LedMatrixData.LedMatrixIdField.Field); }
		}

		// Gets or sets value of the MatrixType field.
		public LedMatrixType MatrixType {
			get { return this.Table.GetField(this.LedMatrixRowId, LedMatrixData.MatrixTypeField.Field); }
			set { this.Table.SetField(this.LedMatrixRowId, LedMatrixData.MatrixTypeField.Field, value); }
		}

		// Gets or sets value of the CellShape field.
		public LedMatrixCellShape CellShape {
			get { return this.Table.GetField(this.LedMatrixRowId, LedMatrixData.CellShapeField.Field); }
			set { this.Table.SetField(this.LedMatrixRowId, LedMatrixData.CellShapeField.Field, value); }
		}

		// Gets or sets value of the Rows field.
		public int Rows {
			get { return this.Table.GetField(this.LedMatrixRowId, LedMatrixData.RowsField.Field); }
			set { this.Table.SetField(this.LedMatrixRowId, LedMatrixData.RowsField.Field, value); }
		}

		// Gets or sets value of the Columns field.
		public int Columns {
			get { return this.Table.GetField(this.LedMatrixRowId, LedMatrixData.ColumnsField.Field); }
			set { this.Table.SetField(this.LedMatrixRowId, LedMatrixData.ColumnsField.Field, value); }
		}

		// Gets or sets value of the Colors field.
		public int Colors {
			get { return this.Table.GetField(this.LedMatrixRowId, LedMatrixData.ColorsField.Field); }
			set { this.Table.SetField(this.LedMatrixRowId, LedMatrixData.ColorsField.Field, value); }
		}

		// Gets or sets value of the Note field.
		public string Note {
			get { return this.Table.GetField(this.LedMatrixRowId, LedMatrixData.NoteField.Field); }
			set { this.Table.SetField(this.LedMatrixRowId, LedMatrixData.NoteField.Field, value); }
		}


		internal void NotifyChanged(TableChange<LedMatrixData> change) {
			if(this.HasListener) {
				LedMatrixData oldData, newData;
				change.GetOldData(out oldData);
				change.GetNewData(out newData);
				if(LedMatrixData.LedMatrixIdField.Field.Compare(ref oldData, ref newData) != 0) {
					this.NotifyPropertyChanged("LedMatrixId");
				}
				if(LedMatrixData.MatrixTypeField.Field.Compare(ref oldData, ref newData) != 0) {
					this.NotifyPropertyChanged("MatrixType");
				}
				if(LedMatrixData.CellShapeField.Field.Compare(ref oldData, ref newData) != 0) {
					this.NotifyPropertyChanged("CellShape");
				}
				if(LedMatrixData.RowsField.Field.Compare(ref oldData, ref newData) != 0) {
					this.NotifyPropertyChanged("Rows");
				}
				if(LedMatrixData.ColumnsField.Field.Compare(ref oldData, ref newData) != 0) {
					this.NotifyPropertyChanged("Columns");
				}
				if(LedMatrixData.ColorsField.Field.Compare(ref oldData, ref newData) != 0) {
					this.NotifyPropertyChanged("Colors");
				}
				if(LedMatrixData.NoteField.Field.Compare(ref oldData, ref newData) != 0) {
					this.NotifyPropertyChanged("Note");
				}
			}
			this.OnLedMatrixChanged();
		}

		partial void OnLedMatrixChanged();
	}


	// Wrapper for table LedMatrix.
	partial class LedMatrixSet : INotifyCollectionChanged, IEnumerable<LedMatrix> {

		public event NotifyCollectionChangedEventHandler CollectionChanged;

		internal TableSnapshot<LedMatrixData> Table { get; private set; }

		// Gets StoreSnapshot this set belongs to.
		public CircuitProject CircuitProject { get { return (CircuitProject)this.Table.StoreSnapshot; } }

		// Constructor
		public LedMatrixSet(CircuitProject store) {
			ITableSnapshot table = store.Table("LedMatrix");
			if(table != null) {
				Debug.Assert(store.IsFrozen, "The store should be frozen");
				this.Table = (TableSnapshot<LedMatrixData>)table;
			} else {
				Debug.Assert(!store.IsFrozen, "In order to create table, the store should not be frozen");
				this.Table = LedMatrixData.CreateTable(store);
			}
			this.InitializeLedMatrixSet();
		}

		partial void InitializeLedMatrixSet();

		//internal void Register() {
		//	foreach(RowId rowId in this.Table.Rows) {
		//		this.FindOrCreate(rowId);
		//	}
		//}


		// gets items wrapper by RowId
		public LedMatrix Find(RowId rowId) {
			if(!rowId.IsEmpty) {
				return this.Table.GetField(rowId, LedMatrixData.LedMatrixField.Field);
			}
			return null;
		}

		private void Delete(RowId rowId) {
		}

		// gets items wrapper by RowId
		private IEnumerable<LedMatrix> Select(IEnumerable<RowId> rows) {
			foreach(RowId rowId in rows) {
				LedMatrix item = this.Find(rowId);
				Debug.Assert(item != null, "What is the reason for the item not to be found?");
				yield return item;
			}
		}

		// Create wrapper for the row and register it in the dictionary
		private LedMatrix Create(RowId rowId, RowId CircuitRowId) {
			LedMatrix item = new LedMatrix(this.CircuitProject, rowId, CircuitRowId);
			return item;
		}

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling")]
		internal LedMatrix FindOrCreate(RowId rowId) {
			Debug.Assert(!rowId.IsEmpty && !this.Table.IsDeleted(rowId), "Bad RowId");
			LedMatrix item;
			if((item = this.Find(rowId)) != null) {
				Debug.Assert(!item.IsDeleted(), "Deleted item should not be present in the dictionary");
				return item;
			}
			Guid primaryKeyValue = this.Table.GetField(rowId, LedMatrixData.LedMatrixIdField.Field);


			TableSnapshot<CircuitData> tableCircuit = (TableSnapshot<CircuitData>)this.CircuitProject.Table("Circuit");
			return this.Create(rowId, tableCircuit.Find(CircuitData.CircuitIdField.Field, primaryKeyValue));
		}

		// Creates LedMatrix wrapper
		private LedMatrix CreateItem(
			// Fields of LedMatrix table
			Guid LedMatrixId,
			LedMatrixType MatrixType,
			LedMatrixCellShape CellShape,
			int Rows,
			int Columns,
			int Colors,
			string Note
			// Fields of Circuit table

		) {
			TableSnapshot<CircuitData> tableCircuit = (TableSnapshot<CircuitData>)this.CircuitProject.Table("Circuit");
			CircuitData dataCircuit = new CircuitData() {
				CircuitId = LedMatrixId
			};
			RowId rowIdCircuit = tableCircuit.Insert(ref dataCircuit);

			LedMatrixData dataLedMatrix = new LedMatrixData() {
				LedMatrixId = LedMatrixId,
				MatrixType = MatrixType,
				CellShape = CellShape,
				Rows = Rows,
				Columns = Columns,
				Colors = Colors,
				Note = Note,
			};
			return this.Create(this.Table.Insert(ref dataLedMatrix), rowIdCircuit);
		}

		// Search helpers

		// Finds LedMatrix by LedMatrixId
		public LedMatrix FindByLedMatrixId(Guid ledMatrixId) {
			return this.Find(this.Table.Find(LedMatrixData.LedMatrixIdField.Field, ledMatrixId));
		}

		public IEnumerator<LedMatrix> GetEnumerator() {
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

		internal List<LedMatrix> UpdateSet(int oldVersion, int newVersion) {
			IEnumerator<TableChange<LedMatrixData>> change = this.Table.GetVersionChangeChanges(oldVersion, newVersion);
			if(change != null) {
				bool handlerAttached = (this.CollectionChanged != null);
				List<LedMatrix> del = (handlerAttached) ? new List<LedMatrix>() : null;
				while(change.MoveNext()) {
					switch(change.Current.Action) {
					case SnapTableAction.Insert:
						this.FindOrCreate(change.Current.RowId);
						Debug.Assert(this.Find(change.Current.RowId) != null, "Why the item was not created?");
						break;
					case SnapTableAction.Delete:
						if(handlerAttached) {
							LedMatrix item = change.Current.GetOldField(LedMatrixData.LedMatrixField.Field);
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

		internal void NotifyVersionChanged(int oldVersion, int newVersion, List<LedMatrix> deleted) {
			IEnumerator<TableChange<LedMatrixData>> change = this.Table.GetVersionChangeChanges(oldVersion, newVersion);
			if(change != null) {
				bool handlerAttached = (this.CollectionChanged != null);
				List<LedMatrix> add = (handlerAttached) ? new List<LedMatrix>() : null;
				this.StartNotifyLedMatrixSetChanged(oldVersion, newVersion);
				while(change.MoveNext()) {
					this.NotifyLedMatrixSetChanged(change.Current);
					switch(change.Current.Action) {
					case SnapTableAction.Insert:
						Debug.Assert(this.Find(change.Current.RowId) != null, "Why the item was not created?");
						if(handlerAttached) {
							add.Add(this.Find(change.Current.RowId));
						}
						break;
					case SnapTableAction.Delete:
						Debug.Assert(change.Current.GetOldField(LedMatrixData.LedMatrixField.Field).IsDeleted(), "Why the item still exists?");
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
				this.EndNotifyLedMatrixSetChanged();
			}
		}

		partial void StartNotifyLedMatrixSetChanged(int oldVersion, int newVersion);
		partial void EndNotifyLedMatrixSetChanged();
		partial void NotifyLedMatrixSetChanged(TableChange<LedMatrixData> change);

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
