using System;

namespace Anvil.Elements.Functional
{
    public class Button : Element<UnityEngine.UIElements.Button>
    {
        public Button(Action onPress) => VisualElement = new(onPress);

        public Button() => VisualElement = new();

        protected override UnityEngine.UIElements.Button VisualElement { get; }
    }
}