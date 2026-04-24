using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DigitalIdentityProcessor
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        private const int WmNclButtonDown = 0xA1;
        private const int HtCaption = 0x2;
        private readonly List<CitizenProfile> profiles = new();
        private CitizenProfile? currentProfile;
        private string currentValidationMessage = "No validation has been run.";

        public Form1()
        {
            InitializeComponent();
            ApplyCyberpunkTheme();
        }

        private void ApplyCyberpunkTheme()
        {
            BackColor = Color.FromArgb(8, 10, 26);
            ForeColor = Color.FromArgb(232, 244, 255);

            var neonPink = Color.FromArgb(255, 46, 189);
            var neonBlue = Color.FromArgb(48, 227, 255);
            var panelColor = Color.FromArgb(18, 22, 48);
            var inputColor = Color.FromArgb(11, 15, 37);

            panelHeader.BackColor = panelColor;
            panelForm.BackColor = panelColor;
            panelOutput.BackColor = panelColor;
            panelHeader.BorderStyle = BorderStyle.FixedSingle;
            panelForm.BorderStyle = BorderStyle.FixedSingle;
            panelOutput.BorderStyle = BorderStyle.FixedSingle;

            lblTitle.ForeColor = neonBlue;
            lblSubtitle.ForeColor = Color.FromArgb(185, 194, 255);
            lblStatus.ForeColor = neonPink;

            foreach (Label label in new[] { lblName, lblIdNumber, lblCitizenship, lblRecords })
            {
                label.ForeColor = Color.FromArgb(210, 220, 255);
            }

            foreach (TextBox textBox in new[] { txtName, txtIdNumber, txtValidation })
            {
                textBox.BackColor = inputColor;
                textBox.ForeColor = Color.White;
                textBox.BorderStyle = BorderStyle.FixedSingle;
            }

            cmbCitizenship.BackColor = inputColor;
            cmbCitizenship.ForeColor = Color.White;
            cmbCitizenship.FlatStyle = FlatStyle.Flat;

            listViewProfiles.BackColor = inputColor;
            listViewProfiles.ForeColor = Color.White;
            listViewProfiles.BorderStyle = BorderStyle.FixedSingle;

            ConfigureButton(btnValidate, neonBlue, Color.Black);
            ConfigureButton(btnGenerateProfile, neonPink, Color.White);
            ConfigureButton(btnClear, neonPink, Color.White);
            ConfigureWindowButton(btnMinimize, Color.FromArgb(255, 196, 0), Color.Black);
            ConfigureWindowButton(btnClose, neonPink, Color.White);
        }

        private static void ConfigureButton(Button button, Color backColor, Color foreColor)
        {
            button.BackColor = backColor;
            button.ForeColor = foreColor;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
        }

        private static void ConfigureWindowButton(Button button, Color backColor, Color foreColor)
        {
            ConfigureButton(button, backColor, foreColor);
            button.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            var fullName = txtName.Text.Trim();
            var idNumber = txtIdNumber.Text.Trim();
            var citizenship = cmbCitizenship.Text.Trim();

            if (string.IsNullOrWhiteSpace(fullName) ||
                string.IsNullOrWhiteSpace(idNumber) ||
                string.IsNullOrWhiteSpace(citizenship))
            {
                txtValidation.Text = "All fields are required before processing an identity profile.";
                lblStatus.Text = "Status: Missing input";
                currentProfile = null;
                currentValidationMessage = "Validation failed due to missing input.";
                return;
            }

            currentProfile = new CitizenProfile(fullName, idNumber, citizenship);
            currentValidationMessage = currentProfile.ValidateID();

            txtValidation.Text =
                $"Validation Scan{Environment.NewLine}" +
                $"Name: {currentProfile.FullName}{Environment.NewLine}" +
                $"ID Number: {currentProfile.IDNumber}{Environment.NewLine}" +
                $"Age: {currentProfile.Age}{Environment.NewLine}" +
                $"Citizenship: {currentProfile.CitizenshipStatus}{Environment.NewLine}" +
                $"Validation: {currentValidationMessage}";

            lblStatus.Text = currentValidationMessage.StartsWith("Valid", StringComparison.OrdinalIgnoreCase)
                ? "Status: Identity accepted"
                : "Status: Identity flagged";
        }

        private void btnGenerateProfile_Click(object sender, EventArgs e)
        {
            if (currentProfile is null)
            {
                txtValidation.Text = "Run Validate ID before generating the profile summary.";
                lblStatus.Text = "Status: Validation required";
                return;
            }

            var timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            var profileSummary =
                $"Citizen Digital Profile{Environment.NewLine}" +
                $"Full Name: {currentProfile.FullName}{Environment.NewLine}" +
                $"ID Number: {currentProfile.IDNumber}{Environment.NewLine}" +
                $"Calculated Age: {currentProfile.Age}{Environment.NewLine}" +
                $"Citizenship Status: {currentProfile.CitizenshipStatus}{Environment.NewLine}" +
                $"Validation Result: {currentValidationMessage}{Environment.NewLine}" +
                $"Processing Timestamp: {timestamp}";

            txtValidation.Text = profileSummary;

            if (currentValidationMessage.StartsWith("Valid", StringComparison.OrdinalIgnoreCase))
            {
                profiles.Add(currentProfile);
                var item = new ListViewItem(currentProfile.FullName);
                item.SubItems.Add(currentProfile.IDNumber);
                item.SubItems.Add(currentProfile.Age.ToString());
                item.SubItems.Add(currentProfile.CitizenshipStatus);
                item.SubItems.Add(currentValidationMessage);
                listViewProfiles.Items.Add(item);
            }

            lblStatus.Text = "Status: Profile generated";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtIdNumber.Clear();
            cmbCitizenship.SelectedIndex = -1;
            txtValidation.Clear();
            listViewProfiles.Items.Clear();
            profiles.Clear();
            currentProfile = null;
            currentValidationMessage = "No validation has been run.";
            lblStatus.Text = "Status: Ready for scan";
            txtName.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }

            ReleaseCapture();
            SendMessage(Handle, WmNclButtonDown, HtCaption, 0);
        }
    }
}
