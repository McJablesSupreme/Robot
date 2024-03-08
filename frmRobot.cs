using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Robot
{
    public partial class frmRobot : Form
    {
        Robot robot = new Robot();
        Coin coin = new Coin();

        public frmRobot()
        {
            InitializeComponent();
            robot.OutOfBounds += Robot_OutOfBounds;
            coin.CoinCollected += Coin_CoinCollected;
        }

        private void Robot_OutOfBounds(string msg)
        {
            lblBonk.Text = msg;
            lblBonk.Location = new Point(robot.XPos + 5, robot.YPos - 5);
        }

        private void Coin_CoinCollected()
        {
            lblCoin.Text = "";
            DialogResult result = MessageBox.Show("You got the money. Noice.",
                "Congratulations. You win.");

            ResetGame();
        }


        private void PlaceCoin()
        {
            coin.RandomizeLocation();
            lblCoin.Location = new Point(coin.XPos, coin.YPos);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            robot.MoveNorth(lblRobot.Location.Y, robot.moveUnit);

            lblRobot.Location = new Point(robot.XPos, robot.YPos);

            lblRobot.Text = "↑";

            UpdateDisplays();

            coin.CheckCollision(robot.XPos, robot.YPos);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            robot.MoveSouth(lblRobot.Location.Y, robot.moveUnit);

            lblRobot.Location = new Point(robot.XPos, robot.YPos);

            lblRobot.Text = "↓";

            UpdateDisplays();

            coin.CheckCollision(robot.XPos, robot.YPos);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            robot.MoveWest(lblRobot.Location.X, robot.moveUnit);

            lblRobot.Location = new Point(robot.XPos, robot.YPos);

            lblRobot.Text = "←";

            UpdateDisplays();

            coin.CheckCollision(robot.XPos, robot.YPos);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            robot.MoveEast(lblRobot.Location.X, robot.moveUnit);

            lblRobot.Location = new Point(robot.XPos, robot.YPos);

            lblRobot.Text = "→";

            UpdateDisplays();

            coin.CheckCollision(robot.XPos, robot.YPos);
        }

        private void btnGoOne_Click(object sender, EventArgs e)
        {
            robot.moveUnit = 1;
            trkBarSpeedControl.Value = 1;
            UpdateDisplays();
        }

        private void btnGoTen_Click(object sender, EventArgs e)
        {
            robot.moveUnit = 10;
            trkBarSpeedControl.Value = 10;
            UpdateDisplays();
        }

        private void UpdateDisplays()
        {
            int currentXposition = robot.XPos - 100;
            int currentYposition = 105 - robot.YPos;
            lblCoordinates.Text = "X = " + currentXposition + " Y = " + currentYposition;
            lblMoveSpeed.Text = "Move Speed = " + robot.moveUnit;
        }

        private void frmRobot_Load(object sender, EventArgs e)
        {
            UpdateDisplays();
            lblBonk.Text = "";
            lblCoin.Text = "💰";
            PlaceCoin();
        }

        private void btnResetPosition_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void trkBarSpeedControl_Scroll(object sender, EventArgs e)
        {
            robot.moveUnit = trkBarSpeedControl.Value;
            UpdateDisplays();
        }

        private void ResetGame()
        {
            robot.XPos = Robot.xStartPos;
            robot.YPos = Robot.yStartPos;
            lblRobot.Location = new Point(robot.XPos, robot.YPos);
            UpdateDisplays();
            lblBonk.Text = "";
            lblRobot.Text = "↑";
            lblCoin.Text = "💰";
            PlaceCoin();
        }
    }
}
