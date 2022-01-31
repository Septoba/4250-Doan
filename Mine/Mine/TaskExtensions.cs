using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mine
{
    public static class TaskExtensions
    {
        public static async void SafeFireAndForget(this Task task,
            bool returnToCallingContext, Action<Exception> onExeption = null)
        {
            try
            {
                await task.ConfigureAwait(returnToCallingContext);
            }
            // if the provided action is not null, catch and pass the thrown 
            // exception
            catch (Exception ex) when (onExeption != null)
            {
                onExeption(ex);
            }
        }
    }
}
