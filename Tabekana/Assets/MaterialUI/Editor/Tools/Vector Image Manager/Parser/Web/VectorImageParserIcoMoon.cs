//  Copyright 2016 MaterialUI for Unity http://materialunity.com
//  Please see license file for terms and conditions of use, and more information.

using System;
using System.Diagnostics;
using Debug = UnityEngine.Debug;

namespace MaterialUI
{
    public class VectorImageParserIcoMoon : VectorImageFontParser
    {
        protected override string GetIconFontUrl()
        {
            return "https://github.com/Keyamoon/IcoMoon-Free/blob/master/Font/IcoMoon-Free.ttf?raw=true";
        }

        protected override string GetIconFontLicenseUrl()
        {
            return "https://github.com/Keyamoon/IcoMoon-Free/blob/master/License.txt?raw=true";
        }

        protected override string GetIconFontDataUrl()
        {
            return "https://github.com/Keyamoon/IcoMoon-Free/raw/master/Font/selection.json?raw=true";
        }

        public override string GetWebsite()
        {
            return "https://icomoon.io/#preview-free";
        }

        public override string GetFontName()
        {
            return "IcoMoon";
        }

        protected override VectorImageSet GenerateIconSet(string fontDataContent)
        {
            return GenerateSpecificIconSet(fontDataContent);
        }

        public static VectorImageSet GenerateSpecificIconSet(string fontDataContent)
        {
            VectorImageSet vectorImageSet = new VectorImageSet();

            string[] sections = fontDataContent.Split(new[] { "}" }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < sections.Length; i++)
            {
                if (i < 2) continue;

                Glyph currentGlyph = new Glyph();

                currentGlyph.name = sections[i].Split(new[] { ":" }, StringSplitOptions.RemoveEmptyEntries)[0].Replace(".icon-", "").Replace("\n", "").Replace(" ", "");

                if (string.IsNullOrEmpty(currentGlyph.name)) continue;

                currentGlyph.unicode = sections[i].Split(new[] { "\"" }, StringSplitOptions.RemoveEmptyEntries)[1].Replace("e", "E").Replace(@"\", "");

                vectorImageSet.iconGlyphList.Add(currentGlyph);
            }

            return vectorImageSet;
        }

        protected override string ExtractLicense(string fontDataLicenseContent)
        {
            return fontDataLicenseContent;
        }
    }
}
