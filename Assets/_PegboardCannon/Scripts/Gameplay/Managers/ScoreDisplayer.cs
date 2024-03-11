using UnityEngine;
using UnityEngine.UI;

namespace br.com.arthurjf.Gameplay.Managers
{
    public class ScoreDisplayer : MonoBehaviour
    {
        private const string SCORE_TEXT_FORMAT = "Score: {0}";

        [SerializeField] private Text m_scoreText;

        private void OnEnable()
        {
            Score.OnScoreChanged += OnScoreChanged;
        }

        private void Start()
        {
            OnScoreChanged(Score.Amount);
        }

        private void OnScoreChanged(int amount)
        {
            m_scoreText.text = string.Format(SCORE_TEXT_FORMAT, amount);
        }
    }
}
