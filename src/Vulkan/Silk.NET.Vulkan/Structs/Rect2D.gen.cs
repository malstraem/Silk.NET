// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

namespace Silk.NET.Vulkan
{
    public unsafe struct Rect2D
    {
        public Rect2D
        (
            Offset2D offset = default,
            Extent2D extent = default
        )
        {
           Offset = offset;
           Extent = extent;
        }

/// <summary></summary>
        public Offset2D Offset;
/// <summary></summary>
        public Extent2D Extent;
    }
}
