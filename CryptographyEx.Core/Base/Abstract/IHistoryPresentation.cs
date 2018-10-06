using CryptographyEx.Core.Base.Const;
using CryptographyEx.Core.Holder;
using System;
using System.Collections.Generic;
using System.Text;

namespace CryptographyEx.Core.Base.Abstract
{
    public interface IHistoryPresentation
    {
        void AddHistory(RequestHistory requestHistory);
        List<Tuple<string, int>> GetAllHistory();
        List<Tuple<string, HistoryDetailByCodingEntity>>
           GetHistoryDetailByCoding(string name);
        List<Tuple<string, CodingType, HistoryDetailByAnswerEntity>>
            GetHistoryDetailByAnswers(string name, Guid guid);
        void Deserialize();
    }
}
