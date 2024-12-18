namespace winform_app
{
    partial class FormCategoria
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.listaCategoria = new System.Windows.Forms.ListView();
            this.LblCategoria = new System.Windows.Forms.Label();
            this.textCategoria = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(394, 94);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(115, 28);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(394, 128);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(115, 29);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Modificar";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(394, 163);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(112, 29);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Eliminar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.button1_Click);
            // 
            // listaCategoria
            // 
            this.listaCategoria.HideSelection = false;
            this.listaCategoria.Location = new System.Drawing.Point(254, 227);
            this.listaCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.listaCategoria.Name = "listaCategoria";
            this.listaCategoria.Size = new System.Drawing.Size(415, 164);
            this.listaCategoria.TabIndex = 2;
            this.listaCategoria.UseCompatibleStateImageBehavior = false;
            // 
            // LblCategoria
            // 
            this.LblCategoria.AutoSize = true;
            this.LblCategoria.Location = new System.Drawing.Point(251, 49);
            this.LblCategoria.Name = "LblCategoria";
            this.LblCategoria.Size = new System.Drawing.Size(52, 13);
            this.LblCategoria.TabIndex = 3;
            this.LblCategoria.Text = "Categoria";
            // 
            // textCategoria
            // 
            this.textCategoria.Location = new System.Drawing.Point(324, 49);
            this.textCategoria.Name = "textCategoria";
            this.textCategoria.Size = new System.Drawing.Size(222, 20);
            this.textCategoria.TabIndex = 4;
            this.textCategoria.TextChanged += new System.EventHandler(this.button1_Click);
            // 
            // FormCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textCategoria);
            this.Controls.Add(this.LblCategoria);
            this.Controls.Add(this.listaCategoria);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Name = "FormCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCategoria";
            this.Load += new System.EventHandler(this.FormCategoria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ListView listaCategoria;
        private System.Windows.Forms.Label LblCategoria;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textCategoria;
    }
}