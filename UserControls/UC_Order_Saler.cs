﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShopManagement.UserControls
{
    public partial class UC_Order_Saler : UserControl
    {
        public UC_Order_Saler()
        {
            InitializeComponent();
            cbHinhthuc.SelectedIndex = 0;
        }
    }
}
