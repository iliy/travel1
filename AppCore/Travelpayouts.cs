using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AppCore
{
    public class Travelpayouts
    {
        private string token = "50e90b3a30d1fa629d5fa72d0e291a23";
        private string marker = "148909";

        public Travelpayouts() { }

        public string getPrice()
        {
            string url = 
                "http://api.travelpayouts.com/v2/prices/latest?currency=rub&" + 
                "period_type=year&page=1&limit=30&show_to_affiliates=true&sorting=price&trip_class=0&token=" + this.token;

            var request = WebRequest.Create(url);
            string text;
            var response = (HttpWebResponse)request.GetResponse();

            request.ContentType = "application/json; charset=utf-8";

            using (var sr = new StreamReader(response.GetResponseStream()))
            {
                text = sr.ReadToEnd();
            }
            
            return text;
        }
    }
}
