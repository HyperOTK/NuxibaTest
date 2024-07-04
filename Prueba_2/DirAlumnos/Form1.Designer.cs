namespace DirAlumnos
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
            this.btAgregar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCSV = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txID = new System.Windows.Forms.TextBox();
            this.txNombre = new System.Windows.Forms.TextBox();
            this.txPaterno = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.txMaterno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txSueldo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txFecha = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txLogin = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(15, 386);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(75, 23);
            this.btAgregar.TabIndex = 0;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(110, 415);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCSV
            // 
            this.btnCSV.Location = new System.Drawing.Point(15, 415);
            this.btnCSV.Name = "btnCSV";
            this.btnCSV.Size = new System.Drawing.Size(75, 23);
            this.btnCSV.TabIndex = 2;
            this.btnCSV.Text = "Generar CSV";
            this.btnCSV.UseVisualStyleBackColor = true;
            this.btnCSV.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre(s)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Paterno";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txID
            // 
            this.txID.Enabled = false;
            this.txID.Location = new System.Drawing.Point(38, 39);
            this.txID.Name = "txID";
            this.txID.Size = new System.Drawing.Size(100, 20);
            this.txID.TabIndex = 6;
            // 
            // txNombre
            // 
            this.txNombre.Location = new System.Drawing.Point(38, 138);
            this.txNombre.Name = "txNombre";
            this.txNombre.Size = new System.Drawing.Size(100, 20);
            this.txNombre.TabIndex = 7;
            // 
            // txPaterno
            // 
            this.txPaterno.Location = new System.Drawing.Point(38, 193);
            this.txPaterno.Name = "txPaterno";
            this.txPaterno.Size = new System.Drawing.Size(100, 20);
            this.txPaterno.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(201, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(587, 399);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(110, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Top 10";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txMaterno
            // 
            this.txMaterno.Location = new System.Drawing.Point(38, 242);
            this.txMaterno.Name = "txMaterno";
            this.txMaterno.Size = new System.Drawing.Size(100, 20);
            this.txMaterno.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(35, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Materno";
            // 
            // txSueldo
            // 
            this.txSueldo.Location = new System.Drawing.Point(38, 293);
            this.txSueldo.Name = "txSueldo";
            this.txSueldo.Size = new System.Drawing.Size(100, 20);
            this.txSueldo.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(35, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Sueldo";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txFecha
            // 
            this.txFecha.Location = new System.Drawing.Point(44, 342);
            this.txFecha.Name = "txFecha";
            this.txFecha.Size = new System.Drawing.Size(100, 20);
            this.txFecha.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(41, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Fecha de Ingreso";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txLogin
            // 
            this.txLogin.Location = new System.Drawing.Point(38, 87);
            this.txLogin.Name = "txLogin";
            this.txLogin.Size = new System.Drawing.Size(100, 20);
            this.txLogin.TabIndex = 18;
            this.txLogin.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Login";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txLogin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txFecha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txSueldo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txMaterno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txPaterno);
            this.Controls.Add(this.txNombre);
            this.Controls.Add(this.txID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCSV);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btAgregar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txID;
        private System.Windows.Forms.TextBox txNombre;
        private System.Windows.Forms.TextBox txPaterno;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txMaterno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txSueldo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txFecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txLogin;
        private System.Windows.Forms.Label label7;
    }
}

