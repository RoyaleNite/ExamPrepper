using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ExamPrepper.Classes.ExamFormData;

namespace ExamPrepper.Forms.TaskCollectionForm
{
    public partial class frmResultInfo : Form
    {
        public Results res;
        public frmResultInfo()
        {
            InitializeComponent();
        }

        private void frmResultInfo_Load(object sender, EventArgs e)
        {
            if (res != null)
            {
                txtPercentage.Text = res.MarkPercentage.ToString() + "%";
                txtReceived.Text = res.TotalCorrectMarks.ToString();
                txtTotal.Text = res.TotalMarks.ToString();
            }
        }
    }
}
