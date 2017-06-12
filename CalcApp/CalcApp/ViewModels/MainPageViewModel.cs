using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using CalcApp.UseCase;
using Reactive.Bindings;

namespace CalcApp.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        private readonly ICalcUseCase _calcUseCase;

        public ReactiveProperty<double> CalcResultLabel { get; set; } = new ReactiveProperty<double>(10);

        public ReactiveCommand Key0Command { get; set; } = new ReactiveCommand();
        public ReactiveCommand Key1Command { get; set; } = new ReactiveCommand();
        public ReactiveCommand Key2Command { get; set; } = new ReactiveCommand();
        public ReactiveCommand Key3Command { get; set; } = new ReactiveCommand();
        public ReactiveCommand Key4Command { get; set; } = new ReactiveCommand();
        public ReactiveCommand Key5Command { get; set; } = new ReactiveCommand();
        public ReactiveCommand Key6Command { get; set; } = new ReactiveCommand();
        public ReactiveCommand Key7Command { get; set; } = new ReactiveCommand();
        public ReactiveCommand Key8Command { get; set; } = new ReactiveCommand();
        public ReactiveCommand Key9Command { get; set; } = new ReactiveCommand();
        public ReactiveCommand AddCommand { get; set; } = new ReactiveCommand();
        public ReactiveCommand SubCommand { get; set; } = new ReactiveCommand();

        public MainPageViewModel(ICalcUseCase calcUseCase)
        {
            _calcUseCase = calcUseCase;

            Key0Command.Subscribe(o => _calcUseCase.InputNumber(0));
            Key1Command.Subscribe(o => _calcUseCase.InputNumber(1));
            Key2Command.Subscribe(o => _calcUseCase.InputNumber(2));
            Key3Command.Subscribe(o => _calcUseCase.InputNumber(3));
            Key4Command.Subscribe(o => _calcUseCase.InputNumber(4));
            Key5Command.Subscribe(o => _calcUseCase.InputNumber(5));
            Key6Command.Subscribe(o => _calcUseCase.InputNumber(6));
            Key7Command.Subscribe(o => _calcUseCase.InputNumber(7));
            Key8Command.Subscribe(o => _calcUseCase.InputNumber(8));
            Key9Command.Subscribe(o => _calcUseCase.InputNumber(9));
            AddCommand.Subscribe(o => _calcUseCase.Add());

        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
        }
    }
}
