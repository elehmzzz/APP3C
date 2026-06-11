using PryCafeteria.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP3C.Cafeteria
{
    internal class BebidaEnergetica:Bebida
    {
        //atributos
        private float cantAzucar;
        public float cantTaurina;

        //propiedades
        public float _cantidadAzucar {
            get { return cantAzucar; }
            set { cantAzucar = value; }
        }
        public float _contieneTaurina {
            get { return cantTaurina; }
            set { cantTaurina = value; }
        }
        //constructor parametrizado
        public BebidaEnergetica(string nombreBebida, string tamanio, float precio, float cantAzucar, float cantTaurina ):base(nombreBebida, tamanio, precio) {
            this.cantAzucar = cantAzucar;
            this.cantTaurina = cantTaurina;
        }
        //metodo
        public override string listar() 
        {
            return $"Un/a {nombreBebida} Energética";
        }

    }
}
