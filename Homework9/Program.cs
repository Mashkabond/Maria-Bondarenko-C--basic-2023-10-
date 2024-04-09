namespace Homework9
{
    internal class Program
    {

        private static readonly string[] Images = new string[]
        {
            "https://webneel.com/daily/sites/default/files/images/daily/08-2018/1-nature-photography-spring-season-mumtazshamsee.jpg",
            "https://webneel.com/daily/sites/default/files/images/daily/07-2021/2-sculpture-stairway-heaven-australia-david-mccracken.jpg",
            "https://webneel.com/daily/sites/default/files/images/daily/07-2021/1-sculpture-stairway-heaven-australia-david-mccracken.jpg",
            "https://webneel.com/daily/sites/default/files/images/daily/07-2021/6-sculpture-caring-hand-switzerland.jpg",
            "https://webneel.com/daily/sites/default/files/images/daily/07-2021/7-sculpture-mother-nature-rotating-earth.jpg",
            "https://webneel.com/daily/sites/default/files/images/daily/07-2021/9-sculpture-de-vaartkapoen-belgium-tom-frantzen.jpg",
            "https://webneel.com/daily/sites/default/files/images/daily/07-2021/13-sculpture-fantasy-wire-fairies-trentham-garden-britain.jpg",
            "https://webneel.com/daily/sites/default/files/images/daily/07-2021/12-sculpture-fantasy-wire-fairies-trentham-garden-britain.jpg",
            "https://webneel.com/daily/sites/default/files/images/daily/07-2021/14-sculpture-mustangs-texas-usa-robert-glen.jpg",
            "https://webneel.com/daily/sites/default/files/images/daily/07-2021/15-sculpture-mustangs-texas-usa-robert-glen.jpg"
        };

        static void Main(string[] args)
        {
            var downloader = new ImageDownloader();

            downloader.ImageStarted += Console.WriteLine;
            downloader.ImageCompleted += Console.WriteLine;

            downloader.DownloadAsync(Images);

            Console.WriteLine("Для выхода из программы нажмите 'A'. Для проверки статуса нажмите любую другую клавишу");
            OnKeyPress(downloader);
        }

        static void OnKeyPress(ImageDownloader downloader)
        {
            while (true)
            {
                var key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.A)
                {
                    break;
                }
                else
                {
                    downloader.PrintImageDownloadStatuses();
                }
            }
        }
    }
}