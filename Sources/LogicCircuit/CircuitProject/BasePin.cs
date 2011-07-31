﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LogicCircuit.DataPersistent;

namespace LogicCircuit {
	public abstract class BasePin : Circuit {

		public const int MaxBitWidth = 32;

		protected BasePin(CircuitProject store, RowId rowId) : base(store, rowId) {
		}

		public static int CheckBitWidth(int value) {
			return Math.Max(1, Math.Min(value, BasePin.MaxBitWidth));
		}

		public static PinSide DefaultSide(PinType pinType) {
			return (pinType == PinType.Input) ? PinSide.Left : PinSide.Right;
		}

		public static string DefaultName(PinType pinType) {
			return (pinType == PinType.Input) ? Resources.PinInName : Resources.PinOutName;
		}

		/// <summary>
		/// Gets or set precalculated position of jam of this pin on the circuit symbol.
		/// This is an optimization to get jams evaluated faster.
		/// </summary>
		public GridPoint GridPoint { get; set; }
		
		protected abstract Circuit PinCircuit { get; set; }
		private Circuit circuit;
		public Circuit Circuit {
			get {
				if(this.circuit == null) {
					this.circuit = this.PinCircuit;
				}
				return this.circuit;
			}
		}

		public abstract PinSide PinSide { get; set; }

		protected abstract PinType PinPinType { get; }
		private int pinType = -1;
		public PinType PinType {
			get {
				if(this.pinType < 0) {
					this.pinType = (int)this.PinPinType;
				}
				return (PinType)this.pinType;
			}
		}
		public abstract int BitWidth { get; set; }
		//public abstract string Name { get; set; }
		public abstract string Note { get; set; }
		public abstract bool Inverted { get; set; }
		public abstract string JamNotation { get; set; }

		public override string ToolTip {
			get {
				if(this.PinType == PinType.Input) {
					return this.AppendNote(Resources.ToolTipInputPin(this.BitWidth, this.Name));
				} else if(this.PinType == PinType.Output) {
					return this.AppendNote(Resources.ToolTipOutputPin(this.BitWidth, this.Name));
				} else {
					return this.AppendNote(Resources.ToolTipNonePin(this.BitWidth, this.Name));
				}
			}
		}

		public override string Category {
			get { return Resources.CategoryInputOutput; }
			set { throw new InvalidOperationException(); }
		}

		private string AppendNote(string toolTip) {
			string n = this.Note;
			if(!string.IsNullOrEmpty(n)) {
				return toolTip + "\n" + n;
			}
			return toolTip;
		}
	}
}
