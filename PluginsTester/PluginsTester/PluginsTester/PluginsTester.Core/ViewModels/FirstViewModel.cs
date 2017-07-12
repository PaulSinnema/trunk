using MvvmCross.Core.ViewModels;
using System.Windows.Input;

namespace PluginsTester.Core.ViewModels
{
    public class FirstViewModel
        : MvxViewModel
    {
        public override void Start()
        {
            base.Start();

            // ShowViewModel<PincodeViewModel>();
        }

        string hello = "Hello MvvmCross";
        public string Hello
        {
            get { return hello; }
            set { SetProperty(ref hello, value); }
        }

        public ICommand PinClicked
        {
            get => new MvxCommand(() => OpenPin());
        }

        private void OpenPin()
        {
            ShowViewModel<TestViewModel>();
        }
    }
}
