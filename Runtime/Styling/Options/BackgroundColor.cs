using UnityEngine;
using UnityEngine.UIElements;

namespace Anvil.Styling.Options
{
    public readonly struct BackgroundColor : IOption
    {
        public BackgroundColor(Color color) => Color = color;

        Color Color { get; }

        public void Apply(VisualElement visualElement) => visualElement.style.backgroundColor = Color;
    }
}