using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoRa05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //show();
            //showshowshow();
            //test_arrangementNode();
            //Creat_random_neigbhour_Layer01();
            Setup_Network();
        }
        string[] Company = { "Gelex", "PSmart", "Vinasino", "HHC" };
        string[] Meter_type = { "1 Phase", "1 Phase Direct", "1 Phase Undirect", "3 Phase", "3 Phase Direct", "3 Phase Undirect" };
        enum Layer
        {
            Layer_01 = 1,
            Layer_02 = 2,
            Layer_03 = 3,
            Layer_04 = 4
        };
        DCU dcu = new DCU();
        Random random = new Random();
        List<Meter> List_Node = new List<Meter>();
        public void Creat_Node(int Node_want_to_creat)
        {
            DCU.Size_network = Node_want_to_creat;
            for (int i = 0; i < Node_want_to_creat; i++)
            {
                int random_company = random.Next(0, Company.Length);
                int random_typeMeter = random.Next(0, Meter_type.Length);
                Meter mETER = new Meter(random.Next(19990000, 20002222), random.Next(100, 350), Company[random_company], Meter_type[random_typeMeter]);
                List_Node.Add(mETER);
            }
            //for (int i = 0; i < Node_want_to_creat; i++)
            //{
            //    Console.WriteLine(i + " " + List_Node[i].getSerial_Node() + " " + List_Node[i].getRSSI_Node());
            //}
        }
        
        public void Arrangement_Layer()
        {
            for (int i = 0; i < DCU.Size_network; i++)
            {
                if (List_Node[i].getRSSI_Node() < 150)
                {
                    // its that mean node belong to Layer01
                    DCU.Node_called_by_name_Layer01[DCU.counter_layer01, 0] = i.ToString();
                    DCU.Node_called_by_name_Layer01[DCU.counter_layer01, 1] = List_Node[i].getSerial_Node().ToString();
                    DCU.Node_called_by_name_Layer01[DCU.counter_layer01, 2] = List_Node[i].getRSSI_Node().ToString();
                    DCU.Node_called_by_name_Layer01[DCU.counter_layer01, 3] = List_Node[i].getProduct_Node();
                    DCU.Node_called_by_name_Layer01[DCU.counter_layer01, 4] = List_Node[i].getTypeMeter_Node();
                    DCU.Node_called_by_name_Layer01[DCU.counter_layer01, 5] = Layer.Layer_01.ToString();
                    DCU.Copy_all_node_and_move_into_buffer[i, 5] = DCU.Node_called_by_name_Layer01[DCU.counter_layer01, 5];
                    for (int j = 6; j < DCU.Columns_Layer; j++)
                    {
                        DCU.Node_called_by_name_Layer01[DCU.counter_layer01, j] = " FFFF";
                    }
                    DCU.counter_layer01++;
                }
                else if ((List_Node[i].getRSSI_Node() >= 150) && (List_Node[i].getRSSI_Node() < 200))
                {
                    DCU.Node_called_by_name_Layer02[DCU.counter_layer02, 0] = i.ToString();
                    DCU.Node_called_by_name_Layer02[DCU.counter_layer02, 1] = List_Node[i].getSerial_Node().ToString();
                    DCU.Node_called_by_name_Layer02[DCU.counter_layer02, 2] = List_Node[i].getRSSI_Node().ToString();
                    DCU.Node_called_by_name_Layer02[DCU.counter_layer02, 3] = List_Node[i].getProduct_Node();
                    DCU.Node_called_by_name_Layer02[DCU.counter_layer02, 4] = List_Node[i].getTypeMeter_Node();
                    DCU.Node_called_by_name_Layer02[DCU.counter_layer02, 5] = Layer.Layer_02.ToString();
                    DCU.Copy_all_node_and_move_into_buffer[i, 5] = DCU.Node_called_by_name_Layer02[DCU.counter_layer02, 5];
                    for (int j = 6; j < DCU.Columns_Layer; j++)
                    {
                        DCU.Node_called_by_name_Layer02[DCU.counter_layer02, j] = " FFFF";
                    }
                    DCU.counter_layer02++;
                }
                else if ((List_Node[i].getRSSI_Node() >= 200) && (List_Node[i].getRSSI_Node() < 250))
                {
                    DCU.Node_called_by_name_Layer03[DCU.counter_layer03, 0] = i.ToString();
                    DCU.Node_called_by_name_Layer03[DCU.counter_layer03, 1] = List_Node[i].getSerial_Node().ToString();
                    DCU.Node_called_by_name_Layer03[DCU.counter_layer03, 2] = List_Node[i].getRSSI_Node().ToString();
                    DCU.Node_called_by_name_Layer03[DCU.counter_layer03, 3] = List_Node[i].getProduct_Node();
                    DCU.Node_called_by_name_Layer03[DCU.counter_layer03, 4] = List_Node[i].getTypeMeter_Node();
                    DCU.Node_called_by_name_Layer03[DCU.counter_layer03, 5] = Layer.Layer_03.ToString();
                    DCU.Copy_all_node_and_move_into_buffer[i, 5] = DCU.Node_called_by_name_Layer03[DCU.counter_layer03, 5];
                    for (int j = 6; j < DCU.Columns_Layer; j++)
                    {
                        DCU.Node_called_by_name_Layer03[DCU.counter_layer03, j] = " FFFF";
                    }
                    DCU.counter_layer03++;
                }
                else
                {
                    DCU.Node_called_by_name_Layer04[DCU.counter_layer04, 0] = i.ToString();
                    DCU.Node_called_by_name_Layer04[DCU.counter_layer04, 1] = List_Node[i].getSerial_Node().ToString();
                    DCU.Node_called_by_name_Layer04[DCU.counter_layer04, 2] = List_Node[i].getRSSI_Node().ToString();
                    DCU.Node_called_by_name_Layer04[DCU.counter_layer04, 3] = List_Node[i].getProduct_Node();
                    DCU.Node_called_by_name_Layer04[DCU.counter_layer04, 4] = List_Node[i].getTypeMeter_Node();
                    DCU.Node_called_by_name_Layer04[DCU.counter_layer04, 5] = Layer.Layer_04.ToString();
                    DCU.Copy_all_node_and_move_into_buffer[i, 5] = DCU.Node_called_by_name_Layer04[DCU.counter_layer04, 5];
                    for (int j = 6; j < DCU.Columns_Layer; j++)
                    {
                        DCU.Node_called_by_name_Layer04[DCU.counter_layer04, j] = " FFFF";
                    }
                    DCU.counter_layer04++;
                }
            }
        }
        public void Move_all_node_into_buffer()
        {
            for (int i = 0; i < DCU.Size_network; i++)
            {
                DCU.Copy_all_node_and_move_into_buffer[i, 0] = i.ToString();
                DCU.Copy_all_node_and_move_into_buffer[i, 1] = List_Node[i].getSerial_Node().ToString();
                DCU.Copy_all_node_and_move_into_buffer[i, 2] = List_Node[i].getRSSI_Node().ToString();
                DCU.Copy_all_node_and_move_into_buffer[i, 3] = List_Node[i].getProduct_Node();
                DCU.Copy_all_node_and_move_into_buffer[i, 4] = List_Node[i].getTypeMeter_Node();
            }
        }
        
        #region
        public void show()
        {
            Creat_Node(50);

            Arrangement_Layer();
            Console.WriteLine("--------------------LOG console----------------------");
            Arrangement_Layer();
            Move_all_node_into_buffer();

            for (int i = 0; i < DCU.counter_layer01; i++)
            {
                Console.WriteLine(DCU.Node_called_by_name_Layer01[i, 0] + " " + DCU.Node_called_by_name_Layer01[i, 1] + " " + DCU.Node_called_by_name_Layer01[i, 2] + " " + DCU.Copy_all_node_and_move_into_buffer[i, 5]);
            }
            show_bufer_test();
            test_show_layer();

        }
        public void show_bufer_test()
        {
            Console.WriteLine("______________________________________________");
            for (int i = 0; i < DCU.counter_layer01; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    Console.WriteLine(DCU.Node_called_by_name_Layer01[i, j]);
                }
            }

        }
        
        void test_show_layer()
        {
            Console.WriteLine("Test_show_Layer");
            for (int i = 0; i < DCU.Size_network; i++)
            {
                if (List_Node[i].getRSSI_Node() < 150)
                {
                    Console.WriteLine(i + " " + DCU.Copy_all_node_and_move_into_buffer[i, 0]);// + " " + DCU.Copy_all_node_and_move_into_buffer[i, 1] + " " + DCU.Copy_all_node_and_move_into_buffer[i, 2] + " " + DCU.Copy_all_node_and_move_into_buffer[i, 3] + " " + DCU.Copy_all_node_and_move_into_buffer[i, 4] + " " + DCU.Copy_all_node_and_move_into_buffer[i, 5]);
                }
            }
        }
        /// <summary>
        /// Done move all Node into buffer and arrangament each Node.
        /// </summary>
        void test_arrangementNode()
        {
            // tạo Node
            Creat_Node(50);
            // set các Node 
            // chuyển vào bufer
            Move_all_node_into_buffer(); 
            Arrangement_Layer();

            for (int i = 0; i < DCU.Size_network; i++)
            {
                Console.WriteLine(i + " " + DCU.Copy_all_node_and_move_into_buffer[i, 0] + " " + DCU.Copy_all_node_and_move_into_buffer[i, 1] + " " + DCU.Copy_all_node_and_move_into_buffer[i, 2] + " " + DCU.Copy_all_node_and_move_into_buffer[i, 3] + " " + DCU.Copy_all_node_and_move_into_buffer[i, 4] + " " + DCU.Copy_all_node_and_move_into_buffer[i, 5]);
            }
        }
        public void showshowshow()
        {
            Creat_Node(50);
            //Move_all_node_into_buffer();
            Move_all_node_into_buffer();
            //Arrangement_Layer();
            //Move_all_node_into_buffer();
            ////Arrangement_Layer();
            //test_show_layer();
            Console.WriteLine("------------------------------");
            for (int i = 0; i < DCU.Size_network; i++)
            {
                Console.WriteLine(DCU.Copy_all_node_and_move_into_buffer[i, 1]);
            }

        }
        #endregion
        /// <summary>
        /// Not check : ///?????????????????????????????????
        /// 
        /// </summary>
        /// <param name="Serial_of_Node"></param>
        public void Creat_Neigbhour(int Serial_of_Node)
        {
            // Những Node thuộc Layer01 có Neigbhour là DCU
            // Neigbhour 01 is DCU
            // Scan 4 buffer
            for (int i = 0; i < DCU.Size_network; i++)
            {
                if(string.Compare(Serial_of_Node.ToString(), DCU.Copy_all_node_and_move_into_buffer[i, 1]) == 0)
                {                    
                    if (string.Compare(DCU.Copy_all_node_and_move_into_buffer[i, 5], Layer.Layer_01.ToString()) == 0)
                     {                      
                        // process running in DCU.Node_called_by_name_Layer01
                        // start add neigbhour
                        //Start neigbhour 01
                        DCU.Node_called_by_name_Layer01[i, 6] = DCU.DCU_Serial.ToString();
                        DCU.Node_called_by_name_Layer01[i, 7] = DCU.Node_called_by_name_Layer01[random.Next(0, DCU.counter_layer01), 2];
                        DCU.Node_called_by_name_Layer01[i, 8] = DCU.Node_called_by_name_Layer01[random.Next(0, DCU.counter_layer01), 2];
                        DCU.Node_called_by_name_Layer01[i, 9] = DCU.Node_called_by_name_Layer01[random.Next(0, DCU.counter_layer01), 2];
                        DCU.Node_called_by_name_Layer01[i, 10] = DCU.Node_called_by_name_Layer01[random.Next(0, DCU.counter_layer01), 2];
                        DCU.Node_called_by_name_Layer01[i, 11] = DCU.Node_called_by_name_Layer01[random.Next(0, DCU.counter_layer01), 2];
                        DCU.Node_called_by_name_Layer01[i, 12] = DCU.Node_called_by_name_Layer01[random.Next(0, DCU.counter_layer01), 2];
                        DCU.Node_called_by_name_Layer01[i, 13] = DCU.Node_called_by_name_Layer01[random.Next(0, DCU.counter_layer01), 2];
                        DCU.Node_called_by_name_Layer01[i, 14] = DCU.Node_called_by_name_Layer01[random.Next(0, DCU.counter_layer01), 2];
                        DCU.Node_called_by_name_Layer01[i, 15] = DCU.Node_called_by_name_Layer01[random.Next(0, DCU.counter_layer01), 2];
                        DCU.Node_called_by_name_Layer01[i, 16] = DCU.Node_called_by_name_Layer01[random.Next(0, DCU.counter_layer01), 2];
                        DCU.Node_called_by_name_Layer01[i, 17] = DCU.Node_called_by_name_Layer01[random.Next(0, DCU.counter_layer01), 2];
                        DCU.Node_called_by_name_Layer01[i, 18] = DCU.Node_called_by_name_Layer01[random.Next(0, DCU.counter_layer01), 2];
                        DCU.Node_called_by_name_Layer01[i, 19] = DCU.Node_called_by_name_Layer01[random.Next(0, DCU.counter_layer01), 2];
                       
                        //for (int j = 6; j < 14; j++)
                        //{ 
                        //    DCU.Node_called_by_name_Layer01[i, j] = DCU.Node_called_by_name_Layer01[random.Next(0, DCU.counter_layer01), 2];
                        //}
                        //for (int j = 14; j < DCU.Columns_Layer; j++)
                        //{
                        //    DCU.Node_called_by_name_Layer01[i, j] = DCU.Node_called_by_name_Layer02[random.Next(0, DCU.counter_layer01), 2];
                        //}
                        //Console.WriteLine("Checked_Layer01");
                        //MessageBox.Show("Node belong to Layer01", "Notification");
                    }
                    else if (DCU.Copy_all_node_and_move_into_buffer[i, 5] == Layer.Layer_02.ToString())
                    {
                        int _compare = 6;
                        for (int j = _compare; j < _compare+4; j++)
                        {
                            DCU.Node_called_by_name_Layer02[i, j] = DCU.Node_called_by_name_Layer01[random.Next(0, DCU.counter_layer01), 2];
                        }
                        for (int j = _compare+4; j < _compare+ 8; j++)
                        {
                            DCU.Node_called_by_name_Layer02[i, j] = DCU.Node_called_by_name_Layer02[random.Next(0, DCU.counter_layer02), 2];
                        }
                        for (int j = _compare+8; j < DCU.Columns_copy_Node; j++)
                        {
                            DCU.Node_called_by_name_Layer02[i, j] = DCU.Node_called_by_name_Layer03[random.Next(0, DCU.counter_layer03), 2];
                        }
                        Console.WriteLine("Checked_Layer02");
                    }
                    else if (DCU.Copy_all_node_and_move_into_buffer[i, 5] == Layer.Layer_03.ToString())
                    {
                        int _compare = 6;
                        for (int j = _compare; j < _compare +4; j++)
                        {
                            DCU.Node_called_by_name_Layer03[i, j] = DCU.Node_called_by_name_Layer02[random.Next(0, DCU.counter_layer02), 2];
                        }
                        for (int j = _compare + 4; j < _compare+8; j++)
                        {
                            DCU.Node_called_by_name_Layer03[i, j] = DCU.Node_called_by_name_Layer03[random.Next(0, DCU.counter_layer03), 2];
                        }
                        for (int j = _compare+8; j < DCU.Columns_copy_Node; j++)
                        {
                            DCU.Node_called_by_name_Layer03[i, j] = DCU.Node_called_by_name_Layer04[random.Next(0, DCU.counter_layer04), 2];
                        }
                        Console.WriteLine("Checked_Layer03");

                    }
                    else if (DCU.Copy_all_node_and_move_into_buffer[i, 5] == Layer.Layer_04.ToString())
                    {
                        int _compare = 6;
                        for (int j = _compare; j < _compare+ 10; j++)
                        {
                            DCU.Node_called_by_name_Layer04[i, j] = DCU.Node_called_by_name_Layer03[random.Next(0, DCU.counter_layer03), 2];
                        }
                        for (int j = _compare + 10; j < DCU.Columns_copy_Node; j++)
                        {
                            DCU.Node_called_by_name_Layer04[i, j] = DCU.Node_called_by_name_Layer04[random.Next(0, DCU.counter_layer04), 2];
                        }
                        Console.WriteLine("Checked_Layer04");
                    }
                }
                else
                {
                    //Console.WriteLine( i + "This node notbelong to management");
                }
            }
        }
        /// <summary>
        /// Notcheck
        /// </summary>
        /// <param name="numberNode"></param>
        /// <param name="Layer"></param>
        public void select_radom_(int numberNode, int Layer)
        {

        }
        /// <summary>
        /// 3 fuction call used to creat neigbhour
        /// </summary>
        #region
        public void Creat_random_neigbhour_Layer01()
        {
            for (int i = 0; i < DCU.Columns_copy_Node; i++)
            {
                // what is layer of Node : check it.
                //DCU.Node_called_by_name_Layer01
                Creat_Neigbhour(int.Parse(DCU.Copy_all_node_and_move_into_buffer[i, 1]));
            }
        }
        public void Creat_random_neigbhour_Layer02()
        {
            for (int i = 0; i < DCU.counter_layer02; i++)
            {
                //Creat_random_neigbhour_Layer01============
            }
        }
        public void Creat_random_neigbhour_Layer04()
        { 
        }
        #endregion

       
        /// <summary>
        ///  Note: Befor call this fuction. Project must be call Creat_node and move all node in to buffer
        /// </summary>
        void setUp_andSHow_listview()
        {
            listView1.Clear();
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.Font = new Font("Arial", 10, FontStyle.Bold);
            listView1.Columns.Add("Number", 65);
            listView1.Columns.Add("Serial", 80);
            listView1.Columns.Add("RSSI", 50);
            listView1.Columns.Add("Company", 80);
            listView1.Columns.Add("Type Meter", 120);
            ListViewItem list_items;
            string[] buffer_used_to_display = new string[6];
            for (int i = 0; i < DCU.Size_network; i++)
            {
                buffer_used_to_display[0] = DCU.Copy_all_node_and_move_into_buffer[i, 0];
                buffer_used_to_display[1] = DCU.Copy_all_node_and_move_into_buffer[i, 1];
                buffer_used_to_display[2] = DCU.Copy_all_node_and_move_into_buffer[i, 2];
                buffer_used_to_display[3] = DCU.Copy_all_node_and_move_into_buffer[i, 3];
                buffer_used_to_display[4] = DCU.Copy_all_node_and_move_into_buffer[i, 4];
                list_items = new ListViewItem(buffer_used_to_display);
                listView1.Items.Add(list_items);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Creat_Node(50);
            Move_all_node_into_buffer();
            setUp_andSHow_listview();
        }
        void Setup_Network()
        {
            Creat_Node(50);
            Move_all_node_into_buffer();
            Arrangement_Layer();
            //for (int i = 0; i < DCU.Size_network; i++)
            //{
            //    Creat_Neigbhour(int.Parse(DCU.Copy_all_node_and_move_into_buffer[i, 2]));
            //}

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = int.Parse(DCU.Copy_all_node_and_move_into_buffer[2, 2]) - 10;
            MessageBox.Show(a.ToString());
        }
        static int variable_use_to_calculator_RSSi;
        int getRSSI_ofNode(int Name)
        {
            for (int i = 0; i < DCU.Size_network; i++)
            {
                if (string.Compare(Name.ToString(), DCU.Copy_all_node_and_move_into_buffer[i,2]) == 0)
                {
                    variable_use_to_calculator_RSSi = int.Parse(DCU.Copy_all_node_and_move_into_buffer[i, 3]);
                    break;
                }
                break;
            }
            return variable_use_to_calculator_RSSi;
        }

    /// <summary>
    /// Creat neigbhour of Node
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Warring", "textbox1 is empty");
            }
            else
            {
                int value = Convert.ToInt32(textBox1.Text);
                Creat_Neigbhour(value);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(textBox1.Text);

            if (textBox1.Text == "")
            {
                MessageBox.Show("Warring", "textbox1 is empty");
            }
            else
            {
                //for (int i = 0; i < DCU.Size_network; i++)
                //{
                //    if (string.Compare(textBox1.Text, DCU.Copy_all_node_and_move_into_buffer[i,1]) == 0)
                //    {
                //        MessageBox.Show("OK", "Notification");
                //        for (int j = 0; j < 20; j++)
                //        {
                //            Console.WriteLine(DCU.Copy_all_node_and_move_into_buffer[i, j]);
                //        }
                //    }
                //}
                // creat neigbhour
                for (int i = 0; i < DCU.Size_network; i++)
                {
                    if (string.Compare(value.ToString(), DCU.Copy_all_node_and_move_into_buffer[i, 2]) == 0)
                    {
                        DCU.Node_called_by_name_Layer01[i, 6] = DCU.DCU_Serial.ToString();
                        for (int j = 6; j < 14; j++)
                        {
                            DCU.Node_called_by_name_Layer01[i, j] = DCU.Node_called_by_name_Layer01[random.Next(0, DCU.counter_layer01), 2];
                        }
                        for (int j = 14; j < DCU.Columns_Layer; j++)
                        {
                            DCU.Node_called_by_name_Layer01[i, j] = DCU.Node_called_by_name_Layer02[random.Next(0, DCU.counter_layer01), 2];
                        }
                    }
                }

            }
            //int value = Convert.ToInt32(textBox1.Text);

            for (int i = 0; i < DCU.Size_network; i++)
            {
                if (string.Compare(value.ToString(), DCU.Copy_all_node_and_move_into_buffer[i, 2]) == 0)
                {
                    for (int j = 0; j < DCU.Columns_Layer; j++)
                    {
                        Console.WriteLine(DCU.Node_called_by_name_Layer01[i, j]);
                    }
                }
            }
            //Arrangement_Layer();
            
        }
       

        private void button5_Click(object sender, EventArgs e)
        {
            test_version02();
        }
        public void test_version02()
        {
            // creat Node
            Creat_Node(50);
            // bufer Copy_Node
            Move_all_node_into_buffer();
            // Move to each Layer Node_called_by_name
            Arrangement_Layer();
            // select each LayerNode
            setUp_andSHow_listview();
            //for (int i = 0; i < DCU.Size_network; i++)
            //{
            //    Random_neigbhour(int.Parse(DCU.Copy_all_node_and_move_into_buffer[i, 1]));
            //}
            //for (int i = 0; i < DCU.Size_network; i++)
            //{
            //    for (int j = 0; j < DCU.Columns_Layer; j++)
            //    {
            //        Console.WriteLine(DCU.Node_called_by_name_Layer01[i, j]);
            //    }
            //}

            //for (int i = 0; i < DCU.counter_layer02; i++)
            //{
            //    for (int j = 0; j < DCU.Columns_Layer; j++)
            //    {
            //        Console.WriteLine(DCU.Node_called_by_name_Layer02[i, j]);
            //    }
            //}
            //Console.WriteLine("___________________________________________________________");
            //// setup test
            //for (int i = 0; i < DCU.counter_layer02; i++)
            //{
            //    for (int j = 6; j < 20; j++)
            //    {
            //        DCU.Node_called_by_name_Layer02[i, j] = "adasfafaf";
            //    }
            //}
            //Console.WriteLine("___________________________________________________________");

            //for (int i = 0; i < DCU.counter_layer02; i++)
            //{
            //    for (int j = 0; j < DCU.Columns_Layer; j++)
            //    {
            //        Console.WriteLine(DCU.Node_called_by_name_Layer02[i, j]);
            //    }
            //}
            //Console.WriteLine("-----------------------------------------------Check Node------------------------------------------------");
            //for (int i = 0; i < DCU.counter_layer02; i++)
            //{
            //    Check_Node(int.Parse(DCU.Node_called_by_name_Layer02[i, 1]));
            //}
            //Console.WriteLine("-----------------------------------------Show Layer01---------------------------------------------------");

            //for (int i = 0; i < DCU.counter_layer02; i++)
            //{
            //    for (int j = 0; j < DCU.Columns_Layer; j++)
            //    {
            //        Console.WriteLine(DCU.Node_called_by_name_Layer02[i, j]);
            //    }
            //}
            for (int i = 0; i < DCU.Size_network; i++)
            {
                Check_Node(int.Parse(DCU.Copy_all_node_and_move_into_buffer[i, 1]));
            }
            Console.WriteLine("------------------------Layer 01------------------");

            for (int i = 0; i < DCU.Size_network; i++)
            {
                for (int j = 0; j < DCU.Columns_Layer; j++)
                {
                    Console.WriteLine(DCU.Node_called_by_name_Layer01[i, j]);
                }
            }
            Console.WriteLine("------------------------Layer 02------------------");
            for (int i = 0; i < DCU.Size_network; i++)
            {
                for (int j = 0; j < DCU.Columns_Layer; j++)
                {
                    Console.WriteLine(DCU.Node_called_by_name_Layer02[i, j]);
                }
            }
            Console.WriteLine("------------------------Layer 03------------------");
            for (int i = 0; i < DCU.Size_network; i++)
            {
                for (int j = 0; j < DCU.Columns_Layer; j++)
                {
                    Console.WriteLine(DCU.Node_called_by_name_Layer03[i, j]);
                }
            }
            Console.WriteLine("------------------------Layer 04------------------");
            for (int i = 0; i < DCU.Size_network; i++)
            {
                for (int j = 0; j < DCU.Columns_Layer; j++)
                {
                    Console.WriteLine(DCU.Node_called_by_name_Layer04[i, j]);
                }
            }
        }
        public void Check_Node(int Node)
        {
            // what is layer node belong  ?
            for (int i = 0; i < DCU.counter_layer01; i++)
            {
                if (string.Compare(Node.ToString(), DCU.Node_called_by_name_Layer01[i,1]) == 0)
                {
                    // upper
                    DCU.Node_called_by_name_Layer01[i, 6] = DCU.DCU_Serial.ToString();
                    // same
                    for (int j = 7; j <14; j++)
                    {
                        DCU.Node_called_by_name_Layer01[i, j] = DCU.Node_called_by_name_Layer01[random.Next(0, DCU.counter_layer01), 1];
                    }
                    // lower
                    for (int k = 14; k < DCU.Columns_Layer; k++)
                    {
                        DCU.Node_called_by_name_Layer02[i, k] = DCU.Node_called_by_name_Layer02[random.Next(0, DCU.counter_layer02), 1];
                    }
                }
            }
            // layer 02
            for (int i = 0; i < DCU.counter_layer02; i++)
            {
                if (string.Compare(Node.ToString(), DCU.Node_called_by_name_Layer02[i, 1]) == 0)
                {
                    // upper
                    for (int j = 6; j < 10; j++)
                    {
                        DCU.Node_called_by_name_Layer02[i, j] = DCU.Node_called_by_name_Layer01[random.Next(0, DCU.counter_layer01), 1];
                    }
                    for (int k = 10; k < 14; k++)
                    {
                        DCU.Node_called_by_name_Layer02[i, k] = DCU.Node_called_by_name_Layer02[random.Next(0, DCU.counter_layer02), 1];
                    }
                    for (int k = 14; k < DCU.Columns_Layer; k++)
                    {
                        DCU.Node_called_by_name_Layer02[i, k] = DCU.Node_called_by_name_Layer03[random.Next(0, DCU.counter_layer03), 1];
                    }
                }
            }
            // layer 03
            for (int i = 0; i < DCU.counter_layer03; i++)
            {
                if (string.Compare(Node.ToString(), DCU.Node_called_by_name_Layer03[i,1]) == 0)
                {
                    // upper
                    for (int j = 6; j < 10; j++)
                    {
                        DCU.Node_called_by_name_Layer03[i, j] = DCU.Node_called_by_name_Layer02[random.Next(0, DCU.counter_layer02), 1];
                    }
                    for (int j = 0; j < 14; j++)
                    {
                        DCU.Node_called_by_name_Layer03[i, j] = DCU.Node_called_by_name_Layer03[random.Next(0, DCU.counter_layer03), 1];
                    }
                    for (int j = 0; j < DCU.Columns_Layer; j++)
                    {
                        DCU.Node_called_by_name_Layer03[i, j] = DCU.Node_called_by_name_Layer04[random.Next(0, DCU.counter_layer04), 1];
                    }
                }
            }
            //layer 04
            for (int i = 0; i < DCU.counter_layer04; i++)
            {
                if (string.Compare(Node.ToString() , DCU.Node_called_by_name_Layer04[i,1]) == 0)
                {
                    for (int j = 6; j < 14; j++)
                    {
                        DCU.Node_called_by_name_Layer04[i, j] = DCU.Node_called_by_name_Layer03[random.Next(0, DCU.counter_layer03), 1];
                    }
                    for (int j = 14; j < DCU.Columns_Layer; j++)
                    {
                        DCU.Node_called_by_name_Layer04[i, j] = DCU.Node_called_by_name_Layer04[random.Next(0, DCU.counter_layer04), 1];
                    }
                }
            }
        
        }
        /// <summary>
        /// discard Node same layer and node upper layer
        /// </summary>
        public void Discard_Node()
        {

        }
    }
}
