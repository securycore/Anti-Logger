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

        #region " Menu Strip "

        private void contextStrip_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = listPossbilities.SelectedItems.Count <= 0 || listPossbilities.SelectedItems.Count <= 0;
        }


        private void copyToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (listPossbilities.Focused)
                Clipboard.SetText(listPossbilities.Text);

            if (listStrings.Focused)
                Clipboard.SetText(listStrings.Text);
        }

        #endregion

    }
}