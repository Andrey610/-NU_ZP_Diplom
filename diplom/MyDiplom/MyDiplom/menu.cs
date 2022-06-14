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
    public partial class menu : Form
    {

        public static string ConnectionString1 = @"Provider=Microsoft.Jet.OLEDB.4.0; " +
                                             "Data Source= 1.mdb";
        public static string ConnectionString2 = @"Provider=Microsoft.ACE.OLEDB.12.0; " +
                                            "Data Source= 1.mdb";

        private OleDbConnection connection;
        public menu()
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
            rmo A = new rmo();
            A.Show();
            //richTextBox1.Text = richTextBox1.Text + "\n" + Form1.OperName + " " + Form1.OperVidd;

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Vidpravlenya viz = new Vidpravlenya();
            viz.VidpravKod = 0;
            viz.NameOperator =0;
            viz.PhoneVidpravnika = "";
            viz.PhoneOtrimuvacha = "";
            viz.NameVidpravnika = "";
            viz.NameOtrimuvacha = "";
            viz.ViddilenyaVidpravnika = 0;
            viz.ViddilenyaOtrimuvacha = 0;

            viz.TypeVidpravlenya = false;

            viz.VesVidpravlenya = 0;
            viz.ObjemVidpravlenya = 0;


            viz.OpisVidpravlenya = "";
            viz.OgoloshVartist = 0;



            viz.Upakovka = 0;
            viz.DopUslugi = 0;

            viz.DateStvorenya = "";
            viz.TimeStvorenya = "";
            viz.DatePriezda = "";

            viz.GdeOtbito = "";

            viz.CityVidpravnika = "";
            viz.CityOtrimuvacha = "";
            viz.KtoPlatit = false;
            viz.Oplacheno = false;//dodav v vizit
            viz.VidpravlenyaPrice = 0;
            viz.ENalojka = false; // last  
            viz.PriceNalojka = 0; // last
            viz.Vidp_zakrit = false;
            viz.TypeVidpravlenya = false;


            string sql = "SELECT * FROM vidprav WHERE vidprav.kod_vidp = " + Int32.Parse(textBox1.Text);

            OleDbCommand myCommand = new OleDbCommand(sql, connection);
            OleDbDataReader reader2 = myCommand.ExecuteReader();

            while (reader2.Read())
            {
                
                viz.VidpravKod = Int32.Parse(reader2[0].ToString());
                viz.NameOperator = Int32.Parse(reader2[1].ToString());
                viz.PhoneVidpravnika = reader2[2].ToString();
                viz.PhoneOtrimuvacha = reader2[3].ToString();
                viz.NameVidpravnika = reader2[4].ToString();
                viz.NameOtrimuvacha = reader2[5].ToString();
                viz.ViddilenyaVidpravnika = Int32.Parse(reader2[6].ToString());
                viz.ViddilenyaOtrimuvacha = Int32.Parse(reader2[7].ToString());
                viz.TypeVidpravlenya = bool.Parse(reader2[8].ToString());
                viz.VesVidpravlenya = Int32.Parse(reader2[9].ToString());
                viz.OpisVidpravlenya = reader2[10].ToString();
                viz.OgoloshVartist = Int32.Parse(reader2[11].ToString());
                viz.KtoPlatit =  bool.Parse(reader2[12].ToString());
                viz.VidpravlenyaPrice = Int32.Parse(reader2[13].ToString());
                viz.Oplacheno =  bool.Parse(reader2[14].ToString());
                viz.DopUslugi = Int32.Parse(reader2[15].ToString());
                viz.Upakovka = Int32.Parse(reader2[16].ToString());
                viz.DateStvorenya = reader2[17].ToString();
                viz.TimeStvorenya = reader2[18].ToString();
                viz.DatePriezda = reader2[19].ToString();
                viz.GdeOtbito = reader2[20].ToString();
                viz.CityVidpravnika = reader2[21].ToString();
                viz.CityOtrimuvacha = reader2[22].ToString();
                viz.ObjemVidpravlenya = Int32.Parse(reader2[23].ToString());
                viz.ENalojka = bool.Parse(reader2[24].ToString());
                viz.PriceNalojka = Int32.Parse(reader2[25].ToString());
                viz.Vidp_zakrit =  bool.Parse(reader2[26].ToString());
            }
            reader2.Close();

            string namePakuv = "";

            string sql2 = "SELECT pakuv_name FROM pakuv WHERE pakuv.kod_pakuv = " + viz.Upakovka;

            OleDbCommand myCommand2 = new OleDbCommand(sql2, connection);
            OleDbDataReader reader3 = myCommand2.ExecuteReader();

            while (reader3.Read())
            {
                namePakuv = reader3[0].ToString();
            }
            reader3.Close();

            string namePoslug = "";

            string sql3 = "SELECT poslug_name FROM poslugi WHERE poslugi.Код = " + viz.DopUslugi;

            OleDbCommand myCommand3 = new OleDbCommand(sql3, connection);
            OleDbDataReader reader4 = myCommand3.ExecuteReader();

            while (reader4.Read())
            {
                namePoslug = reader4[0].ToString();
            }
            reader4.Close();



            vizit Bb = new vizit();
            
            Bb.label2.Text = viz.VidpravKod.ToString();
            Bb.label3.Text = viz.DateStvorenya;
            Bb.label4.Text = viz.TimeStvorenya;
            Bb.textBox1.Text = viz.PhoneVidpravnika;
            Bb.textBox2.Text = viz.NameVidpravnika;
            Bb.textBox3.Text = viz.OpisVidpravlenya;
            Bb.textBox4.Text = viz.OgoloshVartist.ToString();
            Bb.textBox5.Text = viz.VesVidpravlenya.ToString();
            Bb.textBox13.Text = namePakuv;
            Bb.label23.Text = viz.ObjemVidpravlenya.ToString();
            Bb.textBox9.Text = viz.PhoneOtrimuvacha;
            Bb.textBox10.Text = viz.NameOtrimuvacha;
            Bb.textBox11.Text = viz.CityOtrimuvacha;
            Bb.textBox12.Text = viz.ViddilenyaOtrimuvacha.ToString();
            Bb.textBox14.Text = namePoslug;
            if (viz.KtoPlatit == true)
            {
                Bb.radioButton1.Checked = true;
            }
            else
            {
                Bb.radioButton2.Checked = true;
            }
            Bb.label18.Text = "Вартість послуг: "+ viz.VidpravlenyaPrice.ToString() + " ₴";

            Bb.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //menu G = new menu();
            this.Close();
        }

        private void menu_Load(object sender, EventArgs e)
        {
            
        }
    }
}
