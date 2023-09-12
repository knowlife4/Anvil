using UnityEngine.UIElements;

namespace Anvil.Styling.Options
{
    public readonly struct FlexDirection : IOption
    {
        public FlexDirection(UnityEngine.UIElements.FlexDirection direction) => Direction = direction;

        UnityEngine.UIElements.FlexDirection Direction { get; }

        public void Apply(VisualElement visualElement) => visualElement.style.flexDirection = Direction;
    }
}