﻿//-----------------------------------------------------------------------------
//
//	This code was generated by a ResourceWrapper.Generator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null.
//
//	Changes to this file may cause incorrect behavior and will be lost if
//	the code is regenerated.
//
//-----------------------------------------------------------------------------

namespace LogicCircuit {
	using System;

	/// <summary>
	/// A strongly-typed resource class, for looking up localized strings, etc.
	/// </summary>
	// This class was auto-generated.
	// To add or remove a member, edit your .ResX file then rerun MsBuild,
	// or rebuild your VS project.
	[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
	[global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
	public static class Resources {

		private static global::System.Resources.ResourceManager resourceManager;

		/// <summary>
		/// Returns the cached ResourceManager instance used by this class.
		/// </summary>
		[global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static global::System.Resources.ResourceManager ResourceManager {
			get {
				if(resourceManager == null) {
					resourceManager = new global::System.Resources.ResourceManager("LogicCircuit.Properties.Resources", typeof(Resources).Assembly);
				}
				return resourceManager;
			}
		}

		/// <summary>
		/// Overrides the current thread's CurrentUICulture property for all
		/// resource lookups using this strongly typed resource class.
		/// </summary>
		[global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static global::System.Globalization.CultureInfo Culture { get; set; }

		/// <summary>
		/// Looks up a localized string similar to More then one project in the file..
		/// </summary>
 		public static string ErrorProjectCount {
			get { return ResourceManager.GetString("ErrorProjectCount", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to Attempt to load an unknown version of Circuit Project.
		/// The file you are trying to open either corrupted or it was created by newer version of Logic Circuit software. Please check http://www.logiccircuit.org/ for newer versions..
		/// </summary>
 		public static string ErrorUnknownVersion {
			get { return ResourceManager.GetString("ErrorUnknownVersion", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to Circuit Project (*{0})|*{0}|All files (*.*)|*.*.
		/// </summary>
 		public static string FileFilter(string fileExtention) {
			return string.Format(Culture, ResourceManager.GetString("FileFilter", Culture), fileExtention);
		}

		/// <summary>
		/// Looks up a localized string similar to File {0} saved..
		/// </summary>
 		public static string FileSaved(string fileName) {
			return string.Format(Culture, ResourceManager.GetString("FileSaved", Culture), fileName);
		}

		/// <summary>
		/// Looks up a localized string similar to LeftToRight.
		/// </summary>
 		public static string FlowDirection {
			get { return ResourceManager.GetString("FlowDirection", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to And.
		/// </summary>
 		public static string GateAndName {
			get { return ResourceManager.GetString("GateAndName", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to &.
		/// </summary>
 		public static string GateAndNotation {
			get { return ResourceManager.GetString("GateAndNotation", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to NAnd.
		/// </summary>
 		public static string GateAndNotName {
			get { return ResourceManager.GetString("GateAndNotName", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to Clock.
		/// </summary>
 		public static string GateClockName {
			get { return ResourceManager.GetString("GateClockName", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to ω.
		/// </summary>
 		public static string GateClockNotation {
			get { return ResourceManager.GetString("GateClockNotation", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to Even.
		/// </summary>
 		public static string GateEvenName {
			get { return ResourceManager.GetString("GateEvenName", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to 2k.
		/// </summary>
 		public static string GateEvenNotation {
			get { return ResourceManager.GetString("GateEvenNotation", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to LED.
		/// </summary>
 		public static string GateLedName {
			get { return ResourceManager.GetString("GateLedName", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to LED.
		/// </summary>
 		public static string GateLedNotation {
			get { return ResourceManager.GetString("GateLedNotation", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to Not.
		/// </summary>
 		public static string GateNotName {
			get { return ResourceManager.GetString("GateNotName", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to ~.
		/// </summary>
 		public static string GateNotNotation {
			get { return ResourceManager.GetString("GateNotNotation", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to Odd.
		/// </summary>
 		public static string GateOddName {
			get { return ResourceManager.GetString("GateOddName", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to 2k
		/// +1.
		/// </summary>
 		public static string GateOddNotation {
			get { return ResourceManager.GetString("GateOddNotation", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to Or.
		/// </summary>
 		public static string GateOrName {
			get { return ResourceManager.GetString("GateOrName", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to 1.
		/// </summary>
 		public static string GateOrNotation {
			get { return ResourceManager.GetString("GateOrNotation", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to NOr.
		/// </summary>
 		public static string GateOrNotName {
			get { return ResourceManager.GetString("GateOrNotName", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to Probe.
		/// </summary>
 		public static string GateProbeName {
			get { return ResourceManager.GetString("GateProbeName", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to ?.
		/// </summary>
 		public static string GateProbeNotation {
			get { return ResourceManager.GetString("GateProbeNotation", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to Rectangular.
		/// </summary>
 		public static string GateShapeRectangular {
			get { return ResourceManager.GetString("GateShapeRectangular", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to Shaped.
		/// </summary>
 		public static string GateShapeShaped {
			get { return ResourceManager.GetString("GateShapeShaped", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to Tri-state.
		/// </summary>
 		public static string GateTriStateName {
			get { return ResourceManager.GetString("GateTriStateName", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to 1.
		/// </summary>
 		public static string GateTriStateNotation {
			get { return ResourceManager.GetString("GateTriStateNotation", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to Xor.
		/// </summary>
 		public static string GateXorName {
			get { return ResourceManager.GetString("GateXorName", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to =.
		/// </summary>
 		public static string GateXorNotation {
			get { return ResourceManager.GetString("GateXorNotation", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to XNor.
		/// </summary>
 		public static string GateXorNotName {
			get { return ResourceManager.GetString("GateXorNotName", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to a.
		/// </summary>
 		public static string Led7Pin1 {
			get { return ResourceManager.GetString("Led7Pin1", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to b.
		/// </summary>
 		public static string Led7Pin2 {
			get { return ResourceManager.GetString("Led7Pin2", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to c.
		/// </summary>
 		public static string Led7Pin3 {
			get { return ResourceManager.GetString("Led7Pin3", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to d.
		/// </summary>
 		public static string Led7Pin4 {
			get { return ResourceManager.GetString("Led7Pin4", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to e.
		/// </summary>
 		public static string Led7Pin5 {
			get { return ResourceManager.GetString("Led7Pin5", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to f.
		/// </summary>
 		public static string Led7Pin6 {
			get { return ResourceManager.GetString("Led7Pin6", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to g.
		/// </summary>
 		public static string Led7Pin7 {
			get { return ResourceManager.GetString("Led7Pin7", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to dot.
		/// </summary>
 		public static string Led7Pin8 {
			get { return ResourceManager.GetString("Led7Pin8", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to Circuit.
		/// </summary>
 		public static string LogicalCircuitName {
			get { return ResourceManager.GetString("LogicalCircuitName", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to Logical Circuit {0}.
		/// </summary>
 		public static string MainFrameCaption(string projectName) {
			return string.Format(Culture, ResourceManager.GetString("MainFrameCaption", Culture), projectName);
		}

		/// <summary>
		/// Looks up a localized string similar to Memory address.
		/// </summary>
 		public static string MemoryAddressPinName {
			get { return ResourceManager.GetString("MemoryAddressPinName", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to a.
		/// </summary>
 		public static string MemoryAddressPinNotation {
			get { return ResourceManager.GetString("MemoryAddressPinNotation", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to Memory input data.
		/// </summary>
 		public static string MemoryDataInPinName {
			get { return ResourceManager.GetString("MemoryDataInPinName", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to Memory data.
		/// </summary>
 		public static string MemoryDataPinName {
			get { return ResourceManager.GetString("MemoryDataPinName", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to d.
		/// </summary>
 		public static string MemoryDataPinNotation {
			get { return ResourceManager.GetString("MemoryDataPinNotation", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to RAM Write input. Memory value get updated on {0}.
		/// </summary>
 		public static string MemoryWritePinName(string writeOn) {
			return string.Format(Culture, ResourceManager.GetString("MemoryWritePinName", Culture), writeOn);
		}

		/// <summary>
		/// Looks up a localized string similar to w.
		/// </summary>
 		public static string MemoryWritePinNotation {
			get { return ResourceManager.GetString("MemoryWritePinNotation", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to Project {0} has changed.
		/// Do you want to save it?.
		/// </summary>
 		public static string MessageSaveFile(string projecgName) {
			return string.Format(Culture, ResourceManager.GetString("MessageSaveFile", Culture), projecgName);
		}

		/// <summary>
		/// Looks up a localized string similar to Operation canceled..
		/// </summary>
 		public static string OperationCanceled {
			get { return ResourceManager.GetString("OperationCanceled", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to E.
		/// </summary>
 		public static string PinEnableName {
			get { return ResourceManager.GetString("PinEnableName", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to x.
		/// </summary>
 		public static string PinInName {
			get { return ResourceManager.GetString("PinInName", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to {0}{1}.
		/// </summary>
 		public static string PinName(string prefix, int number) {
			return string.Format(Culture, ResourceManager.GetString("PinName", Culture), prefix, number);
		}

		/// <summary>
		/// Looks up a localized string similar to q.
		/// </summary>
 		public static string PinOutName {
			get { return ResourceManager.GetString("PinOutName", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to Ready..
		/// </summary>
 		public static string Ready {
			get { return ResourceManager.GetString("Ready", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to (bit {0}) of Combined Splitter connector.
		/// </summary>
 		public static string SplitterThin1PinName(int bit) {
			return string.Format(Culture, ResourceManager.GetString("SplitterThin1PinName", Culture), bit);
		}

		/// <summary>
		/// Looks up a localized string similar to (bits {0}-{1}) of Combined Splitter connector.
		/// </summary>
 		public static string SplitterThin2PinName(int firstBit, int lastBit) {
			return string.Format(Culture, ResourceManager.GetString("SplitterThin2PinName", Culture), firstBit, lastBit);
		}

		/// <summary>
		/// Looks up a localized string similar to Combined Splitter Connector.
		/// </summary>
 		public static string SplitterWidePinName {
			get { return ResourceManager.GetString("SplitterWidePinName", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to Cancel.
		/// </summary>
 		public static string TitleCancel {
			get { return ResourceManager.GetString("TitleCancel", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to _No.
		/// </summary>
 		public static string TitleNo {
			get { return ResourceManager.GetString("TitleNo", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to OK.
		/// </summary>
 		public static string TitleOK {
			get { return ResourceManager.GetString("TitleOK", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to _Show details.
		/// </summary>
 		public static string TitleShowDetails {
			get { return ResourceManager.GetString("TitleShowDetails", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to _Yes.
		/// </summary>
 		public static string TitleYes {
			get { return ResourceManager.GetString("TitleYes", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to failing from 1 to 0.
		/// </summary>
 		public static string WriteOn0 {
			get { return ResourceManager.GetString("WriteOn0", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to raising from 0 to 1.
		/// </summary>
 		public static string WriteOn1 {
			get { return ResourceManager.GetString("WriteOn1", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to {0:X}.
		/// </summary>
 		public static string ConstantNotation(int constantValue) {
			return string.Format(Culture, ResourceManager.GetString("ConstantNotation", Culture), constantValue);
		}

		/// <summary>
		/// Looks up a localized string similar to RAM.
		/// </summary>
 		public static string RAMNotation {
			get { return ResourceManager.GetString("RAMNotation", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to ROM.
		/// </summary>
 		public static string ROMNotation {
			get { return ResourceManager.GetString("ROMNotation", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to Button {0}.
		/// </summary>
 		public static string ToolTipButton(string buttonName) {
			return string.Format(Culture, ResourceManager.GetString("ToolTipButton", Culture), buttonName);
		}

		/// <summary>
		/// Looks up a localized string similar to {0} bit(s) constant {1:X}.
		/// </summary>
 		public static string ToolTipConstant(int bitWidth, int value) {
			return string.Format(Culture, ResourceManager.GetString("ToolTipConstant", Culture), bitWidth, value);
		}

		/// <summary>
		/// Looks up a localized string similar to Input {0} bit(s) Pin {1}.
		/// </summary>
 		public static string ToolTipInputPin(int bitWidth, string pinName) {
			return string.Format(Culture, ResourceManager.GetString("ToolTipInputPin", Culture), bitWidth, pinName);
		}

		/// <summary>
		/// Looks up a localized string similar to {0} bit(s) {1}.
		/// </summary>
 		public static string ToolTipNonePin(int bitWidth, string pinName) {
			return string.Format(Culture, ResourceManager.GetString("ToolTipNonePin", Culture), bitWidth, pinName);
		}

		/// <summary>
		/// Looks up a localized string similar to Output {0} bit(s) Pin {1}.
		/// </summary>
 		public static string ToolTipOutputPin(int bitWidth, string pinName) {
			return string.Format(Culture, ResourceManager.GetString("ToolTipOutputPin", Culture), bitWidth, pinName);
		}

		/// <summary>
		/// Looks up a localized string similar to RAM {0} bit address / {1} bit data.
		/// </summary>
 		public static string ToolTipRAM(int address, int data) {
			return string.Format(Culture, ResourceManager.GetString("ToolTipRAM", Culture), address, data);
		}

		/// <summary>
		/// Looks up a localized string similar to ROM {0} bit address / {1} bit data.
		/// </summary>
 		public static string ToolTipROM(int address, int data) {
			return string.Format(Culture, ResourceManager.GetString("ToolTipROM", Culture), address, data);
		}

		/// <summary>
		/// Looks up a localized string similar to Splitter of {0} bits to {1} pins.
		/// </summary>
 		public static string ToolTipSplitter(int bitWidth, int pinCount) {
			return string.Format(Culture, ResourceManager.GetString("ToolTipSplitter", Culture), bitWidth, pinCount);
		}

		/// <summary>
		/// Looks up a localized string similar to Wire.
		/// </summary>
 		public static string ToolTipWire {
			get { return ResourceManager.GetString("ToolTipWire", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to Buffer.
		/// </summary>
 		public static string CategoryBuffer {
			get { return ResourceManager.GetString("CategoryBuffer", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to Input - Output.
		/// </summary>
 		public static string CategoryInputOutput {
			get { return ResourceManager.GetString("CategoryInputOutput", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to Memory.
		/// </summary>
 		public static string CategoryMemory {
			get { return ResourceManager.GetString("CategoryMemory", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to Parity.
		/// </summary>
 		public static string CategoryParity {
			get { return ResourceManager.GetString("CategoryParity", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to Number of pins on the splitter should be less or equal to its bit width..
		/// </summary>
 		public static string ErrorWrongSplitter {
			get { return ResourceManager.GetString("ErrorWrongSplitter", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to {0}
		/// In.
		/// </summary>
 		public static string TitlePinInput(string pinName) {
			return string.Format(Culture, ResourceManager.GetString("TitlePinInput", Culture), pinName);
		}

		/// <summary>
		/// Looks up a localized string similar to {0}
		/// Out.
		/// </summary>
 		public static string TitlePinOutput(string pinName) {
			return string.Format(Culture, ResourceManager.GetString("TitlePinOutput", Culture), pinName);
		}

		/// <summary>
		/// Looks up a localized string similar to _About.
		/// </summary>
 		public static string CommandHelpAbout {
			get { return ResourceManager.GetString("CommandHelpAbout", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to Button.
		/// </summary>
 		public static string NameButton {
			get { return ResourceManager.GetString("NameButton", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to Constant.
		/// </summary>
 		public static string NameConstant {
			get { return ResourceManager.GetString("NameConstant", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to Splitter.
		/// </summary>
 		public static string NameSplitter {
			get { return ResourceManager.GetString("NameSplitter", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to About.
		/// </summary>
 		public static string TitleAbout {
			get { return ResourceManager.GetString("TitleAbout", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to Logical Circuit.
		/// </summary>
 		public static string TitleApplication {
			get { return ResourceManager.GetString("TitleApplication", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to Version:.
		/// </summary>
 		public static string TitleVersion {
			get { return ResourceManager.GetString("TitleVersion", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to Web:.
		/// </summary>
 		public static string TitleWeb {
			get { return ResourceManager.GetString("TitleWeb", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to http://www.logiccircuit.org/.
		/// </summary>
 		public static string WebSiteUri {
			get { return ResourceManager.GetString("WebSiteUri", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to _Options.
		/// </summary>
 		public static string CommandToolsOptions {
			get { return ResourceManager.GetString("CommandToolsOptions", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to Rectangular.
		/// </summary>
 		public static string GateShapeRectangular1 {
			get { return ResourceManager.GetString("GateShapeRectangular1", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to Shaped.
		/// </summary>
 		public static string GateShapeShaped1 {
			get { return ResourceManager.GetString("GateShapeShaped1", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to Display.
		/// </summary>
 		public static string TitleDisplayOptions {
			get { return ResourceManager.GetString("TitleDisplayOptions", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to File.
		/// </summary>
 		public static string TitleFileOptions {
			get { return ResourceManager.GetString("TitleFileOptions", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to _Gate shape.
		/// </summary>
 		public static string TitleGateShape {
			get { return ResourceManager.GetString("TitleGateShape", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to _Load last file on start up.
		/// </summary>
 		public static string TitleLoadLastFile {
			get { return ResourceManager.GetString("TitleLoadLastFile", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to Options.
		/// </summary>
 		public static string TitleOptions {
			get { return ResourceManager.GetString("TitleOptions", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to _Show grid.
		/// </summary>
 		public static string TitleShowGrid {
			get { return ResourceManager.GetString("TitleShowGrid", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to {0} free wires have been found..
		/// </summary>
 		public static string MessageFreeWireCount(int wireCount) {
			return string.Format(Culture, ResourceManager.GetString("MessageFreeWireCount", Culture), wireCount);
		}

		/// <summary>
		/// Looks up a localized string similar to {0} unconnected symbols have been found..
		/// </summary>
 		public static string MessageFloatingSymbolCount(int symbolCount) {
			return string.Format(Culture, ResourceManager.GetString("MessageFloatingSymbolCount", Culture), symbolCount);
		}

		/// <summary>
		/// Looks up a localized string similar to Logical Circuit.
		/// </summary>
 		public static string CommandCircuitCurrent {
			get { return ResourceManager.GetString("CommandCircuitCurrent", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to Delete Current Circuit.
		/// </summary>
 		public static string CommandCircuitDelete {
			get { return ResourceManager.GetString("CommandCircuitDelete", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to New Logical Circuit.
		/// </summary>
 		public static string CommandCircuitNew {
			get { return ResourceManager.GetString("CommandCircuitNew", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to Project.
		/// </summary>
 		public static string CommandCircuitProject {
			get { return ResourceManager.GetString("CommandCircuitProject", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to Select All But Wires.
		/// </summary>
 		public static string CommandEditSelectAllButWires {
			get { return ResourceManager.GetString("CommandEditSelectAllButWires", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to Select All Probes.
		/// </summary>
 		public static string CommandEditSelectAllProbes {
			get { return ResourceManager.GetString("CommandEditSelectAllProbes", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to Select All Probes and Connected Wire.
		/// </summary>
 		public static string CommandEditSelectAllProbesWithWire {
			get { return ResourceManager.GetString("CommandEditSelectAllProbesWithWire", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to Select All Wires.
		/// </summary>
 		public static string CommandEditSelectAllWires {
			get { return ResourceManager.GetString("CommandEditSelectAllWires", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to Select Floating Symbols.
		/// </summary>
 		public static string CommandEditSelectFloatingSymbols {
			get { return ResourceManager.GetString("CommandEditSelectFloatingSymbols", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to Select Free Wires.
		/// </summary>
 		public static string CommandEditSelectFreeWires {
			get { return ResourceManager.GetString("CommandEditSelectFreeWires", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to Unselect All But Wires.
		/// </summary>
 		public static string CommandEditUnselectAllButWires {
			get { return ResourceManager.GetString("CommandEditUnselectAllButWires", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to Unselect All Wires.
		/// </summary>
 		public static string CommandEditUnselectAllWires {
			get { return ResourceManager.GetString("CommandEditUnselectAllWires", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to Export Image.
		/// </summary>
 		public static string CommandFileExportImage {
			get { return ResourceManager.GetString("CommandFileExportImage", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to Oscilloscope.
		/// </summary>
 		public static string CommandToolsOscilloscope {
			get { return ResourceManager.GetString("CommandToolsOscilloscope", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to Project Report.
		/// </summary>
 		public static string CommandToolsReport {
			get { return ResourceManager.GetString("CommandToolsReport", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to http://www.logiccircuit.org/help.html.
		/// </summary>
 		public static string HelpContent {
			get { return ResourceManager.GetString("HelpContent", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to _Category:.
		/// </summary>
 		public static string TitleCategory {
			get { return ResourceManager.GetString("TitleCategory", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to _Description:.
		/// </summary>
 		public static string TitleDescription {
			get { return ResourceManager.GetString("TitleDescription", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to _Name:.
		/// </summary>
 		public static string TitleName {
			get { return ResourceManager.GetString("TitleName", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to N_otation:.
		/// </summary>
 		public static string TitleNotation {
			get { return ResourceManager.GetString("TitleNotation", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to _Bit width:.
		/// </summary>
 		public static string TitleBitWidth {
			get { return ResourceManager.GetString("TitleBitWidth", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to _Value:.
		/// </summary>
 		public static string TitleValue {
			get { return ResourceManager.GetString("TitleValue", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to Pin.
		/// </summary>
 		public static string NamePin {
			get { return ResourceManager.GetString("NamePin", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to _Address bit width:.
		/// </summary>
 		public static string TitleAddressBitWidth {
			get { return ResourceManager.GetString("TitleAddressBitWidth", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to Data.
		/// </summary>
 		public static string TitleData {
			get { return ResourceManager.GetString("TitleData", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to _Data bit width:.
		/// </summary>
 		public static string TitleDataBitWidth {
			get { return ResourceManager.GetString("TitleDataBitWidth", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to _Inverted.
		/// </summary>
 		public static string TitleInverted {
			get { return ResourceManager.GetString("TitleInverted", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to _Load....
		/// </summary>
 		public static string TitleLoad {
			get { return ResourceManager.GetString("TitleLoad", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to _Side:.
		/// </summary>
 		public static string TitleSide {
			get { return ResourceManager.GetString("TitleSide", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to _Type:.
		/// </summary>
 		public static string TitleType {
			get { return ResourceManager.GetString("TitleType", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to _Write on:.
		/// </summary>
 		public static string TitleWriteOn {
			get { return ResourceManager.GetString("TitleWriteOn", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to Drag & drop the selection at desired location. Hit Esc to cancel the move. Hold Shift when dropping to prevent connected wires move..
		/// </summary>
 		public static string TipOnStartMove {
			get { return ResourceManager.GetString("TipOnStartMove", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to Drag end of wire to desired location. Hit Esc to cancel wire creation..
		/// </summary>
 		public static string TipOnStartWire {
			get { return ResourceManager.GetString("TipOnStartWire", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to Loading....
		/// </summary>
 		public static string Loading {
			get { return ResourceManager.GetString("Loading", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to Press Ctrl+{Shift}+Tab to switch between logical circuits or click to select/unselect individual symbols..
		/// </summary>
 		public static string TipOnCtrlDown {
			get { return ResourceManager.GetString("TipOnCtrlDown", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to Shift+{Ctrl}+Click on wire to select/unselect entire conductor, Alt+Click on selected wire to split, on common point of two to merge..
		/// </summary>
 		public static string TipOnWireSelect {
			get { return ResourceManager.GetString("TipOnWireSelect", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to {0} {1}. Surround multiple symbols to select them, hold Shift to keep current selection..
		/// </summary>
 		public static string TipOnAwaitingArea(string logicCircuit, LogicCircuit.GridPoint point) {
			return string.Format(Culture, ResourceManager.GetString("TipOnAwaitingArea", Culture), logicCircuit, point);
		}

		/// <summary>
		/// Looks up a localized string similar to Function {0} required at least {1} parameters.
		/// </summary>
 		public static string FunctionParameter(string function, int parameterCount) {
			return string.Format(Culture, ResourceManager.GetString("FunctionParameter", Culture), function, parameterCount);
		}

		/// <summary>
		/// Looks up a localized string similar to State {0} is unknown.
		/// </summary>
 		public static string UnknownState(LogicCircuit.State state) {
			return string.Format(Culture, ResourceManager.GetString("UnknownState", Culture), state);
		}

		/// <summary>
		/// Looks up a localized string similar to Attempt to get function from an empty dirty list..
		/// </summary>
 		public static string ErrorDirtyListIsEmpty {
			get { return ResourceManager.GetString("ErrorDirtyListIsEmpty", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to /.
		/// </summary>
 		public static string CircuitMapPathSeparator {
			get { return ResourceManager.GetString("CircuitMapPathSeparator", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to on.
		/// </summary>
 		public static string CircuitMapLabelSeparator {
			get { return ResourceManager.GetString("CircuitMapLabelSeparator", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to Not all address bits connected on memory {0}.
		/// </summary>
 		public static string ErrorAddressNotConnected(string memoryPath) {
			return string.Format(Culture, ResourceManager.GetString("ErrorAddressNotConnected", Culture), memoryPath);
		}

		/// <summary>
		/// Looks up a localized string similar to Not all input data bits connected on memory {0}.
		/// </summary>
 		public static string ErrorDataInNotConnected(string memoryPath) {
			return string.Format(Culture, ResourceManager.GetString("ErrorDataInNotConnected", Culture), memoryPath);
		}

		/// <summary>
		/// Looks up a localized string similar to Input pin of {0} ({1}) and output pin of {2} ({3}) on {4} have different bit width and cannot be connected. Please resolve the issue..
		/// </summary>
 		public static string ErrorJamBitWidthDifferent(string symbol1, GridPoint point1, string symbol2, GridPoint point2, string logicCircuit) {
			return string.Format(Culture, ResourceManager.GetString("ErrorJamBitWidthDifferent", Culture), symbol1, point1, symbol2, point2, logicCircuit);
		}

		/// <summary>
		/// Looks up a localized string similar to Symbol of circuit "{0}" on logical circuit "{1}" forms infinite loop. Please resolve the loop..
		/// </summary>
 		public static string ErrorLoopInCircuit(string symbol, string logicCircuit) {
			return string.Format(Culture, ResourceManager.GetString("ErrorLoopInCircuit", Culture), symbol, logicCircuit);
		}

		/// <summary>
		/// Looks up a localized string similar to Input pin {0} of {1} connected to more than one output pin that are not tri state capable..
		/// </summary>
 		public static string ErrorManyResults(string pinName, string symbol) {
			return string.Format(Culture, ResourceManager.GetString("ErrorManyResults", Culture), pinName, symbol);
		}

		/// <summary>
		/// Looks up a localized string similar to Power Off.
		/// </summary>
 		public static string PowerOff {
			get { return ResourceManager.GetString("PowerOff", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to Power On.
		/// </summary>
 		public static string PowerOn {
			get { return ResourceManager.GetString("PowerOn", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to 0x{0:X}.
		/// </summary>
 		public static string ProbeHistoryHex(int value) {
			return string.Format(Culture, ResourceManager.GetString("ProbeHistoryHex", Culture), value);
		}

		/// <summary>
		/// Looks up a localized string similar to <<<<<< Mark >>>>>>.
		/// </summary>
 		public static string ProbeHistoryMark {
			get { return ResourceManager.GetString("ProbeHistoryMark", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to _Mark.
		/// </summary>
 		public static string TitleMark {
			get { return ResourceManager.GetString("TitleMark", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to Probe History.
		/// </summary>
 		public static string TitleProbeHistory {
			get { return ResourceManager.GetString("TitleProbeHistory", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to Only constants resided on the root circuit ({0}) can be changed when the power is on..
		/// </summary>
 		public static string MessageNotRootConstant(string circuitName) {
			return string.Format(Culture, ResourceManager.GetString("MessageNotRootConstant", Culture), circuitName);
		}

		/// <summary>
		/// Looks up a localized string similar to Main.
		/// </summary>
 		public static string LogicalCircuitMainName {
			get { return ResourceManager.GetString("LogicalCircuitMainName", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to Circuit Project.
		/// </summary>
 		public static string CircuitProjectName {
			get { return ResourceManager.GetString("CircuitProjectName", Culture); }
		}
	}
}
