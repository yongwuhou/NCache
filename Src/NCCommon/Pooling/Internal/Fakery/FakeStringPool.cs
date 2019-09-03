﻿//  Copyright (c) 2019 Alachisoft
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

using Alachisoft.NCache.Common.Pooling.Stats;

namespace Alachisoft.NCache.Common.Pooling.Internal
{
    internal sealed class FakeStringPool : IStringPool
    {
        public string PoolName
        {
            get => "FakeStringPool";
        }

        public string GetString(string key) => key;

        public void ResetPool()
        {
        }

        public void TrimPool(long count)
        {
        }

        StringPoolStats IStringPool.GetStats()
        {
            return new StringPoolStats
            {
                StringsPooled = 0
            };
        }
    }
}
