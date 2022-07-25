
using UnityEngine;

namespace Nasser.io.DesignPatterns.State
{
    public class AppleGrowingState : AppleBaseState
    {
        Vector3 startingAppleScale = new Vector3(0.1f, 0.1f, 0.1f);
        Vector3 growAppleScalar = new Vector3(0.1f, 0.1f, 0.1f);


        public override void EntreState(AppleStateManager apple)
        {
            Debug.Log("Entre Growing State");
            apple.transform.localScale = startingAppleScale;
        }

        public override void UpdateState(AppleStateManager apple)
        {
            if (apple.transform.localScale.x < 1)
                apple.transform.localScale += growAppleScalar * Time.deltaTime;

            else
                apple.SwitchState(apple.wholeState);
        }

        public override void OnCollisionState(AppleStateManager apple, Collision collision)
        {

        }

    }
}
