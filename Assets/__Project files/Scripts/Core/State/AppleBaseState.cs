
using UnityEngine;
namespace Nasser.io.DesignPatterns.State
{
    public abstract class AppleBaseState
    {
        public abstract void EntreState(AppleStateManager apple);
        public abstract void UpdateState(AppleStateManager apple);
        public abstract void OnCollisionState(AppleStateManager apple , Collision collision);

    }
}
