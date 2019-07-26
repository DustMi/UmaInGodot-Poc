using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityEngine
{
    public enum RenderTextureFormat
    {
        //
        // Summary:
        //     Color render texture format, 8 bits per channel.
        ARGB32 = 0,
        //
        // Summary:
        //     A depth render texture format.
        Depth = 1,
        //
        // Summary:
        //     Color render texture format, 16 bit floating point per channel.
        ARGBHalf = 2,
        //
        // Summary:
        //     A native shadowmap render texture format.
        Shadowmap = 3,
        //
        // Summary:
        //     Color render texture format.
        RGB565 = 4,
        //
        // Summary:
        //     Color render texture format, 4 bit per channel.
        ARGB4444 = 5,
        //
        // Summary:
        //     Color render texture format, 1 bit for Alpha channel, 5 bits for Red, Green and
        //     Blue channels.
        ARGB1555 = 6,
        //
        // Summary:
        //     Default color render texture format: will be chosen accordingly to Frame Buffer
        //     format and Platform.
        Default = 7,
        //
        // Summary:
        //     Color render texture format. 10 bits for colors, 2 bits for alpha.
        ARGB2101010 = 8,
        //
        // Summary:
        //     Default HDR color render texture format: will be chosen accordingly to Frame
        //     Buffer format and Platform.
        DefaultHDR = 9,
        //
        // Summary:
        //     Four color render texture format, 16 bits per channel, fixed point, unsigned
        //     normalized.
        ARGB64 = 10,
        //
        // Summary:
        //     Color render texture format, 32 bit floating point per channel.
        ARGBFloat = 11,
        //
        // Summary:
        //     Two color (RG) render texture format, 32 bit floating point per channel.
        RGFloat = 12,
        //
        // Summary:
        //     Two color (RG) render texture format, 16 bit floating point per channel.
        RGHalf = 13,
        //
        // Summary:
        //     Scalar (R) render texture format, 32 bit floating point.
        RFloat = 14,
        //
        // Summary:
        //     Scalar (R) render texture format, 16 bit floating point.
        RHalf = 15,
        //
        // Summary:
        //     Single channel (R) render texture format, 8 bit integer.
        R8 = 16,
        //
        // Summary:
        //     Four channel (ARGB) render texture format, 32 bit signed integer per channel.
        ARGBInt = 17,
        //
        // Summary:
        //     Two channel (RG) render texture format, 32 bit signed integer per channel.
        RGInt = 18,
        //
        // Summary:
        //     Scalar (R) render texture format, 32 bit signed integer.
        RInt = 19,
        //
        // Summary:
        //     Color render texture format, 8 bits per channel.
        BGRA32 = 20,
        //
        // Summary:
        //     Color render texture format. R and G channels are 11 bit floating point, B channel
        //     is 10 bit floating point.
        RGB111110Float = 22,
        //
        // Summary:
        //     Two color (RG) render texture format, 16 bits per channel, fixed point, unsigned
        //     normalized.
        RG32 = 23,
        //
        // Summary:
        //     Four channel (RGBA) render texture format, 16 bit unsigned integer per channel.
        RGBAUShort = 24,
        //
        // Summary:
        //     Two channel (RG) render texture format, 8 bits per channel.
        RG16 = 25,
        //
        // Summary:
        //     Color render texture format, 10 bit per channel, extended range.
        BGRA10101010_XR = 26,
        //
        // Summary:
        //     Color render texture format, 10 bit per channel, extended range.
        BGR101010_XR = 27,
        //
        // Summary:
        //     Single channel (R) render texture format, 16 bit integer.
        R16 = 28
    }
}
