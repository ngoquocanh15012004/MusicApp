using Music_Application.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Application.Admin
{
    public partial class DelMusicForm : Form
    {
        public DelMusicForm()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns.Clear();
            }
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "MusicID", HeaderText = "MusicID" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "MusicName", HeaderText = "Title" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ArtistID", HeaderText = "ArtistID" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "MusicURL", HeaderText = "URL" });
            dataGridView1.DataSource = BLL_Musics.Instance.GetMusicByName(searchTextBox.Text);
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            DeleteDatabase();
        }
        public void DeleteDatabase()
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select at least one music to delete!");
                return;
            }
            else
            {
                List<int> musicIDs = new List<int>();
                List<string> musicTitles = new List<string>();
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    int musicID = (int)row.Cells[0].Value;
                    string musicTitle = ((string)row.Cells[3].Value).Substring("http://192.168.1.14:8000/".Length);
                    musicIDs.Add(musicID);
                    musicTitles.Add(musicTitle);
                }
                foreach (int musicID in musicIDs)
                {
                    BLL_Musics.Instance.RemoveMusic(musicID);
                }
                foreach (string musicTitle in musicTitles)
                {
                    DeleteFiles(musicTitle);
                }
                MessageBox.Show("Delete selected musics successfully!");
                dataGridView1.DataSource = BLL_Musics.Instance.GetMusicByName(searchTextBox.Text);
            }

        }
        public async void DeleteFiles(string filename)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var values = new Dictionary<string, string>
                    {
                        { "filename", filename }
                    };
                    var content = new FormUrlEncodedContent(values);
                    HttpResponseMessage response = await client.PostAsync("http://192.168.1.14:8000/delete", content);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseString = await response.Content.ReadAsStringAsync();
                        // Optionally, show success message for each file
                        // MessageBox.Show(responseString);
                    }
                    else
                    {
                        MessageBox.Show($"Error deleting file '{filename}' on server");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Exception: {ex.Message}");
                }
            }
        }
    }
}
