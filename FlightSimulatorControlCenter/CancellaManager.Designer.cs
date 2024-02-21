namespace FlightSimulatorControlCenter
{
    partial class CancellaManager
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
            btnSi = new Button();
            btnNo = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 12F);
            label1.Location = new Point(27, 108);
            label1.Name = "label1";
            label1.Size = new Size(471, 28);
            label1.TabIndex = 0;
            label1.Text = "SEI SICURISSIMO DI CANCELLARE L'AEREO?";
            // 
            // btnSi
            // 
            btnSi.Location = new Point(109, 226);
            btnSi.Name = "btnSi";
            btnSi.Size = new Size(94, 29);
            btnSi.TabIndex = 1;
            btnSi.Text = "SI";
            btnSi.UseVisualStyleBackColor = true;
            btnSi.Click += btnSi_Click;
            // 
            // btnNo
            // 
            btnNo.Location = new Point(304, 226);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(94, 29);
            btnNo.TabIndex = 2;
            btnNo.Text = "No";
            btnNo.UseVisualStyleBackColor = true;
            btnNo.Click += btnNo_Click;
            // 
            // CancellaManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 329);
            Controls.Add(btnNo);
            Controls.Add(btnSi);
            Controls.Add(label1);
            Name = "CancellaManager";
            Text = "CancellaManager";
            Load += CancellaManager_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnSi;
        private Button btnNo;
    }
}