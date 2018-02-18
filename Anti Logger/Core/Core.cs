using System.Collections.Generic;
using System.Linq;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace Anti_Logger.Core
{
    internal class Core
    {
        public IEnumerable<string> GetStrings(ModuleDefMD assembly)
        {
            var stringList = new List<string>();

            foreach (var types in assembly.GetTypes())
            foreach (var methods in types.Methods)
                if (methods.HasBody)
                    foreach (var instru in methods.Body.Instructions)
                        if (Equals(instru.OpCode, OpCodes.Ldstr))
                            stringList.Add(instru.ToString());

            return stringList;
        }

        public IEnumerable<string> GetMethods(ModuleDefMD assembly)
        {
            var methodList = new List<string>();

            foreach (var types in assembly.GetTypes())
            foreach (var methods in types.Methods)
                switch (methods.Name)
                {
                    case "SendLinks":
                        methodList.Add("browserLoot");
                        break;
                    case "RunInstallationLogic":
                        methodList.Add("Cookie Ghost");
                        break;
                    case "IRAGC":
                        methodList.Add("Cookie Venom");
                        break;
                    case "RedirectStandardOutput":
                        methodList.Add("QuasarRAT");
                        break;
                    case "GetWindowText":
                        methodList.Add("Common RAT *");
                        break;
                    case "Sendb":
                        methodList.Add("njRAT");
                        break;
                    case "gatherticket":
                        methodList.Add("Cookie Muncher");
                        break;
                    case "GetAntiVirus":
                        methodList.Add("Predator Logger");
                        break;
                    case "DLrun":
                        methodList.Add("Vulcan Logger");
                        break;
                    case "mulai":
                        methodList.Add("NingaliNET");
                        break;
                    case "get_BuilderSettings":
                        methodList.Add("NanoCore");
                        break;
                    case "maine":
                        methodList.Add("Comet RAT");
                        break;
                    case "CIVC":
                        methodList.Add("Revenge RAT");
                        break;
                    case "RecoverCookies":
                        methodList.Add("rbxWorkshop");
                        break;
                    default:
                        break;
                }

            return methodList;
        }

        public IEnumerable<string> GetKeywords(ModuleDefMD mod)
        {
            var keywordsList = new List<string>();

            string[] badKeywords =
            {
                "powershell Add-MpPreference -ExclusionPath",
                "WebBrowserPassView.exe"
            };

            foreach (var td in mod.GetTypes())
            foreach (var mDef in td.Methods)
                if (mDef.HasBody)
                    foreach (var instru in mDef.Body.Instructions)
                        if (Equals(instru.OpCode, OpCodes.Ldstr))
                            foreach (var badKeyword in badKeywords)
                                if (instru.ToString().Contains(badKeyword))
                                {
                                    keywordsList.Add("NirSoft Malware");
                                    keywordsList.Add("XStealer");
                                    keywordsList.Add("Windows Defender Disabler");
                                    break;
                                }

            return keywordsList.Distinct().ToList();
        }
    }
}