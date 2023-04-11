using MAUI_01_02_Inflearn.Views;

namespace MAUI_01_02_Inflearn;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
        //최초 스타트!! 쉘은 다른 컨텐트 페이지 실행 가능
        //App->AppShell->MainPage
        //바로 MainPage를 실행할수도 있음
        //MainPage = new MainPage();
        //MainPage = new AppShell();

        //ch03_tabepage 
        //MainPage = new FirstPage();

        //ch05_FlyoutPage 
        //MainPage = new AppShell();

        //ch06_FlyoutPage 기능추가
        //MainPage = new MainView();

        //ch18_콜렉션뷰로 메뉴구성 다시하기
        MainPage = new MainView2();
    }
}
