namespace Projeto1
{
    partial class frmloop
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
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btncalc3 = new System.Windows.Forms.Button();
            this.btncalc2 = new System.Windows.Forms.Button();
            this.btncalc1 = new System.Windows.Forms.Button();
            this.lblresult = new System.Windows.Forms.Label();
            this.lblnum = new System.Windows.Forms.Label();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnvoltar
            // 
            this.btnvoltar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.Location = new System.Drawing.Point(94, 331);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(82, 34);
            this.btnvoltar.TabIndex = 0;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.Location = new System.Drawing.Point(241, 331);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(82, 34);
            this.btnlimpar.TabIndex = 1;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btncalc3
            // 
            this.btncalc3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalc3.Location = new System.Drawing.Point(288, 254);
            this.btncalc3.Name = "btncalc3";
            this.btncalc3.Size = new System.Drawing.Size(101, 45);
            this.btncalc3.TabIndex = 2;
            this.btncalc3.Text = "Calcular 3";
            this.btncalc3.UseVisualStyleBackColor = true;
            this.btncalc3.Click += new System.EventHandler(this.btncalc3_Click);
            // 
            // btncalc2
            // 
            this.btncalc2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalc2.Location = new System.Drawing.Point(161, 254);
            this.btncalc2.Name = "btncalc2";
            this.btncalc2.Size = new System.Drawing.Size(101, 45);
            this.btncalc2.TabIndex = 3;
            this.btncalc2.Text = "Calcular 2";
            this.btncalc2.UseVisualStyleBackColor = true;
            this.btncalc2.Click += new System.EventHandler(this.btncalc2_Click);
            // 
            // btncalc1
            // 
            this.btncalc1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalc1.Location = new System.Drawing.Point(30, 254);
            this.btncalc1.Name = "btncalc1";
            this.btncalc1.Size = new System.Drawing.Size(101, 45);
            this.btncalc1.TabIndex = 4;
            this.btncalc1.Text = "Calcular 1";
            this.btncalc1.UseVisualStyleBackColor = true;
            this.btncalc1.Click += new System.EventHandler(this.btncalc1_Click);
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresult.Location = new System.Drawing.Point(52, 168);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(72, 18);
            this.lblresult.TabIndex = 5;
            this.lblresult.Text = "Tabuada:";
            // 
            // lblnum
            // 
            this.lblnum.AutoSize = true;
            this.lblnum.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnum.Location = new System.Drawing.Point(51, 90);
            this.lblnum.Name = "lblnum";
            this.lblnum.Size = new System.Drawing.Size(232, 18);
            this.lblnum.TabIndex = 6;
            this.lblnum.Text = "Digite um número para tabuada:";
            // 
            // txtresult
            // 
            this.txtresult.Location = new System.Drawing.Point(143, 153);
            this.txtresult.Multiline = true;
            this.txtresult.Name = "txtresult";
            this.txtresult.ReadOnly = true;
            this.txtresult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtresult.Size = new System.Drawing.Size(51, 46);
            this.txtresult.TabIndex = 7;
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(298, 88);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(100, 20);
            this.txtnum.TabIndex = 8;
            // 
            // frmloop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 419);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.lblnum);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.btncalc1);
            this.Controls.Add(this.btncalc2);
            this.Controls.Add(this.btncalc3);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnvoltar);
            this.Name = "frmloop";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Looping";
            this.Load += new System.EventHandler(this.frmloop_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btncalc3;
        private System.Windows.Forms.Button btncalc2;
        private System.Windows.Forms.Button btncalc1;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.Label lblnum;
        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.TextBox txtnum;
    }
}