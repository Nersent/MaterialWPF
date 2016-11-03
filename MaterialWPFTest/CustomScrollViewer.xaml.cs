﻿using System;
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

namespace MaterialWPFTest
{
    /// <summary>
    /// Interaction logic for CustomScrollViewer.xaml
    /// </summary>
    public partial class CustomScrollViewer : UserControl
    {
        public CustomScrollViewer()
        {
            InitializeComponent();
            this.Loaded += CustomScrollViewer_Loaded;
        }

        private void CustomScrollViewer_Loaded(object sender, RoutedEventArgs e)
        {
            contextmenu.addItem(new MaterialWPF.MaterialContextMenuItem("XDD"));
        }
    }
}