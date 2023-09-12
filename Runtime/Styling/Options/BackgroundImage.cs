using UnityEngine;
using UnityEngine.UIElements;

namespace Anvil.Styling.Options
{
    public readonly struct BackgroundImage : IOption
    {
        public BackgroundImage(Texture2D texture) => Texture = texture;

        Texture2D Texture { get; }

        public void Apply(VisualElement visualElement)
        {
            visualElement.style.backgroundImage = new StyleBackground(Texture);
        }
    }
}