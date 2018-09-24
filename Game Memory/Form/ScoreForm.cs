using Game_Memory.DataBase;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Memory
{
    class ScoreForm
    {
        public static TableLayoutPanel tableScore;

        public void setTableScore(List<User> users)
        {
            tableScore = new TableLayoutPanel();
            IEnumerable<User> orderlyScore = orderByScore(users);
            setPropertyTable();
            drawScoreUsersTable(orderlyScore);
        }

        private IEnumerable<User> orderByScore(List<User> users)
        {
            IEnumerable<User> query = users.OrderByDescending(user => user.score);
            return query;
        }

        private void setPropertyTable()
        {
            tableScore.Font = new Font("Arial", 10, FontStyle.Bold);
            tableScore.Size = new Size(300, 100);
            tableScore.ColumnCount = 2;
            tableScore.RowCount = 1;
            tableScore.Location = new System.Drawing.Point(500, 250);
            tableScore.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableScore.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableScore.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableScore.Controls.Add(new Label() { Text = "Name" }, 0, 0);
            tableScore.Controls.Add(new Label() { Text = "Score" }, 1, 0);
        }

        private void drawScoreUsersTable(IEnumerable<User> orderlyScore)
        {
            int size = sizeTable(orderlyScore.Count());
            
            for (int i = 0; i < size; i++)
            {
                tableScore.RowCount = tableScore.RowCount + 1;
                tableScore.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
                tableScore.Controls.Add(new Label() { Text = orderlyScore.ElementAt(i).name }, 0, tableScore.RowCount - 1);
                tableScore.Controls.Add(new Label() { Text = orderlyScore.ElementAt(i).score.ToString() }, 1, tableScore.RowCount - 1);
            }
            MainForm.form.Controls.Add(tableScore);
        }

        private int sizeTable(int numberOfUsers)
        {
            if (numberOfUsers < 5)
                return numberOfUsers;
            return 5;
        }
    }
}
