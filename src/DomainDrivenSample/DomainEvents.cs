using System;
using System.Collections.Generic;
using System.ComponentModel;
using DomainDrivenSample.Interfaces;

namespace DomainDrivenSample
{
    public static class DomainEvents
    {
        [ThreadStatic]
        private static List<Delegate> actions;
        public static IContainer Container { get; set; }
        public static void Raise<T>(T args) where T : IDomainEvent
        {
            //foreach (var handler in Container.GetAllInstances<IHandle<T>>())
            //{
            //    handler.Handle(args);
            //}

            //if (actions != null)
            //{
            //    foreach (var action in actions)
            //    {
            //        if (action is Action<T>)
            //        {
            //            ((Action<T>)action)(args);
            //        }
            //    }
            //}
        }
    }
}
