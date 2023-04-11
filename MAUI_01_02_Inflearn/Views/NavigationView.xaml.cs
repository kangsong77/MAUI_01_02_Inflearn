namespace MAUI_01_02_Inflearn.Views;

public partial class NavigationView : ContentPage
{
	public NavigationView()
	{
		InitializeComponent();
	}

    private void btn1_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Page2());
    }

    private void btn2_Clicked(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new Page2());
    }
}