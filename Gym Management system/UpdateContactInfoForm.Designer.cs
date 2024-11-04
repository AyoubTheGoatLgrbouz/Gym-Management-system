namespace Gym_Management_system
{
    partial class UpdateContactInfoForm
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
            this.btnSaveContactInfo = new System.Windows.Forms.Button();
            this.lblNewNumber = new System.Windows.Forms.Label();
            this.txtNewNumber = new System.Windows.Forms.TextBox();
            this.lblNewPostCode = new System.Windows.Forms.Label();
            this.txtNewPostCode = new System.Windows.Forms.TextBox();
            this.lblNewEmail = new System.Windows.Forms.Label();
            this.txtNewEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSaveContactInfo
            // 
            this.btnSaveContactInfo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnSaveContactInfo.Location = new System.Drawing.Point(403, 200);
            this.btnSaveContactInfo.Name = "btnSaveContactInfo";
            this.btnSaveContactInfo.Size = new System.Drawing.Size(92, 33);
            this.btnSaveContactInfo.TabIndex = 15;
            this.btnSaveContactInfo.Text = "Save";
            this.btnSaveContactInfo.UseVisualStyleBackColor = false;
            this.btnSaveContactInfo.Click += new System.EventHandler(this.btnSaveContactInfo_Click_1);
            // 
            // lblNewNumber
            // 
            this.lblNewNumber.AutoSize = true;
            this.lblNewNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewNumber.Location = new System.Drawing.Point(48, 164);
            this.lblNewNumber.Name = "lblNewNumber";
            this.lblNewNumber.Size = new System.Drawing.Size(151, 18);
            this.lblNewNumber.TabIndex = 14;
            this.lblNewNumber.Text = "New Contact Number";
            // 
            // txtNewNumber
            // 
            this.txtNewNumber.Location = new System.Drawing.Point(51, 183);
            this.txtNewNumber.Name = "txtNewNumber";
            this.txtNewNumber.Size = new System.Drawing.Size(234, 22);
            this.txtNewNumber.TabIndex = 13;
            // 
            // lblNewPostCode
            // 
            this.lblNewPostCode.AutoSize = true;
            this.lblNewPostCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPostCode.Location = new System.Drawing.Point(48, 89);
            this.lblNewPostCode.Name = "lblNewPostCode";
            this.lblNewPostCode.Size = new System.Drawing.Size(109, 18);
            this.lblNewPostCode.TabIndex = 12;
            this.lblNewPostCode.Text = "New PostCode";
            // 
            // txtNewPostCode
            // 
            this.txtNewPostCode.Location = new System.Drawing.Point(51, 110);
            this.txtNewPostCode.Name = "txtNewPostCode";
            this.txtNewPostCode.Size = new System.Drawing.Size(234, 22);
            this.txtNewPostCode.TabIndex = 11;
            // 
            // lblNewEmail
            // 
            this.lblNewEmail.AutoSize = true;
            this.lblNewEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewEmail.Location = new System.Drawing.Point(48, 18);
            this.lblNewEmail.Name = "lblNewEmail";
            this.lblNewEmail.Size = new System.Drawing.Size(79, 18);
            this.lblNewEmail.TabIndex = 10;
            this.lblNewEmail.Text = "New Email";
            // 
            // txtNewEmail
            // 
            this.txtNewEmail.Location = new System.Drawing.Point(51, 37);
            this.txtNewEmail.Name = "txtNewEmail";
            this.txtNewEmail.Size = new System.Drawing.Size(234, 22);
            this.txtNewEmail.TabIndex = 9;
            // 
            // UpdateContactInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 250);
            this.Controls.Add(this.btnSaveContactInfo);
            this.Controls.Add(this.lblNewNumber);
            this.Controls.Add(this.txtNewNumber);
            this.Controls.Add(this.lblNewPostCode);
            this.Controls.Add(this.txtNewPostCode);
            this.Controls.Add(this.lblNewEmail);
            this.Controls.Add(this.txtNewEmail);
            this.Name = "UpdateContactInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Contact Info ";
            this.Load += new System.EventHandler(this.UpdateContactInfoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveContactInfo;
        private System.Windows.Forms.Label lblNewNumber;
        private System.Windows.Forms.TextBox txtNewNumber;
        private System.Windows.Forms.Label lblNewPostCode;
        private System.Windows.Forms.TextBox txtNewPostCode;
        private System.Windows.Forms.Label lblNewEmail;
        private System.Windows.Forms.TextBox txtNewEmail;
    }
}