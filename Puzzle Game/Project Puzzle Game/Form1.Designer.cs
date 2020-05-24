namespace Project_Puzzle_Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.bntNewGame = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ckRemote = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ckTutorial = new System.Windows.Forms.CheckBox();
            this.panelPlay = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelPlay.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cyan;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.bntNewGame);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 681);
            this.panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DimGray;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 459);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 97);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // bntNewGame
            // 
            this.bntNewGame.BackColor = System.Drawing.Color.DodgerBlue;
            this.bntNewGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntNewGame.Dock = System.Windows.Forms.DockStyle.Top;
            this.bntNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntNewGame.Image = ((System.Drawing.Image)(resources.GetObject("bntNewGame.Image")));
            this.bntNewGame.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntNewGame.Location = new System.Drawing.Point(0, 362);
            this.bntNewGame.Name = "bntNewGame";
            this.bntNewGame.Size = new System.Drawing.Size(200, 97);
            this.bntNewGame.TabIndex = 4;
            this.bntNewGame.Text = "NEW GAME";
            this.bntNewGame.UseVisualStyleBackColor = false;
            this.bntNewGame.Click += new System.EventHandler(this.bntNewGame_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 217);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 145);
            this.panel3.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("MV Boli", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.PapayaWhip;
            this.label3.Location = new System.Drawing.Point(3, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 124);
            this.label3.TabIndex = 0;
            this.label3.Text = "PUZZLE\r\nGAME";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Project_Puzzle_Game.Properties.Resources.puzzles;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 217);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrchid;
            this.panel2.Controls.Add(this.ckRemote);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.ckTutorial);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1064, 100);
            this.panel2.TabIndex = 1;
            // 
            // ckRemote
            // 
            this.ckRemote.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ckRemote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckRemote.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ckRemote.FlatAppearance.BorderSize = 5;
            this.ckRemote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckRemote.Image = ((System.Drawing.Image)(resources.GetObject("ckRemote.Image")));
            this.ckRemote.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckRemote.Location = new System.Drawing.Point(641, 18);
            this.ckRemote.Name = "ckRemote";
            this.ckRemote.Size = new System.Drawing.Size(143, 64);
            this.ckRemote.TabIndex = 5;
            this.ckRemote.Text = "REMOTE";
            this.ckRemote.UseVisualStyleBackColor = false;
            this.ckRemote.CheckedChanged += new System.EventHandler(this.ckRemote_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "MAIN BOARD";
            // 
            // ckTutorial
            // 
            this.ckTutorial.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ckTutorial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckTutorial.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ckTutorial.FlatAppearance.BorderSize = 5;
            this.ckTutorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckTutorial.Image = ((System.Drawing.Image)(resources.GetObject("ckTutorial.Image")));
            this.ckTutorial.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckTutorial.Location = new System.Drawing.Point(445, 18);
            this.ckTutorial.Name = "ckTutorial";
            this.ckTutorial.Size = new System.Drawing.Size(151, 64);
            this.ckTutorial.TabIndex = 4;
            this.ckTutorial.Text = "TUTORIAL";
            this.ckTutorial.UseVisualStyleBackColor = false;
            this.ckTutorial.CheckedChanged += new System.EventHandler(this.ckTutorial_CheckedChanged);
            // 
            // panelPlay
            // 
            this.panelPlay.Controls.Add(this.label2);
            this.panelPlay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPlay.Location = new System.Drawing.Point(200, 93);
            this.panelPlay.Name = "panelPlay";
            this.panelPlay.Size = new System.Drawing.Size(1064, 588);
            this.panelPlay.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("MV Boli", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(335, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(470, 45);
            this.label2.TabIndex = 0;
            this.label2.Text = "Click NEW GAME to start";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panelPlay);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "PUZZLE GAME Ver 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelPlay.ResumeLayout(false);
            this.panelPlay.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelPlay;
        private System.Windows.Forms.CheckBox ckRemote;
        private System.Windows.Forms.CheckBox ckTutorial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button bntNewGame;
        private System.Windows.Forms.Label label3;
    }
}

