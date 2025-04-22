using Music_Application.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Application.Admin
{
    public partial class NextFormEditMusic : Form
    {
        private Music editMusic;
        public NextFormEditMusic(Music music)
        {
            InitializeComponent();
            editMusic = music;
            loadMusic();
        }
        public void loadMusic()
        {
            nameTextBox.Text = editMusic.MusicName;
            artistTextBox.Text = BLL_Aritsts.Instance.GetArtistByID(editMusic.ArtistID.Value).ArtistName;
            dateTimePicker1.Value = editMusic.ReleaseDate.Value;
            textBox1.Text = editMusic.MusicURL;
            textBox2.Text = editMusic.ImageURL;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            editMusic.MusicName = nameTextBox.Text;
            editMusic.ArtistID = BLL_Aritsts.Instance.GetArtistByName(artistTextBox.Text).ArtistID;
            editMusic.ReleaseDate = dateTimePicker1.Value;
            editMusic.MusicURL = textBox1.Text;
            editMusic.ImageURL = textBox2.Text;
            BLL_Musics.Instance.EditMusic(editMusic);
            MessageBox.Show("Edit music successfully!");
        }
    }
}
