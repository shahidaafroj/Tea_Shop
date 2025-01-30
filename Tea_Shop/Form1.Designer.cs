namespace Tea_Shop
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
            this.LblWelcomTeaShop = new System.Windows.Forms.Label();
            this.LblCustomerID = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.LblGender = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.RadMale = new System.Windows.Forms.RadioButton();
            this.RadFemale = new System.Windows.Forms.RadioButton();
            this.BtnADD = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.DataGridCustomerInfo = new System.Windows.Forms.DataGridView();
            this.LblPhoneNo = new System.Windows.Forms.Label();
            this.TxtPhoneNo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCustomerInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // LblWelcomTeaShop
            // 
            this.LblWelcomTeaShop.AutoSize = true;
            this.LblWelcomTeaShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWelcomTeaShop.Location = new System.Drawing.Point(8, 10);
            this.LblWelcomTeaShop.Name = "LblWelcomTeaShop";
            this.LblWelcomTeaShop.Size = new System.Drawing.Size(550, 46);
            this.LblWelcomTeaShop.TabIndex = 0;
            this.LblWelcomTeaShop.Text = "Welcome To Afroj Tea Shop";
            // 
            // LblCustomerID
            // 
            this.LblCustomerID.AutoSize = true;
            this.LblCustomerID.Location = new System.Drawing.Point(34, 75);
            this.LblCustomerID.Name = "LblCustomerID";
            this.LblCustomerID.Size = new System.Drawing.Size(0, 20);
            this.LblCustomerID.TabIndex = 1;
            this.LblCustomerID.Visible = false;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.Location = new System.Drawing.Point(34, 146);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(107, 37);
            this.LblName.TabIndex = 2;
            this.LblName.Text = "Name";
            // 
            // LblGender
            // 
            this.LblGender.AutoSize = true;
            this.LblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGender.Location = new System.Drawing.Point(9, 263);
            this.LblGender.Name = "LblGender";
            this.LblGender.Size = new System.Drawing.Size(115, 32);
            this.LblGender.TabIndex = 3;
            this.LblGender.Text = "Gender";
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.Location = new System.Drawing.Point(164, 135);
            this.TxtName.Multiline = true;
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(239, 42);
            this.TxtName.TabIndex = 5;
            // 
            // RadMale
            // 
            this.RadMale.AutoSize = true;
            this.RadMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadMale.Location = new System.Drawing.Point(144, 263);
            this.RadMale.Name = "RadMale";
            this.RadMale.Size = new System.Drawing.Size(105, 36);
            this.RadMale.TabIndex = 6;
            this.RadMale.TabStop = true;
            this.RadMale.Text = "Male";
            this.RadMale.UseVisualStyleBackColor = true;
            // 
            // RadFemale
            // 
            this.RadFemale.AutoSize = true;
            this.RadFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadFemale.Location = new System.Drawing.Point(263, 264);
            this.RadFemale.Name = "RadFemale";
            this.RadFemale.Size = new System.Drawing.Size(140, 36);
            this.RadFemale.TabIndex = 7;
            this.RadFemale.TabStop = true;
            this.RadFemale.Text = "Female";
            this.RadFemale.UseVisualStyleBackColor = true;
            // 
            // BtnADD
            // 
            this.BtnADD.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnADD.Location = new System.Drawing.Point(61, 331);
            this.BtnADD.Name = "BtnADD";
            this.BtnADD.Size = new System.Drawing.Size(128, 58);
            this.BtnADD.TabIndex = 8;
            this.BtnADD.Text = "ADD";
            this.BtnADD.UseVisualStyleBackColor = false;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.Location = new System.Drawing.Point(195, 330);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(133, 59);
            this.BtnUpdate.TabIndex = 9;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.Location = new System.Drawing.Point(341, 333);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(125, 56);
            this.BtnDelete.TabIndex = 10;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = false;
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Red;
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(177, 395);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(184, 50);
            this.BtnExit.TabIndex = 11;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            // 
            // DataGridCustomerInfo
            // 
            this.DataGridCustomerInfo.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DataGridCustomerInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridCustomerInfo.Location = new System.Drawing.Point(524, 69);
            this.DataGridCustomerInfo.Name = "DataGridCustomerInfo";
            this.DataGridCustomerInfo.RowHeadersWidth = 62;
            this.DataGridCustomerInfo.RowTemplate.Height = 28;
            this.DataGridCustomerInfo.Size = new System.Drawing.Size(750, 514);
            this.DataGridCustomerInfo.TabIndex = 12;
            // 
            // LblPhoneNo
            // 
            this.LblPhoneNo.AutoSize = true;
            this.LblPhoneNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPhoneNo.Location = new System.Drawing.Point(8, 199);
            this.LblPhoneNo.Name = "LblPhoneNo";
            this.LblPhoneNo.Size = new System.Drawing.Size(148, 32);
            this.LblPhoneNo.TabIndex = 13;
            this.LblPhoneNo.Text = "Phone No";
            // 
            // TxtPhoneNo
            // 
            this.TxtPhoneNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPhoneNo.Location = new System.Drawing.Point(164, 193);
            this.TxtPhoneNo.Multiline = true;
            this.TxtPhoneNo.Name = "TxtPhoneNo";
            this.TxtPhoneNo.Size = new System.Drawing.Size(239, 42);
            this.TxtPhoneNo.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 595);
            this.Controls.Add(this.TxtPhoneNo);
            this.Controls.Add(this.LblPhoneNo);
            this.Controls.Add(this.DataGridCustomerInfo);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnADD);
            this.Controls.Add(this.RadFemale);
            this.Controls.Add(this.RadMale);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.LblGender);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.LblCustomerID);
            this.Controls.Add(this.LblWelcomTeaShop);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCustomerInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblWelcomTeaShop;
        private System.Windows.Forms.Label LblCustomerID;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblGender;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.RadioButton RadMale;
        private System.Windows.Forms.RadioButton RadFemale;
        private System.Windows.Forms.Button BtnADD;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.DataGridView DataGridCustomerInfo;
        private System.Windows.Forms.Label LblPhoneNo;
        private System.Windows.Forms.TextBox TxtPhoneNo;
    }
}

