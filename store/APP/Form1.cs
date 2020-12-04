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

namespace APP
{
    public partial class Form1 : Form
    {
        private SqlConnection sqlConnection;
        private DataTable productsInStoreTable;

        public Form1()
        {
            

            InitializeComponent();

            this.productsInStoreTable = new DataTable();

            this.sqlConnection = new SqlConnection(@"Data Source = LIRIMOR\SQLEXPRESS; Initial Catalog = kusach; Integrated Security = True ");


            //string connectionString = @"Data Source = LIRIMOR\SQLEXPRESS; Initial Catalog = kusach; Integrated Security = True ";
            //string sql = "SELECT B.title, C.title, P.price, SH.amount from brand AS B, category AS C, products AS P, stock AS ST, shop AS SH, room AS RM, store AS SR where B.PK_brand = P.FK_brand AND C.PK_category = P.FK_category AND P.PK_product = ST.FK_products AND ST.PK_stock = SH.FK_stock AND RM.PK_room = SH.FK_room AND SR.PK_store = RM.FK_store AND SR.PK_store = 1";

            /*using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);

                DataSet ds = new DataSet();

                adapter.Fill(ds);

                dataGridView2.DataSource = ds.Tables[0];  
            }*/

        }


        private void categoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kusachDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kusachDataSet.stock". При необходимости она может быть перемещена или удалена.
            //this.stockTableAdapter.Fill(this.kusachDataSet.stock);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kusachDataSet.shop". При необходимости она может быть перемещена или удалена.
            this.shopTableAdapter.Fill(this.kusachDataSet.shop);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kusachDataSet.store". При необходимости она может быть перемещена или удалена.
            this.storeTableAdapter.Fill(this.kusachDataSet.store);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kusachDataSet.brand". При необходимости она может быть перемещена или удалена.
            this.brandTableAdapter.Fill(this.kusachDataSet.brand);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kusachDataSet.products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.kusachDataSet.products);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kusachDataSet.category". При необходимости она может быть перемещена или удалена.
            this.categoryTableAdapter.Fill(this.kusachDataSet.category);
            


        }


        private void adminButton_Click (object sender, EventArgs e)
        {
            LoginForm LF = new LoginForm();
            LF.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string SN = storeName.Text;

            string connectionString = @"Data Source = LIRIMOR\SQLEXPRESS; Initial Catalog = kusach; Integrated Security = True ";
            string sql = $"SELECT B.title AS Brand, C.title AS Category, P.price, SH.amount from brand AS B, category AS C, products AS P, stock AS ST, shop AS SH, room AS RM, store AS SR where B.PK_brand = P.FK_brand AND C.PK_category = P.FK_category AND P.PK_product = ST.FK_products AND ST.PK_stock = SH.FK_stock AND RM.PK_room = SH.FK_room AND SR.PK_store = RM.FK_store AND SR.title = '{ SN }'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Создаем объект DataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                // Создаем объект Dataset
                DataSet ds = new DataSet();
                // Заполняем Dataset
                adapter.Fill(ds);
                // Отображаем данные
                dataGridView2.DataSource = ds.Tables[0];
             
            }
        }

        /*private void buttonBuy_Click(object sender, EventArgs e)
        {
            string SN = storeName.Text;
            string TN = textBoxTovarName.Text;
            string BN = textBoxBrandName.Text;

            // string connectionString = @"Data Source = LIRIMOR\SQLEXPRESS; Initial Catalog = kusach; Integrated Security = True ";
            // string sql = $"UPDATE shop set amount = amount - 1 where PK_shop = (SELECT time_table.PK_shop from(SELECT B.title AS brnd, C.title AS tovar, P.price, SH.amount, SH.PK_shop from brand AS B, category AS C, products AS P, stock AS ST, shop AS SH, room AS RM, store AS SR where B.PK_brand = P.FK_brand AND C.PK_category = P.FK_categoryAND P.PK_product = ST.FK_products AND ST.PK_stock = SH.FK_stock AND RM.PK_room = SH.FK_room AND SR.PK_store = RM.FK_store AND SR.title = '{SN}') AS time_table where time_table.brnd = '{BN}' and time_table.tovar = '{TN}' )";

            string sqlExpression = "BuySome";
            try
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, sqlConnection);
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter storeParam = new SqlParameter
                {
                    ParameterName = "@name",
                    Value = SN
                };
                command.Parameters.Add(storeParam);

                SqlParameter tovarParam = new SqlParameter
                {
                    ParameterName = "@tovar_name",
                    Value = TN
                };
                command.Parameters.Add(tovarParam);

                SqlParameter brndParam = new SqlParameter
                {
                    ParameterName = "@brnd_name",
                    Value = BN
                };
                command.Parameters.Add(brndParam);

                command.ExecuteNonQuery();
                this.storeNameTableAdapter.Fill(this.kusachDataSet.storeName, SN);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }

        }*/

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        #region BuySome
        private void button1_Click(object sender, EventArgs e)
        {
            string name = storeName.Text;
            string field1 = textBox1.Text;
            string field2 = textBox2.Text;
            string sqlExpression = "BuySome";
            try
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, sqlConnection);
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter nameParam = new SqlParameter
                {
                    ParameterName = "@name",
                    Value = name
                };
                command.Parameters.Add(nameParam);

                SqlParameter nameParam1 = new SqlParameter
                {
                    ParameterName = "@brnd_name",
                    Value = field1
                };
                command.Parameters.Add(nameParam1);

                SqlParameter priceParam2 = new SqlParameter
                {
                    ParameterName = "@tovar_name",
                    Value = field2
                };
                command.Parameters.Add(priceParam2);

                command.ExecuteNonQuery();
                this.storeNameTableAdapter.Fill(this.kusachDataSet.storeName, name);

                dataGridView2.Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }
        #endregion

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
