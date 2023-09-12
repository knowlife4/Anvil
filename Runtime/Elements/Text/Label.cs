namespace Anvil.Elements.Text
{
    public class Label : Element<UnityEngine.UIElements.Label>
    {
        public Label(string text) => VisualElement = new(text);

        protected override UnityEngine.UIElements.Label VisualElement { get; }
    }
}