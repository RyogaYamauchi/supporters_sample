using System.Collections.Generic;
using Domain;
using System.Linq;

namespace Data
{
    /// <summary>
    /// マスターデータをプログラムで使えるように変換する
    /// FindByIdやFindAllなどのメソッドが生えることが多い
    /// </summary>
    public sealed class HogeRepository
    {
        private List<MasterHogeData> _list;

        public HogeRepository()
        {
            // 何かしらの方法でデシリアライズしてくる
            _list = new List<MasterHogeData>();
        }

        public MasterHogeData FindById(int id)
        {
            return _list.FirstOrDefault(x => x.Id == id);
        }
    }
}