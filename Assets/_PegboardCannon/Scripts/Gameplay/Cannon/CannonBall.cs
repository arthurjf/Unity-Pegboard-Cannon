using UnityEngine;

namespace br.com.arthurjf.Gameplay.Cannon
{
    public class CannonBall : MonoBehaviour
    {
        [SerializeField] private CannonBallScriptableObject m_data;

        public CannonBallScriptableObject Data => m_data;
    }
}
