using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuyac_1stLabEam
{
    public partial class Form1 : Form
    {
        private double total_Danielle = 0;
        private double total_Edward = 0;
        private double total_Fatima = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void getSalesPerson_Amount(string salesInitial, double salesAmount)
        {
            if (salesInitial == "D")
            {
                total_Danielle += salesAmount;
                lbl_Display.Text = $"Updated Total Sales:\nDanielle: ₱{total_Danielle}";
            }
            else if (salesInitial == "E")
            {
                total_Edward += salesAmount;
                lbl_Display.Text = $"Updated Total Sales:\nEdward: ₱{total_Edward}";
            }
            else if (salesInitial == "F")
            {
                total_Fatima += salesAmount;
                lbl_Display.Text = $"Updated Total Sales:\nFatima: ₱{total_Fatima}";
            }
            else
            {
                lbl_Display.Text = "Invalid Sales Person Initial.";
            }
        }
        

        private void UpdateTotalDisplay()
        {
   
        }

        private void clearEntry()
        {
            lbl_Display.Text = "";
            txt_Amount.Text = "";
            txt_Initial.Text = "";
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbl_Display_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Submit_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txt_Amount.Text, out double saleAmount))
            {
                getSalesPerson_Amount(txt_Initial.Text, saleAmount);
            }
            else
            {
                lbl_Display.Text = "Please enter a valid number for the sale amount.";
            }
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            clearEntry();
        }

        private void Btn_Print_Click(object sender, EventArgs e)
        {
            Form2 summary = new Form2(
        total_Danielle,
        total_Edward,
        total_Fatima
    );

            summary.ShowDialog();
        }
    }
}
