namespace CapaPresentacion
{
    partial class informeeconomico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(informeeconomico));
            this.linkprincipal = new System.Windows.Forms.LinkLabel();
            this.dataGridViewinforme = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtfechapago = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtdescuento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmontopagar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcuota = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtperiodo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcodigoalumno = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.txtconceptopago = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtimportemes = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewinforme)).BeginInit();
            this.SuspendLayout();
            // 
            // linkprincipal
            // 
            this.linkprincipal.AutoSize = true;
            this.linkprincipal.BackColor = System.Drawing.Color.CornflowerBlue;
            this.linkprincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkprincipal.Location = new System.Drawing.Point(587, 9);
            this.linkprincipal.Name = "linkprincipal";
            this.linkprincipal.Size = new System.Drawing.Size(69, 16);
            this.linkprincipal.TabIndex = 5;
            this.linkprincipal.TabStop = true;
            this.linkprincipal.Text = "Principal";
            this.linkprincipal.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkprincipal_LinkClicked);
            // 
            // dataGridViewinforme
            // 
            this.dataGridViewinforme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewinforme.Location = new System.Drawing.Point(21, 226);
            this.dataGridViewinforme.Name = "dataGridViewinforme";
            this.dataGridViewinforme.Size = new System.Drawing.Size(617, 309);
            this.dataGridViewinforme.TabIndex = 6;
            this.dataGridViewinforme.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewinforme_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "LISTADO DE PAGOS";
            // 
            // txtfechapago
            // 
            this.txtfechapago.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfechapago.Location = new System.Drawing.Point(420, 134);
            this.txtfechapago.Name = "txtfechapago";
            this.txtfechapago.Size = new System.Drawing.Size(85, 24);
            this.txtfechapago.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(307, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 18);
            this.label7.TabIndex = 24;
            this.label7.Text = "Fecha Pago:";
            // 
            // txtdescuento
            // 
            this.txtdescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescuento.Location = new System.Drawing.Point(162, 137);
            this.txtdescuento.Name = "txtdescuento";
            this.txtdescuento.Size = new System.Drawing.Size(101, 24);
            this.txtdescuento.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(72, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 18);
            this.label6.TabIndex = 22;
            this.label6.Text = "Descuento:";
            // 
            // txtmontopagar
            // 
            this.txtmontopagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmontopagar.Location = new System.Drawing.Point(420, 101);
            this.txtmontopagar.Name = "txtmontopagar";
            this.txtmontopagar.Size = new System.Drawing.Size(85, 24);
            this.txtmontopagar.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(288, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 18);
            this.label5.TabIndex = 20;
            this.label5.Text = "Monto A Pagar:";
            // 
            // txtcuota
            // 
            this.txtcuota.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcuota.Location = new System.Drawing.Point(162, 104);
            this.txtcuota.Name = "txtcuota";
            this.txtcuota.Size = new System.Drawing.Size(102, 24);
            this.txtcuota.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(104, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "Cuota:";
            // 
            // txtperiodo
            // 
            this.txtperiodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtperiodo.Location = new System.Drawing.Point(420, 69);
            this.txtperiodo.Name = "txtperiodo";
            this.txtperiodo.Size = new System.Drawing.Size(85, 24);
            this.txtperiodo.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(331, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "Periodo :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(397, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "REGISTRO DE PAGO DE MENSUALIDAD";
            // 
            // txtcodigoalumno
            // 
            this.txtcodigoalumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigoalumno.Location = new System.Drawing.Point(162, 69);
            this.txtcodigoalumno.Name = "txtcodigoalumno";
            this.txtcodigoalumno.Size = new System.Drawing.Size(102, 24);
            this.txtcodigoalumno.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(42, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 18);
            this.label8.TabIndex = 13;
            this.label8.Text = "Codigo Alumno:";
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(563, 53);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 34);
            this.btnguardar.TabIndex = 26;
            this.btnguardar.Text = "GUARDAR";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btneditar
            // 
            this.btneditar.Location = new System.Drawing.Point(563, 106);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(75, 34);
            this.btneditar.TabIndex = 27;
            this.btneditar.Text = "EDITAR";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(563, 162);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 34);
            this.btneliminar.TabIndex = 28;
            this.btneliminar.Text = "ELIMINAR";
            this.btneliminar.UseVisualStyleBackColor = true;
            // 
            // txtconceptopago
            // 
            this.txtconceptopago.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconceptopago.Location = new System.Drawing.Point(177, 172);
            this.txtconceptopago.Name = "txtconceptopago";
            this.txtconceptopago.Size = new System.Drawing.Size(101, 24);
            this.txtconceptopago.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 18);
            this.label9.TabIndex = 29;
            this.label9.Text = "Pago por concepto de:";
            // 
            // txtimportemes
            // 
            this.txtimportemes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtimportemes.Location = new System.Drawing.Point(420, 169);
            this.txtimportemes.Name = "txtimportemes";
            this.txtimportemes.Size = new System.Drawing.Size(85, 24);
            this.txtimportemes.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(288, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 18);
            this.label10.TabIndex = 31;
            this.label10.Text = "Monto de Mes:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // informeeconomico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 545);
            this.Controls.Add(this.txtimportemes);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtconceptopago);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.txtfechapago);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtdescuento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtmontopagar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtcuota);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtperiodo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcodigoalumno);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewinforme);
            this.Controls.Add(this.linkprincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "informeeconomico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "informeeconomico";
            this.Load += new System.EventHandler(this.informeeconomico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewinforme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkprincipal;
        private System.Windows.Forms.DataGridView dataGridViewinforme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtfechapago;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtdescuento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtmontopagar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcuota;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtperiodo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcodigoalumno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.TextBox txtconceptopago;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtimportemes;
        private System.Windows.Forms.Label label10;
    }
}