namespace CapaPresentacion
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.linkregistroalumno = new System.Windows.Forms.LinkLabel();
            this.linkinformeeconomico = new System.Windows.Forms.LinkLabel();
            this.linkcerrar = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(95, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 187);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "INTEGRANTES DEL GRUPO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "SORIA AVENDAÑO HEMMY SANTIAGUITO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "GALVEZ CHAICO YARITZA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(274, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "CHURANO ROMERO PEDRO ALVARO";
            // 
            // linkregistroalumno
            // 
            this.linkregistroalumno.AutoSize = true;
            this.linkregistroalumno.BackColor = System.Drawing.Color.CornflowerBlue;
            this.linkregistroalumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkregistroalumno.Location = new System.Drawing.Point(1, 0);
            this.linkregistroalumno.Name = "linkregistroalumno";
            this.linkregistroalumno.Size = new System.Drawing.Size(122, 16);
            this.linkregistroalumno.TabIndex = 0;
            this.linkregistroalumno.TabStop = true;
            this.linkregistroalumno.Text = "Registro Alumno";
            this.linkregistroalumno.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkregistroalumno_LinkClicked);
            // 
            // linkinformeeconomico
            // 
            this.linkinformeeconomico.AutoSize = true;
            this.linkinformeeconomico.BackColor = System.Drawing.Color.CornflowerBlue;
            this.linkinformeeconomico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkinformeeconomico.Location = new System.Drawing.Point(129, 0);
            this.linkinformeeconomico.Name = "linkinformeeconomico";
            this.linkinformeeconomico.Size = new System.Drawing.Size(169, 16);
            this.linkinformeeconomico.TabIndex = 2;
            this.linkinformeeconomico.TabStop = true;
            this.linkinformeeconomico.Text = "Informacion Economica";
            this.linkinformeeconomico.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkinformeeconomico_LinkClicked);
            // 
            // linkcerrar
            // 
            this.linkcerrar.AutoSize = true;
            this.linkcerrar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.linkcerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkcerrar.Location = new System.Drawing.Point(315, 0);
            this.linkcerrar.Name = "linkcerrar";
            this.linkcerrar.Size = new System.Drawing.Size(111, 16);
            this.linkcerrar.TabIndex = 8;
            this.linkcerrar.TabStop = true;
            this.linkcerrar.Text = "Cerrar Session";
            this.linkcerrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkcerrar_LinkClicked);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(425, 387);
            this.Controls.Add(this.linkcerrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkinformeeconomico);
            this.Controls.Add(this.linkregistroalumno);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkregistroalumno;
        private System.Windows.Forms.LinkLabel linkinformeeconomico;
        private System.Windows.Forms.LinkLabel linkcerrar;
    }
}