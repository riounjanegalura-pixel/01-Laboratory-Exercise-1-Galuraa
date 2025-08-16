using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp1.StudentInfoClass;

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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private StudentInfoClass.DelegateNumber DelNumAge, DelNumContactNo, DelStudNo;


        private void FrmConfirm_Load(object sender, EventArgs e)
        {
            DelegateText DelProgram = new DelegateText(StudentInfoClass.GetProgram);
            DelegateText DelFirstName = new DelegateText(StudentInfoClass.GetFirstName);
            DelegateText DelMiddleName = new DelegateText(StudentInfoClass.GetMiddleName);
            DelegateText DelLastName = new DelegateText(StudentInfoClass.GetLastName);
            DelegateText DelAddress = new DelegateText(StudentInfoClass.GetAddress);

            DelegateNumber DelNumAge = new DelegateNumber(StudentInfoClass.GetAge);
            DelegateNumber DelNumContactNo = new DelegateNumber(StudentInfoClass.GetContactNo);
            DelegateNumber DelStudNo = new DelegateNumber(StudentInfoClass.GetStudentNo);

            // Call the delegates and assign the return values to the labels
            lblProgram.Text = DelProgram();
            lblFirstName.Text = DelFirstName();
            lblMiddleName.Text = DelMiddleName();
            lblLastName.Text = DelLastName();
            lblAddress.Text = DelAddress();
            lblAge.Text = DelNumAge().ToString();
            lblContactNo.Text = DelNumContactNo().ToString();
            lblStudentNo.Text = DelStudNo().ToString();
        }
    }
}
      
