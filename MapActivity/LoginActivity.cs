using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace MapActivity
{
    [Activity(Label = "login")]
    public class LoginActivity : Activity
    {
        Button btnsignup;
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);


            //back to login page//

            btnsignup = FindViewById<Button>(Resource.Id.btnsignup);

            btnsignup.Click += (Sender, e) =>
            {
                Intent RegisterActivityIntent = new Intent(this, typeof(RegisterActivity));
             
                StartActivity(RegisterActivityIntent);

            };



            btnLogin.Click += async delegate
            {
                var request = HttpWebRequest.Create(string.Format(@"https://10.0.2.2:5001/api/Users"));
                //http://172.31.99.148:5000/api/Users
                request.ContentType = "application/json";
                request.Method = "GET";
                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                        Console.Out.WriteLine("Error fetching data. Server returned status code: {0}", response.StatusCode);
                    using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                    {
                        var content = reader.ReadToEnd();
                        if (string.IsNullOrWhiteSpace(content))
                        {
                            Console.Out.WriteLine("Response contained empty body...");
                        }
                        else
                        {
                            var userList = JsonConvert.DeserializeObject<List<User>>(content);
                            Console.Out.WriteLine("Response Body: \r\n {0}", content);

                        }
                    }
                }
            };
        }

        private T FindViewById<T>(object edfirstname)
        {
            throw new NotImplementedException();
        }
    }
}