namespace ShopifyApp
{
    partial class RegistrationForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.txtRName = new System.Windows.Forms.TextBox();
            this.txtRContactnumber = new System.Windows.Forms.TextBox();
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblRUserid = new System.Windows.Forms.Label();
            this.lblRPassword = new System.Windows.Forms.Label();
            this.txtRUserid = new System.Windows.Forms.TextBox();
            this.txtRPassword = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbTypee = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblPasswordValidation = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.cmbDeleteuser = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(106, 94);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 18);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(106, 152);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(54, 18);
            this.lblGender.TabIndex = 2;
            this.lblGender.Text = "Gender";
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactNumber.Location = new System.Drawing.Point(106, 208);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(107, 18);
            this.lblContactNumber.TabIndex = 3;
            this.lblContactNumber.Text = "ContactNumber";
            // 
            // txtRName
            // 
            this.txtRName.Location = new System.Drawing.Point(278, 95);
            this.txtRName.Name = "txtRName";
            this.txtRName.Size = new System.Drawing.Size(185, 20);
            this.txtRName.TabIndex = 4;
            this.txtRName.Validating += new System.ComponentModel.CancelEventHandler(this.txtRName_Validating);
            // 
            // txtRContactnumber
            // 
            this.txtRContactnumber.Location = new System.Drawing.Point(278, 206);
            this.txtRContactnumber.Name = "txtRContactnumber";
            this.txtRContactnumber.Size = new System.Drawing.Size(185, 20);
            this.txtRContactnumber.TabIndex = 7;
            this.txtRContactnumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtRContactnumber_Validating);
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(177, 14);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(174, 29);
            this.lblHeading.TabIndex = 8;
            this.lblHeading.Text = "ADD USERS";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(19, 417);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(139, 43);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblRUserid
            // 
            this.lblRUserid.AutoSize = true;
            this.lblRUserid.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRUserid.Location = new System.Drawing.Point(106, 262);
            this.lblRUserid.Name = "lblRUserid";
            this.lblRUserid.Size = new System.Drawing.Size(52, 18);
            this.lblRUserid.TabIndex = 10;
            this.lblRUserid.Text = "UserId";
            // 
            // lblRPassword
            // 
            this.lblRPassword.AutoSize = true;
            this.lblRPassword.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRPassword.Location = new System.Drawing.Point(106, 308);
            this.lblRPassword.Name = "lblRPassword";
            this.lblRPassword.Size = new System.Drawing.Size(68, 18);
            this.lblRPassword.TabIndex = 11;
            this.lblRPassword.Text = "Password";
            // 
            // txtRUserid
            // 
            this.txtRUserid.Location = new System.Drawing.Point(278, 260);
            this.txtRUserid.Name = "txtRUserid";
            this.txtRUserid.Size = new System.Drawing.Size(185, 20);
            this.txtRUserid.TabIndex = 12;
            // 
            // txtRPassword
            // 
            this.txtRPassword.Location = new System.Drawing.Point(278, 308);
            this.txtRPassword.Name = "txtRPassword";
            this.txtRPassword.Size = new System.Drawing.Size(185, 20);
            this.txtRPassword.TabIndex = 13;
            this.txtRPassword.TextChanged += new System.EventHandler(this.txtRPassword_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.btnDeleteUser);
            this.panel1.Controls.Add(this.cmbTypee);
            this.panel1.Controls.Add(this.lblType);
            this.panel1.Controls.Add(this.lblPasswordValidation);
            this.panel1.Controls.Add(this.lblMessage);
            this.panel1.Controls.Add(this.rbtnFemale);
            this.panel1.Controls.Add(this.rbtnMale);
            this.panel1.Controls.Add(this.txtRPassword);
            this.panel1.Controls.Add(this.txtRUserid);
            this.panel1.Controls.Add(this.lblRPassword);
            this.panel1.Controls.Add(this.lblRUserid);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.lblHeading);
            this.panel1.Controls.Add(this.txtRContactnumber);
            this.panel1.Controls.Add(this.txtRName);
            this.panel1.Controls.Add(this.lblContactNumber);
            this.panel1.Controls.Add(this.lblGender);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Location = new System.Drawing.Point(325, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 463);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cmbTypee
            // 
            this.cmbTypee.FormattingEnabled = true;
            this.cmbTypee.Items.AddRange(new object[] {
            "Cashier",
            "Stock Manager"});
            this.cmbTypee.Location = new System.Drawing.Point(278, 351);
            this.cmbTypee.Name = "cmbTypee";
            this.cmbTypee.Size = new System.Drawing.Size(185, 21);
            this.cmbTypee.TabIndex = 20;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(106, 354);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(39, 18);
            this.lblType.TabIndex = 19;
            this.lblType.Text = "Type";
            // 
            // lblPasswordValidation
            // 
            this.lblPasswordValidation.AutoSize = true;
            this.lblPasswordValidation.ForeColor = System.Drawing.Color.Red;
            this.lblPasswordValidation.Location = new System.Drawing.Point(442, 351);
            this.lblPasswordValidation.Name = "lblPasswordValidation";
            this.lblPasswordValidation.Size = new System.Drawing.Size(0, 13);
            this.lblPasswordValidation.TabIndex = 18;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(402, 417);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 17;
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFemale.Location = new System.Drawing.Point(369, 152);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(94, 22);
            this.rbtnFemale.TabIndex = 16;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "FEMALE";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMale.Location = new System.Drawing.Point(278, 152);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(73, 22);
            this.rbtnMale.TabIndex = 15;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "MALE";
            this.rbtnMale.UseVisualStyleBackColor = true;
            this.rbtnMale.Validating += new System.ComponentModel.CancelEventHandler(this.rbtnMale_Validating);
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.BackgroundImage = global::ShopifyApp.Properties.Resources.finalpicc;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.Location = new System.Drawing.Point(2, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1253, 76);
            this.panel3.TabIndex = 20;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Location = new System.Drawing.Point(2, 660);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1255, 35);
            this.panel4.TabIndex = 21;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(2, 74);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 22;
            this.btnBack.Text = "back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(248, 427);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteUser.TabIndex = 21;
            this.btnDeleteUser.Text = "Delete";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // cmbDeleteuser
            // 
            this.cmbDeleteuser.FormattingEnabled = true;
            this.cmbDeleteuser.Location = new System.Drawing.Point(872, 143);
            this.cmbDeleteuser.Name = "cmbDeleteuser";
            this.cmbDeleteuser.Size = new System.Drawing.Size(121, 21);
            this.cmbDeleteuser.TabIndex = 23;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1256, 691);
            this.Controls.Add(this.cmbDeleteuser);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblContactNumber;
        private System.Windows.Forms.TextBox txtRName;
        private System.Windows.Forms.TextBox txtRContactnumber;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblRUserid;
        private System.Windows.Forms.Label lblRPassword;
        private System.Windows.Forms.TextBox txtRUserid;
        private System.Windows.Forms.TextBox txtRPassword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblPasswordValidation;
        private System.Windows.Forms.ErrorProvider ep;
        private System.Windows.Forms.ComboBox cmbTypee;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.ComboBox cmbDeleteuser;
    }
}