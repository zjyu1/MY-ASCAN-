﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ascan
{
    public partial class FormProbeDelay : Form
    {
        public FormProbeDelay()
        {
            InitializeComponent();
        }

        private void FormProbeDelay_Load(object sender, EventArgs e)
        {
            MultiLanguage.getNames(this);
        }
    }
}
