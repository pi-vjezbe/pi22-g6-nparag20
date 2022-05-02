using Evaluation_Manager.Models;
using Evaluation_Manager.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluation_Manager
{
    public partial class FrmStudents : Form
    {
        public FrmStudents()
        {
            InitializeComponent();
        }

        private void FrmStudents_Load(object sender, EventArgs e)
        {
            ShowStudents();
        }
        public void ShowStudents()
        {
            List<Student> students = StudentRepository.GetStudents();
            dataGridView1.DataSource = students;


            dataGridView1.Columns["Id"].DisplayIndex = 0;
            dataGridView1.Columns["FirstName"].DisplayIndex = 1;
            dataGridView1.Columns["LastName"].DisplayIndex = 2;
            dataGridView1.Columns["Grade"].DisplayIndex = 3;
        }
    }
}
