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
using System.Runtime.InteropServices;

namespace MyDiplom
{
    public partial class rmo : Form
    {

        public static string ConnectionString1 = @"Provider=Microsoft.Jet.OLEDB.4.0; " +
                                             "Data Source= 1.mdb";
        public static string ConnectionString2 = @"Provider=Microsoft.ACE.OLEDB.12.0; " +
                                            "Data Source= 1.mdb";

        private OleDbConnection connection;

        //глобальные
        public static int NAMEOPERATOR;
        public static string PHONEVIDPRAVNIKA;
        public static string PHONEOTRIMUVACHA;
        public static string NAMEVIDPRAVNIKA;
        public static string NAMEOTRIMUVACHA;
        public static int VIDDILENYAVIDPRAVNIKA;
        public static int VIDDILENYAOTRIMUVACHA;
        public static bool TYPEVIDPRAVLENYA;
        public static int VESVIDPRAVLENYA;
        public static int OBJEMVIDPRAVLENYA;
        public static string OPISVIDPRAVLENYA;
        public static int OGOLOSHVARTIST;
        
        
        public static int VIDPRAVLENYAPRICE = 0;
        public static int BasePrice = 60;
        public static int KGPrice = 0;

        public static int DOPUSLUGI;
        public static int UPAKOVKA;
        public static string DATESTVORENYA;
        public static string TIMESTVORENYA;
        public static string DATEPRIEZDA;
        public static string GDEOTBITO;
        public static string CITYVIDPRAVNIKA;
        public static string CITYOTRIMUVACHA;
        public static bool ENALOJKA;
        public static int PRICENALOJKA;
        public static bool VIDP_ZAKRIT;

        public static int poslugG;
        public static int upakG;

        public static int Xo;
        public static int Yo;
        public static int Zo;

        public static bool OPLACHENO = false;

        public static int TypeCena = 0;
        public static bool KTOPLATIT;

        public static int OgoloshkaPrice;

