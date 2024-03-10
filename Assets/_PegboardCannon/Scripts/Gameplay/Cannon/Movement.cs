using System;
using System.Collections;
using UnityEngine;

namespace br.com.arthurjf.Gameplay.Cannon
{
    public class Movement : MonoBehaviour
    {
        [SerializeField] private MovementScriptableObject m_movementData;
        [SerializeField] private Transform m_leftBound, m_rightBound;

        private void Start()
        {
            StartCoroutine(MoveLeftAndRight());
        }

        private IEnumerator MoveLeftAndRight()
        {
            while (true)
            {
                yield return GoToPosition(m_leftBound.position, m_rightBound.position);

                yield return GoToPosition(m_rightBound.position, m_leftBound.position);
            }
        }

        private IEnumerator GoToPosition(Vector3 startPosition, Vector3 endPosition)
        {
            float elapsed = 0f;

            while (elapsed < 1f)
            {
                elapsed += Time.fixedDeltaTime * m_movementData.Speed;

                float time = elapsed / 1f;

                transform.position = Vector3.Lerp(startPosition, endPosition, time);

                yield return new WaitForFixedUpdate();
            }

            transform.position = endPosition;
        }
    }
}
