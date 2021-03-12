using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1_Barcode.Models
{
    public class Device
    {
        private List<Barcode> barcodingHistory;
        private static int _id;
        private int id;
        /// <summary>
        /// Консткруктор инициализации.
        /// </summary>
        public Device()
        {
            this.barcodingHistory = new List<Barcode>();
            this.id = _id;
            _id = _id + 1;
        }
        public override string ToString()
        {
            return string.Format("id: {0}, barcoded products: {1}", this.id.ToString(), this.GetStringHistory());
        }

        public void AddToHistory(Barcode barcode)
        {
            this.barcodingHistory.Add(barcode);
        }
        public string GetStringHistory()
        {
            var res = "";
            foreach (Barcode b in this.barcodingHistory)
            {
                res = res + b.ToString() + ", ";
            }
            return res;
        }
    }
}
