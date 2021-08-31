using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zklj123
{
	public class Korisnik : INotifyPropertyChanged
	{
		public string Asd { get; set; } = "test";
		private string _ime;
		public string Ime 
		{ 
			get => _ime; 
			set
			{
				_ime = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ime"));
			}
		}
		public string Prezime { get; set; }

		public event PropertyChangedEventHandler? PropertyChanged;

		private int _bla;
		public int Bla
		{
			get => _bla;
			set 
			{
				if (value >= 0 && value <= 10)
				{
					_bla = value;
				}
			}
		}

		/*public int getBla() => Bla;

		public void setBla(int br)
		{
			if (br >= 0 && br <=10)
			{
				Bla = br;
			}
		}*/
	}
}
