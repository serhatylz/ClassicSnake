namespace Yılanoyunu
{
    partial class YılanOyunu
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            pn_panel = new Panel();
            label3 = new Label();
            lb_sıfır = new Label();
            lb_basla = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            pn_panel.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 40F);
            label1.Location = new Point(669, 12);
            label1.Name = "label1";
            label1.Size = new Size(213, 89);
            label1.TabIndex = 0;
            label1.Text = "PUAN";
            label1.Click += label1_Click;
            // 
            // pn_panel
            // 
            pn_panel.BackColor = SystemColors.Control;
            pn_panel.Controls.Add(label3);
            pn_panel.Location = new Point(12, 12);
            pn_panel.Name = "pn_panel";
            pn_panel.Size = new Size(600, 600);
            pn_panel.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Brown;
            label3.Font = new Font("Segoe UI", 40F);
            label3.Location = new Point(134, 211);
            label3.Name = "label3";
            label3.Size = new Size(0, 89);
            label3.TabIndex = 4;
            label3.Visible = false;
            label3.Click += label3_Click;
            // 
            // lb_sıfır
            // 
            lb_sıfır.AutoSize = true;
            lb_sıfır.Font = new Font("Segoe UI", 40F);
            lb_sıfır.Location = new Point(738, 101);
            lb_sıfır.Name = "lb_sıfır";
            lb_sıfır.Size = new Size(74, 89);
            lb_sıfır.TabIndex = 2;
            lb_sıfır.Text = "0";
            // 
            // lb_basla
            // 
            lb_basla.AutoSize = true;
            lb_basla.BackColor = Color.Brown;
            lb_basla.Font = new Font("Segoe UI", 40F);
            lb_basla.Location = new Point(659, 223);
            lb_basla.Name = "lb_basla";
            lb_basla.Size = new Size(232, 89);
            lb_basla.TabIndex = 10;
            lb_basla.Text = "BAŞLA";
            lb_basla.Click += lb_basla_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // YılanOyunu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(894, 653);
            Controls.Add(lb_basla);
            Controls.Add(lb_sıfır);
            Controls.Add(pn_panel);
            Controls.Add(label1);
            Name = "YılanOyunu";
            Text = "Form1";
            KeyDown += YılanOyunu_KeyDown;
            pn_panel.ResumeLayout(false);
            pn_panel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel pn_panel;
        private Label lb_sıfır;
        private Label lb_basla;
        private Label label3;
        private System.Windows.Forms.Timer timer1;
    }
}
