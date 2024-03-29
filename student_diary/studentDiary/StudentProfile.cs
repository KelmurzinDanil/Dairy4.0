using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace studentDiary
{
    public partial class StudentProfile : Form
    {
        public StudentProfile()
        {
            InitializeComponent();
        }
        public StudentProfile(string log, string pas)
        {
            InitializeComponent();
            InputInfoStudent(log, pas);
        }
        string OldEmail { get; set; }

        private void StudentProfileButton_Click(object sender, EventArgs e)
        {
            StudentProfile studentProfile = new StudentProfile();
            studentProfile.Show();
        }

        private void InputInfoStudent(string log, string pas)
        {
            DB dB = new DB();

            MySqlCommand mySqlCommand = new MySqlCommand("SELECT * FROM `user` WHERE `UserEmail` = @lU AND `UserPassword` = @pU", dB.GetConnection());
            mySqlCommand.Parameters.Add("@lU", MySqlDbType.VarChar).Value = log;
            mySqlCommand.Parameters.Add("@pU", MySqlDbType.VarChar).Value = pas;
            dB.OpenConnection();
            using (MySqlDataReader oReader = mySqlCommand.ExecuteReader())
            {
                while (oReader.Read())
                {
                    NameStudentProfileText.Text = oReader.GetString("UserName");
                    SurnameStudentProfileText.Text = oReader.GetString("UserSurname");
                    PatronymicStudentProfileText.Text = oReader.GetString("UserPatronymic");
                    EmailStudentProfileText.Text = oReader.GetString("UserEmail");
                    PhoneNumberStudentProfileText.Text = oReader.GetString("UserTelephone");
                    RoleStudentProfileText.Text = "Студент";
                }

                dB.CloseConnection();
            }
        }

        private void MainWindowButton_Click(object sender, EventArgs e)
        {
            MainWindowStudent mainWindowStudent = new MainWindowStudent();
            mainWindowStudent.Show();
        }

        private void EditButtonStudentProfile_Click(object sender, EventArgs e)
        {
            NameStudentProfileText.ReadOnly = false;
            SurnameStudentProfileText.ReadOnly = false;
            PatronymicStudentProfileText.ReadOnly = false;
            PhoneNumberStudentProfileText.ReadOnly = false;
            SaveBtnInStudentProfile.Visible = true;
        }
        private void SaveBtnInStudentProfile_Click(object sender, EventArgs e)
        {
            if (NameStudentProfileText.Text == String.Empty && SurnameStudentProfileText.Text == String.Empty && PatronymicStudentProfileText.Text == String.Empty && EmailStudentProfileText.Text == String.Empty && PhoneNumberStudentProfileText.Text == String.Empty)
            {
                MessageBox.Show("Есть пустые поля");
                return;
            }
            DB dB = new DB();
            MySqlCommand command = new MySqlCommand("UPDATE `user` SET UserName = @nU, UserSurname = @sU, UserPatronymic = @pU, UserTelephone = @tU WHERE UserEmail = @eU", dB.GetConnection());
            command.Parameters.Add("@eU", MySqlDbType.VarChar).Value = EmailStudentProfileText.Text;
            command.Parameters.Add("@nU", MySqlDbType.VarChar).Value = NameStudentProfileText.Text;
            command.Parameters.Add("@sU", MySqlDbType.VarChar).Value = SurnameStudentProfileText.Text;
            command.Parameters.Add("@pU", MySqlDbType.VarChar).Value = PatronymicStudentProfileText.Text;
            command.Parameters.Add("@tU", MySqlDbType.VarChar).Value = PhoneNumberStudentProfileText.Text;

            dB.OpenConnection();
            command.ExecuteNonQuery();
            dB.CloseConnection();

            NameStudentProfileText.ReadOnly = true;
            SurnameStudentProfileText.ReadOnly = true;
            PatronymicStudentProfileText.ReadOnly = true;
            EmailStudentProfileText.ReadOnly = true;
            PhoneNumberStudentProfileText.ReadOnly = true;
            SaveBtnInStudentProfile.Visible = false;
        }

        private void ScheduleStudentProfile_Click(object sender, EventArgs e)
        {
            StudentScheduleWindow ss = new StudentScheduleWindow();
            ss.Show();
        }
    }

}
