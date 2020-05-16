using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DataBinding
{
    /// <summary>
    /// Interaction logic for DataContext.xaml
    /// </summary>
    public partial class DataContext : Window
    {
        public DataContext()
        {
            InitializeComponent();
            this.DataContext = this;
        }
    }
}
