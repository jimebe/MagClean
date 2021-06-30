using System;

namespace MagClean.Client.Models
{
    public class MagFile
    {
        public MagFile()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ContentType { get; set; }
        public long Size { get; set; }
        public byte[] Content { get; set; }
        public string ImageDataUrl { get; set; }
    }
}
