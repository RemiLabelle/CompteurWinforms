using System.Diagnostics;

namespace WinFormsApp1
{
    partial class RemiLabelle
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
            checkBoxActiverEdition = new CheckBox();
            groupBox1 = new GroupBox();
            radioButton1000 = new RadioButton();
            radioButton1 = new RadioButton();
            radioButton10 = new RadioButton();
            radioButton100 = new RadioButton();
            comboBoxCouleur = new ComboBox();
            labelCouleur = new Label();
            textBoxLog = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(69, 88);
            label1.Name = "label1";
            label1.Size = new Size(117, 30);
            label1.TabIndex = 0;
            label1.Text = "Compteur";
            // 
            // textBoxCompteur
            // 
            textBoxCompteur.Font = new Font("Segoe UI", 12F);
            textBoxCompteur.Location = new Point(86, 134);
            textBoxCompteur.Name = "textBoxCompteur";
            textBoxCompteur.Size = new Size(100, 29);
            textBoxCompteur.TabIndex = 1;
            textBoxCompteur.Text = "0";
            textBoxCompteur.TextAlign = HorizontalAlignment.Center;
            textBoxCompteur.KeyPress += textBoxCompteur_KeyPress;
            // 
            // buttonPlus
            // 
            buttonPlus.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            buttonPlus.Location = new Point(53, 135);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(27, 27);
            buttonPlus.TabIndex = 2;
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = true;
            buttonPlus.Click += buttonPlus_Click;
            // 
            // buttonMoins
            // 
            buttonMoins.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            buttonMoins.Location = new Point(192, 135);
            buttonMoins.Name = "buttonMoins";
            buttonMoins.Size = new Size(27, 27);
            buttonMoins.TabIndex = 3;
            buttonMoins.Text = "-";
            buttonMoins.UseVisualStyleBackColor = true;
            buttonMoins.Click += buttonMoins_Click;
            // 
            // buttonReset
            // 
            buttonReset.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            buttonReset.Location = new Point(192, 168);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(27, 27);
            buttonReset.TabIndex = 4;
            buttonReset.Text = "0";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // checkBoxActiverEdition
            // 
            checkBoxActiverEdition.AutoSize = true;
            checkBoxActiverEdition.Location = new Point(59, 177);
            checkBoxActiverEdition.Name = "checkBoxActiverEdition";
            checkBoxActiverEdition.Size = new Size(103, 19);
            checkBoxActiverEdition.TabIndex = 5;
            checkBoxActiverEdition.Text = "Activer Edition";
            checkBoxActiverEdition.UseVisualStyleBackColor = true;
            checkBoxActiverEdition.CheckedChanged += checkBoxActiverEdition_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton1000);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton10);
            groupBox1.Controls.Add(radioButton100);
            groupBox1.Location = new Point(53, 202);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 48);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Multiplicateur";
            // 
            // radioButton1000
            // 
            radioButton1000.AutoSize = true;
            radioButton1000.Location = new Point(144, 22);
            radioButton1000.Name = "radioButton1000";
            radioButton1000.Size = new Size(49, 19);
            radioButton1000.TabIndex = 3;
            radioButton1000.Text = "1000";
            radioButton1000.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(6, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(31, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            radioButton10.AutoSize = true;
            radioButton10.Location = new Point(46, 22);
            radioButton10.Name = "radioButton10";
            radioButton10.Size = new Size(37, 19);
            radioButton10.TabIndex = 1;
            radioButton10.Text = "10";
            radioButton10.UseVisualStyleBackColor = true;
            // 
            // radioButton100
            // 
            radioButton100.AutoSize = true;
            radioButton100.Location = new Point(92, 22);
            radioButton100.Name = "radioButton100";
            radioButton100.Size = new Size(43, 19);
            radioButton100.TabIndex = 2;
            radioButton100.Text = "100";
            radioButton100.UseVisualStyleBackColor = true;
            // 
            // comboBoxCouleur
            // 
            comboBoxCouleur.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCouleur.FormattingEnabled = true;
            comboBoxCouleur.Items.AddRange(new object[] { "Noir", "Rouge", "Vert", "Bleu", "Magenta" });
            comboBoxCouleur.Location = new Point(114, 269);
            comboBoxCouleur.Name = "comboBoxCouleur";
            comboBoxCouleur.Size = new Size(121, 23);
            comboBoxCouleur.TabIndex = 7;
            comboBoxCouleur.SelectedIndexChanged += comboBoxCouleur_SelectedIndexChanged;
            // 
            // labelCouleur
            // 
            labelCouleur.AutoSize = true;
            labelCouleur.Location = new Point(53, 272);
            labelCouleur.Name = "labelCouleur";
            labelCouleur.Size = new Size(55, 15);
            labelCouleur.TabIndex = 8;
            labelCouleur.Text = "Couleur :";
            // 
            // textBoxLog
            // 
            textBoxLog.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxLog.Location = new Point(59, 314);
            textBoxLog.Multiline = true;
            textBoxLog.Name = "textBoxLog";
            textBoxLog.ReadOnly = true;
            textBoxLog.ScrollBars = ScrollBars.Vertical;
            textBoxLog.Size = new Size(166, 157);
            textBoxLog.TabIndex = 9;
            textBoxLog.DoubleClick += textBoxLog_DoubleClick;
            // 
            // RemiLabelle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 561);
            Controls.Add(textBoxLog);
            Controls.Add(labelCouleur);
            Controls.Add(comboBoxCouleur);
            Controls.Add(groupBox1);
            Controls.Add(checkBoxActiverEdition);
            Controls.Add(buttonReset);
            Controls.Add(buttonMoins);
            Controls.Add(buttonPlus);
            Controls.Add(textBoxCompteur);
            Controls.Add(label1);
            Name = "RemiLabelle";
            Text = "RemiLabelle";
            FormClosed += RemiLabelle_FormClosed;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxCompteur;
        private Button buttonPlus;
        private Button buttonMoins;
        private Button buttonReset;
        private CheckBox checkBoxActiverEdition;
        private GroupBox groupBox1;
        private RadioButton radioButton1000;
        private RadioButton radioButton1;
        private RadioButton radioButton10;
        private RadioButton radioButton100;
        private ComboBox comboBoxCouleur;
        private Label labelCouleur;
        private TextBox textBoxLog;
    }
}
