using UnityEngine.UIElements;

namespace Anvil.Styling.Options
{
    public readonly struct Grow : IOption
    {
        public Grow(bool shouldGrow) => FlexGrow = shouldGrow ? 0 : 1;

        float FlexGrow { get; }

        public void Apply(VisualElement visualElement) => visualElement.style.flexGrow = FlexGrow;
    }
}