namespace FlightSimulatorControlCenter
{
    partial class FleetManager
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
            tabellaFlotte = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textboxnameflotte = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)tabellaFlotte).BeginInit();
            SuspendLayout();
            // 
            // tabellaFlotte
            // 
            tabellaFlotte.AllowUserToAddRows = false;
            tabellaFlotte.AllowUserToDeleteRows = false;
            tabellaFlotte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabellaFlotte.Location = new Point(14, 227);
            tabellaFlotte.Margin = new Padding(3, 4, 3, 4);
            tabellaFlotte.Name = "tabellaFlotte";
            tabellaFlotte.RowHeadersWidth = 51;
            tabellaFlotte.Size = new Size(887, 357);
            tabellaFlotte.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(145, 17);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(153, 57);
            button1.TabIndex = 1;
            button1.Text = "Aggiungi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(747, 81);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(153, 56);
            button2.TabIndex = 2;
            button2.Text = "Seleziona";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(747, 145);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(151, 56);
            button3.TabIndex = 3;
            button3.Text = "Aggiorna";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textboxnameflotte
            // 
            textboxnameflotte.Location = new Point(14, 32);
            textboxnameflotte.Name = "textboxnameflotte";
            textboxnameflotte.Size = new Size(125, 27);
            textboxnameflotte.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 9);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 5;
            label1.Text = "Inserisci nome";
            // 
            // FleetManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(label1);
            Controls.Add(textboxnameflotte);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(tabellaFlotte);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FleetManager";
            Text = "FleetManager";
            ((System.ComponentModel.ISupportInitialize)tabellaFlotte).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tabellaFlotte;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textboxnameflotte;
        private Label label1;
    }
}