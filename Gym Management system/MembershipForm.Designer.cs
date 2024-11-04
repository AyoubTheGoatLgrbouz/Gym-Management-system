namespace Gym_Management_system
{
    partial class MembershipForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.cmbMembershipType = new System.Windows.Forms.ComboBox();
            this.membershipTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet1 = new Gym_Management_system.Database1DataSet1();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsernameID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.membershipTypesTableAdapter = new Gym_Management_system.Database1DataSet1TableAdapters.MembershipTypesTableAdapter();
            this.listViewMembershipInfo = new System.Windows.Forms.ListView();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.membershipTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.Location = new System.Drawing.Point(153, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "Purchase";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbMembershipType
            // 
            this.cmbMembershipType.FormattingEnabled = true;
            this.cmbMembershipType.Location = new System.Drawing.Point(61, 130);
            this.cmbMembershipType.Name = "cmbMembershipType";
            this.cmbMembershipType.Size = new System.Drawing.Size(196, 24);
            this.cmbMembershipType.TabIndex = 0;
            this.cmbMembershipType.SelectedIndexChanged += new System.EventHandler(this.cmbMembershipType_SelectedIndexChanged);
            // 
            // membershipTypesBindingSource
            // 
            this.membershipTypesBindingSource.DataMember = "MembershipTypes";
            this.membershipTypesBindingSource.DataSource = this.database1DataSet1;
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet1";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type of Membership:";
            // 
            // txtUsernameID
            // 
            this.txtUsernameID.Location = new System.Drawing.Point(61, 57);
            this.txtUsernameID.Name = "txtUsernameID";
            this.txtUsernameID.Size = new System.Drawing.Size(196, 22);
            this.txtUsernameID.TabIndex = 11;
            this.txtUsernameID.TextChanged += new System.EventHandler(this.txtUsernameID_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Username :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(61, 210);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 12;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Start Date:";
            // 
            // membershipTypesTableAdapter
            // 
            this.membershipTypesTableAdapter.ClearBeforeFill = true;
            // 
            // listViewMembershipInfo
            // 
            this.listViewMembershipInfo.HideSelection = false;
            this.listViewMembershipInfo.Location = new System.Drawing.Point(303, 38);
            this.listViewMembershipInfo.Name = "listViewMembershipInfo";
            this.listViewMembershipInfo.Size = new System.Drawing.Size(259, 244);
            this.listViewMembershipInfo.TabIndex = 14;
            this.listViewMembershipInfo.UseCompatibleStateImageBehavior = false;
            this.listViewMembershipInfo.SelectedIndexChanged += new System.EventHandler(this.listViewMembershipInfo_SelectedIndexChanged);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonBack.Location = new System.Drawing.Point(346, 320);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(120, 36);
            this.buttonBack.TabIndex = 15;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // MembershipForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 368);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.listViewMembershipInfo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtUsernameID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMembershipType);
            this.Name = "MembershipForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Membership Page";
            this.Load += new System.EventHandler(this.MembershipForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.membershipTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbMembershipType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsernameID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private Database1DataSet1 database1DataSet1;
        private System.Windows.Forms.BindingSource membershipTypesBindingSource;
        private Database1DataSet1TableAdapters.MembershipTypesTableAdapter membershipTypesTableAdapter;
        private System.Windows.Forms.ListView listViewMembershipInfo;
        private System.Windows.Forms.Button buttonBack;
    }
}