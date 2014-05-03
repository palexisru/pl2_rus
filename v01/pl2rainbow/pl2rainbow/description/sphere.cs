using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace pl2.rainbow.description
{
    public class Sphere
    {
        public Abstraction[] abstruction_collection = 
        {
            new Abstraction(Abstraction_level.Class_infinity, "Пустота", "Пустое", "Пустой", Color.FromArgb( 96 , 0 , 160 )) ,
            new Abstraction(Abstraction_level.Class_void, "Пространство", "Наполняемое", "Наполняемый", Color.FromArgb( 80 , 0 , 176 )),
            new Abstraction(Abstraction_level.Class_domain, "Астрофизика", "Доменное", "Хаотический", Color.FromArgb( 64 , 0 , 192 )),
            new Abstraction(Abstraction_level.Class_tuple, "Физика", "Кортежное", "Физический", Color.FromArgb( 32 , 32 , 255 )),
            new Abstraction(Abstraction_level.Class_structure, "Химия", "Структурное", "Канальный", Color.FromArgb( 0 , 96 , 160 )),
            new Abstraction(Abstraction_level.Class_system, "Биология", "Системное", "Системный", Color.FromArgb( 0 , 112 , 144 )),
            new Abstraction(Abstraction_level.Class_process, "Психология", "Процессное", "Межсетевой", Color.FromArgb( 0 , 128 , 128 )),
            new Abstraction(Abstraction_level.Class_specialist, "Социология", "Специальное", "Специализированный", Color.FromArgb( 0 , 144 , 112 )),
            new Abstraction(Abstraction_level.Class_parallel, "Экономика", "Параллельное", "Параллельный", Color.FromArgb( 0 , 160 , 96 )),
            new Abstraction(Abstraction_level.Class_stability, "Синергетика", "Устойчивое", "Устойчивый", Color.FromArgb( 0 , 176 , 80 )),
            new Abstraction(Abstraction_level.Class_responsibility, "Управление", "Ответственное", "Ответственный", Color.FromArgb( 0 , 192 , 64 )),
            new Abstraction(Abstraction_level.Class_below_reality, "Нижний приреал", "Нижний приреал", "Нижний приреал", Color.FromArgb( 0 , 208 , 32 )),
            new Abstraction(Abstraction_level.Class_reality, "Преобразование", "Преобразующее", "Преобразование", Color.FromArgb( 32, 255 , 32 )),
            new Abstraction(Abstraction_level.Interface_above_reality, "Верхний приреал", "Верхний приреал", "Верхний приреал", Color.FromArgb( 32 , 208 , 0 )),
            new Abstraction(Abstraction_level.Interface_technology, "Технология", "Технологическое", "Технологический", Color.FromArgb( 64 , 192 , 0 )),
            new Abstraction(Abstraction_level.Interface_alignment, "Спорт", "Выравнивающее", "Выравнивающий", Color.FromArgb( 80 , 176 , 0 )),
            new Abstraction(Abstraction_level.Interface_exchange, "Маркетинг", "Обменное", "Оценивающий", Color.FromArgb( 96 , 160 , 0 )),
            new Abstraction(Abstraction_level.Interface_control, "Менеджмент", "Управляющее", "Управляющий", Color.FromArgb( 128 , 128 , 0 )),
            new Abstraction(Abstraction_level.Interface_politic, "Политология", "Транспортное", "Транспортный", Color.FromArgb( 160 , 96 , 0 )),
            new Abstraction(Abstraction_level.Interface_session, "Культурология", "Сеансовое", "Сеансовый", Color.FromArgb( 176 , 80 , 0 )),
            new Abstraction(Abstraction_level.Interface_functional, "Философия", "Функциональное", "Представительский", Color.FromArgb( 192 , 64 , 0 )),
            new Abstraction(Abstraction_level.Interface_target, "Религиоведение", "Целевое", "Прикладной", Color.FromArgb( 255 , 32 , 32 )),
            new Abstraction(Abstraction_level.Interface_logical, "Логика", "Логиеское", "Логический", Color.FromArgb( 224 , 0 , 32 )),
            new Abstraction(Abstraction_level.Interface_abstract, "Моделирование", "Абстрактное", "Абстрактный", Color.FromArgb( 192 , 0 , 64 )),
            new Abstraction(Abstraction_level.Interface_infinity, "Идея", "Идейное", "Мыслимый", Color.FromArgb( 176 , 0 , 80 ))
        };
    }
}
