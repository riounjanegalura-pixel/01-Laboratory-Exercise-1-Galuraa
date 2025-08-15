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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            StudentInfoClass.Program = cbProgram.Text.ToString();
            StudentInfoClass.StudentNo = long.Parse(txtStudentNum.Text);
            StudentInfoClass.LastName = txtLastName.Text;
            StudentInfoClass.FirstName = txtFirstName.Text;
            StudentInfoClass.MiddleName = txtMiddleName.Text;
            StudentInfoClass.Age = long.Parse(txtAge.Text);
            StudentInfoClass.ContactNo = long.Parse(txtContactNo.Text);
            StudentInfoClass.Address = rtxtAddress.Text;

            FrmConfirm confirmForm = new FrmConfirm();
            confirmForm.ShowDialog();

        }

        private void MyRegistration_Load(object sender, EventArgs e)
        {

            cbProgram.Items.Add("BS in Computer Science");
            cbProgram.Items.Add("BS in Information Technology");
            cbProgram.Items.Add("BS in Business Administration");
            cbProgram.Items.Add("BS in Accountancy");
        }
    }
}
