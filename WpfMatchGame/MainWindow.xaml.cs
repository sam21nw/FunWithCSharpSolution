using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;

namespace WpfMatchGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly DispatcherTimer timer = new DispatcherTimer();
        private int tenthOfSecondsElapsed;
        private int matchesFound;

        public MainWindow()
        {
            InitializeComponent();

            timer.Interval = TimeSpan.FromSeconds(.1);
            timer.Tick += Timer_Tick;

            SetUpGame();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            tenthOfSecondsElapsed++;
            timeTextBlock.Text = (tenthOfSecondsElapsed / 10f).ToString("0.0s");
            if (matchesFound == 8)
            {
                timer.Stop();
                timeTextBlock.Text += " - Play again?";
            }
        }

        private void SetUpGame()
        {
            List<string> animalEmojis = new List<string>()
            {
                "🐪","🐒","🐋","🐨","🦙","🐈","🐅","🦮","🦖","🦅","🐓","🦆","🐦‍","🦜","🦢","🕊️","🦉"
            };

            var random = new Random();
            //foreach (var textBlock in mainGrid.Children.OfType<TextBlock>())
            //{
            //    if (textBlock.Name != "timeTextBlock")
            //    {
            //        var index = random.Next(animalEmojis.Count);
            //        string nextEmoji = animalEmojis[index];
            //        textBlock.Text = nextEmoji;
            //        animalEmojis.RemoveAt(index);
            //    }
            //}

            timer.Start();
            tenthOfSecondsElapsed = 0;
            matchesFound = 0;
        }

        private TextBlock lastTextBlockClicked;
        private bool findingMatch = false;

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock = (TextBlock)sender;
            if (findingMatch == false)
            {
                textBlock.Visibility = Visibility.Hidden;
                lastTextBlockClicked = textBlock;
                findingMatch = true;
            }
            else if (textBlock.Text == lastTextBlockClicked.Text)
            {
                matchesFound++;
                textBlock.Visibility = Visibility.Hidden;
                findingMatch = false;
            }
            else
            {
                lastTextBlockClicked.Visibility = Visibility.Visible;
                findingMatch = false;
            }
        }

        private void TimeTextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (matchesFound == 8)
            {
                SetUpGame();
            }
        }
    }
}