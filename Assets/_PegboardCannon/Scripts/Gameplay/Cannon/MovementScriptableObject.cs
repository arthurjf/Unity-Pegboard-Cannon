using UnityEngine;

namespace br.com.arthurjf.Gameplay.Cannon
{
    [CreateAssetMenu(fileName = "MovementData", menuName = "arthurjf/Cannon/Movement Data")]
    public class MovementScriptableObject : ScriptableObject
    {
        [SerializeField] private float m_speed = 2f;

        public float Speed => m_speed;
    }
}
