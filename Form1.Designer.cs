
namespace Ui
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.test = new System.Windows.Forms.Panel();
            this.ex = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.leftpanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.painelresposta = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonexit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttondiv = new System.Windows.Forms.Button();
            this.buttonmult = new System.Windows.Forms.Button();
            this.buttonsub = new System.Windows.Forms.Button();
            this.buttonadd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.test.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.painelresposta.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(161)))), ((int)(((byte)(130)))));
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.buttondiv);
            this.panel1.Controls.Add(this.buttonmult);
            this.panel1.Controls.Add(this.buttonsub);
            this.panel1.Controls.Add(this.buttonadd);
            this.panel1.Controls.Add(this.test);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 720);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(1)))), ((int)(((byte)(20)))));
            this.panel6.Location = new System.Drawing.Point(184, 141);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(14, 114);
            this.panel6.TabIndex = 3;
            // 
            // test
            // 
            this.test.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.test.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(201)))), ((int)(((byte)(220)))));
            this.test.Controls.Add(this.ex);
            this.test.Controls.Add(this.label8);
            this.test.Controls.Add(this.label9);
            this.test.Controls.Add(this.label10);
            this.test.Location = new System.Drawing.Point(0, 0);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(178, 110);
            this.test.TabIndex = 0;
            this.test.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // ex
            // 
            this.ex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ex.Enabled = false;
            this.ex.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(91)))), ((int)(((byte)(105)))));
            this.ex.Location = new System.Drawing.Point(0, 0);
            this.ex.Name = "ex";
            this.ex.Size = new System.Drawing.Size(178, 110);
            this.ex.TabIndex = 0;
            this.ex.Text = "Exercício 001";
            this.ex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ex.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(201)))), ((int)(((byte)(220)))));
            this.label8.Location = new System.Drawing.Point(13, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 23);
            this.label8.TabIndex = 1;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(201)))), ((int)(((byte)(220)))));
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 23);
            this.label9.TabIndex = 11;
            this.label9.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(201)))), ((int)(((byte)(220)))));
            this.label10.Location = new System.Drawing.Point(62, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 23);
            this.label10.TabIndex = 12;
            this.label10.Text = "label10";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.painelresposta);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(178, 587);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1102, 133);
            this.panel2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(87)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Location = new System.Drawing.Point(0, 105);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(313, 29);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.panel4.Controls.Add(this.buttonexit);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(178, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1102, 56);
            this.panel4.TabIndex = 2;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // leftpanel
            // 
            this.leftpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(87)))));
            this.leftpanel.Location = new System.Drawing.Point(184, 144);
            this.leftpanel.Name = "leftpanel";
            this.leftpanel.Size = new System.Drawing.Size(15, 114);
            this.leftpanel.TabIndex = 3;
            this.leftpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(186)))), ((int)(((byte)(207)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(958, 56);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(322, 531);
            this.panel3.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 161);
            this.label2.TabIndex = 0;
            this.label2.Text = "\r\n1: Escolha um modo \r\n2: Espere gerar dois números \r\n3: Digite o resultado deles" +
    " \r\npelo modo que você escolheu\r\n4: O programa dirá se você\r\nacertou ou não\r\n";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(91)))), ((int)(((byte)(105)))));
            this.label3.Location = new System.Drawing.Point(178, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 23);
            this.label3.TabIndex = 8;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(645, 56);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(313, 353);
            this.flowLayoutPanel1.TabIndex = 9;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(126)))), ((int)(((byte)(161)))));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(402, 66);
            this.label4.TabIndex = 0;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(3, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(334, 142);
            this.label6.TabIndex = 2;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.textBox1);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(645, 412);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(313, 172);
            this.panel5.TabIndex = 10;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(87)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(208)))), ((int)(((byte)(225)))));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(313, 41);
            this.button1.TabIndex = 0;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button1_MouseMove);
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(126)))), ((int)(((byte)(161)))));
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(313, 105);
            this.label7.TabIndex = 0;
            this.label7.Text = "\r\n";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // painelresposta
            // 
            this.painelresposta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(247)))), ((int)(((byte)(167)))));
            this.painelresposta.Controls.Add(this.label11);
            this.painelresposta.Dock = System.Windows.Forms.DockStyle.Right;
            this.painelresposta.Location = new System.Drawing.Point(781, 0);
            this.painelresposta.Name = "painelresposta";
            this.painelresposta.Size = new System.Drawing.Size(321, 133);
            this.painelresposta.TabIndex = 0;
            this.painelresposta.Paint += new System.Windows.Forms.PaintEventHandler(this.painelresposta_Paint);
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Location = new System.Drawing.Point(3, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(334, 145);
            this.label5.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(87)))));
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(321, 133);
            this.label11.TabIndex = 0;
            // 
            // buttonexit
            // 
            this.buttonexit.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonexit.FlatAppearance.BorderSize = 0;
            this.buttonexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonexit.Image = ((System.Drawing.Image)(resources.GetObject("buttonexit.Image")));
            this.buttonexit.Location = new System.Drawing.Point(1028, 0);
            this.buttonexit.Name = "buttonexit";
            this.buttonexit.Size = new System.Drawing.Size(74, 56);
            this.buttonexit.TabIndex = 1;
            this.buttonexit.UseVisualStyleBackColor = true;
            this.buttonexit.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(91)))), ((int)(((byte)(105)))));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(1102, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Números aleatórios:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // buttondiv
            // 
            this.buttondiv.FlatAppearance.BorderSize = 0;
            this.buttondiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttondiv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.buttondiv.Image = ((System.Drawing.Image)(resources.GetObject("buttondiv.Image")));
            this.buttondiv.Location = new System.Drawing.Point(0, 531);
            this.buttondiv.Name = "buttondiv";
            this.buttondiv.Size = new System.Drawing.Size(181, 114);
            this.buttondiv.TabIndex = 1;
            this.buttondiv.Text = "Elevação";
            this.buttondiv.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttondiv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttondiv.UseVisualStyleBackColor = true;
            this.buttondiv.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonmult
            // 
            this.buttonmult.FlatAppearance.BorderSize = 0;
            this.buttonmult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonmult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.buttonmult.Image = ((System.Drawing.Image)(resources.GetObject("buttonmult.Image")));
            this.buttonmult.Location = new System.Drawing.Point(0, 381);
            this.buttonmult.Name = "buttonmult";
            this.buttonmult.Size = new System.Drawing.Size(184, 114);
            this.buttonmult.TabIndex = 1;
            this.buttonmult.Text = "Multiplicação";
            this.buttonmult.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonmult.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonmult.UseVisualStyleBackColor = true;
            this.buttonmult.Click += new System.EventHandler(this.buttonmult_Click);
            // 
            // buttonsub
            // 
            this.buttonsub.FlatAppearance.BorderSize = 0;
            this.buttonsub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonsub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.buttonsub.Image = ((System.Drawing.Image)(resources.GetObject("buttonsub.Image")));
            this.buttonsub.Location = new System.Drawing.Point(0, 261);
            this.buttonsub.Name = "buttonsub";
            this.buttonsub.Size = new System.Drawing.Size(184, 114);
            this.buttonsub.TabIndex = 1;
            this.buttonsub.Text = "Subtração";
            this.buttonsub.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonsub.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonsub.UseVisualStyleBackColor = true;
            this.buttonsub.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonadd
            // 
            this.buttonadd.FlatAppearance.BorderSize = 0;
            this.buttonadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonadd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.buttonadd.Image = ((System.Drawing.Image)(resources.GetObject("buttonadd.Image")));
            this.buttonadd.Location = new System.Drawing.Point(0, 144);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(184, 114);
            this.buttonadd.TabIndex = 1;
            this.buttonadd.Text = "Adição\r\n";
            this.buttonadd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonadd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonadd.UseVisualStyleBackColor = true;
            this.buttonadd.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.leftpanel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.test.ResumeLayout(false);
            this.test.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.painelresposta.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel test;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttondiv;
        private System.Windows.Forms.Button buttonmult;
        private System.Windows.Forms.Button buttonsub;
        private System.Windows.Forms.Button buttonadd;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel leftpanel;
        private System.Windows.Forms.Label ex;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonexit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel painelresposta;
        private System.Windows.Forms.Label label11;
    }
}

