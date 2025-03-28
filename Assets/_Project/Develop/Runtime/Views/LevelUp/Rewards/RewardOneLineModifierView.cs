using UnityEngine;

namespace _Project.Develop.Runtime.Views.LevelUp.Rewards
{
    public class RewardOneLineModifierView : RewardView
    {
        [SerializeField] private Color _textColor = Color.white;
        [SerializeField] private Color _modifierColor = Color.white;
        public override void SetReward(int rewardValue)
        {
            string curData = _rewardTxt.text;
            int index = curData.LastIndexOf(" x");

            if (index != -1)
            {
                string mainText = curData.Substring(0, index).Trim();
                string mainColorHex = ColorToHex(_textColor);
                string highlightColorHex = ColorToHex(_modifierColor);
                _rewardTxt.text = $"<color=#{mainColorHex}>{mainText}</color> <color=#{highlightColorHex}>x{rewardValue}</color>";
            }
        }

        private string ColorToHex(Color color)
        {
            return ColorUtility.ToHtmlStringRGB(color);
        }
    }
}

