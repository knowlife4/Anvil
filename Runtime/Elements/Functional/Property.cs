using UnityEditor;
using UnityEditor.UIElements;

namespace Anvil.Elements.Functional
{
    public class Property : Element<PropertyField>
    {
        public Property(SerializedProperty property, string label = null) => VisualElement = new(property, label ?? property.displayName);

        protected override PropertyField VisualElement { get; }
    }
}