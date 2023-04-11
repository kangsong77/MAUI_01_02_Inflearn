using MAUI_01_02_Inflearn.Models;

namespace MAUI_01_02_Inflearn.Views;

public partial class ListViewPage : ContentPage
{
	List<Person> list = new List<Person>()
	{
		new Person(){ Name="ȫ�浿", Age = 100, Image="dotnet_bot.svg"},
		new Person(){ Name="�Ӳ���", Age = 50, Image="dotnet_bot.svg"},
		new Person(){ Name="Ÿ��", Age = 10, Image="dotnet_bot.svg"},
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