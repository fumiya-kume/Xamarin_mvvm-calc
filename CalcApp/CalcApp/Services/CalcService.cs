using System;
using CalcApp.Model;

namespace CalcApp.Services
{
    public static class CalcService
    {
        public static double Calc(CalcType calctype, double LeftValue, double RightValue)
        {
            switch (calctype)
            {
                case CalcType.Add:
                    return LeftValue + RightValue;
                case CalcType.Sub:
                    return LeftValue - RightValue;
                case CalcType.multi:
                    return LeftValue * RightValue;
                case CalcType.div:
                    if (RightValue == 0) throw new ArgumentException("Zero除数が発生しました。");
                    return LeftValue / RightValue;
                default:
                    throw new ArgumentException();
            }
        }
    }
}
