﻿namespace FlightSimulatorControlCenter
{
    partial class AggiungiFlotta
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
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            annullaButton = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(105, 37);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(249, 27);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 41);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 1;
            label1.Text = "Nome flotta:";
            // 
            // button1
            // 
            button1.Location = new Point(27, 140);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(195, 63);
            button1.TabIndex = 2;
            button1.Text = "Crea flotta";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // annullaButton
            // 
            annullaButton.Location = new Point(349, 140);
            annullaButton.Margin = new Padding(3, 4, 3, 4);
            annullaButton.Name = "annullaButton";
            annullaButton.Size = new Size(187, 63);
            annullaButton.TabIndex = 3;
            annullaButton.Text = "Annulla";
            annullaButton.UseVisualStyleBackColor = true;
            annullaButton.Click += annullaButton_Click;
            // 
            // AggiungiFlotta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 236);
            Controls.Add(annullaButton);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AggiungiFlotta";
            Text = "AggiungiFlotta";
            Load += AggiungiFlotta_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private Button annullaButton;
    }
}