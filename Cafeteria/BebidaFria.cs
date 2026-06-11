using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PryCafeteria.Clases
{
    internal class BebidaFria:Bebida
    {
        //atributos
        private float cantHielo;

        //propiedades
        public float _cantHielo
        {
            get { return cantHielo; }
            set { cantHielo = value; }
        }

        //constructor parametrizado
        public BebidaFria( string nombreBebida, string tamanio, float precio, float cantHielo): base(nombreBebida, tamanio, precio)
        {
            this.cantHielo = cantHielo;
        }

        //metodo sobreescrito (Polimorfismo)
        public override string preparar()
        {
            return $"Preparando un:{ nombreBebida} Fria con {cantHielo} cubos de hielo de tamaño: {tamanio}";
        }

        public override string listar()
        {
            return $"Un/a {nombreBebida} Fri@";
        }

    }
}
