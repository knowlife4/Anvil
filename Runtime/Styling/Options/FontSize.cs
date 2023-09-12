using UnityEngine.UIElements;

namespace Anvil.Styling.Options
{
    public readonly struct FontSize : IOption
    {
        public FontSize(int size) => Size = size;

        int Size { get; }
        
        public void Apply(VisualElement visualElement) => visualElement.style.fontSize = Size;
    }
}