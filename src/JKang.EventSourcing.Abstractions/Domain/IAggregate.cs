﻿using JKang.EventSourcing.Events;
using System.Collections.Generic;

namespace JKang.EventSourcing.Domain
{
    public interface IAggregate<TKey>
    {
        TKey Id { get; }
        int Version { get; }
        IEnumerable<IAggregateEvent<TKey>> Events { get; }
        IAggregateChangeset<TKey> GetChangeset();
    }
}