using System.Collections;

namespace MyLevel
{
    public interface ICounter
    {
        public bool IsON { get; set; }
        void CounterStart();
        
    }
}