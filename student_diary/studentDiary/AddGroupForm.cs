using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System;
using System.Data.Common;
using System.Windows.Input;
using System.Reflection;

namespace studentDiary
{
    public partial class AddGroupForm : Form
    {
        public AddGroupForm()
        {
            InitializeComponent();
            StudentsWhoAreNotInTheGroup();
        }

        public void StudentsWhoAreNotInTheGroup()
        {
            DB dB = new DB();
            MySqlCommand command = new MySqlCommand("SELECT `UserSurname`, `idUser` FROM `user` WHERE `InTheGroupOrNot` = @n AND `UserRole` = @r", dB.GetConnection());
            command.Parameters.Add("@n", MySqlDbType.Int32).Value = 0;
            command.Parameters.Add("@r", MySqlDbType.Int32).Value = 0;
            dB.OpenConnection();
            using (MySqlDataReader myReader = command.ExecuteReader())
            {
                while (myReader.Read())
                {
                    StudentsListText.Rows.Add(myReader.GetInt32("idUser"), myReader.GetString("UserSurname"));
                }
                dB.CloseConnection();
            }
        }
        private void AddGroupButton_Click(object sender, System.EventArgs e)
        {
            int v;
            if (int.TryParse(GroupNumberText.Text, out v))
            {
                DB dB = new DB();
                dB.OpenConnection();
                MySqlCommand command = new MySqlCommand("INSERT INTO `group` (`Group_idUser`,`GroupNumber`) VALUES (@Gid, @Gn)", dB.GetConnection());
                MySqlCommand command2 = new MySqlCommand("UPDATE `user` SET InTheGroupOrNot = @InTG WHERE `idUser` = @Gid2", dB.GetConnection());

                command.Parameters.Add("@Gn", MySqlDbType.VarChar);
                command.Parameters.Add("@Gid", MySqlDbType.VarChar);
                command2.Parameters.Add("@InTG", MySqlDbType.Int32);
                command2.Parameters.Add("@Gid2", MySqlDbType.VarChar);
                for (int i = 0;i < AddedStudentsText.RowCount - 1; i++)
                {
                    command.Parameters["@Gn"].Value = GroupNumberText.Text;
                    command.Parameters["@Gid"].Value = AddedStudentsText.Rows[i].Cells[0].Value.ToString();                
                    command.ExecuteNonQuery();

                    command2.Parameters["@Gid2"].Value = AddedStudentsText.Rows[i].Cells[0].Value.ToString();
                    command2.Parameters["@InTG"].Value = 1;
                    command2.ExecuteNonQuery();

                }
                if (command.ExecuteNonQuery() == 1 && command2.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Создан");
                }
                else
                {
                    MessageBox.Show("Не создан");
                }
                dB.CloseConnection();

            }
            else
            {
                MessageBox.Show("Некорректный ввод группы");
                return;
            }

        }

        private void TransferBtn_Click(object sender, System.EventArgs e)
        {
            if(StudentsListText.SelectedRows != null)
            {
                foreach (DataGridViewColumn c in StudentsListText.Columns)
                {
                    AddedStudentsText.Columns.Add(c.Clone() as DataGridViewColumn);
                }
                foreach (DataGridViewRow r in StudentsListText.SelectedRows)
                {
                    int index = AddedStudentsText.Rows.Add(r.Clone() as DataGridViewRow);
                    foreach (DataGridViewCell o in r.Cells)
                    {
                        AddedStudentsText.Rows[index].Cells[o.ColumnIndex].Value = o.Value;
                    }
                    StudentsListText.Rows.RemoveAt(r.Index);

                }
            }
            
        }

        private void TransferBtn2_Click(object sender, EventArgs e)
        {
            if(AddedStudentsText.SelectedRows != null)
            {
                foreach (DataGridViewColumn c in AddedStudentsText.Columns)
                {
                    StudentsListText.Columns.Add(c.Clone() as DataGridViewColumn);
                }
                foreach (DataGridViewRow r in AddedStudentsText.SelectedRows)
                {
                    int index = StudentsListText.Rows.Add(r.Clone() as DataGridViewRow);
                    foreach (DataGridViewCell o in r.Cells)
                    {
                        StudentsListText.Rows[index].Cells[o.ColumnIndex].Value = o.Value;
                    }
                    AddedStudentsText.Rows.RemoveAt(r.Index);
                }
            }
            
        }
    }
}

