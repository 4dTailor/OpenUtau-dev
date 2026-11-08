using System.Windows.Forms.VisualStyles;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using OpenUtau.App.Controls;
using OpenUtau.App.ViewModels;
using OpenUtau.Core;
using OpenUtau.Core.Ustx;

namespace OpenUtau.App.Controls;

public partial class ExportUstxDialog : Window {
    private readonly ExportUstxViewModel ViewModel;
    private UProject project;

    public ExportUstxDialog() {
        InitializeComponent();
        DataContext = ViewModel = new ExportUstxViewModel();
        project = new UProject();
    }

    public ExportUstxDialog(UProject project) {
        this.project = project;

        DataContext = ViewModel = new ExportUstxViewModel(project);
    }

    public void OnCancel(object? sender, RoutedEventArgs? args) {
        Close();
    }

    public void OnFinish(object? sender, RoutedEventArgs? args) {
        ViewModel.BatchEditProjectViewModel.RunSelected();
        Close(project);
    }
}
