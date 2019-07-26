using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityEngine
{
    public enum RenderTextureReadWrite
    {
        //
        // Summary:
        //     Default color space conversion based on project settings.
        Default = 0,
        //
        // Summary:
        //     Render texture contains linear (non-color) data; don't perform color conversions
        //     on it.
        Linear = 1,
        //
        // Summary:
        //     Render texture contains sRGB (color) data, perform Linear<->sRGB conversions
        //     on it.
        sRGB = 2
    }
}
