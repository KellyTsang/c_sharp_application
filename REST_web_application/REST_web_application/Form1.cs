/*Created by Kelly Tsang*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace REST_web_application
{
    public enum httpVerb
    {
        GET,
        POST,

    }

    public enum authenticationType
    {
        Basic,
        NTLM
    }


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbReply.Clear();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(tbReply.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbWeb.SelectedIndex = 0;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (tbURL.Text == null || tbPostJSON.Text == null||string.IsNullOrEmpty(tbURL.Text)||string.IsNullOrEmpty(tbPostJSON.Text))
            {
                MessageBox.Show("Please enter the URL and the JSON string!");
                return;

            }

            RestClient rClient = new RestClient();
            rClient.endPoint = tbURL.Text;
            switch (cbWeb.Text)
            {
                case "POST":
                    rClient.httpMethod = httpVerb.POST;
                    rClient.postJSON = tbPostJSON.Text;
                    break;
                default:
                    rClient.httpMethod = httpVerb.GET;
                    break;
            }
            rClient.userName = tbUserName.Text;
            rClient.userPassword = tbPwd.Text;
            string strResponse = string.Empty;
            strResponse = rClient.makeRequest();
            tbReply.Text = strResponse;
        }
    }
    class RestClient
    {
        public string endPoint { get; set; }
        public httpVerb httpMethod { get; set; }
        public authenticationType authType { get; set; }
        public string userName { get; set; }
        public string userPassword { get; set; }
        public string postJSON { get; set; } //New Attribute

        public RestClient()
        {
            endPoint = string.Empty;
        }

        public string makeRequest()
        {
            string strResponseValue = string.Empty;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endPoint);
            request.Method = httpMethod.ToString();

            String authHeaer = System.Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes(userName + ":" + userPassword));
            request.Headers.Add("Authorization", "Basic " + authHeaer);


            //*********  SUPPORT POSTING *********
            if (request.Method == "POST" && postJSON != string.Empty)
            {
                request.ContentType = "application/json"; //Really Important
                using (StreamWriter swJSONPayload = new StreamWriter(request.GetRequestStream()))
                {
                    swJSONPayload.Write(postJSON);
                    swJSONPayload.Close();
                }
            }

            HttpWebResponse response = null;

            try
            {
                response = (HttpWebResponse)request.GetResponse();
                //Proecess the resppnse stream... (could be JSON, XML or HTML etc..._
                using (Stream responseStream = response.GetResponseStream())
                {
                    if (responseStream != null)
                    {
                        using (StreamReader reader = new StreamReader(responseStream))
                        {
                            strResponseValue = reader.ReadToEnd();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                strResponseValue = "{\"errorMessages\":[\"" + ex.Message.ToString() + "\"],\"errors\":{}}";
            }
            finally
            {
                if (response != null)
                {
                    ((IDisposable)response).Dispose();
                }
            }
            return strResponseValue;
        }//End of makeRequest
    }
}
