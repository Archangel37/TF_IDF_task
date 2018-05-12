using System;
using System.Windows.Forms;

namespace TF_IDF
{
    public partial class FormTF_IDF : Form
    {
        public FormTF_IDF()
        {
            InitializeComponent();
        }

        private void CalculateTfIdf_btn_Click(object sender, EventArgs e)
        {
            richTextBoxResult.Text = new TF_IDF_Calculator().GetScoresFromFiles();
        }
    }
}
