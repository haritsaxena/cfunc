using System;
namespace cfunc.ch1
{
    public static class F
    {
        public static R Using<TDisp, R>(TDisp disposable, Func<TDisp, R> f) where TDisp : IDisposable
        {
            using (disposable) return f(disposable);
        }

        public static R Using<TDisp, R>(Func<TDisp> d, Func<TDisp, R> f) where TDisp : IDisposable
        {
            using (var disp = d()) {
                return f(disp);
            }
        }
 
    }
}