namespace _Project.Develop.Runtime.Views.LevelUp.Rewards
{
    public class RewardSumView : RewardView
    {
        public override void SetReward(int rewardValue)
        {
            _rewardTxt.text = $"+{rewardValue}";
        }
    }
}

