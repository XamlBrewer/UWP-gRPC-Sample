using System;
using System.Collections.Generic;

namespace XamlBrewer.Uwp.Grpc.Data
{
    public static class Locations
    {
        private static Random _rnd = new Random(DateTime.Now.Millisecond);

        public static string WhereEver()
        {
            return _Locations[_rnd.Next(_Locations.Count)];
        }

        private static List<string> _Locations = new List<string>
        {
            "starship USS Enterprise",
            "starship USS Voyager",
            "starship USS Discovery",
            "starbase Deep Space 9",
            "USS Shenzhou",
            "where no man has gone before",
            "planet Vulcan",
            "Starfleet Academy",
            "the holodek",
            "the separated saucer",
            "an unexploded photon torpedo",
            "the Mirror Universe",
            "a cloaked Klingon Bird of Prey",
            "planet Romulus",
            "United Federation of Planets Headquarters",
            "a Klingon cleave ship",
            "the Federation-Klingon Neutral Zone",
            "Section 31 Headquarters",
            "a Borg cube",
            "the Genesis Planet",
            "Earth",
            "the Bajoran Wormhole",
            "a fascinating space anomaly",
            "bridge",
            "the turbolift",
            "inside the mycelial network",
            // Here's where my Vulcan mind melt went wrong.
            "Hogwarts",
            "planet Dagobah",
            "the Upside Down"
        };
    }
}