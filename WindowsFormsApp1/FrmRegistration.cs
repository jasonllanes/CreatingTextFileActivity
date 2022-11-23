using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void FrmRegistration_Load(object sender, EventArgs e)
        {
            string[] ListOfProgram = new string[]
            {
                "BS Information Technology",
                "BS Computer Science",
                "BS Information System",
                "BS in Accountacy",
                "BS in Hospitality Management",
                "BS in Tourism Management"
            };

            for (int i = 0; i < 6; i++)
            {
                cbPrograms.Items.Add(ListOfProgram[i].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] details = {"Student No.: " + txtStudentNo.Text,
                "Full Name: " + txtLastName.Text+ " " + txtFirstName.Text + " " + txtMiddleInitial.Text,
                "Program: " + cbPrograms.Text,
                "Gender: " + cbGender.Text,
                "Age: " + txtAge.Text,
                "Birthday: " + datePickerBirthday.Value.ToString("yyyy-MM-dd"),
                "Contact No.: " + txtContactNo.Text
                                   };
            FrmFileName frmFileName = new FrmFileName();
            frmFileName.ShowDialog();


            string docPath =
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath,
            FrmFileName.SetFileName)))
            {
                foreach (string ch in details)
                {
                    outputFile.WriteLine(ch);
                    Console.WriteLine(ch);
                }
                
            }
            
        }
    }
}
