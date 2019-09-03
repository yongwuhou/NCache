//  Copyright (c) 2019 Alachisoft
//  
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//  
//     http://www.apache.org/licenses/LICENSE-2.0
//  
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License
using System;
using Alachisoft.NCache.Common.Threading;

namespace Alachisoft.NCache.Caching.Topologies.Clustered
{
    /// <summary>
    /// Asynchronous notification dispatcher.
    /// </summary>
    internal class AsyncBroadcastNotifyRemoval : AsyncProcessor.IAsyncTask
    {
        /// <summary> The listener class </summary>
        private ClusterCacheBase _parent;
        /// <summary> Message to broadcast </summary>
        private object _key, _value;
        private ItemRemoveReason _reason = ItemRemoveReason.Removed;
        private OperationContext _operationContext;
        private EventContext[] _eventContexts;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="listener"></param>
        /// <param name="data"></param>
        public AsyncBroadcastNotifyRemoval(ClusterCacheBase parent, object key, object value, ItemRemoveReason reason, OperationContext operationContext,EventContext[] eventContexts)
        {
            _parent = parent;
            _key = key;
            _value = value;
            _reason = reason;
            _operationContext = operationContext;
            _eventContexts = eventContexts;
        }

        /// <summary>
        /// Implementation of message sending.
        /// </summary>
        void AsyncProcessor.IAsyncTask.Process()
        {
            try
            {
                if (_parent != null)
                {
                    _parent.RaiseGeneric(new Function((int)ClusterCacheBase.OpCodes.NotifyBulkRemoval, new object[] { _key, _value, _reason, _operationContext,_eventContexts }));
                }
            }
            catch (Exception)
            {

            }

        }
    }
}