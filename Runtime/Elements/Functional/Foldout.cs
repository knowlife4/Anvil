namespace Anvil.Elements.Functional
{
    public class Foldout : Element<UnityEngine.UIElements.Foldout>
    {
        protected override UnityEngine.UIElements.Foldout VisualElement { get; } = new();
    }
}