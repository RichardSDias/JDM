namespace JogoMemoria
{
    partial class FormInicial
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
            this.btnMenina = new System.Windows.Forms.Button();
            this.btnMenino = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMenina
            // 
            this.btnMenina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMenina.BackgroundImage = global::JogoMemoria.Properties.Resources.menina;
            this.btnMenina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenina.Location = new System.Drawing.Point(22, 128);
            this.btnMenina.Name = "btnMenina";
            this.btnMenina.Size = new System.Drawing.Size(439, 582);
            this.btnMenina.TabIndex = 0;
            this.btnMenina.Tag = "MENINA";
            this.btnMenina.UseVisualStyleBackColor = true;
            this.btnMenina.Click += new System.EventHandler(this.btnGenero_Click);
            this.btnMenina.MouseHover += new System.EventHandler(this.btnGenero_MouseHover);
            // 
            // btnMenino
            // 
            this.btnMenino.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenino.BackgroundImage = global::JogoMemoria.Properties.Resources.menino;
            this.btnMenino.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenino.Location = new System.Drawing.Point(554, 128);
            this.btnMenino.Name = "btnMenino";
            this.btnMenino.Size = new System.Drawing.Size(439, 582);
            this.btnMenino.TabIndex = 1;
            this.btnMenino.Tag = "MENINO";
            this.btnMenino.UseVisualStyleBackColor = true;
            this.btnMenino.Click += new System.EventHandler(this.btnGenero_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(981, 94);
            this.label1.TabIndex = 2;
            this.label1.Text = "Jogo da memória";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1015, 734);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMenino);
            this.Controls.Add(this.btnMenina);
            this.Name = "FormInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo da memória";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMenina;
        private System.Windows.Forms.Button btnMenino;
        private System.Windows.Forms.Label label1;
    }
}

