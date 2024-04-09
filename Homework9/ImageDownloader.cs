using System.ComponentModel;
using System.Net;

namespace Homework9
{
    internal class ImageDownloader
    {
        public event Action<string>? ImageStarted;
        public event Action<string>? ImageCompleted;

        private List<ImageDownload> _downloads = new();

        public void DownloadAsync(params string[] urls)
        {
            foreach (var url in urls)
            {
                var download = new ImageDownload { Url = url };
                StartDownloadTask(download);
                _downloads.Add(download);
            }
        }

        public void PrintImageDownloadStatuses()
        {
            foreach (var download in _downloads)
            {
                if (download.Task.IsCompleted)
                {
                    Console.Out.WriteLine($"{download.Filename} - успешно загружен!");
                }
                else
                {
                    Console.Out.WriteLine($"{download.Filename} - загружается...");
                }
            }
            Console.Out.WriteLine();
        }

        private void StartDownloadTask(ImageDownload download) 
        {
            var webClient = new WebClient();
            webClient.DownloadFileCompleted += OnDownloadFileCompleted(download);

            download.Filename = Path.GetFileName(download.Url);

            ImageStarted?.Invoke("Скачивание файла началось");
            Console.WriteLine("Качаю \"{0}\" из \"{1}\" .......\n\n", download.Filename, download.Url);
            download.Task = webClient.DownloadFileTaskAsync(download.Url, download.Filename);
        }

        private AsyncCompletedEventHandler OnDownloadFileCompleted(ImageDownload download)
        {
            return (_, e) =>
            {
                if (e.Error != null)
                {
                    throw e.Error;
                }
                else
                {
                    Console.WriteLine("Успешно скачал \"{0}\" из \"{1}\"", download.Filename, download.Url);
                    ImageCompleted?.Invoke("Скачивание файла закончилось\n");
                }
            };
        }

        private class ImageDownload
        {
            public string Url { get; set; }
            public string Filename { get; set; }
            public Task Task { get; set; }
        }
    }
}
