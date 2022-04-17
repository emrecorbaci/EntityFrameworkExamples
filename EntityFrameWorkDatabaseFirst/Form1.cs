using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityFrameWorkDatabaseFirst.Entities;

namespace EntityFrameWorkDatabaseFirst
{
    public partial class Form1 : Form
    {
        CodeFirstExampleEntities db = new CodeFirstExampleEntities();
        public Form1()
        {
            InitializeComponent();
        }
          
        private void button1_Click(object sender, EventArgs e)
        {
            var data = db.sp_getProduct().ToList(); //mssql de proc olusturduk ve db.edmx i acip sag tik update from database dedik ve projeje dahil ettik

            dataGridView1.DataSource = data;
        }
    }
}
