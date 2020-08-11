using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Izuzetak
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public string[] bla = { "asd", "asdd" };

		public MainWindow()
		{
			InitializeComponent();

			prvo.Click += Button_Click;

			drugo.Click += Button_Click;
			drugo.Click += Button_Click_1;

		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				MessageBox.Show(bla[0]);
				return;
			}
			catch (IndexOutOfRangeException nr)
			{
				MessageBox.Show("Problem!");
			}
			catch (IOException io)
			{
				MessageBox.Show("Problem drugi!");
			}
			catch
			{
				MessageBox.Show("Problem ko zna koji!");
			} finally
			{
				MessageBox.Show("Ovo je uvek uvek!");
			}
		}

		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("Drugo dugme!");
		}
	}
}
