﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _62_GenericsChallenge
{
    internal class TaskProcessor<TTask, TResult> where TTask : ITask<TResult>
    {
        private TTask _task;

        public TaskProcessor(TTask task)
        {
            _task = task;
        }

        public TResult Execute()
        {
            return _task.Perform();
        }


    }
}
