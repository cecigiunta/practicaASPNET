using Antlr.Runtime.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrimerWebASP
{
    public class Auto
    {
        public int Id { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public bool Usado { get; set; }

    }


    public class AutoNegocio
    {
        public List<Auto> listar()
        {
            List<Auto> lista = new List<Auto>();
            lista.Add(new Auto());
            lista.Add(new Auto());

            lista[0].Id = 1;
            lista[0].Modelo = "Gol";
            lista[0].Color = "Rojo";
            lista[0].Usado = true;

            lista[0].Id = 2;
            lista[0].Modelo = "Vento";
            lista[0].Color = "gris";
            lista[0].Usado = true;

            return lista;
        }



    }
}