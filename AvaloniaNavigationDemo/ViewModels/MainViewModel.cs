using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace AvaloniaNavigationDemo.ViewModels;
public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty] private string? _loggedInUserName;
    [ObservableProperty] private DocumentViewModel _selectedDocument;

    [ObservableProperty]
    private ObservableCollection<DocumentViewModel> _documents = new()
    {
        new DocumentViewModel()
        {
            Title = "Product 1",
            Pages = new()
            {
                new DocumentPageViewModel() { Title = "Description", Content = "Text Editor here" },
                new DocumentPageViewModel() { Title = "Pillars", Content = "Text Editor here" },
                new DocumentPageViewModel() { Title = "TargetPlatforms", Content = "Text Editor here" },
                new DocumentPageViewModel() { Title = "Schedule", Content = "Text Editor here" },
            },
        },
        new DocumentViewModel()
        {
            Title = "Product 2",
            Pages = new()
            {
                new DocumentPageViewModel() { Title = "Description", Content = "Text Editor here" },
                new DocumentPageViewModel() { Title = "Pillars", Content = "Text Editor here" },
                new DocumentPageViewModel() { Title = "TargetPlatforms", Content = "Text Editor here" },
                new DocumentPageViewModel() { Title = "Schedule", Content = "Text Editor here" },

                new DocumentPageViewModel() { Title = "Camera and Controls", Content = "Text Editor here" },
                new DocumentPageViewModel() { Title = "Player Character", Content = "Text Editor here" },
                new DocumentPageViewModel() { Title = "Building and Construction", Content = "Text Editor here" },
                new DocumentPageViewModel() { Title = "Equipment", Content = "Text Editor here" },
            }
        },
    };

    public MainViewModel()
    {
        SelectedDocument = Documents.First();
        Messenger.Register<UserLoggedInMessage>(this, UserLoggedIn);
    }

    [RelayCommand] public async Task Logout()
    {
        await Task.Delay(50);
        Messenger.Send(new UserLoggedOutMessage());
    }

    private void UserLoggedIn(object recipient, UserLoggedInMessage message)
    {
        LoggedInUserName = message.UserName;
    }
}
