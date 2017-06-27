using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBInterface
{
    /// <summary>
    /// Class that encapsulates the error message structure
    /// </summary>
    public class Error
    {
        /// <summary>
        /// Source of the error
        /// </summary>
        public string Source { get; set; }
        /// <summary>
        /// Error message
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// Routine where the error occurred
        /// </summary>
        public string RoutineName { get; set; }

        /// <summary>
        /// Overloaded constructor
        /// </summary>
        /// <param name="source">Internal source of the error</param>
        /// <param name="message">Error message</param>
        /// <param name="routineName">Routine where the error ocurred</param>
        public Error(string source, string message, string routineName)
        {
            this.Source = source;
            this.Message = message;
            this.RoutineName = routineName;
        }

        /// <summary>
        /// Main constructor
        /// </summary>
        public Error()
        {
            this.Source = "";
            this.Message = "";
            this.RoutineName = "";
        }
    }
}
