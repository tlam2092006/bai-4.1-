namespace bai_41
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chkShowPassword_CheckedChanged(object? sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void btnLogin_Click(object? sender, EventArgs e)
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                errorProvider.SetError(txtUsername, "Username is required.");
                isValid = false;
            }
            else
            {
                errorProvider.SetError(txtUsername, string.Empty);
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                errorProvider.SetError(txtPassword, "Password is required.");
                isValid = false;
            }
            else
            {
                errorProvider.SetError(txtPassword, string.Empty);
            }

            if (!isValid)
            {
                if (string.IsNullOrWhiteSpace(txtUsername.Text))
                {
                    txtUsername.Focus();
                }
                else
                {
                    txtPassword.Focus();
                }

                return;
            }

            MessageBox.Show("The required fields are valid.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExit_Click(object? sender, EventArgs e)
        {
            Close();
        }

        private void txtUsername_TextChanged(object? sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                errorProvider.SetError(txtUsername, string.Empty);
            }
        }

        private void txtPassword_TextChanged(object? sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                errorProvider.SetError(txtPassword, string.Empty);
            }
        }
    }
}
