namespace MAUI_01_02_Inflearn.Views;

public partial class Page2 : ContentPage
{
	public Page2()
	{
		InitializeComponent();
	}

    private void btn1_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Page3());
    }

    private void btn2_Clicked(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new Page3());
    }
}