﻿using System.Collections.Generic;
using static LoveStringH.Transliterator;

namespace LoveStringH {
    public class TrArabic {
        public static readonly RegexItem[] RegexItems = new RegexItem[] {
            new RegexItem("(?<![A-Za-z])([aiu])(?=[A-Za-z])", new Dictionary<string, string> {
                { "a", "\u0627" },
                { "i", "\u0625" },
                { "u", "\u0624" },
            }),
            new RegexItem("(?<=[A-Za-z])-(?=[A-Za-z])", ""),
            new RegexItem("..", new Dictionary<string, string> {
                { "aa", "\u0627" },
                { "th", "\u062B" },
                { "kh", "\u062E" },
                { "dh", "\u0630" },
                { "sh", "\u0634" },
                { "so", "\u0635" },
                { "do", "\u0636" },
                { "to", "\u0637" },
                { "zo", "\u0638" },
                { "uu", "\u0648" },
                { "ii", "\u064A" },

                { "a~", "\u0622" },
                { "'a", "\u0623" },
                { "'u", "\u0624" },
                { "'i", "\u0625" },
                    
                { "t~", "\u0629" },
                { "i~", "\u0649" },
                { "a'", "\u0671" },
            }),
            new RegexItem(".", new Dictionary<string, string> {
                { "b", "\u0628" },
                { "t", "\u062A" },
                { "j", "\u062C" },
                { "x", "\u062D" },
                { "d", "\u062F" },
                { "r", "\u0631" },
                { "z", "\u0632" },
                { "s", "\u0633" },
                { "o", "\u0639" },
                { "g", "\u063A" },
                { "f", "\u0641" },
                { "q", "\u0642" },
                { "k", "\u0643" },
                { "l", "\u0644" },
                { "m", "\u0645" },
                { "n", "\u0646" },
                { "h", "\u0647" },
                { "w", "\u0648" },
                { "y", "\u064A" },

                { "e", "" },
                { "a", "" },
                { "i", "" },
                { "u", "" },
                
                { "'", "\u0621" },
                { "-", "\u0640" },
            }),
        };
    }
}