namespace TicTacToeSimulator
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
            this.exitButton = new System.Windows.Forms.Button();
            this.A1 = new System.Windows.Forms.Label();
            this.B1 = new System.Windows.Forms.Label();
            this.C1 = new System.Windows.Forms.Label();
            this.A2 = new System.Windows.Forms.Label();
            this.B2 = new System.Windows.Forms.Label();
            this.C2 = new System.Windows.Forms.Label();
            this.A3 = new System.Windows.Forms.Label();
            this.B3 = new System.Windows.Forms.Label();
            this.C3 = new System.Windows.Forms.Label();
            this.turnIdentiferLabel = new System.Windows.Forms.Label();
            this.x_win_count = new System.Windows.Forms.Label();
            this.tie_win_count = new System.Windows.Forms.Label();
            this.o_win_count = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.onePlayerButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(28, 397);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(92, 23);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // A1
            // 
            this.A1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.A1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A1.Location = new System.Drawing.Point(20, 56);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(75, 75);
            this.A1.TabIndex = 2;
            this.A1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.A1.Click += new System.EventHandler(this.square_click);
            // 
            // B1
            // 
            this.B1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.B1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.B1.Location = new System.Drawing.Point(106, 56);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(75, 75);
            this.B1.TabIndex = 3;
            this.B1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.B1.Click += new System.EventHandler(this.square_click);
            // 
            // C1
            // 
            this.C1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.C1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.C1.Location = new System.Drawing.Point(192, 56);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(75, 75);
            this.C1.TabIndex = 4;
            this.C1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.C1.Click += new System.EventHandler(this.square_click);
            // 
            // A2
            // 
            this.A2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.A2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.A2.Location = new System.Drawing.Point(20, 141);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(75, 75);
            this.A2.TabIndex = 5;
            this.A2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.A2.Click += new System.EventHandler(this.square_click);
            // 
            // B2
            // 
            this.B2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.B2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.B2.Location = new System.Drawing.Point(106, 141);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(75, 75);
            this.B2.TabIndex = 6;
            this.B2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.B2.Click += new System.EventHandler(this.square_click);
            // 
            // C2
            // 
            this.C2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.C2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.C2.Location = new System.Drawing.Point(192, 141);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(75, 75);
            this.C2.TabIndex = 7;
            this.C2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.C2.Click += new System.EventHandler(this.square_click);
            // 
            // A3
            // 
            this.A3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.A3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.A3.Location = new System.Drawing.Point(20, 226);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(75, 75);
            this.A3.TabIndex = 8;
            this.A3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.A3.Click += new System.EventHandler(this.square_click);
            // 
            // B3
            // 
            this.B3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.B3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.B3.Location = new System.Drawing.Point(106, 226);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(75, 75);
            this.B3.TabIndex = 9;
            this.B3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.B3.Click += new System.EventHandler(this.square_click);
            // 
            // C3
            // 
            this.C3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.C3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.C3.Location = new System.Drawing.Point(192, 226);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(75, 75);
            this.C3.TabIndex = 10;
            this.C3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.C3.Click += new System.EventHandler(this.square_click);
            // 
            // turnIdentiferLabel
            // 
            this.turnIdentiferLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turnIdentiferLabel.Location = new System.Drawing.Point(54, 33);
            this.turnIdentiferLabel.Name = "turnIdentiferLabel";
            this.turnIdentiferLabel.Size = new System.Drawing.Size(184, 21);
            this.turnIdentiferLabel.TabIndex = 11;
            this.turnIdentiferLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // x_win_count
            // 
            this.x_win_count.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.x_win_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x_win_count.Location = new System.Drawing.Point(6, 36);
            this.x_win_count.Name = "x_win_count";
            this.x_win_count.Size = new System.Drawing.Size(36, 27);
            this.x_win_count.TabIndex = 12;
            this.x_win_count.Text = "0";
            this.x_win_count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tie_win_count
            // 
            this.tie_win_count.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tie_win_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tie_win_count.Location = new System.Drawing.Point(43, 36);
            this.tie_win_count.Name = "tie_win_count";
            this.tie_win_count.Size = new System.Drawing.Size(36, 27);
            this.tie_win_count.TabIndex = 13;
            this.tie_win_count.Text = "0";
            this.tie_win_count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // o_win_count
            // 
            this.o_win_count.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.o_win_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.o_win_count.Location = new System.Drawing.Point(80, 36);
            this.o_win_count.Name = "o_win_count";
            this.o_win_count.Size = new System.Drawing.Size(36, 27);
            this.o_win_count.TabIndex = 14;
            this.o_win_count.Text = "0";
            this.o_win_count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(89, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "O";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Tie";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.x_win_count);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tie_win_count);
            this.groupBox1.Controls.Add(this.o_win_count);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(148, 320);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(123, 71);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Score";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(165, 397);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(92, 23);
            this.clearButton.TabIndex = 19;
            this.clearButton.Text = "Clear Score";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // onePlayerButton
            // 
            this.onePlayerButton.Location = new System.Drawing.Point(20, 339);
            this.onePlayerButton.Name = "onePlayerButton";
            this.onePlayerButton.Size = new System.Drawing.Size(100, 44);
            this.onePlayerButton.TabIndex = 20;
            this.onePlayerButton.Text = "New Game";
            this.onePlayerButton.UseVisualStyleBackColor = true;
            this.onePlayerButton.Click += new System.EventHandler(this.startNewGame);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "TIC TAC TOE";
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 432);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.onePlayerButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.turnIdentiferLabel);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.exitButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TicTacToe";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label A1;
        private System.Windows.Forms.Label B1;
        private System.Windows.Forms.Label C1;
        private System.Windows.Forms.Label A2;
        private System.Windows.Forms.Label B2;
        private System.Windows.Forms.Label C2;
        private System.Windows.Forms.Label A3;
        private System.Windows.Forms.Label B3;
        private System.Windows.Forms.Label C3;
        private System.Windows.Forms.Label turnIdentiferLabel;
        private System.Windows.Forms.Label x_win_count;
        private System.Windows.Forms.Label tie_win_count;
        private System.Windows.Forms.Label o_win_count;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button onePlayerButton;
        private System.Windows.Forms.Label label1;
    }
}

