﻿// Copyright © Microsoft Open Technologies, Inc.
// All Rights Reserved       
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with the License. You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0

// THIS CODE IS PROVIDED ON AN *AS IS* BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING WITHOUT LIMITATION ANY IMPLIED WARRANTIES OR CONDITIONS OF TITLE, FITNESS FOR A PARTICULAR PURPOSE, MERCHANTABLITY OR NON-INFRINGEMENT.

// See the Apache 2 License for the specific language governing permissions and limitations under the License.
using System;
using Microsoft.Http2.Protocol.Framing;

namespace Microsoft.Http2.Protocol.Exceptions
{
    /// <summary>
    /// Generic protocol error exception.
    /// </summary>
    public class ProtocolError : Exception
    {
        public ResetStatusCode Code { get; set; }

        public ProtocolError(ResetStatusCode code, string message): base(message)
        {
            Code = code;
        }
    }
}
