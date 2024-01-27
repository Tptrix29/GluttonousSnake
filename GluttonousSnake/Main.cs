using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

using GluttonousSnake;
using SysTimer = System.Timers;


namespace GluttonousSnake
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private Snake snake;
        private ArrayList preys = new ArrayList();
        private int prey_num = 2;

        private SysTimer.Timer timer;
        // 代理snake活动监听
        public delegate void listen();

        private void Start_Click(object sender, EventArgs e)
        {
            toMainPage(false);
            startGame();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            toMainPage(true);
            timer.Stop();
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            this.startGame();
        }

        private void Progress_Click(object sender, EventArgs e)
        {
            if (this.Progress.Text == "STOP")
            {
                this.Progress.Text = "CONTINUE";
                timer.Stop();
                MessageBox.Show("Stopped!");
            }
            else if (this.Progress.Text == "CONTINUE")
            {
                this.Progress.Text = "STOP";
                timer.Start();
            }

        }

        private void Acc_Click(object sender, EventArgs e)
        {
            double newInterval = this.timer.Interval - 50;
            if (newInterval > 0)
                this.timer.Interval = newInterval;
        }

        private void Dcc_Click(object sender, EventArgs e)
        {
            double newInterval = this.timer.Interval + 50;
            if (newInterval < 10000)
                this.timer.Interval = newInterval;
        }

        // 界面转换
        private void toMainPage(bool sw)
        {
            this.Start.Visible = sw;
            this.Exit.Visible = sw;
            this.Title.Visible = sw;
            
            this.Plane.Visible = !sw;
            this.Back.Visible = !sw;
            this.Restart.Visible = !sw;
            this.Progress.Visible = !sw;
            this.Acc.Visible = !sw;
            this.Dcc.Visible = !sw;
            this.PreyNumber.Visible = !sw;
            this.select.Visible = !sw;
        }

        // 游戏开始
        private void startGame()
        {
            if (snake != null) {
                this.Plane.Controls.Clear();
                timer.Stop();
                preys = new ArrayList();
            }
            snake = new Snake(this.Plane);
            initPreys(prey_num);
            this.InitTimer();
            this.Progress.Text = "STOP";
        }


        // 按键事件监控
        private void Main_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (snake != null)
            {
                // Up
                if (e.KeyChar == 119)
                {
                    if (snake.getHeadDirection()!='d')
                        snake.addTurn('u');
                }

                // Down
                else if (e.KeyChar == 115)
                {
                    if (snake.getHeadDirection() != 'u')
                        snake.addTurn('d');
                }

                // Right
                else if (e.KeyChar == 100)
                {
                    if (snake.getHeadDirection() != 'l')
                        snake.addTurn('r');
                }

                // Left
                else if (e.KeyChar == 97)
                {
                    if (snake.getHeadDirection() != 'r')
                        snake.addTurn('l');
                }
                else
                    ;
            }
        }

        

        // 时间变化监控
        private void InitTimer(double interval = 500)
        {
            timer = new SysTimer.Timer(interval);
            timer.AutoReset = true;
            timer.Enabled = true;
            timer.Elapsed += new SysTimer.ElapsedEventHandler(tickTimer);
        }

        private void tickTimer(object sender, System.Timers.ElapsedEventArgs e)
        {
            this.Invoke(new listen(listenSnake));
        }

        private void listenSnake() {
            if (snake.eatSelf())
            {
                timer.Stop();
                MessageBox.Show("Eat Your Own Body! Dead!");
                toMainPage(true);
            }
            
            else
                snake.actByTime(preys);
            Prey p = (Prey)preys[0];

        }
        // Preys
        private void initPreys(int n) {
            for (; n > 0; n--) 
                preys.Add(new Prey(this.Plane));
        }

        private void removePreysInPlane() {
            int n = prey_num;
            while (n > 0) {
                foreach (Control item in this.Plane.Controls)
                {
                    if (item.GetType().ToString() == "GluttonousSnake.Prey")
                    {
                        this.Plane.Controls.Remove(item);
                        n--;
                    }
                }
            }
        }

        private void PreyNumber_SelectedIndexChanged(object sender, EventArgs e)
        {   
            this.removePreysInPlane();
            prey_num = int.Parse(this.PreyNumber.SelectedItem.ToString());
            preys.Clear();
            preys = new ArrayList();
            initPreys(prey_num);
            this.Plane.Focus();
        }
    }
}
