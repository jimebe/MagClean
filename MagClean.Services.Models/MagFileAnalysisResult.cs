using System.Collections.Generic;

namespace MagClean.Services.Models
{
    public class MagFileAnalysisResult
    {
        public MagFile File { get; set; }

        public IEnumerable<string> Messages { get; set; }

        public IEnumerable<string> Errors { get; set; }
    }
}
