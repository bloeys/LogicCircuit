﻿using System;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using LogicCircuit;
using LogicCircuit.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LogicCircuit.UnitTest {
	/// <summary>
	/// This is a test class for Resources and is intended
	/// to contain all Resources Unit Tests
	/// </summary>
	[TestClass()]
	public class ResourcesTest {
		/// <summary>
		/// Gets or sets the test context which provides
		/// information about and functionality for the current test run.
		/// </summary>
		public TestContext TestContext { get; set; }

		private bool ValidUrl(string url, Predicate<Uri> isValid = null) {
			Uri uri;
			return Uri.TryCreate(url, UriKind.Absolute, out uri) && uri.Scheme == Uri.UriSchemeHttp && uri.Host == "www.logiccircuit.org" && (isValid == null || isValid(uri));
		}

		/// <summary>
		/// A test for DefaultGateShape
		/// </summary>
		[TestMethod()]
		public void ResourcesDefaultGateShapeTest() {
			string[] names = Enum.GetNames(typeof(GateShape));
			foreach(CultureInfo culture in App.AvailableCultures) {
				Resources.Culture = culture;
				string actual = Resources.DefaultGateShape;
				Assert.IsTrue(names.Contains(actual, StringComparer.Ordinal), "DefaultGateShape for \"{0}\" is invalid", culture.Name);
			}
		}

		/// <summary>
		/// A test for FlowDirection
		/// </summary>
		[TestMethod()]
		public void ResourcesFlowDirectionTest() {
			string[] names = Enum.GetNames(typeof(FlowDirection));
			foreach(CultureInfo culture in App.AvailableCultures) {
				Resources.Culture = culture;
				string actual = Resources.FlowDirection;
				Assert.IsTrue(names.Contains(actual, StringComparer.Ordinal), "FlowDirection for \"{0}\" is invalid", culture.Name);
			}
		}

		/// <summary>
		/// A test for ErrorUnknownVersion
		/// </summary>
		[TestMethod()]
		public void ResourcesErrorUnknownVersionTest() {
			Regex regex = new Regex(
				"<Hyperlink NavigateUri=\"http://www.logiccircuit.org/\">http://www.logiccircuit.org/</Hyperlink>",
				RegexOptions.Compiled | RegexOptions.CultureInvariant | RegexOptions.Singleline
			);
			foreach(CultureInfo culture in App.AvailableCultures) {
				Resources.Culture = culture;
				string actual = Resources.ErrorUnknownVersion;
				Assert.IsTrue(regex.IsMatch(actual), "ErrorUnknownVersion for \"{0}\" has invalid hyperlink", culture.Name);
			}
		}

		/// <summary>
		/// A test for FileFilter
		/// </summary>
		[TestMethod()]
		public void ResourcesFileFilterTest() {
			string extension = "ABCDEF";
			Regex regex = new Regex(
				Regex.Escape(string.Format("(*{0})|*{0}|AnyCharacters(*.*)|*.*", extension)).Replace("AnyCharacters", ".*"),
				RegexOptions.Compiled | RegexOptions.CultureInvariant | RegexOptions.Singleline
			);
			foreach(CultureInfo culture in App.AvailableCultures) {
				Resources.Culture = culture;
				string actual = Resources.FileFilter(extension);
				Assert.IsTrue(regex.IsMatch(actual), "FileFilter for \"{0}\" has invalid file filter", culture.Name);
			}
		}

		/// <summary>
		/// A test for ImageFileFilter
		/// </summary>
		[TestMethod()]
		public void ResourcesImageFileFilterTest() {
			Regex regex = new Regex(
				Regex.Escape("(*.bmp;*.dib;*.gif;*.jpeg;*.jpg;*.jpe;*.png;*.tiff;*.tif)|*.bmp;*.dib;*.gif;*.jpeg;*.jpg;*.jpe;*.png;*.tiff;*.tif|ABCDEF(*.*)|*.*").Replace("ABCDEF", ".*"),
				RegexOptions.Compiled | RegexOptions.CultureInvariant | RegexOptions.Singleline
			);
			foreach(CultureInfo culture in App.AvailableCultures) {
				Resources.Culture = culture;
				string actual = Resources.ImageFileFilter;
				Assert.IsTrue(regex.IsMatch(actual), "ImageFileFilter for \"{0}\" has invalid file filter", culture.Name);
			}
		}

		/// <summary>
		/// A test for HelpContent
		/// </summary>
		[TestMethod()]
		public void ResourcesHelpContentTest() {
			foreach(CultureInfo culture in App.AvailableCultures) {
				Resources.Culture = culture;
				string actual = Resources.HelpContent;
				Assert.IsTrue(this.ValidUrl(actual, uri => uri.LocalPath.EndsWith("help.html")), "HelpContent for \"{0}\" has invalid URL", culture.Name);
			}
		}

		/// <summary>
		/// A test for WebSiteDownloadUri
		/// </summary>
		[TestMethod()]
		public void ResourcesWebSiteDownloadUriTest() {
			foreach(CultureInfo culture in App.AvailableCultures) {
				Resources.Culture = culture;
				string actual = Resources.WebSiteDownloadUri;
				Assert.IsTrue(this.ValidUrl(actual, uri => uri.LocalPath.EndsWith("download.html")), "WebSiteDownloadUri for \"{0}\" has invalid URL", culture.Name);
			}
		}

		/// <summary>
		/// A test for WebSiteUri
		/// </summary>
		[TestMethod()]
		public void ResourcesWebSiteUriTest() {
			foreach(CultureInfo culture in App.AvailableCultures) {
				Resources.Culture = culture;
				string actual = Resources.WebSiteUri;
				Assert.IsTrue(this.ValidUrl(actual, uri => uri.LocalPath == "/"), "WebSiteUri for \"{0}\" has invalid URL", culture.Name);
			}
		}
	}
}