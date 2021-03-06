﻿using System;

namespace Nsb.Commands
{
    /// <summary>
    /// NOTE: no need for ICommand implementation
    /// </summary>
    public class ProcessOrderCommand
    {
        public Guid OrderId { get; set; }
        public string Article { get; set; } 
        public string Description { get; set; }
        public int Count { get; set; }
        public int Total { get; set; }
    }
}
