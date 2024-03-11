using System;

namespace br.com.arthurjf.Gameplay.Managers
{
    public static class Score
    {
        public static event Action<int> OnScoreChanged;

        private static int _amount = 0;

        public static int Amount => _amount;

        public static void IncreaseScore(int amount)
        {
            _amount += amount;

            OnScoreChanged?.Invoke(_amount);
        }
    }
}
