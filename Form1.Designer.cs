namespace prueba_arbol
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtInsertar = new System.Windows.Forms.TextBox();
            this.txtEliminar = new System.Windows.Forms.TextBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnrecorrido = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpre = new System.Windows.Forms.TextBox();
            this.txtpost = new System.Windows.Forms.TextBox();
            this.txtin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(36, 56);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 0;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(36, 120);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(36, 184);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtInsertar
            // 
            this.txtInsertar.Location = new System.Drawing.Point(153, 56);
            this.txtInsertar.Name = "txtInsertar";
            this.txtInsertar.Size = new System.Drawing.Size(100, 20);
            this.txtInsertar.TabIndex = 3;
            // 
            // txtEliminar
            // 
            this.txtEliminar.Location = new System.Drawing.Point(153, 123);
            this.txtEliminar.Name = "txtEliminar";
            this.txtEliminar.Size = new System.Drawing.Size(100, 20);
            this.txtEliminar.TabIndex = 4;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(153, 184);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtBuscar.TabIndex = 5;
            // 
            // btnrecorrido
            // 
            this.btnrecorrido.Location = new System.Drawing.Point(36, 260);
            this.btnrecorrido.Name = "btnrecorrido";
            this.btnrecorrido.Size = new System.Drawing.Size(75, 23);
            this.btnrecorrido.TabIndex = 6;
            this.btnrecorrido.Text = "Recorridos";
            this.btnrecorrido.UseVisualStyleBackColor = true;
            this.btnrecorrido.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "PreOrden";
            // 
            // txtpre
            // 
            this.txtpre.Location = new System.Drawing.Point(143, 299);
            this.txtpre.Name = "txtpre";
            this.txtpre.Size = new System.Drawing.Size(100, 20);
            this.txtpre.TabIndex = 8;
            // 
            // txtpost
            // 
            this.txtpost.Location = new System.Drawing.Point(143, 358);
            this.txtpost.Name = "txtpost";
            this.txtpost.Size = new System.Drawing.Size(100, 20);
            this.txtpost.TabIndex = 9;
            this.txtpost.TextChanged += new System.EventHandler(this.txtpost_TextChanged);
            // 
            // txtin
            // 
            this.txtin.Location = new System.Drawing.Point(143, 418);
            this.txtin.Name = "txtin";
            this.txtin.Size = new System.Drawing.Size(100, 20);
            this.txtin.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "PostOrden";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 418);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "InOrden";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtin);
            this.Controls.Add(this.txtpost);
            this.Controls.Add(this.txtpre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnrecorrido);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.txtEliminar);
            this.Controls.Add(this.txtInsertar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnInsertar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtInsertar;
        private System.Windows.Forms.TextBox txtEliminar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnrecorrido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpre;
        private System.Windows.Forms.TextBox txtpost;
        private System.Windows.Forms.TextBox txtin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

