namespace winform_app
{
    partial class Marca
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.textMarca = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.listaMarca = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(115, 98);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(114, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(65, 53);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(37, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Marca";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // textMarca
            // 
            this.textMarca.Location = new System.Drawing.Point(115, 53);
            this.textMarca.Name = "textMarca";
            this.textMarca.Size = new System.Drawing.Size(100, 20);
            this.textMarca.TabIndex = 6;
            this.textMarca.TextChanged += new System.EventHandler(this.textMarca_TextChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(115, 127);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(114, 20);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Modificar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(115, 153);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(114, 21);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // listaMarca
            // 
            this.listaMarca.HideSelection = false;
            this.listaMarca.Location = new System.Drawing.Point(12, 202);
            this.listaMarca.Name = "listaMarca";
            this.listaMarca.Size = new System.Drawing.Size(427, 133);
            this.listaMarca.TabIndex = 9;
            this.listaMarca.UseCompatibleStateImageBehavior = false;
            this.listaMarca.SelectedIndexChanged += new System.EventHandler(this.listaMarca_SelectedIndexChanged);
            // 
            // Marca
            // 
            this.ClientSize = new System.Drawing.Size(496, 373);
            this.Controls.Add(this.listaMarca);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.textMarca);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnAdd);
            this.Name = "Marca";
            this.Text = "Marca";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox textMarca;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListView listaMarca;
    }
}

