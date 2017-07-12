using Foundation;
using MvvmCross.iOS.Views;
using PluginsTester.Core.ViewModels;
using System;

namespace PluginsTester.iOS
{
    public partial class TestViewController : MvxViewController<TestViewModel>
    {
        public TestViewController () : base ("TestView", null)
        {
        }
    }
}