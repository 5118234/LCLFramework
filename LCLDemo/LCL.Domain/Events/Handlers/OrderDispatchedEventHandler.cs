﻿using LCL.Bus;
using LCL.Domain.Events;
using LCL.Domain.Model;
using LCL.Domain.Repositories;

namespace LCL.Domain.Events.Handlers
{
    public class OrderDispatchedEventHandler : IDomainEventHandler<OrderDispatchedEvent>
    {
        private readonly ISalesOrderRepository salesOrderRepository;
        private readonly IEventBus bus;

        public OrderDispatchedEventHandler(ISalesOrderRepository salesOrderRepository, IEventBus bus)
        {
            this.salesOrderRepository = salesOrderRepository;
            this.bus = bus;
        }

        public void Handle(OrderDispatchedEvent evnt)
        {
            SalesOrder salesOrder = evnt.Source as SalesOrder;
            salesOrder.DateDispatched = evnt.DispatchedDate;
            salesOrder.Status = SalesOrderStatus.Dispatched;

            bus.Publish<OrderDispatchedEvent>(evnt);
        }
    }
}
