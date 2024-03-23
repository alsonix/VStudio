using DSAR;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MilEncryptor
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DllTestButton_Click(object sender, EventArgs e)
        {
            try
            {
                string message = Encrypt.GetSuccessMessage(); // Získá zprávu z vaší knihovny
                MessageBox.Show(message, "Message"); // Zobrazí MessageBox s vaší zprávou
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            // Definitions BEGIN //
            // Definitions END //
            string header = string.Empty;
            int rotationsCount = int.Parse(EnigmaRotationsCountTextBox.Text);
            byte[] metadata = new byte[11];

            if (rotationsCount >= -22 && rotationsCount <= 22)
            {
                metadata[10] = (byte)(rotationsCount + 0x60);
            }
            else
            {
                MessageBox.Show("Hodnota musí být v rozmezí od -22 do 22.", "Chyba");
            }

            switch (EncryptDatatypeComboBox.SelectedItem.ToString())
            {
                case "File":
                    metadata[0] = 0x54;
                    break;
                case "Folder":
                    metadata[0] = 0x55;
                    break;
            }

            switch (AlgorithmComboBox.SelectedItem.ToString())
            {
                case "DSAR":
                    metadata[1] = 0xC6;
                    header = ".DSAR.mil!pakdata.conf";
                    break;
                case "MILSAT-4570":
                    metadata[1] = 0xC7;
                    header = "..*MILSAT.dhyvb.sys";
                    break;
                case "KY-99":
                    metadata[1] = 0xC8;
                    break;
                case "THALES3000":
                    metadata[1] = 0xC9;
                    break;
                case "RM10-CRY70":
                    metadata[1] = 0xCA;
                    break;
            }

            switch (EncryptToComboBox.SelectedItem.ToString())
            {
                case "Datafiles":
                    metadata[2] = 0xAD;
                    break;
                case "Pakchunk":
                    metadata[2] = 0xAE;
                    break;
            }

            switch (KeyTypeEncComboBox.SelectedItem.ToString())
            {
                case "HEX 128/192 or 256 bit":
                    metadata[3] = 0x37;
                    break;
                case "String Password (MAX 32)":
                    metadata[3] = 0x38;
                    break;
            }

            switch (ClassComboBox.SelectedItem.ToString())
            {
                case "UNCLASSIFIED":
                    metadata[4] = 0xB9;
                    break;
                case "RESTRICTED":
                    metadata[4] = 0xBA;
                    break;
                case "CONFIDENTIAL":
                    metadata[4] = 0xBB;
                    break;
                case "SECRET":
                    metadata[4] = 0xBC;
                    break;
                case "TOP SECRET":
                    metadata[4] = 0xBD;
                    break;
            }

            switch (AuthorityComboBox.SelectedItem.ToString())
            {
                case "NATO":
                    metadata[5] = 0x37;
                    break;
                case "DoD":
                    metadata[5] = 0x38;
                    break;
                case "FBI":
                    metadata[5] = 0x39;
                    break;
                case "CIA":
                    metadata[5] = 0x3A;
                    break;
                case "NSA":
                    metadata[5] = 0x3B;
                    break;
                case "INTERPOL":
                    metadata[5] = 0x3C;
                    break;
                case "MOSSAD":
                    metadata[5] = 0x3D;
                    break;
                case "NCIS":
                    metadata[5] = 0x3E;
                    break;
                case "NAVY":
                    metadata[5] = 0x3F;
                    break;
            }

            switch (DeleteAfterEncCheckBox.Checked)
            {
                case true:
                    metadata[6] = 0xF6; // Pokud je CheckBox zaškrtnutý
                    break;
                case false:
                    metadata[6] = 0xF7; // Pokud CheckBox není zaškrtnutý
                    break;
            }

            switch (LeaveOrigNamesCheckBox.Checked)
            {
                case true:
                    metadata[7] = 0xCC; // Pokud je CheckBox zaškrtnutý
                    break;
                case false:
                    metadata[7] = 0xCD; // Pokud CheckBox není zaškrtnutý
                    break;
            }

            switch (UseCompressCheckBox.Checked)
            {
                case true:
                    metadata[8] = 0x14; // Pokud je CheckBox zaškrtnutý
                    break;
                case false:
                    metadata[8] = 0x15; // Pokud CheckBox není zaškrtnutý
                    break;
            }

            switch (EnableEnigmaEncCheckBox.Checked)
            {
                case true:
                    metadata[9] = 0x97; // Pokud je CheckBox zaškrtnutý
                    break;
                case false:
                    metadata[9] = 0x98; // Pokud CheckBox není zaškrtnutý
                    break;
            }
            byte[] headerBytes = Encoding.ASCII.GetBytes(header);
            byte[] headerMetadata = new byte[metadata.Length + headerBytes.Length];
            Array.Copy(metadata, headerMetadata, metadata.Length);
            Array.Copy(headerBytes, 0, headerMetadata, metadata.Length, headerBytes.Length);

            // Uložení dat do souboru
            File.WriteAllBytes("data0.mil", headerMetadata);
        }

        private void SelectFileToEncryptButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog SelectedFileToEncrypt = new OpenFileDialog();
            SelectedFileToEncrypt.Filter = "All Files (*.*)|*.*";
            SelectedFileToEncrypt.Title = "Select a VIV File";

            if (SelectedFileToEncrypt.ShowDialog() == DialogResult.OK)
            {
                
            }
        }

        private void SelectFolderToEncryptButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string folderPath = folderBrowserDialog.SelectedPath;
                // Zde mùžete pracovat se složkou
            }
        }
    }
}