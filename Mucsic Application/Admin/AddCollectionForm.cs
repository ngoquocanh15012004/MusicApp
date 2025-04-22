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
    public partial class AddCollectionForm : Form
    {
        public AddCollectionForm()
        {
            InitializeComponent();
            DGVList.Columns.Add("MusicID", "MusicID");
            DGVList.Columns.Add("MusicName", "MusicName");
            DGVList.Columns.Add("ArtistName", "ArtistName");
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            DGVSearch.DataSource = BLL_Musics.Instance.GetMusicsForDGV(searchTextBox.Text);
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DGVSearch.SelectedRows)
            {
                DGVList.Rows.Add(row.Cells["MusicID"].Value, row.Cells["MusicName"].Value, row.Cells["ArtistName"].Value);  
            }
        }
        private void removeBt_Click(object sender, EventArgs e)
        {
            if (DGVList.SelectedRows.Count > 0) 
            {
                foreach (DataGridViewRow row in DGVList.SelectedRows)
                    DGVList.Rows.Remove(row);
            }
        }

        private void submitBt_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên tuyển tập!");
                return;
            }
            int[] musicIDs = new int[DGVList.Rows.Count];
            for (int i = 0; i < musicIDs.Length; i++)
            {
                musicIDs[i] = Convert.ToInt32(DGVList.Rows[i].Cells["MusicID"].Value);
            }
            BLL_Collections.Instance.AddCollection(nameTextBox.Text, musicIDs);
            MessageBox.Show("Thêm tuyển tập thành công!");
        }
    }
}
