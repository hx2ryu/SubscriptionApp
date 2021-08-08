using SubscriptionOverview.Control.Model;
using SubscriptionOverview.Global;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubscriptionOverview.ViewModel
{
    class MenuViewModel : BindableBase
    {
        public MenuViewModel()
        {
            InitBannerItems();
        }

        //public BannerBoxModel CurrentBanner { get; set; }

        private ObservableCollection<BannerBox> bannerDataSource = new();
        public ObservableCollection<BannerBox> BannerDataSource
        {
            get { return bannerDataSource; }
            set 
            {
                bannerDataSource = value;
                OnPropertyChanged();
            }
        }

        private void InitBannerItems()
        {
            string imageRootPath = Path.Combine(Environment.CurrentDirectory, "Assets", "Image");

            BannerDataSource.Add(new BannerBox()
            {
                Title = "Instagram",
                SubTitle = "Workspace",
                Source = Path.Combine(imageRootPath, "instagram_icon.png"),
            });
            BannerDataSource.Add(new BannerBox()
            {
                Title = "Photos",
                SubTitle = "Workspace",
                Source = Path.Combine(imageRootPath, "photo_icon.png"),
            });
            BannerDataSource.Add(new BannerBox()
            {
                Title = "AppStore",
                SubTitle = "Workspace",
                Source = Path.Combine(imageRootPath, "app_store_icon.png"),
            });

            //CurrentBanner = bannerCollection[0];
        }
    }
}
