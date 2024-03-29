using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace studentDiary
{
    public partial class RegistrationWindow : Form
    {
        public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            StudentProfile profile = new StudentProfile();
            profile.CreateControl();
        }
        private int CheckRadioButton()
        {
            int valueRb;
            if (RBtnAdmin.Checked == true)
            {
                valueRb = 1;
            }
            else
            {
                valueRb = 0;
            }

            return valueRb;
        }
        public Boolean CheckUser()
        {

            DB dB = new DB();
            DataTable dTable = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand mySqlCommand = new MySqlCommand("SELECT * FROM `user` WHERE `UserEmail` = @lU", dB.GetConnection());
            mySqlCommand.Parameters.Add("@lU", MySqlDbType.VarChar).Value = EmailText.Text;

            adapter.SelectCommand = mySqlCommand;
            adapter.Fill(dTable);

            if (dTable.Rows.Count > 0)
            {
                MessageBox.Show("Такой логи уже есть");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void RegistrationStart_Click_1(object sender, EventArgs e)
        {

            if (NameText.Text == String.Empty && SurnameText.Text == String.Empty && PatronymicText.Text == String.Empty && TelephoneText.Text == String.Empty && PasswordText.Text == String.Empty)
            {
                MessageBox.Show("Есть пустые поля");
                return;
            }
            if (CheckUser())
            {
                return;
            }
            DB dB = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `user` (`UserName`, `UserSurname`, `UserPatronymic`, `UserRole`, `UserEmail`, `UserTelephone`, `UserPassword`, `InTheGroupOrNot`) VALUES (@nU, @sU, @pU, @r, @eU, @tU, @passU, @InT)", dB.GetConnection());
            command.Parameters.Add("@nU", MySqlDbType.VarChar).Value = NameText.Text;
            command.Parameters.Add("@sU", MySqlDbType.VarChar).Value = SurnameText.Text;
            command.Parameters.Add("@pU", MySqlDbType.VarChar).Value = PatronymicText.Text;
            command.Parameters.Add("@r", MySqlDbType.Int32).Value = CheckRadioButton();
            command.Parameters.Add("@eU", MySqlDbType.VarChar).Value = EmailText.Text;
            command.Parameters.Add("@tU", MySqlDbType.VarChar).Value = TelephoneText.Text;
            command.Parameters.Add("@passU", MySqlDbType.VarChar).Value = PasswordText.Text;
            command.Parameters.Add("@InT", MySqlDbType.Int32).Value = 0;


            dB.OpenConnection();
            AuthorizationWindow authorizationWindow = new AuthorizationWindow();
            RegistrationWindow regWin = new RegistrationWindow();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Создан");
                authorizationWindow.Show();
                regWin.Close();
            }
            else
            {
                MessageBox.Show("Не создан");
            }
            dB.CloseConnection();
        }

        private void RBtnAdmin_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
