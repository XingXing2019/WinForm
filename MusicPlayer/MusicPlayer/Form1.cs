using System;
using System.Collections.Generic;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        private readonly List<string> musicList;
        private readonly SoundPlayer sound;
        public Form1()
        {
            InitializeComponent();
            musicList = new List<string>();
            sound = new SoundPlayer();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                var ofd = new OpenFileDialog
                {
                    Title = "Select Musics",
                    InitialDirectory = @"C:\Users\xxing\OneDrive\Desktop\Musics",
                    Multiselect = true,
                };
                ofd.ShowDialog();
                var paths = ofd.FileNames;
                musicList.AddRange(paths);
                foreach (var path in paths)
                    ltbMusics.Items.Add(Path.GetFileName(path));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void ltbMusics_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                sound.SoundLocation = musicList[ltbMusics.SelectedIndex];
                sound.Play();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                var index = ltbMusics.SelectedIndex + 1;
                index %= ltbMusics.Items.Count;
                ltbMusics.SelectedIndex = index;
                sound.SoundLocation = musicList[index];
                sound.Play();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            try
            {
                var index = ltbMusics.SelectedIndex - 1;
                index += index < 0 ? ltbMusics.Items.Count : 0;
                ltbMusics.SelectedIndex = index;
                sound.SoundLocation = musicList[index];
                sound.Play();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
