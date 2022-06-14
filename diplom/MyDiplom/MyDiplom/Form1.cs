using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace MyDiplom
{
    public partial class Form1 : Form
    {

        public static string ConnectionString1 = @"Provider=Microsoft.Jet.OLEDB.4.0; " +
                                             "Data Source= 1.mdb";
        public static string ConnectionString2 = @"Provider=Microsoft.ACE.OLEDB.12.0; " +
                                            "Data Source= 1.mdb";

        private OleDbConnection connection;

        public static string OperName;
        public static int OperVidd;
        public static int OperKod;
        public static string OperGorod;


        private volatile string LOGIN;
        private volatile string PASS;

       // private volatile bool PROTECTION; //тест на оператора
        public Form1()
        {
            InitializeComponent();


            try
            {
                connection = new OleDbConnection();
                connection.ConnectionString = ConnectionString1;
                connection.Open();
            }
            catch (InvalidOperationException)
            {
                connection = new OleDbConnection();
                connection.ConnectionString = ConnectionString2;
                connection.Open();
            }




        }

  

        



        private void button1_Click(object sender, EventArgs e)
        {
            /*menu C = new menu();
            C.label1.Text = OperName;
            C.Show();*/
            //удалить!!!!!!!!!!!!!!!!!!!!!!!!!

            Operator oper = new Operator();
            oper.kod_user = 0;
            oper.FullName = "Nn";
            oper.Login = "Nn";
            oper.Pass = "Nn";
            oper.Position = "Nn";
            oper.User_vid = 0;
            oper.User_phone = "Nn";

            LOGIN = textBox1.Text;
            PASS = textBox2.Text;

            //string sql = "SELECT  * FROM User_vid ";
            //string sql = "SELECT User_vid.user_login, User_vid.user_pass FROM User_vid WHERE User_vid.user_login = 'zinovyev.a' AND User_vid.user_pass = 'Aa 111111'";
            //string sql = "SELECT user_login  FROM User_vid WHERE User_vid.user_login = 'zinovyev.a'";
            string sql = "SELECT User_vid.user_login, User_vid.user_pass, User_vid.user_fullname, User_vid.user_position, viddilenya.number_vid, User_vid.Kod_user, viddilenya.name_city FROM User_vid, viddilenya WHERE User_vid.user_vid = viddilenya.Kod_vid";
           
            OleDbCommand myCommand = new OleDbCommand(sql, connection);
            OleDbDataReader reader = myCommand.ExecuteReader();

            while (reader.Read())
            {
                //richTextBox1.Text = richTextBox1.Text + "\n" + reader[0].ToString() + " " + reader[1].ToString() + reader[2].ToString() + " " + reader[3].ToString() + " " + reader[4].ToString() + " ";

                if (LOGIN == reader[0].ToString() && PASS == reader[1].ToString())
                {
                    //richTextBox1.Text = richTextBox1.Text + "\n" + reader[0].ToString() + " " + reader[1].ToString() + reader[2].ToString() + " " + reader[3].ToString() + " " + reader[4].ToString() + " ";

                    
                    oper.Login = reader[0].ToString();
                    oper.Pass = reader[1].ToString();
                    oper.FullName = reader[2].ToString();
                    oper.Position = reader[3].ToString();
                    oper.User_vid = Int32.Parse(reader[4].ToString());
                    oper.kod_user = Int32.Parse(reader[5].ToString());

                    OperName = oper.FullName;
                    OperVidd = oper.User_vid;
                    OperKod = oper.kod_user;
                    OperGorod = reader[6].ToString();


                    //blashinin.i

                    menu C = new menu();
                    C.label1.Text = OperName;

                    C.Show();




                    //richTextBox1.Text = richTextBox1.Text + "\n" + oper.Login + " " + oper.Pass + " " + oper.FullName + " " + oper.Position + " " + oper.User_vid;

                }


            }
            reader.Close();

            textBox1.Text = "";
            textBox2.Text = "";


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
