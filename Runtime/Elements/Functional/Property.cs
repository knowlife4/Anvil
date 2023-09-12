using UnityEditor;
using UnityEditor.UIElements;

namespace Anvil.Elements.Functional
{
    public class Property : Element<PropertyField>
    {
        public Property(SerializedProperty property) => VisualElement = new(property);

        protected override PropertyField VisualElement { get; }
    }
}