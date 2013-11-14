using System;

namespace EventStore.ClientAPI
{
    /// <summary>
    /// Event Arguments for the event raised when an <see cref="IEventStoreConnection"/> is 
    /// disconnected from an Event Store server.
    /// </summary>
    public class ClientClosedArgs : EventArgs
    {
        /// <summary>
        /// A description of the reason the connection was closed if closing was initiated by the server or client API directly
        /// rather than by calling <see cref="IEventStoreConnection.Close"/>.
        /// </summary>
        public string Reason { get; private set; }

        /// <summary>
        /// The <see cref="IEventStoreConnection"/> responsible for raising the event.
        /// </summary>
        public IEventStoreConnection Connection { get; private set; }

        /// <summary>
        /// Constructs a new instance of <see cref="ClientClosedArgs"/>.
        /// </summary>
        /// <param name="connection">The <see cref="IEventStoreConnection"/> responsible for raising the event.</param>
        /// <param name="reason">A description of the reason the connection was closed.</param>
        public ClientClosedArgs(IEventStoreConnection connection, string reason)
        {
            Connection = connection;
            Reason = reason;
        }
    }
}