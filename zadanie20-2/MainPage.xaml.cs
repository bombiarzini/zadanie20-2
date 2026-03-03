namespace zadanie20_2
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();

            var image = new Image
            {
                Source = "dotnet_bot.png",
                HeightRequest = 200
            };
            MainStack.Children.Add(image);
            var remoteImage = new Image
            {
                Source = new UriImageSource
                {
                    Uri = new Uri("https://aka.ms/campus.jpg"),
                    CacheValidity = new TimeSpan(7,0,0,0)
                },
                HeightRequest = 200

            };
            MainStack.Children.Add(remoteImage);

        }
        
    }
}
