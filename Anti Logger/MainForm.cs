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

        #region " Drag and Drop "

        private void DragNDrop_PANEL_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Gray, ButtonBorderStyle.Dashed);
        }

        private void DragNDrop_PANEL_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
            Status_LABEL.Text = "Status: Locating file.";
        }


        private void DragNDrop_PANEL_DragLeave(object sender, EventArgs e)
        {
            Status_LABEL.Text = "Status: Idle.";
        }

        private void DragNDrop_PANEL_DragDrop(object sender, DragEventArgs e)
        {
            var assemblyFile = (string[]) e.Data.GetData(DataFormats.FileDrop, false);

            try
            {
                AssemblyName.GetAssemblyName(assemblyFile[0]);

                if (assemblyFile.Length != 1)
                {
                    Status_LABEL.Text = "Status: One file is only allowed per process.";
                }
                else
                {
                    Status_LABEL.Text = "Status: Located file, analyzing code.";
                    DragNDrop_PANEL.Enabled = false;

                    var assembly = ModuleDefMD.Load(assemblyFile[0]);

                    GetStrings(assembly);
                    GetMethods(assembly);

                    var form = new PossbilitiesForm(DumpAllMethods(assembly), DumpAllStrings(assembly),
                        StringKeywords(assembly));
                    form.ShowDialog();

                    DragNDrop_PANEL.Enabled = true;
                }
            }
            catch
            {
                Status_LABEL.Text = "Status: File is not a valid .NET assembly.";
            }
        }

        #endregion

        #region " Dnlib "

        private void GetStrings(ModuleDefMD assembly)
        {
            Status_LABEL.Text = $"Status: Extracted strings. Found {DumpAllStrings(assembly).Count()} strings.";
        }

        private void GetMethods(ModuleDefMD assembly)
        {
            Status_LABEL.Text =
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
                }
            return dumpList;
        }

        public IEnumerable<string> StringKeywords(ModuleDefMD mod)
        {
            string[] badKeywords =
            {
                "WebBrowserPassView.exe"
            };

            var dumpList = new List<string>();
            foreach (var td in mod.GetTypes())
            foreach (var mDef in td.Methods)
                if (mDef.HasBody)
                    foreach (var instru in mDef.Body.Instructions)
                        if (Equals(instru.OpCode, OpCodes.Ldstr))
                        {
                            var currentInt = 0;
                            if (instru.ToString().Contains(badKeywords[currentInt++]))
                            {
                                dumpList.Add("NirSoft Malware");
                                dumpList.Add("XStealer");
                                break;
                            }
                        }


            return dumpList;
        }

        #endregion
    }
}