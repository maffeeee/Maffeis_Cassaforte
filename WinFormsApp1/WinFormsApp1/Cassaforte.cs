using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Cassaforte
    { 
        private string matricola;
        private string produttore;
        private string modello;
        private string codiceSbloccoU;
        private bool stato;
        private bool bloccato;
        private string cUtente;
        private int provaSblocco;
        public string Matricola
        {
            get { return matricola; }
        }
        public string Produttore
        {
            get { return produttore; }
        }
        public string Modello
        {
            get { return modello; }
        }
        private string codiceSbloccoU;
        public string CodiceSbloccoU
        {
            get { return codiceSbloccoU; }
        }
        public bool Stato
        {
            get { return stato; }
            set { stato = value; }
        }
        public bool Bloccato
        {
            get { return bloccato; }
            set { bloccato = value; }
        }
        public string Cutente
        {
            get { return cUtente; }
        }
        public int Provasblocco
        {
            get { return provaSblocco; }
            set { provaSblocco = value; }
        }


        public Cassaforte(string matricola, string produttore, string modello, string codiceSbloccou)
        {
            this.matricola = matricola;
            this.produttore = produttore;
            this.modello = modello;
            if (codiceSbloccoU.Length != 12)
                return;
            else
                this.codiceSbloccoU = codiceSbloccou;
            this.stato = false;
            this.bloccato = false;
        }

        public void ImpostaCodiceU(string codice)
        {
            if (codice.Length != 5)
                return;
            else
                cUtente = codice;
        }

        public void CassaforteAperta(string codice)
        {
            if (bloccato == true)
                return;
            if (codice != cUtente)
            {
                provaSblocco++;
                if (provaSblocco == 4)
                   bloccato = true;
                return;
            }
            Stato = true;
        }

        public void ChiudiCassaforte()
        {
            Stato = false;
        }

        public void SbloccaCassaforte(string codice)
        {
            if (codice != codiceSbloccoU)
                return;
            bloccato = false;
            provaSblocco = 0;
            Stato = true;
        }
    }

}
