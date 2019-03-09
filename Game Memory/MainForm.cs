using Game_Memory.DataBase;
using Game_Memory.Levels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Game_Memory
{
    public partial class MainForm : Form
    {
        public static MainForm form;
        public static double seconds = 0;

        private User user = new User(0);
        private UserController userController = new UserController();
        private ScoreForm scoreForm = new ScoreForm();
        private Level level;

        private int clicks = 0;
        private int score = 0;

        private PictureBox pictureLastClick;
        private PictureBox previousPicture;
        private TableLayoutPanel tableScore = new TableLayoutPanel();

        public MainForm()
        {
            form = this;
            List<User> users = userController.deserializa();
            InitializeComponent();
            labelDefeat.Text = "";
            FlagManipulation.loadAllFlags();
            FlagManipulation.loadImageDoubt();
            setTableScore();
        }

        private void setTableScore()
        {
            List<User> users = userController.deserializa();
            scoreForm.setTableScore(users);
        }

        private void button_Start(object sender, EventArgs e)
        {
            if (!userName.Text.Equals(""))
            {
                settingStart();
                level.start();
                setLabelLevel();
            }
            else
            {
                labelEnterTheName.Text = "Enter the name";
            }
        }

        private void settingStart()
        {
            level = new Level01();
            labelDefeat.Text = "";
            score = 0;
            labelScore.Text = score.ToString();
            clicks = 0;
            user.name = userName.Text;
            user = userController.newUser(user);
            this.Controls.Remove(ScoreForm.tableScore);
            buttonStart.Enabled = false;
            timerStopwatch.Enabled = true;
        }

        private void timer_Stopwatch(object sender, EventArgs e)
        {
            if (seconds <= 0)
            {
                timerStopwatch.Enabled = false;
                defeat();
            }       
        }

        public void imagem_Click(object sender, EventArgs e)
        {
            if (!(sender is PictureBox))
                return;

            previousPicture = pictureLastClick;
            pictureLastClick = (PictureBox)sender;
            showImage();
            clicks++;
            twoClickImage();
        }

        private void showImage()
        {
            foreach (Flag flag in FlagManipulation.flags)
            {
                if (flag.name.Equals(pictureLastClick.Name))
                {
                    pictureLastClick.Image = flag.image;
                    pictureLastClick.Refresh();
                }
            }
        }

        private void twoClickImage()
        {
            if (clicks == 2)
            {
                clicks = 0;
                if (!pictureLastClick.Name.Equals(previousPicture.Name) || 
                    validateTag(pictureLastClick.Tag.ToString(), 
                    previousPicture.Tag.ToString()))
                {
                    wrongPairOfFlags();
                }
                else
                {
                    correctPairOfFlags();
                }
            }
        }

        private bool validateTag(string tagOne, string tagTwo)
        {
            return (tagOne.Equals("first") && tagTwo.Equals("first")) || 
                (tagOne.Equals("second") && tagTwo.Equals("second"));
        }

        private void wrongPairOfFlags()
        {
            imageRemovalDelay();
            backImageDoubt();
        }

        private void imageRemovalDelay()
        {
            if (!pictureLastClick.Name.Equals(previousPicture.Name))
                Thread.Sleep(1000);
        }

        private void backImageDoubt()
        {
            previousPicture.Image = FlagManipulation.doubt.image;
            pictureLastClick.Image = FlagManipulation.doubt.image;
            pictureLastClick.Refresh();
            previousPicture.Refresh();
        }
        
        private void correctPairOfFlags()
        {
            withdrawEventImage();
            increaseScore();
            level.increaseHits();
            nextLevel();
        }

        private void withdrawEventImage()
        {
            previousPicture.Click -= new EventHandler(imagem_Click);
            pictureLastClick.Click -= new EventHandler(imagem_Click);
        }

        private void increaseScore()
        {
            score += (-1 * ((int)StopwatchForm.timeSpan.TotalSeconds) + 10) * level.multiplierPoints();
            labelScore.Text = score.ToString();
        }

        private void nextLevel()
        {
            if (level.getHits() == level.maxHits())
            {
                level = level.nextLevel();
                clearPictureBox();
                level.start();
                setLabelLevel();
                victory();
            }
        }
        
        private void victory()
        {
            if (level.GetType() == typeof(Level09))
            {
                endGame();
                labelDefeat.ForeColor = Color.DarkGreen;
                labelDefeat.Text = "Victory";
            }
        }

        private void defeat()
        {
            endGame();
            labelDefeat.ForeColor = Color.DarkRed;
            labelDefeat.Text = "Defeat";
        }

        private void endGame()
        {
            clearPictureBox();
            setScoreEndGame();
            userController.save(user);
            buttonStart.Enabled = true;
            setTableScore();
        }

        private void clearPictureBox()
        {
            while (existPictureBoxInWindow())
                removeAllPictureBox();
        }

        private bool existPictureBoxInWindow()
        {
            foreach (Control control in this.Controls)
            {
                if (control is PictureBox)
                    return true;
            }
            return false;
        }

        private void removeAllPictureBox()
        {
            foreach (Control control in this.Controls)
            {
                if (control is PictureBox)
                    this.Controls.Remove(control);
            }
        }

        private void setScoreEndGame()
        {
            if (user.score < score)
                user.score = score;
        }

        private void setLabelLevel()
        {
            labelLevel.Text = level.getLevel();
        }
    }
}
