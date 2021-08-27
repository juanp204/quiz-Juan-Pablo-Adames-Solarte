
namespace home
{
    partial class home
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
            this.btnguardar = new System.Windows.Forms.Button();
            this.rtxtResults = new System.Windows.Forms.RichTextBox();
            this.btnreportar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.edad15 = new System.Windows.Forms.RadioButton();
            this.edad17 = new System.Windows.Forms.RadioButton();
            this.edad18 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnguardar
            // 
            this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.Location = new System.Drawing.Point(45, 445);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(112, 44);
            this.btnguardar.TabIndex = 0;
            this.btnguardar.Text = "guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // rtxtResults
            // 
            this.rtxtResults.Location = new System.Drawing.Point(472, 44);
            this.rtxtResults.Name = "rtxtResults";
            this.rtxtResults.Size = new System.Drawing.Size(317, 368);
            this.rtxtResults.TabIndex = 2;
            this.rtxtResults.Text = "";
            // 
            // btnreportar
            // 
            this.btnreportar.Location = new System.Drawing.Point(803, 481);
            this.btnreportar.Name = "btnreportar";
            this.btnreportar.Size = new System.Drawing.Size(79, 26);
            this.btnreportar.TabIndex = 3;
            this.btnreportar.Text = "reportar";
            this.btnreportar.UseVisualStyleBackColor = true;
            this.btnreportar.Click += new System.EventHandler(this.btnreportar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(42, 65);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(302, 22);
            this.txtnombre.TabIndex = 5;
            // 
            // dtpfecha
            // 
            this.dtpfecha.Location = new System.Drawing.Point(42, 280);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(200, 22);
            this.dtpfecha.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Edad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Fecha";
            // 
            // edad15
            // 
            this.edad15.AutoSize = true;
            this.edad15.Location = new System.Drawing.Point(42, 143);
            this.edad15.Name = "edad15";
            this.edad15.Size = new System.Drawing.Size(85, 21);
            this.edad15.TabIndex = 12;
            this.edad15.Text = "edad<15";
            this.edad15.UseVisualStyleBackColor = true;
            this.edad15.CheckedChanged += new System.EventHandler(this.edad15_CheckedChanged);
            // 
            // edad17
            // 
            this.edad17.AutoSize = true;
            this.edad17.Location = new System.Drawing.Point(42, 171);
            this.edad17.Name = "edad17";
            this.edad17.Size = new System.Drawing.Size(109, 21);
            this.edad17.TabIndex = 13;
            this.edad17.TabStop = true;
            this.edad17.Text = "14>edad<18";
            this.edad17.UseVisualStyleBackColor = true;
            this.edad17.CheckedChanged += new System.EventHandler(this.edad17_CheckedChanged);
            // 
            // edad18
            // 
            this.edad18.AutoSize = true;
            this.edad18.Location = new System.Drawing.Point(42, 199);
            this.edad18.Name = "edad18";
            this.edad18.Size = new System.Drawing.Size(85, 21);
            this.edad18.TabIndex = 14;
            this.edad18.TabStop = true;
            this.edad18.Text = "17<edad";
            this.edad18.UseVisualStyleBackColor = true;
            this.edad18.CheckedChanged += new System.EventHandler(this.edad18_CheckedChanged);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 519);
            this.Controls.Add(this.edad18);
            this.Controls.Add(this.edad17);
            this.Controls.Add(this.edad15);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpfecha);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnreportar);
            this.Controls.Add(this.rtxtResults);
            this.Controls.Add(this.btnguardar);
            this.Name = "home";
            this.Text = "home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.RichTextBox rtxtResults;
        private System.Windows.Forms.Button btnreportar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.DateTimePicker dtpfecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton edad15;
        private System.Windows.Forms.RadioButton edad17;
        private System.Windows.Forms.RadioButton edad18;
    }
}

