namespace MilEncryptor
{
    partial class MainWindow
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
            TabControl = new TabControl();
            tabPage1 = new TabPage();
            EncryptButton = new Button();
            AuthorityComboBox = new ComboBox();
            AuthorityLabel = new Label();
            DllTestButton = new Button();
            ClassComboBox = new ComboBox();
            ClassLabel = new Label();
            UseCompressCheckBox = new CheckBox();
            RotationsLabel = new Label();
            EnigmaRotationsCountTextBox = new TextBox();
            EnableEnigmaEncCheckBox = new CheckBox();
            EnigmaLabel = new Label();
            KeyEncLabel = new Label();
            PasswordEncTextBox = new TextBox();
            KeyTypeEncComboBox = new ComboBox();
            KeyTypeEncLabel = new Label();
            SelectFileToEncryptButton = new Button();
            SelectFileToEncLabel = new Label();
            EncryptToComboBox = new ComboBox();
            EncryptToLabel = new Label();
            AlgorithmLabel = new Label();
            AlgorithmComboBox = new ComboBox();
            LeaveOrigNamesCheckBox = new CheckBox();
            DeleteAfterEncCheckBox = new CheckBox();
            OptionsLabel = new Label();
            InputDatatypeLabel = new Label();
            EncryptDatatypeComboBox = new ComboBox();
            tabPage2 = new TabPage();
            ProgressLabel = new Label();
            MainProgressBar = new ProgressBar();
            SelectFolderToEncryptButton = new Button();
            TabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // TabControl
            // 
            TabControl.Controls.Add(tabPage1);
            TabControl.Controls.Add(tabPage2);
            TabControl.Location = new Point(12, 12);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(601, 362);
            TabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(SelectFolderToEncryptButton);
            tabPage1.Controls.Add(EncryptButton);
            tabPage1.Controls.Add(AuthorityComboBox);
            tabPage1.Controls.Add(AuthorityLabel);
            tabPage1.Controls.Add(DllTestButton);
            tabPage1.Controls.Add(ClassComboBox);
            tabPage1.Controls.Add(ClassLabel);
            tabPage1.Controls.Add(UseCompressCheckBox);
            tabPage1.Controls.Add(RotationsLabel);
            tabPage1.Controls.Add(EnigmaRotationsCountTextBox);
            tabPage1.Controls.Add(EnableEnigmaEncCheckBox);
            tabPage1.Controls.Add(EnigmaLabel);
            tabPage1.Controls.Add(KeyEncLabel);
            tabPage1.Controls.Add(PasswordEncTextBox);
            tabPage1.Controls.Add(KeyTypeEncComboBox);
            tabPage1.Controls.Add(KeyTypeEncLabel);
            tabPage1.Controls.Add(SelectFileToEncryptButton);
            tabPage1.Controls.Add(SelectFileToEncLabel);
            tabPage1.Controls.Add(EncryptToComboBox);
            tabPage1.Controls.Add(EncryptToLabel);
            tabPage1.Controls.Add(AlgorithmLabel);
            tabPage1.Controls.Add(AlgorithmComboBox);
            tabPage1.Controls.Add(LeaveOrigNamesCheckBox);
            tabPage1.Controls.Add(DeleteAfterEncCheckBox);
            tabPage1.Controls.Add(OptionsLabel);
            tabPage1.Controls.Add(InputDatatypeLabel);
            tabPage1.Controls.Add(EncryptDatatypeComboBox);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(593, 334);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Encrypt";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // EncryptButton
            // 
            EncryptButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            EncryptButton.Location = new Point(254, 267);
            EncryptButton.Name = "EncryptButton";
            EncryptButton.Size = new Size(333, 27);
            EncryptButton.TabIndex = 27;
            EncryptButton.Text = "ENCRYPT";
            EncryptButton.UseVisualStyleBackColor = true;
            EncryptButton.Click += EncryptButton_Click;
            // 
            // AuthorityComboBox
            // 
            AuthorityComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            AuthorityComboBox.FormattingEnabled = true;
            AuthorityComboBox.Items.AddRange(new object[] { "NATO", "DoD", "FBI", "CIA", "NSA", "INTERPOL", "MOSSAD", "NCIS", "NAVY" });
            AuthorityComboBox.Location = new Point(91, 168);
            AuthorityComboBox.Name = "AuthorityComboBox";
            AuthorityComboBox.Size = new Size(157, 23);
            AuthorityComboBox.TabIndex = 26;
            // 
            // AuthorityLabel
            // 
            AuthorityLabel.AutoSize = true;
            AuthorityLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            AuthorityLabel.Location = new Point(7, 166);
            AuthorityLabel.Name = "AuthorityLabel";
            AuthorityLabel.Size = new Size(78, 21);
            AuthorityLabel.TabIndex = 25;
            AuthorityLabel.Text = "Authority:";
            // 
            // DllTestButton
            // 
            DllTestButton.Location = new Point(266, 133);
            DllTestButton.Name = "DllTestButton";
            DllTestButton.Size = new Size(309, 23);
            DllTestButton.TabIndex = 24;
            DllTestButton.Text = "Test DLL File";
            DllTestButton.UseVisualStyleBackColor = true;
            DllTestButton.Click += DllTestButton_Click;
            // 
            // ClassComboBox
            // 
            ClassComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ClassComboBox.FormattingEnabled = true;
            ClassComboBox.Items.AddRange(new object[] { "UNCLASSIFIED", "RESTRICTED", "CONFIDENTIAL", "SECRET", "TOP SECRET" });
            ClassComboBox.Location = new Point(61, 137);
            ClassComboBox.Name = "ClassComboBox";
            ClassComboBox.Size = new Size(187, 23);
            ClassComboBox.TabIndex = 23;
            // 
            // ClassLabel
            // 
            ClassLabel.AutoSize = true;
            ClassLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            ClassLabel.Location = new Point(6, 137);
            ClassLabel.Name = "ClassLabel";
            ClassLabel.Size = new Size(49, 21);
            ClassLabel.TabIndex = 22;
            ClassLabel.Text = "Class:";
            // 
            // UseCompressCheckBox
            // 
            UseCompressCheckBox.AutoSize = true;
            UseCompressCheckBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            UseCompressCheckBox.Location = new Point(267, 104);
            UseCompressCheckBox.Name = "UseCompressCheckBox";
            UseCompressCheckBox.Size = new Size(158, 25);
            UseCompressCheckBox.TabIndex = 21;
            UseCompressCheckBox.Text = "Use Compression?";
            UseCompressCheckBox.UseVisualStyleBackColor = true;
            // 
            // RotationsLabel
            // 
            RotationsLabel.AutoSize = true;
            RotationsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            RotationsLabel.Location = new Point(267, 228);
            RotationsLabel.Name = "RotationsLabel";
            RotationsLabel.Size = new Size(79, 21);
            RotationsLabel.TabIndex = 20;
            RotationsLabel.Text = "Rotations:";
            // 
            // EnigmaRotationsCountTextBox
            // 
            EnigmaRotationsCountTextBox.BorderStyle = BorderStyle.FixedSingle;
            EnigmaRotationsCountTextBox.Location = new Point(352, 230);
            EnigmaRotationsCountTextBox.Name = "EnigmaRotationsCountTextBox";
            EnigmaRotationsCountTextBox.Size = new Size(224, 23);
            EnigmaRotationsCountTextBox.TabIndex = 19;
            // 
            // EnableEnigmaEncCheckBox
            // 
            EnableEnigmaEncCheckBox.AutoSize = true;
            EnableEnigmaEncCheckBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            EnableEnigmaEncCheckBox.Location = new Point(373, 194);
            EnableEnigmaEncCheckBox.Name = "EnableEnigmaEncCheckBox";
            EnableEnigmaEncCheckBox.Size = new Size(97, 29);
            EnableEnigmaEncCheckBox.TabIndex = 18;
            EnableEnigmaEncCheckBox.Text = "Enable?";
            EnableEnigmaEncCheckBox.UseVisualStyleBackColor = true;
            // 
            // EnigmaLabel
            // 
            EnigmaLabel.BorderStyle = BorderStyle.FixedSingle;
            EnigmaLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            EnigmaLabel.Location = new Point(254, 168);
            EnigmaLabel.Name = "EnigmaLabel";
            EnigmaLabel.Size = new Size(333, 96);
            EnigmaLabel.TabIndex = 17;
            EnigmaLabel.Text = "ENIGMA";
            EnigmaLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // KeyEncLabel
            // 
            KeyEncLabel.AutoSize = true;
            KeyEncLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            KeyEncLabel.Location = new Point(7, 303);
            KeyEncLabel.Name = "KeyEncLabel";
            KeyEncLabel.Size = new Size(38, 21);
            KeyEncLabel.TabIndex = 16;
            KeyEncLabel.Text = "Key:";
            // 
            // PasswordEncTextBox
            // 
            PasswordEncTextBox.BorderStyle = BorderStyle.FixedSingle;
            PasswordEncTextBox.Location = new Point(50, 303);
            PasswordEncTextBox.Name = "PasswordEncTextBox";
            PasswordEncTextBox.Size = new Size(537, 23);
            PasswordEncTextBox.TabIndex = 15;
            // 
            // KeyTypeEncComboBox
            // 
            KeyTypeEncComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            KeyTypeEncComboBox.FormattingEnabled = true;
            KeyTypeEncComboBox.Items.AddRange(new object[] { "HEX 128/192 or 256 bit", "String Password (MAX 32)" });
            KeyTypeEncComboBox.Location = new Point(86, 108);
            KeyTypeEncComboBox.Name = "KeyTypeEncComboBox";
            KeyTypeEncComboBox.Size = new Size(162, 23);
            KeyTypeEncComboBox.TabIndex = 14;
            // 
            // KeyTypeEncLabel
            // 
            KeyTypeEncLabel.AutoSize = true;
            KeyTypeEncLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            KeyTypeEncLabel.Location = new Point(6, 108);
            KeyTypeEncLabel.Name = "KeyTypeEncLabel";
            KeyTypeEncLabel.Size = new Size(74, 21);
            KeyTypeEncLabel.TabIndex = 13;
            KeyTypeEncLabel.Text = "Key Type:";
            // 
            // SelectFileToEncryptButton
            // 
            SelectFileToEncryptButton.Enabled = false;
            SelectFileToEncryptButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            SelectFileToEncryptButton.Location = new Point(22, 231);
            SelectFileToEncryptButton.Name = "SelectFileToEncryptButton";
            SelectFileToEncryptButton.Size = new Size(102, 51);
            SelectFileToEncryptButton.TabIndex = 10;
            SelectFileToEncryptButton.Text = "File";
            SelectFileToEncryptButton.UseVisualStyleBackColor = true;
            SelectFileToEncryptButton.Click += SelectFileToEncryptButton_Click;
            // 
            // SelectFileToEncLabel
            // 
            SelectFileToEncLabel.BorderStyle = BorderStyle.FixedSingle;
            SelectFileToEncLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            SelectFileToEncLabel.Location = new Point(7, 200);
            SelectFileToEncLabel.Name = "SelectFileToEncLabel";
            SelectFileToEncLabel.Size = new Size(242, 94);
            SelectFileToEncLabel.TabIndex = 9;
            SelectFileToEncLabel.Text = "SELECT DATA TO ENCRYPT:";
            SelectFileToEncLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // EncryptToComboBox
            // 
            EncryptToComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            EncryptToComboBox.FormattingEnabled = true;
            EncryptToComboBox.Items.AddRange(new object[] { "Datafiles", "Pakchunk" });
            EncryptToComboBox.Location = new Point(95, 79);
            EncryptToComboBox.Name = "EncryptToComboBox";
            EncryptToComboBox.Size = new Size(153, 23);
            EncryptToComboBox.TabIndex = 8;
            // 
            // EncryptToLabel
            // 
            EncryptToLabel.AutoSize = true;
            EncryptToLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            EncryptToLabel.Location = new Point(6, 77);
            EncryptToLabel.Name = "EncryptToLabel";
            EncryptToLabel.Size = new Size(84, 21);
            EncryptToLabel.TabIndex = 7;
            EncryptToLabel.Text = "Encrypt To:";
            // 
            // AlgorithmLabel
            // 
            AlgorithmLabel.AutoSize = true;
            AlgorithmLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            AlgorithmLabel.Location = new Point(6, 49);
            AlgorithmLabel.Name = "AlgorithmLabel";
            AlgorithmLabel.Size = new Size(83, 21);
            AlgorithmLabel.TabIndex = 6;
            AlgorithmLabel.Text = "Algorithm:";
            // 
            // AlgorithmComboBox
            // 
            AlgorithmComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            AlgorithmComboBox.FormattingEnabled = true;
            AlgorithmComboBox.Items.AddRange(new object[] { "DSAR", "MILSAT-4570", "KY-99", "THALES3000", "RM10-CRY70" });
            AlgorithmComboBox.Location = new Point(95, 49);
            AlgorithmComboBox.Name = "AlgorithmComboBox";
            AlgorithmComboBox.Size = new Size(153, 23);
            AlgorithmComboBox.TabIndex = 5;
            // 
            // LeaveOrigNamesCheckBox
            // 
            LeaveOrigNamesCheckBox.AutoSize = true;
            LeaveOrigNamesCheckBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            LeaveOrigNamesCheckBox.Location = new Point(267, 73);
            LeaveOrigNamesCheckBox.Name = "LeaveOrigNamesCheckBox";
            LeaveOrigNamesCheckBox.Size = new Size(209, 25);
            LeaveOrigNamesCheckBox.TabIndex = 4;
            LeaveOrigNamesCheckBox.Text = "Leave the original names?";
            LeaveOrigNamesCheckBox.UseVisualStyleBackColor = true;
            // 
            // DeleteAfterEncCheckBox
            // 
            DeleteAfterEncCheckBox.AutoSize = true;
            DeleteAfterEncCheckBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            DeleteAfterEncCheckBox.Location = new Point(267, 42);
            DeleteAfterEncCheckBox.Name = "DeleteAfterEncCheckBox";
            DeleteAfterEncCheckBox.Size = new Size(194, 25);
            DeleteAfterEncCheckBox.TabIndex = 2;
            DeleteAfterEncCheckBox.Text = "Delete after encryption?";
            DeleteAfterEncCheckBox.UseVisualStyleBackColor = true;
            // 
            // OptionsLabel
            // 
            OptionsLabel.BorderStyle = BorderStyle.FixedSingle;
            OptionsLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            OptionsLabel.Location = new Point(254, 15);
            OptionsLabel.Name = "OptionsLabel";
            OptionsLabel.Size = new Size(333, 145);
            OptionsLabel.TabIndex = 3;
            OptionsLabel.Text = "OPTIONS";
            OptionsLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // InputDatatypeLabel
            // 
            InputDatatypeLabel.AutoSize = true;
            InputDatatypeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            InputDatatypeLabel.Location = new Point(6, 18);
            InputDatatypeLabel.Name = "InputDatatypeLabel";
            InputDatatypeLabel.Size = new Size(115, 21);
            InputDatatypeLabel.TabIndex = 1;
            InputDatatypeLabel.Text = "Input Datatype:";
            // 
            // EncryptDatatypeComboBox
            // 
            EncryptDatatypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            EncryptDatatypeComboBox.FormattingEnabled = true;
            EncryptDatatypeComboBox.Items.AddRange(new object[] { "File", "Folder" });
            EncryptDatatypeComboBox.Location = new Point(127, 20);
            EncryptDatatypeComboBox.Name = "EncryptDatatypeComboBox";
            EncryptDatatypeComboBox.Size = new Size(121, 23);
            EncryptDatatypeComboBox.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(593, 334);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Decrypt";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // ProgressLabel
            // 
            ProgressLabel.AutoSize = true;
            ProgressLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            ProgressLabel.Location = new Point(16, 380);
            ProgressLabel.Name = "ProgressLabel";
            ProgressLabel.Size = new Size(74, 21);
            ProgressLabel.TabIndex = 12;
            ProgressLabel.Text = "Progress:";
            // 
            // MainProgressBar
            // 
            MainProgressBar.Location = new Point(98, 380);
            MainProgressBar.Name = "MainProgressBar";
            MainProgressBar.Size = new Size(511, 23);
            MainProgressBar.TabIndex = 11;
            // 
            // SelectFolderToEncryptButton
            // 
            SelectFolderToEncryptButton.Enabled = false;
            SelectFolderToEncryptButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            SelectFolderToEncryptButton.Location = new Point(130, 231);
            SelectFolderToEncryptButton.Name = "SelectFolderToEncryptButton";
            SelectFolderToEncryptButton.Size = new Size(102, 51);
            SelectFolderToEncryptButton.TabIndex = 28;
            SelectFolderToEncryptButton.Text = "Folder";
            SelectFolderToEncryptButton.UseVisualStyleBackColor = true;
            SelectFolderToEncryptButton.Click += SelectFolderToEncryptButton_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 415);
            Controls.Add(TabControl);
            Controls.Add(MainProgressBar);
            Controls.Add(ProgressLabel);
            Name = "MainWindow";
            Text = "DSAR - Military Encryptor";
            Load += Form1_Load;
            TabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl TabControl;
        private TabPage tabPage1;
        private ComboBox EncryptDatatypeComboBox;
        private TabPage tabPage2;
        private Label OptionsLabel;
        private CheckBox DeleteAfterEncCheckBox;
        private Label InputDatatypeLabel;
        private CheckBox LeaveOrigNamesCheckBox;
        private Label AlgorithmLabel;
        private ComboBox AlgorithmComboBox;
        private ComboBox EncryptToComboBox;
        private Label EncryptToLabel;
        private Label SelectFileToEncLabel;
        private Button SelectFileToEncryptButton;
        private Label ProgressLabel;
        private ProgressBar MainProgressBar;
        private ComboBox KeyTypeEncComboBox;
        private Label KeyTypeEncLabel;
        private Label KeyEncLabel;
        private TextBox PasswordEncTextBox;
        private CheckBox EnableEnigmaEncCheckBox;
        private Label EnigmaLabel;
        private Label RotationsLabel;
        private TextBox EnigmaRotationsCountTextBox;
        private CheckBox UseCompressCheckBox;
        private ComboBox ClassComboBox;
        private Label ClassLabel;
        private Button DllTestButton;
        private Label AuthorityLabel;
        private ComboBox AuthorityComboBox;
        private Button EncryptButton;
        private Button SelectFolderToEncryptButton;
    }
}
