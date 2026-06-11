using PryCafeteria.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP3C.Cafeteria
{
    internal class BebidaAlcoholica: Bebida
    {
        //atributos
        private float gradosAlcohol;
        private int tiempoAniejamiento; 

        //propiedades
        public float _gradosAlcohol 
        {
            get {  return gradosAlcohol; } 
            set { gradosAlcohol = value; }
        }
        public int _tiempoAniejamiento 
        {
            get { return tiempoAniejamiento; }
            set { tiempoAniejamiento = value; }
        }

        //constructor parametrizado
        public BebidaAlcoholica(string nombreBebida, string tamanio, float precio, float gradosAlcohol, int tiempoAniejamiento) : base(nombreBebida, tamanio, precio) {
            this.gradosAlcohol = gradosAlcohol;
            this.tiempoAniejamiento = tiempoAniejamiento;
        }
        //metodo
        public override string listar()
        {
            return $"Un/a {nombreBebida} Alcoholica";
        }

    }
}
