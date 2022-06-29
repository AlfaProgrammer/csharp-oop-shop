using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop.Shop
{
    public class Product
    {
        public Product(string name, string description, double price) {
            this.name = name;
            this.description = description;
            this._price = price;
            //assegnazione index al code dell'istanza
            this._code = _codeIndex;
            // incremento index statico
            _codeIndex++;
        }

        private static int _codeIndex = 0; // è un index di riferimento che deve stare solo nella classe 
        private int _code;
        public string name;
        public string description;
        private double _price;
        private double _vat = 20;

        public double Price {
            get { return this._price; }
            set { this._price = value; }
        }

        public double Vat { 
            get { return this._vat; }
            set { this._vat = value; }
        }

        public int Code {
            get { return this._code; }
        }

        public static int CodeIndex {
            get { return Product._codeIndex; }
        }

        public double getPriceWithVat() { 
            return Math.Round(this._price + (this._price * this._vat / 100), 2);
        }

        public string getFullName() { 
            return this.name + " " + this._code.ToString();
        }

        //BONUS
        public string fmtCode() { 
            string format = "00000000";
            return this._code.ToString(format);
        }
    }
}
