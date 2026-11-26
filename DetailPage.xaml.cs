using MAUIApp1.ViewModel;
namespace MAUIApp1;



public partial class DetailPage : ContentPage
{
	public DetailPage(DetailViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}

}
