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
            this.lblRandomGuest = new System.Windows.Forms.Label();
            this.btnRaffleStart = new System.Windows.Forms.Button();
            this.timeRandom = new System.Windows.Forms.Timer(this.components);
            this.MainContainer = new System.Windows.Forms.SplitContainer();
            this.btnBack = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.MainContainer)).BeginInit();
            this.MainContainer.Panel1.SuspendLayout();
            this.MainContainer.Panel2.SuspendLayout();
            this.MainContainer.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRandomGuest
            // 
            this.lblRandomGuest.BackColor = System.Drawing.Color.Transparent;
            this.lblRandomGuest.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblRandomGuest.Font = new System.Drawing.Font("Herald Typeface", 79.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRandomGuest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(57)))), ((int)(((byte)(75)))));
            this.lblRandomGuest.Location = new System.Drawing.Point(0, 54);
            this.lblRandomGuest.Name = "lblRandomGuest";
            this.lblRandomGuest.Size = new System.Drawing.Size(1482, 307);
            this.lblRandomGuest.TabIndex = 0;
            this.lblRandomGuest.Text = "-";
            this.lblRandomGuest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRaffleStart
            // 
            this.btnRaffleStart.BackColor = System.Drawing.Color.White;
            this.btnRaffleStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRaffleStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRaffleStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRaffleStart.Font = new System.Drawing.Font("Herald Typeface", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaffleStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(57)))), ((int)(((byte)(75)))));
            this.btnRaffleStart.Location = new System.Drawing.Point(3, 2);
            this.btnRaffleStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRaffleStart.Name = "btnRaffleStart";
            this.btnRaffleStart.Size = new System.Drawing.Size(605, 74);
            this.btnRaffleStart.TabIndex = 1;
            this.btnRaffleStart.Text = "START";
            this.btnRaffleStart.UseVisualStyleBackColor = false;
            this.btnRaffleStart.Click += new System.EventHandler(this.btnRaffleStart_Click);
            // 
            // timeRandom
            // 
            this.timeRandom.Tick += new System.EventHandler(this.timeRandom_Tick);
            // 
            // MainContainer
            // 
            this.MainContainer.BackColor = System.Drawing.Color.Transparent;
            this.MainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainContainer.Location = new System.Drawing.Point(0, 0);
            this.MainContainer.Name = "MainContainer";
            this.MainContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // MainContainer.Panel1
            // 
            this.MainContainer.Panel1.Controls.Add(this.btnBack);
            this.MainContainer.Panel1.Controls.Add(this.lblRandomGuest);
            this.MainContainer.Panel1MinSize = 50;
            // 
            // MainContainer.Panel2
            // 
            this.MainContainer.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.MainContainer.Size = new System.Drawing.Size(1482, 683);
            this.MainContainer.SplitterDistance = 361;
            this.MainContainer.TabIndex = 5;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBack.Font = new System.Drawing.Font("Herald Typeface", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(57)))), ((int)(((byte)(75)))));
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(117, 54);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.16667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.16667F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1482, 318);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnRaffleStart, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(435, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(611, 312);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // RaffleGuestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1482, 683);
            this.Controls.Add(this.MainContainer);
            this.Name = "RaffleGuestForm";
            this.Text = "RaffleGuestForm";
            this.Load += new System.EventHandler(this.RaffleGuestForm_Load);
            this.MainContainer.Panel1.ResumeLayout(false);
            this.MainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainContainer)).EndInit();
            this.MainContainer.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblRandomGuest;
        private System.Windows.Forms.Button btnRaffleStart;
        private System.Windows.Forms.Timer timeRandom;
        private System.Windows.Forms.SplitContainer MainContainer;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}