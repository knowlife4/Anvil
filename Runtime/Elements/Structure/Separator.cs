using UnityEngine;
using UnityEngine.UIElements;

namespace Anvil.Elements.Structure
{
    public sealed class Separator : Element<VisualElement>
    {
        public Separator(Color? color = null)
        {
            VisualElement = new()
            {
                style =
                {
                    height = Length.Auto()
                }
            };

            VisualElement line = new()
            {
                style =
                {
                    height = 2,
                    width = Length.Percent(100),
                    marginTop = 5,
                    marginBottom = 5,
                    backgroundColor = color ?? Color.gray
                }
            };
            
            VisualElement.Add(line);
        }

        protected override VisualElement VisualElement { get; }
    }
}