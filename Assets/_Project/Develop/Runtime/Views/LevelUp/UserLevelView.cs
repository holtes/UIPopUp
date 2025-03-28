using UnityEngine;
using TMPro;

namespace _Project.Develop.Runtime.Views.LevelUp
{
    public class UserLevelView : MonoBehaviour
    {
        [SerializeField] private TMP_Text _levelTxt;

        public void SetUserLevel(int levelValue)
        {
            _levelTxt.text = $"- LEVEL {levelValue} -";
        }
    }
}

