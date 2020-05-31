
namespace Application
{
    /// <summary>
    /// リポジトリやモデルから情報をごちゃごちゃする
    /// 基本的なロジックはここにかく
    /// </summary>
    
    public sealed class HogeUseCase
    {
    private readonly HogeRepository _hogeRepository;

    public HogeUseCase(HogeRepository hogeRepository)
    {
        _hogeRepository = hogeRepository;
    }

    public HogeViewModel GetViewModel(int id)
    {
        // Repositoryからデータを拾ってきていい感じにする
        var masterData = _hogeRepository.FindById(id);
        return new HogeViewModel(masterData.Id, masterData.Name);
    }
    
}