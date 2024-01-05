using System.Threading;
using Cysharp.Threading.Tasks;
using Sabanishi.ScreenSystem;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

namespace Sabanishi.ScreenSystemSample
{
    public class TitleScreen : BaseScreen
    {
        [SerializeField] private Button button;

        protected override UniTask InitializeInternal(IScreenData data, CancellationToken token)
        {
            button.OnClickAsObservable().Subscribe(_ =>
            {
                //SendMessageScreenへ遷移
                ScreenTransitionLocator.Instance.Move<SendMessageScreen>(null, null).Forget();
            }).AddTo(gameObject);
            return UniTask.CompletedTask;
        }
    }
}