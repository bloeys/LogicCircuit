﻿using System;
using System.Collections.Generic;
using System.Windows.Controls;

namespace LogicCircuit {
	public class FunctionProbe : Probe, IFunctionVisual {

		public CircuitSymbol CircuitSymbol { get; private set; }
		private History<State>[] tickHistory;
		private History<long> valueHistory;

		public FunctionProbe(CircuitSymbol symbol, CircuitState circuitState, int[] parameter, int capacity) : base(circuitState, parameter) {
			Tracer.Assert(0 < this.BitWidth && this.BitWidth <= BasePin.MaxBitWidth);
			this.CircuitSymbol = symbol;
			this.tickHistory = new History<State>[this.BitWidth];
			for(int i = 0; i < this.tickHistory.Length; i++) {
				this.tickHistory[i] = new History<State>(capacity);
			}
			this.valueHistory = new History<long>(capacity);
			this.valueHistory.Add(this.Pack());
		}

		public override bool Evaluate() {
			if(this.GetState()) {
				this.valueHistory.Add(this.Pack());
				this.CircuitState.Invalidate(this);
			}
			return false;
		}

		public void Tick() {
			for(int i = 0; i < this.tickHistory.Length; i++) {
				this.tickHistory[i].Add(this[i]);
			}
		}

		public void Read(int bitNumber, State[] state) {
			Tracer.Assert(state.Length == this.tickHistory[bitNumber].Capacity);
			this.tickHistory[bitNumber].GetState(state);
		}

		public long Pack() {
			long pack = 0;
			for(int i = 0; i < this.BitWidth; i++) {
				pack |= ((long)((int)this[i] & 0x03)) << (2 * i);
			}
			return pack;
		}

		public State Unpack(long pack, int bitNumber) {
			Tracer.Assert(0 <= bitNumber && bitNumber < this.BitWidth);
			State state = (State)(((int)(pack >> (2 * bitNumber))) & 0x03);
			Tracer.Assert(Enum.IsDefined(typeof(State), state));
			return state;
		}

		public long[] Read() {
			long[] buffer = new long[this.valueHistory.Capacity];
			int length = this.valueHistory.GetState(buffer);
			long[] state = new long[length];
			if(0 < length) {
				Array.Copy(buffer, buffer.Length - length, state, 0, length);
			}
			return state;
		}

		public void Mark() {
			this.valueHistory.Add(-1L);
		}

		public void TurnOn() {
			this.CircuitSymbol.GuaranteeGlyph();
		}

		public void TurnOff() {
			((TextBlock)this.CircuitSymbol.ProbeView).Text = Resources.GateProbeNotation;
		}

		public void Redraw() {
			((TextBlock)this.CircuitSymbol.ProbeView).Text = this.ToHex();
		}

		private class History<T> {
			private volatile bool adding;
			private T[] list;
			private volatile int head;
			private bool full;

			public History(int capacity) {
				this.list = new T[capacity];
				this.head = 0;
				this.full = false;
			}

			public int Capacity { get { return this.list.Length; } }

			public void Add(T state) {
				while(this.adding);
				this.adding = true;
				this.list[this.head++] = state;
				if(this.list.Length <= this.head) {
					this.full = true;
					this.head = 0;
				}
				this.adding = false;
			}

			public int GetState(T[] state) {
				int size = 0;
				do {
					while(this.adding);
					int h = this.head;
					if(this.full) {
						Array.Copy(this.list, h, state, 0, this.list.Length - h);
					}
					Array.Copy(this.list, 0, state, this.list.Length - h, h);
					if(this.full) {
						size = this.list.Length;
					} else {
						size = this.head;
					}
				} while(this.adding);
				return size;
			}
		}
	}
}
