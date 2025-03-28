using UnityEngine;

namespace _Project.Develop.Runtime.Models
{
    [CreateAssetMenu(fileName = "New LevelUpDataMok", menuName = "MokData", order = 51)]
    public class LevelUpDataMok : ScriptableObject
    {
        [Header("��������� ������� ������������")]
        [SerializeField]
        private int _userLevel;
        [Header("�������� ������ 2X")]
        [SerializeField]
        private RewardData[] _rewards2X;
        [Header("�������� ������")]
        [SerializeField]
        public RewardData[] _rewardsNormal;

        public int UserLevel => _userLevel;
        public RewardData[] Rewards2X => _rewards2X;
        public RewardData[] RewardsNormal => _rewardsNormal;
    }
}