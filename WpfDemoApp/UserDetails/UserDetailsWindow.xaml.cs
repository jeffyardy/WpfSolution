using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
namespace WpfDemoApp.UserDetails
{
  /// <summary>
  /// Interaction logic for UserDetailsWindow.xaml
  /// </summary>
  public partial class UserDetailsWindow : Window
  {

    ObservableCollection<UserDetails> _userdetails;
    public UserDetailsWindow()
    {
      InitializeComponent();
      Loaded += UserDetailsWindow_Loaded;

    }

    private void UserDetailsWindow_Loaded(object sender, RoutedEventArgs e)
    {
      _userdetails = new ObservableCollection<UserDetails>();
      _userdetails.Add(new UserDetails { Username = "jeff", Age = 21, FavColor = "Red" });
      _userdetails.Add(new UserDetails { Username = "jeff1", Age = 21, FavColor = "Red" });
      _userdetails.Add(new UserDetails { Username = "jeff", Age = 21, FavColor = "Red" });


      this.DataContext = _userdetails;
    }

    private void btnadduser_Click(object sender, RoutedEventArgs e)
    {
      _userdetails.Add(new UserDetails { Username = txtusername.Text, Age = Convert.ToInt32(txtage.Text), FavColor = txtfavcolor.Text });
    }
  }
}
