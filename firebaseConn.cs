using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPA_Calculator
{
    public class firebaseConn
    {
        IFirebaseConfig conn;
        IFirebaseClient client;

        public void startConn()
        {
            conn = new FirebaseConfig()
            {
                AuthSecret = "Vx1GMpcIr7wmlNvDZmclpJf6c1HkiK5KLkgqQ9WX",
                BasePath = "https://gpa-calculator-ea6d4-default-rtdb.firebaseio.com/",

            };
            try
            {
                client = new FireSharp.FirebaseClient(conn);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        public void insertData(String pk, resultData rd)
        {
            var setter = client.Set("results/" + pk, rd);
            MessageBox.Show("Data add successfully");
        }

        public Dictionary<string, resultData> exportData()
        {
            

            FirebaseResponse res = client.Get(@"results");
            Console.WriteLine(res.ToString());
            Dictionary<string, resultData> data = JsonConvert.DeserializeObject<Dictionary<string, resultData>>(res.Body.ToString());
   
            return data;
        }

    }
}
