namespace _2A6_Winforms_2024
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
            label1 = new Label();
            textBoxCompteur = new TextBox();
            buttonPlus = new Button();
            buttonMoins = new Button();
            buttonReset = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(74, 70);
            label1.Name = "label1";
            label1.Size = new Size(117, 30);
            label1.TabIndex = 0;
            label1.Text = "Compteur";
            label1.Click += label1_Click;
            // 
            // textBoxCompteur
            // 
            textBoxCompteur.Font = new Font("Segoe UI", 12F);
            textBoxCompteur.Location = new Point(91, 116);
            textBoxCompteur.Name = "textBoxCompteur";
            textBoxCompteur.Size = new Size(100, 29);
            textBoxCompteur.TabIndex = 1;
            textBoxCompteur.Text = "0";
            textBoxCompteur.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonPlus
            // 
            buttonPlus.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            buttonPlus.Location = new Point(197, 120);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(26, 23);
            buttonPlus.TabIndex = 2;
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = true;
            buttonPlus.Click += button1_Click;
            // 
            // buttonMoins
            // 
            buttonMoins.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            buttonMoins.Location = new Point(59, 120);
            buttonMoins.Name = "buttonMoins";
            buttonMoins.Size = new Size(26, 23);
            buttonMoins.TabIndex = 3;
            buttonMoins.Text = "-";
            buttonMoins.UseVisualStyleBackColor = true;
            buttonMoins.Click += buttonMoins_Click;
            // 
            // buttonReset
            // 
            buttonReset.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            buttonReset.Location = new Point(59, 151);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(26, 23);
            buttonReset.TabIndex = 4;
            buttonReset.Text = "0";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 561);
            Controls.Add(buttonReset);
            Controls.Add(buttonMoins);
            Controls.Add(buttonPlus);
            Controls.Add(textBoxCompteur);
            Controls.Add(label1);
            Name = "Form1";
            Text = "RémiLabelle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxCompteur;
        private Button buttonPlus;
        private Button buttonMoins;
        private Button buttonReset;
    }
}
