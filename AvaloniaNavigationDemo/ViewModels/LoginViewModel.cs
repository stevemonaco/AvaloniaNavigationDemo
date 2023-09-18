using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using System.Threading.Tasks;

namespace AvaloniaNavigationDemo.ViewModels;
public partial class LoginViewModel : ViewModelBase
{
    [ObservableProperty] private string _userName = "";
    [ObservableProperty] private string _password = "";

    [RelayCommand]
    public async Task Login()
    {
        await Task.Delay(50);

        Messenger.Send(new UserLoggedInMessage(UserName, Password));
    }
}
