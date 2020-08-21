using System;

using GoogleMobileAds.Api;

namespace GoogleMobileAds.Common
{
    public interface IAdLoaderClient
    {
        event EventHandler<LoadAdErrorClientEventArgs> OnAdFailedToLoad;

        event EventHandler<CustomNativeClientEventArgs> OnCustomNativeTemplateAdLoaded;

        event EventHandler<CustomNativeClientEventArgs> OnCustomNativeTemplateAdClicked;

        void LoadAd(AdRequest request);
    }
}
