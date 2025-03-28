using UnityEngine;

namespace _Project.Develop.Runtime.Models
{
    [CreateAssetMenu(fileName = "New LevelUpDataMok", menuName = "MokData", order = 51)]
    public class LevelUpDataMok : ScriptableObject
    {
        [Header("Начальный уровень пользователя")]
        [SerializeField]
        private int _userLevel;
        [Header("Значения наград 2X")]
        [SerializeField]
        private RewardData[] _rewards2X;
        [Header("Значения наград")]
        [SerializeField]
        public RewardData[] _rewardsNormal;

        public int UserLevel => _userLevel;
        public RewardData[] Rewards2X => _rewards2X;
        public RewardData[] RewardsNormal => _rewardsNormal;
    }
}