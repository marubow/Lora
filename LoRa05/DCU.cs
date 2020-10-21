using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoRa05
{
    class DCU
    {
        public const int Row_layer = 50;
        public const int Columns_Layer = 20;
        public const int Row_copy_Node = Row_layer;
        public const int Columns_copy_Node = 6;
        public int Size;
        public static int Size_network;
        int Number_Node_want_to_creat_copy;
        public static int DCU_Serial = 1234567890;
        public static string[,] Copy_all_node_and_move_into_buffer = new string[Row_copy_Node, Columns_copy_Node];
        public static string[,] Node_called_by_name_Layer01 = new string[Row_layer, Columns_Layer];
        public static string[,] Node_called_by_name_Layer02 = new string[Row_layer, Columns_Layer];
        public static string[,] Node_called_by_name_Layer03 = new string[Row_layer, Columns_Layer];
        public static string[,] Node_called_by_name_Layer04 = new string[Row_layer, Columns_Layer];
        public static int counter_layer01;
        public static int counter_layer02;
        public static int counter_layer03;
        public static int counter_layer04;       
    }
}

