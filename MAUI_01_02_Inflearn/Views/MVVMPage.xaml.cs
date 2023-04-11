using MAUI_01_02_Inflearn.ViewModels;

namespace MAUI_01_02_Inflearn.Views;

public partial class MVVMPage : ContentPage
{
	public MVVMPage()
	{
		InitializeComponent();
		//뷰모델을 통째로 넣어주면 xaml파일에서 데이터 바인딩 해서 모두 쓸수 있음
		BindingContext = new MVVMViewModel();
	}
}