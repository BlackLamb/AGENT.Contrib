//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AGENT.Contrib
{
    
    internal partial class ContribResources
    {
        private static System.Resources.ResourceManager manager;
        internal static System.Resources.ResourceManager ResourceManager
        {
            get
            {
                if ((ContribResources.manager == null))
                {
                    ContribResources.manager = new System.Resources.ResourceManager("AGENT.Contrib.ContribResources", typeof(ContribResources).Assembly);
                }
                return ContribResources.manager;
            }
        }
        internal static Microsoft.SPOT.Font GetFont(ContribResources.FontResources id)
        {
            return ((Microsoft.SPOT.Font)(Microsoft.SPOT.ResourceUtility.GetObject(ResourceManager, id)));
        }
        internal static byte[] GetBytes(ContribResources.BinaryResources id)
        {
            return ((byte[])(Microsoft.SPOT.ResourceUtility.GetObject(ResourceManager, id)));
        }
        [System.SerializableAttribute()]
        internal enum BinaryResources : short
        {
            Envelope = -12987,
            VoiceMail = -11536,
            Time = 3642,
            Mail = 18150,
            Alarm = 22443,
        }
        [System.SerializableAttribute()]
        internal enum FontResources : short
        {
            small = 13070,
        }
    }
}
