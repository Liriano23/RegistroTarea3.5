using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using RegistroInscripcion.Entidades;
using RegistroInscripcion.BLL;

namespace RegistroInscripcion.UI.Consultas
{
    /// <summary>
    /// Interaction logic for FormConsultaEstudiante.xaml
    /// </summary>
    public partial class FormConsultaEstudiante : Window
    {
        public FormConsultaEstudiante()
        {
            InitializeComponent();
        }

        private void ButtonConsultar_Click(object sender, RoutedEventArgs e)
        {
            var listado = new List<Estudiantes>();
            if (TextBoxCriterio.Text.Trim().Length > 0)
            {
                switch (FiltrarComboBox.SelectedIndex)
                {
                    case 0: //TODO
                        listado = EstudiantesBLL.GetList(p => true);
                        break;

                    case 1: //ID
                        int id = int.Parse(TextBoxCriterio.Text);
                        listado = EstudiantesBLL.GetList(p => p.EstudianteId == id);
                        break;

                    case 2:
                        listado = EstudiantesBLL.GetList(p => p.Nombre.Contains(TextBoxCriterio.Text));
                        break;

                    case 3:
                        decimal balance = decimal.Parse(TextBoxCriterio.Text);
                        listado = EstudiantesBLL.GetList(p => p.Balance == balance);
                        break;
                }
            }
            else
            {
                listado = EstudiantesBLL.GetList(p => true);
            }
            ConsultaDataGridView.ItemsSource = null;
            ConsultaDataGridView.ItemsSource = listado;

        }
    }
}
