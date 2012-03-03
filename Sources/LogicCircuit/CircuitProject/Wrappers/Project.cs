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

	// Defines the shape of the table Project
	internal partial struct ProjectData {
		public Guid ProjectId;
		public string Name;
		public string Description;
		private double fieldZoom;
		public double Zoom {
			get { return this.fieldZoom; }
			set { this.fieldZoom = Project.CheckZoom(value); }
		}
		private int fieldFrequency;
		public int Frequency {
			get { return this.fieldFrequency; }
			set { this.fieldFrequency = Project.CheckFrequency(value); }
		}
		public bool IsMaximumSpeed;
		public Guid LogicalCircuitId;
		public bool CategoryTextNoteCollapsed;
		public bool CategoryInputOutputCollapsed;
		public bool CategoryPrimitivesCollapsed;
		internal Project Project;

		private interface IFieldSerializer {
			bool NeedToSave(ref ProjectData data);
			string GetTextValue(ref ProjectData data);
			void SetDefault(ref ProjectData data);
			void SetTextValue(ref ProjectData data, string text);
		}

		// Field accessors

		// Accessor of the ProjectId field
		public sealed class ProjectIdField : IField<ProjectData, Guid>, IFieldSerializer {
			public static readonly ProjectIdField Field = new ProjectIdField();
			private ProjectIdField() {}
			public string Name { get { return "ProjectId"; } }
			public int Order { get; set; }
			public Guid DefaultValue { get { return default(Guid); } }
			public Guid GetValue(ref ProjectData record) {
				return record.ProjectId;
			}
			public void SetValue(ref ProjectData record, Guid value) {
				record.ProjectId = value;
			}
			public int Compare(ref ProjectData l, ref ProjectData r) {
				return l.ProjectId.CompareTo(r.ProjectId);
			}
			public int Compare(Guid l, Guid r) {
				return l.CompareTo(r);
			}

			// Implementation of interface IFieldSerializer
			bool IFieldSerializer.NeedToSave(ref ProjectData data) {
				return this.Compare(data.ProjectId, this.DefaultValue) != 0;
			}
			string IFieldSerializer.GetTextValue(ref ProjectData data) {
				return string.Format(CultureInfo.InvariantCulture, "{0}", data.ProjectId);
			}
			void IFieldSerializer.SetDefault(ref ProjectData data) {
				data.ProjectId = this.DefaultValue;
			}
			void IFieldSerializer.SetTextValue(ref ProjectData data, string text) {
				data.ProjectId = new Guid(text);
			}
		}

		// Accessor of the Name field
		public sealed class NameField : IField<ProjectData, string>, IFieldSerializer {
			public static readonly NameField Field = new NameField();
			private NameField() {}
			public string Name { get { return "Name"; } }
			public int Order { get; set; }
			public string DefaultValue { get { return "Circuit Project"; } }
			public string GetValue(ref ProjectData record) {
				return record.Name;
			}
			public void SetValue(ref ProjectData record, string value) {
				record.Name = value;
			}
			public int Compare(ref ProjectData l, ref ProjectData r) {
				return StringComparer.Ordinal.Compare(l.Name, r.Name);
			}
			public int Compare(string l, string r) {
				return StringComparer.Ordinal.Compare(l, r);
			}

			// Implementation of interface IFieldSerializer
			bool IFieldSerializer.NeedToSave(ref ProjectData data) {
				return this.Compare(data.Name, this.DefaultValue) != 0;
			}
			string IFieldSerializer.GetTextValue(ref ProjectData data) {
				return string.Format(CultureInfo.InvariantCulture, "{0}", data.Name);
			}
			void IFieldSerializer.SetDefault(ref ProjectData data) {
				data.Name = this.DefaultValue;
			}
			void IFieldSerializer.SetTextValue(ref ProjectData data, string text) {
				data.Name = text;
			}
		}

		// Accessor of the Description field
		public sealed class DescriptionField : IField<ProjectData, string>, IFieldSerializer {
			public static readonly DescriptionField Field = new DescriptionField();
			private DescriptionField() {}
			public string Name { get { return "Description"; } }
			public int Order { get; set; }
			public string DefaultValue { get { return ""; } }
			public string GetValue(ref ProjectData record) {
				return record.Description;
			}
			public void SetValue(ref ProjectData record, string value) {
				record.Description = value;
			}
			public int Compare(ref ProjectData l, ref ProjectData r) {
				return StringComparer.Ordinal.Compare(l.Description, r.Description);
			}
			public int Compare(string l, string r) {
				return StringComparer.Ordinal.Compare(l, r);
			}

			// Implementation of interface IFieldSerializer
			bool IFieldSerializer.NeedToSave(ref ProjectData data) {
				return this.Compare(data.Description, this.DefaultValue) != 0;
			}
			string IFieldSerializer.GetTextValue(ref ProjectData data) {
				return string.Format(CultureInfo.InvariantCulture, "{0}", data.Description);
			}
			void IFieldSerializer.SetDefault(ref ProjectData data) {
				data.Description = this.DefaultValue;
			}
			void IFieldSerializer.SetTextValue(ref ProjectData data, string text) {
				data.Description = text;
			}
		}

		// Accessor of the Zoom field
		public sealed class ZoomField : IField<ProjectData, double>, IFieldSerializer {
			public static readonly ZoomField Field = new ZoomField();
			private ZoomField() {}
			public string Name { get { return "Zoom"; } }
			public int Order { get; set; }
			public double DefaultValue { get { return 1; } }
			public double GetValue(ref ProjectData record) {
				return record.Zoom;
			}
			public void SetValue(ref ProjectData record, double value) {
				record.Zoom = value;
			}
			public int Compare(ref ProjectData l, ref ProjectData r) {
				return Math.Sign(l.Zoom - r.Zoom);
			}
			public int Compare(double l, double r) {
				return Math.Sign(l - r);
			}

			// Implementation of interface IFieldSerializer
			bool IFieldSerializer.NeedToSave(ref ProjectData data) {
				return this.Compare(data.Zoom, this.DefaultValue) != 0;
			}
			string IFieldSerializer.GetTextValue(ref ProjectData data) {
				return string.Format(CultureInfo.InvariantCulture, "{0}", data.Zoom);
			}
			void IFieldSerializer.SetDefault(ref ProjectData data) {
				data.Zoom = this.DefaultValue;
			}
			void IFieldSerializer.SetTextValue(ref ProjectData data, string text) {
				data.Zoom = double.Parse(text, CultureInfo.InvariantCulture);
			}
		}

		// Accessor of the Frequency field
		public sealed class FrequencyField : IField<ProjectData, int>, IFieldSerializer {
			public static readonly FrequencyField Field = new FrequencyField();
			private FrequencyField() {}
			public string Name { get { return "Frequency"; } }
			public int Order { get; set; }
			public int DefaultValue { get { return 10; } }
			public int GetValue(ref ProjectData record) {
				return record.Frequency;
			}
			public void SetValue(ref ProjectData record, int value) {
				record.Frequency = value;
			}
			public int Compare(ref ProjectData l, ref ProjectData r) {
				return Math.Sign((long)l.Frequency - (long)r.Frequency);
			}
			public int Compare(int l, int r) {
				return Math.Sign((long)l - (long)r);
			}

			// Implementation of interface IFieldSerializer
			bool IFieldSerializer.NeedToSave(ref ProjectData data) {
				return this.Compare(data.Frequency, this.DefaultValue) != 0;
			}
			string IFieldSerializer.GetTextValue(ref ProjectData data) {
				return string.Format(CultureInfo.InvariantCulture, "{0}", data.Frequency);
			}
			void IFieldSerializer.SetDefault(ref ProjectData data) {
				data.Frequency = this.DefaultValue;
			}
			void IFieldSerializer.SetTextValue(ref ProjectData data, string text) {
				data.Frequency = int.Parse(text, CultureInfo.InvariantCulture);
			}
		}

		// Accessor of the IsMaximumSpeed field
		public sealed class IsMaximumSpeedField : IField<ProjectData, bool>, IFieldSerializer {
			public static readonly IsMaximumSpeedField Field = new IsMaximumSpeedField();
			private IsMaximumSpeedField() {}
			public string Name { get { return "IsMaximumSpeed"; } }
			public int Order { get; set; }
			public bool DefaultValue { get { return false; } }
			public bool GetValue(ref ProjectData record) {
				return record.IsMaximumSpeed;
			}
			public void SetValue(ref ProjectData record, bool value) {
				record.IsMaximumSpeed = value;
			}
			public int Compare(ref ProjectData l, ref ProjectData r) {
				return l.IsMaximumSpeed.CompareTo(r.IsMaximumSpeed);
			}
			public int Compare(bool l, bool r) {
				return l.CompareTo(r);
			}

			// Implementation of interface IFieldSerializer
			bool IFieldSerializer.NeedToSave(ref ProjectData data) {
				return this.Compare(data.IsMaximumSpeed, this.DefaultValue) != 0;
			}
			string IFieldSerializer.GetTextValue(ref ProjectData data) {
				return string.Format(CultureInfo.InvariantCulture, "{0}", data.IsMaximumSpeed);
			}
			void IFieldSerializer.SetDefault(ref ProjectData data) {
				data.IsMaximumSpeed = this.DefaultValue;
			}
			void IFieldSerializer.SetTextValue(ref ProjectData data, string text) {
				data.IsMaximumSpeed = bool.Parse(text);
			}
		}

		// Accessor of the LogicalCircuitId field
		public sealed class LogicalCircuitIdField : IField<ProjectData, Guid>, IFieldSerializer {
			public static readonly LogicalCircuitIdField Field = new LogicalCircuitIdField();
			private LogicalCircuitIdField() {}
			public string Name { get { return "LogicalCircuitId"; } }
			public int Order { get; set; }
			public Guid DefaultValue { get { return default(Guid); } }
			public Guid GetValue(ref ProjectData record) {
				return record.LogicalCircuitId;
			}
			public void SetValue(ref ProjectData record, Guid value) {
				record.LogicalCircuitId = value;
			}
			public int Compare(ref ProjectData l, ref ProjectData r) {
				return l.LogicalCircuitId.CompareTo(r.LogicalCircuitId);
			}
			public int Compare(Guid l, Guid r) {
				return l.CompareTo(r);
			}

			// Implementation of interface IFieldSerializer
			bool IFieldSerializer.NeedToSave(ref ProjectData data) {
				return this.Compare(data.LogicalCircuitId, this.DefaultValue) != 0;
			}
			string IFieldSerializer.GetTextValue(ref ProjectData data) {
				return string.Format(CultureInfo.InvariantCulture, "{0}", data.LogicalCircuitId);
			}
			void IFieldSerializer.SetDefault(ref ProjectData data) {
				data.LogicalCircuitId = this.DefaultValue;
			}
			void IFieldSerializer.SetTextValue(ref ProjectData data, string text) {
				data.LogicalCircuitId = new Guid(text);
			}
		}

		// Accessor of the CategoryTextNoteCollapsed field
		public sealed class CategoryTextNoteCollapsedField : IField<ProjectData, bool>, IFieldSerializer {
			public static readonly CategoryTextNoteCollapsedField Field = new CategoryTextNoteCollapsedField();
			private CategoryTextNoteCollapsedField() {}
			public string Name { get { return "CategoryTextNoteCollapsed"; } }
			public int Order { get; set; }
			public bool DefaultValue { get { return false; } }
			public bool GetValue(ref ProjectData record) {
				return record.CategoryTextNoteCollapsed;
			}
			public void SetValue(ref ProjectData record, bool value) {
				record.CategoryTextNoteCollapsed = value;
			}
			public int Compare(ref ProjectData l, ref ProjectData r) {
				return l.CategoryTextNoteCollapsed.CompareTo(r.CategoryTextNoteCollapsed);
			}
			public int Compare(bool l, bool r) {
				return l.CompareTo(r);
			}

			// Implementation of interface IFieldSerializer
			bool IFieldSerializer.NeedToSave(ref ProjectData data) {
				return this.Compare(data.CategoryTextNoteCollapsed, this.DefaultValue) != 0;
			}
			string IFieldSerializer.GetTextValue(ref ProjectData data) {
				return string.Format(CultureInfo.InvariantCulture, "{0}", data.CategoryTextNoteCollapsed);
			}
			void IFieldSerializer.SetDefault(ref ProjectData data) {
				data.CategoryTextNoteCollapsed = this.DefaultValue;
			}
			void IFieldSerializer.SetTextValue(ref ProjectData data, string text) {
				data.CategoryTextNoteCollapsed = bool.Parse(text);
			}
		}

		// Accessor of the CategoryInputOutputCollapsed field
		public sealed class CategoryInputOutputCollapsedField : IField<ProjectData, bool>, IFieldSerializer {
			public static readonly CategoryInputOutputCollapsedField Field = new CategoryInputOutputCollapsedField();
			private CategoryInputOutputCollapsedField() {}
			public string Name { get { return "CategoryInputOutputCollapsed"; } }
			public int Order { get; set; }
			public bool DefaultValue { get { return false; } }
			public bool GetValue(ref ProjectData record) {
				return record.CategoryInputOutputCollapsed;
			}
			public void SetValue(ref ProjectData record, bool value) {
				record.CategoryInputOutputCollapsed = value;
			}
			public int Compare(ref ProjectData l, ref ProjectData r) {
				return l.CategoryInputOutputCollapsed.CompareTo(r.CategoryInputOutputCollapsed);
			}
			public int Compare(bool l, bool r) {
				return l.CompareTo(r);
			}

			// Implementation of interface IFieldSerializer
			bool IFieldSerializer.NeedToSave(ref ProjectData data) {
				return this.Compare(data.CategoryInputOutputCollapsed, this.DefaultValue) != 0;
			}
			string IFieldSerializer.GetTextValue(ref ProjectData data) {
				return string.Format(CultureInfo.InvariantCulture, "{0}", data.CategoryInputOutputCollapsed);
			}
			void IFieldSerializer.SetDefault(ref ProjectData data) {
				data.CategoryInputOutputCollapsed = this.DefaultValue;
			}
			void IFieldSerializer.SetTextValue(ref ProjectData data, string text) {
				data.CategoryInputOutputCollapsed = bool.Parse(text);
			}
		}

		// Accessor of the CategoryPrimitivesCollapsed field
		public sealed class CategoryPrimitivesCollapsedField : IField<ProjectData, bool>, IFieldSerializer {
			public static readonly CategoryPrimitivesCollapsedField Field = new CategoryPrimitivesCollapsedField();
			private CategoryPrimitivesCollapsedField() {}
			public string Name { get { return "CategoryPrimitivesCollapsed"; } }
			public int Order { get; set; }
			public bool DefaultValue { get { return false; } }
			public bool GetValue(ref ProjectData record) {
				return record.CategoryPrimitivesCollapsed;
			}
			public void SetValue(ref ProjectData record, bool value) {
				record.CategoryPrimitivesCollapsed = value;
			}
			public int Compare(ref ProjectData l, ref ProjectData r) {
				return l.CategoryPrimitivesCollapsed.CompareTo(r.CategoryPrimitivesCollapsed);
			}
			public int Compare(bool l, bool r) {
				return l.CompareTo(r);
			}

			// Implementation of interface IFieldSerializer
			bool IFieldSerializer.NeedToSave(ref ProjectData data) {
				return this.Compare(data.CategoryPrimitivesCollapsed, this.DefaultValue) != 0;
			}
			string IFieldSerializer.GetTextValue(ref ProjectData data) {
				return string.Format(CultureInfo.InvariantCulture, "{0}", data.CategoryPrimitivesCollapsed);
			}
			void IFieldSerializer.SetDefault(ref ProjectData data) {
				data.CategoryPrimitivesCollapsed = this.DefaultValue;
			}
			void IFieldSerializer.SetTextValue(ref ProjectData data, string text) {
				data.CategoryPrimitivesCollapsed = bool.Parse(text);
			}
		}

		// Special field used to access items wrapper of this record from record.
		// This is used when no other universes is used
		internal sealed class ProjectField : IField<ProjectData, Project> {
			public static readonly ProjectField Field = new ProjectField();
			private ProjectField() {}
			public string Name { get { return "ProjectWrapper"; } }
			public int Order { get; set; }
			public Project DefaultValue { get { return null; } }
			public Project GetValue(ref ProjectData record) {
				return record.Project;
			}
			public void SetValue(ref ProjectData record, Project value) {
				record.Project = value;
			}
			public int Compare(ref ProjectData l, ref ProjectData r) {
				return this.Compare(l.Project, r.Project);
			}
			public int Compare(Project l, Project r) {
				if(object.ReferenceEquals(l, r)) return 0;
				if(l == null) return -1;
				if(r == null) return 1;
				return l.ProjectRowId.CompareTo(r.ProjectRowId);
			}
		}

		private static IField<ProjectData>[] fields = {
			ProjectIdField.Field,
			NameField.Field,
			DescriptionField.Field,
			ZoomField.Field,
			FrequencyField.Field,
			IsMaximumSpeedField.Field,
			LogicalCircuitIdField.Field,
			CategoryTextNoteCollapsedField.Field,
			CategoryInputOutputCollapsedField.Field,
			CategoryPrimitivesCollapsedField.Field,
			ProjectField.Field
		};

		// Creates table.
		public static TableSnapshot<ProjectData> CreateTable(StoreSnapshot store) {
			TableSnapshot<ProjectData> table = new TableSnapshot<ProjectData>(store, "Project", ProjectData.fields);
			// Create all but foreign keys of the table
			table.MakeUnique("PK_Project", ProjectData.ProjectIdField.Field , true);
			// Return created table
			return table;
		}

		// Creates all foreign keys of the table
		public static void CreateForeignKeys(StoreSnapshot store) {
			TableSnapshot<ProjectData> table = (TableSnapshot<ProjectData>)store.Table("Project");
			table.CreateForeignKey("FK_LogicalCircuit_Project", store.Table("LogicalCircuit"), ProjectData.LogicalCircuitIdField.Field, ForeignKeyAction.Restrict, false);
		}

		// Serializer of the table
		public static void Save(TableSnapshot<ProjectData> table, XmlElement root) {
			XmlDocument xml = root.OwnerDocument;
			foreach(RowId rowId in table.Rows) {
				ProjectData data;
				table.GetData(rowId, out data);
				XmlElement node = xml.CreateElement(root.Prefix, table.Name, root.NamespaceURI);
				root.AppendChild(node);
				foreach(IField<ProjectData> field in table.Fields) {
					IFieldSerializer serializer = field as IFieldSerializer;
					if(serializer != null && serializer.NeedToSave(ref data)) {
						XmlElement e = xml.CreateElement(root.Prefix, field.Name, root.NamespaceURI);
						node.AppendChild(e);
						e.AppendChild(xml.CreateTextNode(serializer.GetTextValue(ref data)));
					}
				}
			}
		}

		public static void Load(TableSnapshot<ProjectData> table, XmlNodeList list, Action<RowId> register) {
			foreach(XmlElement node in list) {
				Debug.Assert(node.LocalName == table.Name);
				ProjectData data = new ProjectData();
				// Initialize 'data' with default values: 
				for (int i = 0; i < ProjectData.fields.Length; i ++) {
					IFieldSerializer serializer = ProjectData.fields[i] as IFieldSerializer;
					if (serializer != null) {
						serializer.SetDefault(ref data);
					}
				}
				// For each child of 'node' deserialize the field of the 'data' record
				int hintIndex = 0;
				foreach(XmlNode child in node.ChildNodes) {
					XmlElement c = child as XmlElement;
					if(c != null && c.NamespaceURI == node.NamespaceURI) {
						IFieldSerializer serializer = FindField(c.LocalName, ref hintIndex);
						if (serializer != null) {
							serializer.SetTextValue(ref data, c.InnerText);
						}
					}
				}
				// insert 'data' into the table
				RowId rowId = table.Insert(ref data);
				// 'register' it (create realm object)
				if(register != null) {
					register(rowId);
				}
			}
		}

		private static IFieldSerializer FindField(string name, ref int hint) {
			// We serialize/deserialize fields in the same order so result would always be at hint position or after it if hint is skipped during the serialization
			Debug.Assert(0 <= hint && hint <= ProjectData.fields.Length);
			for (int i = hint; i < ProjectData.fields.Length; i ++) {
				if (ProjectData.fields[i].Name == name) {
					hint = i + 1;
					return ProjectData.fields[i] as IFieldSerializer;
				}
			}

			// We don't find the field in expected place. Lets look the beginning of the list in case it is out of order
			for (int i = 0; i < hint; i ++) {
				if (ProjectData.fields[i].Name == name) {
					return ProjectData.fields[i] as IFieldSerializer;
				}
			}

			// Ups. Still don't find. 
			return null;
		}
	}


	// Class wrapper for a record.
	partial class Project : INotifyPropertyChanged {

		// RowId of the wrapped record
		internal RowId ProjectRowId { get; private set; }
		// Store this wrapper belongs to
		public CircuitProject CircuitProject { get; private set; }

		// Constructor
		public Project(CircuitProject store, RowId rowIdProject) {
			Debug.Assert(!rowIdProject.IsEmpty);
			this.CircuitProject = store;
			this.ProjectRowId = rowIdProject;
			// Link back to record. Assuming that a transaction is started
			this.Table.SetField(this.ProjectRowId, ProjectData.ProjectField.Field, this);
			this.InitializeProject();
		}

		partial void InitializeProject();

		// Gets table storing this item.
		private TableSnapshot<ProjectData> Table { get { return this.CircuitProject.ProjectSet.Table; } }

		// Deletes object
		public virtual void Delete() {
			this.Table.Delete(this.ProjectRowId);
		}

		// Checks if the item is deleted
		public bool IsDeleted() {
			return this.Table.IsDeleted(this.ProjectRowId);
		}

		//Properties of Project

		// Gets value of the ProjectId field.
		public Guid ProjectId {
			get { return this.Table.GetField(this.ProjectRowId, ProjectData.ProjectIdField.Field); }
		}

		// Gets or sets value of the Name field.
		public string Name {
			get { return this.Table.GetField(this.ProjectRowId, ProjectData.NameField.Field); }
			set { this.Table.SetField(this.ProjectRowId, ProjectData.NameField.Field, value); }
		}

		// Gets or sets value of the Description field.
		public string Description {
			get { return this.Table.GetField(this.ProjectRowId, ProjectData.DescriptionField.Field); }
			set { this.Table.SetField(this.ProjectRowId, ProjectData.DescriptionField.Field, value); }
		}

		// Gets or sets value of the Zoom field.
		public double Zoom {
			get { return this.Table.GetField(this.ProjectRowId, ProjectData.ZoomField.Field); }
			set { this.Table.SetField(this.ProjectRowId, ProjectData.ZoomField.Field, value); }
		}

		// Gets or sets value of the Frequency field.
		public int Frequency {
			get { return this.Table.GetField(this.ProjectRowId, ProjectData.FrequencyField.Field); }
			set { this.Table.SetField(this.ProjectRowId, ProjectData.FrequencyField.Field, value); }
		}

		// Gets or sets value of the IsMaximumSpeed field.
		public bool IsMaximumSpeed {
			get { return this.Table.GetField(this.ProjectRowId, ProjectData.IsMaximumSpeedField.Field); }
			set { this.Table.SetField(this.ProjectRowId, ProjectData.IsMaximumSpeedField.Field, value); }
		}

		// Gets or sets the value referred by the foreign key on field LogicalCircuitId
		public LogicalCircuit LogicalCircuit {
			get { return this.CircuitProject.LogicalCircuitSet.FindByLogicalCircuitId(this.Table.GetField(this.ProjectRowId, ProjectData.LogicalCircuitIdField.Field)); }
			set { this.Table.SetField(this.ProjectRowId, ProjectData.LogicalCircuitIdField.Field, value.LogicalCircuitId); }
		}

		// Gets or sets value of the CategoryTextNoteCollapsed field.
		public bool CategoryTextNoteCollapsed {
			get { return this.Table.GetField(this.ProjectRowId, ProjectData.CategoryTextNoteCollapsedField.Field); }
			set { this.Table.SetField(this.ProjectRowId, ProjectData.CategoryTextNoteCollapsedField.Field, value); }
		}

		// Gets or sets value of the CategoryInputOutputCollapsed field.
		public bool CategoryInputOutputCollapsed {
			get { return this.Table.GetField(this.ProjectRowId, ProjectData.CategoryInputOutputCollapsedField.Field); }
			set { this.Table.SetField(this.ProjectRowId, ProjectData.CategoryInputOutputCollapsedField.Field, value); }
		}

		// Gets or sets value of the CategoryPrimitivesCollapsed field.
		public bool CategoryPrimitivesCollapsed {
			get { return this.Table.GetField(this.ProjectRowId, ProjectData.CategoryPrimitivesCollapsedField.Field); }
			set { this.Table.SetField(this.ProjectRowId, ProjectData.CategoryPrimitivesCollapsedField.Field, value); }
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected void NotifyPropertyChanged(string name) {
			PropertyChangedEventHandler handler = this.PropertyChanged;
			if(handler != null) {
				handler(this, new PropertyChangedEventArgs(name));
			}
		}

		protected bool HasListener { get { return this.PropertyChanged != null; } }

		internal void NotifyChanged(TableChange<ProjectData> change) {
			if(this.HasListener) {
				ProjectData oldData, newData;
				change.GetOldData(out oldData);
				change.GetNewData(out newData);
				if(ProjectData.ProjectIdField.Field.Compare(ref oldData, ref newData) != 0) {
					this.NotifyPropertyChanged("ProjectId");
				}
				if(ProjectData.NameField.Field.Compare(ref oldData, ref newData) != 0) {
					this.NotifyPropertyChanged("Name");
				}
				if(ProjectData.DescriptionField.Field.Compare(ref oldData, ref newData) != 0) {
					this.NotifyPropertyChanged("Description");
				}
				if(ProjectData.ZoomField.Field.Compare(ref oldData, ref newData) != 0) {
					this.NotifyPropertyChanged("Zoom");
				}
				if(ProjectData.FrequencyField.Field.Compare(ref oldData, ref newData) != 0) {
					this.NotifyPropertyChanged("Frequency");
				}
				if(ProjectData.IsMaximumSpeedField.Field.Compare(ref oldData, ref newData) != 0) {
					this.NotifyPropertyChanged("IsMaximumSpeed");
				}
				if(ProjectData.LogicalCircuitIdField.Field.Compare(ref oldData, ref newData) != 0) {
					this.NotifyPropertyChanged("LogicalCircuit");
				}
				if(ProjectData.CategoryTextNoteCollapsedField.Field.Compare(ref oldData, ref newData) != 0) {
					this.NotifyPropertyChanged("CategoryTextNoteCollapsed");
				}
				if(ProjectData.CategoryInputOutputCollapsedField.Field.Compare(ref oldData, ref newData) != 0) {
					this.NotifyPropertyChanged("CategoryInputOutputCollapsed");
				}
				if(ProjectData.CategoryPrimitivesCollapsedField.Field.Compare(ref oldData, ref newData) != 0) {
					this.NotifyPropertyChanged("CategoryPrimitivesCollapsed");
				}
			}
			this.OnProjectChanged();
		}

		partial void OnProjectChanged();
	}


	// Wrapper for table Project.
	partial class ProjectSet : INotifyCollectionChanged, IEnumerable<Project> {

		public event NotifyCollectionChangedEventHandler CollectionChanged;

		internal TableSnapshot<ProjectData> Table { get; private set; }

		// Gets StoreSnapshot this set belongs to.
		public CircuitProject CircuitProject { get { return (CircuitProject)this.Table.StoreSnapshot; } }

		// Constructor
		public ProjectSet(CircuitProject store) {
			ITableSnapshot table = store.Table("Project");
			if(table != null) {
				Debug.Assert(store.IsFrozen, "The store should be frozen");
				this.Table = (TableSnapshot<ProjectData>)table;
			} else {
				Debug.Assert(!store.IsFrozen, "In order to create table, the store should not be frozen");
				this.Table = ProjectData.CreateTable(store);
			}
			this.InitializeProjectSet();
		}

		partial void InitializeProjectSet();

		//internal void Register() {
		//	foreach(RowId rowId in this.Table.Rows) {
		//		this.FindOrCreate(rowId);
		//	}
		//}


		// gets items wrapper by RowId
		public Project Find(RowId rowId) {
			if(!rowId.IsEmpty) {
				return this.Table.GetField(rowId, ProjectData.ProjectField.Field);
			}
			return null;
		}

		private void Delete(RowId rowId) {
		}

		// gets items wrapper by RowId
		private IEnumerable<Project> Select(IEnumerable<RowId> rows) {
			foreach(RowId rowId in rows) {
				Project item = this.Find(rowId);
				Debug.Assert(item != null, "What is the reason for the item not to be found?");
				yield return item;
			}
		}

		// Create wrapper for the row and register it in the dictionary
		private Project Create(RowId rowId) {
			Project item = new Project(this.CircuitProject, rowId);
			return item;
		}

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling")]
		internal Project FindOrCreate(RowId rowId) {
			Debug.Assert(!rowId.IsEmpty && !this.Table.IsDeleted(rowId), "Bad RowId");
			Project item;
			if((item = this.Find(rowId)) != null) {
				Debug.Assert(!item.IsDeleted(), "Deleted item should not be present in the dictionary");
				return item;
			}

			return this.Create(rowId);
		}

		// Creates Project wrapper
		private Project CreateItem(
			// Fields of Project table
			Guid ProjectId,
			string Name,
			string Description,
			double Zoom,
			int Frequency,
			bool IsMaximumSpeed,
			LogicalCircuit LogicalCircuit,
			bool CategoryTextNoteCollapsed,
			bool CategoryInputOutputCollapsed,
			bool CategoryPrimitivesCollapsed
		) {
			ProjectData dataProject = new ProjectData() {
				ProjectId = ProjectId,
				Name = Name,
				Description = Description,
				Zoom = Zoom,
				Frequency = Frequency,
				IsMaximumSpeed = IsMaximumSpeed,
				LogicalCircuitId = (LogicalCircuit != null) ? LogicalCircuit.LogicalCircuitId : ProjectData.LogicalCircuitIdField.Field.DefaultValue,
				CategoryTextNoteCollapsed = CategoryTextNoteCollapsed,
				CategoryInputOutputCollapsed = CategoryInputOutputCollapsed,
				CategoryPrimitivesCollapsed = CategoryPrimitivesCollapsed,
			};
			return this.Create(this.Table.Insert(ref dataProject));
		}

		// Search helpers

		// Finds Project by ProjectId
		public Project Find(Guid projectId) {
			return this.Find(this.Table.Find(ProjectData.ProjectIdField.Field, projectId));
		}

		// Selects Project by LogicalCircuit
		public IEnumerable<Project> SelectByLogicalCircuit(LogicalCircuit logicalCircuit) {
			return this.Select(this.Table.Select(ProjectData.LogicalCircuitIdField.Field, logicalCircuit.LogicalCircuitId));
		}

		public IEnumerator<Project> GetEnumerator() {
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

		internal List<Project> UpdateSet(int oldVersion, int newVersion) {
			IEnumerator<TableChange<ProjectData>> change = this.Table.GetVersionChangeChanges(oldVersion, newVersion);
			if(change != null) {
				bool handlerAttached = (this.CollectionChanged != null);
				List<Project> del = (handlerAttached) ? new List<Project>() : null;
				while(change.MoveNext()) {
					switch(change.Current.Action) {
					case SnapTableAction.Insert:
						this.FindOrCreate(change.Current.RowId);
						Debug.Assert(this.Find(change.Current.RowId) != null, "Why the item was not created?");
						break;
					case SnapTableAction.Delete:
						if(handlerAttached) {
							Project item = change.Current.GetOldField(ProjectData.ProjectField.Field);
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

		internal void NotifyVersionChanged(int oldVersion, int newVersion, List<Project> deleted) {
			IEnumerator<TableChange<ProjectData>> change = this.Table.GetVersionChangeChanges(oldVersion, newVersion);
			if(change != null) {
				bool handlerAttached = (this.CollectionChanged != null);
				List<Project> add = (handlerAttached) ? new List<Project>() : null;
				this.StartNotifyProjectSetChanged(oldVersion, newVersion);
				while(change.MoveNext()) {
					this.NotifyProjectSetChanged(change.Current);
					switch(change.Current.Action) {
					case SnapTableAction.Insert:
						Debug.Assert(this.Find(change.Current.RowId) != null, "Why the item was not created?");
						if(handlerAttached) {
							add.Add(this.Find(change.Current.RowId));
						}
						break;
					case SnapTableAction.Delete:
						Debug.Assert(change.Current.GetOldField(ProjectData.ProjectField.Field).IsDeleted(), "Why the item still exists?");
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
				this.EndNotifyProjectSetChanged();
			}
		}

		partial void StartNotifyProjectSetChanged(int oldVersion, int newVersion);
		partial void EndNotifyProjectSetChanged();
		partial void NotifyProjectSetChanged(TableChange<ProjectData> change);

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
