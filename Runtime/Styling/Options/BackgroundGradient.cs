using Anvil.Styling.Gradients;
using UnityEngine.UIElements;

namespace Anvil.Styling.Options
{
    public readonly struct BackgroundGradient : IOption
    {
        public BackgroundGradient(Gradient gradient) => Gradient = gradient;

        Gradient Gradient { get; }

        public void Apply(VisualElement visualElement)
        {
            visualElement.style.backgroundImage = new StyleBackground(Gradient.Texture);
        }
    }
}