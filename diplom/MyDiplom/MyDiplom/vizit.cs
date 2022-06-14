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
    public partial class vizit : Form
    {
        public static string ConnectionString1 = @"Provider=Microsoft.Jet.OLEDB.4.0; " +
                                             "Data Source= 1.mdb";
        public static string ConnectionString2 = @"Provider=Microsoft.ACE.OLEDB.12.0; " +
                                            "Data Source= 1.mdb";

        private OleDbConnection connection;

        public static bool OPLACHENO;
        public static int VIDPRAVLENYAPRICE;
        public static bool VIDP_ZAKRIT;
        public static int VIDP_EN;




        public vizit()
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
            this.Close();
        }

        private void vizit_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_1DataSet.poslugi". При необходимости она может быть перемещена или удалена.
            this.poslugiTableAdapter.Fill(this._1DataSet.poslugi);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_1DataSet.pakuv". При необходимости она может быть перемещена или удалена.
            this.pakuvTableAdapter.Fill(this._1DataSet.pakuv);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (OPLACHENO = true)
            {
                VIDP_ZAKRIT = true;
                VIDP_EN = Int32.Parse(label2.Text);

                string sql = "UPDATE vidprav SET vidp_price = "+0+" , vidp_oplacheno = "+true+" , vidp_zakrito = "+true+ " WHERE kod_vidp = "+ VIDP_EN;
                OleDbCommand myCommand = new OleDbCommand(sql, connection);

                myCommand.ExecuteNonQuery();
                DialogResult dialogResult = MessageBox.Show(" Відправлення закрито" + "\n\n", " Підтвердження");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
             OPLACHENO = true;
             label18.Text = "Вартість послуг: 0 ₴";
             VIDPRAVLENYAPRICE = 0;
            


            oplata opp = new oplata();
            opp.Show();
        }
    }
}
