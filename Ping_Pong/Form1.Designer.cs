namespace Ping_Pong
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
            this.playground = new System.Windows.Forms.Panel();
            this.puncte2_lbl = new System.Windows.Forms.Label();
            this.scor2_lbl = new System.Windows.Forms.Label();
            this.ply2 = new System.Windows.Forms.Label();
            this.ply1 = new System.Windows.Forms.Label();
            this.bara2 = new System.Windows.Forms.PictureBox();
            this.stop_joc = new System.Windows.Forms.Label();
            this.puncte_lbl = new System.Windows.Forms.Label();
            this.scor_lbl = new System.Windows.Forms.Label();
            this.minge = new System.Windows.Forms.PictureBox();
            this.bara = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.playground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bara2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bara)).BeginInit();
            this.SuspendLayout();
            // 
            // playground
            // 
            this.playground.Controls.Add(this.puncte2_lbl);
            this.playground.Controls.Add(this.scor2_lbl);
            this.playground.Controls.Add(this.ply2);
            this.playground.Controls.Add(this.ply1);
            this.playground.Controls.Add(this.bara2);
            this.playground.Controls.Add(this.stop_joc);
            this.playground.Controls.Add(this.puncte_lbl);
            this.playground.Controls.Add(this.scor_lbl);
            this.playground.Controls.Add(this.minge);
            this.playground.Controls.Add(this.bara);
            this.playground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playground.Location = new System.Drawing.Point(0, 0);
            this.playground.Name = "playground";
            this.playground.Size = new System.Drawing.Size(583, 415);
            this.playground.TabIndex = 0;
            // 
            // puncte2_lbl
            // 
            this.puncte2_lbl.AutoSize = true;
            this.puncte2_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puncte2_lbl.Location = new System.Drawing.Point(550, 9);
            this.puncte2_lbl.Name = "puncte2_lbl";
            this.puncte2_lbl.Size = new System.Drawing.Size(19, 20);
            this.puncte2_lbl.TabIndex = 9;
            this.puncte2_lbl.Text = "0";
            // 
            // scor2_lbl
            // 
            this.scor2_lbl.AutoSize = true;
            this.scor2_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scor2_lbl.Location = new System.Drawing.Point(425, 9);
            this.scor2_lbl.Name = "scor2_lbl";
            this.scor2_lbl.Size = new System.Drawing.Size(119, 20);
            this.scor2_lbl.TabIndex = 8;
            this.scor2_lbl.Text = "Scor player 2:";
            // 
            // ply2
            // 
            this.ply2.AutoSize = true;
            this.ply2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ply2.Location = new System.Drawing.Point(34, 257);
            this.ply2.Name = "ply2";
            this.ply2.Size = new System.Drawing.Size(162, 20);
            this.ply2.TabIndex = 7;
            this.ply2.Text = "Player 2 a castigat!";
            // 
            // ply1
            // 
            this.ply1.AutoSize = true;
            this.ply1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ply1.Location = new System.Drawing.Point(252, 290);
            this.ply1.Name = "ply1";
            this.ply1.Size = new System.Drawing.Size(162, 20);
            this.ply1.TabIndex = 6;
            this.ply1.Text = "Player 1 a castigat!";
            // 
            // bara2
            // 
            this.bara2.BackColor = System.Drawing.Color.Blue;
            this.bara2.Location = new System.Drawing.Point(173, 36);
            this.bara2.Name = "bara2";
            this.bara2.Size = new System.Drawing.Size(200, 20);
            this.bara2.TabIndex = 5;
            this.bara2.TabStop = false;
            // 
            // stop_joc
            // 
            this.stop_joc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stop_joc.AutoSize = true;
            this.stop_joc.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stop_joc.Location = new System.Drawing.Point(202, 59);
            this.stop_joc.Name = "stop_joc";
            this.stop_joc.Size = new System.Drawing.Size(267, 200);
            this.stop_joc.TabIndex = 4;
            this.stop_joc.Text = "STOP JOC!\r\n\r\nF1 - Restart\r\nESC - Iesire";
            this.stop_joc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // puncte_lbl
            // 
            this.puncte_lbl.AutoSize = true;
            this.puncte_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puncte_lbl.Location = new System.Drawing.Point(137, 9);
            this.puncte_lbl.Name = "puncte_lbl";
            this.puncte_lbl.Size = new System.Drawing.Size(19, 20);
            this.puncte_lbl.TabIndex = 3;
            this.puncte_lbl.Text = "0";
            // 
            // scor_lbl
            // 
            this.scor_lbl.AutoSize = true;
            this.scor_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scor_lbl.Location = new System.Drawing.Point(12, 9);
            this.scor_lbl.Name = "scor_lbl";
            this.scor_lbl.Size = new System.Drawing.Size(119, 20);
            this.scor_lbl.TabIndex = 2;
            this.scor_lbl.Text = "Scor player 1:";
            // 
            // minge
            // 
            this.minge.BackColor = System.Drawing.Color.Red;
            this.minge.Location = new System.Drawing.Point(117, 178);
            this.minge.Name = "minge";
            this.minge.Size = new System.Drawing.Size(25, 25);
            this.minge.TabIndex = 1;
            this.minge.TabStop = false;
            // 
            // bara
            // 
            this.bara.BackColor = System.Drawing.Color.Black;
            this.bara.Location = new System.Drawing.Point(173, 383);
            this.bara.Name = "bara";
            this.bara.Size = new System.Drawing.Size(200, 20);
            this.bara.TabIndex = 0;
            this.bara.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 415);
            this.Controls.Add(this.playground);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.playground.ResumeLayout(false);
            this.playground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bara2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bara)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel playground;
        private System.Windows.Forms.PictureBox minge;
        private System.Windows.Forms.PictureBox bara;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label scor_lbl;
        private System.Windows.Forms.Label puncte_lbl;
        private System.Windows.Forms.Label stop_joc;
        private System.Windows.Forms.PictureBox bara2;
        private System.Windows.Forms.Label ply1;
        private System.Windows.Forms.Label ply2;
        private System.Windows.Forms.Label puncte2_lbl;
        private System.Windows.Forms.Label scor2_lbl;
    }
}

