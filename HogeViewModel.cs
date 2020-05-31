namespace Application
{
    /// <summary>
    /// アプリケーションレイヤー
    /// Viewに必要な情報をもつ
    /// フィールドにIReadOnlyReactiveProperty<T>をもつことも多い
    /// </summary>

    public readonly struct HogeViewModel
    {
        public readonly int Id;
        public readonly string Name;

        public HogeViewModel(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}