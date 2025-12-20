using System;
using System.Linq;
using System.Collections.Generic;

public static class StringExt
{
    public static string ToAlternatingCase(this string s)
    {
        // Flip each alphabetic char; leave others untouched.
        return new string(s.Select(ch =>
            char.IsLetter(ch)
                ? (char.IsLower(ch) ? char.ToUpper(ch) : char.ToLower(ch))
                : ch
        ).ToArray());
    }
}