using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eats
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class ChickenOrder
        {
            int quantity;
            public ChickenOrder(int comingquantity)
            {
                quantity = comingquantity;
            }
            public int GetQuantity()
            {
                return quantity;
            }

            public void CutUp()
            {

            }
            public void cook()
            {

            }
        }

        public class EggOrder
        {
            Random rnd = new Random();
            int quanity;
            int quality;
            public EggOrder(int comingquantity)
            {
                quanity = comingquantity;
                quality = rnd.Next(101);

            }
            public Nullable<int> GetQuantity()
            {
                return quanity;
            }
            public int GetQuality()
            {
                return quality;
            }
            public void Crack()
            {
                if (quality < 25)
                {
                    throw new Exception("egg quality is <= 25");
                }
            }
            public void DisShell()
            {

            }
            public String cook()
            {
                string result = quanity + " eggs are cooking";
                return result;
            }
        }
        public class Employee
        {
            Object currentOrder;
            public Employee()
            {

            }
            public Object NewRequest(int quantity, int itemid)
            {
                if (itemid == 0)
                {
                    currentOrder = new ChickenOrder(quantity);
                    return currentOrder;
                }
                else
                {
                    currentOrder = new EggOrder(quantity);
                    return currentOrder;
                }
            }

            public String Inspect()
            {
                if (currentOrder.GetType() == typeof(ChickenOrder))
                {
                    return "Chicken have not qulity!";
                }
                else
                {
                    return ((EggOrder)currentOrder).GetQuality().ToString();
                }
            }
            public string PrepareFood()
            {
                if (currentOrder.GetType() == typeof(ChickenOrder))
                {
                    ChickenOrder ord = (ChickenOrder)currentOrder;
                    for(int i = 1; i<= ord.GetQuantity(); i++)
                    {
                        ord.CutUp();
                    }
                    ord.cook();
                    return ord.GetQuantity().ToString() + " chikkens is ready";
                }
                else
                {
                    EggOrder ord = (EggOrder)currentOrder;
                    for (int i = 1; i <= ord.GetQuantity(); i++)
                    {
                        ord.Crack();
                        ord.DisShell();
                    }
                    ord.cook();
                    return ((EggOrder)currentOrder).GetQuantity().ToString() + " eggs is ready";
                }
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {

        }

        Employee employee = new Employee();
        int currentOrderId = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int count = int.Parse(textBox1.Text);
            currentOrderId++;
            if (currentOrderId % 2 == 0)
            {
                count = 0;
            }
            if (radioButton.Checked)
            {
                employee.NewRequest(count, 0);
            }
            if (radioButton1.Checked)
            {
                employee.NewRequest(count, 1);
            }
            string eggQuality = employee.Inspect();
            label4.Text = eggQuality;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string result = employee.PrepareFood();
            listBox1.Items.Add(result);
        }     
    }
}
