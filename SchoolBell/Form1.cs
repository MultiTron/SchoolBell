using System.Media;
using WMPLib;

namespace SchoolBell
{
    public partial class Form1 : Form
    {
        private List<TimeOnly> times;
        private WindowsMediaPlayer player;
        private List<string> songs;

        public Form1()
        {
            InitializeComponent();
            times = new List<TimeOnly>()
            {
                new TimeOnly(12, 15),
                new TimeOnly(7, 59),
                new TimeOnly(8, 40),
                new TimeOnly(8, 49),
                new TimeOnly(9, 30),
                new TimeOnly(9, 39),
                new TimeOnly(10, 20),
                new TimeOnly(10, 49),
                new TimeOnly(11, 30),
                new TimeOnly(11, 39),
                new TimeOnly(12, 20),
                new TimeOnly(12, 29),
                new TimeOnly(13, 10),
                new TimeOnly(13, 19),
                new TimeOnly(14)
            };
            songs = new List<string>()
            {
                "C:\\Users\\PC1\\Downloads\\Raina Popgeorgieva - Koi ushi bairaka Instumental.wav"
            };
            player = new WindowsMediaPlayer();
            playingTimer.Interval = 60000;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            startTimer.Start();
            lblStatus.Text = "Armed";
        }

        private void startTimer_Tick(object sender, EventArgs e)
        {
            foreach (var time in times)
            {
                if (time == new TimeOnly(DateTime.Now.Hour, DateTime.Now.Minute))
                {
                    PopulateWithRandomSong();
                    player.controls.play();
                    playingTimer.Start();
                }
            }
        }

        private void PopulateWithRandomSong()
        {
            Random rand = new Random();
            int randIndex = rand.Next(songs.Count);
            player.URL = songs[randIndex];
        }

        private void playingTimer_Tick(object sender, EventArgs e)
        {
            player.controls.stop();
            playingTimer.Stop();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            startTimer.Stop();
            playingTimer.Stop();
            lblStatus.Text = "Stopped";
        }
    }
}