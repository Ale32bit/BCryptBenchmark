using System;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
#nullable enable
namespace BCryptBenchmark {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();

            ToggleLoadingBar(progressBar, false);
            ToggleLoadingBar(progressBarManual, false);
        }

        private async void runTestButton_Click(object sender, EventArgs e) {
            runTestButton.Enabled = false;
            minTimeInput.Enabled = false;
            ToggleLoadingBar(progressBar, true);

            long minTime = (long)minTimeInput.Value;
            long timeTaken;
            int cost = 3;

            long[] costs = new long[31 - 4];
            do {
                cost++;
                timeTaken = await Task.Run(() => Benchmark(cost));
                costs[cost - 4] = timeTaken;
                costResult.Text = cost.ToString();
                timeTakenText.Text = timeTaken + " ms";
            } while ( timeTaken < minTime );

            var nearest = costs.OrderBy(x => Math.Abs(x - minTime)).First();

            var index = Array.IndexOf(costs, nearest);
            cost = index + 4;

            costResult.Text = cost.ToString();
            timeTakenText.Text = nearest + " ms";

            runTestButton.Enabled = true;
            minTimeInput.Enabled = true;
            ToggleLoadingBar(progressBar, false);

        }

        private async void runManualTestButton_Click(object sender, EventArgs e) {
            runManualTestButton.Enabled = false;
            manualCostInput.Enabled = false;

            ToggleLoadingBar(progressBarManual, true);

            int cost = (int)manualCostInput.Value;
            long timeTaken;

            timeTaken = await Task.Run(() => Benchmark(cost));

            timeTakenManualText.Text = timeTaken + " ms";

            ToggleLoadingBar(progressBarManual, false);
            manualCostInput.Enabled = true;
            runManualTestButton.Enabled = true;
        }


        private void ToggleLoadingBar(ProgressBar progressBar, bool enable) {
            if ( enable ) {
                progressBar.Style = ProgressBarStyle.Marquee;
            } else {
                progressBar.Style = ProgressBarStyle.Continuous;
            }
        }

        public long Benchmark(int cost = 4) {
            string password = RandomString(32);

            var sw = Stopwatch.StartNew();
            BCrypt.Net.BCrypt.EnhancedHashPassword(password, cost);
            sw.Stop();

            return sw.ElapsedMilliseconds;
        }

        public static string RandomString(int length) {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789-_!?=()[]{}<>/,.;:";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
