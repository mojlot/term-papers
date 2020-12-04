using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Report
{
    public partial class Form2 : Form
    {
        SqlConnection sqlConnection;
        string connectionToDB = @"Data Source=LIRIMOR\SQLEXPRESS;Initial Catalog=project;Integrated Security=True ";
        DataSet ds = new DataSet();
        int data;

        public Form2(int data)
        {
            InitializeComponent();

            textBox1.Hide();
            textBox2.Hide();
            textBox3.Hide();
            textBox4.Hide();
            textBox5.Hide();
            textBox6.Hide();
            textBox7.Hide();
            textBox8.Hide();

            sqlConnection = new SqlConnection(@"Data Source=LIRIMOR\SQLEXPRESS;Initial Catalog=project;Integrated Security=True ");
            string sql = $"SELECT criminalID, sex, DOB, address, education, cSurname, cName, cFatherName FROM Criminal where criminalID = '{ data }'";
            using (SqlConnection connection = new SqlConnection(connectionToDB))
            {
                connection.Open();
                // Создаем объект DataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                // Создаем объект Dataset

                // Заполняем Dataset
                adapter.Fill(ds);
                // Отображаем данные    
                dataGridView1.DataSource = ds.Tables[0];
            }

            this.data = data;
        }



        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int IDa = dataGridView1.CurrentCell.RowIndex;
            int IDb = dataGridView1.CurrentCell.ColumnIndex;

            string GetIdAByClick = dataGridView1.Rows[IDa].Cells[0].Value.ToString();
            string GetIdBByClick = dataGridView1.Rows[IDa].Cells[1].Value.ToString();
            string GetIdCByClick = dataGridView1.Rows[IDa].Cells[2].Value.ToString();
            string GetIdDByClick = dataGridView1.Rows[IDa].Cells[3].Value.ToString();
            string GetIdEByClick = dataGridView1.Rows[IDa].Cells[4].Value.ToString();
            string GetIdFByClick = dataGridView1.Rows[IDa].Cells[5].Value.ToString();
            string GetIdGByClick = dataGridView1.Rows[IDa].Cells[6].Value.ToString();
            string GetIdHByClick = dataGridView1.Rows[IDa].Cells[7].Value.ToString();


            textBox1.Text = GetIdAByClick;
            textBox2.Text = GetIdBByClick;
            textBox3.Text = GetIdCByClick;
            textBox4.Text = GetIdDByClick;
            textBox5.Text = GetIdEByClick;
            textBox6.Text = GetIdFByClick;
            textBox7.Text = GetIdGByClick;
            textBox8.Text = GetIdHByClick;
 
            this.Close();
        }
    }
}
