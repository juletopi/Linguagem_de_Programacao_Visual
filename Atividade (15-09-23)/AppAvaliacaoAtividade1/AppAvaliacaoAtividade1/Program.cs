using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAvaliacaoAtividade1
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AtividadeAvaliativa1());
            string username = Environment.UserName;
            string computerName = Environment.MachineName;
            string dateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string compilationRecord = $"{username} | {computerName} | {dateTime}";

            string filePath = "compilation_history.txt";

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(compilationRecord);
            }
        }
    }
}
