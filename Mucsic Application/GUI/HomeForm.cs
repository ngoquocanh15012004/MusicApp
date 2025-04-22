using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Music_Application.BLL;
using Music_Application.DAL;
using Music_Application.GUI;

namespace Music_Application
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
            loadFirstPanel();
            loadSecondPanel();
            loadThirdPanel();
            loadFourthPanel();
        }
        private void loadFirstPanel()
        {
            List<Music> listMusic = BLL_Musics.Instance.GetTop5Musics();
            foreach (Music music in listMusic)
            {
                ucMusic bar = new ucMusic();
                bar.music = music;
                bar.load();
                firstPanel.Controls.Add(bar);
            }
        }
        private void loadSecondPanel()
        {
            List<Collection> listCollection = BLL_Collections.Instance.GetCollectionsByOrder(1);
            foreach (Collection cl in listCollection)
            {
                ucPlaylistBox bar = new ucPlaylistBox();
                bar.collectionId = cl.CollectionID;
                bar.pictureBoxClick += pictureBoxClick;
                bar.load();
                secondPanel.Controls.Add(bar);
            }
        }
        private void loadThirdPanel()
        {
            List<Collection> listCollection = BLL_Collections.Instance.GetCollectionsByOrder(2);
            foreach (Collection cl in listCollection)
            {
                ucPlaylistBox bar = new ucPlaylistBox();
                bar.collectionId = cl.CollectionID;
                bar.pictureBoxClick += pictureBoxClick;
                bar.load();
                thirdPanel.Controls.Add(bar);
            }
        }
        private void loadFourthPanel()
        {
            List<Collection> listCollection = BLL_Collections.Instance.GetCollectionsByOrder(3);
            foreach (Collection cl in listCollection)
            {
                ucPlaylistBox bar = new ucPlaylistBox();
                bar.collectionId = cl.CollectionID;
                bar.pictureBoxClick += pictureBoxClick;
                bar.load();
                fourthPanel.Controls.Add(bar);
            }
        }
        private void Bar_pictureBoxClick(object sender, EventArgs e)
        {
            //ucPlaylistBox album = sender as ucPlaylistBox;
            //AlbumForm albumForm = new AlbumForm(selectedAlbum);
            //Form1.Instance.openForm(albumForm, this, selectedAlbum.albumName);
        }
        private void pictureBoxClick(object sender, EventArgs e)
        {
            ucPlaylistBox box = sender as ucPlaylistBox;
            MainForm.Instance.openForm(new CollectionForm(box.collectionId));
        }
    }
}
