using System.Net;
using System.Text;
using System.Web;

namespace LINENotify
{
    class Program
    {
        static void Main(string[] args)
        {
            var token = "取得したトークン";
            var url = "https://notify-api.line.me/api/notify";
            var enc = Encoding.UTF8;
            var payload = "message=" + HttpUtility.UrlEncode("こんにちは!", enc);
            using (var wc = new WebClient())
            {
                wc.Encoding = enc;
                wc.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
                wc.Headers.Add("Authorization", "Bearer " + token);
                var response = wc.UploadString(url, payload);
            }
        }
    }
}
