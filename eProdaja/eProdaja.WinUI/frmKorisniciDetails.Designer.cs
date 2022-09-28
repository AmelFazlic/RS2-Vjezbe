namespace eProdaja.WinUI
{
    partial class frmKorisniciDetails
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
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.Prezime = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxNSE = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPasswordConfirm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.clbRole = new System.Windows.Forms.CheckedListBox();
            this.cbStatus = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStripContainer1.SuspendLayout();
            this.groupBoxNSE.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(150, 150);
            this.toolStripContainer1.Location = new System.Drawing.Point(65, 25);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(150, 175);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(106, 35);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(195, 23);
            this.txtIme.TabIndex = 1;
            this.txtIme.Validating += new System.ComponentModel.CancelEventHandler(this.txtIme_Validating);
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(106, 71);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(195, 23);
            this.txtPrezime.TabIndex = 3;
            // 
            // Prezime
            // 
            this.Prezime.AutoSize = true;
            this.Prezime.Location = new System.Drawing.Point(15, 74);
            this.Prezime.Name = "Prezime";
            this.Prezime.Size = new System.Drawing.Size(49, 15);
            this.Prezime.TabIndex = 2;
            this.Prezime.Text = "Prezime";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(106, 109);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(195, 23);
            this.txtEmail.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email";
            // 
            // groupBoxNSE
            // 
            this.groupBoxNSE.Controls.Add(this.txtIme);
            this.groupBoxNSE.Controls.Add(this.txtEmail);
            this.groupBoxNSE.Controls.Add(this.label1);
            this.groupBoxNSE.Controls.Add(this.label3);
            this.groupBoxNSE.Controls.Add(this.Prezime);
            this.groupBoxNSE.Controls.Add(this.txtPrezime);
            this.groupBoxNSE.Location = new System.Drawing.Point(12, 12);
            this.groupBoxNSE.Name = "groupBoxNSE";
            this.groupBoxNSE.Size = new System.Drawing.Size(322, 155);
            this.groupBoxNSE.TabIndex = 6;
            this.groupBoxNSE.TabStop = false;
            this.groupBoxNSE.Text = "Podaci";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.txtPasswordConfirm);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Location = new System.Drawing.Point(12, 173);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 155);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podaci";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(106, 35);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(195, 23);
            this.txtUserName.TabIndex = 1;
            // 
            // txtPasswordConfirm
            // 
            this.txtPasswordConfirm.Location = new System.Drawing.Point(106, 109);
            this.txtPasswordConfirm.Name = "txtPasswordConfirm";
            this.txtPasswordConfirm.Size = new System.Drawing.Size(195, 23);
            this.txtPasswordConfirm.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Confirmation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(106, 71);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(195, 23);
            this.txtPassword.TabIndex = 3;
            // 
            // clbRole
            // 
            this.clbRole.FormattingEnabled = true;
            this.clbRole.Location = new System.Drawing.Point(12, 342);
            this.clbRole.Name = "clbRole";
            this.clbRole.Size = new System.Drawing.Size(93, 58);
            this.clbRole.TabIndex = 8;
            this.clbRole.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // cbStatus
            // 
            this.cbStatus.AutoSize = true;
            this.cbStatus.Location = new System.Drawing.Point(134, 342);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(58, 19);
            this.cbStatus.TabIndex = 9;
            this.cbStatus.Text = "Status";
            this.cbStatus.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(259, 412);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Sacuvaj";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmKorisniciDetails
            // 
            this.ClientSize = new System.Drawing.Size(346, 447);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.clbRole);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxNSE);
            this.Name = "frmKorisniciDetails";
            this.Load += new System.EventHandler(this.frmKorisniciDetails_Load_1);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.groupBoxNSE.ResumeLayout(false);
            this.groupBoxNSE.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStripContainer toolStripContainer1;
        private Label label1;
        private TextBox txtIme;
        private TextBox txtPrezime;
        private Label Prezime;
        private TextBox txtEmail;
        private Label label3;
        private GroupBox groupBoxNSE;
        private GroupBox groupBox1;
        private TextBox txtUserName;
        private TextBox txtPasswordConfirm;
        private Label label2;
        private Label label4;
        private Label label5;
        private TextBox txtPassword;
        private CheckedListBox clbRole;
        private CheckBox cbStatus;
        private Button btnSave;
        private ErrorProvider errorProvider1;
    }
}