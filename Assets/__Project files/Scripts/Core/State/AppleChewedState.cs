using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nasser.io.DesignPatterns.State
{
    public class AppleChewedState : AppleBaseState
    {
        float destroyCountDown = 5f;
        public override void EntreState(AppleStateManager apple)
        {
            Debug.Log("Entre Chewed State");
        }


        public override void UpdateState(AppleStateManager apple)
        {
           if(destroyCountDown >= 0)
                destroyCountDown-= Time.deltaTime;

           else
                Object.Destroy(apple.gameObject);
        }
        public override void OnCollisionState(AppleStateManager apple , Collision collision)
        {
            
        }
    }
}
