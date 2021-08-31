using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Zklj123
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public ObservableCollection<Ucenik> Ucenici { get; set; }  = new();
		public MainWindow()
		{
			InitializeComponent();
			Datagrid.ItemsSource = Ucenici;
			Ucenik neko = new();
			neko.Bla = 9;
			//MessageBox.Show(neko.Bla.ToString());
			
		}

		private void Bla(object sender, RoutedEventArgs e)
		{
			Ucenici.Add(new Ucenik { Ime = "asd", Prezime = "bvd" });
			
		}
		private void Bla2(object sender, RoutedEventArgs e)
		{
			Ucenici[0].Ime = "Pera";
			Ucenici[0].Prezime = "Peric";

		}
	}
}
