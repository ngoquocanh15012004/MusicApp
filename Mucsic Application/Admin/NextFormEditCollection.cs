using Music_Application.BLL;
using Music_Application.DAL;
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
    public partial class NextFormEditCollection : Form
    {
        private int collectionID;
        public NextFormEditCollection(int collectionID)
        {
            InitializeComponent();
            this.collectionID = collectionID;
            loadCollection();
        }

        public void loadCollection()
        {
            DGVList.DataSource = BLL_Musics.Instance.GetMusicsForDGV(collectionID);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            DGVSearch.DataSource = BLL_Musics.Instance.GetMusicsForDGV(searchTextBox.Text);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            /*foreach (DataGridViewRow row in DGVSearch.SelectedRows)
            {
                DGVList.Rows.Add(row.Cells["MusicID"].Value, row.Cells["MusicName"].Value, row.Cells["ArtistName"].Value);
            }*/
        }
    }
}
