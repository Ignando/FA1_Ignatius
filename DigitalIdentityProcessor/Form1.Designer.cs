namespace DigitalIdentityProcessor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelHeader = new Panel();
            btnMinimize = new Button();
            btnClose = new Button();
            lblStatus = new Label();
            lblSubtitle = new Label();
            lblTitle = new Label();
            panelForm = new Panel();
            btnClear = new Button();
            btnGenerateProfile = new Button();
            btnValidate = new Button();
            cmbCitizenship = new ComboBox();
            txtIdNumber = new TextBox();
            txtName = new TextBox();
            lblCitizenship = new Label();
            lblIdNumber = new Label();
            lblName = new Label();
            panelOutput = new Panel();
            listViewProfiles = new ListView();
            columnHeaderName = new ColumnHeader();
            columnHeaderId = new ColumnHeader();
            columnHeaderAge = new ColumnHeader();
            columnHeaderCitizenship = new ColumnHeader();
            columnHeaderValidation = new ColumnHeader();
            txtValidation = new TextBox();
            lblRecords = new Label();
            panelHeader.SuspendLayout();
            panelForm.SuspendLayout();
            panelOutput.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(btnMinimize);
            panelHeader.Controls.Add(btnClose);
            panelHeader.Controls.Add(lblStatus);
            panelHeader.Controls.Add(lblSubtitle);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Location = new Point(24, 22);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(932, 105);
            panelHeader.TabIndex = 0;
            panelHeader.MouseDown += panelHeader_MouseDown;
            // 
            // btnMinimize
            // 
            btnMinimize.Location = new Point(822, 18);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(40, 32);
            btnMinimize.TabIndex = 4;
            btnMinimize.Text = "–";
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(872, 18);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(40, 32);
            btnClose.TabIndex = 3;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStatus.Location = new Point(28, 68);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(141, 19);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "Status: Ready for scan";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.Location = new Point(31, 41);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(364, 19);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Neon registry for identity validation, age parsing, and records";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblTitle.Location = new Point(24, 8);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(301, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Digital Identity Processor";
            // 
            // panelForm
            // 
            panelForm.Controls.Add(btnClear);
            panelForm.Controls.Add(btnGenerateProfile);
            panelForm.Controls.Add(btnValidate);
            panelForm.Controls.Add(cmbCitizenship);
            panelForm.Controls.Add(txtIdNumber);
            panelForm.Controls.Add(txtName);
            panelForm.Controls.Add(lblCitizenship);
            panelForm.Controls.Add(lblIdNumber);
            panelForm.Controls.Add(lblName);
            panelForm.Location = new Point(24, 148);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(313, 405);
            panelForm.TabIndex = 1;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClear.Location = new Point(31, 329);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(242, 38);
            btnClear.TabIndex = 8;
            btnClear.Text = "RESET GRID";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnGenerateProfile
            // 
            btnGenerateProfile.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGenerateProfile.Location = new Point(31, 275);
            btnGenerateProfile.Name = "btnGenerateProfile";
            btnGenerateProfile.Size = new Size(136, 38);
            btnGenerateProfile.TabIndex = 6;
            btnGenerateProfile.Text = "GENERATE PROFILE";
            btnGenerateProfile.UseVisualStyleBackColor = true;
            btnGenerateProfile.Click += btnGenerateProfile_Click;
            // 
            // btnValidate
            // 
            btnValidate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnValidate.Location = new Point(177, 275);
            btnValidate.Name = "btnValidate";
            btnValidate.Size = new Size(96, 38);
            btnValidate.TabIndex = 7;
            btnValidate.Text = "VALIDATE ID";
            btnValidate.UseVisualStyleBackColor = true;
            btnValidate.Click += btnValidate_Click;
            // 
            // cmbCitizenship
            // 
            cmbCitizenship.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCitizenship.Font = new Font("Segoe UI", 11F);
            cmbCitizenship.FormattingEnabled = true;
            cmbCitizenship.Items.AddRange(new object[] { "Citizen", "Permanent Resident", "Visitor" });
            cmbCitizenship.Location = new Point(31, 219);
            cmbCitizenship.Name = "cmbCitizenship";
            cmbCitizenship.Size = new Size(242, 28);
            cmbCitizenship.TabIndex = 5;
            // 
            // txtIdNumber
            // 
            txtIdNumber.Font = new Font("Segoe UI", 11F);
            txtIdNumber.Location = new Point(31, 138);
            txtIdNumber.MaxLength = 13;
            txtIdNumber.Name = "txtIdNumber";
            txtIdNumber.PlaceholderText = "0000000000000";
            txtIdNumber.Size = new Size(242, 27);
            txtIdNumber.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 11F);
            txtName.Location = new Point(31, 57);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Enter full name";
            txtName.Size = new Size(242, 27);
            txtName.TabIndex = 3;
            // 
            // lblCitizenship
            // 
            lblCitizenship.AutoSize = true;
            lblCitizenship.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCitizenship.Location = new Point(31, 189);
            lblCitizenship.Name = "lblCitizenship";
            lblCitizenship.Size = new Size(132, 19);
            lblCitizenship.TabIndex = 2;
            lblCitizenship.Text = "Citizenship Status";
            // 
            // lblIdNumber
            // 
            lblIdNumber.AutoSize = true;
            lblIdNumber.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblIdNumber.Location = new Point(31, 108);
            lblIdNumber.Name = "lblIdNumber";
            lblIdNumber.Size = new Size(79, 19);
            lblIdNumber.TabIndex = 1;
            lblIdNumber.Text = "ID Number";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblName.Location = new Point(31, 27);
            lblName.Name = "lblName";
            lblName.Size = new Size(77, 19);
            lblName.TabIndex = 0;
            lblName.Text = "Full Name";
            // 
            // panelOutput
            // 
            panelOutput.Controls.Add(listViewProfiles);
            panelOutput.Controls.Add(txtValidation);
            panelOutput.Controls.Add(lblRecords);
            panelOutput.Location = new Point(364, 148);
            panelOutput.Name = "panelOutput";
            panelOutput.Size = new Size(592, 405);
            panelOutput.TabIndex = 2;
            // 
            // listViewProfiles
            // 
            listViewProfiles.Columns.AddRange(new ColumnHeader[] { columnHeaderName, columnHeaderId, columnHeaderAge, columnHeaderCitizenship, columnHeaderValidation });
            listViewProfiles.FullRowSelect = true;
            listViewProfiles.GridLines = true;
            listViewProfiles.Location = new Point(23, 176);
            listViewProfiles.Name = "listViewProfiles";
            listViewProfiles.Size = new Size(546, 202);
            listViewProfiles.TabIndex = 2;
            listViewProfiles.UseCompatibleStateImageBehavior = false;
            listViewProfiles.View = View.Details;
            // 
            // columnHeaderName
            // 
            columnHeaderName.Text = "Name";
            columnHeaderName.Width = 110;
            // 
            // columnHeaderId
            // 
            columnHeaderId.Text = "ID Number";
            columnHeaderId.Width = 110;
            // 
            // columnHeaderAge
            // 
            columnHeaderAge.Text = "Age";
            columnHeaderAge.Width = 55;
            // 
            // columnHeaderCitizenship
            // 
            columnHeaderCitizenship.Text = "Citizenship";
            columnHeaderCitizenship.Width = 120;
            // 
            // columnHeaderValidation
            // 
            columnHeaderValidation.Text = "Validation";
            columnHeaderValidation.Width = 145;
            // 
            // txtValidation
            // 
            txtValidation.Font = new Font("Consolas", 10F);
            txtValidation.Location = new Point(23, 40);
            txtValidation.Multiline = true;
            txtValidation.Name = "txtValidation";
            txtValidation.ReadOnly = true;
            txtValidation.Size = new Size(546, 117);
            txtValidation.TabIndex = 1;
            // 
            // lblRecords
            // 
            lblRecords.AutoSize = true;
            lblRecords.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblRecords.Location = new Point(23, 15);
            lblRecords.Name = "lblRecords";
            lblRecords.Size = new Size(144, 19);
            lblRecords.TabIndex = 0;
            lblRecords.Text = "Validation Readout";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 579);
            Controls.Add(panelOutput);
            Controls.Add(panelForm);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Digital Identity Processor";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            panelOutput.ResumeLayout(false);
            panelOutput.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Button btnMinimize;
        private Button btnClose;
        private Label lblStatus;
        private Label lblSubtitle;
        private Label lblTitle;
        private Panel panelForm;
        private Button btnClear;
        private Button btnGenerateProfile;
        private Button btnValidate;
        private ComboBox cmbCitizenship;
        private TextBox txtIdNumber;
        private TextBox txtName;
        private Label lblCitizenship;
        private Label lblIdNumber;
        private Label lblName;
        private Panel panelOutput;
        private ListView listViewProfiles;
        private TextBox txtValidation;
        private Label lblRecords;
        private ColumnHeader columnHeaderName;
        private ColumnHeader columnHeaderId;
        private ColumnHeader columnHeaderAge;
        private ColumnHeader columnHeaderCitizenship;
        private ColumnHeader columnHeaderValidation;
    }
}
