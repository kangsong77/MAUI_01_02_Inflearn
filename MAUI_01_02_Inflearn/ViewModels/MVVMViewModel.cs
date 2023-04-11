using MAUI_01_02_Inflearn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MAUI_01_02_Inflearn.ViewModels
{
    //ch_19_MVVM-1
    //마소문서: https://learn.microsoft.com/ko-kr/dotnet/maui/xaml/fundamentals/mvvm?view=net-maui-7.0
    
    public class MVVMViewModel
    {
        public Foods foods { get; set; }
        public List<Person> persons { get; set; }
        public ICommand btnCommand { get; } //버튼 이벤트
        public ICommand btnCommand2 { get; } //파라미터 있는 버튼 이벤트
        public MVVMViewModel()
        {
            foods= new Foods() { 
                Name="아보카도",
                Price= 3000,
                Stock=100
            };

            //컬렉션뷰 위한 데이터
            persons = new List<Person>()
            {
                new Person(){ Name="홍길동", Age = 100, Image="dotnet_bot.svg", Human=true, Human2="YES"},
                new Person(){ Name="임꺽정", Age = 50, Image="dotnet_bot.svg", Human=true, Human2="YES"},
                new Person(){ Name="타요", Age = 10, Image="dotnet_bot.svg", Human=false, Human2="NO"},
                new Person(){ Name="핑크퐁", Age = 7, Image="dotnet_bot.svg", Human=false, Human2="NO"},
            };

            btnCommand = new Command(()=>
            {
                App.Current.MainPage.DisplayAlert("정보", "클릭", "확인");
            });

            //a를 통해서 매게변수 받음
            btnCommand2 = new Command((a) =>
            {
                App.Current.MainPage.DisplayAlert("정보", a.ToString(), "확인");
            });
        }
    }
}
