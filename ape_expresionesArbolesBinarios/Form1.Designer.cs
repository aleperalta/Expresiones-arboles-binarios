namespace ape_expresionesArbolesBinarios
{
    partial class frmPrincipal
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
            this.txtExpresión = new System.Windows.Forms.TextBox();
            this.btnLeerExpresion = new System.Windows.Forms.Button();
            this.btnInOrder = new System.Windows.Forms.Button();
            this.btnPreOrder = new System.Windows.Forms.Button();
            this.btnPostOrder = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtExpresión
            // 
            this.txtExpresión.Location = new System.Drawing.Point(34, 35);
            this.txtExpresión.Name = "txtExpresión";
            this.txtExpresión.Size = new System.Drawing.Size(179, 20);
            this.txtExpresión.TabIndex = 0;
            this.txtExpresión.Text = "4*2+6/3-8";
            // 
            // btnLeerExpresion
            // 
            this.btnLeerExpresion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeerExpresion.Location = new System.Drawing.Point(219, 33);
            this.btnLeerExpresion.Name = "btnLeerExpresion";
            this.btnLeerExpresion.Size = new System.Drawing.Size(75, 23);
            this.btnLeerExpresion.TabIndex = 1;
            this.btnLeerExpresion.Text = "Leer expresión";
            this.btnLeerExpresion.UseVisualStyleBackColor = true;
            this.btnLeerExpresion.Click += new System.EventHandler(this.btnLeerExpresion_Click);
            // 
            // btnInOrder
            // 
            this.btnInOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInOrder.Location = new System.Drawing.Point(34, 72);
            this.btnInOrder.Name = "btnInOrder";
            this.btnInOrder.Size = new System.Drawing.Size(75, 23);
            this.btnInOrder.TabIndex = 3;
            this.btnInOrder.Text = "InOrder";
            this.btnInOrder.UseVisualStyleBackColor = true;
            this.btnInOrder.Click += new System.EventHandler(this.btnInOrder_Click);
            // 
            // btnPreOrder
            // 
            this.btnPreOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreOrder.Location = new System.Drawing.Point(34, 124);
            this.btnPreOrder.Name = "btnPreOrder";
            this.btnPreOrder.Size = new System.Drawing.Size(75, 23);
            this.btnPreOrder.TabIndex = 4;
            this.btnPreOrder.Text = "PreOrder";
            this.btnPreOrder.UseVisualStyleBackColor = true;
            this.btnPreOrder.Click += new System.EventHandler(this.btnPreOrder_Click);
            // 
            // btnPostOrder
            // 
            this.btnPostOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPostOrder.Location = new System.Drawing.Point(34, 176);
            this.btnPostOrder.Name = "btnPostOrder";
            this.btnPostOrder.Size = new System.Drawing.Size(75, 23);
            this.btnPostOrder.TabIndex = 5;
            this.btnPostOrder.Text = "PostOrder";
            this.btnPostOrder.UseVisualStyleBackColor = true;
            this.btnPostOrder.Click += new System.EventHandler(this.btnPostOrder_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(127, 72);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultado.Size = new System.Drawing.Size(167, 127);
            this.txtResultado.TabIndex = 6;
            // 
            // btnMostrar
            // 
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrar.Location = new System.Drawing.Point(219, 205);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 7;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(329, 261);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnPostOrder);
            this.Controls.Add(this.btnPreOrder);
            this.Controls.Add(this.btnInOrder);
            this.Controls.Add(this.btnLeerExpresion);
            this.Controls.Add(this.txtExpresión);
            this.Name = "frmPrincipal";
            this.Text = "Expresiones. Árboles Binarios.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtExpresión;
        private System.Windows.Forms.Button btnLeerExpresion;
        private System.Windows.Forms.Button btnInOrder;
        private System.Windows.Forms.Button btnPreOrder;
        private System.Windows.Forms.Button btnPostOrder;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnMostrar;
    }
}

