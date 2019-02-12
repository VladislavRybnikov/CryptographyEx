using CryptographyEx.Core.Base.Abstract;
using CryptographyEx.Core.Holder;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using CryptographyEx.Core.Base.Const;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Xml.Serialization;
using System.Net;
using System.Net.Sockets;
using CryptographyEx.Core.Alphabets;

namespace CryptographyEx.Core.Presentation
{
    public class HistoryPresentation : IHistoryPresentation
    {
        //private readonly IAlphabetEncoder _dsa;
        //public HistoryPresentation()
        //{
   
        //    _dsa = EncoderFactory
        //   .CreateEncoder(EncoderType.Trithemius)
        //     .SetMonoAlphabet(Alphabet.GetMono(MonoAlphabet.UTF16))
        //   .Configure(79, new Func<int, int>(x => x +2));
        //}

            public void AddHistory(RequestHistory requestHistory)
        {
            if (!HistoryHolder.HistoryCodingEntity.Any(p => p.Name.ToLower()
             .Equals(requestHistory?.Name?.ToLower())))
            {
                HistoryHolder.HistoryCodingEntity.Add(new HistoryCodingEntity()
                {
                    Name = requestHistory?.Name,
                });
            }

            HistoryCodingEntity historyCodingEntity =
                HistoryHolder.HistoryCodingEntity.FirstOrDefault(p => p.Name.ToLower()
             .Equals(requestHistory?.Name?.ToLower()));

            HistoryDetailByCodingEntity historyDetailByCodingEntity =
                historyCodingEntity.HistoryDetailByCodingEntity
                .FirstOrDefault(p => p.GuidId.Equals(requestHistory.GuidId));

            if(historyDetailByCodingEntity==null)
            {
                historyDetailByCodingEntity = new HistoryDetailByCodingEntity()
                {
                    GuidId = requestHistory.GuidId,
                    CodingType = requestHistory.CodingType,
                };

                if (!historyCodingEntity.HistoryDetailByCodingEntity
                    .Contains(historyDetailByCodingEntity))
                {
                    historyCodingEntity.HistoryDetailByCodingEntity
                        .Add(historyDetailByCodingEntity);
                }
            }

       
            HistoryDetailByAnswerEntity historyDetailByAnswerEntity =
                new HistoryDetailByAnswerEntity()
                {
                    Mark = requestHistory.Mark,
                    Answer = requestHistory.Answer,
                    DateTime = DateTime.Now,
                    CorrectAnswer = requestHistory.CorrectAnswer
                };

            historyDetailByCodingEntity.HistoryDetailByAnswerEntity
                .Add(historyDetailByAnswerEntity);

            Serializer();
        }

        public List<Tuple<string, int>> GetAllHistory()
        {
            List<Tuple<string, int>> coddingMarks =
                new List<Tuple<string, int>>();

            foreach (var names in HistoryHolder.HistoryCodingEntity)
            {
                int encodingMark = GetMark(CodingType.Encoding,
                    names.HistoryDetailByCodingEntity);

                int decodingMark = GetMark(CodingType.Decoding,
                    names.HistoryDetailByCodingEntity);
                int testMark = GetMark(CodingType.Test,
              names.HistoryDetailByCodingEntity);
                int sum = encodingMark + decodingMark + testMark;

                coddingMarks.Add(new Tuple<string, int>(names.Name, sum));
            }

            return coddingMarks;
        }

        public List<Tuple<string,HistoryDetailByCodingEntity>> 
            GetHistoryDetailByCoding(string name)
        {
            List < Tuple<string, HistoryDetailByCodingEntity> > historyDetailByCodingEntities =
                new List< Tuple<string, HistoryDetailByCodingEntity> > ();

            HistoryCodingEntity historyCodingEntity =
                HistoryHolder.HistoryCodingEntity.FirstOrDefault(p => p.Name.ToLower()
            .Equals(name.ToLower()));

            if(historyCodingEntity==null)
            {
                return historyDetailByCodingEntities;
            }

            return historyCodingEntity.HistoryDetailByCodingEntity
                .Select(p=> new Tuple<string, HistoryDetailByCodingEntity>(name,p)).ToList();
        }

        public List<Tuple<string,CodingType, HistoryDetailByAnswerEntity>> 
            GetHistoryDetailByAnswers(string name, Guid guid)
        {
            List<Tuple<string, CodingType, HistoryDetailByAnswerEntity>> methodResult
                = new List<Tuple<string, CodingType, HistoryDetailByAnswerEntity>>();

            var detailCoddings =
                 GetHistoryDetailByCoding(name).FirstOrDefault(p => p.Item2.GuidId == guid);

            if(detailCoddings==null)
            {
                return methodResult;
            }

            CodingType codingType = detailCoddings.Item2.CodingType;

           return detailCoddings.Item2.HistoryDetailByAnswerEntity
                .Select(p=> new Tuple<string, CodingType, HistoryDetailByAnswerEntity>
                (name, codingType,p)).ToList();
        }

        private int GetMark(CodingType encoding,
            List<HistoryDetailByCodingEntity> historyDetailByCodingEntities)
        {
            int encodingMark = 0;

            foreach (var codding in historyDetailByCodingEntities
                .Where(p => p.CodingType == encoding))
            {
                int tempMark =
                     codding.HistoryDetailByAnswerEntity.Sum(p => p.Mark);

                if (tempMark > encodingMark)
                {
                    encodingMark = tempMark;
                }

                codding.Mark = tempMark;
            }

            return encodingMark;
        }

        public void Serializer()
        {
            HistoryEntity historyEntity = new HistoryEntity();

            XmlSerializer formatter = new XmlSerializer(typeof(List<HistoryCodingEntity>));

            using (FileStream fs = new FileStream("history.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, historyEntity.HistoryCodingEntity);
            }

            Decode();
        }

        private void Decode()
        {
            
//string encode = null;
//            using (StreamReader sr = new StreamReader(("history.xml")))
//            {

//                encode= _dsa.Encode(sr.ReadToEnd());
//            }
//            using (StreamWriter sw = new StreamWriter("history.xml"))
//            {
//                sw.Write(encode);
//            }
        }

        public void Deserialize()
        {
            if (File.Exists("history.xml")) { 
            //string encode = null;
            //using (StreamReader sr = new StreamReader(("history.xml")))
            //{

            //    encode = _dsa.Decode(sr.ReadToEnd());
            //}
            //using (StreamWriter sw = new StreamWriter("history.xml"))
            //{
            //    sw.Write(encode);
            //}
            XmlSerializer formatter = new XmlSerializer(typeof(List<HistoryCodingEntity>));

                try
                {
                    using (FileStream fs = new FileStream("history.xml", FileMode.OpenOrCreate))
                    {
                        List<HistoryCodingEntity> historyEntity = (List<HistoryCodingEntity>)formatter.Deserialize(fs);
                        HistoryHolder.HistoryCodingEntity = historyEntity;
                    }
                }
                catch(Exception e)
                {

                }
                Decode();
            }
        }
    }
}
