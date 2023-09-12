using UnityEngine;
using UnityEngine.UIElements;

namespace Anvil.Styling.Options
{
    public readonly struct Area : IOption
    {
        public Area(Rect rect) => Rect = rect;

        Rect Rect { get; }

        public void Apply(VisualElement visualElement)
        {
            visualElement.style.right = Rect.max.x;
            visualElement.style.left = Rect.min.x;
            visualElement.style.top = Rect.max.y;
            visualElement.style.bottom = Rect.min.y;
        }
    }
}