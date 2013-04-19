﻿using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Windows;
using System.Xml;
using LogicCircuit.DataPersistent;

namespace LogicCircuit {
	public partial class Splitter {
		public override void Delete() {
			this.CircuitProject.DevicePinSet.DeleteAllPins(this);
			base.Delete();
		}

		public override string Name {
			get { return Properties.Resources.NameSplitter; }
			set { throw new NotSupportedException(); }
		}

		public override string Notation {
			get { return this.Name; }
			set { throw new InvalidOperationException(); }
		}

		public override string ToolTip {
			get { return Properties.Resources.ToolTipSplitter(this.BitWidth, this.PinCount); }
		}

		public override string Category {
			get { return Properties.Resources.CategoryInputOutput; }
			set { throw new InvalidOperationException(); }
		}

		public override Circuit CopyTo(LogicalCircuit target) {
			return target.CircuitProject.SplitterSet.Copy(this);
		}

		protected override int CircuitSymbolWidth(int defaultWidth) {
			Tracer.Assert(defaultWidth == 1);
			return 1;
		}

		protected override int CircuitSymbolHeight(int defaultHeight) {
			Tracer.Assert(defaultHeight == this.PinCount + 1);
			return base.CircuitSymbolHeight(defaultHeight);
		}

		public override FrameworkElement CreateGlyph(CircuitGlyph symbol) {
			return symbol.CreateSimpleGlyph(SymbolShape.Splitter);
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
	public sealed partial class SplitterSet {
		private Splitter Register(RowId rowId) {
			CircuitData data = new CircuitData() {
				CircuitId = this.Table.GetField(rowId, SplitterData.SplitterIdField.Field)
			};
			Splitter splitter = this.Create(rowId, this.CircuitProject.CircuitTable.Insert(ref data));
			this.CreatePins(splitter);
			return splitter;
		}

		private void CreatePins(Splitter splitter) {
			// The order of creation of the pins is essential for expansion algorithm (CircuitMap.Connect).
			// The wide pin should go first and then thin pins starting from lower bits to higher
			Tracer.Assert(!this.CircuitProject.DevicePinSet.SelectByCircuit(splitter).Any());
			if(splitter.PinCount < 2) {
				splitter.PinCount = 2;
			}
			if(splitter.BitWidth < splitter.PinCount) {
				splitter.BitWidth = splitter.PinCount;
			}
			DevicePin pin = this.CircuitProject.DevicePinSet.Create(splitter, PinType.None, splitter.BitWidth);
			pin.Name = Properties.Resources.SplitterWidePinName;
			PinSide pinSide;
			if(splitter.Clockwise) {
				pinSide = PinSide.Right;
				pin.PinSide = PinSide.Left;
			} else {
				pinSide = PinSide.Left;
				pin.PinSide = PinSide.Right;
			}
			int pinWidth = splitter.BitWidth / splitter.PinCount;
			int rem = splitter.BitWidth % splitter.PinCount;
			for(int i = 0; i < rem; i++) {
				pin = this.CircuitProject.DevicePinSet.Create(splitter, PinType.None, pinWidth + 1);
				pin.PinSide = pinSide;
				SplitterSet.SetName(pin, i * (pinWidth + 1), pinWidth + 1);
			}
			for(int i = rem; i < splitter.PinCount; i++) {
				pin = this.CircuitProject.DevicePinSet.Create(splitter, PinType.None, pinWidth);
				pin.PinSide = pinSide;
				SplitterSet.SetName(pin, i * pinWidth + rem, pinWidth);
			}
		}

		private static void SetName(DevicePin pin, int firstBit, int pinWidth) {
			if(pinWidth == 1) {
				pin.Name = Properties.Resources.SplitterThin1PinName(firstBit);
			} else {
				pin.Name = Properties.Resources.SplitterThin2PinName(firstBit, firstBit + pinWidth - 1);
			}
		}

		public Splitter Create(int bitWidth, int pinCount, bool clockwise) {
			Splitter splitter = this.CreateItem(Guid.NewGuid(), bitWidth, pinCount, clockwise);
			this.CreatePins(splitter);
			return splitter;
		}

		public Splitter Copy(Splitter other) {
			SplitterData data;
			other.CircuitProject.SplitterSet.Table.GetData(other.SplitterRowId, out data);
			if(this.FindBySplitterId(data.SplitterId) != null) {
				data.SplitterId = Guid.NewGuid();
			}
			data.Splitter = null;
			return this.Register(this.Table.Insert(ref data));
		}

		public IRecordLoader CreateRecordLoader(XmlNameTable nameTable) {
			return new RecordLoader<SplitterData>(nameTable, this.Table, rowId => this.Register(rowId));
		}
	}
}
