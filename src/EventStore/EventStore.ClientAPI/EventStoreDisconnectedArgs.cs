using System;
using System.Net;

namespace EventStore.ClientAPI
{
    /// <summary>
    /// Event Arguments for the event raised when an <see cref="IEventStoreConnection"/> is 
    /// disconnected from an Event Store server.
    /// </summary>
    public class EventStoreDisconnectedArgs : EventArgs
    {
        /// <summary>
        /// The endpoint of the Event Store server from which the connection was disconnected.
        /// </summary>
        public IPEndPoint RemoteEndPoint { get; private set; }

        /// <summary>
        /// Constructs a new instance of <see cref="EventStoreDisconnectedArgs"/>.
        /// </summary>
        /// <param name="remoteEndPoint">The endpoint of the Event Store server from which the connection was disconnected.</param>
        public EventStoreDisconnectedArgs(IPEndPoint remoteEndPoint)
        {
            RemoteEndPoint = remoteEndPoint;
        }
    }
}