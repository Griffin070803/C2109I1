using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet ds = new DataSet();
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();

            //table.DataSource = ds.Tables[1].DefaultView; 
        }

        private void LoadData()
        {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["Griffin"].ConnectionString;

            command.Connection = con;
            command.CommandText = "select * from Student";//; select Id, FirstName from Student
            command.CommandType = CommandType.Text;
            adapter.SelectCommand = command;
            ds.Tables.Clear();
            adapter.Fill(ds);
            bindingSource1.DataSource = ds.Tables[0];
            table.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            TxtId.DataBindings.Add("Text", bindingSource1, "Id", true, DataSourceUpdateMode.OnPropertyChanged);
            txtFirstName.DataBindings.Add("Text", bindingSource1, "FirstName", true, DataSourceUpdateMode.OnPropertyChanged);//true, DataSourceUpdateMode.OnPropertyChanged: khi làm mobile
            TxtLastName.DataBindings.Add("Text", bindingSource1, "LastName", true, DataSourceUpdateMode.OnPropertyChanged);
            ChkGender.DataBindings.Add("Checked", bindingSource1, "Gender", true, DataSourceUpdateMode.OnPropertyChanged);
            DtpDOB.DataBindings.Add("Value", bindingSource1, "Dob", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            //ds.Tables[0].DefaultView bằng select * from Student
            //RowFilter bằng where  => firstname like
            ds.Tables[0].DefaultView.RowFilter = $" FirstName like '%{toolStripTextBox1.Text}%'";
        }

        private void table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex  != -1)
            {
                textBox1.Text = table.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            command.CommandText = "UpdateStudent";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
            command.Parameters.AddWithValue("@LastName", TxtLastName.Text);
            command.Parameters.AddWithValue("@Gender", ChkGender.Checked);
            command.Parameters.AddWithValue("@Dob", DtpDOB.Value);
            command.Parameters.AddWithValue("@Id", TxtId.Text);
            con.Open();
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Success", "Info");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                con.Close();
                command.Parameters.Clear();
                TxtId.DataBindings.Clear();
                txtFirstName.DataBindings.Clear();
                TxtLastName.DataBindings.Clear();
                ChkGender.DataBindings.Clear();
                DtpDOB.DataBindings.Clear();
                LoadData();
            }
        }

        private void BtnUpdateAdapter_Click(object sender, EventArgs e)
        {
            bindingSource1.EndEdit();
            SqlCommandBuilder buider = new SqlCommandBuilder(adapter);
            buider.GetUpdateCommand();
            try
            {
                adapter.Update(ds.Tables[0]);
                MessageBox.Show("Success", "Info");
            }
            catch (Exception exe)
            {

                MessageBox.Show(exe.Message, "Error");
            }
        }
    }
}
