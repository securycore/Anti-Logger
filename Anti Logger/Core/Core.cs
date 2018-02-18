using System.Collections.Generic;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace Anti_Logger.Core
{
    internal class Core
    {
        public IEnumerable<string> GetStrings(ModuleDefMD mod)
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

        public IEnumerable<string> GetMethods(ModuleDefMD mod)
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

        //public IEnumerable<string> GetKeywords(ModuleDefMD mod)
        //{
        //    string[] badKeywords =
        //    {
        //        "powershell Add-MpPreference -ExclusionPath",
        //        "WebBrowserPassView.exe"
        //    };

        //    var dumpList = new List<string>();
        //    foreach (var td in mod.GetTypes())
        //        foreach (var mDef in td.Methods)
        //            if (mDef.HasBody)
        //                foreach (var instru in mDef.Body.Instructions)
        //                    if (Equals(instru.OpCode, OpCodes.Ldstr))
        //                        foreach (var badKeyword in badKeywords)
        //                            if (instru.ToString().Contains(badKeyword))
        //                            {
        //                                dumpList.Add("NirSoft Malware");
        //                                dumpList.Add("XStealer");
        //                                dumpList.Add("Windows Defender Disabler");
        //                                break;
        //                            }

        //    return dumpList;
    }
}