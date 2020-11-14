using CrewNode.Launcher.API.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Windows.Forms;

namespace CrewNode.Launcher.API
{
    class Base
    {
        private string data;
        private int code;

        public Base queryApi(string endpoint)
        {
            WebClient client = new WebClient();
            try
            {
                string rawData = client.DownloadString("https://crewnode.net/api" + endpoint);
                this.data = rawData;
                this.code = 200;
                return this;
            }
            catch (WebException wex)
            {
                HttpWebResponse response = wex.Response as HttpWebResponse;
                using (Stream responseStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                    string rawData = reader.ReadToEnd();

                    switch (response.StatusCode)
                    {
                        case HttpStatusCode.NotFound:
                        case HttpStatusCode.Forbidden:
                        case HttpStatusCode.BadRequest:
                            this.data = rawData;
                            this.code = (int)response.StatusCode;
                            return this.ToError();
                        default:
                            throw wex as Exception;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
                return null;
            }
        }

        public int GetCode()
        {
            return this.code;
        }

        public Error ToError()
        {
            Error errObj = JsonConvert.DeserializeObject<Error>(this.data);
            errObj._code = this.code;
            return errObj;
        }

        public UserAuth ToUserAuth()
        {
            UserAuth userAuthObj = JsonConvert.DeserializeObject<UserAuth>(this.data);
            userAuthObj._code = 200;
            return userAuthObj;
        }

    }
}
