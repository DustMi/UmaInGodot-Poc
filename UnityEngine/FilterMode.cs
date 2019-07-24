using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityEngine
{
    //
    // Summary:
    //     Filtering mode for textures. Corresponds to the settings in a.
    public enum FilterMode
    {
        //
        // Summary:
        //     Point filtering - texture pixels become blocky up close.
        Point = 0,
        //
        // Summary:
        //     Bilinear filtering - texture samples are averaged.
        Bilinear = 1,
        //
        // Summary:
        //     Trilinear filtering - texture samples are averaged and also blended between mipmap
        //     levels.
        Trilinear = 2
    }
}