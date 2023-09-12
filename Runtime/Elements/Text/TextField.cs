namespace Anvil.Elements.Text
{
    public class TextField : Element<UnityEngine.UIElements.TextField>
    {
        protected override UnityEngine.UIElements.TextField VisualElement { get; } = new();
    }
}