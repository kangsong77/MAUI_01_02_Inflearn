namespace MAUI_01_02_Inflearn.Views;

public partial class Page3 : ContentPage
{
	public Page3()
	{
		InitializeComponent();
	}

    //이전화면
    private void btn1_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

    //첫화면
    private void btn2_Clicked(object sender, EventArgs e)
    {
        Navigation.PopToRootAsync();
    }

    //모달닫기
    private void btn3_Clicked(object sender, EventArgs e)
    {
        Navigation.PopModalAsync();
    }
}