using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;

namespace AvaloniaNavigationDemo.ViewModels;

public record UserLoggedInMessage(string UserName, string Password);
public record UserLoggedOutMessage();

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty] private ViewModelBase _activeContent;

    private MainViewModel _mainViewModel;
    private LoginViewModel _loginViewModel;

    public MainWindowViewModel(MainViewModel mainViewModel, LoginViewModel loginViewModel)
    {
        _mainViewModel = mainViewModel;
        _loginViewModel = loginViewModel;
        _activeContent = _loginViewModel;

        Messenger.Register<UserLoggedInMessage>(this, (r, m) => ActiveContent = _mainViewModel);
        Messenger.Register<UserLoggedOutMessage>(this, (r, m) => ActiveContent = _loginViewModel);
    }
}
