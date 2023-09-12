using UnityEngine;

namespace Anvil.Styling.Gradients
{
    public class HorizontalGradient : LinearGradient
    {
        public HorizontalGradient(int detail, params GradientColorKey[] keys) : base(detail, keys) { }

        protected override int? ScaleY => 1;

        protected override Color GenerateLinear(float inv, int x, int y, UnityEngine.Gradient gradient) => gradient.Evaluate(x * inv);
    }
}