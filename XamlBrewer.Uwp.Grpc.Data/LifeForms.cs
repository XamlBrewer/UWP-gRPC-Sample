using System;
using System.Collections.Generic;

namespace XamlBrewer.Uwp.Grpc.Data
{
    public static class LifeForms
    {
        private static Random _rnd = new Random(DateTime.Now.Millisecond);

        public static Tuple<string, string, string> WhoEver()
        {
            return _LifeForms[_rnd.Next(_LifeForms.Count)];
        }

        private static List<Tuple<string, string, string>> _LifeForms = new List<Tuple<string, string, string>>
        {
            Tuple.Create("Human", "James T. Kirk", "Captain"),
            Tuple.Create("Human", "Christopher Pike", "Captain"),
            Tuple.Create("Human", "Jean-Luc Picard", "Captain"),
            Tuple.Create("Human", "Kathryn Janeway", "Captain"),
            Tuple.Create("Human", "William T. Riker", "Commander"),
            Tuple.Create("Human", "Wesley Crusher", "Ensign"),
            Tuple.Create("Human", "Red Shirt", "Anonymous"),
            Tuple.Create("Android", "Data", "Lieutenant Commander"),
            Tuple.Create("Klingon", "Worf", "Lieutenant Commander"),
            Tuple.Create("half-Betazoid, half-Human", "Deanna Troi", "Counselor"),
            Tuple.Create("Klingon", "Worf", "Lieutenant Commander"),
            Tuple.Create("Human", "Benjamin Sisko", "Captain"),
            Tuple.Create("Changeling", "Odo", "Constable"),
            Tuple.Create("Human", "Chakotay", "Commander"),
            Tuple.Create("Hologram", "The Doctor", "Chief Medical Officer"),
            Tuple.Create("Vulcan", "Tuvok", "Lieutenant Commander"),
            Tuple.Create("Human", "Michael Burnham", "Commander"),
            Tuple.Create("half-Vulcan, half-Human", "Spock", "Lieutenant Commander"),
            Tuple.Create("Human", "Leonard 'Bones' McCoy", "Chief Medical Officer"),
            Tuple.Create("Kelpien", "Saru", "First Officer"),
            Tuple.Create("Klingon", "Voq", "Chief Security"),
            Tuple.Create("Bajoran", "Kira Nerys", "Colonel"),
            Tuple.Create("Ferengi", "Quark", "Barkeeper"),
            Tuple.Create("Cyborg", "The Borg", "Collective"),
            Tuple.Create("Human, former Borg drone", "Seven of Nine", "Scientist"),
            Tuple.Create("Talaxian", "Neelix","Ambassador"),
            Tuple.Create("Terran", "Philippa Georgiou", "Emperor"),
            Tuple.Create("Vulcan", "Sarek", "Ambassador"),
            // Here's where my alter ego from the Mirror Universe took over
            Tuple.Create("Toy", "Buzz Lightyear", "Space Ranger"),
            Tuple.Create("half-Human, half-Giant", "Rubeus Hagrid", "Gamekeeper"),
            Tuple.Create("Cylon","Number Six","Infiltrator")
    };
    }
}
