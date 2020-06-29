using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace BAC_Note
{
    public class HtmlCodeChangeNotify
    {
        private string webPageSite;
        private string initialWebPageHtmlCode;
        private Timer tmr_Check = new Timer() { Enabled = true, Interval = 1000 * 10 };
        private Action callbackFunc;
        private Action callbackCount;


        public HtmlCodeChangeNotify(string _webPageSite, Action function, int interval, Action countFunct) : this(_webPageSite, function)
        {
            callbackCount = countFunct;
            tmr_Check.Interval = interval;
        }
        public HtmlCodeChangeNotify(string _webPageSite, Action function) : this()
        {
            initialWebPageHtmlCode = GetHtmlCode(_webPageSite);
            webPageSite = _webPageSite;
            callbackFunc = function;
        }
        private HtmlCodeChangeNotify()
        {
            tmr_Check.Tick += Tmr_Check_Tick;
        }


        private string GetHtmlCode(string webPageSite)
        {
            using (WebClient client = new WebClient())
            {
                return client.DownloadString(webPageSite);
            }
        }


        private void Tmr_Check_Tick(object sender, EventArgs e)
        {
            string currentWebPageHtmlCode = GetHtmlCode(webPageSite);

            if (initialWebPageHtmlCode.CompareTo(currentWebPageHtmlCode) != 0)
            {
                tmr_Check.Stop();
                callbackFunc.Invoke();
            }
            else
            {
                callbackCount.Invoke();
            }
        }


        public void TimerStop()
        {
            tmr_Check.Stop();
        }
        public void TimerStart()
        {
            tmr_Check.Start();
        }
    }
}
