
using UnityEngine;

namespace Nasser.io.DesignPatterns.State
{
    public class AppleWholeState : AppleBaseState
    {
        float rottenCountdown = 5f;
        public override void EntreState(AppleStateManager apple)
        {
            Debug.Log("Entre Whole State");
            apple.GetComponent<Rigidbody>().useGravity = true;
        }

        public override void UpdateState(AppleStateManager apple)
        {
            if(rottenCountdown >= 0)
                rottenCountdown-=Time.deltaTime;
            else
                apple.SwitchState(apple.rottenState);
        }
        public override void OnCollisionState(AppleStateManager apple, Collision collision)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                // add hetlth for player
                Debug.Log(" ++ Health ");
                apple.SwitchState(apple.chewedState);
            }
        }

    }
}
