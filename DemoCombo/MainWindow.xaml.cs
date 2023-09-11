using DemoCombo.Annotations;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace DemoCombo
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window, INotifyPropertyChanged
  {
    private string _selectedParam;


    public MainWindow()
    {
      InitializeComponent();

    }

    public string SelectedParam
    {
      get { return _selectedParam; }
      set
      {
        if (value == _selectedParam) return;
        _selectedParam = value;
        OnPropertyChanged();
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    [NotifyPropertyChangedInvocator]
    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
