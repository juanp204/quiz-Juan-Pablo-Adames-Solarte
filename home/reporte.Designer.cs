
namespace home
{
    partial class reporte
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
            this.rtbreporte = new System.Windows.Forms.RichTextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnenviar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btncerrar = new System.Windows.Forms.Button();
            this.txtrepenv = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtbreporte
            // 
            this.rtbreporte.Location = new System.Drawing.Point(32, 156);
            this.rtbreporte.Name = "rtbreporte";
            this.rtbreporte.Size = new System.Drawing.Size(349, 143);
            this.rtbreporte.TabIndex = 0;
            this.rtbreporte.Text = "";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(32, 68);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(302, 22);
            this.txtnombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // btnenviar
            // 
            this.btnenviar.Location = new System.Drawing.Point(35, 357);
            this.btnenviar.Name = "btnenviar";
            this.btnenviar.Size = new System.Drawing.Size(114, 38);
            this.btnenviar.TabIndex = 3;
            this.btnenviar.Text = "Enviar";
            this.btnenviar.UseVisualStyleBackColor = true;
            this.btnenviar.Click += new System.EventHandler(this.btnenviar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Reporte";
            // 
            // btncerrar
            // 
            this.btncerrar.Location = new System.Drawing.Point(666, 390);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(106, 38);
            this.btncerrar.TabIndex = 5;
            this.btncerrar.Text = "Cerrar";
            this.btncerrar.UseVisualStyleBackColor = true;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // txtrepenv
            // 
            this.txtrepenv.AutoSize = true;
            this.txtrepenv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtrepenv.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrepenv.Location = new System.Drawing.Point(158, 172);
            this.txtrepenv.Name = "txtrepenv";
            this.txtrepenv.Size = new System.Drawing.Size(464, 46);
            this.txtrepenv.TabIndex = 6;
            this.txtrepenv.Text = "Su reporte se a enviado";
            this.txtrepenv.Visible = false;
            // 
            // reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtrepenv);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnenviar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.rtbreporte);
            this.Name = "reporte";
            this.Text = "reporte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbreporte;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnenviar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.Label txtrepenv;
    }
}