using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizEsparsa
{
    class Celula
    {
        private double valor;
        private int linha, coluna;
        private Celula direita, abaixo;

        public Celula(double valor, int linha, int coluna, Celula direita, Celula abaixo)
        {
            this.valor   = valor;
            this.linha   = linha;
            this.coluna  = coluna;
            this.direita = direita;
            this.abaixo  = abaixo;
            
        }

        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public int Linha
        {
            get { return linha; }
            set { linha = value; }
        }

        public int Coluna
        {
            get { return coluna; }
            set { coluna = value; }
        }

        public Celula Direita
        {
            get { return direita; }
            set { direita = value; }
        }

        public Celula Abaixo
        {
            get { return abaixo; }
            set { abaixo = value; }
        }

        public override string ToString()
        {
            String ret = "(";
            if (this.valor == null)
                this.valor = 0;

            ret += this.Valor + ";" + this.Linha + ";" + this.Coluna;

            return ret + ")";
        }
    }

    
}
