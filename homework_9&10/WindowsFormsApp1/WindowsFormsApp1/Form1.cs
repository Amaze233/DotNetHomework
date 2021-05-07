using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example9_2
{
    public delegate void CraewlerHanlder(string obj);

    public partial class Form_crawler : Form
    {
        Crawler crawler = new Crawler();
        
        public Form_crawler()
        {
            InitializeComponent();
            crawler.PageDownloaded += Crawler_PageDownloaded;
        }

        public void Crawler_PageDownloaded(string obj)
        {
            if (listBox_URL.InvokeRequired)
            {
                Action<string> action = AddUrl;
                Invoke(action, new object[] { obj });
            }
            else
            {
                listBox_URL.Items.Add(obj);
            }
        }

        private void AddUrl(string url)
        {
            listBox_URL.Items.Add(url);
        }

        private void button_Crawl_Click(object sender, EventArgs e)
        {
            crawler.StartURL = txtURL.Text;
            int limit;
            try
            {
                limit = int.Parse(txtLimit.Text);
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
                return;
            }
            catch (ArgumentNullException ane)
            {
                MessageBox.Show(ane.Message);
                return;
            }
            crawler.Limit = limit;
            listBox_URL.Items.Clear();
            new Thread(crawler.Start).Start();
        }

        private void txtURL_TextChanged(object sender, EventArgs e)
        {

        }
    }

    class Crawler
    {
        private Hashtable urls;
        public int Limit { get; set; }
        private int count = 0;
        public string StartURL { get; set; }
        public event CraewlerHanlder PageDownloaded;

        public void Start()
        {
            urls = new Hashtable
            {
                { StartURL, false }
            };
            while (true)
            {
                string current = null;
                foreach (string url in urls.Keys)
                {
                    if ((bool)urls[url])
                    {
                        continue;
                    }
                    current = url;
                    break;
                }
                if (current == null || count > Limit)
                {
                    break;
                }
                string html = DownLoad(current);
                urls[current] = true;
                if(!Regex.IsMatch(html, "<!DOCTYPE html>"))
                {
                    continue;
                }
                PageDownloaded(current);
                count++;
                Parse(current, html);
            }
            return;
        }

        public string DownLoad(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                return html;
            }
            catch (Exception ex)
            {
                MessageBox.Show(url + "" + ex.Message);
                return "";
            }
        }

        private void Parse(string current, string html)
        {
            string curmatch = @"^http[s]?://[\w]+.[^.]*.[^/]+";
            MatchCollection curmatches = new Regex(curmatch).Matches(current);
            string curstr = curmatches[0].Value;

            string leagle = new Regex(@"[//][^.]+[.][^.]+[.]").Matches(curstr)[0].Value;
            

            string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1).Trim('"', '\"', '#', '>');
                
                if (strRef.Length == 0)
                {
                    continue;
                }
                if (strRef[0] == '/')
                {
                    strRef = strRef.Insert(0, curstr);
                }
                if (strRef[0] != '/' && strRef.Substring(0, 4) != "http")
                {
                    strRef = strRef.Insert(0, current + "/");
                }
                if (!Regex.IsMatch(strRef, leagle))
                {
                    continue;
                }
                if (urls[strRef] == null)
                {
                    urls[strRef] = false;
                }
            }
        }
    }
}
