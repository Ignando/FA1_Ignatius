using System.Drawing;
using System.Windows.Forms;

namespace DigitalIdentityProcessor
{
    public partial class Form1 : Form
    {
        private readonly List<CitizenProfile> profiles = new();

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

            lblTitle.ForeColor = neonBlue;
            lblSubtitle.ForeColor = Color.FromArgb(185, 194, 255);
            lblStatus.ForeColor = neonPink;

            foreach (Label label in new[] { lblName, lblIdNumber, lblCitizenship, lblRecords })
            {
                label.ForeColor = Color.FromArgb(210, 220, 255);
            }

            foreach (TextBox textBox in new[] { txtName, txtIdNumber, txtCitizenship, txtValidation })
            {
                textBox.BackColor = inputColor;
                textBox.ForeColor = Color.White;
                textBox.BorderStyle = BorderStyle.FixedSingle;
            }

            listViewProfiles.BackColor = inputColor;
            listViewProfiles.ForeColor = Color.White;
            listViewProfiles.BorderStyle = BorderStyle.FixedSingle;

            ConfigureButton(btnProcess, neonBlue, Color.Black);
            ConfigureButton(btnClear, neonPink, Color.White);
        }

        private static void ConfigureButton(Button button, Color backColor, Color foreColor)
        {
            button.BackColor = backColor;
            button.ForeColor = foreColor;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            var fullName = txtName.Text.Trim();
            var idNumber = txtIdNumber.Text.Trim();
            var citizenship = txtCitizenship.Text.Trim();

            if (string.IsNullOrWhiteSpace(fullName) ||
                string.IsNullOrWhiteSpace(idNumber) ||
                string.IsNullOrWhiteSpace(citizenship))
            {
                txtValidation.Text = "All fields are required before processing an identity profile.";
                lblStatus.Text = "Status: Missing input";
                return;
            }

            var profile = new CitizenProfile(fullName, idNumber, citizenship);
            var validationMessage = profile.ValidateID();

            txtValidation.Text =
                $"Name: {profile.FullName}{Environment.NewLine}" +
                $"ID Number: {profile.IDNumber}{Environment.NewLine}" +
                $"Age: {profile.Age}{Environment.NewLine}" +
                $"Citizenship: {profile.CitizenshipStatus}{Environment.NewLine}" +
                $"Validation: {validationMessage}";

            lblStatus.Text = validationMessage.StartsWith("Valid", StringComparison.OrdinalIgnoreCase)
                ? "Status: Identity accepted"
                : "Status: Identity flagged";

            if (validationMessage.StartsWith("Valid", StringComparison.OrdinalIgnoreCase))
            {
                profiles.Add(profile);
                var item = new ListViewItem(profile.FullName);
                item.SubItems.Add(profile.IDNumber);
                item.SubItems.Add(profile.Age.ToString());
                item.SubItems.Add(profile.CitizenshipStatus);
                item.SubItems.Add(validationMessage);
                listViewProfiles.Items.Add(item);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtIdNumber.Clear();
            txtCitizenship.Clear();
            txtValidation.Clear();
            listViewProfiles.Items.Clear();
            profiles.Clear();
            lblStatus.Text = "Status: Ready for scan";
            txtName.Focus();
        }
    }
}
