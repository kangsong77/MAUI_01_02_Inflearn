namespace MAUI_01_02_Inflearn.Views;

public partial class EventView : ContentPage
{
	public EventView()
	{
		InitializeComponent();
	}

    private void btn_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("정보",btn.Text + "입니다.", "확인");
    }

    private void imgBtn_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("정보", imgBtn.Source.ToString(), "확인");
    }

    private void radioBtn_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        DisplayAlert("정보", e.Value.ToString(), "확인");
    }
    private void radioBtn_CheckedChanged_1(object sender, CheckedChangedEventArgs e)
    {
        //선택된건 True발생, 선택 취소된건 False 발생 =>true인것만 나오도록
        if (e.Value)
        {
            var radio = sender as RadioButton;
            //DisplayAlert("정보", radio.ContentAsString(), "확인");
            DisplayAlert("정보", radio.Content.ToString(), "확인");
        }
    }

    private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
    {
        var label = sender as Label;
        DisplayAlert("정보", label.Text, "확인");

    }

    private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
    {
        DisplayAlert("정보", "박스뷰클릭", "확인");
    }

    private void Entry_TextChanged(object sender, TextChangedEventArgs e)
    {
        var entry = sender as Entry;
        DisplayAlert("정보", entry.Text, "확인");
    }
}