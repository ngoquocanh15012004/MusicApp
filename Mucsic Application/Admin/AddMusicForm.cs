using Music_Application.BLL;
using System;
using System.IO;
using System.Net.Http;
using System.Windows.Forms;

namespace Music_Application.Admin
{
    public partial class AddMusicForm : Form
    {
        private string attachedFileName;
        private byte[] attachedFileBytes;

        public AddMusicForm()
        {
            InitializeComponent();
        }

        private void attachButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "MP3 Files|*.mp3";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                attachedFileName = ofd.SafeFileName;
                fileLabel.Text = attachedFileName;
                attachedFileBytes = File.ReadAllBytes(ofd.FileName);
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            UpLoadFile();
            UpdateDatabase();
        }
        public async void UpLoadFile()
        {
            if (attachedFileBytes != null && attachedFileBytes.Length > 0)
            {
                // Tạo HTTP Client
                using (HttpClient client = new HttpClient())
                {
                    // Tạo nội dung yêu cầu
                    MultipartFormDataContent content = new MultipartFormDataContent();
                    ByteArrayContent fileContent = new ByteArrayContent(attachedFileBytes);
                    content.Add(fileContent, "file", attachedFileName);

                    // Gửi yêu cầu POST
                    HttpResponseMessage response = await client.PostAsync("http://192.168.1.14:8000/upload", content);

                    // Xử lý phản hồi
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Upload thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Upload không thành công. Lỗi: " + response.StatusCode);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng đính kèm một tệp trước khi tải lên.");
            }
        }
        public void UpdateDatabase()
        {
            if (BLL_Aritsts.Instance.GetArtistByName(artistTextBox.Text) == null)
            {
                Artist artist = new Artist()
                {
                    ArtistName = artistTextBox.Text
                };
                BLL_Aritsts.Instance.AddArtist(artist);
            }
            BLL_Musics.Instance.AddMusic(new Music()
            {
                MusicName = nameTextBox.Text,
                ArtistID = BLL_Aritsts.Instance.GetArtistByName(artistTextBox.Text).ArtistID,
                ReleaseDate = dateTimePicker1.Value,
                TotalViews = 0,
                MusicURL = "http://192.168.1.14:8000/" + attachedFileName,
                ImageURL = "D://Downloads//25.jpg"
            });
        }
    }
}
