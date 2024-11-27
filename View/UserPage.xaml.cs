namespace Module08.View;
using Module08.ViewModel; //Add this line

public partial class UserPage : ContentPage
{
    public UserPage()
    {
        InitializeComponent();
        BindingContext = new UserViewModel();
    }
}