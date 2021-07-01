using System;
using System.Collections.Generic;

namespace MagClean.Services.Models
{
    public class MagFile
    {
        public string Name { get; set; }

        public List<MagFileLine> Lines { get; set; }
    }

    public class MagFileLine
    {
        public string Value { get; set; }

        public bool Metadata { get; set; }

        public decimal Easting { get; set; }

        public int EastingRounded { get { return (int)Math.Round(Easting, 0); } }

        public decimal Northing { get; set; }

        public int NorthingRounded { get { return (int)Math.Round(Northing, 0); } }

        public string EastingNorthingRounded { get { return EastingRounded.ToString() + " - " + NorthingRounded.ToString(); } }

        public int Elevation { get; set; }

        public decimal MagNanoTeslas { get; set; }

        public int MagNanoTeslasRounded { get { return (int)Math.Round(MagNanoTeslas, 0); } }

        public int Li1 { get; set; }

        public decimal CorNanoTeslas { get; set; }

        public int Satellite { get; set; }

        public decimal Time { get; set; }

        public int PicketX { get; set; }

        public int PicketY { get; set; }
    }
}
