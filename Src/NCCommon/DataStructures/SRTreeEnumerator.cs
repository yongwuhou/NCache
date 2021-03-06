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
using System.Collections;
using Alachisoft.NCache.Common.DataStructures.Clustered;

namespace Alachisoft.NCache.Common.DataStructures
{
    public class SRTreeEnumerator
    {
        private ClusteredArrayList _list;
        private IEnumerator _ide;

        public SRTreeEnumerator(ClusteredArrayList list)
        {
            _list = list;
            _ide = _list.GetEnumerator();
        }

        public bool MoveNext()
        {
            try
            {
                return _ide.MoveNext();
            }
            catch (Exception)
            {
                return false;
            }
        }

        public object Current
        {
            get { return _ide.Current; }
        }

        public void Reset()
        {
            _ide.Reset();
        }
    }
}