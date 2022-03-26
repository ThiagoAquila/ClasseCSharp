using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeDS6
{
    class Carro : Veiculo
    {
        //Atributos
        private int capPortaMala;
        private bool bagageiro;
        private bool estepe;

        //Construtores SEM parametro
        public Carro() : base()
        {
            this.capPortaMala = 0;
            this.bagageiro = false;
            this.estepe = false;
        }

        //Construtores COM parametro
        public Carro(string modelo, string fabricante, int ano, string cor, int numeroPortas, string placa, int capPortaMala, bool bagageiro, bool estepe) 
            : base(modelo, fabricante, ano, cor, numeroPortas, placa)
        {
            this.estepe = estepe;
            this.capPortaMala = capPortaMala;
            this.bagageiro = bagageiro;
        }

        //GET SET
        public int getsetCapPortaMala
        {
            get { return capPortaMala; }
            set { capPortaMala = value; }
        }

        public bool getsetBagageiro
        {
            get { return bagageiro; }
            set { bagageiro = value; }
        }

        public bool getsetEstepe
        {
            get { return estepe; }
            set { estepe = value; }
        }
    }
}
