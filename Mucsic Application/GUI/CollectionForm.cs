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

namespace Music_Application.GUI
{
    public partial class CollectionForm : Form
    {
        public int collectionId { get; set; }
        public CollectionForm(int id)
        {
            InitializeComponent();
            load(id);
        }
        public void load(int ID)
        {
            Collection collection = BLL_Collections.Instance.GetCollectionByID(ID);
            collectionId = collection.CollectionID;
            foreach (Music music in collection.Musics)
            {
                ucMusic bar = new ucMusic();
                bar.music = music;
                bar.load();
                listPanel.Controls.Add(bar);
            }
            collectionName.Text = collection.CollectionName;
            try
            {
                CollectionPic.BackgroundImage = Image.FromFile(collection.ImageURL);
            }
            catch
            {
                CollectionPic.BackgroundImage = null;
            }
        }
        private void RemoveMusicFromPlaylist(object sender, EventArgs e)
        {
            ucPlayListSong removedBar = sender as ucPlayListSong;
            listPanel.Controls.Remove(removedBar);
        }
        private void playBt_Click(object sender, EventArgs e)
        {
            Collection collection = BLL_Collections.Instance.GetCollectionByID(collectionId);
            BLL_Player.Instance.setMusicQueue(collection.Musics.ToList());
            MainForm.Instance.setPlayer();
        }
    }
}
