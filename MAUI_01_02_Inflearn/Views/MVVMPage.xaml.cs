using MAUI_01_02_Inflearn.ViewModels;

namespace MAUI_01_02_Inflearn.Views;

public partial class MVVMPage : ContentPage
{
	public MVVMPage()
	{
		InitializeComponent();
		//����� ��°�� �־��ָ� xaml���Ͽ��� ������ ���ε� �ؼ� ��� ���� ����
		BindingContext = new MVVMViewModel();
	}
}