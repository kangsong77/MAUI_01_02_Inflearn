
namespace MAUI_01_02_Inflearn.Views;

public partial class Event2View : ContentPage
{
	public Event2View()
	{
		InitializeComponent();
	}        

    private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
    {
        var date = sender as DatePicker;
        act.IsRunning = false;
        DisplayAlert("정보", date.Date.ToString("D"), "확인");
    }

    private void chk1_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        lbl2.Text = e.Value.ToString();
    }

    private void stepper_ValueChanged(object sender, ValueChangedEventArgs e)
    {
       // lbl2.Text = stepper.Value.ToString();
        double value = e.NewValue;
        lbl2.Text = value.ToString();

        if(value < 5)
        {
            chk1.IsChecked= true;
            chk2.IsChecked= false;
        }
        else
        {
            chk1.IsChecked= false;
            chk2.IsChecked= true;
        }
    }

    private void sw1_Toggled(object sender, ToggledEventArgs e)
    {
        if (sw1.IsToggled)
        {
            sw1.IsToggled = true;
            sw2.IsToggled = false;
        }
        else
        {
            sw1.IsToggled = false;
            sw2.IsToggled = true;
        }
    }
}