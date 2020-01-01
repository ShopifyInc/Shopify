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
            this.lblDob = new System.Windows.Forms.Label();
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
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.lblPasswordValidation = new System.Windows.Forms.Label();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(82, 92);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDob.Location = new System.Drawing.Point(82, 148);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(44, 20);
            this.lblDob.TabIndex = 1;
            this.lblDob.Text = "DOB";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(82, 205);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(63, 20);
            this.lblGender.TabIndex = 2;
            this.lblGender.Text = "Gender";
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactNumber.Location = new System.Drawing.Point(82, 258);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(121, 20);
            this.lblContactNumber.TabIndex = 3;
            this.lblContactNumber.Text = "ContactNumber";
            // 
            // txtRName
            // 
            this.txtRName.Location = new System.Drawing.Point(278, 92);
            this.txtRName.Name = "txtRName";
            this.txtRName.Size = new System.Drawing.Size(185, 20);
            this.txtRName.TabIndex = 4;
            this.txtRName.Validating += new System.ComponentModel.CancelEventHandler(this.txtRName_Validating);
            // 
            // txtRContactnumber
            // 
            this.txtRContactnumber.Location = new System.Drawing.Point(278, 258);
            this.txtRContactnumber.Name = "txtRContactnumber";
            this.txtRContactnumber.Size = new System.Drawing.Size(174, 20);
            this.txtRContactnumber.TabIndex = 7;
            this.txtRContactnumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtRContactnumber_Validating);
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(125, 14);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(327, 33);
            this.lblHeading.TabIndex = 8;
            this.lblHeading.Text = "REGISTRATION FORM";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(257, 417);
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
            this.lblRUserid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRUserid.Location = new System.Drawing.Point(82, 304);
            this.lblRUserid.Name = "lblRUserid";
            this.lblRUserid.Size = new System.Drawing.Size(57, 20);
            this.lblRUserid.TabIndex = 10;
            this.lblRUserid.Text = "UserId";
            // 
            // lblRPassword
            // 
            this.lblRPassword.AutoSize = true;
            this.lblRPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRPassword.Location = new System.Drawing.Point(82, 343);
            this.lblRPassword.Name = "lblRPassword";
            this.lblRPassword.Size = new System.Drawing.Size(78, 20);
            this.lblRPassword.TabIndex = 11;
            this.lblRPassword.Text = "Password";
            // 
            // txtRUserid
            // 
            this.txtRUserid.Location = new System.Drawing.Point(278, 306);
            this.txtRUserid.Name = "txtRUserid";
            this.txtRUserid.Size = new System.Drawing.Size(174, 20);
            this.txtRUserid.TabIndex = 12;
            // 
            // txtRPassword
            // 
            this.txtRPassword.Location = new System.Drawing.Point(278, 344);
            this.txtRPassword.Name = "txtRPassword";
            this.txtRPassword.Size = new System.Drawing.Size(174, 20);
            this.txtRPassword.TabIndex = 13;
            this.txtRPassword.TextChanged += new System.EventHandler(this.txtRPassword_TextChanged);
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(278, 147);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(200, 20);
            this.dtp.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.lblPasswordValidation);
            this.panel1.Controls.Add(this.lblMessage);
            this.panel1.Controls.Add(this.rbtnFemale);
            this.panel1.Controls.Add(this.rbtnMale);
            this.panel1.Controls.Add(this.dtp);
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
            this.panel1.Controls.Add(this.lblDob);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Location = new System.Drawing.Point(75, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 463);
            this.panel1.TabIndex = 0;
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
            this.rbtnFemale.Location = new System.Drawing.Point(385, 208);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(67, 17);
            this.rbtnFemale.TabIndex = 16;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "FEMALE";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Location = new System.Drawing.Point(278, 208);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(54, 17);
            this.rbtnMale.TabIndex = 15;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "MALE";
            this.rbtnMale.UseVisualStyleBackColor = true;
            this.rbtnMale.Validating += new System.ComponentModel.CancelEventHandler(this.rbtnMale_Validating);
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
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //this.BackgroundImage = global::ShopifyApp.Properties.Resources.download__2_;
            this.ClientSize = new System.Drawing.Size(800, 544);
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
        private System.Windows.Forms.Label lblDob;
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
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblPasswordValidation;
        private System.Windows.Forms.ErrorProvider ep;
    }
}