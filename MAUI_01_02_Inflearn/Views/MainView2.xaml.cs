using MAUI_01_02_Inflearn.Models;
using System.Collections.Generic;

namespace MAUI_01_02_Inflearn.Views;


public partial class MainView2 : FlyoutPage
{
    List<Menu> menus = new List<Menu>() 
    { 
        new Menu() {Name="GridView"},
        new Menu() {Name="FlexLayout"},
        new Menu() {Name="AbsoluteLayout"},
        new Menu() {Name="NavigationView"},
        new Menu() {Name="Shapes"},
        new Menu() {Name="EventView"},
        new Menu() {Name="EventView2"},
        new Menu() {Name="CarouselPage"},
        new Menu() {Name="ListView"},
        new Menu() {Name="CollectionView"},
        new Menu() {Name="MVVM"},
        new Menu() {Name="Style"}
    };
	public MainView2()
	{
        InitializeComponent();
        lst.ItemsSource = menus;
    }

    private void lst_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var selectedItem = e.CurrentSelection.FirstOrDefault() as Menu;

        switch (selectedItem.Name)
        {
            case "GridView":
                Detail = new NavigationPage(new GridView());
                break;
            case "FlexLayout":
                Detail = new NavigationPage(new FlexLayoutView());
                break;
            case "AbsoluteLayout":
                Detail = new NavigationPage(new AbsoluteLayoutView());
                break;
            case "NavigationView":
                Detail = new NavigationPage(new NavigationView());
                break;
            case "Shapes":
                Detail = new NavigationPage(new ShapesView());
                break;
            case "EventView":
                Detail = new NavigationPage(new EventView());
                break;
            case "EventView2":
                Detail = new NavigationPage(new Event2View());
                break;
            case "CarouselPage":
                Detail = new NavigationPage(new CarouselPage());
                break;
            case "ListView":
                Detail = new NavigationPage(new ListViewPage());
                break;
            case "CollectionView":
                Detail = new NavigationPage(new CollectionView());
                break;
            case "MVVM":
                Detail = new NavigationPage(new MVVMPage());
                break;
            case "Style":
                Detail = new NavigationPage(new StylesPage());
                break;
                
        };
    }
}