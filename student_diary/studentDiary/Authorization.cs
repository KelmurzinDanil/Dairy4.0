using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace studentDiary
{
    public partial class AuthorizationWindow : Form
    {
        public AuthorizationWindow()
        {
            InitializeComponent();
        }
        private void AuthorizationStart_Click_1(object sender, EventArgs e)
        {
            String loginUser = EmailText.Text;
            String passwordUser = PasswordText.Text;
            DB dB = new DB();
            DataTable dTable = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand mySqlCommand = new MySqlCommand("SELECT * FROM `user` WHERE `UserEmail` = @lU AND `UserPassword` = @pU", dB.GetConnection());
            mySqlCommand.Parameters.Add("@lU", MySqlDbType.VarChar).Value = loginUser;
            mySqlCommand.Parameters.Add("@pU", MySqlDbType.VarChar).Value = passwordUser;

            adapter.SelectCommand = mySqlCommand;
            adapter.Fill(dTable);

            dB.OpenConnection();
            using (MySqlDataReader oReader = mySqlCommand.ExecuteReader())
            {
                if (dTable.Rows.Count > 0)
                {
                    MessageBox.Show("Yes");
                    while (oReader.Read())
                    {
                        StudentProfile studentProfile = new StudentProfile(loginUser, passwordUser);
                        AdministratorProfile administratorProfile = new AdministratorProfile(loginUser, passwordUser);
                        if (oReader.GetUInt32("UserRole") == 0)
                        {
                            studentProfile.Show();
                        }
                        else
                        {
                            administratorProfile.Show();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No");
                }
            }
            dB.CloseConnection();

        }
    }

}
