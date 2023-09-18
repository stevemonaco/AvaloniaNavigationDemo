using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace AvaloniaNavigationDemo.ViewModels;
public partial class DocumentViewModel : ViewModelBase
{
    [ObservableProperty] private string _title;
    [ObservableProperty] private ObservableCollection<DocumentPageViewModel> _pages = new();
    [ObservableProperty] private DocumentPageViewModel _selectedPage;
}
