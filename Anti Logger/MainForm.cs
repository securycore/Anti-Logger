using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

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

        #region " Dnlib "

        private void GetStrings(ModuleDefMD assembly)
        {
            statusLabel.Text = $"Status: Extracted strings. Found {DumpAllStrings(assembly).Count()} strings.";
        }

        private void GetMethods(ModuleDefMD assembly)
        {
            statusLabel.Text =
                $"Status: Extracted methods. Found {DumpAllMethods(assembly).Count()} possiblities and {StringKeywords(assembly).Count()} suspicious keywords.";
        }

        public IEnumerable<string> DumpAllStrings(ModuleDefMD mod)
        {
            var dumpList = new List<string>();
            foreach (var td in mod.GetTypes())
            foreach (var mDef in td.Methods)
                if (mDef.HasBody)
                    foreach (var instru in mDef.Body.Instructions)
                        if (Equals(instru.OpCode, OpCodes.Ldstr))
                            dumpList.Add(instru.ToString());
            return dumpList;
        }

        public IEnumerable<string> DumpAllMethods(ModuleDefMD mod)
        {
            var dumpList = new List<string>();
            foreach (var td in mod.GetTypes())
            foreach (var mDef in td.Methods)
                switch (mDef.Name)
                {
                    case "SendLinks":
                        dumpList.Add("browserLoot");
                        break;
                    case "RunInstallationLogic":
                        dumpList.Add("Cookie Ghost");
                        break;
                    case "IRAGC":
                        dumpList.Add("Sir Cookie");
                        dumpList.Add("Cookie Venom");
                        break;
                    case "RedirectStandardOutput":
                        dumpList.Add("QuasarRAT");
                        break;
                    case "GetWindowText":
                        dumpList.Add("Common RAT *");
                        break;
                    case "Sendb":
                        dumpList.Add("njRAT");
                        break;
                    case "gatherticket":
                        dumpList.Add("Cookie Muncher");
                        break;
                    case "GetAntiVirus":
                        dumpList.Add("Predator Logger");
                        break;
                    case "DLrun":
                        dumpList.Add("Vulcan Logger");
                        break;
                    case "mulai":
                        dumpList.Add("NingaliNET");
                        break;
                    case "get_BuilderSettings":
                        dumpList.Add("NanoCore");
                        break;
                    case "maine":
                        dumpList.Add("Comet RAT");
                        break;
                    case "CIVC":
                        dumpList.Add("Revenge RAT");
                        break;
                    case "RecoverCookies":
                        dumpList.Add("rbxWorkshop");
                        break;
                }
            return dumpList;
        }

        public IEnumerable<string> StringKeywords(ModuleDefMD mod)
        {
            string[] badKeywords =
            {
                "powershell Add-MpPreference -ExclusionPath",
                "WebBrowserPassView.exe"
            };

            var dumpList = new List<string>();
            foreach (var td in mod.GetTypes())
            foreach (var mDef in td.Methods)
                if (mDef.HasBody)
                    foreach (var instru in mDef.Body.Instructions)
                        if (Equals(instru.OpCode, OpCodes.Ldstr))
                            foreach (var badKeyword in badKeywords)
                                if (instru.ToString().Contains(badKeyword))
                                {
                                    dumpList.Add("NirSoft Malware");
                                    dumpList.Add("XStealer");
                                    dumpList.Add("Windows Defender Disabler");
                                    break;
                                }

            return dumpList;
        }

        #endregion
    }
}