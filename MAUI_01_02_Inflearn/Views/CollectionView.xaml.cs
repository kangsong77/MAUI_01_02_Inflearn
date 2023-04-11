using MAUI_01_02_Inflearn.Models;

namespace MAUI_01_02_Inflearn.Views;

public partial class CollectionView : ContentPage
{
    List<Person> list = new List<Person>()
    {
        new Person(){ Name="ȫ�浿", Age = 100, Image="dotnet_bot.svg"},
        new Person(){ Name="�Ӳ���", Age = 50, Image="dotnet_bot.svg"},
        new Person(){ Name="Ÿ��", Age = 10, Image="dotnet_bot.svg"},
    };
    public CollectionView()
	{
		InitializeComponent();
        lst.ItemsSource = list;
    }

    private void lst_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        //�÷��Ǻ�� ���߼����� ����! �Ʒ�ó�� �ϸ� �ȵ�
        //var selectedItem = e.CurrentSelection as Person;

        var selectedItem = e.CurrentSelection.FirstOrDefault() as Person;
        //�������� �̵�
        Navigation.PushAsync(new ListViewDetailPage(selectedItem));
    }
}