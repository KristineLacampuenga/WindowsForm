using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsAppCode
{
    public class DICTForms : Form
    {

        public DICTForms()
        {

            this.Text = "I am a DICT Form";
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // DICTForms
            // 
            this.ClientSize = new System.Drawing.Size(278, 244);
            this.Name = "DICTForms";
            this.Load += new System.EventHandler(this.DICTForms_Load);
            this.ResumeLayout(false);

        }

        private void DICTForms_Load(object sender, EventArgs e)
        {

        }
    }
}
