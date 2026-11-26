using MAUIApp1.ViewModel;
namespace MAUIApp1;

public partial class MainPage : ContentPage
{

	public MainPage(MainViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}

	
}
