using System.Collections.Generic;

namespace MagClean.Services.Models
{
    public class MagFileCleanResult
    {
        public MagFile CleanFile { get; set; }

        public MagFile OriginalFile { get; set; }

        public IEnumerable<string> Messages { get; set; }

        public IEnumerable<string> Errors { get; set; }
    }
}
