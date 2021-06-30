using MagClean.Services.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagClean.Services
{
    public class MagFileService : IMagFileService
    {
        public MagFileService(ILogger<MagFileService> logger)
        {
            Logger = logger;
        }

        public ILogger<MagFileService> Logger { get; }

        public Task<IEnumerable<MagFileAnalysisResult>> UploadFiles(IEnumerable<MagFileUpload> files)
        {
            var uploadedFiles = files?.Select(x => new MagFileAnalysisResult()
            {
                File = new MagFile()
                {
                    Name = x.Name,
                    Lines = x.Content.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None)?.Select(y =>
                    {
                        var line = new MagFileLine();
                        if (y != null)
                        {
                            line.Value = y;
                            if (string.IsNullOrWhiteSpace(y) || y.Trim().StartsWith('/'))
                            {
                                line.Metadata = true;
                            }
                            else
                            {
                                try
                                {

                                    var lineValues = y.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                                    line.Easting = decimal.TryParse(lineValues.ElementAtOrDefault(0), out decimal easting) ? easting : decimal.Zero;
                                    line.Northing = decimal.TryParse(lineValues.ElementAtOrDefault(1), out decimal northing) ? northing : decimal.Zero;
                                    line.Elevation = int.TryParse(lineValues.ElementAtOrDefault(2), out int elevation) ? elevation : 0;
                                    line.MagNanoTeslas = decimal.TryParse(lineValues.ElementAtOrDefault(3), out decimal cor) ? cor : 0;
                                    line.Time = decimal.TryParse(lineValues.ElementAtOrDefault(8), out decimal time) ? time : 0;
                                }
                                catch (Exception e) { }
                            }
                        }
                        return line;
                    }).ToList()
                }
            });
            return Task.FromResult(uploadedFiles);
        }
    }
}
