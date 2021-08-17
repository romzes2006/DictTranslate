using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace Dictionary_lib
{
    public class Files_Work
    {
        public Files_Work()
        {
        }

        public async Task<Dictionary_class> load_from_file_async(string filename)
        {
            try
            {
                using var file = new FileStream(filename, FileMode.Open);
                Dictionary_class restoredDict = await JsonSerializer.DeserializeAsync<Dictionary_class>(file);
                return restoredDict;
            }
            catch (Exception e)
            {
                throw new Exception($"Ошибка доступа к файлу: {e}");
            }
        }

        public async Task save_to_file_async(string filename, Dictionary_class Dict)
        {
            try
            {
                using var file = new FileStream(filename, FileMode.Create);
                await JsonSerializer.SerializeAsync<Dictionary_class>(file, Dict);
            }
            catch (Exception e)
            {
                throw new Exception($"Ошибка доступа к файлу {e}");
            }
        }
    }
}