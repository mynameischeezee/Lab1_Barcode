using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1_Barcode.Models
{
    public class Barcode
    {
        static int _id = 0;
        private string code;
        private string name;
        private int id;
        /// <summary>
        /// Консткруктор инициализации.
        /// </summary>
        public Barcode(string code, string name)
        {
            this.name = name;
            this.code = code;
            this.id = _id;
            _id = _id + 1;
        }
        public override string ToString()
        {
            return string.Format("barcode: {0}, ID: {1}, name {2}", this.code, this.id.ToString(), this.name);
        }
    }
}
