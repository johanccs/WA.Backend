using System.Collections.Generic;

namespace WA.Data.Entities
{
    public class RawProjectLocation
    {
        public string Result { get; set; }
        public string? Message { get; set; }
        public List<ProjectLocationsEntity> Data { get; set; }
    }
}
