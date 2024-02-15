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
            bottoneAggiungi = new Button();
            bottoneSeleziona = new Button();
            label1 = new Label();
            tabellaFlotte = new DataGridView();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)tabellaFlotte).BeginInit();
            SuspendLayout();
            // 
            // bottoneAggiungi
            // 
            bottoneAggiungi.Location = new Point(587, 71);
            bottoneAggiungi.Name = "Aggiungi Flotta";
            bottoneAggiungi.Size = new Size(201, 29);
            bottoneAggiungi.TabIndex = 0;
            bottoneAggiungi.Text = "Aggiungi Flotta";
            bottoneAggiungi.UseVisualStyleBackColor = true;
            bottoneAggiungi.Click += button1_Click;
            // 
            // bottoneSeleziona
            // 
            bottoneSeleziona.Location = new Point(587, 36);
            bottoneSeleziona.Name = "Seleziona Flotta";
            bottoneSeleziona.Size = new Size(201, 29);
            bottoneSeleziona.TabIndex = 1;
            bottoneSeleziona.Text = "Seleziona Flotta";
            bottoneSeleziona.UseVisualStyleBackColor = true;
            bottoneSeleziona.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Location = new Point(12, 40);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 2;
            label1.Text = "Flotta Corrente";
            label1.Click += label1_Click;
            // 
            // tabellaFlotte
            // 
            tabellaFlotte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabellaFlotte.Location = new Point(12, 106);
            tabellaFlotte.Name = "tabellaFlotte";
            tabellaFlotte.RowHeadersWidth = 51;
            tabellaFlotte.Size = new Size(776, 332);
            tabellaFlotte.TabIndex = 3;
            tabellaFlotte.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(126, 40);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 4;
            // 
            // FleetManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(tabellaFlotte);
            Controls.Add(label1);
            Controls.Add(bottoneSeleziona);
            Controls.Add(bottoneAggiungi);
            Name = "FleetManager";
            Text = "FleetManager";
            Load += FleetManager_Load;
            ((System.ComponentModel.ISupportInitialize)tabellaFlotte).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bottoneAggiungi;
        private Button bottoneSeleziona;
        private Label label1;
        private DataGridView tabellaFlotte;
        private Label label2;
    }
}