using MAUI_01_02_Inflearn.Views;

namespace MAUI_01_02_Inflearn;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
    }

    //<!--ch05_FlyoutPage-->
    private void menu1_Clicked(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new FirstPage());
    }

    private void menu2_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Page1());
    }
}
