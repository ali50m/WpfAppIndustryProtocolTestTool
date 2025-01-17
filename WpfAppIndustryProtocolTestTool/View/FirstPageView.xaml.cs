﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace WpfAppIndustryProtocolTestTool.View
{
    /// <summary>
    /// Interaction logic for Default.xaml
    /// </summary>
    public partial class FirstPageView : UserControl
    {
        public FirstPageView()
        {
            InitializeComponent();
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            Hyperlink? link = sender as Hyperlink;
            if (link!=null)
            {
                Process.Start(new ProcessStartInfo { FileName = link.NavigateUri.AbsoluteUri, UseShellExecute = true });
            }
        }
    }
}
