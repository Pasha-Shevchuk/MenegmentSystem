namespace MenegmentSystem
{
    partial class userMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param GoodsName="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAll = new System.Windows.Forms.Button();
            this.lblOrderSelect = new System.Windows.Forms.Label();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dtnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.comboCatSel = new System.Windows.Forms.ComboBox();
            this.lblTOTAL = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgOrder = new System.Windows.Forms.DataGridView();
            this.dgCatalog = new System.Windows.Forms.DataGridView();
            this.lblLogOut = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCatalog)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblExit);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 35);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Location = new System.Drawing.Point(1145, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "-";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExit.Location = new System.Drawing.Point(1170, 5);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(26, 25);
            this.lblExit.TabIndex = 0;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.Controls.Add(this.btnAll);
            this.panel2.Controls.Add(this.lblOrderSelect);
            this.panel2.Controls.Add(this.btnPurchase);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.dtnDelete);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtAmount);
            this.panel2.Controls.Add(this.comboCatSel);
            this.panel2.Controls.Add(this.lblTOTAL);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dgOrder);
            this.panel2.Controls.Add(this.dgCatalog);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1200, 525);
            this.panel2.TabIndex = 1;
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(360, 10);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(75, 23);
            this.btnAll.TabIndex = 14;
            this.btnAll.Text = "All";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // lblOrderSelect
            // 
            this.lblOrderSelect.AutoSize = true;
            this.lblOrderSelect.Location = new System.Drawing.Point(15, 373);
            this.lblOrderSelect.Name = "lblOrderSelect";
            this.lblOrderSelect.Size = new System.Drawing.Size(0, 16);
            this.lblOrderSelect.TabIndex = 13;
            // 
            // btnPurchase
            // 
            this.btnPurchase.BackColor = System.Drawing.Color.PowderBlue;
            this.btnPurchase.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.btnPurchase.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchase.Location = new System.Drawing.Point(18, 442);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(160, 41);
            this.btnPurchase.TabIndex = 11;
            this.btnPurchase.Text = "PURCHASE";
            this.btnPurchase.UseVisualStyleBackColor = false;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 10;
            // 
            // dtnDelete
            // 
            this.dtnDelete.BackColor = System.Drawing.Color.PowderBlue;
            this.dtnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.dtnDelete.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtnDelete.Location = new System.Drawing.Point(592, 442);
            this.dtnDelete.Name = "dtnDelete";
            this.dtnDelete.Size = new System.Drawing.Size(133, 41);
            this.dtnDelete.TabIndex = 9;
            this.dtnDelete.Text = "DELETE";
            this.dtnDelete.UseVisualStyleBackColor = false;
            this.dtnDelete.Click += new System.EventHandler(this.dtnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.PowderBlue;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.btnAdd.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(409, 442);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(123, 41);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(404, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Amount";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(499, 373);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(41, 30);
            this.txtAmount.TabIndex = 6;
            // 
            // comboCatSel
            // 
            this.comboCatSel.FormattingEnabled = true;
            this.comboCatSel.Location = new System.Drawing.Point(192, 10);
            this.comboCatSel.Name = "comboCatSel";
            this.comboCatSel.Size = new System.Drawing.Size(153, 24);
            this.comboCatSel.TabIndex = 5;
            this.comboCatSel.Text = "Select Category";
            this.comboCatSel.SelectedIndexChanged += new System.EventHandler(this.comboCatSel_SelectedIndexChanged);
            // 
            // lblTOTAL
            // 
            this.lblTOTAL.AutoSize = true;
            this.lblTOTAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTOTAL.Location = new System.Drawing.Point(71, 376);
            this.lblTOTAL.Name = "lblTOTAL";
            this.lblTOTAL.Size = new System.Drawing.Size(97, 25);
            this.lblTOTAL.TabIndex = 4;
            this.lblTOTAL.Text = "TOTAL: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Snow;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(842, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "Your Order";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Snow;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Catalog";
            // 
            // dgOrder
            // 
            this.dgOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgOrder.BackgroundColor = System.Drawing.Color.White;
            this.dgOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrder.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgOrder.Location = new System.Drawing.Point(592, 46);
            this.dgOrder.Name = "dgOrder";
            this.dgOrder.RowHeadersWidth = 51;
            this.dgOrder.RowTemplate.Height = 24;
            this.dgOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgOrder.Size = new System.Drawing.Size(604, 300);
            this.dgOrder.TabIndex = 1;
            this.dgOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOrder_CellContentClick);
            // 
            // dgCatalog
            // 
            this.dgCatalog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCatalog.BackgroundColor = System.Drawing.Color.White;
            this.dgCatalog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCatalog.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgCatalog.Location = new System.Drawing.Point(3, 46);
            this.dgCatalog.Name = "dgCatalog";
            this.dgCatalog.RowHeadersWidth = 51;
            this.dgCatalog.RowTemplate.Height = 24;
            this.dgCatalog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCatalog.Size = new System.Drawing.Size(583, 300);
            this.dgCatalog.TabIndex = 0;
            this.dgCatalog.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCatalog_CellContentClick);
            // 
            // lblLogOut
            // 
            this.lblLogOut.AutoSize = true;
            this.lblLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLogOut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLogOut.Location = new System.Drawing.Point(12, 599);
            this.lblLogOut.Name = "lblLogOut";
            this.lblLogOut.Size = new System.Drawing.Size(50, 16);
            this.lblLogOut.TabIndex = 2;
            this.lblLogOut.Text = "LogOut";
            this.lblLogOut.Click += new System.EventHandler(this.lblLogOut_Click);
            // 
            // userMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1200, 633);
            this.Controls.Add(this.lblLogOut);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "userMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "userMenu";
            this.Load += new System.EventHandler(this.userMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCatalog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLogOut;
        private System.Windows.Forms.Label lblTOTAL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgOrder;
        private System.Windows.Forms.Button dtnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.ComboBox comboCatSel;
        private System.Windows.Forms.DataGridView dgCatalog;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Label lblOrderSelect;
        private System.Windows.Forms.Button btnAll;
    }
}