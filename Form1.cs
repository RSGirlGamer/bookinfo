using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Windows.Forms.DataVisualization.Charting;

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
            this.dataGridView1.Columns[0].HeaderText = "";
            this.dataGridView2.Columns[0].HeaderText = "";
            this.dataGridView3.Columns[0].HeaderText = "";
        }

        private void tbControl_SelectdIndx(object sender, EventArgs e)
        { 
            int tab = tabControl1.SelectedIndex;

            switch (tab)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    getPrefData(this.chart);

                    break;
                    

                default:
                    break;
            }
        }

        public void getPrefData(Chart dChart)

        {
            string prefs;
            prefs = Session.prefs;
           

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

        void initTable(DataGridView grid, int tab)
        {
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn firstColumn = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn secondColumn = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn thirdColumn = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn fourthColumn = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn fifthColumn = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn sixthColumn = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn seventhColumn = new DataGridViewTextBoxColumn();
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            imageColumn.Width = 150;
            grid.Columns.Add(imageColumn);
            grid.Columns.AddRange(new System.Windows.Forms.DataGridViewTextBoxColumn[] { nameColumn, firstColumn, secondColumn, thirdColumn, fourthColumn, fifthColumn, sixthColumn, seventhColumn });
            nameColumn.HeaderText = "Nombre";
            grid.RowTemplate.Height = 150;
            switch (Session.prefs)
            {
                case "Lenguajes de Programación":
                    setLanguageData(firstColumn, secondColumn, thirdColumn, fourthColumn, fifthColumn, sixthColumn, seventhColumn, grid, tab);
                    break;
                case "Libros":
                    setBooksData(firstColumn, secondColumn, thirdColumn, fourthColumn, fifthColumn, sixthColumn, seventhColumn, grid, tab);
                    break;
                case "Programas de Entretenimiento":
                    setProgramsData(firstColumn, secondColumn, thirdColumn, fourthColumn, fifthColumn, sixthColumn, seventhColumn, grid, tab);
                    break;
                default:
                    break;
            }
        }

        void setProgramsData(DataGridViewTextBoxColumn firstColumn, DataGridViewTextBoxColumn secondColumn,
            DataGridViewTextBoxColumn thirdColumn, DataGridViewTextBoxColumn fourthColumn,
            DataGridViewTextBoxColumn fifthColumn, DataGridViewTextBoxColumn sixthColumn,
            DataGridViewTextBoxColumn seventhColumn, DataGridView grid, int tab)
        {
            firstColumn.HeaderText = "Título en Español";
            secondColumn.HeaderText = "Creado por";
            thirdColumn.HeaderText = "Protagonistas";
            fourthColumn.HeaderText = "País de Origen";
            fifthColumn.HeaderText = "Temporadas";
            sixthColumn.HeaderText = "Episodios";
            seventhColumn.HeaderText = "Sinopsis";
            Programas program = datos.Defineprogramas()[tab - 1];
            switch (tab)
            {
                case 1:
                    this.tabPage1.Text = program.Nombre;
                    break;
                case 2:
                    this.tabPage2.Text = program.Nombre;
                    break;
                case 3:
                    this.tabPage3.Text = program.Nombre;
                    break;
                default:
                    break;
            };
            grid.Rows.Add(program.imagen, program.Nombre, program.title, program.creado, program.protas, program.origen, program.seasons, program.caps, program.sinopsis);
        }

        void setBooksData(DataGridViewTextBoxColumn firstColumn, DataGridViewTextBoxColumn secondColumn,
            DataGridViewTextBoxColumn thirdColumn, DataGridViewTextBoxColumn fourthColumn,
            DataGridViewTextBoxColumn fifthColumn, DataGridViewTextBoxColumn sixthColumn,
            DataGridViewTextBoxColumn seventhColumn, DataGridView grid, int tab)
        {
            firstColumn.HeaderText = "Autor";
            secondColumn.HeaderText = "Género";
            thirdColumn.HeaderText = "Subgénero";
            fourthColumn.HeaderText = "# páginas";
            fifthColumn.HeaderText = "Protagonistas";
            sixthColumn.HeaderText = "Antagonistas";
            seventhColumn.HeaderText = "Argumento";
            Libros book = datos.DefineBooks()[tab - 1];
            switch (tab)
            {
                case 1:
                    this.tabPage1.Text = book.Nombre;
                    break;
                case 2:
                    this.tabPage2.Text = book.Nombre;
                    break;
                case 3:
                    this.tabPage3.Text = book.Nombre;
                    break;
                default:
                    break;
            };
            grid.Rows.Add(book.imagen, book.Nombre, book.autor, book.generos, book.subs, book.pages, book.protas, book.antag, book.argumento);
        }

        void setLanguageData(DataGridViewTextBoxColumn firstColumn, DataGridViewTextBoxColumn secondColumn,
            DataGridViewTextBoxColumn thirdColumn, DataGridViewTextBoxColumn fourthColumn,
            DataGridViewTextBoxColumn fifthColumn, DataGridViewTextBoxColumn sixthColumn,
            DataGridViewTextBoxColumn seventhColumn, DataGridView grid, int tab)
        {
            firstColumn.HeaderText = "Desarrollador(es)";
            secondColumn.HeaderText = "Extensiones";
            thirdColumn.HeaderText = "Apareció en";
            fourthColumn.HeaderText = "Sistema Operativo";
            fifthColumn.HeaderText = "Paradigma";
            sixthColumn.HeaderText = "Ultima Versión Estable";
            seventhColumn.HeaderText = "Licencia";
            Lenguajes language = datos.DefineLanguages()[tab - 1];
            switch (tab)
            {
                case 1:
                    this.tabPage1.Text = language.Nombre;
                    break;
                case 2:
                    this.tabPage2.Text = language.Nombre;
                    break;
                case 3:
                    this.tabPage3.Text = language.Nombre;
                    break;
                default:
                    break;
            };
            grid.Rows.Add(language.imagen, language.Nombre, language.devs, language.exts, language.released, language.OS, language.paradigma, language.latestV, language.license);
        }
        static void ShowPieChart(Chart chart, IEnumerable<object> data)
        {
            chart.Series.Clear();
            Series series = chart.Series.Add("Porcentajes");
            series.ChartType = SeriesChartType.Doughnut;

            foreach (var item in data)
            {
                var propertyName = item.GetType().GetProperty("Nombre");
                var propertyperc = item.GetType().GetProperty("percent");
                if (propertyName!= null && propertyperc!= null)
                {
                    string nombre = propertyName.GetValue(item)?.ToString();
                    int percent = Convert.ToInt32(propertyperc.GetValue(item));
                    chart.Series[0].Points.AddXY(nombre, percent);
                    chart.Series[0].IsValueShownAsLabel = true;
                }
            }
            chart.Update();

        }


    }
}
