namespace PaintText
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Paint = new System.Windows.Forms.Button();
            this.ETXT = new System.Windows.Forms.Button();
            this.Menuuu = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Paint
            // 
            this.Paint.BackColor = System.Drawing.Color.White;
            this.Paint.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Paint.FlatAppearance.BorderSize = 3;
            this.Paint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Paint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Paint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Paint.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Paint.Location = new System.Drawing.Point(410, 184);
            this.Paint.Name = "Paint";
            this.Paint.Size = new System.Drawing.Size(130, 61);
            this.Paint.TabIndex = 1;
            this.Paint.Text = "Paint";
            this.Paint.UseVisualStyleBackColor = false;
            this.Paint.Click += new System.EventHandler(this.PaintClick);
            // 
            // ETXT
            // 
            this.ETXT.BackColor = System.Drawing.Color.White;
            this.ETXT.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ETXT.FlatAppearance.BorderSize = 3;
            this.ETXT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.ETXT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.ETXT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ETXT.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ETXT.Location = new System.Drawing.Point(350, 251);
            this.ETXT.Name = "ETXT";
            this.ETXT.Size = new System.Drawing.Size(240, 64);
            this.ETXT.TabIndex = 2;
            this.ETXT.Text = "Editor de texto";
            this.ETXT.UseVisualStyleBackColor = false;
            this.ETXT.Click += new System.EventHandler(this.ETXT_Click);
            // 
            // Menuuu
            // 
            this.Menuuu.AutoSize = true;
            this.Menuuu.BackColor = System.Drawing.Color.White;
            this.Menuuu.Font = new System.Drawing.Font("Lucida Calligraphy", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Menuuu.Location = new System.Drawing.Point(55, 27);
            this.Menuuu.Name = "Menuuu";
            this.Menuuu.Size = new System.Drawing.Size(309, 60);
            this.Menuuu.TabIndex = 3;
            this.Menuuu.Text = "❤Menú ❤";
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.DarkRed;
            this.Close.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Close.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Close.ForeColor = System.Drawing.Color.White;
            this.Close.Location = new System.Drawing.Point(420, 321);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(107, 39);
            this.Close.TabIndex = 4;
            this.Close.Text = "Cerrar";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(847, 515);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Menuuu);
            this.Controls.Add(this.ETXT);
            this.Controls.Add(this.Paint);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button Paint;
        private Button ETXT;
        private Label Menuuu;
        private Button Close;
    }
}