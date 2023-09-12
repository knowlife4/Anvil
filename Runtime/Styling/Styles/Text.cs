using Anvil.Styling.Options;
using UnityEngine;

namespace Anvil.Styling.Styles
{
    public static class Text
    {
        public static Style Title => new()
        {
            new FontSize(20),
            new FontAlignment(TextAnchor.MiddleCenter),
        };
    }
}