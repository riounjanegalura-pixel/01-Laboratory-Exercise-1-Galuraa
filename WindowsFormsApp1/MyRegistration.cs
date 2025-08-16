using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp1.MyRegistration;

namespace WindowsFormsApp1
{
    public partial class MyRegistration : Form
    {
        public MyRegistration()
        {
            InitializeComponent();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            StudentInfoClass.Program = cbProgram.Text.ToString();
            StudentInfoClass.StudentNo = Convert.ToInt64(txtStudentNum.Text);
            StudentInfoClass.LastName = txtLastName.Text;
            StudentInfoClass.FirstName = txtFirstName.Text;
            StudentInfoClass.MiddleName = txtMiddleName.Text;
            StudentInfoClass.Age = Convert.ToInt64(txtAge.Text);
            StudentInfoClass.ContactNo = Convert.ToInt64(txtContactNo.Text);
            StudentInfoClass.Address = rtxtAddress.Text;

            FrmConfirm confirmForm = new FrmConfirm();
            confirmForm.ShowDialog();

            if (confirmForm.ShowDialog() == DialogResult.OK)
            {
                // If the user confirms, all controls will be reset.
                txtStudentNum.Text = string.Empty;
                txtLastName.Text = string.Empty;
                txtFirstName.Text = string.Empty;
                txtMiddleName.Text = string.Empty;
                txtAge.Text = string.Empty;
                txtContactNo.Text = string.Empty;
                rtxtAddress.Text = string.Empty;

                cbProgram.SelectedIndex = -1;
                cbProgram.Text = string.Empty;
            }

        }

        private void MyRegistration_Load(object sender, EventArgs e)
        {

            cbProgram.Items.Add("BS in Computer Science");
            cbProgram.Items.Add("BS in Information Technology");
            cbProgram.Items.Add("BS in Information System");
            cbProgram.Items.Add("BS in Accountancy");
        }
    }
}
