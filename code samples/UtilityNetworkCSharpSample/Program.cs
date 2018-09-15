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
        private static readonly string s_portalUserName = "USER_NAME";
        private static readonly string s_portalPssword = "PASSWORD";
        private static readonly string s_portalMachine = "https://portalMachine.neat.com";
        private static readonly string s_portalWebAdaptorName = "portal";
        private static readonly string s_serverWebAdaptorName = "server";

        //REQUIRED - Starting point. Find an edge's global ID in your data then update GlobalID below, change percent if desired.
        private static readonly TraceLocation s_traceLocation = new TraceLocation
        {
            TraceLocationType = TraceLocationType.StartingPoint,
            PercentAlong = 0.5,
            GlobalId = "{00000000-0000-0000-0000-0000000000}"
        };

        //REQUIRED - A valid Utility Network service name
        private static readonly string s_utilityNetworkName = "Electric_Combined_Utility_Network";

        // NOT REQUIRED - Header, version information. Change if you want.
        private static readonly int s_tokenTimeout = 90;
        private static readonly string s_myIP = "127.0.0.1";
        private static readonly string s_formatParam = "json";
        private static readonly string s_versioSDE = "SDE.DEFAULT";
        private static readonly string s_myReferrer = "http:\\argis.com";

        // NOT REQUIRED - Trace type, defaulting to connected (recommend for first run)
        private static readonly TraceType s_traceType = TraceType.Connected;
       
        public static void Main(string[] args)
        {

            Client client = new Client();
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

            Task<TokenResponse> tokenResponse = c.GenerateTokenAsync(s_portalUserName,s_portalPssword, s_myIP, s_myReferrer, s_tokenTimeout, s_formatParam, s_portalWebAdaptorName);
            return await tokenResponse;

        }

        private static async Task<UpdateIsConnectedResponse> UpdateIsConnectedAsync(Client c, string token)
        {

            Task<UpdateIsConnectedResponse> connectedResponse = c.UpdateIsConnectedAsync(s_formatParam, token, s_serverWebAdaptorName, s_utilityNetworkName);
            return await connectedResponse;

        }

        private static async Task<TraceResultsSet> TraceAsync(Client c, string token)
        {

            TraceConfiguration traceConfiguration = new TraceConfiguration();
            List<TraceLocation> tlList = new List<TraceLocation>();
            tlList.Add(s_traceLocation);        

            string traceLocationList = JsonConvert.SerializeObject(tlList);
            var result = c.TraceAsync(token,s_formatParam, s_versioSDE, "","", s_traceType, traceLocationList, traceConfiguration.ToJson(),s_serverWebAdaptorName,s_utilityNetworkName);

            return await result;
        }

    }
}