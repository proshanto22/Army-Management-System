﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Army_Management_System
{
    public partial class About_UserControl : UserControl
    {
        
        private static About_UserControl _instance;

        public static About_UserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new About_UserControl();
                }
                return _instance;
            }
        }
        public About_UserControl()
        {
            InitializeComponent();
        }
    }
}
