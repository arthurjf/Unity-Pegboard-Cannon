using UnityEngine;
using UnityEngine.UI;

namespace br.com.arthurjf.Gameplay.Cannon
{
    public class Gun : MonoBehaviour
    {
        private const string CANNONBALLS_AMOUNT_TEXT_FORMAT = "Ammo: {0}";

        [SerializeField] private int m_cannonBallsAmount = 10;
        [SerializeField] private GameObject m_cannonBall;
        [SerializeField] private Transform m_spawnPoint;
        [SerializeField] private Text m_cannonBallsAmountText;

        public int CannonBallAmount
        {
            get => m_cannonBallsAmount;
            set
            {
                m_cannonBallsAmount = value;

                UpdateUIText();
            }
        }

        private void Start()
        {
            UpdateUIText();
        }

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

            UpdateUIText();
        }

        //TODO: Decouple UI from this script.
        private void UpdateUIText()
        {
            m_cannonBallsAmountText.text = string.Format(CANNONBALLS_AMOUNT_TEXT_FORMAT, m_cannonBallsAmount);
        }
    }
}
