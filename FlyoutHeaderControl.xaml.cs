namespace mycustomerloginapp.UserControl;

public partial class FlyoutHeaderControl : ContentView
{
	public FlyoutHeaderControl()
	{
		InitializeComponent();
		if(App.UserInfo != null)
		{
			lblUserName.Text = "Logged in :" + App.UserInfo.UserName;
			lblUserEmail.Text = App.UserInfo.UserName;
		}
	}
}