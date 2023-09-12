using System;
using UnityEngine;
using UnityEngine.UIElements;

namespace Anvil.Styling.Options
{
    public readonly struct FontAlignment : IOption
    {
        public FontAlignment(TextAnchor alignment) => Alignment = alignment;

        TextAnchor Alignment { get; }

        public void Apply(VisualElement visualElement) => visualElement.style.unityTextAlign = Alignment;
    }
}