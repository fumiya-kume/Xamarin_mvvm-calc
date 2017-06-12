using Reactive.Bindings;
using System.Collections.Generic;
using System.Linq;
using CalcApp.Model;
using System.Reactive.Linq;
using CalcApp.Services;

namespace CalcApp.UseCase
{
    public class CalcUseCase : ICalcUseCase
    {
        public ReactiveProperty<double> CalcResult { get; set; }
        public ReactiveProperty<Dictionary<CalcType, double>> CalcHistry { get; set; } = new ReactiveProperty<Dictionary<CalcType, double>>();

        public CalcUseCase()
        {
            NumberHistry = 0;

            CalcResult = CalcHistry
                .Where(doubles => doubles != null)
                .Select(doubles => CalcService.Calc(doubles.Last().Key, CalcResult.Value, doubles.Last().Value))
                .ToReactiveProperty();
        }

        private double NumberHistry = 0;

        public void InputNumber(double number)
        {
            NumberHistry = NumberHistry * 10 + number;
        }
        public void Add()
        {
            CalcHistry.Value.Add(CalcType.Add, NumberHistry);
        }

        public void Sub()
        {
            CalcHistry.Value.Add(CalcType.Sub, NumberHistry);
        }

        public void multi()
        {
            CalcHistry.Value.Add(CalcType.multi, NumberHistry);
        }

        public void div()
        {
            CalcHistry.Value.Add(CalcType.div, NumberHistry);
        }
    }
}
