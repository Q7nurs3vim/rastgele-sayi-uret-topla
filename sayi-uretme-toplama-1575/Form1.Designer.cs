namespace sayi_uretme_toplama_1575
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
            btnTopla = new Button();
            lbSayilar = new ListBox();
            lblToplam = new Label();
            btnUret = new Button();
            SuspendLayout();
            // 
            // btnTopla
            // 
            btnTopla.BackColor = Color.DarkCyan;
            btnTopla.Location = new Point(199, 271);
            btnTopla.Name = "btnTopla";
            btnTopla.Size = new Size(173, 48);
            btnTopla.TabIndex = 0;
            btnTopla.Text = "TOPLA";
            btnTopla.UseVisualStyleBackColor = false;
            btnTopla.Click += btnTopla_Click;
            // 
            // lbSayilar
            // 
            lbSayilar.FormattingEnabled = true;
            lbSayilar.ItemHeight = 20;
            lbSayilar.Location = new Point(12, 70);
            lbSayilar.Name = "lbSayilar";
            lbSayilar.Size = new Size(173, 304);
            lbSayilar.TabIndex = 1;
            // 
            // lblToplam
            // 
            lblToplam.AutoSize = true;
            lblToplam.Location = new Point(199, 145);
            lblToplam.Name = "lblToplam";
            lblToplam.Size = new Size(72, 20);
            lblToplam.TabIndex = 2;
            lblToplam.Text = "TOPLAM :";
            // 
            // btnUret
            // 
            btnUret.BackColor = Color.CornflowerBlue;
            btnUret.Location = new Point(12, 12);
            btnUret.Name = "btnUret";
            btnUret.Size = new Size(173, 39);
            btnUret.TabIndex = 3;
            btnUret.Text = "ÜRET";
            btnUret.UseVisualStyleBackColor = false;
            btnUret.Click += btnUret_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Coral;
            ClientSize = new Size(389, 390);
            Controls.Add(btnUret);
            Controls.Add(lblToplam);
            Controls.Add(lbSayilar);
            Controls.Add(btnTopla);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTopla;
        private ListBox lbSayilar;
        private Label lblToplam;
        private Button btnUret;
    }
}