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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF.MarkupExtension
{
    /// <summary>
    /// Interaction logic for CustomUC.xaml
    /// </summary>
    public partial class CustomUC : UserControl
    {
        public CustomUC()
        {
            InitializeComponent();
        }

        public string Property2
        {
            get { return (string)GetValue(Property1Property); }
            set { SetValue(Property1Property, value); }
        }

        public static readonly DependencyProperty Property1Property = DependencyProperty.Register(
          "Property2",
          typeof(string),
          typeof(CustomUC),
          new PropertyMetadata("Default value")
      );

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ((Button)sender).Content = Property2;
        }
    }
}
