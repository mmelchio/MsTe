﻿using System;

namespace AutoReservation.Dal
{
    public class LocalOptimisticConcurrencyException<T> : Exception
    {
        public LocalOptimisticConcurrencyException(string msg) : base(msg) { }
        public LocalOptimisticConcurrencyException(string msg, T mergedEntity) : base(msg)
        {
            MergedEntity = mergedEntity;
        }

        public T MergedEntity { get; set; }
    }
}