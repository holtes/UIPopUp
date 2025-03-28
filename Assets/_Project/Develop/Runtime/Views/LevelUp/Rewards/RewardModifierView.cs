namespace _Project.Develop.Runtime.Views.LevelUp.Rewards
{
    public class RewardModifierView : RewardView
    {
        public override void SetReward(int rewardValue)
        {
            _rewardTxt.text = $"x{rewardValue}";
        }
    }
}

