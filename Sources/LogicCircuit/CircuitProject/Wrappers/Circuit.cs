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

	// Defines the shape of the table Circuit
	internal partial struct CircuitData {
		public Guid CircuitId;
		internal Circuit Circuit;
		// Field accessors
		// Accessor of the CircuitId field
		public sealed class CircuitIdField : IField<CircuitData, Guid> {
			public static readonly CircuitIdField Field = new CircuitIdField();
			private CircuitIdField() {}
			public string Name { get { return "CircuitId"; } }
			public int Order { get; set; }
			public Guid DefaultValue { get { return default(Guid); } }
			public Guid GetValue(ref CircuitData record) {
				return record.CircuitId;
			}
			public void SetValue(ref CircuitData record, Guid value) {
				record.CircuitId = value;
			}
			public int Compare(ref CircuitData l, ref CircuitData r) {
				return l.CircuitId.CompareTo(r.CircuitId);
			}
			public int Compare(Guid l, Guid r) {
				return l.CompareTo(r);
			}
		}

		// Special field used to access items wrapper of this record from record.
		// This is used when no other universes is used
		internal sealed class CircuitField : IField<CircuitData, Circuit> {
			public static readonly CircuitField Field = new CircuitField();
			private CircuitField() {}
			public string Name { get { return "CircuitWrapper"; } }
			public int Order { get; set; }
			public Circuit DefaultValue { get { return null; } }
			public Circuit GetValue(ref CircuitData record) {
				return record.Circuit;
			}
			public void SetValue(ref CircuitData record, Circuit value) {
				record.Circuit = value;
			}
			public int Compare(ref CircuitData l, ref CircuitData r) {
				return this.Compare(l.Circuit, r.Circuit);
			}
			public int Compare(Circuit l, Circuit r) {
				if(object.ReferenceEquals(l, r)) return 0;
				if(l == null) return -1;
				if(r == null) return 1;
				return l.CircuitRowId.CompareTo(r.CircuitRowId);
			}
		}

		private static IField<CircuitData>[] fields = {
			CircuitIdField.Field,
			CircuitField.Field
		};

		// Creates table.
		public static TableSnapshot<CircuitData> CreateTable(StoreSnapshot store) {
			TableSnapshot<CircuitData> table = new TableSnapshot<CircuitData>(store, "Circuit", CircuitData.fields);
			// Create all but foreign keys of the table
			table.MakeUnique("PK_Circuit", CircuitData.CircuitIdField.Field , true);
			// Return created table
			return table;
		}

		// Creates all foreign keys of the table
		public static void CreateForeignKeys(StoreSnapshot store) {
		}
	}

	// Class wrapper for a record.
	abstract partial class Circuit : INotifyPropertyChanged {

		// RowId of the wrapped record
		internal RowId CircuitRowId { get; private set; }
		// Store this wrapper belongs to
		public CircuitProject CircuitProject { get; private set; }

		// Constructor
		protected Circuit(CircuitProject store, RowId rowIdCircuit) {
			Debug.Assert(!rowIdCircuit.IsEmpty);
			this.CircuitProject = store;
			this.CircuitRowId = rowIdCircuit;
			// Link back to record. Assuming that a transaction is started
			this.Table.SetField(this.CircuitRowId, CircuitData.CircuitField.Field, this);
			this.InitializeCircuit();
		}

		partial void InitializeCircuit();

		// Gets table storing this item.
		private TableSnapshot<CircuitData> Table { get { return this.CircuitProject.CircuitSet.Table; } }

		// Deletes object
		public virtual void Delete() {
			this.Table.Delete(this.CircuitRowId);
		}

		// Checks if the item is deleted
		public bool IsDeleted() {
			return this.Table.IsDeleted(this.CircuitRowId);
		}

		//Properties of Circuit

		// Gets value of the CircuitId field.
		public Guid CircuitId {
			get { return this.Table.GetField(this.CircuitRowId, CircuitData.CircuitIdField.Field); }
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected void NotifyPropertyChanged(string name) {
			PropertyChangedEventHandler handler = this.PropertyChanged;
			if(handler != null) {
				handler(this, new PropertyChangedEventArgs(name));
			}
		}

		protected bool HasListener { get { return this.PropertyChanged != null; } }

		internal void NotifyChanged(TableChange<CircuitData> change) {
			if(this.HasListener) {
				CircuitData oldData, newData;
				change.GetOldData(out oldData);
				change.GetNewData(out newData);
				if(CircuitData.CircuitIdField.Field.Compare(ref oldData, ref newData) != 0) {
					this.NotifyPropertyChanged("CircuitId");
				}
			}
			this.OnCircuitChanged();
		}

		partial void OnCircuitChanged();
	}


	// Wrapper for table Circuit.
	partial class CircuitSet : INotifyCollectionChanged, IEnumerable<Circuit> {

		public event NotifyCollectionChangedEventHandler CollectionChanged;

		internal TableSnapshot<CircuitData> Table { get; private set; }

		// Gets StoreSnapshot this set belongs to.
		public CircuitProject CircuitProject { get { return (CircuitProject)this.Table.StoreSnapshot; } }

		// Constructor
		public CircuitSet(CircuitProject store) {
			ITableSnapshot table = store.Table("Circuit");
			if(table != null) {
				Debug.Assert(store.IsFrozen, "The store should be frozen");
				this.Table = (TableSnapshot<CircuitData>)table;
			} else {
				Debug.Assert(!store.IsFrozen, "In order to create table, the store should not be frozen");
				this.Table = CircuitData.CreateTable(store);
			}
			this.InitializeCircuitSet();
		}

		partial void InitializeCircuitSet();

		//internal void Register() {
		//	foreach(RowId rowId in this.Table.Rows) {
		//		this.FindOrCreate(rowId);
		//	}
		//}


		// gets items wrapper by RowId
		public Circuit Find(RowId rowId) {
			if(!rowId.IsEmpty) {
				return this.Table.GetField(rowId, CircuitData.CircuitField.Field);
			}
			return null;
		}


		// gets items wrapper by RowId
		private IEnumerable<Circuit> Select(IEnumerable<RowId> rows) {
			foreach(RowId rowId in rows) {
				Circuit item = this.Find(rowId);
				Debug.Assert(item != null, "What is the reason for the item not to be found?");
				yield return item;
			}
		}

		// Create wrapper for the row and register it in the dictionary
		private Circuit Create(RowId rowId) {
			throw new InvalidOperationException();
		}

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling")]
		internal Circuit FindOrCreate(RowId rowId) {
			Debug.Assert(!rowId.IsEmpty && !this.Table.IsDeleted(rowId), "Bad RowId");
			Circuit item;
			if((item = this.Find(rowId)) != null) {
				Debug.Assert(!item.IsDeleted(), "Deleted item should not be present in the dictionary");
				return item;
			}
			Guid primaryKeyValue = this.Table.GetField(rowId, CircuitData.CircuitIdField.Field);

			RowId rowIdDevicePin = this.CircuitProject.DevicePinSet.Table.Find(DevicePinData.PinIdField.Field, primaryKeyValue);
			if(!rowIdDevicePin.IsEmpty) {
				return this.CircuitProject.DevicePinSet.FindOrCreate(rowIdDevicePin);
			}

			RowId rowIdGate = this.CircuitProject.GateSet.Table.Find(GateData.GateIdField.Field, primaryKeyValue);
			if(!rowIdGate.IsEmpty) {
				return this.CircuitProject.GateSet.FindOrCreate(rowIdGate);
			}

			RowId rowIdLogicalCircuit = this.CircuitProject.LogicalCircuitSet.Table.Find(LogicalCircuitData.LogicalCircuitIdField.Field, primaryKeyValue);
			if(!rowIdLogicalCircuit.IsEmpty) {
				return this.CircuitProject.LogicalCircuitSet.FindOrCreate(rowIdLogicalCircuit);
			}

			RowId rowIdPin = this.CircuitProject.PinSet.Table.Find(PinData.PinIdField.Field, primaryKeyValue);
			if(!rowIdPin.IsEmpty) {
				return this.CircuitProject.PinSet.FindOrCreate(rowIdPin);
			}

			RowId rowIdCircuitProbe = this.CircuitProject.CircuitProbeSet.Table.Find(CircuitProbeData.CircuitProbeIdField.Field, primaryKeyValue);
			if(!rowIdCircuitProbe.IsEmpty) {
				return this.CircuitProject.CircuitProbeSet.FindOrCreate(rowIdCircuitProbe);
			}

			RowId rowIdConstant = this.CircuitProject.ConstantSet.Table.Find(ConstantData.ConstantIdField.Field, primaryKeyValue);
			if(!rowIdConstant.IsEmpty) {
				return this.CircuitProject.ConstantSet.FindOrCreate(rowIdConstant);
			}

			RowId rowIdCircuitButton = this.CircuitProject.CircuitButtonSet.Table.Find(CircuitButtonData.CircuitButtonIdField.Field, primaryKeyValue);
			if(!rowIdCircuitButton.IsEmpty) {
				return this.CircuitProject.CircuitButtonSet.FindOrCreate(rowIdCircuitButton);
			}

			RowId rowIdMemory = this.CircuitProject.MemorySet.Table.Find(MemoryData.MemoryIdField.Field, primaryKeyValue);
			if(!rowIdMemory.IsEmpty) {
				return this.CircuitProject.MemorySet.FindOrCreate(rowIdMemory);
			}

			RowId rowIdLedMatrix = this.CircuitProject.LedMatrixSet.Table.Find(LedMatrixData.LedMatrixIdField.Field, primaryKeyValue);
			if(!rowIdLedMatrix.IsEmpty) {
				return this.CircuitProject.LedMatrixSet.FindOrCreate(rowIdLedMatrix);
			}

			RowId rowIdSplitter = this.CircuitProject.SplitterSet.Table.Find(SplitterData.SplitterIdField.Field, primaryKeyValue);
			if(!rowIdSplitter.IsEmpty) {
				return this.CircuitProject.SplitterSet.FindOrCreate(rowIdSplitter);
			}

			RowId rowIdSensor = this.CircuitProject.SensorSet.Table.Find(SensorData.SensorIdField.Field, primaryKeyValue);
			if(!rowIdSensor.IsEmpty) {
				return this.CircuitProject.SensorSet.FindOrCreate(rowIdSensor);
			}

			RowId rowIdSound = this.CircuitProject.SoundSet.Table.Find(SoundData.SoundIdField.Field, primaryKeyValue);
			if(!rowIdSound.IsEmpty) {
				return this.CircuitProject.SoundSet.FindOrCreate(rowIdSound);
			}

			return this.Create(rowId);
		}

		// Creates Circuit wrapper
		private Circuit CreateItem(
			// Fields of Circuit table
			Guid CircuitId
		) {
			CircuitData dataCircuit = new CircuitData() {
				CircuitId = CircuitId,
			};
			return this.Create(this.Table.Insert(ref dataCircuit));
		}

		// Search helpers

		// Finds Circuit by CircuitId
		public Circuit Find(Guid circuitId) {
			return this.Find(this.Table.Find(CircuitData.CircuitIdField.Field, circuitId));
		}

		public IEnumerator<Circuit> GetEnumerator() {
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

		internal List<Circuit> UpdateSet(int oldVersion, int newVersion) {
			IEnumerator<TableChange<CircuitData>> change = this.Table.GetVersionChangeChanges(oldVersion, newVersion);
			if(change != null) {
				bool handlerAttached = (this.CollectionChanged != null);
				List<Circuit> del = (handlerAttached) ? new List<Circuit>() : null;
				while(change.MoveNext()) {
					switch(change.Current.Action) {
					case SnapTableAction.Insert:
						this.FindOrCreate(change.Current.RowId);
						Debug.Assert(this.Find(change.Current.RowId) != null, "Why the item was not created?");
						break;
					case SnapTableAction.Delete:
						if(handlerAttached) {
							Circuit item = change.Current.GetOldField(CircuitData.CircuitField.Field);
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

		internal void NotifyVersionChanged(int oldVersion, int newVersion, List<Circuit> deleted) {
			IEnumerator<TableChange<CircuitData>> change = this.Table.GetVersionChangeChanges(oldVersion, newVersion);
			if(change != null) {
				bool handlerAttached = (this.CollectionChanged != null);
				List<Circuit> add = (handlerAttached) ? new List<Circuit>() : null;
				this.StartNotifyCircuitSetChanged(oldVersion, newVersion);
				while(change.MoveNext()) {
					this.NotifyCircuitSetChanged(change.Current);
					switch(change.Current.Action) {
					case SnapTableAction.Insert:
						Debug.Assert(this.Find(change.Current.RowId) != null, "Why the item was not created?");
						if(handlerAttached) {
							add.Add(this.Find(change.Current.RowId));
						}
						break;
					case SnapTableAction.Delete:
						Debug.Assert(change.Current.GetOldField(CircuitData.CircuitField.Field).IsDeleted(), "Why the item still exists?");
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
				this.EndNotifyCircuitSetChanged();
			}
		}

		partial void StartNotifyCircuitSetChanged(int oldVersion, int newVersion);
		partial void EndNotifyCircuitSetChanged();
		partial void NotifyCircuitSetChanged(TableChange<CircuitData> change);

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
