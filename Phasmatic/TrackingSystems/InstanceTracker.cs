using Phasmatic.RpcValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phasmatic.TrackingSystems
{
    public class InstanceTracker
    {
        private static InstanceTracker _current = null;
        private static List<InstanceTracker> _all = new List<InstanceTracker>();

        /// <summary>
        /// Gets the current instance tracker.
        /// </summary>
        public static InstanceTracker Current
        {
            get
            {
                if (_current != null) return _current;
                _current = new InstanceTracker();
                _all.Add(_current);
                return _current;
            }
        }

        /// <summary>
        /// Gets all of the instance trackers from the current run of Phasmophobia.
        /// </summary>
        public static IEnumerable<InstanceTracker> All
        {
            get => _all.ToArray();
        }

        /// <summary>
        /// Initializes a new instance of the tracker for a new room. This should be executed every time a game is joined/entered.
        /// </summary>
        public static void NewInstance()
        {
            _current = null;
        }

        private InstanceTracker()
        {
            Started = DateTime.Now;

        }

        /// <summary>
        /// Gets the <see cref="DateTime"/> that this instance was created.
        /// </summary>
        public DateTime Started
        {
            get; private set;
        }

        /// <summary>
        /// Gets all of the executions in the current game.
        /// </summary>
        public IEnumerable<RpcExecution> Executions => rpcExecutions.ToArray(); //To keep this thread-safe, this execution is thrown to an array so another RPC can come along and update the list.

        /// <summary>
        /// Gets all of the <see cref="RpcValidator"/> of a specific type.
        /// </summary>
        /// <typeparam name="T">Type of <see cref="RpcValidator"/> to look for.</typeparam>
        /// <returns><see cref="IEnumerable{T}"/> with all of the executions that match the specific type.</returns>
        public IEnumerable<RpcExecution> GetExecutionsOf<T>() where T : RpcValidator
        {
            return rpcExecutions.Where(e => e.Validator is T).ToArray();
        }

        /// <summary>
        /// Gets <see cref="RpcValidator"/> of a specific type from the last <see cref="TimeSpan"/> that was executed.
        /// </summary>
        /// <typeparam name="T">Type of <see cref="RpcValidator"/> to look for.</typeparam>
        /// <param name="timeLimit"><see cref="TimeSpan"/> limit to look backwards.</param>
        /// <returns><see cref="IEnumerable{T}"/> with all of the executions that match the specific parameters.</returns>
        public IEnumerable<RpcExecution> GetLatestExecutionsOf<T>(TimeSpan timeLimit) where T : RpcValidator
        {
            DateTime earliest = DateTime.Now.Subtract(timeLimit);
            return rpcExecutions.Where(e => e.Validator is T).Where(e => e.Received >= earliest).ToArray();
        }

        private List<RpcExecution> rpcExecutions = new List<RpcExecution>();

        /// <summary>
        /// Adds in an RPC Execution into the tracker.
        /// </summary>
        /// <param name="execution"><see cref="RpcExecution"/> that was called.</param>
        public void AddExecution(RpcExecution execution)
        {
            rpcExecutions.Add(execution);
        }
    }
}
