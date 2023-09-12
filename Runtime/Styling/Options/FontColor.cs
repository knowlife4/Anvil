using UnityEngine;
using UnityEngine.UIElements;

namespace Anvil.Styling.Options
{
    public readonly struct FontColor : IOption
    {
        public FontColor(Color color) => Color = color;

        Color Color { get; }

        public void Apply(VisualElement visualElement) => visualElement.style.color = Color;
    }
}