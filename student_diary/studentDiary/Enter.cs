using System;
using System.Windows.Forms;


namespace studentDiary
{
    public partial class OpenWindow : Form
    {
        public OpenWindow()
        {
            InitializeComponent();
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            RegistrationWindow registration = new RegistrationWindow();
            registration.Show();
        }

        private void AuthorizationButton_Click(object sender, EventArgs e)
        {
            AuthorizationWindow authorization = new AuthorizationWindow();
            authorization.Show();
        }
    }
}
