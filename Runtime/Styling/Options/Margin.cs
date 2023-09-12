using UnityEngine.UIElements;

namespace Anvil.Styling.Options
{
    public readonly struct Margin : IOption
    {
        public Margin(float margin)
        {
            Top = margin;
            Bottom = margin;
            Right = margin;
            Left = margin;
        }

        public Margin(float top = 0, float bottom = 0, float right = 0, float left = 0)
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
            visualElement.style.marginTop = Top;
            visualElement.style.marginBottom = Bottom;
            visualElement.style.marginRight = Right;
            visualElement.style.marginLeft = Left;
        }
    }
}