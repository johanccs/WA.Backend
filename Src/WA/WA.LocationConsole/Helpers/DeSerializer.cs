using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using WA.Data.Entities;

namespace WA.LocationConsole.Helpers
{
    public class DeSerializer
    {
        public async Task<RawProjectLocation> DeSerialize()
        {
            RawProjectLocation serializer = new RawProjectLocation();

            await Task.Run(() =>
            {
                string jsonContent = File.ReadAllText(@"C:\Tutorials\WebAfrica\WA.Backend\Resources\Locations.txt");
                serializer = JsonSerializer.Deserialize<RawProjectLocation>(jsonContent);

            });
            return serializer;
        }
    }
}
