using UnityEngine;
using TMPro;

namespace _Project.Develop.Runtime.Views.LevelUp.Rewards
{
    public abstract class RewardView : MonoBehaviour
    {
        [SerializeField] protected TMP_Text _rewardTxt;
        public abstract void SetReward(int rewardValue);
    }
}

