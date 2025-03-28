namespace _Project.Develop.Runtime.Models
{
    public class LevelUpModel
    {
        public int UserLevel { get; private set; }
        public RewardData[] Rewards2X { get; }
        public RewardData[] RewardsNormal { get; }

        public LevelUpModel(LevelUpDataMok dataMok)
        {
            UserLevel = dataMok.UserLevel;
            Rewards2X = dataMok.Rewards2X;
            RewardsNormal = dataMok.RewardsNormal;
        }

        public void LevelUpUser() => UserLevel++;
    }
}

