using System.Collections.Generic;
using System.Threading.Tasks;

namespace MagClean.Services.Models
{
    public interface IMagFileService
    {
        Task<IEnumerable<MagFileAnalysisResult>> UploadFiles(IEnumerable<MagFileUpload> files);
    }
}
