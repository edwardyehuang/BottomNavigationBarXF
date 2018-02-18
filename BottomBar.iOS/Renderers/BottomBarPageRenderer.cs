using System;
using BottomBar.iOS.Renderers;
using BottomBar.XamarinForms;
using CoreGraphics;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(BottomBarPage), typeof(BottomBarPageRenderer))]
namespace BottomBar.iOS.Renderers
{
    public class BottomBarPageRenderer : TabbedRenderer
    {
        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);

            RemoveBorderLine();
        }

        protected virtual void RemoveBorderLine()
        {
            TabBar.ShadowImage = new UIImage();
            TabBar.BackgroundImage = new UIImage();

        }

        public static void Initialize()
        {
            
        }
    }
}
