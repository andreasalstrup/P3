using System;
using System.Threading;
using System.Threading.Tasks;

namespace BlazorApp.DataStreaming
{
    public class DEMORealtimeService
    {
        private int _a;
        public int a
        {
            get { return _a; }
            set 
            { 
                _a = value;
                // If event is not NULL, Invoke it
                UpdateEvent?.Invoke();
            }
        }
        private int _b;

        public int b
        {
            get { return _b; }
            set 
            { 
                _b = value;
                // If event is not NULL, Invoke it
                UpdateEvent?.Invoke();
            }
        }
        
        // event is triggered when new values are set
        public event Func<Task> UpdateEvent;

        public async void Loop()
        {
            for (int i = 0; i <= 1000; i++)
            {
                a = i;
                UpdateEvent?.Invoke();
                await Task.Delay(1000);
            }
        }
        
    }
}