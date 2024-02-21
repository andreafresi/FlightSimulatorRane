namespace FlightSimulatorControlCenter
{
    partial class CreazioneAereo
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
            label3 = new Label();
            codiceText = new TextBox();
            coloreText = new TextBox();
            numPostiText = new TextBox();
            salvaButton = new Button();
            annullaButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 28);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 0;
            label1.Text = "Codice:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 76);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 1;
            label2.Text = "Colore:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 135);
            label3.Name = "label3";
            label3.Size = new Size(120, 20);
            label3.TabIndex = 2;
            label3.Text = "Numero di posti:";
            // 
            // codiceText
            // 
            codiceText.Location = new Point(130, 17);
            codiceText.Margin = new Padding(3, 4, 3, 4);
            codiceText.Name = "codiceText";
            codiceText.Size = new Size(247, 27);
            codiceText.TabIndex = 3;
            // 
            // coloreText
            // 
            coloreText.Location = new Point(130, 65);
            coloreText.Margin = new Padding(3, 4, 3, 4);
            coloreText.Name = "coloreText";
            coloreText.Size = new Size(247, 27);
            coloreText.TabIndex = 4;
            // 
            // numPostiText
            // 
            numPostiText.Location = new Point(130, 124);
            numPostiText.Margin = new Padding(3, 4, 3, 4);
            numPostiText.Name = "numPostiText";
            numPostiText.Size = new Size(247, 27);
            numPostiText.TabIndex = 5;
            // 
            // salvaButton
            // 
            salvaButton.Location = new Point(14, 215);
            salvaButton.Margin = new Padding(3, 4, 3, 4);
            salvaButton.Name = "salvaButton";
            salvaButton.Size = new Size(192, 69);
            salvaButton.TabIndex = 6;
            salvaButton.Text = "Salva";
            salvaButton.UseVisualStyleBackColor = true;
            salvaButton.Click += salvaButton_Click;
            // 
            // annullaButton
            // 
            annullaButton.Location = new Point(315, 215);
            annullaButton.Margin = new Padding(3, 4, 3, 4);
            annullaButton.Name = "annullaButton";
            annullaButton.Size = new Size(195, 69);
            annullaButton.TabIndex = 7;
            annullaButton.Text = "Annulla";
            annullaButton.UseVisualStyleBackColor = true;
            annullaButton.Click += annullaButton_Click;
            // 
            // CreazioneAereo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 300);
            Controls.Add(annullaButton);
            Controls.Add(salvaButton);
            Controls.Add(numPostiText);
            Controls.Add(coloreText);
            Controls.Add(codiceText);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CreazioneAereo";
            Text = "CreazioneAereo";
            Load += CreazioneAereo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox codiceText;
        private TextBox coloreText;
        private TextBox numPostiText;
        private Button salvaButton;
        private Button annullaButton;
    }
}