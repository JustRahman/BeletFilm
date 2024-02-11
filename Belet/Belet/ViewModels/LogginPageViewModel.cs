using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Belet.Model;
using Belet.Views;
using Npgsql;
using Twilio;
using Twilio.Rest.Verify.V2.Service;
using Belet.Model.Login;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Collections.ObjectModel;
using Belet.Command;
using Belet.Helper;
using Newtonsoft.Json;
using MaterialDesignThemes.Wpf;
using System.Net.Http;
using Newtonsoft.Json;
using Belet.Model.UserLog;
using System.IO;
using System.Security.Cryptography;

namespace Belet.ViewModels
{
    class LogginPageViewModel:ViewModelBase 
    { 
        public DelegateCommand toggleTheme { get; set; }

        public bool IsDarkTheme { get; set; }
        private readonly PaletteHelper paletteHelper = new PaletteHelper();

        bool wndstate = false;
        private Window _wnd;
        public Window wnd
        {
            get
            {
                return _wnd;
            }
            set
            {
                SetValue(ref _wnd, value);
            }

        }

        private LogginPasswordModel _logginpasswordmodel;
        public LogginPasswordModel logginpasswordmodel
        {
            get
            {
                return _logginpasswordmodel;
            }
            set
            {
                SetValue(ref _logginpasswordmodel, value);
            }
        }

        private ObservableCollection<JsonPersonIdClass> _JsonCollection;
        public ObservableCollection<JsonPersonIdClass> JsonCollection
        {
            get
            {
                return _JsonCollection;
            }
            set
            {
                SetValue(ref _JsonCollection,value);
            }
        }

        private JsonPersonIdClass _jsonPersonIdClasses;
        public JsonPersonIdClass jsonPersonIdClasses
        {
            get
            {
                return _jsonPersonIdClasses;
            }
            set
            {
                SetValue(ref _jsonPersonIdClasses, value);
            }
        }

        static HttpClient httpClient;

        public MyDelegateCommand InitializeCommand { get; set; }
        public DelegateCommand Logginbtn { get; set; }
        public DelegateCommand codev { get; set; }

        public MyDelegateCommand close_application { get; set; } 
        public MyDelegateCommand cmdLogin { get; set; }
        string path;
        string pathKey;
        string pathIV;


        public LogginPageViewModel()
        {
            JsonCollection = new ObservableCollection<JsonPersonIdClass>();
            logginpasswordmodel = new LogginPasswordModel();
            InitializeCommand = new MyDelegateCommand(w => InitializeCommand_cmd(w));
            Logginbtn = new DelegateCommand(()=> Logginbtn_cmd());
            codev = new DelegateCommand(()=> codev_cmd());
            close_application = new MyDelegateCommand(pep => close_application_cmd(pep)); 
            cmdLogin = new MyDelegateCommand(zid => cmdLogin_cmd(zid));

            IsDarkTheme = StaticsForTheme.IsBtnChecked;
            toggleTheme = new DelegateCommand(toggleTheme_cmd);

            logginpasswordmodel.Beletlogo = AppDomain.CurrentDomain.BaseDirectory + @"Images\\BeletLogo.png";
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:1337/api/");
            path = System.AppDomain.CurrentDomain.BaseDirectory + "config.json";
            pathKey = System.AppDomain.CurrentDomain.BaseDirectory + "configKey.json";
            pathIV = System.AppDomain.CurrentDomain.BaseDirectory + "configIV.json";

            jsonPersonIdClasses = new JsonPersonIdClass();
            logginpasswordmodel.sectextvis = "Collapsed";

            TwilioClient.Init("ACf7a585f8d20cd8c4b21b7b26469b31c2", "c3861f3aaf368dde6afa5f22f7050ce4");

        }

