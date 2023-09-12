using System.Collections;
using System.Collections.Generic;
using UnityEngine.UIElements;

namespace Anvil.Styling
{
    public class Style : IEnumerable<IOption>
    {
        public Style(params IOption[] options) => Options = new(options);

        List<IOption> Options { get; }
        
        public void Add(IOption option) => Options.Add(option);

        public void Apply(VisualElement element)
        {
            foreach (IOption option in Options)
            {
                option.Apply(element);
            }
        }

        public IEnumerator<IOption> GetEnumerator() => Options.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

}