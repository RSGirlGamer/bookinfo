using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto___DAS
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var usuarios = LoginInfo.DefinePersonas();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tbControl_SelectdIndx(object sender, EventArgs e)
        {

        }
        static void GetPrefData(LoginInfo info)
        {
            string prefs;
            prefs = info.Preferencia;

            switch (prefs)
            {
                case "Lenguajes de Programación":
                    break;
                case "Libros":
                    break;
                case "Programas de Entretenimiento":
                    break;
                default:
                    break;
            }
        }

        
    }

}
