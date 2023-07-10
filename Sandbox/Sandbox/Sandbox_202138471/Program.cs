using Sandbox.Model;
using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Security;
using System.Security.Policy;
using System.Windows.Forms;

namespace Sandbox_202138471
{
    public class Program : MarshalByRefObject
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        // defines for commandline output
        [DllImport("kernel32.dll")]
        static extern bool AttachConsole(int dwProcessId);
        private const int ATTACH_PARENT_PROCESS = -1;

        [STAThread]
        static void Main(string[] args)
        {
            AttachConsole(ATTACH_PARENT_PROCESS);

            if (args.Length > 0)
            {
                Console.WriteLine("Please provide arguments in the following order and format (Entry Point will be picked from the assembly): appfolderpath e.g C:/ <SPACE>classpath e.g Fruit.Apple<SPACE>args e.g (0,1,2,3)<SPACE>permission e.g (0,1,2,3,4,5,6,7,8,9,10,11,12) <SPACE>filepath e.g C:/temp.txt ");
                Util utl = new Util();
                utl.CommandSandbox(args);
                System.Windows.Forms.SendKeys.SendWait("{ENTER}");
                Application.Exit();
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Sandbox());
            }
        }

        public void createAppDomain(PermissionSet permSet, string pathToUntrusted, string untrustedClass, string entryPoint, string[] parameters)
        {
            try
            { 
            //Setting the AppDomainSetup.
            AppDomainSetup adSetup = new AppDomainSetup();
            adSetup.ApplicationBase = Path.GetFullPath(pathToUntrusted);

            //Strong naming the sandbox assembly, in porder to add it to the full trust list.
            StrongName fullTrustAssembly = typeof(Sandbox).Assembly.Evidence.GetHostEvidence<StrongName>();

            AppDomain newDomain = AppDomain.CreateDomain("Sandbox", null, adSetup, permSet, fullTrustAssembly);

            //Using CreateInstanceFrom to load an instance of the Sandbox - Program class into the new AppDomain.
            ObjectHandle handle = Activator.CreateInstanceFrom(
                newDomain, typeof(Program).Assembly.ManifestModule.FullyQualifiedName,
                typeof(Program).FullName
                );

            //Loading Assembly name
            AsmRequestDto untrustedAssembly = new Util().AssemblyNameSearch(pathToUntrusted);
                if(entryPoint.Equals(""))
                {
                    entryPoint = untrustedAssembly.entryPoint;
                }
            try
            {
                //Unwrapping the new domain instance into a reference in the domain to be used in executing the untrusted code.
                Program newDomainInstance = (Program)handle.Unwrap();
                newDomainInstance.ExecuteUntrustedCode(untrustedAssembly.fileName, untrustedClass, entryPoint, parameters, pathToUntrusted);
            }
            catch (SecurityException ex)
            {
                MessageBox.Show("Please provide the right permission(s)", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
}

        public void ExecuteUntrustedCode(string assemblyName, string typeName, string entryPoint, string[] parameters, string pathToUntrusted)
        {
            //Loading the MethodInfo for a method in the new Assembly.
            MethodInfo target = Assembly.Load(assemblyName).GetType(typeName).GetMethod(entryPoint);
            try
            {
                //Invoking the method
                if (parameters.Length == 1 && parameters[0].Equals(""))
                {
                    parameters[0] = null;
                    object valu = target.Invoke(null, parameters);
                }
                else
                {
                    object valu = target.Invoke(null, parameters);
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Cannot perform CAS Asserts in Security Transparent methods", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (MethodAccessException ex)
            {
                MessageBox.Show("Attempt to access method " + entryPoint + " failed. " + assemblyName, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (SecurityException ex)
            {
                MessageBox.Show("Please provide the right permission(s)", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


    }
}
