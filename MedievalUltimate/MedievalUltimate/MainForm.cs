using MusicLibrary3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MedievalUltimate
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        Music music = null;
        private void btnCreateMusic_Click(object sender, EventArgs e)
        {
            music = Fncs.GetSong(Genre.Medieval, FormType.Arch, Midi.Channel.Channel1);
            lblSongCreated.Text = "A song has been created";
            MessageBox.Show("Composed!");
        }

        private void btnPlayMusic_Click(object sender, EventArgs e)
        {
            if (music != null)
            {
                music.PlayMusic(true);
            }
            else
            {
                MessageBox.Show("Create a song first :p");
            }
        }
        string file = "";
        private void btnSaveMusic_Click(object sender, EventArgs e)
        {
            if (music != null)
            {
                if (!cbSamePath.Checked || file == "")
                {
                    SaveFileDialog fdsave = new SaveFileDialog();
                    fdsave.Filter = "WAVE files|*.wav";
                    fdsave.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    fdsave.Title = "Save as Wave file:";
                    if (fdsave.ShowDialog() == DialogResult.OK)
                    {
                        file = fdsave.FileName;
                    }
                }
                Fncs.Save(AudioFileType.WAV, file, music);
                cbSamePath.Enabled = true;
                MessageBox.Show("Saved!");
            }
            else
            {
                MessageBox.Show("Create a song first :p");
            }
        }
    }
}