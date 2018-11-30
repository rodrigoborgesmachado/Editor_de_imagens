using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editor_de_Imagens
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DirectoryInfo diretorio = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory.ToString() + "OUT\\");
            if (!diretorio.Exists)
                diretorio.Create();
            else
            {
                foreach (FileInfo arq in diretorio.GetFiles())
                {
                    arq.Delete();
                }
            }

            Application.Run(new FO_Principal());
        }
    }
}
