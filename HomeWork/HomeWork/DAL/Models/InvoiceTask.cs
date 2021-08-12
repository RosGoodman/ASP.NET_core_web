using System.Collections.Generic;

namespace HomeWork.Models
{
    /// <summary>Модель описывает состояние задач по накладной.</summary>
    public class InvoiceTask
    {
        private double _id
        private long _invoiceID;    //id накладной.
        private Dictionary<int, Dictionary<long, int>> _idTaskEmployees;    //<id задачи, <id сотрудника, время работы>>

        /// <summary>Конструктор списка задач.</summary>
        /// <param name="invoiceID">Номер накладной.</param>
        /// <param name="idEmployeeHour">Список id задачи(id сорудника, кол-во рабочих часов)></param>
        public InvoiceTask(int invoiceID, Dictionary<int, Dictionary<long, int>> idTaskEmployees)
        {
            _invoiceID = invoiceID;
            _idTaskEmployees = idTaskEmployees;
        }
    }
}
