using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace studentDiary
{
    public partial class AdministratorProfile : Form
    {
        public AdministratorProfile()
        {
            InitializeComponent();
        }
        public AdministratorProfile(string log, string pas)
        {
            InitializeComponent();
            InputInfoStudent(log, pas);
        }
        private void InputInfoStudent(string log, string pas)
        {
            DB dB = new DB();
            DataTable dTable = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand mySqlCommand = new MySqlCommand("SELECT * FROM `user` WHERE `UserEmail` = @lU AND `UserPassword` = @pU", dB.GetConnection());
            mySqlCommand.Parameters.Add("@lU", MySqlDbType.VarChar).Value = log;
            mySqlCommand.Parameters.Add("@pU", MySqlDbType.VarChar).Value = pas;
            dB.OpenConnection();
            using (MySqlDataReader oReader = mySqlCommand.ExecuteReader())
            {
                while (oReader.Read())
                {
                    NameAdminProfileText.Text = oReader.GetString("UserName");
                    SurnameAdminProfileText.Text = oReader.GetString("UserSurname");
                    PatronymicAdminProfileText.Text = oReader.GetString("UserPatronymic");
                    EmailAdminProfileText.Text = oReader.GetString("UserEmail");
                    PhoneNumberAdminProfileText.Text = oReader.GetString("UserTelephone");
                    RoleAdminProfileText.Text = "Адмнистратор";
                }

                dB.CloseConnection();
            }
        }

        private void SaveButtonAdminProfile_Click(object sender, EventArgs e)
        {
            if (NameAdminProfileText.Text == String.Empty && SurnameAdminProfileText.Text == String.Empty && PatronymicAdminProfileText.Text == String.Empty && EmailAdminProfileText.Text == String.Empty && PhoneNumberAdminProfileText.Text == String.Empty)
            {
                MessageBox.Show("Есть пустые поля");
                return;
            }
            DB dB = new DB();
            MySqlCommand command = new MySqlCommand("UPDATE `user` SET UserName = @nU, UserSurname = @sU, UserPatronymic = @pU, UserTelephone = @tU WHERE UserEmail = @eU", dB.GetConnection());
            command.Parameters.Add("@eU", MySqlDbType.VarChar).Value = EmailAdminProfileText.Text;
            command.Parameters.Add("@nU", MySqlDbType.VarChar).Value = NameAdminProfileText.Text;
            command.Parameters.Add("@sU", MySqlDbType.VarChar).Value = SurnameAdminProfileText.Text;
            command.Parameters.Add("@pU", MySqlDbType.VarChar).Value = PatronymicAdminProfileText.Text;
            command.Parameters.Add("@tU", MySqlDbType.VarChar).Value = PhoneNumberAdminProfileText.Text;

            dB.OpenConnection();
            command.ExecuteNonQuery();
            dB.CloseConnection();

            NameAdminProfileText.ReadOnly = true;
            SurnameAdminProfileText.ReadOnly = true;
            PatronymicAdminProfileText.ReadOnly = true;
            EmailAdminProfileText.ReadOnly = true;
            PhoneNumberAdminProfileText.ReadOnly = true;
            SaveButtonAdminProfile.Visible = false;
        }

        private void EditButtonAdminProfile_Click(object sender, EventArgs e)
        {
            NameAdminProfileText.ReadOnly = false;
            SurnameAdminProfileText.ReadOnly = false;
            PatronymicAdminProfileText.ReadOnly = false;
            PhoneNumberAdminProfileText.ReadOnly = false;
            SaveButtonAdminProfile.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditGroupForm editGroupForm = new EditGroupForm();
            editGroupForm.Show();
        }

        private void ScheduleStudentProfile_Click(object sender, EventArgs e)
        {
            AdminSchedule adminSchedule = new AdminSchedule();
            adminSchedule.Show();
        }
    }
}
