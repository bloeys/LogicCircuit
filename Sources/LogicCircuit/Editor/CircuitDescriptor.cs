﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows;

namespace LogicCircuit {
	public interface IDescriptor {
		Circuit Circuit { get; }
		string Category { get; }
		void CreateSymbol(EditorDiagram editor, GridPoint point);
	}

	public abstract class Descriptor {
		public abstract bool CategoryExpanded { get; set; }

		protected static CircuitProject CircuitProject {
			get {
				Mainframe mainframe = App.Mainframe;
				if(mainframe != null) {
					Editor editor = mainframe.Editor;
					if(editor != null) {
						return editor.CircuitProject;
					}
				}
				return null;
			}
		}
	}

	public abstract class CircuitDescriptor<T> : Descriptor, IDescriptor, INotifyPropertyChanged where T:Circuit {
		public event PropertyChangedEventHandler PropertyChanged;

		public T Circuit { get; private set; }
		Circuit IDescriptor.Circuit { get { return this.Circuit; } }
		public CircuitGlyph CircuitGlyph { get; private set; }

		public string Category { get; set; }

		protected abstract T GetCircuitToDrop(CircuitProject circuitProject);

		public void CreateSymbol(EditorDiagram editor, GridPoint point) {
			CircuitProject project = editor.CircuitProject;
			project.InTransaction(() => project.CircuitSymbolSet.Create(this.GetCircuitToDrop(project), editor.Project.LogicalCircuit, point.X, point.Y));
		}

		protected CircuitDescriptor(T circuit) {
			this.Circuit = circuit;
			this.Category = circuit.Category;
			this.CircuitGlyph = new CircuitDescriptorGlyph(this);
		}

		public void ResetGlyph() {
			this.CircuitGlyph.ResetJams();
			this.CircuitGlyph.Invalidate();
		}

