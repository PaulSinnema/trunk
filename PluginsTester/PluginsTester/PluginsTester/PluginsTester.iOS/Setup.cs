using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Platform;
using MvvmCross.iOS.Views.Presenters;
using MvvmCross.Platform;
using MvvmCross.Platform.Platform;
using PluginsTester.Core.ViewModels;
using System.Collections.Generic;
using System.Reflection;
using UIKit;

namespace PluginsTester.iOS
{
    public class Setup : MvxIosSetup
    {
        public Setup(MvxApplicationDelegate applicationDelegate, UIWindow window)
            : base(applicationDelegate, window)
        {
        }

        public Setup(MvxApplicationDelegate applicationDelegate, IMvxIosViewPresenter presenter)
            : base(applicationDelegate, presenter)
        {
        }

        protected override void InitializeFirstChance()
        {
            base.InitializeFirstChance();
        }

        protected override IEnumerable<Assembly> GetViewModelAssemblies()
        {
            var assemblies = base.GetViewModelAssemblies();

            assemblies = new List<Assembly>()
            {
                typeof(FirstViewModel).Assembly,
                //typeof(TestViewModel).Assembly
            };
            return assemblies;
        }

        protected override IEnumerable<Assembly> GetViewAssemblies()
        {
            var assemblies = base.GetViewAssemblies();

            assemblies = new List<Assembly>(assemblies)
            {
                typeof(FirstViewModel).Assembly,
                //typeof(TestViewController).Assembly
            };
            return assemblies;
        }

        protected override IMvxApplication CreateApp()
        {
            return new Core.App();
        }

        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }
    }
}
