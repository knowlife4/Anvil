namespace Anvil.Elements.Text
{
    public class Label : Element<UnityEngine.UIElements.Label>, IText
    {
        public Label(string text) => VisualElement = new(text);

        protected override UnityEngine.UIElements.Label VisualElement { get; }

        public string Text => VisualElement.text;
    }
}