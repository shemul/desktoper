using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FlickrNet;
using System.Net;
using Desktoper;
using MetroFramework.Forms;
using MetroFramework;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Threading;

namespace WinForms
{
    public partial class Mainform : MetroForm
    {

        Rectangle resolution = Screen.PrimaryScreen.Bounds;
        WebClient webClient;
        string destination;
        string filePath;
        Flickr f = FlickrManager.GetInstance();
        PhotoSearchOptions o;

        public Mainform()
        {
            InitializeComponent();
            filePath = Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData);
            System.IO.Directory.CreateDirectory(filePath + "/desktoper");
        }

     

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void PhotoSearchForm_Load(object sender, EventArgs e)
        {
            label4.Text = resolution.Width + " X " + resolution.Height;
            
        }

        
        public void flickerRequest()
        {
            o = new PhotoSearchOptions();
            o.Extras = PhotoSearchExtras.LargeUrl | PhotoSearchExtras.Description | PhotoSearchExtras.OwnerName | PhotoSearchExtras.Large1600Url;
            o.SortOrder = PhotoSearchSortOrder.Relevance;


            o.Text = workspace.Text;
            o.Tags = workspace.Text + ",large";
            o.Page = 1;
            o.PerPage = 50;
           // Thread.Sleep(3000);
            //bindingSource1.DataSource = f.PhotosSearch(o);

            if (InvokeRequired)
                Invoke(new MethodInvoker(InnerLoadData));

        }

        public void InnerLoadData()
        {
            bindingSource1.DataSource = f.PhotosSearch(o);

        }
        private void button1_Click(object sender, EventArgs e)
        {

            ThreadStart childref = new ThreadStart(flickerRequest);
            Thread childThread = new Thread(childref);
            childThread.Start();
            
        }

        private void btnSetas_Click(object sender, EventArgs e)
        {
            
           

            destination = filePath + "/desktoper/" + textBox2.Text + ".jpg";

            if (textBox5.Text == "")
            {
                MetroMessageBox.Show(this, "you must have to set tags and select an image", "Desktoper");
            }
            else
            {
               DownloadFile(textBox5.Text, destination);
            }
           
            

        }



        //Async Downloader
        public void DownloadFile(string urlAddress, string location)
        {
            using (webClient = new WebClient())
            {
                if (isBlue.Checked == true)
                {
                    

                    var data = webClient.DownloadString("http://api.imageresizer.io/v0.1/images?url=" + urlAddress);
                    
                    JObject jo = (JObject)JsonConvert.DeserializeObject(data);
                    string id = jo.GetValue("response").Value<string>("id");
                    urlAddress = "http://img.imageresizer.io/" + id + "/Lightbulb-moment.jpg?size=100%&blur=10";
                    

                }
               

                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);

                Uri URL = new Uri(urlAddress);
                //Console.WriteLine(urlAddress);
                try
                {
                    webClient.DownloadFileAsync(URL, location);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;

        }

        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                
            }
            else
            {
                if (isCredit.Checked == true)
                {
                    string new_destination = filePath + "/desktoper/" + textBox2.Text + "_credit" + ".jpg"; ;
                    Bitmap bit = (Bitmap)Image.FromFile(destination);
                    Graphics g = Graphics.FromImage(bit);


                    g.DrawString(txtOwnerName.Text, new Font("Segoe UI light", 20), Brushes.White, new PointF(0, 0));
                    bit.Save(new_destination);
                    Wallpaper.SetDesktopWallpaper(new_destination, SelectedWallpaperStyle);
                }
                else
                {
                   Wallpaper.SetDesktopWallpaper(destination, WallpaperStyle.Fill);
                }

                 MetroMessageBox.Show(this, textBox2.Text + " has been set as your wallpaper !", "Congratulation ! ", MessageBoxButtons.OK, MessageBoxIcon.Question);


            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
           
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private WallpaperStyle SelectedWallpaperStyle
        {
            get
            {
                if (this.wallpaperStyle.Text=="Tile")
                {
                    return WallpaperStyle.Tile;
                }
                else if (this.wallpaperStyle.Text == "Center")
                {
                    return WallpaperStyle.Center;
                }
                else if (this.wallpaperStyle.Text == "Stretch")
                {
                    return WallpaperStyle.Stretch;
                }
                else if (this.wallpaperStyle.Text == "Fit")
                {
                    return WallpaperStyle.Fit;
                }
                else
                {
                    return WallpaperStyle.Fill;
                }
            }
        }

        //End of Async Downloader
    }
}
