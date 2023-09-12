using Anvil.Elements;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine.UIElements;

namespace Anvil.Editor.Interfaces
{
    public abstract class Inspector : UnityEditor.Editor, IInterface
    {
        public override VisualElement CreateInspectorGUI()
        { 
            VisualElement root = Root.GetVisualElement();
            root.style.flexGrow = 1;

            if (DrawDefault) root.Add(CreateDefaultGUI());

            return root;
        }
        
        public VisualElement CreateDefaultGUI()
        {
            VisualElement container = new VisualElement();
 
            SerializedProperty iterator = serializedObject.GetIterator();
            if (!iterator.NextVisible(true)) return container;
            
            do
            {
                PropertyField propertyField = new PropertyField(iterator.Copy()) { name = "PropertyField:" + iterator.propertyPath };
 
                if (iterator.propertyPath == "m_Script" && serializedObject.targetObject != null)
                    propertyField.SetEnabled(value: false);
 
                container.Add(propertyField);
            }
            while (iterator.NextVisible(false));

            return container;
        }

        protected UnityEngine.Object Target => target;

        public abstract Element Root { get; }

        protected abstract bool DrawDefault { get; }
    }
}