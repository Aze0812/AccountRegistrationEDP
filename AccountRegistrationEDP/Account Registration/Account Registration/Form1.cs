using System.Collections;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Account_Registration
{
    //ARNOCO, ZEJI SOLOMON
    //BSIT-509
    //08/14/25
    //EVENT DRIVEN PROGRAMMING
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ComboBox1.Items.Add("BS of Science in Computer Science");
            ComboBox1.Items.Add("BS of Science in Information Technology");
            ComboBox1.Items.Add("BS of Science in Information System");
            ComboBox1.Items.Add("BS of Science in Computer Engineering");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void NextBtn_Click(object sender, EventArgs e)
        {

            StudentInfoClass.StudentNo = Convert.ToInt64(textBox1.Text);
            StudentInfoClass.FirstName = textBox2.Text;
            StudentInfoClass.LastName = textBox3.Text;
            StudentInfoClass.MiddleName = textBox4.Text;
            StudentInfoClass.Address = textBox7.Text;
            StudentInfoClass.Program = ComboBox1.Text;
            StudentInfoClass.Age = Convert.ToInt64(textBox5.Text);
            StudentInfoClass.ContactNo = Convert.ToInt64(textBox6.Text);

            FrmConfirm frmConfirm = new FrmConfirm();
            if (frmConfirm.ShowDialog() == DialogResult.OK)
            {
           
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox7.Clear();
                ComboBox1.SelectedIndex = -1;
                textBox5.Clear();
                textBox6.Clear();
            }

        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }



        private void label4_Click(object sender, EventArgs e)
        {

        }
    }

    public class StudentInfoClass
    {
            public delegate long DelegateNumber (long number);
            public delegate string DelegateString(string txt);

            public static string FirstName = "";
            public static string LastName = "";
            public static string MiddleName = "";
            public static string Address = "";
            public static string Program = "";
            public static long Age = 0;
            public static long ContactNo = 0;
            public static long StudentNo = 0;

        public static string GetFirstName(string FirstName)
        {
            return FirstName;
        }
        public static string GetLastName(string LastName)
        {
            return LastName;
        }

        public static string GetMiddleName(string MiddleName)
        {
            return MiddleName;
        }

        public static string GetAddress(string Address)
        {
            return Address;
        }

        public static string GetProgram(string Program)
        {
            return Program;
        }

        public static long GetAge(long Age)
        {
            return Age;
        }

        public static long GetContactNo(long ContactNo)
        {
            return ContactNo;
        }
        public static long GetStudentNo(long StudentNo)
        {
            return StudentNo;
        }
    }
}
