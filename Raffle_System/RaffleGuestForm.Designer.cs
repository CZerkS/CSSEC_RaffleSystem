namespace Raffle_System
{
    partial class RaffleGuestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RaffleGuestForm));
            this.timeRandom = new System.Windows.Forms.Timer(this.components);
            this.pnlMain = new System.Windows.Forms.SplitContainer();
            this.pnlTop = new System.Windows.Forms.TableLayoutPanel();
            this.lblRandomGuest = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.TableLayoutPanel();
            this.btnRaffleStart = new RoundButton();
            this.btnBack = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).BeginInit();
            this.pnlMain.Panel1.SuspendLayout();
            this.pnlMain.Panel2.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // timeRandom
            // 
            this.timeRandom.Tick += new System.EventHandler(this.timeRandom_Tick);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlMain.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.IsSplitterFixed = true;
            this.pnlMain.Location = new System.Drawing.Point(10, 10);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(10);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // pnlMain.Panel1
            // 
            this.pnlMain.Panel1.Controls.Add(this.pnlTop);
            // 
            // pnlMain.Panel2
            // 
            this.pnlMain.Panel2.Controls.Add(this.pnlBottom);
            this.pnlMain.Size = new System.Drawing.Size(1884, 1021);
            this.pnlMain.SplitterDistance = 696;
            this.pnlMain.TabIndex = 0;
            // 
            // pnlTop
            // 
            this.pnlTop.CausesValidation = false;
            this.pnlTop.ColumnCount = 3;
            this.pnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.pnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlTop.Controls.Add(this.lblRandomGuest, 0, 1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTop.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.RowCount = 3;
            this.pnlTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.pnlTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlTop.Size = new System.Drawing.Size(1884, 696);
            this.pnlTop.TabIndex = 0;
            // 
            // lblRandomGuest
            // 
            this.pnlTop.SetColumnSpan(this.lblRandomGuest, 3);
            this.lblRandomGuest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRandomGuest.Font = new System.Drawing.Font("Herald Typeface", 98F);
            this.lblRandomGuest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.lblRandomGuest.Location = new System.Drawing.Point(3, 139);
            this.lblRandomGuest.Name = "lblRandomGuest";
            this.lblRandomGuest.Size = new System.Drawing.Size(1878, 417);
            this.lblRandomGuest.TabIndex = 0;
            this.lblRandomGuest.Text = "WINNER";
            this.lblRandomGuest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBottom
            // 
            this.pnlBottom.ColumnCount = 3;
            this.pnlBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.5F));
            this.pnlBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.pnlBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.5F));
            this.pnlBottom.Controls.Add(this.btnRaffleStart, 1, 0);
            this.pnlBottom.Controls.Add(this.btnBack, 0, 0);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBottom.Location = new System.Drawing.Point(0, 0);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.RowCount = 1;
            this.pnlBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlBottom.Size = new System.Drawing.Size(1884, 321);
            this.pnlBottom.TabIndex = 0;
            // 
            // btnRaffleStart
            // 
            this.btnRaffleStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.btnRaffleStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRaffleStart.Font = new System.Drawing.Font("Herald Typeface", 72F);
            this.btnRaffleStart.ForeColor = System.Drawing.Color.White;
            this.btnRaffleStart.Location = new System.Drawing.Point(803, 3);
            this.btnRaffleStart.Name = "btnRaffleStart";
            this.btnRaffleStart.Size = new System.Drawing.Size(276, 315);
            this.btnRaffleStart.TabIndex = 0;
            this.btnRaffleStart.Text = "GO";
            this.btnRaffleStart.UseVisualStyleBackColor = false;
            this.btnRaffleStart.Click += new System.EventHandler(this.btnRaffleStart_Click);
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 64F);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(67)))), ((int)(((byte)(83)))));
            this.btnBack.Location = new System.Drawing.Point(3, 224);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(794, 97);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "◄";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // RaffleGuestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.pnlMain);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RaffleGuestForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "AdDU Raffle";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RaffleGuestForm_Load);
            this.pnlMain.Panel1.ResumeLayout(false);
            this.pnlMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timeRandom;
        private System.Windows.Forms.SplitContainer pnlMain;
        private System.Windows.Forms.TableLayoutPanel pnlBottom;
        private RoundButton btnRaffleStart;
        private System.Windows.Forms.TableLayoutPanel pnlTop;
        private System.Windows.Forms.Label lblRandName;
        private System.Windows.Forms.Label btnBack;
        private System.Windows.Forms.Label lblRandomGuest;
    }
}

