using PryCafeteria.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP3C.Cafeteria
{
    internal class BebidaArtesanal:Bebida
    {
        //atributos
        private string ingrediente;
        private string origen;
        
        //propiedades
        public string _ingrediente {
            get { return ingrediente; }
            set { ingrediente = value; }
        }
        public string _origen {
            get { return origen; }
            set { origen = value; }
        }
        //parametro parametrizado
        public BebidaArtesanal(string nombreBebida, string tamanio, float precio, string ingrediente, string origen):base(nombreBebida, tamanio, precio){
            this.ingrediente = ingrediente;
            this.origen = origen;
        }
        //metodo
        public override string listar() 
        {
            return $"Un/a {nombreBebida} Artesanal";
        }


    }
}
