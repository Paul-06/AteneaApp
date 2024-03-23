using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AteneaApp.Cells
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CatalogItemCard : Frame
	{
		public CatalogItemCard()
		{
			InitializeComponent();
		}
	}
}