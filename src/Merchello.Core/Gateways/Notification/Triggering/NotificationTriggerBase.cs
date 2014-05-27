﻿using System.Collections.Generic;
using Merchello.Core.Observation;

namespace Merchello.Core.Gateways.Notification.Triggering
{
    /// <summary>
    /// Defines the <see cref="NotificationTriggerBase{TInput, TMonitor}"/>
    /// </summary>
    /// <typeparam name="TInput">The type passed to the trigger</typeparam>
    /// <typeparam name="TMonitor">The type of the monitor</typeparam>
    public abstract class NotificationTriggerBase<TInput, TMonitor> : ObservableTriggerBase<TMonitor>
    {
        /// <summary>
        /// Value to pass to the notification monitors
        /// </summary>
        public virtual void Update(TInput model)
        {
            Update(model, new string[]{});
        }

        /// <summary>
        /// Value to pass to the notification monitors
        /// </summary>
        public abstract void Update(TInput model, IEnumerable<string> contacts);
    }

}