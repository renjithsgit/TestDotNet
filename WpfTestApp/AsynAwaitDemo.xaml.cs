using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfTestApp
{
    /// <summary>
    /// Interaction logic for AsynAwaitDemo.xaml
    /// </summary>
    public partial class AsynAwaitDemo : Window
    {
        CancellationTokenSource cts = new CancellationTokenSource();
        public AsynAwaitDemo()
        {
            InitializeComponent();
        }

        private void btnNormal_Click(object sender, RoutedEventArgs e)
        {
            resultWindow.Text = "";
            var watch = System.Diagnostics.Stopwatch.StartNew();

            List<WebsiteDataModel> results = AsyncDemoMethod.RunDownloadSync();

            watch.Stop();
            var ms = watch.ElapsedMilliseconds;

            PrintResults(results);
            resultWindow.Text += $" Toatal execution time: {ms}. {Environment.NewLine} ";

        }
        private void PrintResults(List<WebsiteDataModel> results)
        {
            resultWindow.Text = "";
            foreach (var item in results)
            {
                resultWindow.Text += $" Website downloaded: {item.WebSiteURL} length: {item.Length}. {Environment.NewLine} ";
            }
        }

        private async void btnAsyncExecute_Click(object sender, RoutedEventArgs e)
        {
            resultWindow.Text = "";
            var watch = System.Diagnostics.Stopwatch.StartNew();

            List<WebsiteDataModel> results = await AsyncDemoMethod.RunDownloadASyncWithOutUsingWeclientAsync();

            watch.Stop();
            var ms = watch.ElapsedMilliseconds;

            PrintResults(results);
            resultWindow.Text += $" Toatal execution time: {ms}. {Environment.NewLine} ";
        }

        private async void btnAsyncExcute2_Click(object sender, RoutedEventArgs e)
        {
            resultWindow.Text = "";
            var watch = System.Diagnostics.Stopwatch.StartNew();

            List<WebsiteDataModel> results = await AsyncDemoMethod.RunDownloadASyncUsingWebclientAsync();

            watch.Stop();
            var ms = watch.ElapsedMilliseconds;

            PrintResults(results);
            resultWindow.Text += $" Toatal execution time: {ms}. {Environment.NewLine} ";

        }

        private async void btnAsyncProgress_Click(object sender, RoutedEventArgs e)
        {
            resultWindow.Text = "";
            var watch = System.Diagnostics.Stopwatch.StartNew();
            Progress<ProgressReportModel> progress = new Progress<ProgressReportModel>();
            progress.ProgressChanged += Progress_ProgressChanged;

            List<WebsiteDataModel> results = await AsyncDemoMethod.RunDownloadAsync(progress);

            watch.Stop();
            var ms = watch.ElapsedMilliseconds;

            PrintResults(results);
            resultWindow.Text += $" Toatal execution time: {ms}. {Environment.NewLine} ";
        }

        private void Progress_ProgressChanged(object sender, ProgressReportModel e)
        {
            dashBoardProgress.Value = e.percentage;
            PrintResults(e.WebSitesDownlaoded);
        }

        private async void btnParallelFor_Click(object sender, RoutedEventArgs e)
        {
            resultWindow.Text = "";
            var watch = System.Diagnostics.Stopwatch.StartNew();
            Progress<ProgressReportModel> progress = new Progress<ProgressReportModel>();
            progress.ProgressChanged += Progress_ProgressChanged;

            List<WebsiteDataModel> results = await AsyncDemoMethod.RunDownloadAsyncParallelFor(progress);

            watch.Stop();
            var ms = watch.ElapsedMilliseconds;

            PrintResults(results);
            resultWindow.Text += $" Toatal execution time: {ms}. {Environment.NewLine} ";
        }

        private async void btnCancelThread_Click(object sender, RoutedEventArgs e)
        {
            resultWindow.Text = "";
            var watch = System.Diagnostics.Stopwatch.StartNew();
            Progress<ProgressReportModel> progress = new Progress<ProgressReportModel>();
            progress.ProgressChanged += Progress_ProgressChanged;

            try
            {
                List<WebsiteDataModel> results = await AsyncDemoMethod.RunDownloadAsyncParallelForWithCancel(progress, cts.Token);
                PrintResults(results);
            }
            catch (Exception ex)
            {

                resultWindow.Text += $" Cancelled: {ex.InnerException.Message}. {Environment.NewLine} "; 
            }

            watch.Stop();
            var ms = watch.ElapsedMilliseconds;

            
            resultWindow.Text += $" Toatal execution time: {ms}. {Environment.NewLine} ";
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            cts.Cancel();
        }
    }
}
