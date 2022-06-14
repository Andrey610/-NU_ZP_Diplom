using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDiplom
{
    public class Vidpravlenya
    {
        private int vidpravKod;
        private int nameOperator;

        private string phoneVidpravnika;
        private string phoneOtrimuvacha;

        private string nameVidpravnika;
        private string nameOtrimuvacha;

        private int viddilenyaVidpravnika;
        private int viddilenyaOtrimuvacha;

        private bool typeVidpravlenya;

        private int vesVidpravlenya;
        private int objemVidpravlenya;

        private string opisVidpravlenya;

        private int ogoloshVartist;

        private bool ktoPlatit;
        private bool oplacheno;

        private int vidpravlenyaPrice;

        private int dopUslugi;

        private int upakovka;

        private string dateStvorenya;
        private string timeStvorenya;
        private string datePriezda;


        private string gdeOtbito;

        private string cityVidpravnika;
        private string cityOtrimuvacha;

        private bool eNalojka;
        private int priceNalojka;

        private bool vidp_zakrit;

        public int VidpravKod
        {
            get => vidpravKod;
            set => vidpravKod = value;
        }
        public int NameOperator
        {
            get => nameOperator;
            set => nameOperator = value;
        }

        public string PhoneVidpravnika
        {
            get => phoneVidpravnika;
            set => phoneVidpravnika = value;
        }
        public string PhoneOtrimuvacha
        {
            get => phoneOtrimuvacha;
            set => phoneOtrimuvacha = value;
        }
        public string NameVidpravnika
        {
            get => nameVidpravnika;
            set => nameVidpravnika = value;
        }
        public string NameOtrimuvacha
        {
            get => nameOtrimuvacha;
            set => nameOtrimuvacha = value;
        }
        public int ViddilenyaVidpravnika
        {
            get => viddilenyaVidpravnika;
            set => viddilenyaVidpravnika = value;
        }
        public int ViddilenyaOtrimuvacha
        {
            get => viddilenyaOtrimuvacha;
            set => viddilenyaOtrimuvacha = value;
        }
        public bool TypeVidpravlenya
        {
            get => typeVidpravlenya;
            set => typeVidpravlenya = value;
        }
        public int VesVidpravlenya
        {
            get => vesVidpravlenya;
            set => vesVidpravlenya = value;
        }
        public int ObjemVidpravlenya
        {
            get => objemVidpravlenya;
            set => objemVidpravlenya = value;
        }
        public string OpisVidpravlenya
        {
            get => opisVidpravlenya;
            set => opisVidpravlenya = value;
        }
        public int OgoloshVartist
        {
            get => ogoloshVartist;
            set => ogoloshVartist = value;
        }
        public bool KtoPlatit
        {
            get => ktoPlatit;
            set => ktoPlatit = value;
        }
        public bool Oplacheno
        {
            get => oplacheno;
            set => oplacheno = value;

        }
        public int VidpravlenyaPrice
        {
            get => vidpravlenyaPrice;
            set => vidpravlenyaPrice = value;

        }
        public int DopUslugi
        {
            get => dopUslugi;
            set => dopUslugi = value;

        }
        public int Upakovka
        {
            get => upakovka;
            set => upakovka = value;

        }
        public string DateStvorenya
        {
            get => dateStvorenya;
            set => dateStvorenya = value;

        }
        public string TimeStvorenya
        {
            get => timeStvorenya;
            set => timeStvorenya = value;


        }
        public string DatePriezda
        {
            get => datePriezda;
            set => datePriezda = value;

        }
        public string GdeOtbito
        {
            get => gdeOtbito;
            set => gdeOtbito = value;

        }
        public string CityVidpravnika
        {
            get => cityVidpravnika;
            set => cityVidpravnika = value;

        }
        public string CityOtrimuvacha
        {
            get => cityOtrimuvacha;
            set => cityOtrimuvacha = value;

        }
        public bool ENalojka
        {
            get => eNalojka;
            set => eNalojka = value;

        }
        public int PriceNalojka
        {
            get => priceNalojka;
            set => priceNalojka = value;

        }       
            public bool Vidp_zakrit
        {
            get => vidp_zakrit;
            set => vidp_zakrit = value;

        }

    }
}
