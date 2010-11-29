﻿//-----------------------------------------------------------------------------
//
//	This code was generated by a ResourceWrapper.Generator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null.
//
//	Changes to this file may cause incorrect behavior and will be lost if
//	the code is regenerated.
//
//-----------------------------------------------------------------------------

namespace ItemWrapper.Generator {
	using System;

	/// <summary>
	/// A strongly-typed resource class, for looking up localized strings, etc.
	/// </summary>
	// This class was auto-generated.
	// To add or remove a member, edit your .ResX file then rerun MsBuild,
	// or rebuild your VS project.
	[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
	[global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
	internal static class TextMessage {

		private static global::System.Resources.ResourceManager resourceManager;

		/// <summary>
		/// Returns the cached ResourceManager instance used by this class.
		/// </summary>
		[global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static global::System.Resources.ResourceManager ResourceManager {
			get {
				if(resourceManager == null) {
					resourceManager = new global::System.Resources.ResourceManager("ItemWrapper.Generator.TextMessage", typeof(TextMessage).Assembly);
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
		/// Looks up a localized string similar to {0} is missing..
		/// </summary>
 		public static string ArgumentMissing(string argument) {
			return string.Format(Culture, ResourceManager.GetString("ArgumentMissing", Culture), argument);
		}

		/// <summary>
		/// Looks up a localized string similar to {0} already defined..
		/// </summary>
 		public static string ArgumentRedefinition(string argument) {
			return string.Format(Culture, ResourceManager.GetString("ArgumentRedefinition", Culture), argument);
		}

		/// <summary>
		/// Looks up a localized string similar to Item generation complete witout errors..
		/// </summary>
 		public static string ReportSuccess {
			get { return ResourceManager.GetString("ReportSuccess", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to Schema file "{0}" does not exist..
		/// </summary>
 		public static string SchemaFileMissing(string file) {
			return string.Format(Culture, ResourceManager.GetString("SchemaFileMissing", Culture), file);
		}

		/// <summary>
		/// Looks up a localized string similar to Target folder "{0}" does not exist..
		/// </summary>
 		public static string TargetFolderMissing(string folder) {
			return string.Format(Culture, ResourceManager.GetString("TargetFolderMissing", Culture), folder);
		}

		/// <summary>
		/// Looks up a localized string similar to {0} unknown argument..
		/// </summary>
 		public static string UnknownArgument(string argument) {
			return string.Format(Culture, ResourceManager.GetString("UnknownArgument", Culture), argument);
		}

		/// <summary>
		/// Looks up a localized string similar to ItemWrapper.Generator /Schema:<file.xaml> /Target:<Destination folder> [/UseDispatcher:<true|false>] [/RealmType:<None|Universe|Multiverse>].
		/// </summary>
 		public static string Usage {
			get { return ResourceManager.GetString("Usage", Culture); }
		}
	}
}
