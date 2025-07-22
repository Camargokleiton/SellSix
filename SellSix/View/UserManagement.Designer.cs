namespace SellSix.View
{
    partial class UserManagement
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
            tbUserName = new TextBox();
            lbUsername = new Label();
            lbDocument = new Label();
            tbDocument = new TextBox();
            lbEmail = new Label();
            tbEmail = new TextBox();
            lbAddress = new Label();
            tbAddress = new TextBox();
            lbFone = new Label();
            tbPhone = new TextBox();
            cbAccessLevel = new ComboBox();
            lbAccesLevel = new Label();
            lbCity = new Label();
            tbCity = new TextBox();
            tvUsers = new TreeView();
            panel1 = new Panel();
            btShowPass = new Button();
            lbPass = new Label();
            tbPass = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tbUserName
            // 
            tbUserName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbUserName.BackColor = SystemColors.ButtonHighlight;
            tbUserName.BorderStyle = BorderStyle.FixedSingle;
            tbUserName.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbUserName.Location = new Point(8, 49);
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new Size(326, 26);
            tbUserName.TabIndex = 0;
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbUsername.ForeColor = SystemColors.ActiveCaptionText;
            lbUsername.Location = new Point(8, 26);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(114, 20);
            lbUsername.TabIndex = 1;
            lbUsername.Text = "Nome do Usuário";
            // 
            // lbDocument
            // 
            lbDocument.AutoSize = true;
            lbDocument.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbDocument.ForeColor = SystemColors.ActiveCaptionText;
            lbDocument.Location = new Point(8, 76);
            lbDocument.Name = "lbDocument";
            lbDocument.Size = new Size(77, 20);
            lbDocument.TabIndex = 3;
            lbDocument.Text = "Documento";
            // 
            // tbDocument
            // 
            tbDocument.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbDocument.BackColor = SystemColors.ButtonHighlight;
            tbDocument.BorderStyle = BorderStyle.FixedSingle;
            tbDocument.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbDocument.Location = new Point(8, 99);
            tbDocument.Name = "tbDocument";
            tbDocument.Size = new Size(326, 26);
            tbDocument.TabIndex = 2;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbEmail.ForeColor = SystemColors.ActiveCaptionText;
            lbEmail.Location = new Point(8, 228);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(42, 20);
            lbEmail.TabIndex = 7;
            lbEmail.Text = "Email";
            // 
            // tbEmail
            // 
            tbEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbEmail.BackColor = SystemColors.ButtonHighlight;
            tbEmail.BorderStyle = BorderStyle.FixedSingle;
            tbEmail.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbEmail.Location = new Point(8, 251);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(326, 26);
            tbEmail.TabIndex = 6;
            // 
            // lbAddress
            // 
            lbAddress.AutoSize = true;
            lbAddress.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbAddress.ForeColor = SystemColors.ActiveCaptionText;
            lbAddress.Location = new Point(8, 127);
            lbAddress.Name = "lbAddress";
            lbAddress.Size = new Size(68, 20);
            lbAddress.TabIndex = 5;
            lbAddress.Text = "Endereço";
            // 
            // tbAddress
            // 
            tbAddress.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbAddress.BackColor = SystemColors.ButtonHighlight;
            tbAddress.BorderStyle = BorderStyle.FixedSingle;
            tbAddress.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbAddress.Location = new Point(8, 150);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(326, 26);
            tbAddress.TabIndex = 4;
            // 
            // lbFone
            // 
            lbFone.AutoSize = true;
            lbFone.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbFone.ForeColor = SystemColors.ActiveCaptionText;
            lbFone.Location = new Point(8, 278);
            lbFone.Name = "lbFone";
            lbFone.Size = new Size(40, 20);
            lbFone.TabIndex = 9;
            lbFone.Text = "Fone";
            // 
            // tbPhone
            // 
            tbPhone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbPhone.BackColor = SystemColors.ButtonHighlight;
            tbPhone.BorderStyle = BorderStyle.FixedSingle;
            tbPhone.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPhone.Location = new Point(8, 301);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(326, 26);
            tbPhone.TabIndex = 8;
            // 
            // cbAccessLevel
            // 
            cbAccessLevel.FormattingEnabled = true;
            cbAccessLevel.Location = new Point(8, 409);
            cbAccessLevel.Name = "cbAccessLevel";
            cbAccessLevel.Size = new Size(153, 23);
            cbAccessLevel.TabIndex = 10;
            // 
            // lbAccesLevel
            // 
            lbAccesLevel.AutoSize = true;
            lbAccesLevel.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbAccesLevel.ForeColor = SystemColors.ActiveCaptionText;
            lbAccesLevel.Location = new Point(8, 387);
            lbAccesLevel.Name = "lbAccesLevel";
            lbAccesLevel.Size = new Size(107, 20);
            lbAccesLevel.TabIndex = 9;
            lbAccesLevel.Text = "Nivel de acesso";
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCity.ForeColor = SystemColors.ActiveCaptionText;
            lbCity.Location = new Point(8, 178);
            lbCity.Name = "lbCity";
            lbCity.Size = new Size(52, 20);
            lbCity.TabIndex = 12;
            lbCity.Text = "Cidade";
            // 
            // tbCity
            // 
            tbCity.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbCity.BackColor = SystemColors.ButtonHighlight;
            tbCity.BorderStyle = BorderStyle.FixedSingle;
            tbCity.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbCity.Location = new Point(8, 201);
            tbCity.Name = "tbCity";
            tbCity.Size = new Size(326, 26);
            tbCity.TabIndex = 11;
            // 
            // tvUsers
            // 
            tvUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            tvUsers.Location = new Point(436, 26);
            tvUsers.Name = "tvUsers";
            tvUsers.ShowLines = false;
            tvUsers.Size = new Size(326, 389);
            tvUsers.TabIndex = 13;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btShowPass);
            panel1.Controls.Add(lbPass);
            panel1.Controls.Add(tbPass);
            panel1.Controls.Add(tvUsers);
            panel1.Controls.Add(lbUsername);
            panel1.Controls.Add(tbUserName);
            panel1.Controls.Add(lbCity);
            panel1.Controls.Add(tbDocument);
            panel1.Controls.Add(tbCity);
            panel1.Controls.Add(lbDocument);
            panel1.Controls.Add(cbAccessLevel);
            panel1.Controls.Add(tbAddress);
            panel1.Controls.Add(lbAccesLevel);
            panel1.Controls.Add(lbAddress);
            panel1.Controls.Add(lbFone);
            panel1.Controls.Add(tbEmail);
            panel1.Controls.Add(tbPhone);
            panel1.Controls.Add(lbEmail);
            panel1.Dock = DockStyle.Fill;
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 14;
            // 
            // btShowPass
            // 
            btShowPass.Image = Properties.Resources.visibility;
            btShowPass.Location = new Point(336, 349);
            btShowPass.Name = "btShowPass";
            btShowPass.Size = new Size(45, 34);
            btShowPass.TabIndex = 16;
            btShowPass.UseVisualStyleBackColor = true;
            btShowPass.Click += btShowPass_Click;
            // 
            // lbPass
            // 
            lbPass.AutoSize = true;
            lbPass.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbPass.ForeColor = SystemColors.ActiveCaptionText;
            lbPass.Location = new Point(8, 330);
            lbPass.Name = "lbPass";
            lbPass.Size = new Size(47, 20);
            lbPass.TabIndex = 15;
            lbPass.Text = "Senha";
            // 
            // tbPass
            // 
            tbPass.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbPass.BackColor = SystemColors.ButtonHighlight;
            tbPass.BorderStyle = BorderStyle.FixedSingle;
            tbPass.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPass.Location = new Point(8, 353);
            tbPass.Name = "tbPass";
            tbPass.Size = new Size(326, 26);
            tbPass.TabIndex = 14;
            // 
            // UserManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Name = "UserManagement";
            Size = new Size(800, 450);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbUserName;
        private Label lbUsername;
        private Label lbDocument;
        private TextBox tbDocument;
        private Label lbEmail;
        private TextBox tbEmail;
        private Label lbAddress;
        private TextBox tbAddress;
        private Label lbFone;
        private TextBox tbPhone;
        private ComboBox cbAccessLevel;
        private Label lbAccesLevel;
        private Label lbCity;
        private TextBox tbCity;
        private TreeView tvUsers;
        private Panel panel1;
        private Label lbPass;
        private TextBox tbPass;
        private Button btShowPass;
    }
}