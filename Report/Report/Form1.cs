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
using Microsoft.Office.Core;
using System.Reflection;
using Microsoft.Office.Interop.Word;
using Word = Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

using System.Diagnostics;



namespace Report
{
    public partial class Form1 : Form
    {
        SqlConnection sqlConnection;
        string connectionToDB = @"Data Source=LIRIMOR\SQLEXPRESS;Initial Catalog=project;Integrated Security=True ";
        List<string> listText = new List<string>();
        bool tEnable = false;
        DataSet ds = new DataSet();
        DataSet ds1 = new DataSet();
        DataSet ds2 = new DataSet();
        DataSet ds3 = new DataSet();

       
        #region kill
        public List<int> getRunningProcesses()
        {
            List<int> ProcessIDs = new List<int>();
            //here we're going to get a list of all running processes on
            //the computer
            foreach (Process clsProcess in Process.GetProcesses())
            {
                if (Process.GetCurrentProcess().Id == clsProcess.Id)
                    continue;
                if (clsProcess.ProcessName.Contains("WINWORD"))
                {
                    ProcessIDs.Add(clsProcess.Id);
                }
            }
            return ProcessIDs;
        }


        private void killProcesses(List<int> processesbeforegen, List<int> processesaftergen)
        {
            foreach (int pidafter in processesaftergen)
            {
                bool processfound = false;
                foreach (int pidbefore in processesbeforegen)
                {
                    if (pidafter == pidbefore)
                    {
                        processfound = true;
                    }
                }

                if (processfound == false)
                {
                    Process clsProcess = Process.GetProcessById(pidafter);
                    clsProcess.Kill();
                }
            }
        }
        #endregion

        public Form1()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(@"Data Source=LIRIMOR\SQLEXPRESS;Initial Catalog=project;Integrated Security=True ");
            string sql = $"Select C.cSurname, C.cName,  C.cFatherName, C.sex, P.surname, P.name, P.fatherName, C.DOB, C.address, C.education, O.article, O.material, O.refusal,O.considerationDate,O.punishment,O.sum,O.paidSum,O.maturityDate,O.courtDate from Criminal AS C, Offense AS O, Parents AS P where O.parentsFK = P.parentID AND O.criminalFK = C.criminalID";
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

            //sqlConnection = new SqlConnection(@"Data Source=LIRIMOR\SQLEXPRESS;Initial Catalog=project;Integrated Security=True ");
            string sql1 = $"SELECT (c.cSurname + ' ' + c.cName + ' ' +c.cFatherName)as ФИО,(P.surname + ' ' + p.name + ' ' + p.fatherName) as ФИО_родителя,article, material, refusal, considerationDate, punishment, sum, paidSum, maturityDate, courtDate,offenseID FROM Offense as O, Criminal as C, Parents as P where parentsFK = parentID AND criminalFK = criminalID ";
            
            using (SqlConnection connection = new SqlConnection(connectionToDB))
            {
                connection.Open();
                // Создаем объект DataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(sql1, connection);
                // Заполняем Dataset
                adapter.Fill(ds1);
                // Отображаем данные
                dataGridView2.DataSource = ds1.Tables[0];
            }
            dataGridView2.Columns["offenseID"].Visible = false;

            string sql2 = $"SELECT criminalID,sex,DOB,address,education,cSurname,cName,cFatherName FROM Criminal";
            using (SqlConnection connection = new SqlConnection(connectionToDB))
            {
                connection.Open();
                // Создаем объект DataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(sql2, connection);
                // Заполняем Dataset
                adapter.Fill(ds2);
                // Отображаем данные
                dataGridView3.DataSource = ds2.Tables[0];
            }


            string sql3 = $"SELECT parentID, surname, name,fatherName FROM Parents";
            using (SqlConnection connection = new SqlConnection(connectionToDB))
            {
                connection.Open();
                // Создаем объект DataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(sql3, connection);
                // Заполняем Dataset
                adapter.Fill(ds3);
                // Отображаем данные
                dataGridView4.DataSource = ds3.Tables[0];
            }
            textBox4.Visible = false;
        }

        
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int IDa = dataGridView2.CurrentCell.RowIndex;
            int IDb = dataGridView2.CurrentCell.ColumnIndex;
            
