using UnityEngine;
using UnityEngine.UIElements;

namespace Anvil.Styling.Options
{
    public readonly struct Border : IOption
    {
        public Border(Color color, float width, float roundness)
        {
            Color = color;
            Width = width;
            Roundness = roundness;
        }

        Color Color { get; }

        float Width { get; }

        float Roundness { get; }


        public void Apply(VisualElement visualElement)
        {
            visualElement.style.borderBottomColor = Color;
            visualElement.style.borderTopColor = Color;
            visualElement.style.borderRightColor = Color;
            visualElement.style.borderLeftColor = Color;

            visualElement.style.borderBottomWidth = Width;
            visualElement.style.borderTopWidth = Width;
            visualElement.style.borderRightWidth = Width;
            visualElement.style.borderLeftWidth = Width;
            
            visualElement.style.borderBottomRightRadius = Roundness;
            visualElement.style.borderTopRightRadius = Roundness;
            visualElement.style.borderBottomLeftRadius = Roundness;
            visualElement.style.borderTopLeftRadius = Roundness;
        }
    }
}