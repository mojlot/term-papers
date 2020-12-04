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
    public partial class AdminForm : Form
    {

        private SqlConnection sqlConnection;
        public AdminForm()
        {
            InitializeComponent();
            this.sqlConnection = new SqlConnection(@"Data Source = LIRIMOR\SQLEXPRESS; Initial Catalog = kusach; Integrated Security = True ");
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kusachDataSet.cashbox". При необходимости она может быть перемещена или удалена.
            this.cashboxTableAdapter.Fill(this.kusachDataSet.cashbox);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kusachDataSet.store". При необходимости она может быть перемещена или удалена.
            this.storeTableAdapter.Fill(this.kusachDataSet.store);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kusachDataSet.chek". При необходимости она может быть перемещена или удалена.
            this.chekTableAdapter.Fill(this.kusachDataSet.chek);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kusachDataSet.room". При необходимости она может быть перемещена или удалена.
            this.roomTableAdapter.Fill(this.kusachDataSet.room);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kusachDataSet.shift". При необходимости она может быть перемещена или удалена.
            this.shiftTableAdapter.Fill(this.kusachDataSet.shift);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kusachDataSet.shop". При необходимости она может быть перемещена или удалена.
            this.shopTableAdapter.Fill(this.kusachDataSet.shop);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kusachDataSet.stock". При необходимости она может быть перемещена или удалена.
            this.stockTableAdapter.Fill(this.kusachDataSet.stock);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kusachDataSet.manufact". При необходимости она может быть перемещена или удалена.
            this.manufactTableAdapter.Fill(this.kusachDataSet.manufact);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kusachDataSet.products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.kusachDataSet.products);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kusachDataSet.brand". При необходимости она может быть перемещена или удалена.
            this.brandTableAdapter.Fill(this.kusachDataSet.brand);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kusachDataSet.category". При необходимости она может быть перемещена или удалена.
            this.categoryTableAdapter.Fill(this.kusachDataSet.category);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kusachDataSet.employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.kusachDataSet.employee);

        }

        #region Employee
        private void buttonSaveEmployee_Click_1(object sender, EventArgs e)
        {
            //Int32.TryParse(textBoxEmployeePK.Text, out int PK);
            string name = textBoxEmployeeName.Text;
            string sqlExpression = "AddEmployee";
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

                command.ExecuteNonQuery();
                this.employeeTableAdapter.Fill(this.kusachDataSet.employee);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { sqlConnection.Close(); }
        }


        private void buttonRemoveEmployee_Click(object sender, EventArgs e)
        {
            Int32.TryParse(textBoxEmployeePK.Text, out int PK);
            //string name = textBoxEmployeeName.Text;
            string sqlExpression = "DelEmployee";
            try
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, sqlConnection);
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter nameParam = new SqlParameter
                {
                    ParameterName = "@ID",
                    Value = PK
                };
                command.Parameters.Add(nameParam);

                command.ExecuteNonQuery();
                this.employeeTableAdapter.Fill(this.kusachDataSet.employee);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { sqlConnection.Close(); }
        }
        #endregion

        #region Category

        private void buttonAddCategory_Click_1(object sender, EventArgs e)
        {
            //Int32.TryParse(textBoxEmployeePK.Text, out int PK);
            string name = textBoxCategoreTitle.Text;
            string sqlExpression = "AddCategory";
            try
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, sqlConnection);
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter nameParam = new SqlParameter
                {
                    ParameterName = "@categoryTitle",
                    Value = name
                };
                command.Parameters.Add(nameParam);

                command.ExecuteNonQuery();
                this.categoryTableAdapter.Fill(this.kusachDataSet.category);
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

        private void buttonRemoveCategory_Click_1(object sender, EventArgs e)
        {
            Int32.TryParse(textBoxCategoryID.Text, out int PK);
            //string name = textBoxEmployeeName.Text;
            string sqlExpression = "DelCategory";
            try
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, sqlConnection);
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter nameParam = new SqlParameter
                {
                    ParameterName = "@IDcategory",
                    Value = PK
                };
                command.Parameters.Add(nameParam);

                command.ExecuteNonQuery();
                this.categoryTableAdapter.Fill(this.kusachDataSet.category);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { sqlConnection.Close(); }
        }


        #endregion

        #region Brand

        private void buttonAddBrand_Click(object sender, EventArgs e)
        {
            //Int32.TryParse(textBoxEmployeePK.Text, out int PK);
            string name = textBox3.Text;
            string sqlExpression = "AddBrand";
            try
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, sqlConnection);
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter nameParam = new SqlParameter
                {
                    ParameterName = "@brandTitle",
                    Value = name
                };
                command.Parameters.Add(nameParam);

                command.ExecuteNonQuery();
                this.brandTableAdapter.Fill(this.kusachDataSet.brand);
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

        private void buttonRemoveBrand_Click(object sender, EventArgs e)
        {
            Int32.TryParse(textBox4.Text, out int PK);
            //string name = textBoxEmployeeName.Text;
            string sqlExpression = "DelBrand";
            try
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, sqlConnection);
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter nameParam = new SqlParameter
                {
                    ParameterName = "@IDbrand",
                    Value = PK
                };
                command.Parameters.Add(nameParam);

                command.ExecuteNonQuery();
                this.brandTableAdapter.Fill(this.kusachDataSet.brand);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { sqlConnection.Close(); }
        }


        #endregion

        #region Manufact
        private void buttonAddManufact_Click(object sender, EventArgs e)
        {
            //Int32.TryParse(textBoxEmployeePK.Text, out int PK);
            string name = textBox5.Text;
            string sqlExpression = "AddManufact";
            try
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, sqlConnection);
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter nameParam = new SqlParameter
                {
                    ParameterName = "@manufactAddres",
                    Value = name
                };
                command.Parameters.Add(nameParam);

                command.ExecuteNonQuery();
                this.manufactTableAdapter.Fill(this.kusachDataSet.manufact);
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

        private void buttonRemoveManufact_Click(object sender, EventArgs e)
        {
            Int32.TryParse(textBox6.Text, out int PK);
            //string name = textBoxEmployeeName.Text;
            string sqlExpression = "DelManufact";
            try
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, sqlConnection);
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter nameParam = new SqlParameter
                {
                    ParameterName = "@IDmanufact",
                    Value = PK
                };
                command.Parameters.Add(nameParam);

                command.ExecuteNonQuery();
                this.manufactTableAdapter.Fill(this.kusachDataSet.manufact);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { sqlConnection.Close(); }
        }
        #endregion

        #region Product
        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            //Int32.TryParse(textBoxEmployeePK.Text, out int PK);
            string category = textBox7.Text;
            string brand = textBox23.Text;
            string manufact = textBox24.Text;
            string price = textBox25.Text;
            string sqlExpression = "AddProducts";
            try
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, sqlConnection);
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter nameParam = new SqlParameter
                {
                    ParameterName = "@fkCategoryProduct",
                    Value = category
                };
                command.Parameters.Add(nameParam);

                SqlParameter nameParam1 = new SqlParameter
                {
                    ParameterName = "@fkBrandProduct",
                    Value = brand
                };
                command.Parameters.Add(nameParam1);

                SqlParameter nameParam2 = new SqlParameter
                {
                    ParameterName = "@fkManufactProduct",
                    Value = manufact
                };
                command.Parameters.Add(nameParam2);

                SqlParameter nameParam3 = new SqlParameter
                {
                    ParameterName = "@productPrice",
                    Value = price
                };
                command.Parameters.Add(nameParam3);

                command.ExecuteNonQuery();
                this.productsTableAdapter.Fill(this.kusachDataSet.products);
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

        private void buttonRemoveProduct_Click(object sender, EventArgs e)
        {
            Int32.TryParse(textBox8.Text, out int PK);
            //string name = textBoxEmployeeName.Text;
            string sqlExpression = "DelProducts";
            try
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, sqlConnection);
                command.CommandType = CommandType.StoredProcedure;
                SqlParameter nameParam = new SqlParameter
                {
                    ParameterName = "@IDproduct",
                    Value = PK
                };
                command.Parameters.Add(nameParam);
                command.ExecuteNonQuery();
                this.productsTableAdapter.Fill(this.kusachDataSet.products);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { sqlConnection.Close(); }
        }
        #endregion

        #region Stock

        private void buttonAddStock_Click(object sender, EventArgs e)
        {
            //Int32.TryParse(textBoxEmployeePK.Text, out int PK);
            string delivery = textBox9.Text;
            string products = textBox26.Text;
            string amount = textBox27.Text;
            string price = textBox28.Text;
            string sqlExpression = "AddStock";
            try
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, sqlConnection);
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter nameParam = new SqlParameter
                {
                    ParameterName = "@fkDeliveryStock",
                    Value = delivery
                };
                command.Parameters.Add(nameParam);

                SqlParameter nameParam1 = new SqlParameter
                {
                    ParameterName = "@fkProductsStock",
                    Value = products
                };
                command.Parameters.Add(nameParam1);

                SqlParameter nameParam2 = new SqlParameter
                {
                    ParameterName = "@amountStock",
                    Value = amount
                };
                command.Parameters.Add(nameParam2);

                SqlParameter nameParam3 = new SqlParameter
                {
                    ParameterName = "@priceStock",
                    Value = price
                };
                command.Parameters.Add(nameParam3);

                command.ExecuteNonQuery();
                this.stockTableAdapter.Fill(this.kusachDataSet.stock);
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

        private void buttonRemoveStock_Click(object sender, EventArgs e)
        {
            Int32.TryParse(textBox10.Text, out int PK);
            //string name = textBoxEmployeeName.Text;
            string sqlExpression = "DelStock";
            try
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, sqlConnection);
                command.CommandType = CommandType.StoredProcedure;
                SqlParameter nameParam = new SqlParameter
                {
                    ParameterName = "@IDstock",
                    Value = PK
                };
                command.Parameters.Add(nameParam);
                command.ExecuteNonQuery();
                this.stockTableAdapter.Fill(this.kusachDataSet.stock);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { sqlConnection.Close(); }
        }


        #endregion

        #region Shop
        private void buttonAddShop_Click(object sender, EventArgs e)
        {
            //Int32.TryParse(textBoxEmployeePK.Text, out int PK);
            string stock = textBox11.Text;
            string room = textBox29.Text;
            string amount = textBox30.Text;
            string sqlExpression = "AddShop";
            try
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, sqlConnection);
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter nameParam = new SqlParameter
                {
                    ParameterName = "@fkStockShop",
                    Value = stock
                };
                command.Parameters.Add(nameParam);

                SqlParameter nameParam1 = new SqlParameter
                {
                    ParameterName = "@fkRoomShop",
                    Value = room
                };
                command.Parameters.Add(nameParam1);

                SqlParameter nameParam2 = new SqlParameter
                {
                    ParameterName = "@amountShop",
                    Value = amount
                };
                command.Parameters.Add(nameParam2);

                command.ExecuteNonQuery();
                this.shopTableAdapter.Fill(this.kusachDataSet.shop);
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

        private void buttonRemoveShop_Click(object sender, EventArgs e)
        {
            Int32.TryParse(textBox12.Text, out int PK);
            //string name = textBoxEmployeeName.Text;
            string sqlExpression = "DelShop";
            try
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, sqlConnection);
                command.CommandType = CommandType.StoredProcedure;
                SqlParameter nameParam = new SqlParameter
                {
                    ParameterName = "@IDshop",
                    Value = PK
                };
                command.Parameters.Add(nameParam);
                command.ExecuteNonQuery();
                this.shopTableAdapter.Fill(this.kusachDataSet.shop);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { sqlConnection.Close(); }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Shift
        private void buttonAddShift_Click(object sender, EventArgs e)
        {
            //Int32.TryParse(textBoxEmployeePK.Text, out int PK);
            string store = textBox13.Text;
            string employee = textBox31.Text;

            string sqlExpression = "AddShift";
            try
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, sqlConnection);
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter nameParam = new SqlParameter
                {
                    ParameterName = "@fkStoreShift",
                    Value = store
                };
                command.Parameters.Add(nameParam);

                SqlParameter nameParam1 = new SqlParameter
                {
                    ParameterName = "@fkEmployeeShift",
                    Value = employee
                };
                command.Parameters.Add(nameParam1);

                command.ExecuteNonQuery();
                this.shiftTableAdapter.Fill(this.kusachDataSet.shift);
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

        private void buttonRemoveShift_Click(object sender, EventArgs e)
        {
            Int32.TryParse(textBox14.Text, out int PK);
            //string name = textBoxEmployeeName.Text;
            string sqlExpression = "DelShift";
            try
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, sqlConnection);
                command.CommandType = CommandType.StoredProcedure;
                SqlParameter nameParam = new SqlParameter
                {
                    ParameterName = "@IDshift",
                    Value = PK
                };
                command.Parameters.Add(nameParam);
                command.ExecuteNonQuery();
                this.shiftTableAdapter.Fill(this.kusachDataSet.shift);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { sqlConnection.Close(); }
        }

        #endregion

        #region Room
        private void buttonAddRoom_Click(object sender, EventArgs e)
        {
            //Int32.TryParse(textBoxEmployeePK.Text, out int PK);
            string store = textBox15.Text;

            string sqlExpression = "AddRoom";
            try
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, sqlConnection);
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter nameParam = new SqlParameter
                {
                    ParameterName = "@fkStoreRoom",
                    Value = store
                };
                command.Parameters.Add(nameParam);


                command.ExecuteNonQuery();
                this.roomTableAdapter.Fill(this.kusachDataSet.room);
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

        private void buttonRemoveRoom_Click(object sender, EventArgs e)
        {
            Int32.TryParse(textBox16.Text, out int PK);
            //string name = textBoxEmployeeName.Text;
            string sqlExpression = "DelRoom";
            try
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, sqlConnection);
                command.CommandType = CommandType.StoredProcedure;
                SqlParameter nameParam = new SqlParameter
                {
                    ParameterName = "@IDroom",
                    Value = PK
                };
                command.Parameters.Add(nameParam);
                command.ExecuteNonQuery();
                this.roomTableAdapter.Fill(this.kusachDataSet.room);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { sqlConnection.Close(); }
        }
        #endregion

        #region Chek

        private void buttonAddChek_Click(object sender, EventArgs e)
        {
            //Int32.TryParse(textBoxEmployeePK.Text, out int PK);
            string shop = textBox17.Text;
            string date = textBox32.Text;

            string sqlExpression = "AddChek";
            try
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, sqlConnection);
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter nameParam = new SqlParameter
                {
                    ParameterName = "@fkShopChek",
                    Value = shop
                };
                command.Parameters.Add(nameParam);

                SqlParameter nameParam1 = new SqlParameter
                {
                    ParameterName = "@saleDateChek",
                    Value = date
                };
                command.Parameters.Add(nameParam1);


                command.ExecuteNonQuery();
                this.chekTableAdapter.Fill(this.kusachDataSet.chek);
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

        private void buttonRemoveChek_Click(object sender, EventArgs e)
        {
            Int32.TryParse(textBox18.Text, out int PK);
            //string name = textBoxEmployeeName.Text;
            string sqlExpression = "DelChek";
            try
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, sqlConnection);
                command.CommandType = CommandType.StoredProcedure;
                SqlParameter nameParam = new SqlParameter
                {
                    ParameterName = "@IDchek",
                    Value = PK
                };
                command.Parameters.Add(nameParam);
                command.ExecuteNonQuery();
                this.chekTableAdapter.Fill(this.kusachDataSet.chek);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { sqlConnection.Close(); }
        }


        #endregion

        #region Store

        private void buttonAddStore_Click(object sender, EventArgs e)
        {
            //Int32.TryParse(textBoxEmployeePK.Text, out int PK);
            string cashbox = textBox19.Text;
            string title = textBox33.Text;
            string addres = textBox34.Text;

            string sqlExpression = "AddStore";
            try
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, sqlConnection);
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter nameParam = new SqlParameter
                {
                    ParameterName = "@fkCashboxStore",
                    Value = cashbox
                };
                command.Parameters.Add(nameParam);

                SqlParameter nameParam1 = new SqlParameter
                {
                    ParameterName = "@titleStore",
                    Value = title
                };
                command.Parameters.Add(nameParam1);

                SqlParameter nameParam2 = new SqlParameter
                {
                    ParameterName = "@addresStore",
                    Value = addres
                };
                command.Parameters.Add(nameParam2);


                command.ExecuteNonQuery();
                this.storeTableAdapter.Fill(this.kusachDataSet.store);
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

        private void buttonRemoveStore_Click(object sender, EventArgs e)
        {
            Int32.TryParse(textBox20.Text, out int PK);
            //string name = textBoxEmployeeName.Text;
            string sqlExpression = "DelStore";
            try
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, sqlConnection);
                command.CommandType = CommandType.StoredProcedure;
                SqlParameter nameParam = new SqlParameter
                {
                    ParameterName = "@IDstore",
                    Value = PK
                };
                command.Parameters.Add(nameParam);
                command.ExecuteNonQuery();
                this.storeTableAdapter.Fill(this.kusachDataSet.store);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { sqlConnection.Close(); }
        }
        #endregion

        #region cashbox
        private void buttonAddCashbox_Click(object sender, EventArgs e)
        {
            //Int32.TryParse(textBoxEmployeePK.Text, out int PK);
            string limit = textBox21.Text;


            string sqlExpression = "AddCashbox";
            try
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, sqlConnection);
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter nameParam = new SqlParameter
                {
                    ParameterName = "@limitCashbox",
                    Value = limit
                };
                command.Parameters.Add(nameParam);

                command.ExecuteNonQuery();
                this.cashboxTableAdapter.Fill(this.kusachDataSet.cashbox);
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

        private void buttonRemoveCashbox_Click(object sender, EventArgs e)
        {

            Int32.TryParse(textBox22.Text, out int PK);
            //string name = textBoxEmployeeName.Text;
            string sqlExpression = "DelCashbox";
            try
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, sqlConnection);
                command.CommandType = CommandType.StoredProcedure;
                SqlParameter nameParam = new SqlParameter
                {
                    ParameterName = "@IDcashbox",
                    Value = PK
                };
                command.Parameters.Add(nameParam);
                command.ExecuteNonQuery();
                this.cashboxTableAdapter.Fill(this.kusachDataSet.cashbox);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { sqlConnection.Close(); }
        }
        #endregion


    }
}
