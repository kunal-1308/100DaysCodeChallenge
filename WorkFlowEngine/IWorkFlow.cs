﻿using System.Collections.Generic;

namespace WorkFlow_Engine
{
    public interface IWorkFlow
    {
        void Add(IActivity activity);
        void Remove(IActivity activity);

        IEnumerable<IActivity> GetActivities();
    }
}
