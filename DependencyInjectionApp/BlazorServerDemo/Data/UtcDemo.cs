using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerDemo.Data
{
    public class UtcDemo : IDemo
    {
        public DateTime StartupTime { get; init; }
        public UtcDemo()
        {
            StartupTime = DateTime.UtcNow;
        }
    }
}
