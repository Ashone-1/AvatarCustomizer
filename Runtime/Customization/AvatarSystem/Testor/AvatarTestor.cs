using UnityEngine;

namespace Bear
{
    public class AvatarTestor : MonoBehaviour
    {
        public AvatarGenerator generator;
        public ResourceMakeSignal[] resourceMakeSignals;

        public void Make() {
            foreach (var item in resourceMakeSignals)
            {
                generator.ReceiveSignal(item);
            }
        }
    }
}