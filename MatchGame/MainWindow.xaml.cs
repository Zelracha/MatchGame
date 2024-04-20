using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MatchGame
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
            //list of the animals in the matching game
            List<string> animalEmoji = new List<string>()
            {
                "🐅", "🐅",
                "🐇", "🐇",
                "🐺", "🐺",
                "🐼", "🐼",
                "🦝", "🦝",
                "😾", "😾",
                "🐶", "🐶",
                "🦊", "🦊",
            };

            //Random Placement of the animals
            Random random = new Random();


            foreach (TextBlock textBlock in mainGrid.Children.OfType<TextBlock>())
            {
                int index = random.Next(animalEmoji.Count);
                string nextEmoji = animalEmoji[index];
                textBlock.Text = nextEmoji;
                animalEmoji.RemoveAt(index);
            }

        }
    }
}