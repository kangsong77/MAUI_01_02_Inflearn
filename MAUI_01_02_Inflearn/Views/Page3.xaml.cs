namespace MAUI_01_02_Inflearn.Views;

public partial class Page3 : ContentPage
{
	public Page3()
	{
		InitializeComponent();
	}

    //����ȭ��
    private void btn1_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

    //ùȭ��
    private void btn2_Clicked(object sender, EventArgs e)
    {
        Navigation.PopToRootAsync();
    }

    //��޴ݱ�
    private void btn3_Clicked(object sender, EventArgs e)
    {
        Navigation.PopModalAsync();
    }
}