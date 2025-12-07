namespace Pool_Ball
{
    partial class ctrlBoolTable
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            btnStartStop = new Button();
            btnEnd = new Button();
            lblPlayer = new Label();
            lblTime = new Label();
            gbTable = new GroupBox();
            TableTimer = new System.Windows.Forms.Timer(components);
            lblHourlyCash = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            gbTable.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Image = Properties.Resources.pool;
            pictureBox1.Location = new Point(6, 75);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(422, 213);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnStartStop
            // 
            btnStartStop.BackColor = Color.Black;
            btnStartStop.ForeColor = Color.White;
            btnStartStop.Location = new Point(459, 133);
            btnStartStop.Name = "btnStartStop";
            btnStartStop.Size = new Size(89, 39);
            btnStartStop.TabIndex = 1;
            btnStartStop.Text = "Start";
            btnStartStop.UseVisualStyleBackColor = false;
            btnStartStop.Click += btnStartStop_Click;
            // 
            // btnEnd
            // 
            btnEnd.BackColor = Color.Black;
            btnEnd.ForeColor = Color.White;
            btnEnd.Location = new Point(459, 198);
            btnEnd.Name = "btnEnd";
            btnEnd.Size = new Size(89, 39);
            btnEnd.TabIndex = 2;
            btnEnd.Text = "End";
            btnEnd.UseVisualStyleBackColor = false;
            btnEnd.Click += btnEnd_Click;
            // 
            // lblPlayer
            // 
            lblPlayer.AutoSize = true;
            lblPlayer.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlayer.ForeColor = Color.White;
            lblPlayer.Location = new Point(233, 22);
            lblPlayer.Name = "lblPlayer";
            lblPlayer.Size = new Size(98, 37);
            lblPlayer.TabIndex = 3;
            lblPlayer.Text = "Player";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTime.ForeColor = Color.White;
            lblTime.Location = new Point(157, 305);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(127, 37);
            lblTime.TabIndex = 4;
            lblTime.Text = "00:00:00";
            // 
            // gbTable
            // 
            gbTable.BackColor = Color.Black;
            gbTable.Controls.Add(lblHourlyCash);
            gbTable.Controls.Add(lblTime);
            gbTable.Controls.Add(lblPlayer);
            gbTable.Controls.Add(btnEnd);
            gbTable.Controls.Add(btnStartStop);
            gbTable.Controls.Add(pictureBox1);
            gbTable.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbTable.ForeColor = Color.White;
            gbTable.Location = new Point(3, 3);
            gbTable.Name = "gbTable";
            gbTable.Size = new Size(574, 360);
            gbTable.TabIndex = 5;
            gbTable.TabStop = false;
            gbTable.Text = "Table";
            // 
            // TableTimer
            // 
            TableTimer.Interval = 1000;
            TableTimer.Tick += Time_Tick;
            // 
            // lblHourlyCash
            // 
            lblHourlyCash.AutoSize = true;
            lblHourlyCash.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHourlyCash.ForeColor = Color.White;
            lblHourlyCash.Location = new Point(371, 305);
            lblHourlyCash.Name = "lblHourlyCash";
            lblHourlyCash.Size = new Size(75, 37);
            lblHourlyCash.TabIndex = 5;
            lblHourlyCash.Text = "/ HR";
            // 
            // ctrlBoolTable
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(gbTable);
            Name = "ctrlBoolTable";
            Size = new Size(582, 368);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            gbTable.ResumeLayout(false);
            gbTable.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnStartStop;
        private Button btnEnd;
        private Label lblPlayer;
        private Label lblTime;
        private GroupBox gbTable;
        private System.Windows.Forms.Timer TableTimer;
        private Label lblHourlyCash;
    }
}
