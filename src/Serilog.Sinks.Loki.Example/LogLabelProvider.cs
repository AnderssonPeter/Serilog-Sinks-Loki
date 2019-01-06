using System.Collections.Generic;
using Serilog.Sinks.Loki.Labels;

namespace Serilog.Sinks.Loki.Example
{
    public class LogLabelProvider : ILogLabelProvider
    {
        public IList<LokiLabel> GetLabels()
        {
            return new List<LokiLabel>
            {
                new LokiLabel
                {
                    Key = "app",
                    Value = "demo"
                },
                new LokiLabel
                {
                    Key = "namespace",
                    Value = "prod"
                }
            };
        }
    }
}