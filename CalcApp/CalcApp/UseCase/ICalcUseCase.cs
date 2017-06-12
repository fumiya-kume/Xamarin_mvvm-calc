using System.Collections.Generic;
using CalcApp.Model;
using Reactive.Bindings;

namespace CalcApp.UseCase
{
    public interface ICalcUseCase
    {
        ReactiveProperty<Dictionary<CalcType, double>> CalcHistry { get; set; }
        ReactiveProperty<double> CalcResult { get; set; }

        void Add();
        void div();
        void InputNumber(double number);
        void multi();
        void Sub();
    }
}