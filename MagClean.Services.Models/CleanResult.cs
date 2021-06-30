using System.Collections.Generic;

namespace MagClean.Services.Models
{
    public class CleanResult
    {
        public IEnumerable<MagFileCleanResult> MagFileUploadResults { get; set; }
    }
}
