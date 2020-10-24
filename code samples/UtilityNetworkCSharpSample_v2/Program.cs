using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNamespace
{
    public class Program
    {
    
        //REQUIRED - Portal information
        private static readonly string s_portalUserName = "myuser";
        private static readonly string s_portalPssword = "mypassword";
        private static readonly string s_portalMachine = "https://myportal.com";
        private static readonly string s_portalWebAdaptorName = "portal";
        private static readonly string s_serverWebAdaptorName = "server";

        //REQUIRED - Starting point. Find an edge's global ID in your data then update GlobalID below, change percent if desired.
        private static readonly TraceLocation s_traceLocation = new TraceLocation
        {
            TraceLocationType = TraceLocationType.StartingPoint,
            PercentAlong = 0.5,
            GlobalId = "{E87BDA91-01AB-409B-A8AD-4199EE702F22}"
        };

        //REQUIRED - A valid Utility Network service name
        private static readonly string s_utilityNetworkName = "My_Utility_Network_Feature_Service_Name";

        // NOT REQUIRED - Header, version information. Change if you want.
        private static readonly int s_tokenTimeout = 90;
        private static readonly string s_myIP = "127.0.0.1";
        private static readonly string s_formatParam = "json";
        private static readonly string s_versionSDE = "SDE.DEFAULT";
        private static readonly string s_myReferrer = "http:\\mywebsite.com";

        // NOT REQUIRED - Trace type, defaulting to connected (recommend for first run)
        private static readonly BodyTraceType s_traceType = BodyTraceType.Connected;

        public static void Main(string[] args)
        {

            Client client = new Client(new System.Net.Http.HttpClient());
            client.BaseUrl = s_portalMachine;

            Task<TokenResponse> tokenTask = Task.Run(() => GenerateTokenAsync(client));
            tokenTask.Wait();

            TokenResponse tr = tokenTask.Result;
            if (tr.Token == null)
            {

                if ((tr.Error != null) && (tr.Error.Code != 0)) {
                    Console.WriteLine("Error(s) retreiving token:");
                }
                else {
                    Console.WriteLine("Error - no details could be retreived. Sorry!");
                }
            }
            else
            {
                Console.WriteLine("Token received");
                Console.WriteLine(tr.Token);
            }


            Task<TraceResultsSet> traceResults = Task.Run(() => TraceAsync(client, tr.Token));
            traceResults.Wait();


            TraceResultsSet traceResultSet = traceResults.Result;
            Console.WriteLine("Trace : OK");

            
            Task <UpdateIsConnectedResponse> connectedResponse  = Task.Run(() => UpdateIsConnectedAsync(client, tr.Token));
            connectedResponse.Wait();

            UpdateIsConnectedResponse connectTaskResponse = connectedResponse.Result;
            if (connectedResponse.Result.Error != null) {
                Console.WriteLine("Error(s) UpdateIsConnected:");
                Console.WriteLine(connectTaskResponse.Error.Message);
            }
            else {
                Console.WriteLine("UpdateIsConnected : OK");
            }

            Console.ReadKey();
            return;
        }

        private static async Task<TokenResponse> GenerateTokenAsync(Client c)
        {

        Body2 body = new Body2();
            body.Expiration = s_tokenTimeout;
            body.F = s_formatParam;
            body.Ip = s_myIP;
            body.Referer = s_myReferrer;
            body.Password = s_portalPssword;
            body.Username = s_portalUserName;

            Task<TokenResponse> tokenResponse = c.GenerateTokenAsync(s_portalWebAdaptorName, body);
            return await tokenResponse;
        }

        private static async Task<UpdateIsConnectedResponse> UpdateIsConnectedAsync(Client c, string token)
        {
            Task<UpdateIsConnectedResponse> connectedResponse = c.UpdateIsConnectedAsync(s_serverWebAdaptorName, s_utilityNetworkName, s_formatParam, token);
            return await connectedResponse;
        }

        private static async Task<TraceResultsSet> TraceAsync(Client c, string token)
        {
            TraceConfiguration traceConfiguration = new TraceConfiguration();
            List<TraceLocation> tlList = new List<TraceLocation>();
            tlList.Add(s_traceLocation);      
            string traceLocationList = JsonConvert.SerializeObject(tlList);

            Body body = new Body();
            body.F = s_formatParam;
            body.GdbVersion = s_versionSDE;
            body.TraceConfiguration = JsonConvert.SerializeObject(traceConfiguration);
            body.TraceLocations = tlList.ConvertAll<object>(item => (object)item).ToArray();
            body.TraceType = s_traceType;

            var result = c.TraceAsync(s_serverWebAdaptorName, s_utilityNetworkName, token, body);

            return await result;
        }

    }
}