            Form2 newForm = new Form2(IDa);
            newForm.Show();
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int IDa = dataGridView3.CurrentCell.RowIndex;
            int IDb = dataGridView3.CurrentCell.ColumnIndex;

            string GetIdAByClick = dataGridView3.Rows[IDa].Cells[0].Value.ToString();
            string GetIdBByClick = dataGridView3.Rows[IDa].Cells[1].Value.ToString();
            string GetIdCByClick = dataGridView3.Rows[IDa].Cells[2].Value.ToString();
            string GetIdDByClick = dataGridView3.Rows[IDa].Cells[3].Value.ToString();
            string GetIdEByClick = dataGridView3.Rows[IDa].Cells[4].Value.ToString();
            string GetIdFByClick = dataGridView3.Rows[IDa].Cells[5].Value.ToString();
            string GetIdGByClick = dataGridView3.Rows[IDa].Cells[6].Value.ToString();
            string GetIdHByClick = dataGridView3.Rows[IDa].Cells[7].Value.ToString();

            textBox21.Text = GetIdAByClick;
            textBox22.Text = GetIdBByClick;
            textBox23.Text = GetIdCByClick;
            textBox24.Text = GetIdDByClick;
            textBox25.Text = GetIdEByClick;
            textBox26.Text = GetIdFByClick;
            textBox27.Text = GetIdGByClick;
            textBox28.Text = GetIdHByClick;
        }

        void FindAndReplace(Word.Application wordApp, object findText, object replaceText)
        {
            object matchCase = true;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundLike = false;
            object matchAllForms = false;
            object forward = true;
            object format = false;
            object matchKashida = false;
            object matchDiactitics = false;
            object matchAlefHamza = false;
            object matchControl = false;
            object read_only = false;
            object visible = true;
            object replace = 2;
            object wrap = 1;

            wordApp.Selection.Find.Execute(ref findText, ref matchCase, ref matchWholeWord, ref matchWildCards,
                ref matchSoundLike, ref matchAllForms,
                ref forward, ref wrap, ref format,
                ref replaceText, ref replace,
                ref matchKashida, ref matchDiactitics,
                ref matchAlefHamza, ref matchControl);
        }

        void CreateWordDocument(object filename, object saveAs)
        {
            List<int> processesbeforegen = getRunningProcesses();
            object missing = Missing.Value;
            //string tempPath = null;
            Word.Application wordApp = new Word.Application();
            Word.Document nDoc = null;
            if (File.Exists((string)filename))
            {
                DateTime today = DateTime.Now;

                object readOnly = false;
                object isVisible = false;

                wordApp.Visible = false;

                nDoc = wordApp.Documents.Open(ref filename, ref missing, ref readOnly,
                    ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing, ref missing);

                nDoc.Activate();

                this.FindAndReplace(wordApp, "<cSurname>", textBox1.Text.Trim()); //like a test
                this.FindAndReplace(wordApp, "<cName>", textBox2.Text.Trim());
                this.FindAndReplace(wordApp, "<CFatherName>", textBox3.Text.Trim());

                this.FindAndReplace(wordApp, "<surname>", textBox5.Text.Trim());
                this.FindAndReplace(wordApp, "<name>", textBox6.Text.Trim());
                this.FindAndReplace(wordApp, "<fatherName>", textBox7.Text.Trim());
                this.FindAndReplace(wordApp, "<DOB>", textBox8.Text.Trim());
                this.FindAndReplace(wordApp, "<address>", textBox9.Text.Trim());
                this.FindAndReplace(wordApp, "<education>", textBox10.Text.Trim());
                this.FindAndReplace(wordApp, "<article>", textBox11.Text.Trim());
                this.FindAndReplace(wordApp, "<material>", textBox12.Text.Trim());
                this.FindAndReplace(wordApp, "<refusal>", textBox13.Text.Trim());
                this.FindAndReplace(wordApp, "<considirationDate>", textBox14.Text.Trim());
                this.FindAndReplace(wordApp, "<punishment>", textBox15.Text.Trim());
                this.FindAndReplace(wordApp, "<sum>", textBox16.Text.Trim());
                this.FindAndReplace(wordApp, "<paidSum>", textBox17.Text.Trim());
                this.FindAndReplace(wordApp, "<maturityDate>", textBox18.Text.Trim());
                this.FindAndReplace(wordApp, "<courtDate>", textBox19.Text.Trim());

            }
            else
            {
                MessageBox.Show("file does not exist");
                return;
            }
            #region print
            if (checkBox1.Checked)
            {
                object copies = 1;
                object pages = 1;
                object range = Word.WdPrintOutRange.wdPrintCurrentPage;
                object items = Word.WdPrintOutItem.wdPrintDocumentContent;
                object pageType = Word.WdPrintOutPages.wdPrintAllPages;
                object oTrue = true;
                object oFalse = false;

                Word.Document doc = nDoc;
                object nullobj = Missing.Value;
                int dialogResult = wordApp.Dialogs[Microsoft.Office.Interop.Word.WdWordDialog.wdDialogFilePrint].Show(ref nullobj);
                wordApp.Visible = false;
                if (dialogResult == 1)
                {
                    doc.PrintOut(ref oTrue, ref oFalse, ref missing, ref missing, ref missing,
                        ref items, ref copies, ref pages, ref pageType, ref oFalse, ref oTrue,
                        ref missing, ref oFalse, ref missing, ref missing, ref missing, ref missing);
                }
                else
                {
                    MessageBox.Show("Error");
                    GC.Collect();
                    return;
                }
                
                
            }
            #endregion

            nDoc.SaveAs2(ref saveAs, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing);

            nDoc.Close(ref missing, ref missing, ref missing);
            MessageBox.Show("created");
            wordApp.Quit();
            /*List<int> processesaftergen = getRunningProcesses();
            killProcesses(processesbeforegen, processesaftergen);*/
        }


        /*void button1_Click(object sender, EventArgs e)
        {
            var app = new Word.Application();
            var doc = new Word.Document();
            doc = app.Documents.Add();
            app.Visible = true;
        }

        public void button2_Click(object sender, EventArgs e)
        {
            List<int> processesbeforegen = getRunningProcesses();
            Word.Document nDoc = null;
            try
            {
                Word.Application app = new Word.Application();
                string source = @"C:\Users\kirm2\Desktop\asd.docx";
                nDoc = app.Documents.Open(source);
                nDoc.Activate();

                Word.Bookmarks wBookmarks = nDoc.Bookmarks;
                Word.Range wRange;
                int i = 0;
                string[] data = new string[3] { "0", "1", "2" };
                foreach (Word.Bookmark mark in wBookmarks)
                {

                    wRange = mark.Range;
                    wRange.Text = data[i];
                    i++;
                }
                //doc.SelectContentControlsByTag("Address")[1].Range.Text = "asdf"
                //nDoc.SelectContentControlsByTag("test0")[0].Range.Text = "name";
                //nDoc.FormFields["test0"].Result = "name";
                //nDoc.FormFields["test1"].Result = "sur";
                //nDoc.FormFields["test2"].Result = "father";
                nDoc.Close();    
                nDoc = null;
                List<int> processesaftergen = getRunningProcesses();
                killProcesses(processesbeforegen, processesaftergen);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                nDoc.Close();
                nDoc = null;
                Console.WriteLine("Во время выполнения произошла ошибка!");
                Console.ReadLine();
            }
        }
        
        public void button3_Click(object sender, EventArgs e)
        {
            Excel.Application excelApp = new Excel.Application();
            excelApp.Workbooks.Open(@"C:\Users\kirm2\Desktop\asd.xlsx", Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                                    Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                                    Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                                    Type.Missing, Type.Missing);
            //Excel.Workbook workBook;
            Excel.Worksheet workSheet;
            //workBook = excelApp.Workbooks.Add();
            workSheet = (Excel.Worksheet)excelApp.Worksheets.get_Item(1);

            for (int j = 1; j <= 20; j++)
            {
                workSheet.Cells[1, j] = j;
            }
            excelApp.Visible = true;
            excelApp.UserControl = true;
            excelApp.Quit();
        }*/

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idA = dataGridView1.CurrentCell.RowIndex;
            int idB = dataGridView1.CurrentCell.ColumnIndex;

            string GetIdAByClick = dataGridView1.Rows[idA].Cells[0].Value.ToString();
            string GetIdBByClick = dataGridView1.Rows[idA].Cells[1].Value.ToString();
            string GetIdCByClick = dataGridView1.Rows[idA].Cells[2].Value.ToString();
            string GetIdDByClick = dataGridView1.Rows[idA].Cells[3].Value.ToString();
            string GetIdEByClick = dataGridView1.Rows[idA].Cells[4].Value.ToString();
            string GetIdFByClick = dataGridView1.Rows[idA].Cells[5].Value.ToString();
            string GetIdGByClick = dataGridView1.Rows[idA].Cells[6].Value.ToString();
            string GetIdHByClick = dataGridView1.Rows[idA].Cells[7].Value.ToString();
            string GetIdIByClick = dataGridView1.Rows[idA].Cells[8].Value.ToString();
            string GetIdJByClick = dataGridView1.Rows[idA].Cells[9].Value.ToString();
            string GetIdKByClick = dataGridView1.Rows[idA].Cells[10].Value.ToString();
            string GetIdLByClick = dataGridView1.Rows[idA].Cells[11].Value.ToString();
            string GetIdMByClick = dataGridView1.Rows[idA].Cells[12].Value.ToString();
            string GetIdNByClick = dataGridView1.Rows[idA].Cells[13].Value.ToString();
            string GetIdOByClick = dataGridView1.Rows[idA].Cells[14].Value.ToString();
            string GetIdPByClick = dataGridView1.Rows[idA].Cells[15].Value.ToString();
            string GetIdQByClick = dataGridView1.Rows[idA].Cells[16].Value.ToString();
            string GetIdRByClick = dataGridView1.Rows[idA].Cells[17].Value.ToString();
            string GetIdSByClick = dataGridView1.Rows[idA].Cells[18].Value.ToString();


            textBox1.Text = GetIdAByClick;
            textBox2.Text = GetIdBByClick;
            textBox3.Text = GetIdCByClick;
            //textBox4.Text = GetIdDByClick;
            textBox5.Text = GetIdEByClick;
            textBox6.Text = GetIdFByClick;
            textBox7.Text = GetIdGByClick;
            textBox8.Text = GetIdHByClick;
            textBox9.Text = GetIdIByClick;
            textBox10.Text = GetIdJByClick;
            textBox11.Text = GetIdKByClick;
            textBox12.Text = GetIdLByClick;
            textBox13.Text = GetIdMByClick;
            textBox14.Text = GetIdNByClick;
            textBox15.Text = GetIdOByClick;
            textBox16.Text = GetIdPByClick;
            textBox17.Text = GetIdQByClick;
            textBox18.Text = GetIdRByClick;
            textBox19.Text = GetIdSByClick;

            //listText.AddRange(new string[] { });
            //listText.Add(GetIdCByClick);
        }

        private void button4_Click(object sender, EventArgs e) //save
        {
            if (SaveDoc.ShowDialog() == DialogResult.OK && tEnable == true) 
            {
                CreateWordDocument(tFilename.Text, SaveDoc.FileName);
                tEnable = false;
                //printDocument1.DocumentName = SaveDoc.FileName;
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void button5_Click(object sender, EventArgs e) //open
        {
            if (LoadDoc.ShowDialog() == DialogResult.OK) 
            {
                tFilename.Text = LoadDoc.FileName;
                tEnable = true;
            }
        }
        
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            //textBox20.Text = "Михаил";
            /*string tb = textBox20.Text;
            DataView dv = new DataView(ds.Tables[0], "cName = '{ tb }' ", "cName DESC", DataViewRowState.CurrentRows);
            dataGridView1.DataSource = dv;
            dv.RowFilter = "cName = 'фыв'";*/

        }
        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as System.Data.DataTable).DefaultView.RowFilter = string.Format("cSurname like '{0}%'", textBox20.Text);
            if (textBox20.Text == "")
            {
                (dataGridView1.DataSource as System.Data.DataTable).DefaultView.RowFilter = string.Empty;
            }
        }
        private void textBox44_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as System.Data.DataTable).DefaultView.RowFilter = string.Format("education like '{0}%'", textBox44.Text);
            if (textBox44.Text == "")
            {
                (dataGridView1.DataSource as System.Data.DataTable).DefaultView.RowFilter = string.Empty;
            }
        }

        private void textBox45_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as System.Data.DataTable).DefaultView.RowFilter = string.Format("article like '{0}%'", textBox45.Text);
            if (textBox45.Text == "")
            {
                (dataGridView1.DataSource as System.Data.DataTable).DefaultView.RowFilter = string.Empty;
            }
        }

        private void textBox46_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as System.Data.DataTable).DefaultView.RowFilter = string.Format("considerationDate like '{0}%'", textBox46.Text);
            if (textBox46.Text == "")
            {
                (dataGridView1.DataSource as System.Data.DataTable).DefaultView.RowFilter = string.Empty;
            }
        }

        private void textBox47_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as System.Data.DataTable).DefaultView.RowFilter = string.Format("punishment like '{0}%'", textBox47.Text);
            if (textBox47.Text == "")
            {
                (dataGridView1.DataSource as System.Data.DataTable).DefaultView.RowFilter = string.Empty;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //sex,DOB,address,education,cSurname,cName,cFatherName

            string sex = textBox22.Text;
            string DOB = textBox23.Text;
            string address = textBox24.Text;
            string education = textBox25.Text;
            string cSurname = textBox26.Text;
            string cName = textBox27.Text;
            string cFatherName = textBox28.Text;

            string sqlExpression = "AddCriminal";
            try
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, sqlConnection);
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter nameParam = new SqlParameter
                {
                    ParameterName = "@criminalSex",
                    Value = sex
                };
                command.Parameters.Add(nameParam);

                SqlParameter nameParam1 = new SqlParameter
                {
                    ParameterName = "@criminalDOB",
                    Value = DOB
                };
                command.Parameters.Add(nameParam1);

                SqlParameter nameParam2 = new SqlParameter
                {
                    ParameterName = "@criminalAddress",
                    Value = address
                };
                command.Parameters.Add(nameParam2);

                SqlParameter nameParam3 = new SqlParameter
                {
                    ParameterName = "@criminalEducation",
                    Value = education
                };
                command.Parameters.Add(nameParam3);

                SqlParameter nameParam4 = new SqlParameter
                {
                    ParameterName = "@criminalcSurname",
                    Value = cSurname
                };
                command.Parameters.Add(nameParam4);

                SqlParameter nameParam5 = new SqlParameter
                {
                    ParameterName = "@criminalcName",
                    Value = cName
                };
                command.Parameters.Add(nameParam5);

                SqlParameter nameParam6 = new SqlParameter
                {
                    ParameterName = "@criminalcFatherName",
                    Value = cFatherName
                };
                command.Parameters.Add(nameParam6);

                command.ExecuteNonQuery();
                this.criminalTableAdapter1.Fill(this.projectDataSet.Criminal);
                //dataGridView3.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                
                ds2.Clear();
                //dataGridView3.Refresh();
                string sql2 = $"SELECT criminalID,sex,DOB,address,education,cSurname,cName,cFatherName FROM Criminal";
                using (SqlConnection connection = new SqlConnection(connectionToDB))
                {
                    connection.Open();
                    // Создаем объект DataAdapter
                    SqlDataAdapter adapter = new SqlDataAdapter(sql2, connection);
                    // Заполняем Dataset
                    adapter.Fill(ds2);
                    // Отображаем данные
                    dataGridView3.DataSource = ds2.Tables[0];
                }
                sqlConnection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Int32.TryParse(textBox21.Text, out int ID);
            //string name = textBoxEmployeeName.Text;
            string sqlExpression = "DelCriminal";
            try
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, sqlConnection);
                command.CommandType = CommandType.StoredProcedure;
                SqlParameter nameParam = new SqlParameter
                {
                    ParameterName = "@criminalID",
                    Value = ID
                };
                command.Parameters.Add(nameParam);
                command.ExecuteNonQuery();
                this.criminalTableAdapter1.Fill(this.projectDataSet.Criminal);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ds2.Clear();
                string sql2 = $"SELECT criminalID,sex,DOB,address,education,cSurname,cName,cFatherName FROM Criminal";
                using (SqlConnection connection = new SqlConnection(connectionToDB))
                {
                    connection.Open();
                    // Создаем объект DataAdapter
                    SqlDataAdapter adapter = new SqlDataAdapter(sql2, connection);
                    // Заполняем Dataset
                    adapter.Fill(ds2);
                    // Отображаем данные
                    dataGridView3.DataSource = ds2.Tables[0];
                }
                sqlConnection.Close();
            }
        }


        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int IDa = dataGridView4.CurrentCell.RowIndex;
            int IDb = dataGridView4.CurrentCell.ColumnIndex;

            string GetIdAByClick = dataGridView4.Rows[IDa].Cells[0].Value.ToString();
            string GetIdBByClick = dataGridView4.Rows[IDa].Cells[1].Value.ToString();
            string GetIdCByClick = dataGridView4.Rows[IDa].Cells[2].Value.ToString();
            string GetIdDByClick = dataGridView4.Rows[IDa].Cells[3].Value.ToString();


            textBox29.Text = GetIdAByClick;
            textBox30.Text = GetIdBByClick;
            textBox31.Text = GetIdCByClick;
            textBox32.Text = GetIdDByClick;

        }

        private void button6_Click(object sender, EventArgs e) { 

        //string surname = textBox29.Text;
        string surname = textBox30.Text;
        string name = textBox31.Text;
        string fathername = textBox32.Text;


        string sqlExpression = "AddParent";
            try
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, sqlConnection);
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter nameParam = new SqlParameter
                {
                    ParameterName = "@parentSurname",
                    Value = surname
                };
                command.Parameters.Add(nameParam);

                SqlParameter nameParam1 = new SqlParameter
                {
                    ParameterName = "@parentNmae",
                    Value = name
                };
                command.Parameters.Add(nameParam1);

                SqlParameter nameParam2 = new SqlParameter
                {
                    ParameterName = "@parentFathername",
                    Value = fathername
                };
                command.Parameters.Add(nameParam2);

                command.ExecuteNonQuery();
                this.parentsTableAdapter1.Fill(this.projectDataSet.Parents);
                //dataGridView3.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

                ds3.Clear();
                //dataGridView3.Refresh();
                string sql3 = $"SELECT parentID,surname, name, fatherName FROM Parents";
                using (SqlConnection connection = new SqlConnection(connectionToDB))
                {
                    connection.Open();
                    // Создаем объект DataAdapter
                    SqlDataAdapter adapter = new SqlDataAdapter(sql3, connection);
                    // Заполняем Dataset
                    adapter.Fill(ds3);
                    // Отображаем данные
                    dataGridView4.DataSource = ds3.Tables[0];
                }
                sqlConnection.Close();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Int32.TryParse(textBox29.Text, out int ID);
            //string name = textBoxEmployeeName.Text;
            string sqlExpression = "DelParent";
            try
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, sqlConnection);
                command.CommandType = CommandType.StoredProcedure;
                SqlParameter nameParam = new SqlParameter
                {
                    ParameterName = "@parentID",
                    Value = ID
                };
                command.Parameters.Add(nameParam);
                command.ExecuteNonQuery();
                this.parentsTableAdapter1.Fill(this.projectDataSet.Parents);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ds3.Clear();
                string sql3 = $"SELECT parentID,surname, name, fatherName FROM Parents";
                using (SqlConnection connection = new SqlConnection(connectionToDB))
                {
                    connection.Open();
                    // Создаем объект DataAdapter
                    SqlDataAdapter adapter = new SqlDataAdapter(sql3, connection);
                    // Заполняем Dataset
                    adapter.Fill(ds3);
                    // Отображаем данные
                    dataGridView4.DataSource = ds3.Tables[0];
                }
                sqlConnection.Close();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string parentsFK = textBox33.Text;
            string criminalFK = textBox34.Text;

            string article = textBox35.Text;
            string material = textBox36.Text;
            string refusal = textBox37.Text;
            string considerationDate = textBox38.Text;
            string punishment = textBox39.Text;
            string sum = textBox40.Text;
            string paidSum = textBox41.Text;
            string maturityDate = textBox42.Text;
            string courtDate = textBox43.Text;

            string sqlExpression = "AddOffense";
            try
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, sqlConnection);
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter nameParam = new SqlParameter
                {
                    ParameterName = "@article",
                    Value = article
                };
                command.Parameters.Add(nameParam);

                SqlParameter nameParam1 = new SqlParameter
                {
                    ParameterName = "@material",
                    Value = material
                };
                command.Parameters.Add(nameParam1);

                SqlParameter nameParam2 = new SqlParameter
                {
                    ParameterName = "@refusal",
                    Value = refusal
                };
                command.Parameters.Add(nameParam2);

                SqlParameter nameParam3 = new SqlParameter
                {
                    ParameterName = "@considerationDate",
                    Value = considerationDate
                };
                command.Parameters.Add(nameParam3);

                SqlParameter nameParam4 = new SqlParameter
                {
                    ParameterName = "@punishment",
                    Value = punishment
                };
                command.Parameters.Add(nameParam4);

                SqlParameter nameParam5 = new SqlParameter
                {
                    ParameterName = "@sum",
                    Value = sum
                };
                command.Parameters.Add(nameParam5);

                SqlParameter nameParam6 = new SqlParameter
                {
                    ParameterName = "@paidSum",
                    Value = paidSum
                };
                command.Parameters.Add(nameParam6);

                SqlParameter nameParam7 = new SqlParameter
                {
                    ParameterName = "@maturityDate",
                    Value = maturityDate
                };
                command.Parameters.Add(nameParam7);

                SqlParameter nameParam8 = new SqlParameter
                {
                    ParameterName = "@courtDate",
                    Value = courtDate
                };
                command.Parameters.Add(nameParam8);

                SqlParameter nameParam9 = new SqlParameter
                {
                    ParameterName = "@parentsFK",
                    Value = parentsFK
                };
                command.Parameters.Add(nameParam9);

                SqlParameter nameParam10 = new SqlParameter
                {
                    ParameterName = "@criminalFK",
                    Value = criminalFK
                };
                command.Parameters.Add(nameParam10);

                command.ExecuteNonQuery();
                this.offenseTableAdapter1.Fill(this.projectDataSet.Offense);
                //dataGridView3.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

                ds1.Clear();
                //dataGridView3.Refresh();
                string sql1 = $"SELECT (c.cSurname + ' ' + c.cName + ' ' +c.cFatherName)as ФИО,(P.surname + ' ' + p.name + ' ' + p.fatherName) as ФИО_родителя,article, material, refusal, considerationDate, punishment, sum, paidSum, maturityDate, courtDate,offenseID FROM Offense as O, Criminal as C, Parents as P where parentsFK = parentID AND criminalFK = criminalID ";
                using (SqlConnection connection = new SqlConnection(connectionToDB))
                {
                    connection.Open();
                    // Создаем объект DataAdapter
                    SqlDataAdapter adapter = new SqlDataAdapter(sql1, connection);
                    // Заполняем Dataset
                    adapter.Fill(ds1);
                    // Отображаем данные
                    dataGridView2.DataSource = ds1.Tables[0];
                }
                sqlConnection.Close();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
            Int32.TryParse(textBox4.Text, out int ID);
            //string name = textBoxEmployeeName.Text;
            string sqlExpression = "DelOffense";
            try
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, sqlConnection);
                command.CommandType = CommandType.StoredProcedure;
                SqlParameter nameParam = new SqlParameter
                {
                    ParameterName = "@offenseID",
                    Value = ID
                };
                command.Parameters.Add(nameParam);
                command.ExecuteNonQuery();
                this.offenseTableAdapter1.Fill(this.projectDataSet.Offense);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ds1.Clear();
            string sql1 = $"SELECT (c.cSurname + ' ' + c.cName + ' ' +c.cFatherName)as ФИО,(P.surname + ' ' + p.name + ' ' + p.fatherName) as ФИО_родителя,article, material, refusal, considerationDate, punishment, sum, paidSum, maturityDate, courtDate,offenseID FROM Offense as O, Criminal as C, Parents as P where parentsFK = parentID AND criminalFK = criminalID ";
                using (SqlConnection connection = new SqlConnection(connectionToDB))
                {
                    connection.Open();
                    // Создаем объект DataAdapter
                    SqlDataAdapter adapter = new SqlDataAdapter(sql1, connection);
                    // Заполняем Dataset
                    adapter.Fill(ds1);
                    // Отображаем данные
                    dataGridView2.DataSource = ds1.Tables[0];
                }
                sqlConnection.Close();
            }
        }

        private void dataGridView2_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int idA = dataGridView2.CurrentCell.RowIndex;
            int idB = dataGridView2.CurrentCell.ColumnIndex;
            //string sql1 = $"SELECT offenseID from offense offenseID = '{idA}'";

            
            

            string GetIdAByClick = dataGridView2.Rows[idA].Cells[0].Value.ToString();
            string GetIdBByClick = dataGridView2.Rows[idA].Cells[1].Value.ToString();
            string GetIdCByClick = dataGridView2.Rows[idA].Cells[2].Value.ToString();
            string GetIdDByClick = dataGridView2.Rows[idA].Cells[3].Value.ToString();
            string GetIdEByClick = dataGridView2.Rows[idA].Cells[4].Value.ToString();
            string GetIdFByClick = dataGridView2.Rows[idA].Cells[5].Value.ToString();
            string GetIdGByClick = dataGridView2.Rows[idA].Cells[6].Value.ToString();
            string GetIdHByClick = dataGridView2.Rows[idA].Cells[7].Value.ToString();
            string GetIdIByClick = dataGridView2.Rows[idA].Cells[8].Value.ToString();
            string GetIdJByClick = dataGridView2.Rows[idA].Cells[9].Value.ToString();
            string GetIdKByClick = dataGridView2.Rows[idA].Cells[10].Value.ToString();
            string GetIdLByClick = dataGridView2.Rows[idA].Cells[11].Value.ToString();


            //string sql1 = $"SELECT parentsFK FROM Offense where offenseID = '{idA}'";
            //textBox33.Text = sql1;
            //textBox34.Text = GetIdBByClick;
            textBox35.Text = GetIdCByClick;
            textBox36.Text = GetIdDByClick;
            textBox37.Text = GetIdEByClick;
            textBox38.Text = GetIdFByClick;
            textBox39.Text = GetIdGByClick;
            textBox40.Text = GetIdHByClick;
            textBox41.Text = GetIdIByClick;
            textBox42.Text = GetIdJByClick;
            textBox43.Text = GetIdKByClick;
            textBox4.Text = GetIdLByClick;
        }
    }
}
