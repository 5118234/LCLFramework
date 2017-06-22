﻿
using LCL.Domain.Entities;
using LCL.Domain.Events;
using LCL.Tests.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCL.Tests.Domain.Events
{
    [Serializable]
    public class GetUserOrdersEvent : DomainEvent
    {
        public GetUserOrdersEvent(IEntity source) : base(source) { }

        public IEnumerable<SalesOrder> SalesOrders { get; set; }


    }
}
