﻿using Transit.Addon.TM.UI.Toolbar.RoadEditor;
using Transit.Framework.Builders;

namespace Transit.Addon.TM.Tools.LaneDirectionEditor
{
    public class LaneDirectionEditorBuilder : ToolBuilder<LaneDirectionEditor>, IToolBuilder
    {
        public int Order { get { return 10; } }
        public int UIOrder { get { return 10; } }

        public string Name { get { return "Lane Direction Editor"; } }
        public string DisplayName { get { return Name; } }
        public string Description { get { return "Allows you to customize entry and exit points in intersections and junctions."; } }
        public string UICategory { get { return RoadEditorMenuMainCategoryInfo.NAME; } }

        public string ThumbnailsPath { get { return @"Tools\LaneDirectionEditor\thumbnails.png"; } }
        public string InfoTooltipPath { get { return @"Tools\LaneDirectionEditor\infotooltip.png"; } }
    }
}
