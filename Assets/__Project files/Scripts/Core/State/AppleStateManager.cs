using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nasser.io.DesignPatterns.State
{
    public class AppleStateManager : MonoBehaviour
    {
     
        public AppleGrowingState growingState = new AppleGrowingState();
        public AppleChewedState chewedState = new AppleChewedState();
        public AppleRottenState rottenState = new AppleRottenState();
        public  AppleWholeState wholeState = new AppleWholeState();

        AppleBaseState currentState;

        void Start()
        {
            currentState = growingState;

            currentState.EntreState(this);
        }

        void Update()
        {
            currentState.UpdateState(this);
        }

        private void OnCollisionEnter(Collision collision)
        {
            currentState.OnCollisionState(this,collision);
        }

        public  void SwitchState(AppleBaseState state)
        {
            if (currentState != state)
            {
                currentState = state;
                currentState.EntreState(this);
            }
        }
    }
}
