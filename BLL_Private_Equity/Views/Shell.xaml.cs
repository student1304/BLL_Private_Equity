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
using System.Windows.Shapes;
using Telerik.Windows.Controls;

namespace BLL_Private_Equity.Views
{
    /// <summary>
    /// Interaktionslogik für Shell.xaml
    /// </summary>
    public partial class Shell : RadRibbonWindow
    {
        public Shell()
        {
            StyleManager.ApplicationTheme = new MaterialTheme();
            InitializeComponent();
        }
    }
}
