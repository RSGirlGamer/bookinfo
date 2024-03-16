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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtBPw.UseSystemPasswordChar = false;
            }
            else
            {
                txtBPw.UseSystemPasswordChar = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtBUsername.Text;
            string pw = txtBPw.Text;
            int index = getData(user, pw);
            
            if (index>-1)
            {
                //Para pasar informacion de este form al  otro
                Session.user = user;
                Session.prefs = cat(index);
                Session.name = name(index); 
                Bienvenida bienvenida = new Bienvenida();
                bienvenida.Show();
                this.Hide();
            }


        }

        public int getData(string user, string pw)
        {
            var usuarios = LoginInfo.DefinePersonas();

            int indice =-1;

            foreach (var usuario in usuarios)
            {
                if (usuario.Username == user && usuario.Password == pw)
                {
                    MessageBox.Show("Usuario validado con éxito", "Inicio de Sesion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    indice = usuarios.IndexOf(usuario);
                    break;


                }

            }
            if (indice == -1)
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Inicio de Sesión", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            } 
            return indice;

        }
        public string cat(int index)
        {
            string myCat;
            var usuarios = LoginInfo.DefinePersonas();
            myCat = usuarios.ElementAt(index).Preferencia;

            return myCat;
        }
        public string name(int index)
        {
            string fullName;
            var usuarios = LoginInfo.DefinePersonas();
            fullName = usuarios.ElementAt(index).Nombre +" "+ usuarios.ElementAt(index).Apellido;

            return fullName;
        }

    }
}
