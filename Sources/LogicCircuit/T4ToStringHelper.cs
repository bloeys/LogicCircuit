﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Diagnostics.CodeAnalysis;

namespace LogicCircuit {
	/// <summary>
	/// Utility class to produce culture-oriented representation of an object as a string.
	/// </summary>
	public class T4ToStringHelper {
		private IFormatProvider formatProvider = CultureInfo.CurrentUICulture;

		/// <summary>
		/// Gets or sets format provider to be used by ToStringWithCulture method.
		/// </summary>
		public IFormatProvider FormatProvider {
			get { return this.formatProvider; }
			set { this.formatProvider = value ?? CultureInfo.CurrentUICulture; }
		}

		/// <summary>
		/// This is called from the compile/run appdomain to convert objects within an expression block to a string
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		[SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
		public string ToStringWithCulture(object value) {
			if(value == null) {
				throw new ArgumentNullException("value");
			}

			Type type = value.GetType();
			MethodInfo method = type.GetMethod("ToString", new Type[] { typeof(IFormatProvider) });
			if(method != null) {
				return (string)method.Invoke(value, new object[] { this.FormatProvider });
			} else {
				return value.ToString();
			}
		}

		[SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
		public string ToStringWithCulture(int value) {
			return value.ToString("D", this.FormatProvider);
		}

		[SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
		public string ToStringWithCulture(string value) {
			return value;
		}
	}
}
