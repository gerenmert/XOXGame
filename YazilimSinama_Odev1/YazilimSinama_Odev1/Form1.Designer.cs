namespace YazilimSinama_Odev1
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setPlayerDefaultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetWinCountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_A1 = new System.Windows.Forms.Button();
            this.btn_A2 = new System.Windows.Forms.Button();
            this.btn_A3 = new System.Windows.Forms.Button();
            this.btn_B1 = new System.Windows.Forms.Button();
            this.btn_B2 = new System.Windows.Forms.Button();
            this.btn_B3 = new System.Windows.Forms.Button();
            this.btn_C1 = new System.Windows.Forms.Button();
            this.btn_C2 = new System.Windows.Forms.Button();
            this.btn_C3 = new System.Windows.Forms.Button();
            this.lbl_xwincount = new System.Windows.Forms.Label();
            this.lbl_owincount = new System.Windows.Forms.Label();
            this.txt_p1 = new System.Windows.Forms.TextBox();
            this.txt_p2 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.labelPlayer1 = new System.Windows.Forms.Label();
            this.labelPlayer2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(209, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.setPlayerDefaultsToolStripMenuItem,
            this.resetWinCountToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // setPlayerDefaultsToolStripMenuItem
            // 
            this.setPlayerDefaultsToolStripMenuItem.Name = "setPlayerDefaultsToolStripMenuItem";
            this.setPlayerDefaultsToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.setPlayerDefaultsToolStripMenuItem.Text = "Set Player Defaults";
            this.setPlayerDefaultsToolStripMenuItem.Click += new System.EventHandler(this.setPlayerDefaultsToolStripMenuItem_Click);
            // 
            // resetWinCountToolStripMenuItem
            // 
            this.resetWinCountToolStripMenuItem.Name = "resetWinCountToolStripMenuItem";
            this.resetWinCountToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.resetWinCountToolStripMenuItem.Text = "Reset Win Count";
            this.resetWinCountToolStripMenuItem.Click += new System.EventHandler(this.resetWinCountToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // btn_A1
            // 
            this.btn_A1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_A1.Location = new System.Drawing.Point(9, 33);
            this.btn_A1.Margin = new System.Windows.Forms.Padding(2);
            this.btn_A1.Name = "btn_A1";
            this.btn_A1.Size = new System.Drawing.Size(60, 65);
            this.btn_A1.TabIndex = 1;
            this.btn_A1.UseVisualStyleBackColor = true;
            this.btn_A1.Click += new System.EventHandler(this.button_click);
            this.btn_A1.MouseEnter += new System.EventHandler(this.button_enter);
            this.btn_A1.MouseLeave += new System.EventHandler(this.buton_leave);
            // 
            // btn_A2
            // 
            this.btn_A2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_A2.Location = new System.Drawing.Point(74, 33);
            this.btn_A2.Margin = new System.Windows.Forms.Padding(2);
            this.btn_A2.Name = "btn_A2";
            this.btn_A2.Size = new System.Drawing.Size(60, 65);
            this.btn_A2.TabIndex = 2;
            this.btn_A2.UseVisualStyleBackColor = true;
            this.btn_A2.Click += new System.EventHandler(this.button_click);
            this.btn_A2.MouseEnter += new System.EventHandler(this.button_enter);
            this.btn_A2.MouseLeave += new System.EventHandler(this.buton_leave);
            // 
            // btn_A3
            // 
            this.btn_A3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_A3.Location = new System.Drawing.Point(138, 33);
            this.btn_A3.Margin = new System.Windows.Forms.Padding(2);
            this.btn_A3.Name = "btn_A3";
            this.btn_A3.Size = new System.Drawing.Size(60, 65);
            this.btn_A3.TabIndex = 3;
            this.btn_A3.UseVisualStyleBackColor = true;
            this.btn_A3.Click += new System.EventHandler(this.button_click);
            this.btn_A3.MouseEnter += new System.EventHandler(this.button_enter);
            this.btn_A3.MouseLeave += new System.EventHandler(this.buton_leave);
            // 
            // btn_B1
            // 
            this.btn_B1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_B1.Location = new System.Drawing.Point(9, 103);
            this.btn_B1.Margin = new System.Windows.Forms.Padding(2);
            this.btn_B1.Name = "btn_B1";
            this.btn_B1.Size = new System.Drawing.Size(60, 65);
            this.btn_B1.TabIndex = 4;
            this.btn_B1.UseVisualStyleBackColor = true;
            this.btn_B1.Click += new System.EventHandler(this.button_click);
            this.btn_B1.MouseEnter += new System.EventHandler(this.button_enter);
            this.btn_B1.MouseLeave += new System.EventHandler(this.buton_leave);
            // 
            // btn_B2
            // 
            this.btn_B2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_B2.Location = new System.Drawing.Point(74, 103);
            this.btn_B2.Margin = new System.Windows.Forms.Padding(2);
            this.btn_B2.Name = "btn_B2";
            this.btn_B2.Size = new System.Drawing.Size(60, 65);
            this.btn_B2.TabIndex = 5;
            this.btn_B2.UseVisualStyleBackColor = true;
            this.btn_B2.Click += new System.EventHandler(this.button_click);
            this.btn_B2.MouseEnter += new System.EventHandler(this.button_enter);
            this.btn_B2.MouseLeave += new System.EventHandler(this.buton_leave);
            // 
            // btn_B3
            // 
            this.btn_B3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_B3.Location = new System.Drawing.Point(138, 103);
            this.btn_B3.Margin = new System.Windows.Forms.Padding(2);
            this.btn_B3.Name = "btn_B3";
            this.btn_B3.Size = new System.Drawing.Size(60, 65);
            this.btn_B3.TabIndex = 6;
            this.btn_B3.UseVisualStyleBackColor = true;
            this.btn_B3.Click += new System.EventHandler(this.button_click);
            this.btn_B3.MouseEnter += new System.EventHandler(this.button_enter);
            this.btn_B3.MouseLeave += new System.EventHandler(this.buton_leave);
            // 
            // btn_C1
            // 
            this.btn_C1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_C1.Location = new System.Drawing.Point(9, 173);
            this.btn_C1.Margin = new System.Windows.Forms.Padding(2);
            this.btn_C1.Name = "btn_C1";
            this.btn_C1.Size = new System.Drawing.Size(60, 65);
            this.btn_C1.TabIndex = 7;
            this.btn_C1.UseVisualStyleBackColor = true;
            this.btn_C1.Click += new System.EventHandler(this.button_click);
            this.btn_C1.MouseEnter += new System.EventHandler(this.button_enter);
            this.btn_C1.MouseLeave += new System.EventHandler(this.buton_leave);
            // 
            // btn_C2
            // 
            this.btn_C2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_C2.Location = new System.Drawing.Point(74, 173);
            this.btn_C2.Margin = new System.Windows.Forms.Padding(2);
            this.btn_C2.Name = "btn_C2";
            this.btn_C2.Size = new System.Drawing.Size(60, 65);
            this.btn_C2.TabIndex = 8;
            this.btn_C2.UseVisualStyleBackColor = true;
            this.btn_C2.Click += new System.EventHandler(this.button_click);
            this.btn_C2.MouseEnter += new System.EventHandler(this.button_enter);
            this.btn_C2.MouseLeave += new System.EventHandler(this.buton_leave);
            // 
            // btn_C3
            // 
            this.btn_C3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_C3.Location = new System.Drawing.Point(138, 173);
            this.btn_C3.Margin = new System.Windows.Forms.Padding(2);
            this.btn_C3.Name = "btn_C3";
            this.btn_C3.Size = new System.Drawing.Size(60, 65);
            this.btn_C3.TabIndex = 9;
            this.btn_C3.UseVisualStyleBackColor = true;
            this.btn_C3.Click += new System.EventHandler(this.button_click);
            this.btn_C3.MouseEnter += new System.EventHandler(this.button_enter);
            this.btn_C3.MouseLeave += new System.EventHandler(this.buton_leave);
            // 
            // lbl_xwincount
            // 
            this.lbl_xwincount.AutoSize = true;
            this.lbl_xwincount.Location = new System.Drawing.Point(32, 271);
            this.lbl_xwincount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_xwincount.Name = "lbl_xwincount";
            this.lbl_xwincount.Size = new System.Drawing.Size(13, 13);
            this.lbl_xwincount.TabIndex = 13;
            this.lbl_xwincount.Text = "0";
            // 
            // lbl_owincount
            // 
            this.lbl_owincount.AutoSize = true;
            this.lbl_owincount.Location = new System.Drawing.Point(161, 271);
            this.lbl_owincount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_owincount.Name = "lbl_owincount";
            this.lbl_owincount.Size = new System.Drawing.Size(13, 13);
            this.lbl_owincount.TabIndex = 15;
            this.lbl_owincount.Text = "0";
            // 
            // txt_p1
            // 
            this.txt_p1.Location = new System.Drawing.Point(9, 249);
            this.txt_p1.Margin = new System.Windows.Forms.Padding(2);
            this.txt_p1.Name = "txt_p1";
            this.txt_p1.Size = new System.Drawing.Size(61, 20);
            this.txt_p1.TabIndex = 18;
            this.txt_p1.Text = "Player 1";
            this.txt_p1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_p2
            // 
            this.txt_p2.Location = new System.Drawing.Point(138, 249);
            this.txt_p2.Margin = new System.Windows.Forms.Padding(2);
            this.txt_p2.Name = "txt_p2";
            this.txt_p2.Size = new System.Drawing.Size(61, 20);
            this.txt_p2.TabIndex = 19;
            this.txt_p2.Text = "Player 2";
            this.txt_p2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_p2.TextChanged += new System.EventHandler(this.txt_p2_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // labelPlayer1
            // 
            this.labelPlayer1.AutoSize = true;
            this.labelPlayer1.Location = new System.Drawing.Point(116, 275);
            this.labelPlayer1.Name = "labelPlayer1";
            this.labelPlayer1.Size = new System.Drawing.Size(19, 13);
            this.labelPlayer1.TabIndex = 20;
            this.labelPlayer1.Text = "00";
            // 
            // labelPlayer2
            // 
            this.labelPlayer2.AutoSize = true;
            this.labelPlayer2.Location = new System.Drawing.Point(71, 275);
            this.labelPlayer2.Name = "labelPlayer2";
            this.labelPlayer2.Size = new System.Drawing.Size(19, 13);
            this.labelPlayer2.TabIndex = 21;
            this.labelPlayer2.Text = "00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 297);
            this.Controls.Add(this.labelPlayer2);
            this.Controls.Add(this.labelPlayer1);
            this.Controls.Add(this.txt_p2);
            this.Controls.Add(this.txt_p1);
            this.Controls.Add(this.lbl_owincount);
            this.Controls.Add(this.lbl_xwincount);
            this.Controls.Add(this.btn_C3);
            this.Controls.Add(this.btn_C2);
            this.Controls.Add(this.btn_C1);
            this.Controls.Add(this.btn_B3);
            this.Controls.Add(this.btn_B2);
            this.Controls.Add(this.btn_B1);
            this.Controls.Add(this.btn_A3);
            this.Controls.Add(this.btn_A2);
            this.Controls.Add(this.btn_A1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(225, 336);
            this.MinimumSize = new System.Drawing.Size(225, 336);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " X O X  GAME";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btn_A1;
        private System.Windows.Forms.Button btn_A2;
        private System.Windows.Forms.Button btn_A3;
        private System.Windows.Forms.Button btn_B1;
        private System.Windows.Forms.Button btn_B2;
        private System.Windows.Forms.Button btn_B3;
        private System.Windows.Forms.Button btn_C1;
        private System.Windows.Forms.Button btn_C2;
        private System.Windows.Forms.Button btn_C3;
        private System.Windows.Forms.Label lbl_xwincount;
        private System.Windows.Forms.Label lbl_owincount;
        private System.Windows.Forms.ToolStripMenuItem resetWinCountToolStripMenuItem;
        private System.Windows.Forms.TextBox txt_p1;
        private System.Windows.Forms.TextBox txt_p2;
        private System.Windows.Forms.ToolStripMenuItem setPlayerDefaultsToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label labelPlayer1;
        private System.Windows.Forms.Label labelPlayer2;
    }
}

