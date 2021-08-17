
namespace HomeWork.Models
{
    //Модель описывающая отдельные работы, выполняемые поставщиком услуг.
    public class Task
    {
        private int _id;    //id задачи.
        private string _taskDescription;    //описание задачи.
        private decimal _priceOneTime;      //стоимость разового выполнения.
        private decimal _hourlyPayment;     //стоимость почасовой оплаты.

        /// <summary>Конструктор задачи.</summary>
        /// <param name="id">id задачи.</param>
        /// <param name="taskDescription">Описание задачи.</param>
        /// <param name="priceOneTime">Стоимость выполнения.</param>
        /// <param name="hourlyPayment">стоимость почасовой оплаты.</param>
        public Task(int id, string taskDescription, decimal priceOneTime, decimal hourlyPayment)
        {
            _id = id;
            _taskDescription = taskDescription;
            _priceOneTime = priceOneTime;
            _hourlyPayment = hourlyPayment;
        }
    }
}
