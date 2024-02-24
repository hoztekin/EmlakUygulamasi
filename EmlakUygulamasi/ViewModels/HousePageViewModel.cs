using EmlakUygulamasi.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace EmlakUygulamasi.ViewModels
{
	public class HousePageViewModel
	{
		public ObservableCollection<Features> features { get; set; }

		public HousePageViewModel()
		{
			Features = new ObservableCollection<Features>
			{
				new Features {Quantity = "700",	Name = "Metre Kare"	},
				new Features {Quantity = "4", Name = "Oda Sayısı" },
				new Features {Quantity = "2", Name = "Banyo Sayısı" },
				new Features {Quantity = "1", Name = "Garaj Sayısı"}
			};
		}
        public ObservableCollection<Features> Features { get => features; set => features=value; }
    }
}
