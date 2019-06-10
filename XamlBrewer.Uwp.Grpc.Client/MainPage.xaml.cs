using Grpc.Core;
using Startrek;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using static Startrek.Transporter;

namespace XamlBrewer.Uwp.Grpc.Client
{
    public sealed partial class MainPage : Page
    {
        private Channel _channel;
        private TransporterClient _client;

        private Random _rnd = new Random(DateTime.Now.Millisecond);

        public MainPage()
        {
            var coreTitleBar = CoreApplication.GetCurrentView().TitleBar;
            coreTitleBar.ExtendViewIntoTitleBar = true;

            var titleBar = ApplicationView.GetForCurrentView().TitleBar;
            if (titleBar != null)
            {
                titleBar.BackgroundColor = Colors.Transparent;
                titleBar.ForegroundColor = Color.FromArgb(255, 214, 117, 36);
                titleBar.ButtonBackgroundColor = Colors.Transparent;
                titleBar.ButtonInactiveBackgroundColor = Colors.SlateGray;
                titleBar.ButtonForegroundColor = Color.FromArgb(255, 214, 117, 36);
            }

            this.InitializeComponent();

            Loaded += MainPage_Loaded;
        }

        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            WriteLog("Transporter Room Panel Startup.");
            WriteLog("- Openening a channel.");
            _channel = new Channel("localhost:50051", ChannelCredentials.Insecure);
            WriteLog("- Channel open.");

            _client = new TransporterClient(_channel);
        }

        private void BeamUpOne_Click(object sender, RoutedEventArgs e)
        {
            var location = new Location
            {
                Description = Data.Locations.WhereEver()
            };

            var lifeForm = _client.BeamUp(location);

            WriteLog($"Beamed up {lifeForm.Rank} {lifeForm.Name} ({lifeForm.Species}) from {location.Description}.");
        }

        private async void BeamUpParty_Click(object sender, RoutedEventArgs e)
        {
            var location = new Location
            {
                Description = Data.Locations.WhereEver()
            };

            WriteLog($"Beaming up a party from {location.Description}.");

            using (var lifeForms = _client.BeamUpParty(location))
            {
                while (await lifeForms.ResponseStream.MoveNext())
                {
                    var lifeForm = lifeForms.ResponseStream.Current;
                    WriteLog($"- Beamed up {lifeForm.Rank} {lifeForm.Name} ({lifeForm.Species}).");
                }
            }

            WriteLog($"- Party beamed up.");
        }

        private void BeamDownOne_Click(object sender, RoutedEventArgs e)
        {
            var whoEver = Data.LifeForms.WhoEver();
            var lifeForm = new LifeForm
            {
                Species = whoEver.Item1,
                Name = whoEver.Item2,
                Rank = whoEver.Item3
            };

            var location = _client.BeamDown(lifeForm);

            WriteLog($"Beamed down {lifeForm.Rank} {lifeForm.Name} ({lifeForm.Species}) to {location.Description}.");
        }

        private async void BeamDownParty_Click(object sender, RoutedEventArgs e)
        {
            var rnd = _rnd.Next(2, 5);
            var lifeForms = new List<LifeForm>();
            for (int i = 0; i < rnd; i++)
            {
                var whoEver = Data.LifeForms.WhoEver();
                var lifeForm = new LifeForm
                {
                    Species = whoEver.Item1,
                    Name = whoEver.Item2,
                    Rank = whoEver.Item3
                };

                lifeForms.Add(lifeForm);
            }

            WriteLog($"Beaming down a party.");

            using (var call = _client.BeamDownParty())
            {
                foreach (var lifeForm in lifeForms)
                {
                    await call.RequestStream.WriteAsync(lifeForm);
                    WriteLog($"- Beamed down {lifeForm.Rank} {lifeForm.Name} ({lifeForm.Species}).");
                }

                await call.RequestStream.CompleteAsync();

                var location = await call.ResponseAsync;

                WriteLog($"- Party beamed down to {location.Description}.");
            }
        }

        private async void CloseChannel_Click(object sender, RoutedEventArgs e)
        {
            WriteLog("Routing all energy to deflector shields.");
            await _channel.ShutdownAsync();
            WriteLog("- Transporter channel closed.");
        }

        private void WriteLog(string message)
        {
            Log.Text += message + " (stardate " + Stardate + ")" +Environment.NewLine;
            LogScroll.ChangeView(0, double.MaxValue, 1);
        }

        private string Stardate => DateTime.Now.ToString("mm:ss.fff");
    }
}
