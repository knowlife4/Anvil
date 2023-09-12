using UnityEngine.UIElements;

namespace Anvil.Styling.Options
{
    public readonly struct Padding : IOption
    {
        public Padding(float padding)
        {
            Top = padding;
            Bottom = padding;
            Right = padding;
            Left = padding;
        }

        public Padding(float top = 0, float bottom = 0, float right = 0, float left = 0)
        {
            Top = top;
            Bottom = bottom;
            Right = right;
            Left = left;
        }

        float Top { get; }

        float Bottom { get; }

        float Right { get; }

        float Left { get; }

        public void Apply(VisualElement visualElement)
        {
            visualElement.style.paddingTop = Top;
            visualElement.style.paddingBottom = Bottom;
            visualElement.style.paddingRight = Right;
            visualElement.style.paddingLeft = Left;
        }
    }
}