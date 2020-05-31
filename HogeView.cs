using Framework; // ViewBaseなど
using UniRx.Async;
using Zenject;



namespace Presentation
{
    /// <summary>
    /// プレゼンテーションレイヤー
    /// View側で表示、ボタンの制御などする。
    /// </summary>
    
    public sealed class HogeView : ViewBase
    {
        [Inject]
        private void Construct(HogePresenter presenter)
        {
            presenter.View = this;
        }

        public HogePresenter Presenter { get; set; }


        private void Start()
        {
            Presenter.Start();
        }

        public async UniTask ShowAsync(HogeViewModel viewModel)
        {
            // viewModelの情報から表示したりいろいろする
            var a = new List<int>();
            a.Sort
        }
    }
}