using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace studentDiary
{
    public partial class LessonCardWindow : Form
    {
        public LessonCardWindow(string lesson, int numberWeek)
        {
            InitializeComponent();
            FillTextCard(lesson, numberWeek);
        }
        public void FillTextCard(string lesson, int numberWeek)
        {

            DB dB = new DB();
            dB.OpenConnection();
            MySqlCommand mySqlCommand = new MySqlCommand("SELECT * FROM `lesson` WHERE `LessonName` = @lN", dB.GetConnection());
            MySqlCommand mySqlCommand2 = new MySqlCommand("UPDATE `lesson` SET `LessonNote` = @lesN", dB.GetConnection());
            mySqlCommand.Parameters.Add("@lN", MySqlDbType.VarChar).Value = lesson;
            if (NoteCardLesson.Text != null && NoteCardLesson.Text != String.Empty)
            {
                mySqlCommand2.Parameters.Add("@lesN", MySqlDbType.VarChar).Value = NoteCardLesson.Text;
                dB.OpenConnection();
                if (mySqlCommand2.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Создан");;
                }
                else
                {
                    MessageBox.Show("Не создан");
                }
                dB.CloseConnection();
            }

            DateTime dateTime = DateTime.Now;
            int dayDateTime = (int)DateTime.Now.DayOfWeek;
            using (MySqlDataReader oReader = mySqlCommand.ExecuteReader())
            {
                if(oReader.Read())
                {
                    NameCardLesson.Text = oReader.GetString("LessonName");
                    ProfessorNameCardLesson.Text = oReader.GetString("LessonProfessor");
                    DataNameCardLesson.Text = dateTime.AddDays(dayDateTime + (7 - numberWeek)).ToString();
                }              
            }
            dB.CloseConnection();
        }
    }
}
