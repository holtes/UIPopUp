using UnityEngine;
using TSS;
using Zenject;
using _Project.Develop.Runtime.Models;
using _Project.Develop.Runtime.Views.LevelUp;
using _Project.Develop.Runtime.Views.Buttons;

namespace _Project.Develop.Runtime.Controllers
{
    public class UIController : MonoBehaviour
    {
        [SerializeField] private TSSCore _tssCore;
        [SerializeField] private LevelUpView _levelUpView;
        [SerializeField] private LevelUpBtnView _levelUpBtnView;

        private LevelUpModel _levelUpModel;


        [Inject]
        private void Construct(LevelUpModel levelUpModel)
        {
            _levelUpModel = levelUpModel;
        }

        private void Awake()
        {
            _levelUpBtnView.OnBtnClicked += LevelUpUser;
            _levelUpView.OnAdBtnClicked += OpenURL;
            _levelUpView.OnClaimBtnClicked += ClosePopUp;
        }

        private void LevelUpUser()
        {
            _levelUpModel.LevelUpUser();
            _levelUpView.SetLevelUpData(_levelUpModel.UserLevel, _levelUpModel.Rewards2X, _levelUpModel.RewardsNormal);
            OpenPopUp();
        }

        private void OpenPopUp() => _tssCore.SelectNextState();

        private void ClosePopUp() => _tssCore.SelectDefaultState();

        private void OpenURL() => Application.OpenURL("https://example.com");

    }
}

