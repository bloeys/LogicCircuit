﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicCircuit {
	public class FunctionClock : CircuitFunction, IFunctionClock {
		private bool state;
		public FunctionClock(CircuitState circuitState, int result) : base(circuitState, null, new int[] { result }) {
			this.state = false;
		}
		public bool Flip() {
			this.state = !this.state;
			return true;
		}
		public override bool Evaluate() {
			return this.SetResult(CircuitFunction.FromBool(this.state));
		}

		public override string ReportName { get { return Resources.GateClockName; } }
	}
}
