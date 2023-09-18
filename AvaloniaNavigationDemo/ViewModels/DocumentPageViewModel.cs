using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaloniaNavigationDemo.ViewModels;
public partial class DocumentPageViewModel : ViewModelBase
{
    [ObservableProperty] private string _title = "";
    [ObservableProperty] private string _content = "";
}
