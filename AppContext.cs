using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace NiiarGeneration
{
    public class AppContext : ApplicationContext
    {
        private Repository repository;
        private Form currentForm;

        
        public AppContext(Repository repository)
        {
            this.repository = repository;
            //currentForm = new TitleForm();
            currentForm = new ApplicateListForm(repository);
            currentForm.FormClosed += OnFormClosed;
            currentForm.Show();
        }

        private void SwitchContext()
        {           
            if (currentForm!= null)
            {
                currentForm.FormClosed -= OnFormClosed;
                currentForm.Close();
            }     
        }

        private void OnFormClosed(object sender, EventArgs e)
        {
            ExitThread();
        }

    }
}
