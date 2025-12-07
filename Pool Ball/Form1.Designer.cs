namespace Pool_Ball
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ctrlBoolTable1 = new ctrlBoolTable();
            ctrlBoolTable2 = new ctrlBoolTable();
            ctrlBoolTable4 = new ctrlBoolTable();
            ctrlBoolTable3 = new ctrlBoolTable();
            SuspendLayout();
            // 
            // ctrlBoolTable1
            // 
            ctrlBoolTable1.BackColor = Color.Black;
            ctrlBoolTable1.HourlyCash = 20;
            ctrlBoolTable1.Location = new Point(6, 3);
            ctrlBoolTable1.Name = "ctrlBoolTable1";
            ctrlBoolTable1.PlayerCount = 1;
            ctrlBoolTable1.Size = new Size(581, 368);
            ctrlBoolTable1.TabIndex = 0;
            ctrlBoolTable1.OnTableEnd += ctrlBoolTable_OnTableEnd;
            // 
            // ctrlBoolTable2
            // 
            ctrlBoolTable2.BackColor = Color.Black;
            ctrlBoolTable2.HourlyCash = 10;
            ctrlBoolTable2.Location = new Point(597, 3);
            ctrlBoolTable2.Name = "ctrlBoolTable2";
            ctrlBoolTable2.PlayerCount = 2;
            ctrlBoolTable2.Size = new Size(581, 368);
            ctrlBoolTable2.TabIndex = 1;
            ctrlBoolTable2.OnTableEnd += ctrlBoolTable_OnTableEnd;
            // 
            // ctrlBoolTable4
            // 
            ctrlBoolTable4.BackColor = Color.Black;
            ctrlBoolTable4.HourlyCash = 10;
            ctrlBoolTable4.Location = new Point(6, 368);
            ctrlBoolTable4.Name = "ctrlBoolTable4";
            ctrlBoolTable4.PlayerCount = 3;
            ctrlBoolTable4.Size = new Size(581, 368);
            ctrlBoolTable4.TabIndex = 2;
            ctrlBoolTable4.OnTableEnd += ctrlBoolTable_OnTableEnd;
            // 
            // ctrlBoolTable3
            // 
            ctrlBoolTable3.BackColor = Color.Black;
            ctrlBoolTable3.HourlyCash = 10;
            ctrlBoolTable3.Location = new Point(606, 368);
            ctrlBoolTable3.Name = "ctrlBoolTable3";
            ctrlBoolTable3.PlayerCount = 1;
            ctrlBoolTable3.Size = new Size(582, 368);
            ctrlBoolTable3.TabIndex = 3;
            ctrlBoolTable3.OnTableEnd += ctrlBoolTable_OnTableEnd;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1186, 752);
            Controls.Add(ctrlBoolTable3);
            Controls.Add(ctrlBoolTable4);
            Controls.Add(ctrlBoolTable2);
            Controls.Add(ctrlBoolTable1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ctrlBoolTable ctrlBoolTable1;
        private ctrlBoolTable ctrlBoolTable2;
        private ctrlBoolTable ctrlBoolTable4;
        private ctrlBoolTable ctrlBoolTable3;
    }
}
