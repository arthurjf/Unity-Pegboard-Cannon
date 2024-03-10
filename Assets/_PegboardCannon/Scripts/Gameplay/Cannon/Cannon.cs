using UnityEngine;

namespace br.com.arthurjf.Gameplay.Cannon
{
    public class Cannon : MonoBehaviour
    {
        [SerializeField] private int m_cannonBallsAmount = 10;
        [SerializeField] private GameObject m_cannonBall;
        [SerializeField] private Transform m_spawnPoint;

        private void Update()
        {
            if (Input.GetMouseButtonDown(0) && m_cannonBallsAmount > 0)
            {
                Shoot();
            }
        }

        private void Shoot()
        {
            Instantiate(m_cannonBall, m_spawnPoint.position, Quaternion.identity);

            m_cannonBallsAmount--;
        }
    }
}
