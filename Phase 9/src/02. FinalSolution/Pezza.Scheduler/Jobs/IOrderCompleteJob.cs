﻿namespace Pezza.Scheduler.Jobs;

using System.Threading.Tasks;

public interface IOrderCompleteJob
{
    Task SendNotificationAsync();
}
