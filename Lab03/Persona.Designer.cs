
namespace Lab03
{
    partial class Persona
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
            this.btnListar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.btnBuscar2 = new System.Windows.Forms.Button();
            this.hPersonId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hHireDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hEnrollmentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(12, 26);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 0;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.CausesValidation = false;
            this.txtNombre.Location = new System.Drawing.Point(110, 26);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(196, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(329, 26);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvListado
            // 
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hPersonId,
            this.hFirstName,
            this.hLastName,
            this.hHireDate,
            this.hEnrollmentDate});
            this.dgvListado.Location = new System.Drawing.Point(12, 95);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.Size = new System.Drawing.Size(392, 329);
            this.dgvListado.TabIndex = 3;
            // 
            // btnBuscar2
            // 
            this.btnBuscar2.Location = new System.Drawing.Point(329, 56);
            this.btnBuscar2.Name = "btnBuscar2";
            this.btnBuscar2.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar2.TabIndex = 4;
            this.btnBuscar2.Text = "Buscar 2";
            this.btnBuscar2.UseVisualStyleBackColor = true;
            this.btnBuscar2.Click += new System.EventHandler(this.btnBuscar2_Click);
            // 
            // hPersonId
            // 
            this.hPersonId.HeaderText = "PersonId";
            this.hPersonId.Name = "hPersonId";
            // 
            // hFirstName
            // 
            this.hFirstName.HeaderText = "FirstName";
            this.hFirstName.Name = "hFirstName";
            // 
            // hLastName
            // 
            this.hLastName.HeaderText = "LastName";
            this.hLastName.Name = "hLastName";
            // 
            // hHireDate
            // 
            this.hHireDate.HeaderText = "HireDate";
            this.hHireDate.Name = "hHireDate";
            // 
            // hEnrollmentDate
            // 
            this.hEnrollmentDate.HeaderText = "EnrollmentDate";
            this.hEnrollmentDate.Name = "hEnrollmentDate";
            // 
            // Persona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 450);
            this.Controls.Add(this.btnBuscar2);
            this.Controls.Add(this.dgvListado);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnListar);
            this.Name = "Persona";
            this.Text = "Persona";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.Button btnBuscar2;
        private System.Windows.Forms.DataGridViewTextBoxColumn hPersonId;
        private System.Windows.Forms.DataGridViewTextBoxColumn hFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn hLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn hHireDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn hEnrollmentDate;
    }
}