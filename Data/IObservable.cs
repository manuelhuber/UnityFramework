using System;

namespace Grimity.Data {
public interface IObservable<T> {
    T Value { get; }
    void OnChange(Action<T> obs, bool callImmediately = true);
    bool RemoveOnChange(Action<T> obs);
}
}