using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoRa05
{
    class Meter
    {
        public int Serial_Node;
        public int RSSI_Node;
        public string Product;
        public string Type_meter;
        public void setSerial_Node(int x)
        {
            Serial_Node = x;
        }
        public int getSerial_Node()
        {
            return Serial_Node;
        }
        public void setRSSI_Node(int x)
        {
            RSSI_Node = x;
        }
        public int getRSSI_Node()
        {
            return RSSI_Node;
        }
        public void setProduct_Node(string x)
        {
            Product = x;
        }
        public string getProduct_Node()
        {
            return Product;
        }
        public void setTypeMeter_Node(string x)
        {
            Type_meter = x;
        }
        public string getTypeMeter_Node()
        {
            return Type_meter;
        }
        public Meter(int Serial, int RSSI, string product, string Type)
        {
            this.Serial_Node = Serial;
            this.RSSI_Node = RSSI;
            this.Product = product;
            this.Type_meter = Type;
        }
    }
}
