﻿namespace Cut
{
    public interface ITimerUpdater
    {
        void Subscribe(IPrepTimer newSubscriber);
        void Unsubscribe(IPrepTimer subscriber);
    }
}