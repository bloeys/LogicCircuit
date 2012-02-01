﻿//-----------------------------------------------------------------------------
//
//	This code was generated by a ResourceWrapper.Generator Version 1.0.0.0.
//
//	Changes to this file may cause incorrect behavior and will be lost if
//	the code is regenerated.
//
//-----------------------------------------------------------------------------

namespace TestProject.SubFolder {
	using System;
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.Diagnostics;
	using System.Globalization;
	using System.Reflection;
	using System.Resources;
	using System.Runtime.CompilerServices;

	/// <summary>
	/// A strongly-typed resource class, for looking up localized strings, etc.
	/// </summary>
	// This class was auto-generated.
	// To add or remove a member, edit your .ResX file then rerun MsBuild,
	// or rebuild your VS project.
	[DebuggerNonUserCodeAttribute()]
	[CompilerGeneratedAttribute()]
	internal static class Resource {

		/// <summary>
		/// Overrides the current thread's CurrentUICulture property for all
		/// resource lookups using this strongly typed resource class.
		/// </summary>
		[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
		public static CultureInfo Culture { get; set; }

		private static PseudoResourceManager resourceManager;

		/// <summary>
		/// Returns the cached ResourceManager instance used by this class.
		/// </summary>
		[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
		public static ResourceManager ResourceManager {
			get {
				if(resourceManager == null) {
					resourceManager = new PseudoResourceManager("TestProject.SubFolder.Resource", typeof(Resource).Assembly);
				}
				return resourceManager;
			}
		}

		/// <summary>
		/// Performs pseudo localization of string resources
		/// </summary>
		private class PseudoResourceManager : ResourceManager {
			private static Dictionary<char, char> map = new Dictionary<char, char> {
				{ 'a', 'ä' },
				{ 'b', 'ƃ' },
				{ 'c', 'č' },
				{ 'd', 'ƌ' },
				{ 'e', 'ë' },
				{ 'f', 'ƒ' },
				{ 'g', 'ğ' },
				{ 'h', 'ħ' },
				{ 'i', 'ï' },
				{ 'j', 'ĵ' },
				{ 'k', 'ƙ' },
				{ 'l', 'ł' },
				{ 'm', 'ɱ' },
				{ 'n', 'ň' },
				{ 'o', 'ö' },
				{ 'p', 'þ' },
				{ 'q', 'ɋ' },
				{ 'r', 'ř' },
				{ 's', 'š' },
				{ 't', 'ŧ' },
				{ 'u', 'ü' },
				{ 'v', 'ṽ' },
				{ 'w', 'ŵ' },
				{ 'x', 'ӿ' },
				{ 'y', 'ŷ' },
				{ 'z', 'ž' },
				{ 'A', 'Ä' },
				{ 'B', 'Ɓ' },
				{ 'C', 'Č' },
				{ 'D', 'Đ' },
				{ 'E', 'Ë' },
				{ 'F', 'Ƒ' },
				{ 'G', 'Ğ' },
				{ 'H', 'Ħ' },
				{ 'I', 'Ï' },
				{ 'J', 'Ĵ' },
				{ 'K', 'Ҟ' },
				{ 'L', 'Ł' },
				{ 'M', 'Ӎ' },
				{ 'N', 'Ň' },
				{ 'O', 'Ö' },
				{ 'P', 'Ҏ' },
				{ 'Q', 'Ǫ' },
				{ 'R', 'Ř' },
				{ 'S', 'Š' },
				{ 'T', 'Ŧ' },
				{ 'U', 'Ü' },
				{ 'V', 'Ṽ' },
				{ 'W', 'Ŵ' },
				{ 'X', 'Ӿ' },
				{ 'Y', 'Ŷ' },
				{ 'Z', 'Ž' },
			};

			private Dictionary<string, string> resources = new Dictionary<string, string>();

			public PseudoResourceManager(string baseName, Assembly assembly) : base(baseName, assembly) {
			}

			public override string GetString(string name, CultureInfo culture) {
				if(culture == null) {
					return this.Pseudo(name);
				}
				return base.GetString(name, culture);
			}

			public string GetBaseString(string name, CultureInfo culture) {
				return base.GetString(name, culture);
			}

			public string GetBaseString(string[] values, string name, CultureInfo culture) {
				string text;
				if(!this.resources.TryGetValue(name, out text)) {
					Random random = new Random();
					this.resources[name] = text = values[random.Next(values.Length)];
				}
				return text;
			}

			private string Pseudo(string name) {
				string text;
				if(!this.resources.TryGetValue(name, out text)) {
					this.resources[name] = text = this.PseudoLocalize(base.GetString(name, null));
				}
				return text;
			}

			private string PseudoLocalize(string text) {
				if(!string.IsNullOrEmpty(text)) {
					char[] result = new char[text.Length];
					for(int i = 0; i < result.Length; i++) {
						char c;
						if(map.TryGetValue(text[i], out c)) {
							result[i] = c;
						} else {
							result[i] = text[i];
						}
					}
					return "[===" + new string(result) + "===]";
				}
				return text;
			}
		}

		/// <summary>
		/// Looks up a localized string similar to ..\resources\binfile.bin.
		/// </summary>
 		public static System.Byte[] BinFile {
			get { return (System.Byte[])ResourceManager.GetObject("BinFile", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to ..\resources\cursor.cur.
		/// </summary>
 		public static System.Byte[] Cursor {
			get { return (System.Byte[])ResourceManager.GetObject("Cursor", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to ..\resources\database.sdf.
		/// </summary>
 		public static System.Byte[] Database {
			get { return (System.Byte[])ResourceManager.GetObject("Database", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to LeftToRight.
		/// </summary>
 		public static string FlowDirection {
			get { return ((PseudoResourceManager)ResourceManager).GetBaseString(new string[]{"LeftToRight","RightToLeft"}, "FlowDirection", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to ..\resources\icon.ico.
		/// </summary>
 		public static System.Drawing.Icon Icon {
			get { return (System.Drawing.Icon)ResourceManager.GetObject("Icon", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to Hello, World!.
		/// </summary>
 		public static string JustProperty {
			get { return ResourceManager.GetString("JustProperty", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to This string with argument {0} should be non localizable.
		/// </summary>
 		public static string NotLocalizeFunction(int arg) {
			return string.Format(Culture, ((PseudoResourceManager)ResourceManager).GetBaseString("NotLocalizeFunction", Culture), arg);
		}

		/// <summary>
		/// Looks up a localized string similar to This string without arguments should be non localizable.
		/// </summary>
 		public static string NotLocalizeProperty {
			get { return ((PseudoResourceManager)ResourceManager).GetBaseString("NotLocalizeProperty", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to ..\Resources\PngImage.png.
		/// </summary>
 		public static System.Drawing.Bitmap PngImage {
			get { return (System.Drawing.Bitmap)ResourceManager.GetObject("PngImage", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to content of the file: "..\textfile.txt".
		/// </summary>
 		public static string TextFile {
			get { return ResourceManager.GetString("TextFile", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to This is int {0}, and this is string {1}.
		/// </summary>
 		public static string TwoArguments(int justInt, string justString) {
			return string.Format(Culture, ResourceManager.GetString("TwoArguments", Culture), justInt, justString);
		}

		/// <summary>
		/// Looks up a localized string similar to content of the file: "..\resources\xmlfile.xml".
		/// </summary>
 		public static string XMLFile {
			get { return ResourceManager.GetString("XMLFile", Culture); }
		}
	}
}