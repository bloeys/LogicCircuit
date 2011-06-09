﻿using System;

namespace LogicCircuit {
	internal class SettingsEnumCache<T> where T:struct {
		private Settings settings;
		private string key;
		private T defaultValue;

		private T cache;
		public T Value {
			get { return this.cache; }
			set {
				this.cache = Enum.IsDefined(typeof(T), value) ? value : this.defaultValue;
				this.settings[this.key] = this.cache.ToString();
			}
		}

		public SettingsEnumCache(
			Settings settings,
			string key,
			T defaultValue
		) {
			this.settings = settings;
			this.key = key;
			if(!Enum.IsDefined(typeof(T), defaultValue)) {
				defaultValue = (T)Enum.GetValues(typeof(T)).GetValue(0);
			}
			this.defaultValue = defaultValue;
			string text = this.settings[this.key];
			if(!string.IsNullOrEmpty(text)) {
				if(!Enum.TryParse<T>(text, out this.cache)) {
					this.cache = defaultValue;
				}
			} else {
				this.cache = this.defaultValue;
			}
		}
	}
}
