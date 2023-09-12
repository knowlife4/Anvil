using UnityEngine;

namespace Anvil.Styling.Gradients
{
    public class VerticalGradient : LinearGradient
    {
        public VerticalGradient(int detail, params GradientColorKey[] keys) : base(detail, keys) { }

        protected override int? ScaleX => 1;

        protected override Color GenerateLinear(float inv, int x, int y, UnityEngine.Gradient gradient) => gradient.Evaluate(y * inv);
    }
}