using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Anti_Logger
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        #region " Panel "

        private void dragPanel_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Gray, ButtonBorderStyle.Dashed);
        }

        private void dragPanel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void dragPanel_DragDrop(object sender, DragEventArgs e)
        {
            var assemblyFiles = (string[]) e.Data.GetData(DataFormats.FileDrop, false);

            try
            {
                AssemblyName.GetAssemblyName(assemblyFiles[0]);

                if (assemblyFiles.Length != 1)
                {
                    MessageBox.Show(this, $"Please only scan one assembly at a time!", "Anti-Logger",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    dragPanel.Enabled = false;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(this, $"An exception has been thrown. \r\n {exception.Message}", "Anti-Logger",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}