﻿using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Xml;

namespace LogicCircuit {
	public partial class CircuitSymbol {

		public void DeleteSymbol() {
			if(this.Circuit is Gate || this.Circuit is LogicalCircuit) {
				this.Delete();
			} else {
				this.Circuit.Delete();
			}
		}

		partial void OnCircuitSymbolChanged() {
			Pin pin = this.Circuit as Pin;
			if(pin != null) {
				pin.LogicalCircuit.ResetPins();
			}
			this.PositionGlyph();
		}

		public override void Shift(int dx, int dy) {
			this.X += dx;
			this.Y += dy;
		}

		public override GridPoint Point {
			get { return new GridPoint(this.X, this.Y); }
			set { this.X = value.X; this.Y = value.Y; }
		}

		public override int Z { get { return 2; } }

		public override void PositionGlyph() {
			FrameworkElement glyph = this.Glyph;
			Canvas.SetLeft(glyph, Symbol.ScreenPoint(this.X));
			Canvas.SetTop(glyph, Symbol.ScreenPoint(this.Y));
		}

		public override void CopyTo(CircuitProject project) {
			project.CircuitSymbolSet.Copy(this);
		}

		public override void Invalidate() {
			this.CircuitProject.CircuitSymbolSet.Invalidate(this);
		}
	}

	public partial class CircuitSymbolSet {
		private HashSet<CircuitSymbol> invalid = new HashSet<CircuitSymbol>();

		public IEnumerable<CircuitSymbol> Invalid { get { return this.invalid; } }
		
		public void Invalidate(CircuitSymbol symbol) {
			this.invalid.Add(symbol);
		}

		public void ValidateAll() {
			this.invalid.Clear();
		}

		public void Load(XmlNodeList list) {
			CircuitSymbolData.Load(this.Table, list, rowId => this.Create(rowId));
		}

		public CircuitSymbol Create(Circuit circuit, LogicalCircuit logicalCircuit, int x, int y) {
			return this.CreateItem(Guid.NewGuid(), circuit, logicalCircuit, x, y);
		}

		public CircuitSymbol Copy(CircuitSymbol other) {
			CircuitSymbolData data;
			other.CircuitProject.CircuitSymbolSet.Table.GetData(other.CircuitSymbolRowId, out data);
			if(this.Find(data.CircuitSymbolId) != null) {
				data.CircuitSymbolId = Guid.NewGuid();
			}
			Circuit circuit = other.Circuit.CopyTo(this.CircuitProject);
			data.CircuitId = circuit.CircuitId;
			Pin pin = circuit as Pin;
			if(pin != null) {
				pin.Rebase(this.CircuitProject.LogicalCircuitSet.FindByLogicalCircuitId(data.LogicalCircuitId));
			}
			return this.Create(this.Table.Insert(ref data));
		}
	}
}
