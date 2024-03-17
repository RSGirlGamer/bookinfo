using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Proyecto___DAS
{

    public partial class Form1 : Form
    {
        Chart dChart = new Chart();
        public Form1()
        {
            InitializeComponent();
            //  var usuarios = LoginInfo.DefinePersonas();
            dChart.Parent = graficos;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblName.Text = Session.name;
            lbluser.Text = Session.user;


        }

        private void tbControl_SelectdIndx(object sender, EventArgs e)
        { 
            int tab = tabControl1.SelectedIndex;
            Console.WriteLine(tab);

            switch (tab)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    GetPrefData(dChart);
                    break;
                    

                default:
                    break;
            }
        }
        public static void GetPrefData(Chart dChart)
        {
            string prefs;
            prefs = Session.prefs;
           
            Console.WriteLine(prefs);

            switch (prefs)
            {
                
                case "Lenguajes de Programación":
                    List <Lenguajes> dataL =  datos.DefineLanguages();
                    ShowPieChart(dChart, dataL);

                    break;
                case "Libros":
                    List<Libros> dataB = datos.DefineBooks();
                    ShowPieChart(dChart, dataB);
                    break;
                case "Programas de Entretenimiento":
                    List<Programas> dataP = datos.Defineprogramas();
                    ShowPieChart(dChart, dataP);

                    break;
                default:
                    break;
            }
        }
        static void ShowPieChart(Chart chart, IEnumerable<object> data)
        {
            chart.Series.Clear();
            Series series = chart.Series.Add("Porcentajes");
            series.ChartType = SeriesChartType.Doughnut;
            Console.WriteLine(series.ChartType.ToString());

            foreach (var item in data)
            {
                var propertyName = item.GetType().GetProperty("Nombre");
                var propertyperc = item.GetType().GetProperty("percent");
                Console.WriteLine(propertyName);
                Console.WriteLine(propertyperc);
                Console.WriteLine(propertyperc == null);
                Console.WriteLine(propertyName == null);
                if (propertyName!= null && propertyperc!= null)
                {
                    string nombre = propertyName.GetValue(item)?.ToString();
                    int percent = Convert.ToInt32(propertyperc.GetValue(item));
                    Console.WriteLine(nombre+" "+percent);
                    chart.Series[0].Points.AddXY(nombre, percent);        
                }
            }
            chart.Update();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }

}
