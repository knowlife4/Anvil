using Anvil.Styling.Gradients;
using Anvil.Styling.Options;
using UnityEngine;
using UnityEngine.UIElements;
using FlexDirection = Anvil.Styling.Options.FlexDirection;

namespace Anvil.Styling.Styles
{
    public static class Group
    {
        public static Style Horizontal => new()
        {
            new FlexDirection(UnityEngine.UIElements.FlexDirection.Row),
            new JustifyContent(Justify.Center)
        };

        public static Style Vertical => new()
        {
            new FlexDirection(UnityEngine.UIElements.FlexDirection.Column)
        };

        public static Style Dark => new()
        {
            new BackgroundColor(new Color(0,0,0, .3f))
        };

        public static Style DarkFancy => new()
        {
            new BackgroundGradient(new VerticalGradient(4, new(new(0, 0, 0, .5f), 0), new(new(0, 0, 0, .2f), 1))),
            new Border(Color.black, 1, 5f)
        };

        public static Style Fill => new()
        {
            new Grow(false),
            new JustifyContent(Justify.SpaceBetween)
        };

        public static Style Spaced => new()
        {
            new Padding(3),
            new Margin(3)
        };

        public static Style Indented => new()
        {
            new Margin(left: 15)
        };
    }
}