        private async void codev_cmd()
        {
            //var verificationCheck = VerificationCheckResource.Create(
            //      to: $"+{logginpasswordmodel.firstxt}",
            //      code: $"{logginpasswordmodel.secstxt}",
            //      pathServiceSid: "VAd0f9fb116fc1949e0e88e4bcb3ab5d10"
            //  );verificationCheck.Status
            string verificationCheck = "approved";
            if (verificationCheck == "approved")
            {
                var cs = "Host=localhost;Username=postgres;Password=123;Database=Belet";
                var con = new NpgsqlConnection(cs);
                con.Open();


                NpgsqlCommand command = new NpgsqlCommand($"SELECT * FROM public.user_logs WHERE user_phone_number LIKE '{logginpasswordmodel.firstxt}' ", con);

                HttpResponseMessage response1 = await httpClient.GetAsync($"user-logs?filters[user_phone_number][$contains]={(logginpasswordmodel.firstxt).Substring(1, logginpasswordmodel.firstxt.Length - 1)}");
                string str1 = response1.Content.ReadAsStringAsync().Result;
                //Media media1 = JsonConvert.DeserializeObject<Media>(str1);
                Login mediaObject = JsonConvert.DeserializeObject<Login>(str1);

                NpgsqlDataReader rdr = command.ExecuteReader();
                while (rdr.Read())
                {
                    jsonPersonIdClasses.PersonId = Convert.ToInt32(mediaObject.Data[0].Id);
                    jsonPersonIdClasses.PersonPhoneNumber = $"{(logginpasswordmodel.firstxt).Substring(1, logginpasswordmodel.firstxt.Length - 1)}";
                    if (Convert.ToString(rdr[0]) != "0")
                    {
                        StaticsForTheme.PersonPhoneNumber = $"{logginpasswordmodel.firstxt}";
                        StaticsForTheme.UserLogid = Convert.ToInt32(mediaObject.Data[0].Id);
                        logginpasswordmodel.firstxt = "Login complete successfully";
                    }
                    else
                    {
                        using (var client = new HttpClient())
                        {
                            var endpoint = new Uri("http://localhost:1337/api/user-logs");
                            var newPost = new Data()
                            {
                                user_phone_number = $"+{logginpasswordmodel.firstxt}"
                            };
                            var newPostJson2 = new PostJson()
                            {
                                data = newPost
                            };
                            var newPostJson = JsonConvert.SerializeObject(newPostJson2);
                            var payload = new StringContent(newPostJson, Encoding.UTF8, "application/json");
                            var result = client.PostAsync(endpoint, payload).Result.Content.ReadAsStringAsync().Result;
                            StaticsForTheme.PersonPhoneNumber = $"{(logginpasswordmodel.firstxt).Substring(1, logginpasswordmodel.firstxt.Length - 1)}";
                            StaticsForTheme.UserLogid = Convert.ToInt32(mediaObject.Data[0].Id);
                            logginpasswordmodel.firstxt = "Login complete successfully";



                        }
                    }
                }

                JsonCollection.Add(jsonPersonIdClasses);
                var model1 = JsonConvert.SerializeObject(JsonCollection);

                try
                {

                    

                    // Create a new instance of the RijndaelManaged
                    // class.  This generates a new key and initialization
                    // vector (IV).
                    using (RijndaelManaged myRijndael = new RijndaelManaged())
                    {
                        myRijndael.GenerateKey();
                        myRijndael.GenerateIV();


                        // Encrypt the string to an array of bytes.
                        byte[] encrypted = EncryptStringToBytes(model1, myRijndael.Key, myRijndael.IV);

                        

                        using (StreamWriter streamWriter = new StreamWriter(path, false))
                        {
                            streamWriter.Flush();
                            foreach (var item in encrypted)
                            {
                                streamWriter.WriteLine(item);
                            }
                            
                        }

                        using (StreamWriter streamWriter = new StreamWriter(pathKey, false))
                        {
                            streamWriter.Flush();
                            foreach (var item in myRijndael.Key)
                            {
                                streamWriter.WriteLine(item);
                            }

                        }

                        using (StreamWriter streamWriter = new StreamWriter(pathIV, false))
                        {
                            streamWriter.Flush();
                            foreach (var item in myRijndael.IV)
                            {
                                streamWriter.WriteLine(item);
                            }

                        }




                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: {0}", e.Message);
                }

                

                

                con.Close();



                Views.ChoosePage choosePage = new Views.ChoosePage();
                wnd.Close();
                choosePage.ShowDialog();
            }
            else
            {
                MessageBox.Show("Try type code again");
            }
        }


        static byte[] EncryptStringToBytes(string plainText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");
            byte[] encrypted;
            // Create an RijndaelManaged object
            // with the specified key and IV.
            using (RijndaelManaged rijAlg = new RijndaelManaged())
            {
                rijAlg.Key = Key;
                rijAlg.IV = IV;

                // Create an encryptor to perform the stream transform.
                ICryptoTransform encryptor = rijAlg.CreateEncryptor(rijAlg.Key, rijAlg.IV);

                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {

                            //Write all data to the stream.
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }

            // Return the encrypted bytes from the memory stream.
            return encrypted;
        }

        static string DecryptStringFromBytes(byte[] cipherText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");

            // Declare the string used to hold
            // the decrypted text.
            string plaintext = null;

            // Create an RijndaelManaged object
            // with the specified key and IV.
            using (RijndaelManaged rijAlg = new RijndaelManaged())
            {
                rijAlg.Key = Key;
                rijAlg.IV = IV;

                // Create a decryptor to perform the stream transform.
                ICryptoTransform decryptor = rijAlg.CreateDecryptor(rijAlg.Key, rijAlg.IV);

                // Create the streams used for decryption.
                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            // Read the decrypted bytes from the decrypting stream
                            // and place them in a string.
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }

            return plaintext;
        }



        private void toggleTheme_cmd()
        {
            ITheme theme = paletteHelper.GetTheme();

            if (IsDarkTheme = theme.GetBaseTheme() == BaseTheme.Dark)
            {
                IsDarkTheme = false;
                theme.SetBaseTheme(Theme.Light); 
                StaticsForTheme.IsBtnChecked = IsDarkTheme;

            }
            else
            {
                IsDarkTheme = true;
                theme.SetBaseTheme(Theme.Dark); 
                StaticsForTheme.IsBtnChecked = IsDarkTheme;

            }
            paletteHelper.SetTheme(theme);
        }
        private void cmdLogin_cmd(object zid)
        {
            wnd.WindowState = WindowState.Minimized;
        }


        
        

        private void close_application_cmd(object pep)
        {
           
        }

    
        private async void Logginbtn_cmd()
        {
            if (logginpasswordmodel.checker == true)
            {




                //var verification = VerificationResource.Create(
                //    to: $"{logginpasswordmodel.firstxt}",
                //    channel: "sms",
                //    pathServiceSid: "VAd0f9fb116fc1949e0e88e4bcb3ab5d10"
                //);

                logginpasswordmodel.sectextvis = "Visible";

                //if (verification.Status == "pending" || verification.Status == "approved")
                //{
                    
                //}
                //else
                //{
                //    MessageBox.Show("Try again after some time");
                //}


                

                
               
                
            }
            else if (logginpasswordmodel.checker == false)
            {
                MessageBox.Show("Please, accept our term and conditions!");
            }
         
        }
        
        private void InitializeCommand_cmd(object o)
        {
            object[] wind = o as object[];
            wnd = (Window)wind[0];
            logginpasswordmodel.checker = false;
            if (File.Exists(path))
            {
                Views.ChoosePage choosePage = new Views.ChoosePage();
                wnd.Close();
                choosePage.ShowDialog();
            }





        }

    }
}
