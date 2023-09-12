using UnityEngine.UIElements;

namespace Anvil.Styling.Options
{
    public readonly struct Position : IOption
    {
        public void Apply(VisualElement visualElement)
        {
            visualElement.style.position = UnityEngine.UIElements.Position.Absolute;
        }
    }
}