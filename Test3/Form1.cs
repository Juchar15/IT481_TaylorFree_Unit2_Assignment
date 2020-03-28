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

namespace Test3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Data Source=DESKTOP-FAHRK5N;Initial Catalog=Northwind;Integrated Security=True";
                connection.Open();

                checkconnection.Text = "Connection Successful";
                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error, " + ex);
            }

            }

        private void InitializeComponent()
        {
            this.checkconnection = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.recordsbutton = new System.Windows.Forms.Button();
            this.countbutton = new System.Windows.Forms.Button();
            this.counttotal = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.employeebutton = new System.Windows.Forms.Button();
            this.ordersbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // checkconnection
            // 
            this.checkconnection.AutoSize = true;
            this.checkconnection.Location = new System.Drawing.Point(12, 366);
            this.checkconnection.Name = "checkconnection";
            this.checkconnection.Size = new System.Drawing.Size(95, 13);
            this.checkconnection.TabIndex = 0;
            this.checkconnection.Text = "Check Connection";
            this.checkconnection.Click += new System.EventHandler(this.checkconnection_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(239, 150);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // recordsbutton
            // 
            this.recordsbutton.Location = new System.Drawing.Point(63, 168);
            this.recordsbutton.Name = "recordsbutton";
            this.recordsbutton.Size = new System.Drawing.Size(135, 30);
            this.recordsbutton.TabIndex = 2;
            this.recordsbutton.Text = "View Customer Records";
            this.recordsbutton.UseVisualStyleBackColor = true;
            this.recordsbutton.Click += new System.EventHandler(this.recordsbutton_Click);
            // 
            // countbutton
            // 
            this.countbutton.Location = new System.Drawing.Point(78, 305);
            this.countbutton.Name = "countbutton";
            this.countbutton.Size = new System.Drawing.Size(92, 23);
            this.countbutton.TabIndex = 3;
            this.countbutton.Text = "Count Records";
            this.countbutton.UseVisualStyleBackColor = true;
            this.countbutton.Click += new System.EventHandler(this.countbutton_Click);
            // 
            // counttotal
            // 
            this.counttotal.AutoSize = true;
            this.counttotal.Location = new System.Drawing.Point(85, 263);
            this.counttotal.Name = "counttotal";
            this.counttotal.Size = new System.Drawing.Size(74, 13);
            this.counttotal.TabIndex = 4;
            this.counttotal.Text = "Total Records";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(277, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(236, 150);
            this.dataGridView2.TabIndex = 5;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(543, 12);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(240, 150);
            this.dataGridView3.TabIndex = 6;
            // 
            // employeebutton
            // 
            this.employeebutton.Location = new System.Drawing.Point(329, 168);
            this.employeebutton.Name = "employeebutton";
            this.employeebutton.Size = new System.Drawing.Size(136, 31);
            this.employeebutton.TabIndex = 7;
            this.employeebutton.Text = "View Employee Records";
            this.employeebutton.UseVisualStyleBackColor = true;
            this.employeebutton.Click += new System.EventHandler(this.employeebutton_Click);
            // 
            // ordersbutton
            // 
            this.ordersbutton.Location = new System.Drawing.Point(608, 167);
            this.ordersbutton.Name = "ordersbutton";
            this.ordersbutton.Size = new System.Drawing.Size(127, 32);
            this.ordersbutton.TabIndex = 8;
            this.ordersbutton.Text = "View Orders";
            this.ordersbutton.UseVisualStyleBackColor = true;
            this.ordersbutton.Click += new System.EventHandler(this.ordersbutton_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(795, 388);
            this.Controls.Add(this.ordersbutton);
            this.Controls.Add(this.employeebutton);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.counttotal);
            this.Controls.Add(this.countbutton);
            this.Controls.Add(this.recordsbutton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.checkconnection);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void checkconnection_Click(object sender, EventArgs e)
        {

        }

        private void recordsbutton_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=DESKTOP-FAHRK5N;Initial Catalog=Northwind;Integrated Security=True";
            connection.Open();

            command.Connection = connection;
            command.CommandText = "select * from Customers";

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void countbutton_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=DESKTOP-FAHRK5N;Initial Catalog=Northwind;Integrated Security=True";
            connection.Open();

            command.Connection = connection;
            command.CommandText = "select count(*) from Customers";

            int count = (int)command.ExecuteScalar();
            counttotal.Text = count.ToString();
        }

        private void employeebutton_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=DESKTOP-FAHRK5N;Initial Catalog=Northwind;Integrated Security=True";
            connection.Open();

            command.Connection = connection;
            command.CommandText = "select * from Employees";
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView2.DataSource = dt;
            connection.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ordersbutton_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=DESKTOP-FAHRK5N;Initial Catalog=Northwind;Integrated Security=True";
            connection.Open();

            command.Connection = connection;
            command.CommandText = "select * from Orders";
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView3.DataSource = dt;
            connection.Close();
        }
    }
        
    }

