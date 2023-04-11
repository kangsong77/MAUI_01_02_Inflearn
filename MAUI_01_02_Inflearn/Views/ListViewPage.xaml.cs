using MAUI_01_02_Inflearn.Models;

namespace MAUI_01_02_Inflearn.Views;

public partial class ListViewPage : ContentPage
{
	List<Person> list = new List<Person>()
	{
		new Person(){ Name="È«±æµ¿", Age = 100, Image="dotnet_bot.svg"},
		new Person(){ Name="ÀÓ²©Á¤", Age = 50, Image="dotnet_bot.svg"},
		new Person(){ Name="Å¸¿ä", Age = 10, Image="dotnet_bot.svg"},
	};
	public ListViewPage()
	{
		InitializeComponent();
		lst.ItemsSource= list;
	}

    private void lst_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
		var selectedItem = e.SelectedItem as Person;
		Navigation.PushAsync(new ListViewDetailPage(selectedItem));
    }
}