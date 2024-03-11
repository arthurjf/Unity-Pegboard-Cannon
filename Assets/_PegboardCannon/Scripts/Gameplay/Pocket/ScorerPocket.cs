using UnityEngine;
using br.com.arthurjf.Gameplay.Cannon;
using br.com.arthurjf.Gameplay.Managers;

namespace br.com.arthurjf.Gameplay.Pocket
{
    public class ScorerPocket : Pocket
    {
        [SerializeField] private Gun m_gun;

        protected override void OnCollideWithCannonBall(Collider other)
        {
            if(other.TryGetComponent(out CannonBall cannonBall))
            {
                Score.IncreaseScore(cannonBall.Data.ScorePoints);

                m_gun.CannonBallAmount += cannonBall.Data.IncreaseAmount;
            }

            base.OnCollideWithCannonBall(other);
        }
    }
}
