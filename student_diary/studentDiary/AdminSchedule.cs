using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace studentDiary
{
    public partial class AdminSchedule : Form
    {
        public AdminSchedule()
        {
            InitializeComponent();
            GetInfoComboBox();
            FillComboBox();
        }
        public void FillComboBox()
        {
            DB dB = new DB();
            MySqlCommand command = new MySqlCommand("SELECT `GroupNumber` FROM `group` ", dB.GetConnection());
            dB.OpenConnection();
            using (MySqlDataReader oReader = command.ExecuteReader())
            {
                List<int> list = new List<int>();
                while (oReader.Read())
                {
                    list.Add(oReader.GetInt32(0));
                }
                list.Distinct().ToArray(); // Удаляем повторяющиеся элементы
                GroupCombo.DataSource = list.Distinct().ToArray();
            }

        }
        private void GetInfoComboBox()
        {
            DB dB = new DB();
            MySqlCommand command = new MySqlCommand("SELECT `LessonName` FROM `lesson` ", dB.GetConnection());
            dB.OpenConnection();
            using (MySqlDataReader oReader = command.ExecuteReader())
            {
                while (oReader.Read())
                {
                    comboBox1.Items.Add(oReader[0]);
                    comboBox2.Items.Add(oReader[0]);
                    comboBox3.Items.Add(oReader[0]);
                    comboBox4.Items.Add(oReader[0]);
                    comboBox5.Items.Add(oReader[0]);
                    comboBox6.Items.Add(oReader[0]);
                    comboBox7.Items.Add(oReader[0]);
                    comboBox8.Items.Add(oReader[0]);
                    comboBox9.Items.Add(oReader[0]);
                    comboBox10.Items.Add(oReader[0]);
                    comboBox11.Items.Add(oReader[0]);
                    comboBox12.Items.Add(oReader[0]);
                    comboBox13.Items.Add(oReader[0]);
                    comboBox14.Items.Add(oReader[0]);
                    comboBox15.Items.Add(oReader[0]);
                    comboBox16.Items.Add(oReader[0]);
                    comboBox17.Items.Add(oReader[0]);
                    comboBox18.Items.Add(oReader[0]);
                    comboBox19.Items.Add(oReader[0]);
                    comboBox20.Items.Add(oReader[0]);
                    comboBox21.Items.Add(oReader[0]);
                    comboBox22.Items.Add(oReader[0]);
                    comboBox23.Items.Add(oReader[0]);
                    comboBox24.Items.Add(oReader[0]);
                    comboBox25.Items.Add(oReader[0]);
                    comboBox26.Items.Add(oReader[0]);
                    comboBox27.Items.Add(oReader[0]);
                    comboBox28.Items.Add(oReader[0]);
                    comboBox29.Items.Add(oReader[0]);
                    comboBox30.Items.Add(oReader[0]);
                    comboBox31.Items.Add(oReader[0]);
                    comboBox32.Items.Add(oReader[0]);
                    comboBox33.Items.Add(oReader[0]);
                    comboBox34.Items.Add(oReader[0]);
                    comboBox35.Items.Add(oReader[0]);
                    comboBox36.Items.Add(oReader[0]);
                }
            }
            dB.CloseConnection();
        }

        private void SaveButton_Click(object sender, System.EventArgs e)
        {
            DB dB = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `sheduleday` (`Shedule_LessonName`, `SheduleDay_NumberGroup`, `ShuduleDay_NumberInWeek`) VALUES (@nU, @Ad_nG, @Sd_NiW)", dB.GetConnection());
            // Я грешный человек, простите за такой хардкодинг
            dB.OpenConnection();
            command.Parameters.Add("@Ad_nG", MySqlDbType.VarChar).Value = GroupCombo.Text;
            command.Parameters.Add("@nU", MySqlDbType.VarChar).Value = comboBox1.Text;
            command.Parameters.Add("@Sd_NiW", MySqlDbType.VarChar).Value = 1;
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            command.Parameters.Add("@Ad_nG", MySqlDbType.VarChar).Value = GroupCombo.Text;
            command.Parameters.Add("@nU", MySqlDbType.VarChar).Value = comboBox2.Text;
            command.Parameters.Add("@Sd_NiW", MySqlDbType.VarChar).Value = 1;
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            command.Parameters.Add("@Ad_nG", MySqlDbType.VarChar).Value = GroupCombo.Text;
            command.Parameters.Add("@nU", MySqlDbType.VarChar).Value = comboBox3.Text;
            command.Parameters.Add("@Sd_NiW", MySqlDbType.VarChar).Value = 1;
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            command.Parameters.Add("@Ad_nG", MySqlDbType.VarChar).Value = GroupCombo.Text;
            command.Parameters.Add("@nU", MySqlDbType.VarChar).Value = comboBox4.Text;
            command.Parameters.Add("@Sd_NiW", MySqlDbType.VarChar).Value = 1;
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            command.Parameters.Add("@Ad_nG", MySqlDbType.VarChar).Value = GroupCombo.Text;
            command.Parameters.Add("@nU", MySqlDbType.VarChar).Value = comboBox5.Text;
            command.Parameters.Add("@Sd_NiW", MySqlDbType.VarChar).Value = 1;
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            command.Parameters.Add("@Ad_nG", MySqlDbType.VarChar).Value = GroupCombo.Text;
            command.Parameters.Add("@nU", MySqlDbType.VarChar).Value = comboBox6.Text;
            command.Parameters.Add("@Sd_NiW", MySqlDbType.VarChar).Value = 1;
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            command.Parameters.Add("@Ad_nG", MySqlDbType.VarChar).Value = GroupCombo.Text;
            command.Parameters.Add("@nU", MySqlDbType.VarChar).Value = comboBox7.Text;
            command.Parameters.Add("@Sd_NiW", MySqlDbType.VarChar).Value = 2;
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            command.Parameters.Add("@Ad_nG", MySqlDbType.VarChar).Value = GroupCombo.Text;
            command.Parameters.Add("@nU", MySqlDbType.VarChar).Value = comboBox8.Text;
            command.Parameters.Add("@Sd_NiW", MySqlDbType.VarChar).Value = 2;
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            command.Parameters.Add("@Ad_nG", MySqlDbType.VarChar).Value = GroupCombo.Text;
            command.Parameters.Add("@nU", MySqlDbType.VarChar).Value = comboBox9.Text;
            command.Parameters.Add("@Sd_NiW", MySqlDbType.VarChar).Value = 2;
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            command.Parameters.Add("@Ad_nG", MySqlDbType.VarChar).Value = GroupCombo.Text;
            command.Parameters.Add("@nU", MySqlDbType.VarChar).Value = comboBox10.Text;
            command.Parameters.Add("@Sd_NiW", MySqlDbType.VarChar).Value = 2;
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            command.Parameters.Add("@Ad_nG", MySqlDbType.VarChar).Value = GroupCombo.Text;
            command.Parameters.Add("@nU", MySqlDbType.VarChar).Value = comboBox12.Text;
            command.Parameters.Add("@Sd_NiW", MySqlDbType.VarChar).Value = 2;
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            command.Parameters.Add("@Ad_nG", MySqlDbType.VarChar).Value = GroupCombo.Text;
            command.Parameters.Add("@nU", MySqlDbType.VarChar).Value = comboBox12.Text;
            command.Parameters.Add("@Sd_NiW", MySqlDbType.VarChar).Value = 2;
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            command.Parameters.Add("@Ad_nG", MySqlDbType.VarChar).Value = GroupCombo.Text;
            command.Parameters.Add("@nU", MySqlDbType.VarChar).Value = comboBox13.Text;
            command.Parameters.Add("@Sd_NiW", MySqlDbType.VarChar).Value = 3;
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            command.Parameters.Add("@Ad_nG", MySqlDbType.VarChar).Value = GroupCombo.Text;
            command.Parameters.Add("@nU", MySqlDbType.VarChar).Value = comboBox14.Text;
            command.Parameters.Add("@Sd_NiW", MySqlDbType.VarChar).Value = 3;
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            command.Parameters.Add("@Ad_nG", MySqlDbType.VarChar).Value = GroupCombo.Text;
            command.Parameters.Add("@nU", MySqlDbType.VarChar).Value = comboBox15.Text;
            command.Parameters.Add("@Sd_NiW", MySqlDbType.VarChar).Value = 3;
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            command.Parameters.Add("@Ad_nG", MySqlDbType.VarChar).Value = GroupCombo.Text;
            command.Parameters.Add("@nU", MySqlDbType.VarChar).Value = comboBox16.Text;
            command.Parameters.Add("@Sd_NiW", MySqlDbType.VarChar).Value = 3;
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            command.Parameters.Add("@Ad_nG", MySqlDbType.VarChar).Value = GroupCombo.Text;
            command.Parameters.Add("@nU", MySqlDbType.VarChar).Value = comboBox17.Text;
            command.Parameters.Add("@Sd_NiW", MySqlDbType.VarChar).Value = 3;
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            command.Parameters.Add("@Ad_nG", MySqlDbType.VarChar).Value = GroupCombo.Text;
            command.Parameters.Add("@nU", MySqlDbType.VarChar).Value = comboBox18.Text;
            command.Parameters.Add("@Sd_NiW", MySqlDbType.VarChar).Value = 3;
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            command.Parameters.Add("@Ad_nG", MySqlDbType.VarChar).Value = GroupCombo.Text;
            command.Parameters.Add("@nU", MySqlDbType.VarChar).Value = comboBox19.Text;
            command.Parameters.Add("@Sd_NiW", MySqlDbType.VarChar).Value = 4;
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            command.Parameters.Add("@Ad_nG", MySqlDbType.VarChar).Value = GroupCombo.Text;
            command.Parameters.Add("@nU", MySqlDbType.VarChar).Value = comboBox20.Text;
            command.Parameters.Add("@Sd_NiW", MySqlDbType.VarChar).Value = 4;
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            command.Parameters.Add("@Ad_nG", MySqlDbType.VarChar).Value = GroupCombo.Text;
            command.Parameters.Add("@nU", MySqlDbType.VarChar).Value = comboBox21.Text;
            command.Parameters.Add("@Sd_NiW", MySqlDbType.VarChar).Value = 4;
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            command.Parameters.Add("@Ad_nG", MySqlDbType.VarChar).Value = GroupCombo.Text;
            command.Parameters.Add("@nU", MySqlDbType.VarChar).Value = comboBox22.Text;
            command.Parameters.Add("@Sd_NiW", MySqlDbType.VarChar).Value = 4;
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            command.Parameters.Add("@Ad_nG", MySqlDbType.VarChar).Value = GroupCombo.Text;
            command.Parameters.Add("@nU", MySqlDbType.VarChar).Value = comboBox23.Text;
            command.Parameters.Add("@Sd_NiW", MySqlDbType.VarChar).Value = 4;
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            command.Parameters.Add("@Ad_nG", MySqlDbType.VarChar).Value = GroupCombo.Text;
            command.Parameters.Add("@nU", MySqlDbType.VarChar).Value = comboBox24.Text;
            command.Parameters.Add("@Sd_NiW", MySqlDbType.VarChar).Value = 4;
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            command.Parameters.Add("@Ad_nG", MySqlDbType.VarChar).Value = GroupCombo.Text;
            command.Parameters.Add("@nU", MySqlDbType.VarChar).Value = comboBox25.Text;
            command.Parameters.Add("@Sd_NiW", MySqlDbType.VarChar).Value = 5;
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            command.Parameters.Add("@Ad_nG", MySqlDbType.VarChar).Value = GroupCombo.Text;
            command.Parameters.Add("@nU", MySqlDbType.VarChar).Value = comboBox26.Text;
            command.Parameters.Add("@Sd_NiW", MySqlDbType.VarChar).Value = 5;
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            command.Parameters.Add("@Ad_nG", MySqlDbType.VarChar).Value = GroupCombo.Text;
            command.Parameters.Add("@nU", MySqlDbType.VarChar).Value = comboBox27.Text;
            command.Parameters.Add("@Sd_NiW", MySqlDbType.VarChar).Value = 5;
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            command.Parameters.Add("@Ad_nG", MySqlDbType.VarChar).Value = GroupCombo.Text;
            command.Parameters.Add("@nU", MySqlDbType.VarChar).Value = comboBox28.Text;
            command.Parameters.Add("@Sd_NiW", MySqlDbType.VarChar).Value = 5;
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            command.Parameters.Add("@Ad_nG", MySqlDbType.VarChar).Value = GroupCombo.Text;
            command.Parameters.Add("@nU", MySqlDbType.VarChar).Value = comboBox29.Text;
            command.Parameters.Add("@Sd_NiW", MySqlDbType.VarChar).Value = 5;
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            command.Parameters.Add("@Ad_nG", MySqlDbType.VarChar).Value = GroupCombo.Text;
            command.Parameters.Add("@nU", MySqlDbType.VarChar).Value = comboBox30.Text;
            command.Parameters.Add("@Sd_NiW", MySqlDbType.VarChar).Value = 5;
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            command.Parameters.Add("@Ad_nG", MySqlDbType.VarChar).Value = GroupCombo.Text;
            command.Parameters.Add("@nU", MySqlDbType.VarChar).Value = comboBox31.Text;
            command.Parameters.Add("@Sd_NiW", MySqlDbType.VarChar).Value = 6;
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            command.Parameters.Add("@Ad_nG", MySqlDbType.VarChar).Value = GroupCombo.Text;
            command.Parameters.Add("@nU", MySqlDbType.VarChar).Value = comboBox32.Text;
            command.Parameters.Add("@Sd_NiW", MySqlDbType.VarChar).Value = 6;
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            command.Parameters.Add("@Ad_nG", MySqlDbType.VarChar).Value = GroupCombo.Text;
            command.Parameters.Add("@nU", MySqlDbType.VarChar).Value = comboBox33.Text;
            command.Parameters.Add("@Sd_NiW", MySqlDbType.VarChar).Value = 6;
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            command.Parameters.Add("@Ad_nG", MySqlDbType.VarChar).Value = GroupCombo.Text;
            command.Parameters.Add("@nU", MySqlDbType.VarChar).Value = comboBox34.Text;
            command.Parameters.Add("@Sd_NiW", MySqlDbType.VarChar).Value = 6;
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            command.Parameters.Add("@Ad_nG", MySqlDbType.VarChar).Value = GroupCombo.Text;
            command.Parameters.Add("@nU", MySqlDbType.VarChar).Value = comboBox35.Text;
            command.Parameters.Add("@Sd_NiW", MySqlDbType.VarChar).Value = 6;
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            command.Parameters.Add("@Ad_nG", MySqlDbType.VarChar).Value = GroupCombo.Text;
            command.Parameters.Add("@nU", MySqlDbType.VarChar).Value = comboBox36.Text;
            command.Parameters.Add("@Sd_NiW", MySqlDbType.VarChar).Value = 6;


            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Создан");
            }
            else
            {
                MessageBox.Show("Не создан");
            }
            dB.CloseConnection();
        }
    }
}
