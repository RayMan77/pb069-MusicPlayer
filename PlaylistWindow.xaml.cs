﻿using System;
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

namespace PB_069_MusicPlayer
{
	/// <summary>
	/// Interaction logic for PlaylistWindow.xaml
	/// </summary>
	public partial class PlaylistWindow : Window
	{
		public PlaylistWindow()
		{
			InitializeComponent();
		}

		private void listBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
		{
			Console.WriteLine(listBox.SelectedItems[0].ToString().Split('.').First());
			
		}
	}
}