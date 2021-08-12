
namespace HomeWork.Models
{
    //Модель описывающая отдельные работы, выполняемые поставщиком услуг.
    public class Task
    {
        private int _id;    //id задачи.
        private string _taskDescription;    //описание задачи.
        private decimal _price;             //стоимость выполнения.

        /// <summary>Конструктор задачи.</summary>
        /// <param name="id">id задачи.</param>
        /// <param name="taskDescription">Описание задачи.</param>
        /// <param name="price">Стоимость выполнения.</param>
        public Task(int id, string taskDescription, decimal price)
        {
            _id = id;
            _taskDescription = taskDescription;
            _price = price;
        }
    }
}
