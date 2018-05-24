using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoMVVMAprendices.View
{
    using DemoMVVMAprendices.Model;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;

	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetalleAprendiz : ContentPage
	{
		public DetalleAprendiz (Aprendiz aprendizSeleccionado)
		{
			InitializeComponent ();
            this.BindingContext = aprendizSeleccionado;
		}
	}
}