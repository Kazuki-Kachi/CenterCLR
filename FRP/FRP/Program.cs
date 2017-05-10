using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using System.Collections;
using System.Reactive.Concurrency;
using System.Threading;
using t = System.Timers;
using System.Timers;
using System.Reactive.Subjects;

namespace RP
{
    class Program
    {

        static void Main(string[] args)
        {
            var hot = HotTimer(TimeSpan.Zero,TimeSpan.FromSeconds(2));
            var cold = Observable.Timer(TimeSpan.Zero, TimeSpan.FromSeconds(2));
            Thread.Sleep(5000);
            hot.Subscribe(i => Console.WriteLine($"Hot A:{i}"));
            cold.Subscribe(i => Console.WriteLine($"Cold A:{i}"));
            Thread.Sleep(5000);
            hot.Subscribe(i => Console.WriteLine($"Hot B:{i}"));
            cold.Subscribe(i => Console.WriteLine($"Cold B:{i}"));

            Console.ReadKey();
        }

        static IObservable<long> HotTimer(TimeSpan duetime,TimeSpan period)
        {
            var s = new Subject<long>();
            Task.Run(async () =>
            {
                await Task.Delay(duetime);
                for(var l = 0L; true; l++)
                {
                    s.OnNext(l);
                    await Task.Delay(period).ConfigureAwait(false);
                }
            });
            return s.AsObservable();
        }

        #region 反転

        class Enumerable<T>
        {
            // 引数なしでIEnumerator<T>を返す
            public IEnumerator<T> GetEnumerator() => throw new NotImplementedException();
        }
        class Observable<T> : IObservable<T>
        {
            // IObserver<T>を引数にとって返値なし(購読解除用のIDisposable)
            public IDisposable Subscribe(IObserver<T> observer) => throw new NotImplementedException();
        }

        class Enumerator<T>
        {
            public T Current => throw new NotImplementedException();
            public bool MoveNext() => throw new NotImplementedException();

            // MoveNext()とCurrentを合わせる
            public T GetNext() => throw new NotImplementedException();
            /* このMethodの結果として起り得るパターン
                 1.T型のデータが返る(MoveNext() == true + Current)
                 2.列挙が完了した(MoveNext() == false)
                 3.例外
                 def getNext() : Try[Option[T]] => 
            */

        }

        class Observer<T>
        {
            // T型のデータを伝搬する
            public void OnNext(T value) => throw new NotImplementedException();
            // Pushが完了したことを表す
            public void OnCompleted() => throw new NotImplementedException();
            // 例外が発生したことを通知する
            public void OnError(Exception error) => throw new NotImplementedException();
        }

        #endregion

    }
}
