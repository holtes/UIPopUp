using UnityEngine;
using UnityEngine.UI;
using System;

namespace _Project.Develop.Runtime.Views.Buttons
{
    public class LevelUpBtnView : MonoBehaviour
    {
        [SerializeField] private Button _levelUpBtn;

        public Action OnBtnClicked;

        private void Awake() => _levelUpBtn.onClick.AddListener(delegate { OnBtnClicked?.Invoke(); });
    }
}

