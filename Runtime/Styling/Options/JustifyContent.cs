using UnityEngine.UIElements;

namespace Anvil.Styling.Options
{
    public readonly struct JustifyContent : IOption
    {
        public JustifyContent(Justify justify) => Justify = justify;

        Justify Justify { get; }

        public void Apply(VisualElement visualElement) => visualElement.style.justifyContent = Justify;
    }
}