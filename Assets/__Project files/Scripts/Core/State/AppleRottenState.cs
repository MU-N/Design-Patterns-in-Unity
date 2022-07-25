
using UnityEngine;

namespace Nasser.io.DesignPatterns.State
{
    public class AppleRottenState : AppleBaseState
    {
        public override void EntreState(AppleStateManager apple)
        {
            Debug.Log("Entre Rotten State");
        }


        public override void UpdateState(AppleStateManager apple)
        {
            
        }
        public override void OnCollisionState(AppleStateManager apple, Collision collision)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                // sub hetlth for player
                Debug.Log(" -- Health ");
                apple.SwitchState(apple.chewedState);
            }
        }
    }
}
