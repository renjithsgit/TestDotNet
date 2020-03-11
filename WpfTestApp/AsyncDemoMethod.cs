using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace WpfTestApp
{
    class AsyncDemoMethod
    {
        
        public static List<WebsiteDataModel> RunDownloadSync()
        {
            List<string> websites = PrepData();
            List<WebsiteDataModel> results = new List<WebsiteDataModel>();

            foreach (var item in websites)
            {
                var output = DownloadWebsite(item);
                results.Add(output);
            }

            return results;
        }
        public static async Task<List<WebsiteDataModel>> RunDownloadAsyncParallelForWithCancel(IProgress<ProgressReportModel> progress, CancellationToken cancellationToken)
        {
            List<string> websites = PrepData();
            List<WebsiteDataModel> results = new List<WebsiteDataModel>();
            ProgressReportModel report = new ProgressReportModel();


            await Task.Run(() =>
            {

                Parallel.ForEach<string>(websites, (url) =>
                        {
                            try
                            {
                                var output = DownloadWebsiteAsync(url);
                                results.Add(output.Result);

                                cancellationToken.ThrowIfCancellationRequested();

                                report.percentage = (results.Count * 100) / websites.Count;
                                report.WebSitesDownlaoded = results;
                                progress.Report(report);
                            }
                            catch (Exception ex)
                            {

                                throw ex;
                            }
                        });

            });
            



            return results;
        }

        public static async Task<List<WebsiteDataModel>> RunDownloadAsyncParallelFor(IProgress<ProgressReportModel> progress)
        {
            List<string> websites = PrepData();
            List<WebsiteDataModel> results = new List<WebsiteDataModel>();
            ProgressReportModel report = new ProgressReportModel();

            await Task.Run(() => 
            {
                Parallel.ForEach<string>(websites, (url) => {
                    var output = DownloadWebsiteAsync(url);
                    results.Add(output.Result);


                    report.percentage = (results.Count * 100) / websites.Count;
                    report.WebSitesDownlaoded = results;
                    progress.Report(report);
                });
            });
           
            

            return results;
        }
        public static async Task<List<WebsiteDataModel>> RunDownloadAsync(IProgress<ProgressReportModel> progress)
        {
            List<string> websites = PrepData();
            List<WebsiteDataModel> results = new List<WebsiteDataModel>();
            ProgressReportModel report = new ProgressReportModel();
            foreach (var item in websites)
            {
                var output = await DownloadWebsiteAsync(item);
                results.Add(output);


                report.percentage = (results.Count * 100 ) / websites.Count;
                report.WebSitesDownlaoded = results;
                progress.Report(report);


            }

            return results;
        }

        public static async Task<List<WebsiteDataModel>> RunDownloadASyncUsingWebclientAsync()
        {
            List<string> websites = PrepData();
            List<Task<WebsiteDataModel>> tasks = new List<Task<WebsiteDataModel>>();
            
            foreach (var item in websites)
            {
                tasks.Add(Task.Run(() => DownloadWebsiteAsync(item)));

             }

            var res = await Task.WhenAll(tasks);

            return res.ToList();
        }

       

        public static async Task<List<WebsiteDataModel>> RunDownloadASyncWithOutUsingWeclientAsync()
        {
            List<string> websites = PrepData();
            
            List<Task<WebsiteDataModel>> tasks = new List<Task<WebsiteDataModel>>();

            foreach (var item in websites)
            {
                tasks.Add(Task.Run(()=> DownloadWebsite(item)));
                
            }

            var res = await Task.WhenAll(tasks);
           
            return new List<WebsiteDataModel>(res) ;
        }

        private static async Task<WebsiteDataModel> DownloadWebsiteAsync(string address)
        {
            //System.Threading.Thread.Sleep(1000);
            WebClient client = new WebClient();
            WebsiteDataModel data = new WebsiteDataModel();
            data.WebsiteData = await client.DownloadStringTaskAsync(address);
            data.Length = data.WebsiteData.Length;
            data.WebSiteURL = address;
            return data;
        }

        private static WebsiteDataModel DownloadWebsite(string address)
        {
           // System.Threading.Thread.Sleep(1000);
            WebClient client = new WebClient();
            WebsiteDataModel data = new WebsiteDataModel();
            data.WebsiteData = client.DownloadString(address);
            data.Length = data.WebsiteData.Length;
            data.WebSiteURL = address;
            return data;
        }
        private static List<string> PrepData()
        {
            List<string> web = new List<string>();
            web.Add("https://www.google.com");
            web.Add("https://www.msn.com");
            web.Add("https://www.microsoft.com");
            web.Add("https://www.amazon.com");
            web.Add("https://www.yahoo.com");
            return web;
        }
    }
}
