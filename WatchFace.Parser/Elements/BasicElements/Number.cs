﻿using WatchFace.Parser.Attributes;

namespace WatchFace.Parser.Elements.BasicElements
{
    public class Number
    {
        [ParameterId(1)]
        public long TopLeftX { get; set; }

        [ParameterId(2)]
        public long TopLeftY { get; set; }

        [ParameterId(3)]
        public long BottomRightX { get; set; }

        [ParameterId(4)]
        public long BottomRightY { get; set; }

        [ParameterId(5)]
        public long Alignment { get; set; }

        [ParameterId(6)]
        public long Spacing { get; set; }

        [ParameterId(7)]
        [ParameterImageIndex]
        public long ImageIndex { get; set; }

        [ParameterId(8)]
        [ParameterImagesCount]
        public long ImagesCount { get; set; }
    }
}