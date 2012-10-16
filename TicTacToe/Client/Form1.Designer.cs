namespace Client
{
    partial class TicTacToe
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
            this.components = new System.ComponentModel.Container();
            this.lbl_playerName = new System.Windows.Forms.Label();
            this.btn_startNewGame = new System.Windows.Forms.Button();
            this.btn_00 = new System.Windows.Forms.Button();
            this.btn_01 = new System.Windows.Forms.Button();
            this.btn_02 = new System.Windows.Forms.Button();
            this.btn_10 = new System.Windows.Forms.Button();
            this.btn_11 = new System.Windows.Forms.Button();
            this.btn_12 = new System.Windows.Forms.Button();
            this.btn_20 = new System.Windows.Forms.Button();
            this.btn_21 = new System.Windows.Forms.Button();
            this.btn_22 = new System.Windows.Forms.Button();
            this.GameLoop = new System.Windows.Forms.Timer(this.components);
            this.lbl_message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_playerName
            // 
            this.lbl_playerName.AutoSize = true;
            this.lbl_playerName.Location = new System.Drawing.Point(12, 17);
            this.lbl_playerName.Name = "lbl_playerName";
            this.lbl_playerName.Size = new System.Drawing.Size(107, 13);
            this.lbl_playerName.TabIndex = 0;
            this.lbl_playerName.Text = "<<PLAYER NAME>>";
            // 
            // btn_startNewGame
            // 
            this.btn_startNewGame.Location = new System.Drawing.Point(177, 12);
            this.btn_startNewGame.Name = "btn_startNewGame";
            this.btn_startNewGame.Size = new System.Drawing.Size(94, 23);
            this.btn_startNewGame.TabIndex = 1;
            this.btn_startNewGame.Text = "Start new Game";
            this.btn_startNewGame.UseVisualStyleBackColor = true;
            this.btn_startNewGame.Click += new System.EventHandler(this.StartNewGame_Click);
            // 
            // btn_00
            // 
            this.btn_00.Enabled = false;
            this.btn_00.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_00.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_00.Location = new System.Drawing.Point(15, 87);
            this.btn_00.Name = "btn_00";
            this.btn_00.Size = new System.Drawing.Size(60, 60);
            this.btn_00.TabIndex = 3;
            this.btn_00.UseVisualStyleBackColor = true;
            this.btn_00.Click += new System.EventHandler(this.Move_Click);
            // 
            // btn_01
            // 
            this.btn_01.Enabled = false;
            this.btn_01.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_01.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_01.Location = new System.Drawing.Point(113, 87);
            this.btn_01.Name = "btn_01";
            this.btn_01.Size = new System.Drawing.Size(60, 60);
            this.btn_01.TabIndex = 4;
            this.btn_01.UseVisualStyleBackColor = true;
            this.btn_01.Click += new System.EventHandler(this.Move_Click);
            // 
            // btn_02
            // 
            this.btn_02.Enabled = false;
            this.btn_02.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_02.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_02.Location = new System.Drawing.Point(211, 87);
            this.btn_02.Name = "btn_02";
            this.btn_02.Size = new System.Drawing.Size(60, 60);
            this.btn_02.TabIndex = 5;
            this.btn_02.UseVisualStyleBackColor = true;
            this.btn_02.Click += new System.EventHandler(this.Move_Click);
            // 
            // btn_10
            // 
            this.btn_10.Enabled = false;
            this.btn_10.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_10.Location = new System.Drawing.Point(15, 153);
            this.btn_10.Name = "btn_10";
            this.btn_10.Size = new System.Drawing.Size(60, 60);
            this.btn_10.TabIndex = 6;
            this.btn_10.UseVisualStyleBackColor = true;
            this.btn_10.Click += new System.EventHandler(this.Move_Click);
            // 
            // btn_11
            // 
            this.btn_11.Enabled = false;
            this.btn_11.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_11.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_11.Location = new System.Drawing.Point(113, 153);
            this.btn_11.Name = "btn_11";
            this.btn_11.Size = new System.Drawing.Size(60, 60);
            this.btn_11.TabIndex = 7;
            this.btn_11.UseVisualStyleBackColor = true;
            this.btn_11.Click += new System.EventHandler(this.Move_Click);
            // 
            // btn_12
            // 
            this.btn_12.Enabled = false;
            this.btn_12.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_12.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_12.Location = new System.Drawing.Point(211, 153);
            this.btn_12.Name = "btn_12";
            this.btn_12.Size = new System.Drawing.Size(60, 60);
            this.btn_12.TabIndex = 8;
            this.btn_12.UseVisualStyleBackColor = true;
            this.btn_12.Click += new System.EventHandler(this.Move_Click);
            // 
            // btn_20
            // 
            this.btn_20.Enabled = false;
            this.btn_20.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_20.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_20.Location = new System.Drawing.Point(15, 226);
            this.btn_20.Name = "btn_20";
            this.btn_20.Size = new System.Drawing.Size(60, 60);
            this.btn_20.TabIndex = 9;
            this.btn_20.UseVisualStyleBackColor = true;
            this.btn_20.Click += new System.EventHandler(this.Move_Click);
            // 
            // btn_21
            // 
            this.btn_21.Enabled = false;
            this.btn_21.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_21.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_21.Location = new System.Drawing.Point(113, 226);
            this.btn_21.Name = "btn_21";
            this.btn_21.Size = new System.Drawing.Size(60, 60);
            this.btn_21.TabIndex = 10;
            this.btn_21.UseVisualStyleBackColor = true;
            this.btn_21.Click += new System.EventHandler(this.Move_Click);
            // 
            // btn_22
            // 
            this.btn_22.Enabled = false;
            this.btn_22.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_22.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_22.Location = new System.Drawing.Point(211, 226);
            this.btn_22.Name = "btn_22";
            this.btn_22.Size = new System.Drawing.Size(60, 60);
            this.btn_22.TabIndex = 11;
            this.btn_22.UseVisualStyleBackColor = true;
            this.btn_22.Click += new System.EventHandler(this.Move_Click);
            // 
            // GameLoop
            // 
            this.GameLoop.Tick += new System.EventHandler(this.serverPollTimer_Tick);
            // 
            // lbl_message
            // 
            this.lbl_message.AutoSize = true;
            this.lbl_message.Location = new System.Drawing.Point(12, 51);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(83, 13);
            this.lbl_message.TabIndex = 12;
            this.lbl_message.Text = "<<MESSAGE>>";
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 296);
            this.Controls.Add(this.lbl_message);
            this.Controls.Add(this.btn_22);
            this.Controls.Add(this.btn_21);
            this.Controls.Add(this.btn_20);
            this.Controls.Add(this.btn_12);
            this.Controls.Add(this.btn_11);
            this.Controls.Add(this.btn_10);
            this.Controls.Add(this.btn_02);
            this.Controls.Add(this.btn_01);
            this.Controls.Add(this.btn_00);
            this.Controls.Add(this.btn_startNewGame);
            this.Controls.Add(this.lbl_playerName);
            this.Name = "TicTacToe";
            this.Text = "TicTacToe";
            this.Load += new System.EventHandler(this.TicTacToe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_playerName;
        private System.Windows.Forms.Button btn_startNewGame;
        private System.Windows.Forms.Button btn_00;
        private System.Windows.Forms.Button btn_01;
        private System.Windows.Forms.Button btn_02;
        private System.Windows.Forms.Button btn_10;
        private System.Windows.Forms.Button btn_11;
        private System.Windows.Forms.Button btn_12;
        private System.Windows.Forms.Button btn_20;
        private System.Windows.Forms.Button btn_21;
        private System.Windows.Forms.Button btn_22;
        private System.Windows.Forms.Timer GameLoop;

        public TicTacToe()
        {
            InitializeComponent();
        }

        private System.Windows.Forms.Label lbl_message;
    }
}

