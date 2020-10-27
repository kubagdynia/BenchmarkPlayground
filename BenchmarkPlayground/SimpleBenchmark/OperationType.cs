using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleBenchmark
{
    public enum OperationType
    {
        Import,
        Update,
        Send
    }
    
    public static class OperationTypeExtension
    {
        private static readonly Dictionary<OperationType, string> Types =
            Enum.GetValues(typeof(OperationType)).Cast<OperationType>()
                .ToDictionary(type => type, type => type.ToString());
		
        private static readonly Dictionary<OperationType, string> TypesUpperCase =
            Types.ToDictionary(k => k.Key, k => k.Value.ToUpper());
		
        public static string ToStringCode(this OperationType type) => Types[type];
		
        public static string ToStringCodeUpperCase(this OperationType type) => TypesUpperCase[type];
    }
}