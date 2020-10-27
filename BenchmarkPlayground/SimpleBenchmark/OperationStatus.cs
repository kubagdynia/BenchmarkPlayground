using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleBenchmark
{
    public enum OperationStatus
    {
        Info,
        Warn,
        Error,
        Success
    }
    
    public static class OperationStatusExtension
    {
        private static readonly Dictionary<OperationStatus, string> Statuses =
            Enum.GetValues(typeof(OperationStatus)).Cast<OperationStatus>()
                .ToDictionary(status => status, status => status.ToString());

        private static readonly Dictionary<OperationStatus, string> StatusesUpperCase =
            Statuses.ToDictionary(k => k.Key, k => k.Value.ToUpper());

        public static string ToStringCode(this OperationStatus status) => Statuses[status];
		
        public static string ToStringCodeUpperCase(this OperationStatus status) => StatusesUpperCase[status];
    }
    
    
}