using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatosDeComida
{
    class MainWindowVm : INotifyPropertyChanged
    {
        private ObservableCollection<Plato> listaPlatos;

        public ObservableCollection<Plato> ListaPlatos
        {
            get { return listaPlatos; }
            set { listaPlatos = value;
                NotifyPropertyChanged("ListaPlatos");
            }
        }
        private Plato platoSeleccionado;

        public Plato PlatoSeleccionado
        {
            get { return platoSeleccionado; }
            set
            {
                platoSeleccionado = value;
                NotifyPropertyChanged("PlatoSeleccionado");
            }
        }
        private ObservableCollection<String> listaPaises;
        

        public ObservableCollection<String> ListaPaises 
        {
            get { return listaPaises; }
            set
            {
                listaPaises = value;
                NotifyPropertyChanged("ListaPaises");
            }
        }

       
        public MainWindowVm()
        {
            listaPlatos = Plato.GetSamples("./assets2/");
            listaPaises = new ObservableCollection<String>();
            ListaPaises.Add("China");
            ListaPaises.Add("Americana");
            ListaPaises.Add("Mexicana");

        }






        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
