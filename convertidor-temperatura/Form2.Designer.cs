namespace convertidor_temperatura
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            btnAcep = new Button();
            txtCen = new TextBox();
            txtfah = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 31);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 0;
            label1.Text = "Grados Centigrados:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 85);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 1;
            label2.Text = "Grados Fahrenheit:";
            // 
            // btnAcep
            // 
            btnAcep.Location = new Point(186, 137);
            btnAcep.Name = "btnAcep";
            btnAcep.Size = new Size(119, 23);
            btnAcep.TabIndex = 2;
            btnAcep.Text = "Aceptar";
            btnAcep.UseVisualStyleBackColor = true;
            btnAcep.Click += btnAcep_Click;
            // 
            // txtCen
            // 
            txtCen.Location = new Point(168, 28);
            txtCen.Name = "txtCen";
            txtCen.Size = new Size(166, 23);
            txtCen.TabIndex = 3;
            txtCen.TextChanged += txtCen_TextChanged;
            txtCen.KeyPress += txtCen_KeyPress;
            // 
            // txtfah
            // 
            txtfah.Location = new Point(168, 77);
            txtfah.Name = "txtfah";
            txtfah.Size = new Size(165, 23);
            txtfah.TabIndex = 4;
            txtfah.KeyPress += txtfah_KeyPress;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 199);
            Controls.Add(txtfah);
            Controls.Add(txtCen);
            Controls.Add(btnAcep);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Conversor de Temperatura";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnAcep;
        private TextBox txtCen;
        private TextBox txtfah;
    }
}