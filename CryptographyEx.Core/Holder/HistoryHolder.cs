using CryptographyEx.Core.Base.Const;
using System;
using System.Collections.Generic;
using System.Text;

namespace CryptographyEx.Core.Holder
{

    public static class HistoryHolder
    {
        static HistoryHolder()
        {
            HistoryCodingEntity = new List<HistoryCodingEntity>();
        }
        public static List<HistoryCodingEntity> HistoryCodingEntity { get; set; }
    }

    [Serializable]
    public class HistoryEntity
    {
        public List<HistoryCodingEntity> HistoryCodingEntity
        {
            get
            {
                List<HistoryCodingEntity> historyCodingEntities =
                    new List<HistoryCodingEntity>();

                foreach (var hist in HistoryHolder.HistoryCodingEntity)
                {
                    HistoryCodingEntity temp = new HistoryCodingEntity()
                    {
                        HistoryDetailByCodingEntity = hist.HistoryDetailByCodingEntity,
                        Name = hist.Name
                    };

                    historyCodingEntities.Add(temp);
                }

                return historyCodingEntities;
            } set { } }

    }

    [Serializable]

    public class HistoryCodingEntity
    {
        public string Name { get; set; }

        public List<HistoryDetailByCodingEntity> HistoryDetailByCodingEntity { get; set; }

        public HistoryCodingEntity()
        {
            HistoryDetailByCodingEntity = new List<HistoryDetailByCodingEntity>();
        }
    }

    public class HistoryDetailByCodingEntity
    {
        public Guid GuidId { get; set; }
        public List<HistoryDetailByAnswerEntity> HistoryDetailByAnswerEntity { get; set; }

        public double Mark { get; set; }

        public CodingType CodingType { get; set; }

        public HistoryDetailByCodingEntity()
        {
            HistoryDetailByAnswerEntity = new List<HistoryDetailByAnswerEntity>();
        }

    }

    public class HistoryDetailByAnswerEntity
    {
        public string CorrectAnswer { get; set; }

        public string Answer { get; set; }
        public int Mark { get; set; }

        public DateTime DateTime { get; set; }
    }

    public class RequestHistory
    {
        public Guid GuidId { get; set; }
        public string Name { get; set; }
        public CodingType CodingType { get; set; }
        public string CorrectAnswer { get; set; }
        public string Answer { get; set; }
        public string Question { get; set; }
        public int Mark { get; set; }
    }
}
