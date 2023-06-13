using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PaggingControlProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void pageControl_PreviewPageChange(object sender, PageChangedEventArgs args)
        {
            List<Object> items = pageControl.ItemsSource.ToList();
            int count = items.Count;
        }

        private void pageControl_PageChanged(object sender, PageChangedEventArgs args)
        {
            List<Object> items = pageControl.ItemsSource.ToList();
            int count = items.Count;
        }
    }
}