        public static int NumberEN;
        public static string AllTime;
        public rmo()
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

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rmo_Load(object sender, EventArgs e)
        {
            this.poslugiTableAdapter.Fill(this._1DataSet.poslugi);
            this.pakuvTableAdapter.Fill(this._1DataSet.pakuv);

           
            DateTime date23 = new DateTime();
            date23 = DateTime.Now;
            AllTime = date23.ToLongDateString().ToString();
            label3.Text = date23.ToShortDateString().ToString();
            label4.Text = date23.ToShortTimeString().ToString();
            DATESTVORENYA = date23.ToShortDateString().ToString(); 
            TIMESTVORENYA = date23.ToShortTimeString().ToString(); 
            DATEPRIEZDA = date23.AddHours(16).ToString();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            upakG = 0;
            switch (comboBox1.SelectedIndex)
            {
                case 0: upakG = 0; break;
                case 1: upakG = 100; break;
                case 2: upakG = 80; break;
                case 3: upakG = 60; break;
                case 4: upakG = 150; break;
                case 5: upakG = 200; break;
                case 6: upakG = 350; break;
                case 7: upakG = 25; break;
                case 8: upakG = 70; break;
                case 9: upakG = 130; break;
                case 10: upakG = 25; break;
                case 11: upakG = 8; break;
                case 12: upakG = 10; break;
                case 13: upakG = 10; break;
                case 14: upakG = 15; break;
                case 15: upakG = 30; break;
                case 17: upakG = 40; break;
                case 18: upakG = 40; break;
                case 19: upakG = 50; break;
                case 20: upakG = 50; break;
                case 21: upakG = 18; break;
                case 22: upakG = 25; break;
                case 23: upakG = 5; break;
                case 24: upakG = 200; break;
            }
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
               poslugG = 0;
            switch (comboBox2.SelectedIndex)
            {
                case 0: poslugG = 0; break;
                case 1: poslugG = 100; break;
                case 2: poslugG = 60; break;
                case 3: poslugG = 120; break;
                case 4: poslugG = 30; break;
                case 5: poslugG = 30; break;
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Vidpravlenya vdpr = new Vidpravlenya();
            vdpr.NameOperator = Form1.OperKod;
            vdpr.PhoneVidpravnika = textBox1.Text;
            vdpr.PhoneOtrimuvacha = textBox9.Text;
            vdpr.NameVidpravnika = textBox2.Text;
            vdpr.NameOtrimuvacha = textBox10.Text;
            vdpr.ViddilenyaVidpravnika = Form1.OperVidd;
            vdpr.ViddilenyaOtrimuvacha = Int32.Parse(textBox12.Text);

            vdpr.TypeVidpravlenya = TYPEVIDPRAVLENYA;

            vdpr.VesVidpravlenya = VESVIDPRAVLENYA; 
            vdpr.ObjemVidpravlenya = OBJEMVIDPRAVLENYA;


            vdpr.OpisVidpravlenya = textBox3.Text;
            vdpr.OgoloshVartist = Int32.Parse(textBox4.Text);

            

            vdpr.Upakovka = 1+comboBox1.SelectedIndex;
            vdpr.DopUslugi = 1+comboBox2.SelectedIndex;     

            vdpr.DateStvorenya = DATESTVORENYA;   
            vdpr.TimeStvorenya = TIMESTVORENYA;   
            vdpr.DatePriezda = DATEPRIEZDA;   

            vdpr.GdeOtbito = Form1.OperGorod;   

            vdpr.CityVidpravnika = Form1.OperGorod;
            vdpr.CityOtrimuvacha = textBox11.Text;

            

            
            vdpr.KtoPlatit = KTOPLATIT;

          
            vdpr.Oplacheno = OPLACHENO;//dodav v vizit

            vdpr.VidpravlenyaPrice = VIDPRAVLENYAPRICE;
            

            vdpr.ENalojka = false; // last  
            vdpr.PriceNalojka = 0; // last


            vdpr.Vidp_zakrit = false;// dobav v vizit




            string sql = "INSERT INTO [vidprav] ( [vidp_name_operator] ,[vidp_phone_vidprav], [vidp_phone_otrim], [vidp_name_vidprav], [vidp_name_otrim], [vidp_vidd_vidprav], [vidp_vidd_otrim], [vidp_type], [vidp_ves], [vidp_opis], [vidp_ocenka], [vidp_splachue], [vidp_price], [vidp_oplacheno], [vidp_dop_poslug], [vidp_pakuv], [vidp_date_stvorenya], [vidp_time_stvorenya], [vidp_date_priezd], [vidp_otbito], [vidp_city_vidprav], [vidp_city_otrim], [vidp_massa], [vidp_nalojka], [vidp_price_nalojka], [vidp_zakrito] ) VALUES ( " + vdpr.NameOperator + " , '" + vdpr.PhoneVidpravnika + "' , '" + vdpr.PhoneOtrimuvacha + "' , '" + vdpr.NameVidpravnika + "' , '" + vdpr.NameOtrimuvacha + "' , " + vdpr.ViddilenyaVidpravnika + " , " + vdpr.ViddilenyaOtrimuvacha + " , " + vdpr.TypeVidpravlenya + " , " + vdpr.VesVidpravlenya + " , '" + vdpr.OpisVidpravlenya + "' , " + vdpr.OgoloshVartist + " , " + vdpr.KtoPlatit + " , " + vdpr.VidpravlenyaPrice + " , " + vdpr.Oplacheno + " , " + vdpr.DopUslugi + " , " + vdpr.Upakovka + " , '" + vdpr.DateStvorenya + "' , '" + vdpr.TimeStvorenya + "' , '" + vdpr.DatePriezda + "' , '" + vdpr.GdeOtbito + "' , '" + vdpr.CityVidpravnika + "' , '" + vdpr.CityOtrimuvacha + "' , " + vdpr.ObjemVidpravlenya + " , " + vdpr.ENalojka + " , " + vdpr.PriceNalojka + " , " + vdpr.Vidp_zakrit + " )";
            OleDbCommand myCommand = new OleDbCommand(sql, connection);

            myCommand.ExecuteNonQuery();


            string sql2 = "SELECT vidprav.kod_vidp FROM vidprav WHERE vidprav.vidp_name_vidprav = '" + vdpr.NameVidpravnika + "'  AND vidprav.vidp_name_otrim = '"+ vdpr.NameOtrimuvacha + "' AND vidprav.vidp_date_stvorenya = '"+ vdpr.DateStvorenya + "'  AND vidprav.vidp_time_stvorenya =  '"+ vdpr.TimeStvorenya + "'";

            OleDbCommand myCommand2 = new OleDbCommand(sql2, connection);
            OleDbDataReader reader2 = myCommand2.ExecuteReader();

            while (reader2.Read())
            {
                NumberEN = Int32.Parse(reader2[0].ToString());
               
            }
            reader2.Close();

            
            DialogResult dialogResult = MessageBox.Show("Данні введено вірно?" + "\n\n" , " Підтвердження", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                EN Eee = new EN();                
                Eee.label1.Text = Eee.label1.Text+" "+ NumberEN.ToString();               
                Eee.label2.Text = Eee.label2.Text + " " + vdpr.DateStvorenya;
                Eee.label3.Text = Eee.label3.Text + " " + vdpr.DatePriezda;

                Eee.label5.Text = vdpr.NameVidpravnika;
                Eee.label6.Text = vdpr.CityVidpravnika;
                Eee.label8.Text = vdpr.PhoneVidpravnika;

                Eee.label10.Text = vdpr.NameOtrimuvacha;
                Eee.label11.Text = vdpr.CityOtrimuvacha;
                Eee.label13.Text = vdpr.PhoneOtrimuvacha;

                if (vdpr.TypeVidpravlenya == true)
                {
                    Eee.label14.Text = Eee.label14.Text+" ВАНТАЖ";
                }
                else
                {
                    Eee.label14.Text = Eee.label14.Text + " ПОСИЛКА";
                }

                Eee.label15.Text = Eee.label15.Text + " "+ vdpr.VesVidpravlenya.ToString()+" ОБ'ЄМ: "+ vdpr.ObjemVidpravlenya.ToString();
                Eee.label17.Text = Eee.label17.Text + " " + vdpr.OpisVidpravlenya;

                Eee.label18.Text = Eee.label18.Text + " " + vdpr.OgoloshVartist.ToString();

                if (vdpr.KtoPlatit == true)
                {
                    Eee.label19.Text = Eee.label19.Text + " ОТРИМУВАЧ";
                }
                else
                {
                    Eee.label19.Text = Eee.label19.Text + " ВІДПРАВНИК";
                }
                Eee.label20.Text = Eee.label20.Text + " " + vdpr.VidpravlenyaPrice.ToString() + " ₴";
                Eee.label22.Text = Form1.OperName;

                Eee.label23.Text = AllTime;




                Eee.Show();
            }
            else if (dialogResult == DialogResult.Cancel)
            {
                //do something else
            }

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            Xo = Int32.Parse(textBox6.Text);
            Yo = Int32.Parse(textBox7.Text);
            Zo = Int32.Parse(textBox8.Text);

            OBJEMVIDPRAVLENYA = (Xo * Yo * Zo) / 4000;
            label23.Text = OBJEMVIDPRAVLENYA.ToString();

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            Xo = Int32.Parse(textBox6.Text);
            Yo = Int32.Parse(textBox7.Text);
            Zo = Int32.Parse(textBox8.Text);

            OBJEMVIDPRAVLENYA = (Xo * Yo * Zo) / 4000;
            label23.Text = OBJEMVIDPRAVLENYA.ToString();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            Xo = Int32.Parse(textBox6.Text);
            Yo = Int32.Parse(textBox7.Text);
            Zo = Int32.Parse(textBox8.Text);

            OBJEMVIDPRAVLENYA = (Xo * Yo * Zo) / 4000;
            label23.Text = OBJEMVIDPRAVLENYA.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                OPLACHENO = true;
                label18.Text = "Вартість послуг: 0 ₴";
                VIDPRAVLENYAPRICE = 0;
            }
                
            
            oplata opp = new oplata();
            opp.Show();
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                KTOPLATIT = true;
                VESVIDPRAVLENYA = Int32.Parse(textBox5.Text);

                if (OBJEMVIDPRAVLENYA > VESVIDPRAVLENYA)
                {
                    KGPrice = OBJEMVIDPRAVLENYA;
                }
                else
                {
                    KGPrice = VESVIDPRAVLENYA;
                }
               
                if ((VESVIDPRAVLENYA > 30) || (OBJEMVIDPRAVLENYA > 30))
                {
                    TYPEVIDPRAVLENYA = true;
                    TypeCena = 200;
                }

                VIDPRAVLENYAPRICE = BasePrice+ OgoloshkaPrice+ KGPrice + TypeCena + poslugG + upakG;
                label18.Text = "Вартість послуг: " + VIDPRAVLENYAPRICE.ToString() + " ₴";

                
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                KTOPLATIT = false;
                VESVIDPRAVLENYA = Int32.Parse(textBox5.Text);

                if (OBJEMVIDPRAVLENYA > VESVIDPRAVLENYA)
                {
                    KGPrice = OBJEMVIDPRAVLENYA;
                }
                else
                {
                    KGPrice = VESVIDPRAVLENYA;
                }
               
                if ((VESVIDPRAVLENYA > 30) || (OBJEMVIDPRAVLENYA > 30))
                {
                    TYPEVIDPRAVLENYA = true;
                    TypeCena = 200;
                }

                VIDPRAVLENYAPRICE = BasePrice+ OgoloshkaPrice+ KGPrice + TypeCena + poslugG + upakG;
                label18.Text = "Вартість послуг: " + VIDPRAVLENYAPRICE.ToString() + " ₴";
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            OGOLOSHVARTIST = Int32.Parse(textBox4.Text);
            OgoloshkaPrice = OGOLOSHVARTIST/ 100;
        }
    }
}
