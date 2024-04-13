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

namespace db2
{
    public partial class ThirdGrid : Page
    {
        private ITCompanyEntities context = new ITCompanyEntities();

        public ThirdGrid()
        {
            InitializeComponent();
            TasksDataGrid.ItemsSource = context.Tasks.ToList();
        }
    }
}