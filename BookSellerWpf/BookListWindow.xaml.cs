﻿using PublisherLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BookSellerWpf {
	/// <summary>
	/// Interaction logic for BookListWindow.xaml
	/// </summary>
	public partial class BookListWindow : Window {
		public BookListWindow() {
			InitializeComponent();

			var dataSource = new PublisherLib.BookDataSource();
			Book book = dataSource.GetBestSellingBook();
			this.DataContext = book;
		}
	}
}