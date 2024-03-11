using UnityEngine;

namespace br.com.arthurjf.Gameplay.Pocket
{
    public class Pocket : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("CannonBall"))
            {
                OnCollideWithCannonBall(other);
            }
        }

        protected virtual void OnCollideWithCannonBall(Collider other)
        {
            Destroy(other.gameObject);
        }
    }
}
