﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertGPT.MainScene
{
    public partial class GuideScreen : UserControl
    {
        public GuideScreen()
        {
            InitializeComponent();
        }

        private void GuideScreen_Load(object sender, EventArgs e)
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }
    }
}
