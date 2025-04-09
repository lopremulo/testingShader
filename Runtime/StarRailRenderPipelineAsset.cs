using UnityEngine;
using UnityEngine.Rendering;

namespace StarRailNPR
{
    [CreateAssetMenu(menuName = "Rendering/StarRail Render Pipeline Asset")]
    public class StarRailRenderPipelineAsset : RenderPipelineAsset
    {
        protected override RenderPipeline CreatePipeline()
        {
            return new StarRailRenderPipeline();
        }
    }
}