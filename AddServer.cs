using System;
using Newtonsoft.Json;
using System.Net.Http;
using System.Windows.Forms;

namespace ServerTap_GUI
{
    public partial class AddServer : Form
    {
        public AddServer()
        {
            InitializeComponent();
        }

        private void ServerNameBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ServerIPBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ServerTapPortBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ServerTapKeyBox_TextChanged(object sender, EventArgs e)
        {

        }
        bool success;
        private void TestConnectionButton_Click(object sender, EventArgs e)
            {
            //make sure the boxes are filled out
            if (ServerNameBox.Text == "" || ServerIPBox.Text == "" || ServerTapPortBox.Text == "" || ServerTapKeyBox.Text == "")
            {
                MessageBox.Show("Please fill out all fields");
                return;
            } else
            {
                //make a request to the server with the data provided and key is a header
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://" + ServerIPBox.Text + ":" + ServerTapPortBox.Text + "/v1/");
                client.DefaultRequestHeaders.Add("key", ServerTapKeyBox.Text);
                //make a request to the BaseAddress + /ping
                HttpResponseMessage response = client.GetAsync("ping").Result;
                //show the json response in a message box
                if (response.IsSuccessStatusCode)
                {
                    //Check to see if the reply is "pong"
                    string json = response.Content.ReadAsStringAsync().Result;
                    if (json == "\"pong\"")
                    {
                        MessageBox.Show("Connection Successful");
                        success = true;
                    }
                } else
                {
                    success = false;
                    MessageBox.Show("Error: " + response.Content.ReadAsStringAsync().Result);
                    return;
                }
                
            }
        }

        private void AddServerButton_Click(object sender, EventArgs e)
        {
            if (success != true)
            {
                MessageBox.Show("Failed to add server \nPlease check the info and try again");
                return;
                }
            else MessageBox.Show("Server Saved");
            //save info to json file unsing newtonsoft.json
            string data = JsonConvert.SerializeObject(new
            {
                ServerName = ServerNameBox.Text,
                ServerIP = ServerIPBox.Text,
                ServerTapPort = ServerTapPortBox.Text,
                ServerTapKey = ServerTapKeyBox.Text
            });
            System.IO.File.WriteAllText(@"Server.json", data);
            //open the panel form and close this form
            this.Hide();
            panel panel = new panel();
            panel.ShowDialog();
            this.Close();

        }
    }
}
