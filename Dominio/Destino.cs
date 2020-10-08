﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Destino
    {
        #region Variables
        private string ciudad;
        private string pais;
        private int cantidadDias;
        private double costoActualDiario;
        
        #endregion

        #region Constructor
        public Destino(string ciudad, string pais, int cantidadDias, double costoActualDiario)
        {
            this.ciudad = ciudad;
            this.pais = pais;
            this.cantidadDias = cantidadDias;
            this.costoActualDiario = costoActualDiario;
        }
        #endregion

        #region Propiedades
        public string Ciudad
        {
            get { return ciudad; }
            set { ciudad = value; }
        }


        public string Pais
        {
            get { return pais; }
            set { pais = value; }
        }


        public int CantidadDias
        {
            get { return cantidadDias; }
            set { cantidadDias = value; }
        }


        public double CostoActualDiario
        {
            get { return costoActualDiario; }
            set { costoActualDiario = value; }
        }
        #endregion


        //public void IngresarDestino(List<Object> unaListaDeDestinos)
        //{
        //    if(this.pais.Length>=3 && this.ciudad.Length >= 3 && this.cantidadDias>0 && this.costoActualDiario > 0)
        //    {
        //        unaListaDeDestinos.Add(this);
        //    }
              
        //}

        //public void AgregarDestino(Destino unDestino, List<Object> unaListaDeDestinos)
        //{
        //    if (unDestino.pais.Length >= 3 && unDestino.ciudad.Length >= 3 && unDestino.cantidadDias > 0 && unDestino.CostoActualDiario > 0)
        //    {
        //        unaListaDeDestinos.Add(unDestino);
        //    }
        //}
         //agrego un comentario
         //comentario en rama alternativa

        #region Equals y ToString
        public override bool Equals(object obj)
        {
            if(obj == null || !(obj is Destino))
            {
                return false;
            }
            else
            {
                
                return this.ciudad == ((Destino)obj).Ciudad && this.Pais == ((Destino)obj).Pais;
            }
  
        }

        
        public override string ToString()
        {
            
            
            //falta agregar la cotizacion del dolar en algun lado y poner la variable aca al final
            return $"Ciudad: {ciudad}, Pais: {pais}, Cantidad de dias: {cantidadDias}, " +
                $"Costo actual diario: {CostoActualDiario}, Costo por persona(dolares): {cantidadDias*CostoActualDiario}, " +
                $"Costo por persona(pesos): {cantidadDias * CostoActualDiario * Sistema.CotizacionDolar}"; 
        }
        #endregion
    }
}


