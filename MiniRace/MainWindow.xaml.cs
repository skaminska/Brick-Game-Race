using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;

namespace MiniRace
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer timer;
        private int columnNumber;
        private int speed;
        private Random random;
        private Thickness enemyMargin;

        private int score;

        private int startingSpeed;
        private int startAgain;
        private bool gameEnded;

        public MainWindow()
        {
            InitializeComponent();

            timer = new DispatcherTimer();
            timer.Tick += new EventHandler(timer_Thick);
            timer.Interval = new TimeSpan(0, 0, 0, 0, 5);

            random = new Random();

            score = 0;
            scoreLabel.Content = score.ToString();

            startAgain = 3;
            gameEnded = false;

            columnNumber = 1;
            speed = 5;
        }

        private void timer_Thick(object sender, EventArgs e)
        {
            if (gameEnded == false)
            {
                startButton.Content = "Zaczynamy";
                moveLines(speed);
                moveEnemy(speed);
                gameOver();
            }
            if(gameEnded == true)
            {
                System.Threading.Thread.Sleep(1000);
                gameOverLabel.Content = startAgain;
                startAgain--;

                if (startAgain < 0)
                {
                    gameEnded = false;
                    gameOverLabel.Visibility = Visibility.Hidden;
                    gameOverLabel.Content = "Przegrałeś";
                }
            }
        }

        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            switch(gameSpeedComboBox.SelectedIndex)
            {
                case 0:
                    speed = 2;
                    break;
                case 1:
                    speed = 5;
                    break;
                case 2:
                    speed = 7;
                    break;
                case 3:
                    speed = 9;
                    break;
                case 4:
                    speed = 11;
                    break;
            }
            startingSpeed = speed;
            timer.Start();
            startButton.Visibility = Visibility.Hidden;
            gameSpeedComboBox.Visibility = Visibility.Hidden;
        }

        private void moveEnemy(int speed)
        {
            enemyMargin = enemy1.Margin;

            if(enemyMargin.Top >= 400)
            {
                enemyMargin.Top = -100;

                int randomNumber = random.Next(0, 3);
                int randomNumber1 = random.Next(0, 3);

                Grid.SetColumn(enemy1, randomNumber);
                Grid.SetColumn(enemy2, randomNumber1);
                enemy1.Margin = enemyMargin;
                enemy2.Margin = enemyMargin;

                score += speed * 10;
                scoreLabel.Content = score.ToString();
            }
            else
            {
                enemyMargin.Top += speed;
                enemy1.Margin = enemyMargin;
                enemy2.Margin = enemyMargin;
            }
        }

        public void gameOver()
        {
            if(Grid.GetColumn(carImage)==Grid.GetColumn(enemy1) || Grid.GetColumn(carImage) == Grid.GetColumn(enemy2))
            {
                if (enemyMargin.Top >= 150)
                {
                    timer.Stop();
                    restartButton.Visibility = Visibility.Visible;
                    gameOverLabel.Visibility = Visibility.Visible;
                }
            }
        }

        private void moveLines(int speed)
        {
            Thickness marigin = line1.Margin;
            Thickness marigin1 = line2.Margin;
            Thickness marigin2 = line3.Margin;
            Thickness marigin3 = line4.Margin;
            Thickness marigin4 = line5.Margin;
            Thickness marigin5 = line6.Margin;

            if(marigin.Top >= 400)
            {
                marigin.Top = -50;
                line1.Margin = marigin;
            }
            else
            {
                marigin.Top += speed+5;
                line1.Margin = marigin;
            }

            if (marigin1.Top >= 400)
            {
                marigin1.Top = -50;
                line2.Margin = marigin1;
            }
            else
            {
                marigin1.Top += speed+5;
                line2.Margin = marigin1;
            }
            if (marigin2.Top >= 400)
            {
                marigin2.Top = -50;
                line3.Margin = marigin2;
            }
            else
            {
                marigin2.Top += speed+5;
                line3.Margin = marigin2;
            }

            if (marigin3.Top >= 400)
            {
                marigin3.Top = -50;
                line4.Margin = marigin3;
            }
            else
            {
                marigin3.Top += speed+5;
                line4.Margin = marigin3;
            }

            if (marigin4.Top >= 400)
            {
                marigin4.Top = -50;
                line5.Margin = marigin4;
            }
            else
            {
                marigin4.Top += speed+5;
                line5.Margin = marigin4;
            }
            if (marigin5.Top >= 400)
            {
                marigin5.Top = -50;
                line6.Margin = marigin5;
            }
            else
            {
                marigin5.Top += speed+5;
                line6.Margin = marigin5;
            }
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Left)
            {
                if (columnNumber != 0)
                {
                    columnNumber -= 1;
                    Grid.SetColumn(carImage, columnNumber);
                }
            }

            if(e.Key == Key.Right)
            {
                if(columnNumber != 2)
                {
                    columnNumber += 1;
                    Grid.SetColumn(carImage, columnNumber);
                }
            }

            if (e.Key == Key.Up)
            {
                if(speed == startingSpeed)
                    speed += 10;
            }
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Up)
            {
                if(speed == startingSpeed+10)
                    speed -= 10;
            }
        }

        private void RestartButton_Click(object sender, RoutedEventArgs e)
        {
            restartButton.Visibility = Visibility.Hidden;

            Grid.SetColumn(enemy1, 0);
            Grid.SetColumn(carImage, 1);
            Grid.SetColumn(enemy2, 2);

            score = 0;
            scoreLabel.Content = score.ToString();

            startAgain = 3;
            enemyMargin.Top = 0;
            enemy1.Margin = enemyMargin;
            enemy2.Margin = enemyMargin;
            gameEnded = true;
            timer.Start();
        }
    }
}
