namespace MAUI_01_02_Inflearn.Views;

public partial class EventView : ContentPage
{
	public EventView()
	{
		InitializeComponent();
	}

    private void btn_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("����",btn.Text + "�Դϴ�.", "Ȯ��");
    }

    private void imgBtn_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("����", imgBtn.Source.ToString(), "Ȯ��");
    }

    private void radioBtn_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        DisplayAlert("����", e.Value.ToString(), "Ȯ��");
    }
    private void radioBtn_CheckedChanged_1(object sender, CheckedChangedEventArgs e)
    {
        //���õȰ� True�߻�, ���� ��ҵȰ� False �߻� =>true�ΰ͸� ��������
        if (e.Value)
        {
            var radio = sender as RadioButton;
            //DisplayAlert("����", radio.ContentAsString(), "Ȯ��");
            DisplayAlert("����", radio.Content.ToString(), "Ȯ��");
        }
    }

    private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
    {
        var label = sender as Label;
        DisplayAlert("����", label.Text, "Ȯ��");

    }

    private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
    {
        DisplayAlert("����", "�ڽ���Ŭ��", "Ȯ��");
    }

    private void Entry_TextChanged(object sender, TextChangedEventArgs e)
    {
        var entry = sender as Entry;
        DisplayAlert("����", entry.Text, "Ȯ��");
    }
}