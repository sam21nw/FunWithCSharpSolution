using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace WpfMatchGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            SetUpGame();
        }

        private void SetUpGame()
        {
            List<string> animalEmojis = new List<string>()
            {
                "🐪", "🐪",
                "🐒", "🐒",
                "🐋", "🐋",
                "🐨", "🐨",
                "🦙", "🦙",
                "🐈", "🐈",
                "🐅", "🐅",
                "🦮", "🦮",
            };

            var random = new Random();
            foreach (var textBlock in mainGrid.Children.OfType<TextBlock>())
            {
                var index = random.Next(animalEmojis.Count);
                string nextEmoji = animalEmojis[index];
                textBlock.Text = nextEmoji;
                animalEmojis.RemoveAt(index);
            }
        }
    }
}