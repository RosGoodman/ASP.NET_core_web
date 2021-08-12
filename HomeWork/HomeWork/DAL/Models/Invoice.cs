using System;
using System.Collections.Generic;

namespace HomeWork.Models
{
    /// <summary>Модель накладной.</summary>
    public class Invoice
    {
        private long _id;           //id накладной.
        private long _idContract;   //id контракта.
        private DateTimeOffset _startDate;      //дата начала.
        private DateTimeOffset _endDate;        //дата окончания.
        private Dictionary<int,bool> _tasksIdState;        //список задач, статус (выполнена/не выполнена)

        public Invoice(long contractID, DateTimeOffset startDate, DateTimeOffset endDate, Dictionary<int, bool> tasksIdState)
        {
            _idContract = contractID;
            _startDate = startDate;
            _endDate = endDate;
            _tasksIdState = tasksIdState;
        }
    }
}
