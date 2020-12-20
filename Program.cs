using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NiiarGeneration.Models;

namespace NiiarGeneration
{
    static class Program
    {
        /// <summary>
        /// Главная  точка входа
        /// </summary>
        [STAThread]
        static void Main()
        {
           var repository = new Repository();
            // Repository repository = new Repository("Server=localHost\\SQLEXPRESS;Integrated Security=True;Initial Catalog=NIIAR-GENERATION");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AppContext appContext = new AppContext(repository);
            Application.Run(appContext);
        }
    }
}