namespace Anvil.Elements.Text
{
    public class TextField : Element<UnityEngine.UIElements.TextField>, IText
    {
        protected override UnityEngine.UIElements.TextField VisualElement { get; } = new();
        
        public string Text => VisualElement.text;
    }
}