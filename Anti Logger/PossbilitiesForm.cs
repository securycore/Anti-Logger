using System.Collections.Generic;
using System.Windows.Forms;

namespace Anti_Logger
{
    public partial class PossbilitiesForm : Form
    {
        public PossbilitiesForm(IEnumerable<string> possbilities, IEnumerable<string> strings,
            IEnumerable<string> keywords)
        {
            InitializeComponent();

            var totalPossiblities = new List<string>();

            foreach (var possbility in possbilities)
                totalPossiblities.Add(possbility);

            foreach (var keyword in keywords)
                totalPossiblities.Add(keyword);

            listPossbilities.DataSource = totalPossiblities;
            listStrings.DataSource = strings;
        }
    }
}