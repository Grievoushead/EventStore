using System;

namespace EventStore.ClientAPI
{
    /// <summary>
    /// Event Arguments for the event raised when an <see cref="IEventStoreConnection"/> fails 
    /// to authenticate against an Event Store server.
    /// </summary>
    public class ClientAuthenticationFailedArgs : EventArgs
    {
        /// <summary>
        /// A reason for authentication failure, if known.
        /// </summary>
        public string Reason { get; private set; }

        /// <summary>
        /// The <see cref="IEventStoreConnection"/> responsible for raising the event.
        /// </summary>
        public IEventStoreConnection Connection { get; private set; }

        /// <summary>
        /// Constructs a new instance of <see cref="ClientAuthenticationFailedArgs"/>.
        /// </summary>
        /// <param name="connection">The <see cref="IEventStoreConnection"/> responsible for raising the event.</param>
        /// <param name="reason">A reason for authentication failure, if known.</param>
        public ClientAuthenticationFailedArgs(IEventStoreConnection connection, string reason)
        {
            Connection = connection;
            Reason = reason;
        }
    }
}