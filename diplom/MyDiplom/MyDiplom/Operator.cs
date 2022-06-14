using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDiplom
{
    public class Operator
    {
        private int Kod_user;
        private string fullName;
        private string login;
        private string pass;
        private string position;

        private int user_vid;
        private string user_phone;

        public int kod_user
        {
            get => Kod_user;
            set => Kod_user = value;
        }
        public string FullName
        {
            get => fullName;
            set => fullName = value;
        }
        public string Login
        {
            get => login;
            set => login = value;
        }
        public string Pass
        {
            get => pass;
            set => pass = value;
        }
        public string Position
        {
            get => position;
            set => position = value;
        }
        public int User_vid
        {
            get => user_vid;
            set => user_vid = value;
        }
        public string User_phone
        {
            get => user_phone;
            set => user_phone = value;
        }
    }
}
