namespace Calculadora
{
    partial class Calculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Txb_Ingr = new System.Windows.Forms.TextBox();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.Btn_Mult = new System.Windows.Forms.Button();
            this.Btn_Sqr = new System.Windows.Forms.Button();
            this.Btn_Rest = new System.Windows.Forms.Button();
            this.Btn_Div = new System.Windows.Forms.Button();
            this.Btn_Exp = new System.Windows.Forms.Button();
            this.Btn_Equal = new System.Windows.Forms.Button();
            this.Lbl_Reg = new System.Windows.Forms.Label();
            this.Lbl_Val1 = new System.Windows.Forms.Label();
            this.Lbl_Val2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txb_Ingr
            // 
            this.Txb_Ingr.Location = new System.Drawing.Point(94, 81);
            this.Txb_Ingr.Name = "Txb_Ingr";
            this.Txb_Ingr.Size = new System.Drawing.Size(233, 20);
            this.Txb_Ingr.TabIndex = 0;
            this.Txb_Ingr.Text = "0";
            // 
            // Btn_Add
            // 
            this.Btn_Add.Location = new System.Drawing.Point(12, 146);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(88, 49);
            this.Btn_Add.TabIndex = 1;
            this.Btn_Add.Text = "Suma";
            this.Btn_Add.UseVisualStyleBackColor = true;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // Btn_Mult
            // 
            this.Btn_Mult.Location = new System.Drawing.Point(149, 146);
            this.Btn_Mult.Name = "Btn_Mult";
            this.Btn_Mult.Size = new System.Drawing.Size(88, 49);
            this.Btn_Mult.TabIndex = 2;
            this.Btn_Mult.Text = "Multiplicacion";
            this.Btn_Mult.UseVisualStyleBackColor = true;
            this.Btn_Mult.Click += new System.EventHandler(this.Btn_Mult_Click);
            // 
            // Btn_Sqr
            // 
            this.Btn_Sqr.Location = new System.Drawing.Point(283, 146);
            this.Btn_Sqr.Name = "Btn_Sqr";
            this.Btn_Sqr.Size = new System.Drawing.Size(97, 49);
            this.Btn_Sqr.TabIndex = 3;
            this.Btn_Sqr.Text = "Raiz Cuadrada";
            this.Btn_Sqr.UseVisualStyleBackColor = true;
            this.Btn_Sqr.Click += new System.EventHandler(this.Btn_Sqr_Click);
            // 
            // Btn_Rest
            // 
            this.Btn_Rest.Location = new System.Drawing.Point(12, 211);
            this.Btn_Rest.Name = "Btn_Rest";
            this.Btn_Rest.Size = new System.Drawing.Size(88, 49);
            this.Btn_Rest.TabIndex = 4;
            this.Btn_Rest.Text = "Resta";
            this.Btn_Rest.UseVisualStyleBackColor = true;
            this.Btn_Rest.Click += new System.EventHandler(this.Btn_Rest_Click);
            // 
            // Btn_Div
            // 
            this.Btn_Div.Location = new System.Drawing.Point(149, 211);
            this.Btn_Div.Name = "Btn_Div";
            this.Btn_Div.Size = new System.Drawing.Size(88, 49);
            this.Btn_Div.TabIndex = 5;
            this.Btn_Div.Text = "Division";
            this.Btn_Div.UseVisualStyleBackColor = true;
            this.Btn_Div.Click += new System.EventHandler(this.Btn_Div_Click);
            // 
            // Btn_Exp
            // 
            this.Btn_Exp.Location = new System.Drawing.Point(283, 211);
            this.Btn_Exp.Name = "Btn_Exp";
            this.Btn_Exp.Size = new System.Drawing.Size(97, 49);
            this.Btn_Exp.TabIndex = 6;
            this.Btn_Exp.Text = "Exp";
            this.Btn_Exp.UseVisualStyleBackColor = true;
            this.Btn_Exp.Click += new System.EventHandler(this.Btn_Exp_Click);
            // 
            // Btn_Equal
            // 
            this.Btn_Equal.Location = new System.Drawing.Point(340, 265);
            this.Btn_Equal.Name = "Btn_Equal";
            this.Btn_Equal.Size = new System.Drawing.Size(75, 38);
            this.Btn_Equal.TabIndex = 7;
            this.Btn_Equal.Text = "=";
            this.Btn_Equal.UseVisualStyleBackColor = true;
            this.Btn_Equal.Click += new System.EventHandler(this.Btn_Equal_Click);
            // 
            // Lbl_Reg
            // 
            this.Lbl_Reg.AutoSize = true;
            this.Lbl_Reg.Location = new System.Drawing.Point(171, 33);
            this.Lbl_Reg.Name = "Lbl_Reg";
            this.Lbl_Reg.Size = new System.Drawing.Size(56, 13);
            this.Lbl_Reg.TabIndex = 8;
            this.Lbl_Reg.Text = "Operacion";
            this.Lbl_Reg.Visible = false;
            // 
            // Lbl_Val1
            // 
            this.Lbl_Val1.AutoSize = true;
            this.Lbl_Val1.Location = new System.Drawing.Point(122, 33);
            this.Lbl_Val1.Name = "Lbl_Val1";
            this.Lbl_Val1.Size = new System.Drawing.Size(13, 13);
            this.Lbl_Val1.TabIndex = 9;
            this.Lbl_Val1.Text = "0";
            this.Lbl_Val1.Visible = false;
            // 
            // Lbl_Val2
            // 
            this.Lbl_Val2.AutoSize = true;
            this.Lbl_Val2.Location = new System.Drawing.Point(260, 33);
            this.Lbl_Val2.Name = "Lbl_Val2";
            this.Lbl_Val2.Size = new System.Drawing.Size(13, 13);
            this.Lbl_Val2.TabIndex = 10;
            this.Lbl_Val2.Text = "0";
            this.Lbl_Val2.Visible = false;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 315);
            this.Controls.Add(this.Lbl_Val2);
            this.Controls.Add(this.Lbl_Val1);
            this.Controls.Add(this.Lbl_Reg);
            this.Controls.Add(this.Btn_Equal);
            this.Controls.Add(this.Btn_Exp);
            this.Controls.Add(this.Btn_Div);
            this.Controls.Add(this.Btn_Rest);
            this.Controls.Add(this.Btn_Sqr);
            this.Controls.Add(this.Btn_Mult);
            this.Controls.Add(this.Btn_Add);
            this.Controls.Add(this.Txb_Ingr);
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txb_Ingr;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.Button Btn_Mult;
        private System.Windows.Forms.Button Btn_Sqr;
        private System.Windows.Forms.Button Btn_Rest;
        private System.Windows.Forms.Button Btn_Div;
        private System.Windows.Forms.Button Btn_Exp;
        private System.Windows.Forms.Button Btn_Equal;
        private System.Windows.Forms.Label Lbl_Reg;
        private System.Windows.Forms.Label Lbl_Val1;
        private System.Windows.Forms.Label Lbl_Val2;
    }
}

