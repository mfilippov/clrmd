﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.Diagnostics.Runtime.MacOS
{
    internal readonly struct MachOHeader64
    {
        internal readonly int Magic;
        internal readonly MachOCpuType CpuType;
        internal readonly int CpuSubtype;
        internal readonly int FileType;
        internal readonly int NumberOfCommands;
        internal readonly int SizeOfCommands;
        internal readonly int Flags;
        internal readonly int Reserved;
    }
}
