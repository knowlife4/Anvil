using UnityEngine;

namespace Anvil.Styling.Gradients
{
    public class DiagonalGradient : LinearGradient
    {
        public DiagonalGradient(int detail, params GradientColorKey[] keys) : base(detail, keys) { }

        protected override Color GenerateLinear(float inv, int x, int y, UnityEngine.Gradient gradient) => gradient.Evaluate((x + y) * inv);
    }
}