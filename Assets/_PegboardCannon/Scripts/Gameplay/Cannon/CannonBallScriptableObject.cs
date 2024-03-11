using UnityEngine;

namespace br.com.arthurjf.Gameplay.Cannon
{
    [CreateAssetMenu(fileName = "CannonBallData", menuName = "arthurjf/Cannon/Cannonball Data")]
    public class CannonBallScriptableObject : ScriptableObject
    {
        [SerializeField] private int m_scorePoints = 50;
        [SerializeField] private int m_increaseAmount = 1;

        public int ScorePoints => m_scorePoints;

        public int IncreaseAmount => m_increaseAmount;
    }
}
