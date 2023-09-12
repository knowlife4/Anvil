using Anvil.Elements;
using UnityEditor.UIElements;
using UnityEngine.UIElements;

namespace Anvil.Editor.Elements
{
    public class Editor : Element<InspectorElement>
    {
        public Editor(UnityEngine.Object obj) => VisualElement = new(obj);

        protected override InspectorElement VisualElement { get; }
    }
}