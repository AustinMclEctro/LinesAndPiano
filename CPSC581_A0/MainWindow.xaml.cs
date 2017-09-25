using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Media;
using System.Resources;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;

namespace CPSC581_A0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> sounds = new List<string>();

        bool fullyPressed;
        bool fullyReleased;

        public MainWindow()
        {
            InitializeComponent();
            InitializeSounds();
        }


        /// <summary>
        /// Parses project resources for filenames including "piano"
        /// Adds them into a global list for easy access.
        /// </summary>
        private void InitializeSounds()
        {
            ResourceSet rSet = Properties.Resources.ResourceManager.GetResourceSet(CultureInfo.CurrentUICulture, true, true);
            foreach (DictionaryEntry entry in rSet)
            {
                string resourceName = entry.Key.ToString() + ".mp3";
                if (resourceName.StartsWith("piano"))
                    sounds.Add(resourceName);
            }
        }

        private void PlayPianoSound()
        {
            int r = new Random(DateTime.Now.Millisecond).Next(0, sounds.Count);
            Uri src = new Uri("Resources\\" + sounds[r], UriKind.Relative);

            MediaPlayer player = new MediaPlayer();
            GC.KeepAlive(player);
            player.Open(src);
            player.Play();
            player.MediaEnded += (sender, e) => Player_MediaEnded(sender, e, player);
        }


        /// <summary>
        /// Closes the media player when it is finished playing.
        /// </summary>
        private void Player_MediaEnded(object sender, EventArgs e, MediaPlayer m)
        {
            m.Close();
        }

        private void OnMouseMovement(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Point point = e.GetPosition(MainGrid);
            //System.Diagnostics.Debug.WriteLine("pointX: " + point.X + "  pointY: " + point.Y);
        }

        private void Button_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            fullyPressed = false;
            Storyboard press = FindResource("Press") as Storyboard;
            press.Begin();
            press.Completed += Press_Completed;
            PlayPianoSound();
        }

        private void Press_Completed(object sender, EventArgs e)
        {
            fullyPressed = true;
        }

        private void Button_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Storyboard lift = FindResource("Lift") as Storyboard;
            lift.Begin();
        }
    }
}
