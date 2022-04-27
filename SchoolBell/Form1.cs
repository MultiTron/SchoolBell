using System.Media;
using NAudio.Wave.SampleProviders;
using NAudio.Wave;

namespace SchoolBell
{
    public partial class Form1 : Form
    {
        private List<TimeOnly> times;
        private List<string> songs;
        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;
        private FadeInOutSampleProvider fade;
        private bool flag;

        public Form1()
        {
            InitializeComponent();
            clockTimer.Start();
            times = new List<TimeOnly>()
            {
                new TimeOnly(16, 44, 00),
                new TimeOnly(13, 55, 00),
                new TimeOnly(13, 58, 00),
                new TimeOnly(7, 59, 00),
                new TimeOnly(8, 40, 00),
                new TimeOnly(8, 49, 00),
                new TimeOnly(9, 30, 00),
                new TimeOnly(9, 39, 00),
                new TimeOnly(10, 20, 00),
                new TimeOnly(10, 49, 00),
                new TimeOnly(11, 30, 00),
                new TimeOnly(11, 39, 00),
                new TimeOnly(12, 20, 00),
                new TimeOnly(12, 29, 00),
                new TimeOnly(13, 10, 00),
                new TimeOnly(13, 19, 00),
                new TimeOnly(14, 00, 00)
            };
            songs = new List<string>()
            {
                "C:\\Users\\MultiTron\\Documents\\Audacity\\F1 Ceremony Melody.mp3"
            };
            playingTimer.Interval = 60000;
            if (outputDevice == null)
            {
                outputDevice = new WaveOutEvent();
                outputDevice.PlaybackStopped += OnPlaybackStopped;
            }
            listSongs.DataSource = songs;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            startTimer.Start();
            picStatus.BackColor = Color.Green;
        }

        private void startTimer_Tick(object sender, EventArgs e)
        {
            foreach (var time in times)
            {
                if (time == new TimeOnly(DateTime.Now.Hour, DateTime.Now.Minute))
                {
                    if (outputDevice.PlaybackState != PlaybackState.Playing)
                    {
                        RandomSong();
                        outputDevice.Play();
                        playingTimer.Start();
                        if (time.Minute % 10 == 0)
                        {
                            flag = true;
                        }
                        else
                        {
                            flag = false;
                        }
                    }
                }
            }
        }

        private void RandomSong()
        {
            Random rnd = new Random();
            audioFile = new AudioFileReader(songs[rnd.Next(songs.Count)]);
            fade = new FadeInOutSampleProvider(audioFile, true);
            fade.BeginFadeIn(2000);
            outputDevice.Init(fade);
        }

        private void playingTimer_Tick(object sender, EventArgs e)
        {
            if (!flag) 
            {
                Fade();
                outputDevice?.Stop();
                playingTimer.Stop();
            }
            flag = false;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            outputDevice?.Stop();
            startTimer.Stop();
            playingTimer.Stop();
            picStatus.BackColor = Color.Red;
        }

        private void clockTimer_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void OnPlaybackStopped(object sender, StoppedEventArgs args)
        {
            audioFile.Dispose();
            audioFile = null;
        }

        private void volumeSlider1_VolumeChanged(object sender, EventArgs e)
        {
            outputDevice.Volume = volumeSlider1.Volume;
        }
        private void Fade()
        {
            fade.BeginFadeOut(2000);
            Thread.Sleep(2000);
        }

        private void chkEdit_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEdit.Checked)
            {
                panel1.Enabled = true;
            }
            else
            {
                panel1.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.ShowDialog();
            using (FileStream fs = (FileStream)saveFileDialog.OpenFile())
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    foreach (var song in songs)
                    {
                        sw.WriteLine(song);
                    }
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            using (FileStream fs = (FileStream)openFileDialog.OpenFile())
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        songs.Add(line);
                    }
                }
            }
        }

        private void btnAddSong_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            songs.Add(openFileDialog.FileName);
        }
    }
}