		protected void NotifyPropertyChanged(string propertyName) {
			PropertyChangedEventHandler handler = this.PropertyChanged;
			if(handler != null) {
				handler(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		private class CircuitDescriptorGlyph : CircuitGlyph {
			private readonly CircuitDescriptor<T> circuitDescriptor;

			public CircuitDescriptorGlyph(CircuitDescriptor<T> circuitDescriptor) {
				this.circuitDescriptor = circuitDescriptor;
			}
			protected override Circuit SymbolCircuit { get { return this.circuitDescriptor.Circuit; } }
			protected override LogicalCircuit SymbolLogicalCircuit { get { throw new InvalidOperationException(); } set { throw new InvalidOperationException(); } }
			public override void Shift(int dx, int dy) { throw new InvalidOperationException(); }
			public override GridPoint Point {
				get { return new GridPoint(0, 0); }
				set { throw new InvalidOperationException(); }
			}
			public override int Z { get { return 0; } }

			public override void PositionGlyph() {
				throw new InvalidOperationException();
			}

			public override void DeleteSymbol() {
				throw new InvalidOperationException();
			}

			public override Symbol CopyTo(LogicalCircuit target) {
				throw new InvalidOperationException();
			}

			public override void Invalidate() {
				this.Reset();
				this.NotifyPropertyChanged("Glyph");
			}
		}
	}

	public abstract class PrimitiveCircuitDescriptor<T> : CircuitDescriptor<T> where T:Circuit {
		protected  PrimitiveCircuitDescriptor(T circuit) : base(circuit) {
		}

		public override bool CategoryExpanded {
			get {
				CircuitProject circuitProject = Descriptor.CircuitProject;
				if(circuitProject != null) {
					return !circuitProject.ProjectSet.Project.CategoryPrimitivesCollapsed;
				}
				return true;
			}
			set {
				CircuitProject circuitProject = Descriptor.CircuitProject;
				if(circuitProject != null) {
					Project project = circuitProject.ProjectSet.Project;
					if(value != (!project.CategoryPrimitivesCollapsed)) {
						circuitProject.InOmitTransaction(() => project.CategoryPrimitivesCollapsed = !value);
					}
				}
			}
		}
	}

	public abstract class IOCircuitDescriptor<T> : CircuitDescriptor<T> where T:Circuit {
		protected  IOCircuitDescriptor(T circuit) : base(circuit) {
		}

		public override bool CategoryExpanded {
			get {
				CircuitProject circuitProject = Descriptor.CircuitProject;
				if(circuitProject != null) {
					return !circuitProject.ProjectSet.Project.CategoryInputOutputCollapsed;
				}
				return true;
			}
			set {
				CircuitProject circuitProject = Descriptor.CircuitProject;
				if(circuitProject != null) {
					Project project = circuitProject.ProjectSet.Project;
					if(value != (!project.CategoryInputOutputCollapsed)) {
						circuitProject.InOmitTransaction(() => project.CategoryInputOutputCollapsed = !value);
					}
				}
			}
		}
	}

	public class GateDescriptor : PrimitiveCircuitDescriptor<Gate> {
		private static readonly int[] inputCountRange = PinDescriptor.NumberRange(2, Gate.MaxInputCount);
		
		public int InputCount { get; set; }
		public IEnumerable<int> InputCountRange { get; private set; }
		public int InputCountRangeLength { get; private set; }

		public GateDescriptor(Gate gate) : base(gate) {
			switch(gate.GateType) {
			case GateType.Clock:
			case GateType.Not:
			case GateType.Led:
			case GateType.Probe:
			case GateType.TriState:
				this.InputCountRangeLength = 0;
				break;
			case GateType.Or:
			case GateType.And:
			case GateType.Xor:
			case GateType.Odd:
			case GateType.Even:
				this.InputCountRange = GateDescriptor.inputCountRange;
				this.InputCountRangeLength = GateDescriptor.inputCountRange.Length;
				break;
			default:
				Tracer.Fail();
				break;
			}
			this.InputCount = gate.InputCount;
		}

		protected override Gate GetCircuitToDrop(CircuitProject circuitProject) {
			return circuitProject.GateSet.Gate(this.Circuit.GateType, this.InputCount, this.Circuit.InvertedOutput);
		}
	}

	public class ButtonDescriptor : IOCircuitDescriptor<CircuitButton> {
		public string Notation { get; set; }
		public bool IsToggle { get; set; }

		public ButtonDescriptor(CircuitProject circuitProject) : base(circuitProject.CircuitButtonSet.Create(string.Empty, false)) {
			this.Notation = string.Empty;
		}

		protected override CircuitButton GetCircuitToDrop(CircuitProject circuitProject) {
			string notation = (this.Notation ?? string.Empty).Trim();
			if(!string.IsNullOrEmpty(notation)) {
				this.Notation = string.Empty;
				this.NotifyPropertyChanged("Notation");
			}
			return circuitProject.CircuitButtonSet.Create(notation, this.IsToggle);
		}
	}

	public class ConstantDescriptor : IOCircuitDescriptor<Constant> {
		public int BitWidth { get; set; }
		public string Value { get; set; }

		public ConstantDescriptor(CircuitProject circuitProject) : base(circuitProject.ConstantSet.Create(1, 0)) {
			this.BitWidth = 1;
			this.Value = "0";
		}

		protected override Constant GetCircuitToDrop(CircuitProject circuitProject) {
			int value;
			if(!int.TryParse(this.Value, NumberStyles.HexNumber, Resources.Culture, out value)) {
				value = 0;
			}
			return circuitProject.ConstantSet.Create(this.BitWidth, value);
		}
	}

	public class MemoryDescriptor : PrimitiveCircuitDescriptor<Memory> {
		private static readonly int[] addressBitWidthRange = PinDescriptor.AddressBitRange();

		public static IEnumerable<int> AddressBitWidthRange { get { return MemoryDescriptor.addressBitWidthRange; } }

		public int AddressBitWidth { get; set; }
		public int DataBitWidth { get; set; }

		public MemoryDescriptor(CircuitProject circuitProject, bool writable) : base(circuitProject.MemorySet.Create(writable, 1, 1)) {
			this.AddressBitWidth = 1;
			this.DataBitWidth = 1;
		}

		protected override Memory GetCircuitToDrop(CircuitProject circuitProject) {
			return circuitProject.MemorySet.Create(this.Circuit.Writable, this.AddressBitWidth, this.DataBitWidth);
		}
	}

	public class LedMatrixDescriptor : IOCircuitDescriptor<LedMatrix> {
		private static readonly IEnumerable<string> matrixTypeNames = new string[] { Resources.LedMatrixTypeIndividual, Resources.LedMatrixTypeSelector };
		public static IEnumerable<string> MatrixTypeNames { get { return LedMatrixDescriptor.matrixTypeNames; } }

		private static readonly IEnumerable<int> ledRange = PinDescriptor.NumberRange(LedMatrix.MinLedCount, LedMatrix.MaxLedCount);
		public static IEnumerable<int> RowsRange { get { return LedMatrixDescriptor.ledRange; } }
		public static IEnumerable<int> ColumnsRange { get { return LedMatrixDescriptor.ledRange; } }

		public int Rows { get; set; }
		public int Columns { get; set; }
		public int MatrixType { get; set; }

		public LedMatrixDescriptor(CircuitProject circuitProject) : base(circuitProject.LedMatrixSet.Create(LedMatrixType.Individual, 4, 4)) {
			this.Rows = 4;
			this.Columns = 4;
		}

		protected override LedMatrix GetCircuitToDrop(CircuitProject circuitProject) {
			return circuitProject.LedMatrixSet.Create((LedMatrixType)this.MatrixType, this.Rows, this.Columns);
		}
	}

	public class PinDescriptor : IOCircuitDescriptor<Pin> {
		private static readonly string[] pinSideRange = new string[] { Resources.PinSideLeft, Resources.PinSideTop, Resources.PinSideRight, Resources.PinSideBottom };
		private static readonly int[] bitWidthRange = PinDescriptor.NumberRange(1);

		public static IEnumerable<string> PinSideRange { get { return PinDescriptor.pinSideRange; } }
		public static IEnumerable<int> BitWidthRange { get { return PinDescriptor.bitWidthRange; } }

		public int BitWidth { get; set; }
		public int PinSide { get; set; }

		public PinDescriptor(CircuitProject circuitProject, PinType pinType) : base(
			circuitProject.PinSet.Create(circuitProject.ProjectSet.Project.LogicalCircuit, pinType, 1)
		) {
			this.BitWidth = 1;
			this.PinSide = (int)((pinType == PinType.Input) ? LogicCircuit.PinSide.Left : LogicCircuit.PinSide.Right);
		}

		protected override Pin GetCircuitToDrop(CircuitProject circuitProject) {
			Pin pin = circuitProject.PinSet.Create(circuitProject.ProjectSet.Project.LogicalCircuit, this.Circuit.PinType, this.BitWidth);
			pin.PinSide = (PinSide)this.PinSide;
			return pin;
		}

		public static int[] NumberRange(int minBitWidth, int maxBitWidth) {
			Tracer.Assert(0 < minBitWidth && minBitWidth < maxBitWidth);
			int[] range = new int[maxBitWidth - minBitWidth + 1];
			for(int i = 0; i < range.Length; i++) {
				range[i] = i + minBitWidth;
			}
			return range;
		}

		public static int[] NumberRange(int minBitWidth) {
			return PinDescriptor.NumberRange(minBitWidth, BasePin.MaxBitWidth);
		}

		public static int[] AddressBitRange() {
			return PinDescriptor.NumberRange(1, Memory.MaxAddressBitWidth);
		}
	}

	public class SplitterDescriptor : IOCircuitDescriptor<Splitter> {
		public int BitWidth { get; set; }
		public int PinCount { get; set; }
		private int direction;
		public int Direction {
			get { return this.direction; }
			set {
				this.direction = value;
				this.NotifyPropertyChanged("Flip");
			}
		}

		public double Flip { get { return this.Direction == 0 ? 1 : -1; } }

		public IEnumerable<int> BitWidthRange { get; private set; }
		public IEnumerable<int> PinCountRange { get; private set; }
		public IEnumerable<string> DirectionRange { get; private set; }

		public SplitterDescriptor(CircuitProject circuitProject) : base(circuitProject.SplitterSet.Create(3, 3, true)) {
			this.PinCount = 3;
			this.BitWidth = 1;
			this.Direction = 0;
			this.PinCountRange = PinDescriptor.NumberRange(2, Gate.MaxInputCount);
			this.BitWidthRange = PinDescriptor.NumberRange(1, BasePin.MaxBitWidth / 2);
			this.DirectionRange = new string[] { Resources.SplitterDirectionClockwise, Resources.SplitterDirectionCounterclockwise };
		}

		protected override Splitter GetCircuitToDrop(CircuitProject circuitProject) {
			return circuitProject.SplitterSet.Create(this.BitWidth * this.PinCount, this.PinCount, this.Direction == 0);
		}
	}

	public class LogicalCircuitDescriptor : CircuitDescriptor<LogicalCircuit> {
		public LogicalCircuitDescriptor(LogicalCircuit logicalCircuit, Predicate<string> isReserved) : base(logicalCircuit) {
			if(isReserved(logicalCircuit.Category)) {
				this.Category = Resources.CategoryDuplicate(logicalCircuit.Category);
			}
		}

		public bool IsCurrent { get { return this.Circuit == this.Circuit.CircuitProject.ProjectSet.Project.LogicalCircuit; } }

		protected override LogicalCircuit GetCircuitToDrop(CircuitProject circuitProject) {
			return this.Circuit;
		}

		public void NotifyCurrentChanged() {
			this.NotifyPropertyChanged("IsCurrent");
		}

		public override bool CategoryExpanded {
			get {
				CircuitProject circuitProject = this.Circuit.CircuitProject;
				if(circuitProject != null) {
					return !circuitProject.CollapsedCategorySet.IsCollapsed(this.Circuit.Category);
				}
				return true;
			}
			set {
				CircuitProject circuitProject = this.Circuit.CircuitProject;
				if(circuitProject != null) {
					circuitProject.CollapsedCategorySet.SetCollapsed(this.Circuit.Category, !value);
				}
			}
		}
	}

	public class TextNoteDescriptor : Descriptor, IDescriptor {

		public Circuit Circuit { get; private set; }
		public string Category { get { return this.Circuit.Category; } }
		public override bool CategoryExpanded {
			get {
				CircuitProject circuitProject = Descriptor.CircuitProject;
				if(circuitProject != null) {
					return !circuitProject.ProjectSet.Project.CategoryTextNoteCollapsed;
				}
				return true;
			}
			set {
				CircuitProject circuitProject = Descriptor.CircuitProject;
				if(circuitProject != null) {
					Project project = circuitProject.ProjectSet.Project;
					if(value != (!project.CategoryTextNoteCollapsed)) {
						circuitProject.InOmitTransaction(() => project.CategoryTextNoteCollapsed = !value);
					}
				}
			}
		}

		public TextNoteDescriptor(CircuitProject circuitProject) {
			// create dummy circuit to provide category and name for sorting and displaying in list of circuits descriptors
			LogicalCircuit circuit = circuitProject.LogicalCircuitSet.Create();
			circuit.Category = Resources.TextNotation;
			circuit.Name = Resources.TextNotation;
			this.Circuit = circuit;
		}

		public void CreateSymbol(EditorDiagram editor, GridPoint point) {
			CircuitProject project = editor.CircuitProject;
			DialogText dialog = new DialogText(null);
			bool? result = editor.Mainframe.ShowDialog(dialog);
			if(result.HasValue && result.Value && TextNote.IsValidText(dialog.Document)) {
				project.InTransaction(() => project.TextNoteSet.Create(editor.Project.LogicalCircuit, point, dialog.Document));
			}
		}
	}
}
