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

namespace KP.Pages
{
    /// <summary>
    /// Логика взаимодействия для AnalizControl.xaml
    /// </summary>
    public partial class AnalizControl : Page
    {
        public bool IsEditor { get; set; }
        public AnalizControl(bool isEditor)
        {
            InitializeComponent();
            IsEditor = isEditor;
            DataContext = this;
        }
    }
}
