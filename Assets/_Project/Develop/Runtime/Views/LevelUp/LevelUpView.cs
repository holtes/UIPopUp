using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using _Project.Develop.Runtime.Models;
using _Project.Develop.Runtime.Views.LevelUp.Rewards;

namespace _Project.Develop.Runtime.Views.LevelUp
{
    public class LevelUpView : MonoBehaviour
    {
        [System.Serializable]
        private struct RewardViewIds
        {
            public int Id;
            public RewardView RewardView;
        }

        [SerializeField] private UserLevelView _levelUpTitle;
        [SerializeField] private List<RewardViewIds> _rewardViewIds2X;
        [SerializeField] private List<RewardViewIds> _rewardViewIdsNormal;
        [SerializeField] private Button _adBtn;
        [SerializeField] private Button _claimBtn;

        public Action OnAdBtnClicked;
        public Action OnClaimBtnClicked;

        private void Awake()
        {
            _adBtn.onClick.AddListener(delegate { OnAdBtnClicked?.Invoke(); });
            _claimBtn.onClick.AddListener(delegate { OnClaimBtnClicked?.Invoke(); });
        }

        public void SetLevelUpData(int userLevel, RewardData[] rewards2X, RewardData[] rewardsNormal)
        {
            _levelUpTitle.SetUserLevel(userLevel);
            SetRewardsData(rewards2X, _rewardViewIds2X);
            SetRewardsData(rewardsNormal, _rewardViewIdsNormal);
        }

        private void SetRewardsData(RewardData[] rewardDatas, List<RewardViewIds> rewardViewIds)
        {
            foreach (var rewardData in rewardDatas)
            {
                var rewardView = rewardViewIds.Find(view => view.Id == rewardData.Id).RewardView;
                rewardView.SetReward(rewardData.RewardValue);
            }
        }
    }
}

