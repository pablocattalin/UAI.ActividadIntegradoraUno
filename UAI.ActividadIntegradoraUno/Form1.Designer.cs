namespace UAI.ActividadIntegradoraUno
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvPersonas = new System.Windows.Forms.DataGridView();
            this.dGvAutos = new System.Windows.Forms.DataGridView();
            this.dgvAutosPersona = new System.Windows.Forms.DataGridView();
            this.dgvTitularCompleto = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblValuacionAutos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGvAutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutosPersona)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTitularCompleto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPersonas
            // 
            this.dgvPersonas.AllowUserToAddRows = false;
            this.dgvPersonas.AllowUserToDeleteRows = false;
            this.dgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonas.Location = new System.Drawing.Point(37, 69);
            this.dgvPersonas.Name = "dgvPersonas";
            this.dgvPersonas.ReadOnly = true;
            this.dgvPersonas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonas.Size = new System.Drawing.Size(392, 150);
            this.dgvPersonas.TabIndex = 0;
            this.dgvPersonas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.selectedPersona_CellClick);
            // 
            // dGvAutos
            // 
            this.dGvAutos.AllowUserToAddRows = false;
            this.dGvAutos.AllowUserToDeleteRows = false;
            this.dGvAutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGvAutos.Location = new System.Drawing.Point(449, 69);
            this.dGvAutos.Name = "dGvAutos";
            this.dGvAutos.ReadOnly = true;
            this.dGvAutos.Size = new System.Drawing.Size(454, 150);
            this.dGvAutos.TabIndex = 1;
            // 
            // dgvAutosPersona
            // 
            this.dgvAutosPersona.AllowUserToAddRows = false;
            this.dgvAutosPersona.AllowUserToDeleteRows = false;
            this.dgvAutosPersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutosPersona.Location = new System.Drawing.Point(37, 318);
            this.dgvAutosPersona.Name = "dgvAutosPersona";
            this.dgvAutosPersona.ReadOnly = true;
            this.dgvAutosPersona.Size = new System.Drawing.Size(392, 120);
            this.dgvAutosPersona.TabIndex = 2;
            // 
            // dgvTitularCompleto
            // 
            this.dgvTitularCompleto.AllowUserToAddRows = false;
            this.dgvTitularCompleto.AllowUserToDeleteRows = false;
            this.dgvTitularCompleto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTitularCompleto.Location = new System.Drawing.Point(449, 288);
            this.dgvTitularCompleto.Name = "dgvTitularCompleto";
            this.dgvTitularCompleto.ReadOnly = true;
            this.dgvTitularCompleto.Size = new System.Drawing.Size(454, 150);
            this.dgvTitularCompleto.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(37, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 25);
            this.button1.TabIndex = 4;
            this.button1.Text = "Agregar Personas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnClickAgregarPersona);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(507, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 25);
            this.button2.TabIndex = 5;
            this.button2.Text = "Agregar autos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnClickAgregarAuto);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Location = new System.Drawing.Point(161, 38);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 25);
            this.button3.TabIndex = 6;
            this.button3.Text = "Modificar Personas";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnClickModificarPersona);
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.Location = new System.Drawing.Point(619, 40);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 25);
            this.button4.TabIndex = 7;
            this.button4.Text = "Modificar Autos";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnClickModificarAuto);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(37, 230);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(392, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "Asignar auto a titular";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btnAsignarAuto_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(37, 259);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(392, 23);
            this.button6.TabIndex = 9;
            this.button6.Text = "Desasignar auto a titular";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.btnDesasignarTitular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(37, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(610, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Si la patente ya fue agregada o el dni fue agregado, la aplicacion modifica autom" +
    "aticamente los valores ingresados";
            // 
            // lblValuacionAutos
            // 
            this.lblValuacionAutos.AutoSize = true;
            this.lblValuacionAutos.Location = new System.Drawing.Point(37, 288);
            this.lblValuacionAutos.Name = "lblValuacionAutos";
            this.lblValuacionAutos.Size = new System.Drawing.Size(133, 15);
            this.lblValuacionAutos.TabIndex = 11;
            this.lblValuacionAutos.Text = "Valuacion total de autos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 450);
            this.Controls.Add(this.lblValuacionAutos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvTitularCompleto);
            this.Controls.Add(this.dgvAutosPersona);
            this.Controls.Add(this.dGvAutos);
            this.Controls.Add(this.dgvPersonas);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGvAutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutosPersona)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTitularCompleto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvPersonas;
        private DataGridView dGvAutos;
        private DataGridView dgvAutosPersona;
        private DataGridView dataGridView4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private DataGridView dgvTitularCompleto;
        private Button button6;
        private Label label1;
        private Label lblValuacionAutos;
    }
}