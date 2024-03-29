using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace studentDiary
{
    public partial class StudentScheduleWindow : Form
    {
        public StudentScheduleWindow()
        {
            InitializeComponent();
            FillComboBox();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MainWindowStudent mainWindowStudent = new MainWindowStudent();
            mainWindowStudent.Show();
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
                GroupComboSt.DataSource = list.Distinct().ToArray();
            }
        }
        public void FillShedule()
        {
            DB dB = new DB();
            MySqlCommand mySqlCommand = new MySqlCommand("SELECT `Shedule_LessonName`, `ShuduleDay_NumberInWeek` FROM `sheduleday` WHERE `SheduleDay_NumberGroup` = @Sd_Ng", dB.GetConnection());
            mySqlCommand.Parameters.Add("@Sd_Ng", MySqlDbType.Int32).Value = GroupComboSt.Text;
            dB.OpenConnection();
            using (MySqlDataReader oReader = mySqlCommand.ExecuteReader())
            {
                while (oReader.Read())
                {
                    switch (oReader.GetInt32("ShuduleDay_NumberInWeek"))
                    {
                        case 1:
                            if(!oReader["Shedule_LessonName"].Equals(null) && !oReader["Shedule_LessonName"].Equals(String.Empty) && StudShed1.RowCount <= 6)
                                StudShed1.Rows.Add(oReader["Shedule_LessonName"]);
                            break;
                        case 2:
                            if (!oReader["Shedule_LessonName"].Equals(null) && !oReader["Shedule_LessonName"].Equals(String.Empty) && StudShed2.RowCount <= 6)
                                StudShed2.Rows.Add(oReader["Shedule_LessonName"]);
                            break;
                        case 3:
                            if (!oReader["Shedule_LessonName"].Equals(null) && !oReader["Shedule_LessonName"].Equals(String.Empty) && StudShed3.RowCount <= 6)
                                StudShed3.Rows.Add(oReader["Shedule_LessonName"]);
                            break;
                        case 4:
                            if (!oReader["Shedule_LessonName"].Equals(null) && !oReader["Shedule_LessonName"].Equals(String.Empty) && StudShed4.RowCount <= 6)
                                StudShed4.Rows.Add(oReader["Shedule_LessonName"]);
                            break;
                        case 5:
                            if (!oReader["Shedule_LessonName"].Equals(null) && !oReader["Shedule_LessonName"].Equals(String.Empty) && StudShed5.RowCount <= 6)
                                StudShed5.Rows.Add(oReader["Shedule_LessonName"]);
                            break;
                        case 6:
                            if (!oReader["Shedule_LessonName"].Equals(null) && !oReader["Shedule_LessonName"].Equals(String.Empty) && StudShed6.RowCount <= 6)
                                StudShed6.Rows.Add(oReader["Shedule_LessonName"]);
                            break;
                    }
                }
            }
            dB.CloseConnection();
        }

        private void ViewSheduleBtn_Click(object sender, EventArgs e)
        {
            FillShedule();
        }

        private void StudShed1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string lesson = StudShed1.Rows[e.RowIndex].Cells[0].Value.ToString();
            LessonCardWindow lessonCardWindow = new LessonCardWindow(lesson, 1);              
            lessonCardWindow.Show();

        }

        private void StudShed2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string lesson = StudShed1.Rows[e.RowIndex].Cells[0].Value.ToString();
            LessonCardWindow lessonCardWindow = new LessonCardWindow(lesson, 2);
            lessonCardWindow.Show();
        }

        private void StudShed3_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string lesson = StudShed1.Rows[e.RowIndex].Cells[0].Value.ToString();
            LessonCardWindow lessonCardWindow = new LessonCardWindow(lesson, 3);
            lessonCardWindow.Show();
        }

        private void StudShed4_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string lesson = StudShed1.Rows[e.RowIndex].Cells[0].Value.ToString();
            LessonCardWindow lessonCardWindow = new LessonCardWindow(lesson, 4);
            lessonCardWindow.Show();
        }

        private void StudShed5_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string lesson = StudShed1.Rows[e.RowIndex].Cells[0].Value.ToString();
            LessonCardWindow lessonCardWindow = new LessonCardWindow(lesson, 5);
            lessonCardWindow.Show();
        }

        private void StudShed6_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string lesson = StudShed1.Rows[e.RowIndex].Cells[0].Value.ToString();
            LessonCardWindow lessonCardWindow = new LessonCardWindow(lesson, 6);
            lessonCardWindow.Show();
        }
    }
}
