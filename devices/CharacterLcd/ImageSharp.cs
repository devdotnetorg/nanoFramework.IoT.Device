﻿// This is a class added speifically for nanoFramework so we dont need to include the full fat ImageSharp lib!

using System;

namespace SixLabors.ImageSharp
{
    /// <summary>
    /// Stores an ordered pair of integers, which specify a height and width.
    /// </summary>
    /// <remarks>
    /// This struct is fully mutable. This is done (against the guidelines) for the sake of performance,
    /// as it avoids the need to create new values for modification operations.
    /// </remarks>
    public struct Size
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public Size(int width, int height)
        {
            Width = width;
            Height = height;
        }

    }
}
