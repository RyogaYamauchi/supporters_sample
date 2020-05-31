using Application;

namespace Presentation
{
    /// <summary>
    /// プレゼンテーションレイヤー
    /// UseCaseまたはPresenterで生成したViewModelを元にViewを制御したりいろいろする
    /// </summary>
    
    public sealed class HogePresenter
    {
        private readonly HogeUseCase _useCase;

        public HogePresenter(HogeUseCase useCase)
        {
            _useCase = useCase;
        }

        public HogeView View { get; set; }

        public void Start()
        {
            // UseCaseをうんちゃらかんちゃらでデータを撮ってくる
            var viewModel = _useCase.GetViewModel();
            View.ShowAsync(viewModel).Forget();
        }
    }
}