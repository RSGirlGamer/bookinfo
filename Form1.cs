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
          //  var usuarios = LoginInfo.DefinePersonas();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblName.Text = Session.name;
            lbluser.Text = Session.user;


        }

        private void tbControl_SelectdIndx(object sender, EventArgs e)
        {

        }
        static void GetPrefData(LoginInfo info)
        {
            string prefs;
            prefs = Session.prefs;

            switch (prefs)
            {
                case "Lenguajes de Programación":
                    List <Lenguajes> data =  datos.DefineLanguages();
                    mostrarData(data);

                    break;
                case "Libros":

                    break;
                case "Programas de Entretenimiento":

                    break;
                default:
                    break;
            }
        }
        static void mostrarData(List<Lenguajes> data)
        {

        }
    }

}
