using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Anti_Logger
{
    public partial class PossbilitiesForm : Form
    {
        public PossbilitiesForm(IEnumerable<string> possbilities, IEnumerable<string> strings)
        {
            InitializeComponent();

            listPossbilities.DataSource = possbilities;
            listStrings.DataSource = strings;
        }
    }
}
