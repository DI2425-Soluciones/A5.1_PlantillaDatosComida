using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comida
{
    class Plato : INotifyPropertyChanged
    {
        private string _nombre;
        public string Nombre
        {
            get => _nombre;
            set
            {
                _nombre = value;
                NotifyPropertyChanged("Nombre");
            }
        }

        private string _imagen;
        public string Imagen
        {
            get => _imagen;
            set
            {
                _imagen = value;
                NotifyPropertyChanged("Imagen");
            }
        }
        private string _tipo;
        public string Tipo
        {
            get => _tipo;
            set
            {
                _tipo = value;
                NotifyPropertyChanged("Tipo");
            }
        }
        private bool _gluten;
        public bool Gluten
        {
            get => _gluten;
            set
            {
                _gluten = value;
                NotifyPropertyChanged("Gluten");
            }
        }

        private bool _soja;
        public bool Soja
        {
            get => _soja;
            set
            {
                _soja = value;
                NotifyPropertyChanged("Soja");
            }
        }

        private bool _leche;
        public bool Leche
        {
            get => _leche;
            set
            {
                _leche = value;
                NotifyPropertyChanged("Leche");
            }
        }

        private bool _sulfitos;
        public bool Sulfitos
        {
            get => _sulfitos;
            set
            {
                _sulfitos = value;
                NotifyPropertyChanged("Sulfitos");
            }
        }

        public Plato(string nombre, string imagen, string tipo, bool gluten, bool soja, bool leche, bool sulfitos)
        {
            Nombre = nombre;
            Imagen = imagen;
            Tipo = tipo;
            Gluten = gluten;
            Soja = soja;
            Leche = leche;
            Sulfitos = sulfitos;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
