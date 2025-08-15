using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp1.StudentInfo;

namespace WindowsFormsApp1
{
    public partial class FrmConfirm : Form
    {
        public FrmConfirm()

        {
            InitializeComponent();
        }
        // Delegate variables
        private StudentInfoClass.DelegateText DelProgram, DelLastName, DelFirstName, DelMiddleName, DelAddress;
        private StudentInfoClass.DelegateNumber DelNumAge, DelNumContactNo, DelStudNo;

        
        private void FrmConfirm_Load(object sender, EventArgs e)
        {

        }
    }
}
