using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeDS6
{
    class Caminhao : Veiculo
    {
        //Atributos
        private int numeroEixos;
        private double pesoMaxCarga;
        private double distEntreEixos;

        //Construtores SEM parametros
        public Caminhao() : base ()
        {
            this.numeroEixos = 0;
            this.pesoMaxCarga = 0.0;
            this.distEntreEixos = 0.0;
        }

        //Construtores COM paramentros
        public Caminhao(string modelo, string fabricante, int ano, string cor, int numeroPortas, string placa, int numeroEixos, double pesoMaxCarga, double distEntreEixos) 
            : base (modelo, fabricante, ano, cor, numeroPortas, placa)
        {
            this.numeroEixos = numeroEixos;
            this.pesoMaxCarga = pesoMaxCarga;
            this.distEntreEixos = distEntreEixos;
        }

        //GET SET
        public int getsetNumeroEixos
        {
            get { return numeroEixos; }
            set { numeroEixos = value; }
        }

        public double getsetPesoMaxCarga
        {
            get { return pesoMaxCarga; }
            set { pesoMaxCarga = value; }
        }

        public double getsetDistEntreEixos
        {
            get { return distEntreEixos; }
            set { distEntreEixos = value; }
        }
    }
}
