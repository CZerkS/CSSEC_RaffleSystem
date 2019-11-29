namespace Raffle_System
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.cmbEvents = new System.Windows.Forms.ComboBox();
            this.btnEventRaffle = new System.Windows.Forms.Button();
            this.lblEventName = new System.Windows.Forms.Label();
            this.lblSystemName = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnGuestRaffle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbEvents
            // 
            this.cmbEvents.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbEvents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEvents.DropDownWidth = 121;
            this.cmbEvents.Font = new System.Drawing.Font("Herald Typeface", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEvents.FormattingEnabled = true;
            this.cmbEvents.Location = new System.Drawing.Point(0, 0);
            this.cmbEvents.Name = "cmbEvents";
            this.cmbEvents.Size = new System.Drawing.Size(470, 40);
            this.cmbEvents.TabIndex = 0;
            this.cmbEvents.SelectedIndexChanged += new System.EventHandler(this.cmbEvents_SelectedIndexChanged);
            // 
            // btnEventRaffle
            // 
            this.btnEventRaffle.BackColor = System.Drawing.Color.White;
            this.btnEventRaffle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEventRaffle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEventRaffle.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventRaffle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(57)))), ((int)(((byte)(75)))));
            this.btnEventRaffle.Location = new System.Drawing.Point(3, 3);
            this.btnEventRaffle.Name = "btnEventRaffle";
            this.btnEventRaffle.Size = new System.Drawing.Size(382, 45);
            this.btnEventRaffle.TabIndex = 1;
            this.btnEventRaffle.Text = "AdDU Raffle";
            this.btnEventRaffle.UseVisualStyleBackColor = false;
            this.btnEventRaffle.Click += new System.EventHandler(this.btnEventRaffle_Click);
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.BackColor = System.Drawing.Color.Transparent;
            this.lblEventName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEventName.Font = new System.Drawing.Font("Herald Typeface", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(57)))), ((int)(((byte)(75)))));
            this.lblEventName.Location = new System.Drawing.Point(3, 85);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(856, 47);
            this.lblEventName.TabIndex = 2;
            this.lblEventName.Text = "Choose Event";
            this.lblEventName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSystemName
            // 
            this.lblSystemName.AutoSize = true;
            this.lblSystemName.BackColor = System.Drawing.Color.Transparent;
            this.lblSystemName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSystemName.Font = new System.Drawing.Font("Herald Typeface", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystemName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(57)))), ((int)(((byte)(75)))));
            this.lblSystemName.Location = new System.Drawing.Point(3, 0);
            this.lblSystemName.Name = "lblSystemName";
            this.lblSystemName.Size = new System.Drawing.Size(856, 85);
            this.lblSystemName.TabIndex = 3;
            this.lblSystemName.Text = "CSSEC\'S RAFFLE SYSTEM";
            this.lblSystemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(862, 265);
            this.splitContainer1.SplitterDistance = 132;
            this.splitContainer1.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblSystemName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblEventName, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.93507F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.06493F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(862, 132);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.cmbEvents);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer2.Size = new System.Drawing.Size(862, 129);
            this.splitContainer2.SplitterDistance = 470;
            this.splitContainer2.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnGuestRaffle, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnEventRaffle, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(388, 129);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // btnGuestRaffle
            // 
            this.btnGuestRaffle.BackColor = System.Drawing.Color.White;
            this.btnGuestRaffle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuestRaffle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGuestRaffle.Font = new System.Drawing.Font("Herald Typeface", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuestRaffle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(57)))), ((int)(((byte)(75)))));
            this.btnGuestRaffle.Location = new System.Drawing.Point(3, 54);
            this.btnGuestRaffle.Name = "btnGuestRaffle";
            this.btnGuestRaffle.Size = new System.Drawing.Size(382, 45);
            this.btnGuestRaffle.TabIndex = 2;
            this.btnGuestRaffle.Text = "Guest Raffle";
            this.btnGuestRaffle.UseVisualStyleBackColor = false;
            this.btnGuestRaffle.Click += new System.EventHandler(this.btnGuestRaffle_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(862, 265);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEvents;
        private System.Windows.Forms.Button btnEventRaffle;
        private System.Windows.Forms.Label lblEventName;
        private System.Windows.Forms.Label lblSystemName;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnGuestRaffle;
    }
}