using Android.Content;
using Android.Widget;
using eShopOnContainers.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android.AppCompat;

[assembly: ExportRenderer(typeof(NavigationPage), typeof(CustomNavigationPageRenderer))]
namespace eShopOnContainers.Droid.Renderers
{
    public class CustomNavigationPageRenderer : NavigationPageRenderer
    {
        public CustomNavigationPageRenderer(Context context) : base(context)
        {
        }

        protected override void OnLayout(bool changed, int l, int t, int r, int b)
        {
            base.OnLayout(changed, l, t, r, b);

            if (Element.CurrentPage == null)
            {
                return;
            }

            var toolbar = FindViewById<AndroidX.AppCompat.Widget.Toolbar>(Resource.Id.toolbar);

            if (toolbar != null)
            {
                var image = toolbar.FindViewById<ImageView>(Resource.Id.toolbar_image);

                if (image != null)
                {
                    image.Visibility = !string.IsNullOrEmpty(Element.CurrentPage.Title) 
                        ? Android.Views.ViewStates.Invisible 
                        : Android.Views.ViewStates.Visible;
                }
            }
        }
    }
}
