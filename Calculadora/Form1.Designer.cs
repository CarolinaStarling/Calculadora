namespace Calculadora
{
    partial class Form1
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
            this.Resultado = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnSoma = new System.Windows.Forms.Button();
            this.btnMultiplicacao = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnMMais = new System.Windows.Forms.Button();
            this.btnMS = new System.Windows.Forms.Button();
            this.btnMC = new System.Windows.Forms.Button();
            this.btnMR = new System.Windows.Forms.Button();
            this.btnSeta = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btnSubtracao = new System.Windows.Forms.Button();
            this.btnDivisao = new System.Windows.Forms.Button();
            this.btnMaisMenos = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnRaiz = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnVirgula = new System.Windows.Forms.Button();
            this.btnMMenos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Resultado
            // 
            this.Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultado.Location = new System.Drawing.Point(12, 34);
            this.Resultado.Name = "Resultado";
            this.Resultado.ReadOnly = true;
            this.Resultado.Size = new System.Drawing.Size(260, 22);
            this.Resultado.TabIndex = 0;
            this.Resultado.Text = "0";
            this.Resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(12, 215);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(47, 28);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnSoma
            // 
            this.btnSoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoma.Location = new System.Drawing.Point(174, 248);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(47, 28);
            this.btnSoma.TabIndex = 2;
            this.btnSoma.Text = "+";
            this.btnSoma.UseVisualStyleBackColor = true;
            this.btnSoma.Click += new System.EventHandler(this.btnSoma_Click);
            // 
            // btnMultiplicacao
            // 
            this.btnMultiplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicacao.Location = new System.Drawing.Point(174, 180);
            this.btnMultiplicacao.Name = "btnMultiplicacao";
            this.btnMultiplicacao.Size = new System.Drawing.Size(47, 28);
            this.btnMultiplicacao.TabIndex = 3;
            this.btnMultiplicacao.Text = "*";
            this.btnMultiplicacao.UseVisualStyleBackColor = true;
            this.btnMultiplicacao.Click += new System.EventHandler(this.btnMultiplicacao_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(65, 214);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(47, 28);
            this.btn2.TabIndex = 4;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgual.Location = new System.Drawing.Point(227, 215);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(47, 61);
            this.btnIgual.TabIndex = 5;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnMMais
            // 
            this.btnMMais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMMais.Location = new System.Drawing.Point(121, 79);
            this.btnMMais.Name = "btnMMais";
            this.btnMMais.Size = new System.Drawing.Size(47, 28);
            this.btnMMais.TabIndex = 9;
            this.btnMMais.Text = "M+";
            this.btnMMais.UseVisualStyleBackColor = true;
            this.btnMMais.Click += new System.EventHandler(this.btnMMais_Click);
            // 
            // btnMS
            // 
            this.btnMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMS.Location = new System.Drawing.Point(227, 79);
            this.btnMS.Name = "btnMS";
            this.btnMS.Size = new System.Drawing.Size(47, 28);
            this.btnMS.TabIndex = 10;
            this.btnMS.Text = "MS";
            this.btnMS.UseVisualStyleBackColor = true;
            this.btnMS.Click += new System.EventHandler(this.btnMS_Click);
            // 
            // btnMC
            // 
            this.btnMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMC.Location = new System.Drawing.Point(12, 79);
            this.btnMC.Name = "btnMC";
            this.btnMC.Size = new System.Drawing.Size(47, 28);
            this.btnMC.TabIndex = 11;
            this.btnMC.Text = "MC";
            this.btnMC.UseVisualStyleBackColor = true;
            this.btnMC.Click += new System.EventHandler(this.btnMC_Click);
            // 
            // btnMR
            // 
            this.btnMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMR.Location = new System.Drawing.Point(65, 79);
            this.btnMR.Name = "btnMR";
            this.btnMR.Size = new System.Drawing.Size(47, 28);
            this.btnMR.TabIndex = 12;
            this.btnMR.Text = "MR";
            this.btnMR.UseVisualStyleBackColor = true;
            this.btnMR.Click += new System.EventHandler(this.btnMR_Click);
            // 
            // btnSeta
            // 
            this.btnSeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeta.Location = new System.Drawing.Point(12, 112);
            this.btnSeta.Name = "btnSeta";
            this.btnSeta.Size = new System.Drawing.Size(47, 28);
            this.btnSeta.TabIndex = 14;
            this.btnSeta.Text = "←";
            this.btnSeta.UseVisualStyleBackColor = true;
            this.btnSeta.Click += new System.EventHandler(this.btnSeta_Click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(12, 146);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(47, 28);
            this.btn7.TabIndex = 15;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(12, 181);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(47, 28);
            this.btn4.TabIndex = 16;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(121, 214);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(47, 28);
            this.btn3.TabIndex = 17;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btnCE
            // 
            this.btnCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCE.Location = new System.Drawing.Point(65, 113);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(47, 28);
            this.btnCE.TabIndex = 18;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(65, 147);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(47, 28);
            this.btn8.TabIndex = 19;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(65, 180);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(47, 28);
            this.btn5.TabIndex = 20;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btnSubtracao
            // 
            this.btnSubtracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtracao.Location = new System.Drawing.Point(174, 214);
            this.btnSubtracao.Name = "btnSubtracao";
            this.btnSubtracao.Size = new System.Drawing.Size(47, 28);
            this.btnSubtracao.TabIndex = 21;
            this.btnSubtracao.Text = "-";
            this.btnSubtracao.UseVisualStyleBackColor = true;
            this.btnSubtracao.Click += new System.EventHandler(this.btnSubtracao_Click);
            // 
            // btnDivisao
            // 
            this.btnDivisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivisao.Location = new System.Drawing.Point(174, 146);
            this.btnDivisao.Name = "btnDivisao";
            this.btnDivisao.Size = new System.Drawing.Size(47, 28);
            this.btnDivisao.TabIndex = 22;
            this.btnDivisao.Text = "/";
            this.btnDivisao.UseVisualStyleBackColor = true;
            this.btnDivisao.Click += new System.EventHandler(this.btnDivisao_Click);
            // 
            // btnMaisMenos
            // 
            this.btnMaisMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaisMenos.Location = new System.Drawing.Point(174, 112);
            this.btnMaisMenos.Name = "btnMaisMenos";
            this.btnMaisMenos.Size = new System.Drawing.Size(47, 28);
            this.btnMaisMenos.TabIndex = 23;
            this.btnMaisMenos.Text = "±";
            this.btnMaisMenos.UseVisualStyleBackColor = true;
            this.btnMaisMenos.Click += new System.EventHandler(this.btnMaisMenos_Click);
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(227, 180);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(47, 28);
            this.button15.TabIndex = 24;
            this.button15.Text = "1/x";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.Location = new System.Drawing.Point(227, 147);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(47, 28);
            this.button16.TabIndex = 25;
            this.button16.Text = "%";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(121, 180);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(47, 28);
            this.btn6.TabIndex = 26;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(121, 146);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(47, 28);
            this.btn9.TabIndex = 27;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btnC
            // 
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(121, 112);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(47, 28);
            this.btnC.TabIndex = 28;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnRaiz
            // 
            this.btnRaiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaiz.Location = new System.Drawing.Point(227, 112);
            this.btnRaiz.Name = "btnRaiz";
            this.btnRaiz.Size = new System.Drawing.Size(47, 28);
            this.btnRaiz.TabIndex = 29;
            this.btnRaiz.Text = "√";
            this.btnRaiz.UseVisualStyleBackColor = true;
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(12, 248);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(100, 29);
            this.btn0.TabIndex = 30;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnVirgula
            // 
            this.btnVirgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVirgula.Location = new System.Drawing.Point(121, 248);
            this.btnVirgula.Name = "btnVirgula";
            this.btnVirgula.Size = new System.Drawing.Size(47, 28);
            this.btnVirgula.TabIndex = 31;
            this.btnVirgula.Text = ",";
            this.btnVirgula.UseVisualStyleBackColor = true;
            this.btnVirgula.Click += new System.EventHandler(this.btnVirgula_Click);
            // 
            // btnMMenos
            // 
            this.btnMMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMMenos.Location = new System.Drawing.Point(174, 79);
            this.btnMMenos.Name = "btnMMenos";
            this.btnMMenos.Size = new System.Drawing.Size(47, 28);
            this.btnMMenos.TabIndex = 32;
            this.btnMMenos.Text = "M-";
            this.btnMMenos.UseVisualStyleBackColor = true;
            this.btnMMenos.Click += new System.EventHandler(this.btnMMenos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 288);
            this.Controls.Add(this.btnMMenos);
            this.Controls.Add(this.btnVirgula);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnRaiz);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.btnMaisMenos);
            this.Controls.Add(this.btnDivisao);
            this.Controls.Add(this.btnSubtracao);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnSeta);
            this.Controls.Add(this.btnMR);
            this.Controls.Add(this.btnMC);
            this.Controls.Add(this.btnMS);
            this.Controls.Add(this.btnMMais);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btnMultiplicacao);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.Resultado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Resultado;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Button btnMultiplicacao;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnMMais;
        private System.Windows.Forms.Button btnMS;
        private System.Windows.Forms.Button btnMC;
        private System.Windows.Forms.Button btnMR;
        private System.Windows.Forms.Button btnSeta;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btnSubtracao;
        private System.Windows.Forms.Button btnDivisao;
        private System.Windows.Forms.Button btnMaisMenos;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnRaiz;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnVirgula;
        private System.Windows.Forms.Button btnMMenos;
    }
}

