namespace CAFFETERIA.MAQUINA_EXPENDEDORA
{
    partial class MaquinaExpendedora
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
            this.grpOperaciones = new System.Windows.Forms.GroupBox();
            this.txtAbastecer = new System.Windows.Forms.Button();
            this.btnComprar = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbProductos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpVitrina = new System.Windows.Forms.GroupBox();
            this.txtVitrina = new System.Windows.Forms.ListBox();
            this.grpOperaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).BeginInit();
            this.grpVitrina.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOperaciones
            // 
            this.grpOperaciones.BackColor = System.Drawing.Color.CadetBlue;
            this.grpOperaciones.Controls.Add(this.txtAbastecer);
            this.grpOperaciones.Controls.Add(this.btnComprar);
            this.grpOperaciones.Controls.Add(this.txtCantidad);
            this.grpOperaciones.Controls.Add(this.label2);
            this.grpOperaciones.Controls.Add(this.cmbProductos);
            this.grpOperaciones.Controls.Add(this.label1);
            this.grpOperaciones.Location = new System.Drawing.Point(12, 12);
            this.grpOperaciones.Name = "grpOperaciones";
            this.grpOperaciones.Size = new System.Drawing.Size(260, 426);
            this.grpOperaciones.TabIndex = 0;
            this.grpOperaciones.TabStop = false;
            this.grpOperaciones.Text = "VENTA";
            this.grpOperaciones.Enter += new System.EventHandler(this.grpOperaciones_Enter);
            // 
            // txtAbastecer
            // 
            this.txtAbastecer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtAbastecer.Location = new System.Drawing.Point(26, 323);
            this.txtAbastecer.Name = "txtAbastecer";
            this.txtAbastecer.Size = new System.Drawing.Size(200, 55);
            this.txtAbastecer.TabIndex = 4;
            this.txtAbastecer.Text = "Abastecer";
            this.txtAbastecer.UseVisualStyleBackColor = false;
            this.txtAbastecer.Click += new System.EventHandler(this.txtAbastecer_Click);
            // 
            // btnComprar
            // 
            this.btnComprar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnComprar.Location = new System.Drawing.Point(26, 251);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(200, 46);
            this.btnComprar.TabIndex = 1;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = false;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(14, 185);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(201, 27);
            this.txtCantidad.TabIndex = 3;
            this.txtCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtCantidad.ValueChanged += new System.EventHandler(this.txtCantidad_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Teal;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad de Producto: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cmbProductos
            // 
            this.cmbProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductos.FormattingEnabled = true;
            this.cmbProductos.Location = new System.Drawing.Point(15, 77);
            this.cmbProductos.Name = "cmbProductos";
            this.cmbProductos.Size = new System.Drawing.Size(200, 24);
            this.cmbProductos.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Producto";
            // 
            // grpVitrina
            // 
            this.grpVitrina.BackColor = System.Drawing.Color.CadetBlue;
            this.grpVitrina.Controls.Add(this.txtVitrina);
            this.grpVitrina.Location = new System.Drawing.Point(264, 12);
            this.grpVitrina.Name = "grpVitrina";
            this.grpVitrina.Size = new System.Drawing.Size(447, 426);
            this.grpVitrina.TabIndex = 1;
            this.grpVitrina.TabStop = false;
            this.grpVitrina.Text = "Vitrina ";
            // 
            // txtVitrina
            // 
            this.txtVitrina.BackColor = System.Drawing.Color.LightCyan;
            this.txtVitrina.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVitrina.FormattingEnabled = true;
            this.txtVitrina.ItemHeight = 20;
            this.txtVitrina.Location = new System.Drawing.Point(20, 21);
            this.txtVitrina.Name = "txtVitrina";
            this.txtVitrina.Size = new System.Drawing.Size(408, 384);
            this.txtVitrina.TabIndex = 0;
            // 
            // MaquinaExp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 450);
            this.Controls.Add(this.grpVitrina);
            this.Controls.Add(this.grpOperaciones);
            this.Name = "MaquinaExp";
            this.Text = "Máquina Expendedora";
            this.Load += new System.EventHandler(this.MaquinaExp_Load);
            this.grpOperaciones.ResumeLayout(false);
            this.grpOperaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).EndInit();
            this.grpVitrina.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOperaciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.NumericUpDown txtCantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbProductos;
        private System.Windows.Forms.Button txtAbastecer;
        private System.Windows.Forms.GroupBox grpVitrina;
        private System.Windows.Forms.ListBox txtVitrina;
    }
}

