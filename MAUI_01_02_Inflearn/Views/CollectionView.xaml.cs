using MAUI_01_02_Inflearn.Models;

namespace MAUI_01_02_Inflearn.Views;

public partial class CollectionView : ContentPage
{
    List<Person> list = new List<Person>()
    {
        new Person(){ Name="홍길동", Age = 100, Image="dotnet_bot.svg"},
        new Person(){ Name="임꺽정", Age = 50, Image="dotnet_bot.svg"},
        new Person(){ Name="타요", Age = 10, Image="dotnet_bot.svg"},
    };
    public CollectionView()
	{
		InitializeComponent();
        lst.ItemsSource = list;
    }

    private void lst_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        //컬렉션뷰는 다중선택이 가능! 아래처럼 하면 안됨
        //var selectedItem = e.CurrentSelection as Person;

        var selectedItem = e.CurrentSelection.FirstOrDefault() as Person;
        //상세페이지 이동
        Navigation.PushAsync(new ListViewDetailPage(selectedItem));
    }
}