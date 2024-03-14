using ETicaretAPI.Application.Storage.Local;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace ETicaretAPI.Infrastructure.Services.Storage.Local
{
    public class LocalStorage : Storage,ILocalStorage
    {
        private readonly IWebHostEnvironment _webHostEnvironement;

        public LocalStorage(IWebHostEnvironment webHostEnvironement)
        {
            _webHostEnvironement = webHostEnvironement;
        }

        public async Task DeleteAsync(string path, string fileName)
        => File.Delete($"{path}\\{fileName}");

        public List<string> GetFiles(string path)
        {
            DirectoryInfo directoryInfo=new DirectoryInfo(path);
            return directoryInfo.GetFiles().Select(f=> f.Name).ToList();    
        }

        public bool HasFile(string path, string fileName)
        => File.Exists($"{path}\\{fileName}");
        private async Task<bool> CopyFileAsync(string path, IFormFile file)
        {
            try
            {
                await using FileStream fileStream = new(path, FileMode.Create, FileAccess.Write, FileShare.None, 1024 * 1024, useAsync: false);

                await fileStream.CopyToAsync(fileStream);
                await fileStream.FlushAsync();
                return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<List<(string fileName, string pathOrContainerName)>> UploadAsync(string path, IFormFileCollection files)
        {
            string uploadPath = Path.Combine(_webHostEnvironement.WebRootPath, path);
            if (!Directory.Exists(uploadPath))
            {
                Directory.CreateDirectory(uploadPath);
            }
            List<(string fileName, string path)> datas = new();
            foreach (IFormFile file in files)
            {
                await CopyFileAsync($"{uploadPath}\\{file.Name}", file);
                datas.Add((file.Name, $"{uploadPath}\\{file.Name}"));
            }

            //TODO CUSTOM EXCEPTION

            return null;
        }
    }
}
