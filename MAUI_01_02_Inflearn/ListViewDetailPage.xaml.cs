using MAUI_01_02_Inflearn.Models;

namespace MAUI_01_02_Inflearn;

public partial class ListViewDetailPage : ContentPage
{
	public ListViewDetailPage(Person person)
	{
		InitializeComponent();
		BindingContext= person;
	}
}