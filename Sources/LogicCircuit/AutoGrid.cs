﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace LogicCircuit {
	/// <summary>
	/// Based on: http://www.codeproject.com/Articles/756873/GridEx-for-WPF-Automatic-Placement-of-Children
	/// </summary>
	public class AutoGrid : Grid {
		public static readonly DependencyProperty ColumnWidthsProperty = DependencyProperty.Register("ColumnWidths", typeof(string), typeof(AutoGrid));
		public string ColumnWidths {
			get { return (string)this.GetValue(AutoGrid.ColumnWidthsProperty); }
			set { this.SetValue(AutoGrid.ColumnWidthsProperty, value); }
		}

		public static readonly DependencyProperty RowHeightProperty = DependencyProperty.RegisterAttached("RowHeight", typeof(GridLength), typeof(AutoGrid));
		public static GridLength GetRowHeight(DependencyObject obj) {
			return (GridLength)obj.GetValue(AutoGrid.RowHeightProperty);
		}
		public static void SetRowHeight(DependencyObject obj, GridLength rowHeight) {
			obj.SetValue(AutoGrid.RowHeightProperty, rowHeight);
		}

		public AutoGrid() {
			this.DefineColumns();
			this.Loaded += this.AutoGridLoaded;
		}

		private void AutoGridLoaded(object sender, RoutedEventArgs e) {
			this.Loaded -= AutoGridLoaded;
			foreach(UIElement child in this.Children) {
				this.UpdateRowHeight(child);
			}
		}

		protected override void OnPropertyChanged(DependencyPropertyChangedEventArgs e) {
			base.OnPropertyChanged(e);
			if(e.Property == AutoGrid.ColumnWidthsProperty) {
				this.DefineColumns();
				if(0 < this.Children.Count) {
					UIElement[] children = new UIElement[this.Children.Count];
					this.Children.CopyTo(children, 0);
					this.Children.Clear();
					foreach (var child in children) {
						this.Children.Add(child);
					}
				}
			}
		}

		protected override void OnVisualChildrenChanged(DependencyObject visualAdded, DependencyObject visualRemoved) {
			base.OnVisualChildrenChanged(visualAdded, visualRemoved);
			if(visualAdded != null) {
				int column = this.AvailableColumn();
				int row = this.AvailableRow();
				if(this.ColumnDefinitions.Count <= column) {
					column = 0;
					row++;
				}
				if(this.RowDefinitions.Count <= row) {
					this.RowDefinitions.Add(new RowDefinition() { Height = GridLength.Auto });
				}
				if(!AutoGrid.WasSet(visualAdded.ReadLocalValue(Grid.ColumnProperty))) {
					visualAdded.SetValue(Grid.ColumnProperty, column);
				}
				visualAdded.SetValue(Grid.RowProperty, row);
			}
		}

		private void DefineColumns() {
			this.ColumnDefinitions.Clear();
			this.RowDefinitions.Clear();
			foreach(GridLength gridLength in AutoGrid.ParseColumnWidths(this.ColumnWidths)) {
				this.ColumnDefinitions.Add(new ColumnDefinition() { Width = gridLength });
			}
		}

		private static IEnumerable<GridLength> ParseColumnWidths(string widths) {
			if(!string.IsNullOrWhiteSpace(widths)) {
				GridLengthConverter converter = new GridLengthConverter();
				foreach(string text in widths.Split(';').Where(str => !string.IsNullOrWhiteSpace(str)).Select(str => str.Trim())) {
					yield return (GridLength)converter.ConvertFromInvariantString(text);
				}
			} else {
				yield return GridLength.Auto;
				yield return new GridLength(1, GridUnitType.Star);
			}
		}

		private static bool WasSet(object obj) {
			return obj != null && obj != DependencyProperty.UnsetValue;
		}

		private int AvailableColumn() {
			int index = this.Children.Count - 2; // The last element needs to be placed in the grid. The previous already placed so inspect it.
			if (0 <= index) {
				UIElement last = this.Children[index];
				object columnObject = last.ReadLocalValue(Grid.ColumnProperty);
				object spanObject = last.ReadLocalValue(Grid.ColumnSpanProperty);
				int column = AutoGrid.WasSet(columnObject) ? (int)columnObject : 0;
				int span = AutoGrid.WasSet(spanObject) ? (int)spanObject : 1;
				return column + span;
			}
			return 0;
		}

		private int AvailableRow() {
			int index = this.Children.Count - 2; // The last element needs to be placed in the grid. The previous already placed so inspect it.
			if (0 <= index) {
				UIElement last = this.Children[index];
				object rowObject = last.ReadLocalValue(Grid.RowProperty);
				if (AutoGrid.WasSet(rowObject)) {
					return (int)rowObject;
				}
			}
			return 0;
		}

		private void UpdateRowHeight(DependencyObject child) {
			object objHeight = child.ReadLocalValue(AutoGrid.RowHeightProperty);
			if(AutoGrid.WasSet(objHeight)) {
				GridLength rowHeight = (GridLength)objHeight;
				RowDefinition row = this.RowDefinitions[(int)child.GetValue(Grid.RowProperty)];
				if(rowHeight != row.Height) {
					row.Height = rowHeight;
				}
			} else {
				TextBox textBox = child as TextBox;
				if((textBox != null && textBox.AcceptsReturn && !(0 < textBox.Height || 1 < textBox.MinLines || textBox.MaxLines < int.MaxValue)) ||
					child is GroupBox || child is ListBox || child is ListView || child is RichTextBox || child is DataGrid || child is TreeView
				) {
					RowDefinition row = this.RowDefinitions[(int)child.GetValue(Grid.RowProperty)];
					if(row.Height == GridLength.Auto) {
						row.Height = new GridLength(1, GridUnitType.Star);
					}
				}
			}
		}
	}
}
