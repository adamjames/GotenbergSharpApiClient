﻿// CaptiveAire.Gotenberg.App.API.Sharp.Client - Copyright (c) 2019 CaptiveAire

namespace CaptiveAire.Gotenberg.App.API.Sharp.Client.Extensions
{
    /// <summary>
    /// 
    /// </summary>
    public static class StringExtensions
    {
        // ReSharper disable once UnusedMember.Global
        /// <summary>
        /// Determines whether this instance is set with a non null/non whitespace value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        ///   <c>true</c> if the specified value is set; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsSet(this string value) => !value.IsNotSet();

        /// <summary>
        /// Determines whether this instance is set with a non null/non whitespace value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        ///   <c>true</c> if [is not set] [the specified value]; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsNotSet(this string value) => string.IsNullOrWhiteSpace(value);
    }
}