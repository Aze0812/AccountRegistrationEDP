using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_Registration
{
    //ARNOCO, ZEJI SOLOMON
    //BSIT-509
    //08/14/25
    //EVENT DRIVEN PROGRAMMING
    public partial class FrmConfirm : Form
    {
        private StudentInfoClass.DelegateString DelProgram, DelLastName,
                                                DelFirstName, DelMiddleName, DelAddress;
        private StudentInfoClass.DelegateNumber DelAge, DelContactNo, DelStudNo;
        public FrmConfirm() 
        {
            InitializeComponent();

            DelProgram = new StudentInfoClass.DelegateString(StudentInfoClass.GetProgram);
            DelLastName = new StudentInfoClass.DelegateString(StudentInfoClass.GetLastName);
            DelFirstName = new StudentInfoClass.DelegateString(StudentInfoClass.GetFirstName);
            DelMiddleName = new StudentInfoClass.DelegateString(StudentInfoClass.GetMiddleName);
            DelAddress = new StudentInfoClass.DelegateString(StudentInfoClass.GetAddress);
            DelAge = new StudentInfoClass.DelegateNumber(StudentInfoClass.GetAge);
            DelContactNo = new StudentInfoClass.DelegateNumber(StudentInfoClass.GetContactNo);
            DelStudNo = new StudentInfoClass.DelegateNumber(StudentInfoClass.GetStudentNo);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FrmConfirm_Load(object sender, EventArgs e)
        {
            label1.Text = DelStudNo(StudentInfoClass.StudentNo).ToString();
            label2.Text = DelProgram(StudentInfoClass.Program);
            label3.Text = DelLastName(StudentInfoClass.LastName);
            label4.Text = DelFirstName(StudentInfoClass.FirstName);
            label5.Text = DelMiddleName(StudentInfoClass.MiddleName);
            label6.Text = DelAge(StudentInfoClass.Age).ToString();
            label7.Text = DelContactNo(StudentInfoClass.ContactNo).ToString();
            label8.Text = DelAddress(StudentInfoClass.Address).ToString();

        }

        private void FrmConfirm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
