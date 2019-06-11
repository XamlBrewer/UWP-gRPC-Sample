using Grpc.Core;
using Startrek;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using static Startrek.Transporter;

namespace XamlBrewer.Uwp.Grpc.Server
{
    public class TransporterService : TransporterBase
    {
        private Random _rnd = new Random(DateTime.Now.Millisecond);

        public override Task<Location> Lock(Location request, ServerCallContext context)
        {
            return Task.FromResult(new Location
            {
                Description = Data.Locations.WhereEver()
            });
        }

        public override Task<LifeForm> BeamUp(Location request, ServerCallContext context)
        {
            var whoEver = Data.LifeForms.WhoEver();
            var result = new LifeForm
            {
                Species = whoEver.Item1,
                Name = whoEver.Item2,
                Rank = whoEver.Item3
            };

            return Task.FromResult(result);
        }

        public override async Task BeamUpParty(Location request, IServerStreamWriter<LifeForm> responseStream, ServerCallContext context)
        {
            var rnd = _rnd.Next(2, 5);
            for (int i = 0; i < rnd; i++)
            {
                var whoEver = Data.LifeForms.WhoEver();
                var result = new LifeForm
                {
                    Species = whoEver.Item1,
                    Name = whoEver.Item2,
                    Rank = whoEver.Item3
                };

                await responseStream.WriteAsync(result);
            }
        }

        public override Task<Location> BeamDown(LifeForm request, ServerCallContext context)
        {
            // Uncomment to test the client deadline.
            // Task.Delay(60000).Wait();

            return Task.FromResult(new Location
            {
                Description = Data.Locations.WhereEver()
            });
        }

        public override async Task<Location> BeamDownParty(IAsyncStreamReader<LifeForm> requestStream, ServerCallContext context)
        {
            while (await requestStream.MoveNext())
            {
                // ...
            }

            return new Location
            {
                Description = Data.Locations.WhereEver()
            };
        }
    }
}
