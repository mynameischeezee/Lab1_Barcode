using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1_Barcode.Models
{
    public class Server
    {

        private List<Device> devices;
        private List<Barcode> barcodes;
        public Server()
        {
            this.barcodes = new List<Barcode>();
            this.devices = new List<Device>();
        }

        public override string ToString()
        {
            return string.Format("total count of:\ndevices: {0}, barcodes: {1}\n{2}",
                this.devices.Count.ToString(), this.barcodes.Count.ToString(), this.GetStringInfo());
        }
        public void AddBarcode(Barcode barcode)
        {
            this.barcodes.Add(barcode);
        }
        public void AddDevice(Device device)
        {
            this.devices.Add(device);
        }
        public string GetStringInfo()
        {
            var res = "";
            foreach (Device d in this.devices)
            {
                res = res + d.ToString() + Environment.NewLine;
            }
            return res;
        }
    }
}
