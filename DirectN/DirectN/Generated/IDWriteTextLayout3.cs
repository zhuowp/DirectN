﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\dwrite_3.h(1729,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("07ddcd52-020e-4de8-ac33-6c953d83f92d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteTextLayout3 : IDWriteTextLayout2
    {
        // IDWriteTextFormat
        [PreserveSig]
        new HRESULT SetTextAlignment(DWRITE_TEXT_ALIGNMENT textAlignment);
        
        [PreserveSig]
        new HRESULT SetParagraphAlignment(DWRITE_PARAGRAPH_ALIGNMENT paragraphAlignment);
        
        [PreserveSig]
        new HRESULT SetWordWrapping(DWRITE_WORD_WRAPPING wordWrapping);
        
        [PreserveSig]
        new HRESULT SetReadingDirection(DWRITE_READING_DIRECTION readingDirection);
        
        [PreserveSig]
        new HRESULT SetFlowDirection(DWRITE_FLOW_DIRECTION flowDirection);
        
        [PreserveSig]
        new HRESULT SetIncrementalTabStop(float incrementalTabStop);
        
        [PreserveSig]
        new HRESULT SetTrimming(/* _In_ */ ref DWRITE_TRIMMING trimmingOptions, /* _In_opt_ */ IDWriteInlineObject trimmingSign);
        
        [PreserveSig]
        new HRESULT SetLineSpacing(DWRITE_LINE_SPACING_METHOD lineSpacingMethod, float lineSpacing, float baseline);
        
        [PreserveSig]
        new DWRITE_TEXT_ALIGNMENT GetTextAlignment();
        
        [PreserveSig]
        new DWRITE_PARAGRAPH_ALIGNMENT GetParagraphAlignment();
        
        [PreserveSig]
        new DWRITE_WORD_WRAPPING GetWordWrapping();
        
        [PreserveSig]
        new DWRITE_READING_DIRECTION GetReadingDirection();
        
        [PreserveSig]
        new DWRITE_FLOW_DIRECTION GetFlowDirection();
        
        [PreserveSig]
        new float GetIncrementalTabStop();
        
        [PreserveSig]
        new HRESULT GetTrimming(/* _Out_ */ out DWRITE_TRIMMING trimmingOptions, /* _COM_Outptr_ */ out IDWriteInlineObject trimmingSign);
        
        [PreserveSig]
        new HRESULT GetLineSpacing(/* _Out_ */ out DWRITE_LINE_SPACING_METHOD lineSpacingMethod, /* _Out_ */ out float lineSpacing, /* _Out_ */ out float baseline);
        
        [PreserveSig]
        new HRESULT GetFontCollection(/* _COM_Outptr_ */ out IDWriteFontCollection fontCollection);
        
        [PreserveSig]
        new uint GetFontFamilyNameLength();
        
        [PreserveSig]
        new HRESULT GetFontFamilyName(/* _Out_writes_z_(nameSize) */ [MarshalAs(UnmanagedType.LPWStr)] string fontFamilyName, uint nameSize);
        
        [PreserveSig]
        new DWRITE_FONT_WEIGHT GetFontWeight();
        
        [PreserveSig]
        new DWRITE_FONT_STYLE GetFontStyle();
        
        [PreserveSig]
        new DWRITE_FONT_STRETCH GetFontStretch();
        
        [PreserveSig]
        new float GetFontSize();
        
        [PreserveSig]
        new uint GetLocaleNameLength();
        
        [PreserveSig]
        new HRESULT GetLocaleName(/* _Out_writes_z_(nameSize) */ [MarshalAs(UnmanagedType.LPWStr)] string localeName, uint nameSize);
        
        // IDWriteTextLayout
        [PreserveSig]
        new HRESULT SetMaxWidth(float maxWidth);
        
        [PreserveSig]
        new HRESULT SetMaxHeight(float maxHeight);
        
        [PreserveSig]
        new HRESULT SetFontCollection(/* _In_ */ IDWriteFontCollection fontCollection, DWRITE_TEXT_RANGE textRange);
        
        [PreserveSig]
        new HRESULT SetFontFamilyName(/* _In_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string fontFamilyName, DWRITE_TEXT_RANGE textRange);
        
        [PreserveSig]
        new HRESULT SetFontWeight(DWRITE_FONT_WEIGHT fontWeight, DWRITE_TEXT_RANGE textRange);
        
        [PreserveSig]
        new HRESULT SetFontStyle(DWRITE_FONT_STYLE fontStyle, DWRITE_TEXT_RANGE textRange);
        
        [PreserveSig]
        new HRESULT SetFontStretch(DWRITE_FONT_STRETCH fontStretch, DWRITE_TEXT_RANGE textRange);
        
        [PreserveSig]
        new HRESULT SetFontSize(float fontSize, DWRITE_TEXT_RANGE textRange);
        
        [PreserveSig]
        new HRESULT SetUnderline(bool hasUnderline, DWRITE_TEXT_RANGE textRange);
        
        [PreserveSig]
        new HRESULT SetStrikethrough(bool hasStrikethrough, DWRITE_TEXT_RANGE textRange);
        
        [PreserveSig]
        new HRESULT SetDrawingEffect([MarshalAs(UnmanagedType.IUnknown)] object drawingEffect, DWRITE_TEXT_RANGE textRange);
        
        [PreserveSig]
        new HRESULT SetInlineObject(/* _In_ */ IDWriteInlineObject inlineObject, DWRITE_TEXT_RANGE textRange);
        
        [PreserveSig]
        new HRESULT SetTypography(/* _In_ */ IDWriteTypography typography, DWRITE_TEXT_RANGE textRange);
        
        [PreserveSig]
        new HRESULT SetLocaleName(/* _In_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string localeName, DWRITE_TEXT_RANGE textRange);
        
        [PreserveSig]
        new float GetMaxWidth();
        
        [PreserveSig]
        new float GetMaxHeight();
        
        [PreserveSig]
        new HRESULT GetFontCollection(uint currentPosition, /* _COM_Outptr_ */ out IDWriteFontCollection fontCollection, /* _Out_opt_ */ out DWRITE_TEXT_RANGE textRange);
        
        [PreserveSig]
        new HRESULT GetFontFamilyNameLength(uint currentPosition, /* _Out_ */ out uint nameLength, /* _Out_opt_ */ out DWRITE_TEXT_RANGE textRange);
        
        [PreserveSig]
        new HRESULT GetFontFamilyName(uint currentPosition, /* _Out_writes_z_(nameSize) */ [MarshalAs(UnmanagedType.LPWStr)] string fontFamilyName, uint nameSize, /* _Out_opt_ */ out DWRITE_TEXT_RANGE textRange);
        
        [PreserveSig]
        new HRESULT GetFontWeight(uint currentPosition, /* _Out_ */ out DWRITE_FONT_WEIGHT fontWeight, /* _Out_opt_ */ out DWRITE_TEXT_RANGE textRange);
        
        [PreserveSig]
        new HRESULT GetFontStyle(uint currentPosition, /* _Out_ */ out DWRITE_FONT_STYLE fontStyle, /* _Out_opt_ */ out DWRITE_TEXT_RANGE textRange);
        
        [PreserveSig]
        new HRESULT GetFontStretch(uint currentPosition, /* _Out_ */ out DWRITE_FONT_STRETCH fontStretch, /* _Out_opt_ */ out DWRITE_TEXT_RANGE textRange);
        
        [PreserveSig]
        new HRESULT GetFontSize(uint currentPosition, /* _Out_ */ out float fontSize, /* _Out_opt_ */ out DWRITE_TEXT_RANGE textRange);
        
        [PreserveSig]
        new HRESULT GetUnderline(uint currentPosition, /* _Out_ */ out bool hasUnderline, /* _Out_opt_ */ out DWRITE_TEXT_RANGE textRange);
        
        [PreserveSig]
        new HRESULT GetStrikethrough(uint currentPosition, /* _Out_ */ out bool hasStrikethrough, /* _Out_opt_ */ out DWRITE_TEXT_RANGE textRange);
        
        [PreserveSig]
        new HRESULT GetDrawingEffect(uint currentPosition, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object drawingEffect, /* _Out_opt_ */ out DWRITE_TEXT_RANGE textRange);
        
        [PreserveSig]
        new HRESULT GetInlineObject(uint currentPosition, /* _COM_Outptr_ */ out IDWriteInlineObject inlineObject, /* _Out_opt_ */ out DWRITE_TEXT_RANGE textRange);
        
        [PreserveSig]
        new HRESULT GetTypography(uint currentPosition, /* _COM_Outptr_ */ out IDWriteTypography typography, /* _Out_opt_ */ out DWRITE_TEXT_RANGE textRange);
        
        [PreserveSig]
        new HRESULT GetLocaleNameLength(uint currentPosition, /* _Out_ */ out uint nameLength, /* _Out_opt_ */ out DWRITE_TEXT_RANGE textRange);
        
        [PreserveSig]
        new HRESULT GetLocaleName(uint currentPosition, /* _Out_writes_z_(nameSize) */ [MarshalAs(UnmanagedType.LPWStr)] string localeName, uint nameSize, /* _Out_opt_ */ out DWRITE_TEXT_RANGE textRange);
        
        [PreserveSig]
        new HRESULT Draw(/* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object clientDrawingContext, /* _In_ */ IDWriteTextRenderer renderer, float originX, float originY);
        
        [PreserveSig]
        new HRESULT GetLineMetrics(/* _Out_writes_opt_(maxLineCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] DWRITE_LINE_METRICS[] lineMetrics, uint maxLineCount, /* _Out_ */ out uint actualLineCount);
        
        [PreserveSig]
        new HRESULT GetMetrics(/* _Out_ */ out DWRITE_TEXT_METRICS textMetrics);
        
        [PreserveSig]
        new HRESULT GetOverhangMetrics(/* _Out_ */ out DWRITE_OVERHANG_METRICS overhangs);
        
        [PreserveSig]
        new HRESULT GetClusterMetrics(/* _Out_writes_opt_(maxClusterCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] DWRITE_CLUSTER_METRICS[] clusterMetrics, uint maxClusterCount, /* _Out_ */ out uint actualClusterCount);
        
        [PreserveSig]
        new HRESULT DetermineMinWidth(/* _Out_ */ out float minWidth);
        
        [PreserveSig]
        new HRESULT HitTestPoint(float pointX, float pointY, /* _Out_ */ out bool isTrailingHit, /* _Out_ */ out bool isInside, /* _Out_ */ out DWRITE_HIT_TEST_METRICS hitTestMetrics);
        
        [PreserveSig]
        new HRESULT HitTestTextPosition(uint textPosition, bool isTrailingHit, /* _Out_ */ out float pointX, /* _Out_ */ out float pointY, /* _Out_ */ out DWRITE_HIT_TEST_METRICS hitTestMetrics);
        
        [PreserveSig]
        new HRESULT HitTestTextRange(uint textPosition, uint textLength, float originX, float originY, /* _Out_writes_opt_(maxHitTestMetricsCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] DWRITE_HIT_TEST_METRICS[] hitTestMetrics, uint maxHitTestMetricsCount, /* _Out_ */ out uint actualHitTestMetricsCount);
        
        // IDWriteTextLayout1
        [PreserveSig]
        new HRESULT SetPairKerning(bool isPairKerningEnabled, DWRITE_TEXT_RANGE textRange);
        
        [PreserveSig]
        new HRESULT GetPairKerning(uint currentPosition, /* _Out_ */ out bool isPairKerningEnabled, /* _Out_opt_ */ out DWRITE_TEXT_RANGE textRange);
        
        [PreserveSig]
        new HRESULT SetCharacterSpacing(float leadingSpacing, float trailingSpacing, float minimumAdvanceWidth, DWRITE_TEXT_RANGE textRange);
        
        [PreserveSig]
        new HRESULT GetCharacterSpacing(uint currentPosition, /* _Out_ */ out float leadingSpacing, /* _Out_ */ out float trailingSpacing, /* _Out_ */ out float minimumAdvanceWidth, /* _Out_opt_ */ out DWRITE_TEXT_RANGE textRange);
        
        // IDWriteTextLayout2
        [PreserveSig]
        new HRESULT GetMetrics(/* _Out_ */ out DWRITE_TEXT_METRICS1 textMetrics);
        
        [PreserveSig]
        new HRESULT SetVerticalGlyphOrientation(DWRITE_VERTICAL_GLYPH_ORIENTATION glyphOrientation);
        
        [PreserveSig]
        new DWRITE_VERTICAL_GLYPH_ORIENTATION GetVerticalGlyphOrientation();
        
        [PreserveSig]
        new HRESULT SetLastLineWrapping(bool isLastLineWrappingEnabled);
        
        [PreserveSig]
        new bool GetLastLineWrapping();
        
        [PreserveSig]
        new HRESULT SetOpticalAlignment(DWRITE_OPTICAL_ALIGNMENT opticalAlignment);
        
        [PreserveSig]
        new DWRITE_OPTICAL_ALIGNMENT GetOpticalAlignment();
        
        [PreserveSig]
        new HRESULT SetFontFallback(IDWriteFontFallback fontFallback);
        
        [PreserveSig]
        new HRESULT GetFontFallback(/* __out */ out IDWriteFontFallback fontFallback);
        
        // IDWriteTextLayout3
        [PreserveSig]
        HRESULT InvalidateLayout();
        
        [PreserveSig]
        HRESULT SetLineSpacing(/* _In_ */ ref DWRITE_LINE_SPACING lineSpacingOptions);
        
        [PreserveSig]
        HRESULT GetLineSpacing(/* _Out_ */ out DWRITE_LINE_SPACING lineSpacingOptions);
        
        [PreserveSig]
        HRESULT GetLineMetrics(/* _Out_writes_to_opt_(maxLineCount, *actualLineCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] DWRITE_LINE_METRICS1[] lineMetrics, uint maxLineCount, /* _Out_ */ out uint actualLineCount);
    }
}
