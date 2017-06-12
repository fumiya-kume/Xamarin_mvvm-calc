using CalcApp.UseCase;
using Prism.Unity;
using CalcApp.Views;
using Microsoft.Practices.Unity;
using Xamarin.Forms;

namespace CalcApp
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync("MainPage");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterType<ICalcUseCase, CalcUseCase>(new ContainerControlledLifetimeManager());

            Container.RegisterTypeForNavigation<MainPage>();
        }
    }
}
