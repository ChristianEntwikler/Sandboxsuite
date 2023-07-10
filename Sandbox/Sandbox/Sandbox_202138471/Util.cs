using Sandbox.Model;
using System;
using System.Drawing.Printing;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.Remoting;
using System.Security;
using System.Security.Permissions;
using System.Security.Policy;
using System.Windows.Forms;

namespace Sandbox_202138471
{
    class Util
    {

        

        //Searching for exe or dll in the folder path provided
        public AsmRequestDto AssemblyNameSearch(string pathToUntrusted)
        {
            AsmRequestDto req = AssemblyNameLoader(pathToUntrusted, "exe");
            if (req.fileName == null || req.fileName.Length < 1)
            {
               req = AssemblyNameLoader(pathToUntrusted, "dll");
            }

            return req;
        }

        //Fetching the exe or dll name from the folder path provided
        private AsmRequestDto AssemblyNameLoader(string pathToUntrusted, string extension)
        {
            AsmRequestDto req = new AsmRequestDto();
            try
            {
                string[] loadDll = Directory.GetFiles(pathToUntrusted, "*." + extension);

                if (loadDll.Length > 0)
                {
                    foreach (string file in loadDll)
                    {
                        Assembly asm = Assembly.LoadFile(file);
                        req.entryPoint = asm.EntryPoint.Name;
                        req.fileName = (Path.GetFileNameWithoutExtension(file));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return req;
        }


        
        public void CommandSandbox(string[] args)
        {
            try
            { 
            String appFolderPath = "";
            String appClassPath = "";
            String entryPoint = "";
            String filePath = "";
            String[] argsParams = null;
            String[] permissionParams = null;

            PermissionSet permSet = new PermissionSet(PermissionState.None);

            for (int i=0; i<args.Length; i++)
            {
                if(i==0)
                {
                    appFolderPath = args[i];
                }
                if(i==1)
                {
                    appClassPath = args[i];
                }
                if(i==2)
                {
                    argsParams = args[i].ToString().Replace("(","").Replace(")","").Split(',');
                }
                
                if (i == 3)
                {
                    permissionParams = args[i].ToString().Replace("(", "").Replace(")", "").Split(',');
                }
                if (i == 4)
                {
                    filePath = args[i];
                }

            }

            //Add supplied permissions
            if (permissionParams.Length > 0)
            {
                if (permissionParams.Length > 0 && !permissionParams[0].Equals(""))
                {
                    for (int p = 0; p < permissionParams.Length; p++)
                    {
                        if (permissionParams[p].Equals("0"))
                        {
                            EnvironmentPermission evr = new EnvironmentPermission(EnvironmentPermissionAccess.Read, "USERNAME");
                            permSet.AddPermission(evr);
                            try
                            {
                                permSet.Demand();
                            }
                            catch (SecurityException s)
                            {
                                MessageBox.Show(s.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                            //"Adding permission to read environment variable COMPUTERNAME.";
                            EnvironmentPermission evr2 = new EnvironmentPermission(EnvironmentPermissionAccess.Read, "COMPUTERNAME");
                            permSet.AddPermission(evr2);

                            // Demand the permissions in the set.
                            try
                            {
                                evr2.Demand();
                            }
                            catch (SecurityException s)
                            {
                                MessageBox.Show(s.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        if (permissionParams[p].Equals("1"))
                        {
                            permSet.AddPermission(new SecurityPermission(SecurityPermissionFlag.Execution));
                            permSet.Demand();
                        }
                        if (permissionParams[p].Equals("2"))
                        {
                            permSet.AddPermission(new UIPermission(PermissionState.Unrestricted));
                            permSet.Demand();
                        }

                        if (permissionParams[p].Equals("3"))
                        {
                            FileIOPermission fileReada = new FileIOPermission(FileIOPermissionAccess.Read | FileIOPermissionAccess.PathDiscovery, filePath);
                            try
                            {
                                fileReada.Demand();
                            }
                            catch (SecurityException s)
                            {
                                MessageBox.Show(s.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            permSet.AddPermission(fileReada);
                        }
                        if (permissionParams[p].Equals("4"))
                        {
                            FileIOPermission fileWrita = new FileIOPermission(FileIOPermissionAccess.Read, filePath);
                            fileWrita.AddPathList(FileIOPermissionAccess.Write | FileIOPermissionAccess.Read, filePath);
                            permSet.AddPermission(fileWrita);
                            try
                            {
                                fileWrita.Demand();
                            }
                            catch (SecurityException s)
                            {
                                MessageBox.Show(s.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                        if (permissionParams[p].Equals("5"))
                        {
                            FileIOPermission fileWrita = new FileIOPermission(FileIOPermissionAccess.Read, filePath);
                            fileWrita.AddPathList(FileIOPermissionAccess.Append | FileIOPermissionAccess.Write | FileIOPermissionAccess.Read, filePath);
                            permSet.AddPermission(fileWrita);
                            try
                            {
                                fileWrita.Demand();
                            }
                            catch (SecurityException s)
                            {
                                MessageBox.Show(s.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                        if (permissionParams[p].Equals("6"))
                        {
                            permSet.AddPermission(new FileDialogPermission(FileDialogPermissionAccess.Open));
                            //Demanding permission to open a file
                            try
                            {
                                permSet.Demand();
                            }
                            catch (SecurityException s)
                            {
                                MessageBox.Show(s.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        if (permissionParams[p].Equals("7"))
                        {
                            //Adding permission to save a file from a file dialog box
                            permSet.AddPermission(new FileDialogPermission(FileDialogPermissionAccess.Save));

                            //Demanding permission to open and save a file
                            try
                            {
                                permSet.Demand();
                            }
                            catch (SecurityException s)
                            {
                                MessageBox.Show(s.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        if (permissionParams[p].Equals("8"))
                        {
                            // Create a WebPermission  instance.
                            WebPermission webPermission = new WebPermission(PermissionState.Unrestricted);

                            // Check for permission.
                            try
                            {
                                webPermission.Demand();
                            }
                            catch (SecurityException s)
                            {
                                MessageBox.Show(s.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            permSet.AddPermission(webPermission);
                        }
                        if (permissionParams[p].Equals("9"))
                        {
                            // Create a WebBrowserPermission  instance.
                            WebBrowserPermission webPermission = new WebBrowserPermission(PermissionState.Unrestricted);

                            // Check for permission.
                            try
                            {
                                webPermission.Demand();
                            }
                            catch (SecurityException s)
                            {
                                MessageBox.Show(s.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            permSet.AddPermission(webPermission);
                        }

                        if (permissionParams[p].Equals("10"))
                        {
                            SocketPermission mySocketPermission = new SocketPermission(PermissionState.Unrestricted);
                            permSet.AddPermission(mySocketPermission);

                        }

                        if (permissionParams[p].Equals("11"))
                        {
                            // Create a DnsPermission instance.
                            DnsPermission dnsPermission = new DnsPermission(PermissionState.Unrestricted);

                            // Check for permission.
                            try
                            {
                                dnsPermission.Demand();
                            }
                            catch (SecurityException s)
                            {
                                MessageBox.Show(s.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            permSet.AddPermission(dnsPermission);
                        }

                        if (permissionParams[p].Equals("12"))
                        {
                            // Create a PrintingPermission instance.
                            PrintingPermission printPermission = new PrintingPermission(PermissionState.Unrestricted);

                            // Check for permission.
                            try
                            {
                                printPermission.Demand();
                            }
                            catch (SecurityException s)
                            {
                                MessageBox.Show(s.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            permSet.AddPermission(printPermission);
                        }

                    }
                }
            }

            if (appFolderPath.Length != 0 && appClassPath.Length != 0)
            {
                new Program().createAppDomain(permSet, appFolderPath, appClassPath, entryPoint, argsParams);
            }
            else
            {
                Console.WriteLine("Application Folder Path and Class Path cannot be empty");
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void WriteToFile(string Message)
        {

            string path = AppDomain.CurrentDomain.BaseDirectory + "\\SandboxLogs";

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            string filepath = AppDomain.CurrentDomain.BaseDirectory + "\\SandboxLogs\\Log_" + DateTime.Now.Date.ToShortDateString().Replace('/', '_') + ".txt";

            if (!File.Exists(filepath))
            {
                using (StreamWriter sw = File.CreateText(filepath))
                {

                    sw.WriteLine(Message);

                }

            }
            else
            {

                using (StreamWriter sw = File.AppendText(filepath))
                {

                    sw.WriteLine(Message);

                }

            }

        }
    }
}
