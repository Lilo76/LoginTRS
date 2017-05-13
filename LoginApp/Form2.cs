using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LoginApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //This is my connection string i have assigned the database file address path
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=1234;database=trs";
                //This is my insert query in which i am taking input from the user through windows forms
                string Query = "insert into trs.produit(id,indice,nom,config,temps) values('" +this.IdTextBox.Text+ "','" +this.NameTextBox.Text+ "','" +this.FnameTextBox.Text+ "','" +this.AgeTextBox.Text+ "','" +this.SemesterTextBox.Text+ "');";
                //This is  MySqlConnection here i have created the object and pass my connection string.
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
               //This is command class which will handle the query and connection object.
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                MessageBox.Show("Save Data");
                while (MyReader2.Read())
                {
                    
                }
                dataGridView1.DataSource = "produit";
                dataGridView1.Refresh();
                MyConn2.Close();

                string MyConnection3 = "datasource=localhost;port=3306;username=root;password=1234;database=trs";
                MySqlConnection MyConn3 = new MySqlConnection(MyConnection3);
                MySqlDataAdapter MyDA = new MySqlDataAdapter();
                string sqlSelectAll = "SELECT * from produit";
                MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, MyConn3);

                DataTable table = new DataTable();
                MyDA.Fill(table);

                BindingSource bSource = new BindingSource();
                bSource.DataSource = table;


                dataGridView1.DataSource = bSource;
                MyConn3.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //This is my connection string i have assigned the database file address path
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=1234;database=trs";
                //This is my update query in which i am taking input from the user through windows forms and update the record.
                string Query = "update trs.produit set id='" + this.IdTextBox.Text + "',indice='" + this.NameTextBox.Text + "',nom='" + this.FnameTextBox.Text + "',config='" + this.AgeTextBox.Text + "',temps='" + this.SemesterTextBox.Text + "' where id='" + this.IdTextBox.Text + "';";
                //This is  MySqlConnection here i have created the object and pass my connection string.
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Data Updated");
                while (MyReader2.Read())
                {

                }
                MyConn2.Close();//Connection closed here



                string MyConnection3 = "datasource=localhost;port=3306;username=root;password=1234;database=trs";
                MySqlConnection MyConn3 = new MySqlConnection(MyConnection3);
                MySqlDataAdapter MyDA = new MySqlDataAdapter();
                string sqlSelectAll = "SELECT * from produit";
                MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, MyConn3);

                DataTable table = new DataTable();
                MyDA.Fill(table);

                BindingSource bSource = new BindingSource();
                bSource.DataSource = table;


                dataGridView1.DataSource = bSource;
                MyConn3.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=1234;database=trs";
                string Query = "delete from trs.produit where id='" + this.IdTextBox.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Data Deleted");
                while (MyReader2.Read())
                {

                }
                MyConn2.Close();

                string MyConnection3 = "datasource=localhost;port=3306;username=root;password=1234;database=trs";
                MySqlConnection MyConn3 = new MySqlConnection(MyConnection3);
                MySqlDataAdapter MyDA = new MySqlDataAdapter();
                string sqlSelectAll = "SELECT * from produit";
                MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, MyConn3);

                DataTable table = new DataTable();
                MyDA.Fill(table);

                BindingSource bSource = new BindingSource();
                bSource.DataSource = table;


                dataGridView1.DataSource = bSource;
                MyConn3.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string MyConnection2 = "datasource=localhost;port=3306;username=root;password=1234;database=trs";
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            MySqlDataAdapter MyDA = new MySqlDataAdapter();
            string sqlSelectAll = "SELECT * from produit";
            MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, MyConn2);

            DataTable table = new DataTable();
            MyDA.Fill(table);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;


            dataGridView1.DataSource = bSource;
            MyConn2.Close();


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void IdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string MyConnection2 = "datasource=localhost;port=3306;username=root;password=1234;database=trs";
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            MySqlDataAdapter MyDA = new MySqlDataAdapter();
            string sqlSelectAll = "SELECT * from produit";
            MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, MyConn2);

            DataTable table = new DataTable();
            MyDA.Fill(table);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;


            dataGridView1.DataSource = bSource;
            MyConn2.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
