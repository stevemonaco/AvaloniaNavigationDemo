using Avalonia.Controls;
using AvaloniaNavigationDemo.ViewModels;
using System;

namespace AvaloniaNavigationDemo.Views;
public partial class MainWindow : Window
{
    public MainWindowViewModel ViewModel => (MainWindowViewModel)DataContext;

    public MainWindow()
    {
        InitializeComponent();
        Width = 250;
        Height = 500;
    }

    protected override void OnDataContextChanged(EventArgs e)
    {
        ViewModel.PropertyChanged += ViewModel_PropertyChanged;

        base.OnDataContextChanged(e);
    }

    private void ViewModel_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        if (e.PropertyName == "ActiveContent")
        {
            if (ViewModel.ActiveContent is LoginViewModel)
            {
                Width = 250;
                Height = 500;
            }
            else
            {
                Width = 800;
                Height = 600;
            }
        }
    }
}