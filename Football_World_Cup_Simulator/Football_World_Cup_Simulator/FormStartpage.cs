using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldCupSimulator2
{
    public partial class FormStartpage : Form
    {
        public FormStartpage()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            // minimalizacja aktualnego okna
            this.WindowState = FormWindowState.Minimized;

            // tworzę nowy formularz i go wyświetlam
            FormQualifications newForm = new FormQualifications();

            // chcemy wrzucić to okno na wierzch
            newForm.Show();
            newForm.Activate();
            
            System.Windows.Forms.Application.OpenForms[newForm.Name].Focus();
        }

        private void FormStartpage_Load(object sender, EventArgs e)
        {

        }
    }
}
