using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TidsregistreringCC
{
    public partial class Form1 : Form
    {
        static int currentRow = 0;
        public static void SetCurrentRow(int CR)
        {
            currentRow = CR;
        }

        public static int GetCurrentRow()
        {
            return currentRow;
        }

        public Form1()
        {
            InitializeComponent();

            button1.Click += new EventHandler(this.GreetingBtn_Click);
           
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void GreetingBtn_Click(Object sender, EventArgs e)
        {
            R(this.richTextBox1.Text, this.richTextBox2.Text, this.monthCalendar1.SelectionRange.Start.ToShortDateString(), this.richTextBox3.Text, this.richTextBox4.Text,this.antalTB.Text,this.fraTimer.Text,this.tilTimer.Text,this.cbTB.Checked,this.cbTimer.Checked);
        }

        // If modifying these scopes, delete your previously saved credentials
        // at ~/.credentials/sheets.googleapis.com-dotnet-quickstart.json
        static string[] Scopes = { SheetsService.Scope.Spreadsheets };
        static string ApplicationName = "Sheet Update";
        static string SheetId = "1oHUNt1hFAR8x36Ks-jC35rTvAikcpy4ofixobJIjW-E";

        static void R(string t1,string t2, string t3, string t4, string t5,string antalTB,string fraTimer,string tilTimer,bool cbTB,bool cbTimer)
        {
            var service = AuthorizeGoogleApp();
            
            string newRange = GetRange(service);

            IList<IList<Object>> objNeRecords = GenerateData(t1,t2,t3,t4,t5,antalTB,fraTimer,tilTimer,cbTB,cbTimer);

            UpdatGoogleSheetinBatch(objNeRecords, SheetId, newRange, service);

            Console.WriteLine("Inserted");
            Console.Read();
        }

        private static SheetsService AuthorizeGoogleApp()
        {
            UserCredential credential;

            using (var stream =
                new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = System.Environment.GetFolderPath(
                    System.Environment.SpecialFolder.Personal);
                credPath = Path.Combine(credPath, ".credentials/sheets.googleapis.com-dotnet-quickstart.json");

                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "Poll3XD",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                Console.WriteLine("Credential file saved to: " + credPath);
            }

            // Create Google Sheets API service.
            var service = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            return service;
        }

        static string GetRange(SheetsService service)
        {
            // Define request parameters.
            String spreadsheetId = SheetId;
            String range = "A:A";

            SpreadsheetsResource.ValuesResource.GetRequest getRequest =
                       service.Spreadsheets.Values.Get(spreadsheetId, range);

            ValueRange getResponse = getRequest.Execute();
            IList<IList<Object>> getValues = getResponse.Values;

            int currentCount = getValues.Count()+1;

            SetCurrentRow(currentCount);

            String newRange = "A" + currentCount + ":A";

            return newRange;
        }

        private static IList<IList<Object>> GenerateData(string t1, string t2, string t3, string t4, string t5,string antalTB, string fraTimer, string tilTimer,bool cbTB, bool cbTimer)
        {
            List<IList<Object>> objNewRecords = new List<IList<Object>>();

            IList<Object> obj = new List<Object>();

            

            obj.Add(t1);
            obj.Add(t2);
            obj.Add(t3);
            obj.Add(t4);
            if (cbTB)
            {
                obj.Add(antalTB);
                obj.Add("");
                obj.Add("");
                obj.Add(0);
            }
            else
            {
                obj.Add("");
                obj.Add("00.00");
                obj.Add(tilTimer);

                string[] sfraTimer = fraTimer.Split('.');
                string[] stilTimer = tilTimer.Split('.');

                int hours = Int32.Parse(stilTimer[0]) - Int32.Parse(sfraTimer[0]);
                int mins = Int32.Parse(stilTimer[1]) - Int32.Parse(sfraTimer[1]);

                //int sum;

                obj.Add(hours+"."+mins);
            }
            obj.Add(t5);

            objNewRecords.Add(obj);

            return objNewRecords;
        }

        private static void UpdatGoogleSheetinBatch(IList<IList<Object>> values, string spreadsheetId, string newRange, SheetsService service)
        {
            SpreadsheetsResource.ValuesResource.AppendRequest request =
               service.Spreadsheets.Values.Append(new ValueRange() { Values = values }, spreadsheetId, newRange);
            request.InsertDataOption = SpreadsheetsResource.ValuesResource.AppendRequest.InsertDataOptionEnum.INSERTROWS;
            request.ValueInputOption = SpreadsheetsResource.ValuesResource.AppendRequest.ValueInputOptionEnum.USERENTERED;
            Console.WriteLine(newRange);
            var response = request.Execute();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
