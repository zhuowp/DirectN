﻿using System;

namespace DirectN
{
    [Flags]
    public enum PFM
    {
        PFM_STARTINDENT = 0x00000001,
        PFM_RIGHTINDENT = 0x00000002,
        PFM_OFFSET = 0x00000004,
        PFM_ALIGNMENT = 0x00000008,
        PFM_TABSTOPS = 0x00000010,
        PFM_NUMBERING = 0x00000020,
        PFM_OFFSETINDENT = unchecked((int)0x80000000),
        PFM_SPACEBEFORE = 0x00000040,
        PFM_SPACEAFTER = 0x00000080,
        PFM_LINESPACING = 0x00000100,
        PFM_STYLE = 0x00000400,
        PFM_BORDER = 0x00000800,
        PFM_SHADING = 0x00001000,
        PFM_NUMBERINGSTYLE = 0x00002000,
        PFM_NUMBERINGTAB = 0x00004000,
        PFM_NUMBERINGSTART = 0x00008000,
        PFM_RTLPARA = 0x00010000,
        PFM_KEEP = 0x00020000,
        PFM_KEEPNEXT = 0x00040000,
        PFM_PAGEBREAKBEFORE = 0x00080000,
        PFM_NOLINENUMBER = 0x00100000,
        PFM_NOWIDOWCONTROL = 0x00200000,
        PFM_DONOTHYPHEN = 0x00400000,
        PFM_SIDEBYSIDE = 0x00800000,
        PFM_COLLAPSED = 0x01000000,
        PFM_OUTLINELEVEL = 0x02000000,
        PFM_BOX = 0x04000000,
        PFM_RESERVED2 = 0x08000000,
        PFM_TABLEROWDELIMITER = 0x10000000,
        PFM_TEXTWRAPPINGBREAK = 0x20000000,
        PFM_TABLE = 0x40000000,
        PFM_ALL = (PFM_STARTINDENT | PFM_RIGHTINDENT | PFM_OFFSET | PFM_ALIGNMENT | PFM_TABSTOPS | PFM_NUMBERING | PFM_OFFSETINDENT | PFM_RTLPARA),
        PFM_EFFECTS = (PFM_RTLPARA | PFM_KEEP | PFM_KEEPNEXT | PFM_TABLE | PFM_PAGEBREAKBEFORE | PFM_NOLINENUMBER | PFM_NOWIDOWCONTROL | PFM_DONOTHYPHEN | PFM_SIDEBYSIDE | PFM_TABLE | PFM_TABLEROWDELIMITER),
        PFM_ALL2 = (PFM_ALL | PFM_EFFECTS | PFM_SPACEBEFORE | PFM_SPACEAFTER | PFM_LINESPACING | PFM_STYLE | PFM_SHADING | PFM_BORDER | PFM_NUMBERINGTAB | PFM_NUMBERINGSTART | PFM_NUMBERINGSTYLE),
    }
}
