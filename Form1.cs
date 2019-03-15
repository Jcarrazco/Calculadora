using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
            
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            
        }

        private void Btn_Div_Click(object sender, EventArgs e)
        {
            Lbl_Val2.Visible = false;
            Lbl_Val1.Text = Txb_Ingr.Text;
            Lbl_Reg.Text = "/";
            Lbl_Reg.Visible = true;
            Lbl_Val1.Visible = true;
            Txb_Ingr.Text = "0";
            Txb_Ingr.Focus();
            
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            Lbl_Val2.Visible = false;
            Lbl_Val1.Text = Txb_Ingr.Text;
            Lbl_Reg.Text = "+";
            Lbl_Reg.Visible = true;
            Lbl_Val1.Visible = true;
            Txb_Ingr.Text = "0";
            Txb_Ingr.Focus();
        }

        public static class Operations
        {
            public static Double Suma(double x, double y)
            {
                double Result;
                Result = x + y;
                return Result;
            }

            public static Double Resta(double x, double y)
            {
                double Result;
                Result = x - y;
                return Result;
            }

            public static Double Mult(double x, double y)
            {
                double Result;
                Result = x * y;
                return Result;
            }

            public static Double Div(double x, double y)
            {
                double Result;
                try {
                    Result = x / y;
                    return Result;
                }
                catch (InvalidCastException e) {
                    return 0;
                }
                
            }

            public static double Sqr(int x)
            {
                return Math.Sqrt(x);
            }

            public static double Pow(double x, Double y)
            {
                return Math.Pow(x,y);
            }
        }

        private void Btn_Rest_Click(object sender, EventArgs e)
        {
            Lbl_Val2.Visible = false;
            Lbl_Val1.Text = Txb_Ingr.Text;
            Lbl_Reg.Text = "-";
            Lbl_Reg.Visible = true;
            Lbl_Val1.Visible = true;
            Txb_Ingr.Text = "0";
            Txb_Ingr.Focus();
        }

        private void Btn_Mult_Click(object sender, EventArgs e)
        {
            Lbl_Val2.Visible = false;
            Lbl_Val1.Text = Txb_Ingr.Text;
            Lbl_Reg.Text = "*";
            Lbl_Reg.Visible = true;
            Lbl_Val1.Visible = true;
            Txb_Ingr.Text = "0";
            Txb_Ingr.Focus();
        }

        private void Btn_Sqr_Click(object sender, EventArgs e)
        {
            Lbl_Val2.Visible = false;
            Lbl_Val1.Text = Txb_Ingr.Text;
            int a = Convert.ToInt32(Txb_Ingr.Text);

            Lbl_Reg.Text = "Sqr";
            Lbl_Reg.Visible = true;
            Lbl_Val1.Visible = true;
            Txb_Ingr.Text = Convert.ToString(Operations.Sqr(a));
            Btn_Equal.Focus();
        }

        private void Btn_Exp_Click(object sender, EventArgs e)
        {
            Lbl_Val2.Visible = false;
            Lbl_Val1.Text = Txb_Ingr.Text;
            Lbl_Reg.Text = "power";
            Lbl_Reg.Visible = true;
            Lbl_Val1.Visible = true;
            Txb_Ingr.Text = "0";
            Txb_Ingr.Focus();
        }

        private void Btn_Equal_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(Lbl_Val1.Text);
            double b = Convert.ToDouble(Txb_Ingr.Text);
            Lbl_Val2.Text = Txb_Ingr.Text;
            Lbl_Val2.Visible = true;
            string op = Lbl_Reg.Text;

            switch (op)
            {
                case "+"://Caso suma pone en la caja de texto el resultado
                    Txb_Ingr.Text = Convert.ToString( 
                    Operations.Suma(a, b));
                    break;
                case "-"://Caso resta pone resultado en caja de texto
                    Txb_Ingr.Text = Convert.ToString(
                    Operations.Resta(a, b));
                    break;
                case "*"://Caso Multiplicacion Pone resultado en caja de texto
                    Txb_Ingr.Text = Convert.ToString(
                    Operations.Mult(a, b));
                    break;
                case "/"://Caso division pone el resultado en caja de texto
                    Txb_Ingr.Text = Convert.ToString(
                    Operations.Div(a, b));
                    break;
                case "power"://Caso division pone el resultado en caja de texto
                    Txb_Ingr.Text = Convert.ToString(
                    Operations.Pow(a, b));
                    break;

                default:
                    Lbl_Val2.Visible = false;
                    Lbl_Val1.Visible = false;
                    Lbl_Reg.Visible = false;
                    Txb_Ingr.Text = "0";
                    break;
            }

        }
    }
}
