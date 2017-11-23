using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF.Recursos.Controles
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListPickerView : ContentPage
	{
		public ListPickerView ()
		{
			InitializeComponent ();
		}
	}
}