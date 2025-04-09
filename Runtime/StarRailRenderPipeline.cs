using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace StarRailNPR
{
    public class StarRailRenderPipeline : RenderPipeline
    {
        private RenderGraph m_RenderGraph;
        
        public StarRailRenderPipeline()
        {
            InitializeRenderGraph();
        }

        private void InitializeRenderGraph()
        {
            m_RenderGraph = new RenderGraph("StarRailRenderGraph");
        }

        protected override void Dispose(bool disposing)
        {
            CleanupRenderGraph();
            base.Dispose(disposing);
        }

        private void CleanupRenderGraph()
        {
            if (m_RenderGraph != null)
            {
                m_RenderGraph.Cleanup();
                m_RenderGraph = null;
            }
        }

        protected override void Render(ScriptableRenderContext context, Camera[] cameras)
        {
            m_RenderGraph.BeginRecording();
            
            // Here we'll set up passes using RenderGraph
            
            m_RenderGraph.EndRecordingAndExecute();
        }
    }
}