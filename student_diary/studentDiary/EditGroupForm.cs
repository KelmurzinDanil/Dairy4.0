using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace studentDiary
{
    public partial class EditGroupForm : Form
    {
        public EditGroupForm()
        {
            InitializeComponent();
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
                GroupList.DataSource = list.Distinct().ToArray();


            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddGroupForm addGroupForm = new AddGroupForm();
            addGroupForm.ShowDialog();
        }

        private void GroupList_SelectedIndexChanged(object sender, EventArgs e)
        {
            StudentList.Items.Clear();
            DB dB = new DB();
            GroupList.Click += GroupList_SelectedIndexChanged;
            MySqlCommand command = new MySqlCommand("SELECT `UserSurname` FROM  `user` INNER JOIN `group` ON  user.idUser = group.Group_idUser WHERE `GroupNumber` = @G_N ", dB.GetConnection());
            command.Parameters.Add("@G_N", MySqlDbType.Int32).Value = GroupList.SelectedItem;
            dB.OpenConnection();
            using (MySqlDataReader myReader = command.ExecuteReader())
            {
                while (myReader.Read())
                {
                    StudentList.Items.Add(myReader.IsDBNull(myReader.GetOrdinal("UserSurname")) ? string.Empty : myReader["UserSurname"].ToString());
                }
                dB.CloseConnection();
            }
        }
    }
}
