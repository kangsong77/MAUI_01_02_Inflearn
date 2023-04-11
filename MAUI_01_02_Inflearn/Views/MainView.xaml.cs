namespace MAUI_01_02_Inflearn.Views;

public partial class MainView : FlyoutPage
{
	public MainView()
	{
		InitializeComponent();
	}
    //ch06_FlyoutPage 기능추가
    private void btn1_Clicked(object sender, EventArgs e)
    {
        //본문부분 변경
        Detail = new NavigationPage(new GridView());
    }

    private void btn2_Clicked(object sender, EventArgs e)
    {
        Detail = new NavigationPage(new FlexLayoutView());
    }

    private void btn3_Clicked(object sender, EventArgs e)
    {
        Detail = new NavigationPage(new AbsoluteLayoutView());
    }

    private void btn4_Clicked(object sender, EventArgs e)
    {
        Detail = new NavigationPage(new NavigationView());
    }

    private void btn5_Clicked(object sender, EventArgs e)
    {
        Detail = new NavigationPage(new ShapesView());
    }
    private void btn6_Clicked(object sender, EventArgs e)
    {
        Detail = new NavigationPage(new EventView());
    }
    private void btn7_Clicked(object sender, EventArgs e)
    {
        Detail = new NavigationPage(new Event2View());
    }
    private void btn8_Clicked(object sender, EventArgs e)
    {
        Detail = new NavigationPage(new CarouselPage());
    }
    private void btn9_Clicked(object sender, EventArgs e)
    {
        Detail = new NavigationPage(new ListViewPage());
    }
    private void btn10_Clicked(object sender, EventArgs e)
    {
        Detail = new NavigationPage(new CollectionView());
    }
    

}