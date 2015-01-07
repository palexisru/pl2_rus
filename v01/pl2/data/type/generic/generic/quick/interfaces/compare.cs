using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pl2.data.generic.quick.interfaces
{
    /// <summary>
    /// интерфейс сравнения в алгоритмах быстрой сортировки и поиска
    /// </summary>
    /// <typeparam name="Type_for_compare">тип данных для сравнения</typeparam>
    interface I_less_or_equal<Type_for_compare>
    {
        /// <summary>
        /// возвращает истину, если первый аргумент раньше второго в порядке сортировки 
        /// </summary>
        /// <param name="before">значение, которое должно быть раньше</param>
        /// <param name="after">значение, которое должно быть позже</param>
        /// <returns></returns>
        bool sorted(
            Type_for_compare before,
            Type_for_compare after);

        /// <summary>
        /// возвращает истину, если аргументы одинаковы 
        /// </summary>
        /// <param name="arg1">первое сравниваемое значение</param>
        /// <param name="arg2">второе сравниваемое значение</param>
        /// <returns></returns>
        bool equal(
            Type_for_compare arg1,
            Type_for_compare arg2);
    }
}
