using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            //C2109I1Entities ef = new C2109I1Entities();
            //dataGridView1.DataSource = ef.Students.ToList();
            //dùng xong đối tượng vẫn còn sống
            //dùng entity frameword khai biến cục bộ không xài toàn cục


            //chạy xong nó sẽ chết
            //**** cách 1 **** : lấy hết
            using (var ef = new C2109I1Entities())
            {
                bindingSource1.DataSource = await ef.Students.ToListAsync();
                //có await thì phương thức phải có async, là bất đồng bộ
                //có asyac mà không có await thì vẫn chạy đồng bộ
                bindingNavigator1.BindingSource = bindingSource1;
                dataGridView1.DataSource        = bindingSource1;
                TxtId.DataBindings.Add("Text", bindingSource1, "Id", true, DataSourceUpdateMode.OnPropertyChanged);
                TxtFirstName.DataBindings.Add("Text", bindingSource1, "FirstName", true, DataSourceUpdateMode.OnPropertyChanged);//true, DataSourceUpdateMode.OnPropertyChanged: khi làm mobile
                TxtLastName.DataBindings.Add("Text", bindingSource1, "LastName", true, DataSourceUpdateMode.OnPropertyChanged);
                checkBox1.DataBindings.Add("Checked", bindingSource1, "Gender", true, DataSourceUpdateMode.OnPropertyChanged);
                dateTimePicker1.DataBindings.Add("Value", bindingSource1, "Dob", true, DataSourceUpdateMode.OnPropertyChanged);
            }

            //**** cách 2 **** : lấy hết hoặc lấy cái nào mình muốn
            //using (var ef = new C2109I1Entities())
            //{
            //    dataGridView1.DataSource = ef.Students.Select(stu => new
            //    {
            //        stu.Id, stu.FirstName, stu.LastName, stu.Gender, stu.Dob
            //    }).ToList();
            //}

             
        }

        
        private async void Update_Click(object sender, EventArgs e)
        {
            using (var ef = new C2109I1Entities())
            {
                var id = Convert.ToInt32(TxtId.Text);
                var obj = await ef.Students.SingleOrDefaultAsync(i => i.Id == id);
                if (obj != null)
                {
                    obj.FirstName = TxtFirstName.Text;
                    obj.LastName = TxtLastName.Text;
                    obj.Gender = checkBox1.Checked;
                    obj.Dob = dateTimePicker1.Value;
                }
                //xong hết update về database 
                await ef.SaveChangesAsync();

                bindingSource1.DataSource = await ef.Students.ToListAsync();
                MessageBox.Show("Success", "info");
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            using (var ef = new C2109I1Entities())
            {
                var stu = new Student();
                stu.FirstName = TxtFirstName.Text;
                stu.LastName  = TxtLastName.Text;
                stu.Gender    = checkBox1.Checked;
                stu.Dob       = dateTimePicker1.Value;

                ef.Students.Add(stu);
                await ef.SaveChangesAsync();
                bindingSource1.DataSource = await ef.Students.ToListAsync();
                MessageBox.Show("Success", "info");
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            using (var ef = new C2109I1Entities())
            {
                var id = Convert.ToInt32(TxtId.Text);
                foreach(var stu in ef.Students)
                {
                    if(stu.Id == id)
                    {
                        ef.Students.Remove(stu);
                    }
                }

                //ef.Students.RemoveRange(i => ef.Students.Where(t => t.Id == id));

                await ef.SaveChangesAsync();
                bindingSource1.DataSource = await ef.Students.ToListAsync();
                MessageBox.Show("Success", "info");
            }
        }
    }
}
