namespace Juego_de_dados
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
            this.lblDado1 = new System.Windows.Forms.Label();
            this.lblDado2 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnJugar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.PicDado2 = new System.Windows.Forms.PictureBox();
            this.PicDado1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicDado2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDado1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDado1
            // 
            this.lblDado1.AutoSize = true;
            this.lblDado1.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDado1.Location = new System.Drawing.Point(12, 163);
            this.lblDado1.Name = "lblDado1";
            this.lblDado1.Size = new System.Drawing.Size(82, 25);
            this.lblDado1.TabIndex = 0;
            this.lblDado1.Text = "DADO 1";
            // 
            // lblDado2
            // 
            this.lblDado2.AutoSize = true;
            this.lblDado2.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDado2.Location = new System.Drawing.Point(239, 163);
            this.lblDado2.Name = "lblDado2";
            this.lblDado2.Size = new System.Drawing.Size(84, 25);
            this.lblDado2.TabIndex = 1;
            this.lblDado2.Text = "DADO 2";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(173, 173);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 25);
            this.lblResultado.TabIndex = 2;
            // 
            // btnJugar
            // 
            this.btnJugar.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnJugar.Location = new System.Drawing.Point(119, 215);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(112, 34);
            this.btnJugar.TabIndex = 3;
            this.btnJugar.Text = "JUGAR";
            this.btnJugar.UseVisualStyleBackColor = true;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.Location = new System.Drawing.Point(79, 258);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(198, 34);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "SALIR DEL JUEGO";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // PicDado2
            // 
            this.PicDado2.Location = new System.Drawing.Point(173, 13);
            this.PicDado2.Name = "PicDado2";
            this.PicDado2.Size = new System.Drawing.Size(150, 147);
            this.PicDado2.TabIndex = 5;
            this.PicDado2.TabStop = false;
            // 
            // PicDado1
            // 
            this.PicDado1.Location = new System.Drawing.Point(12, 13);
            this.PicDado1.Name = "PicDado1";
            this.PicDado1.Size = new System.Drawing.Size(150, 147);
            this.PicDado1.TabIndex = 6;
            this.PicDado1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 305);
            this.Controls.Add(this.PicDado1);
            this.Controls.Add(this.PicDado2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblDado2);
            this.Controls.Add(this.lblDado1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PicDado2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDado1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblDado1;
        private Label lblDado2;
        private Label lblResultado;
        private Button btnJugar;
        private Button btnSalir;
        private PictureBox PicDado2;
        private PictureBox PicDado1;
    }
}