namespace SubscriptionOverview.Control.Model
{
    public class BannerBoxModel
    {
        public BannerBoxModel(string source, string title, string subTitle)
        {
            Source = source;
            Title = title;
            SubTitle = subTitle;
        }

        public string Source { get; }
        public string Title { get; }
        public string SubTitle { get; }
    }
}
