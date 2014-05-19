using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace pl2.rainbow.description
{
    public class Sphere
    {
        public static Abstraction_system[] abstruction_collection = 
        {
            new Abstraction_system(Abstraction_level_enum.Class_infinity, "Пустота", 
               Importance_enum.Level_reserved, "Пустое", "Пустой", Color.FromArgb( 96 , 0 , 160 )) ,
            new Abstraction_system(Abstraction_level_enum.Class_void, "Пространство", 
               Importance_enum.Level_reserved, "Наполняемое", "Наполняемый", Color.FromArgb( 80 , 0 , 176 )),
            new Abstraction_system(Abstraction_level_enum.Class_domain, "Астрофизика", 
               Importance_enum.Level_probably, "Доменное", "Хаотический", Color.FromArgb( 64 , 0 , 192 )),
            new Abstraction_system(Abstraction_level_enum.Class_tuple, "Физика", 
               Importance_enum.Level_important, "Кортежное", "Физический", Color.FromArgb( 32 , 32 , 255 )),
            new Abstraction_system(Abstraction_level_enum.Class_structure, "Химия", 
               Importance_enum.Level_main, "Структурное", "Канальный", Color.FromArgb( 0 , 96 , 160 )),
            new Abstraction_system(Abstraction_level_enum.Class_system, "Биология", 
               Importance_enum.Level_main, "Системное", "Системный", Color.FromArgb( 0 , 112 , 144 )),
            new Abstraction_system(Abstraction_level_enum.Class_process, "Психология", 
               Importance_enum.Level_important, "Процессное", "Межсетевой", Color.FromArgb( 0 , 128 , 128 )),
            new Abstraction_system(Abstraction_level_enum.Class_specialist, "Социология", 
               Importance_enum.Level_important, "Специальное", "Специализированный", Color.FromArgb( 0 , 144 , 112 )),
            new Abstraction_system(Abstraction_level_enum.Class_parallel, "Экономика", 
               Importance_enum.Level_probably, "Параллельное", "Параллельный", Color.FromArgb( 0 , 160 , 96 )),
            new Abstraction_system(Abstraction_level_enum.Class_stability, "Синергетика", 
               Importance_enum.Level_probably, "Устойчивое", "Устойчивый", Color.FromArgb( 0 , 176 , 80 )),
            new Abstraction_system(Abstraction_level_enum.Class_responsibility, "Управление", 
               Importance_enum.Level_reserved, "Ответственное", "Ответственный", Color.FromArgb( 0 , 192 , 64 )),
            new Abstraction_system(Abstraction_level_enum.Class_below_reality, "Нижний приреал", 
               Importance_enum.Level_reserved, "Нижний приреал", "Нижний приреал", Color.FromArgb( 0 , 208 , 32 )),
            new Abstraction_system(Abstraction_level_enum.Class_reality, "Преобразование", 
               Importance_enum.Level_probably, "Преобразующее", "Преобразование", Color.FromArgb( 32, 255 , 32 )),
            new Abstraction_system(Abstraction_level_enum.Interface_above_reality, "Верхний приреал", 
               Importance_enum.Level_reserved, "Верхний приреал", "Верхний приреал", Color.FromArgb( 32 , 208 , 0 )),
            new Abstraction_system(Abstraction_level_enum.Interface_technology, "Технология", 
               Importance_enum.Level_reserved, "Технологическое", "Технологический", Color.FromArgb( 64 , 192 , 0 )),
            new Abstraction_system(Abstraction_level_enum.Interface_alignment, "Спорт", 
               Importance_enum.Level_probably, "Выравнивающее", "Выравнивающий", Color.FromArgb( 80 , 176 , 0 )),
            new Abstraction_system(Abstraction_level_enum.Interface_exchange, "Маркетинг", 
               Importance_enum.Level_probably, "Обменное", "Оценивающий", Color.FromArgb( 96 , 160 , 0 )),
            new Abstraction_system(Abstraction_level_enum.Interface_control, "Менеджмент", 
               Importance_enum.Level_important, "Управляющее", "Управляющий", Color.FromArgb( 128 , 128 , 0 )),
            new Abstraction_system(Abstraction_level_enum.Interface_politic, "Политология", 
               Importance_enum.Level_important, "Транспортное", "Транспортный", Color.FromArgb( 160 , 96 , 0 )),
            new Abstraction_system(Abstraction_level_enum.Interface_session, "Культурология", 
               Importance_enum.Level_main, "Сеансовое", "Сеансовый", Color.FromArgb( 176 , 80 , 0 )),
            new Abstraction_system(Abstraction_level_enum.Interface_functional, "Философия", 
               Importance_enum.Level_main, "Функциональное", "Представительский", Color.FromArgb( 192 , 64 , 0 )),
            new Abstraction_system(Abstraction_level_enum.Interface_target, "Религиоведение", 
               Importance_enum.Level_important, "Целевое", "Прикладной", Color.FromArgb( 255 , 32 , 32 )),
            new Abstraction_system(Abstraction_level_enum.Interface_logical, "Логика", 
               Importance_enum.Level_probably, "Логическое", "Логический", Color.FromArgb( 224 , 0 , 32 )),
            new Abstraction_system(Abstraction_level_enum.Interface_abstract, "Моделирование", 
               Importance_enum.Level_reserved, "Абстрактное", "Абстрактный", Color.FromArgb( 192 , 0 , 64 )),
            new Abstraction_system(Abstraction_level_enum.Interface_infinity, "Идея", 
               Importance_enum.Level_reserved, "Идейное", "Мыслимый", Color.FromArgb( 176 , 0 , 80 ))
        };

        public static Cell_system[] cell_collection =
        {
            new Cell_system("idia", "Идея", Abstraction_level_enum.Interface_infinity, Phase_direction_enum.invariant),
            new Cell_system("idia", "Идея", Abstraction_level_enum.Interface_infinity, Phase_direction_enum.before),
            new Cell_system("idia", "Идея", Abstraction_level_enum.Interface_infinity, Phase_direction_enum.action),
            new Cell_system("idia", "Идея", Abstraction_level_enum.Interface_infinity, Phase_direction_enum.after),

            new Cell_system("idia", "Необходимость", Abstraction_level_enum.Interface_abstract, Phase_direction_enum.invariant),
            new Cell_system("idia", "Направленность", Abstraction_level_enum.Interface_abstract, Phase_direction_enum.before),
            new Cell_system("idia", "Несуществование", Abstraction_level_enum.Interface_abstract, Phase_direction_enum.action),
            new Cell_system("idia", "Отрицание", Abstraction_level_enum.Interface_abstract, Phase_direction_enum.after),

            new Cell_system("idia", "Необходимость", Abstraction_level_enum.Interface_logical, Phase_direction_enum.invariant),
            new Cell_system("idia", "Направленность", Abstraction_level_enum.Interface_logical, Phase_direction_enum.before),
            new Cell_system("idia", "Несуществование", Abstraction_level_enum.Interface_logical, Phase_direction_enum.action),
            new Cell_system("idia", "Отрицание", Abstraction_level_enum.Interface_logical, Phase_direction_enum.after),

            new Cell_system("idia", "Цель", Abstraction_level_enum.Interface_target, Phase_direction_enum.invariant),
            new Cell_system("idia", "Респондент", Abstraction_level_enum.Interface_target, Phase_direction_enum.before),
            new Cell_system("idia", "Функция", Abstraction_level_enum.Interface_target, Phase_direction_enum.action),
            new Cell_system("idia", "Состояние", Abstraction_level_enum.Interface_target, Phase_direction_enum.after),

            new Cell_system("idia", "Точка зрения", Abstraction_level_enum.Interface_functional, Phase_direction_enum.invariant),
            new Cell_system("idia", "Обобщение", Abstraction_level_enum.Interface_functional, Phase_direction_enum.before),
            new Cell_system("idia", "Интерфейс", Abstraction_level_enum.Interface_functional, Phase_direction_enum.action),
            new Cell_system("idia", "Оценка", Abstraction_level_enum.Interface_functional, Phase_direction_enum.after),

            new Cell_system("idia", "Критерий", Abstraction_level_enum.Interface_session, Phase_direction_enum.invariant),
            new Cell_system("idia", "Прогноз", Abstraction_level_enum.Interface_session, Phase_direction_enum.before),
            new Cell_system("idia", "Культура", Abstraction_level_enum.Interface_session, Phase_direction_enum.action),
            new Cell_system("idia", "История", Abstraction_level_enum.Interface_session, Phase_direction_enum.after),

            new Cell_system("idia", "Стратегия", Abstraction_level_enum.Interface_politic, Phase_direction_enum.invariant),
            new Cell_system("idia", "Планирование", Abstraction_level_enum.Interface_politic, Phase_direction_enum.before),
            new Cell_system("idia", "Обучение", Abstraction_level_enum.Interface_politic, Phase_direction_enum.action),
            new Cell_system("idia", "Познание", Abstraction_level_enum.Interface_politic, Phase_direction_enum.after),

            new Cell_system("idia", "Сценарий", Abstraction_level_enum.Interface_control, Phase_direction_enum.invariant),
            new Cell_system("idia", "Обеспечение", Abstraction_level_enum.Interface_control, Phase_direction_enum.before),
            new Cell_system("idia", "Проект", Abstraction_level_enum.Interface_control, Phase_direction_enum.action),
            new Cell_system("idia", "Аудит", Abstraction_level_enum.Interface_control, Phase_direction_enum.after),

            new Cell_system("idia", "Отношение", Abstraction_level_enum.Interface_exchange, Phase_direction_enum.invariant),
            new Cell_system("idia", "Помощь", Abstraction_level_enum.Interface_exchange, Phase_direction_enum.before),
            new Cell_system("idia", "Управление", Abstraction_level_enum.Interface_exchange, Phase_direction_enum.action),
            new Cell_system("idia", "Учет", Abstraction_level_enum.Interface_exchange, Phase_direction_enum.after),

            new Cell_system("idia", "Роль", Abstraction_level_enum.Interface_alignment, Phase_direction_enum.invariant),
            new Cell_system("idia", "Организация", Abstraction_level_enum.Interface_alignment, Phase_direction_enum.before),
            new Cell_system("idia", "Соревнование", Abstraction_level_enum.Interface_alignment, Phase_direction_enum.action),
            new Cell_system("idia", "Контроль", Abstraction_level_enum.Interface_alignment, Phase_direction_enum.after),

            new Cell_system("idia", "Компетентность", Abstraction_level_enum.Interface_technology, Phase_direction_enum.invariant),
            new Cell_system("idia", "Согласование", Abstraction_level_enum.Interface_technology, Phase_direction_enum.before),
            new Cell_system("idia", "Реализация", Abstraction_level_enum.Interface_technology, Phase_direction_enum.action),
            new Cell_system("idia", "Результат", Abstraction_level_enum.Interface_technology, Phase_direction_enum.after),

            new Cell_system("idia", "Компетентность", Abstraction_level_enum.Interface_above_reality, Phase_direction_enum.invariant),
            new Cell_system("idia", "Согласование", Abstraction_level_enum.Interface_above_reality, Phase_direction_enum.before),
            new Cell_system("idia", "Реализация", Abstraction_level_enum.Interface_above_reality, Phase_direction_enum.action),
            new Cell_system("idia", "Результат", Abstraction_level_enum.Interface_above_reality, Phase_direction_enum.after),

            new Cell_system("idia", "Компетентность", Abstraction_level_enum.Class_reality, Phase_direction_enum.invariant),
            new Cell_system("idia", "Согласование", Abstraction_level_enum.Class_reality, Phase_direction_enum.before),
            new Cell_system("idia", "Реализация", Abstraction_level_enum.Class_reality, Phase_direction_enum.action),
            new Cell_system("idia", "Результат", Abstraction_level_enum.Class_reality, Phase_direction_enum.after),

            new Cell_system("idia", "Компетентность", Abstraction_level_enum.Class_below_reality, Phase_direction_enum.invariant),
            new Cell_system("idia", "Согласование", Abstraction_level_enum.Class_below_reality, Phase_direction_enum.before),
            new Cell_system("idia", "Реализация", Abstraction_level_enum.Class_below_reality, Phase_direction_enum.action),
            new Cell_system("idia", "Результат", Abstraction_level_enum.Class_below_reality, Phase_direction_enum.after),

            new Cell_system("idia", "Компетентность", Abstraction_level_enum.Class_responsibility, Phase_direction_enum.invariant),
            new Cell_system("idia", "Согласование", Abstraction_level_enum.Class_responsibility, Phase_direction_enum.before),
            new Cell_system("idia", "Реализация", Abstraction_level_enum.Class_responsibility, Phase_direction_enum.action),
            new Cell_system("idia", "Результат", Abstraction_level_enum.Class_responsibility, Phase_direction_enum.after),

            new Cell_system("idia", "Ответственность", Abstraction_level_enum.Class_stability, Phase_direction_enum.invariant),
            new Cell_system("idia", "Регламент", Abstraction_level_enum.Class_stability, Phase_direction_enum.before),
            new Cell_system("idia", "Граница", Abstraction_level_enum.Class_stability, Phase_direction_enum.action),
            new Cell_system("idia", "Устойчивоть", Abstraction_level_enum.Class_stability, Phase_direction_enum.after),

            new Cell_system("idia", "Процедура", Abstraction_level_enum.Class_parallel, Phase_direction_enum.invariant),
            new Cell_system("idia", "Взаимодействие", Abstraction_level_enum.Class_parallel, Phase_direction_enum.before),
            new Cell_system("idia", "Экземпляр", Abstraction_level_enum.Class_parallel, Phase_direction_enum.action),
            new Cell_system("idia", "Завершение", Abstraction_level_enum.Class_parallel, Phase_direction_enum.after),

            new Cell_system("idia", "Требование", Abstraction_level_enum.Class_specialist, Phase_direction_enum.invariant),
            new Cell_system("idia", "Поставщик", Abstraction_level_enum.Class_specialist, Phase_direction_enum.before),
            new Cell_system("idia", "Продукция", Abstraction_level_enum.Class_specialist, Phase_direction_enum.action),
            new Cell_system("idia", "Потребитель", Abstraction_level_enum.Class_specialist, Phase_direction_enum.after),

            new Cell_system("idia", "Состав", Abstraction_level_enum.Class_process, Phase_direction_enum.invariant),
            new Cell_system("idia", "Вход", Abstraction_level_enum.Class_process, Phase_direction_enum.before),
            new Cell_system("idia", "Процесс", Abstraction_level_enum.Class_process, Phase_direction_enum.action),
            new Cell_system("idia", "Выход", Abstraction_level_enum.Class_process, Phase_direction_enum.after),

            new Cell_system("idia", "Знание", Abstraction_level_enum.Class_system, Phase_direction_enum.invariant),
            new Cell_system("idia", "Система", Abstraction_level_enum.Class_system, Phase_direction_enum.before),
            new Cell_system("idia", "Альтернатива", Abstraction_level_enum.Class_system, Phase_direction_enum.action),
            new Cell_system("idia", "Использование", Abstraction_level_enum.Class_system, Phase_direction_enum.after),

            new Cell_system("idia", "Правило", Abstraction_level_enum.Class_structure, Phase_direction_enum.invariant),
            new Cell_system("idia", "Структура", Abstraction_level_enum.Class_structure, Phase_direction_enum.before),
            new Cell_system("idia", "Субъект", Abstraction_level_enum.Class_structure, Phase_direction_enum.action),
            new Cell_system("idia", "Ресурс", Abstraction_level_enum.Class_structure, Phase_direction_enum.after),

            new Cell_system("idia", "Сущность", Abstraction_level_enum.Class_tuple, Phase_direction_enum.invariant),
            new Cell_system("idia", "Объект", Abstraction_level_enum.Class_tuple, Phase_direction_enum.before),
            new Cell_system("idia", "Сообщение", Abstraction_level_enum.Class_tuple, Phase_direction_enum.action),
            new Cell_system("idia", "Сигнал", Abstraction_level_enum.Class_tuple, Phase_direction_enum.after),

            new Cell_system("exists", "Существование", Abstraction_level_enum.Class_domain, Phase_direction_enum.invariant),
            new Cell_system("relation", "Связь", Abstraction_level_enum.Class_domain, Phase_direction_enum.before),
            new Cell_system("possibility", "Возможность", Abstraction_level_enum.Class_domain, Phase_direction_enum.action),
            new Cell_system("chaos", "Случайность", Abstraction_level_enum.Class_domain, Phase_direction_enum.after),

            new Cell_system("exists", "Существование", Abstraction_level_enum.Class_void, Phase_direction_enum.invariant),
            new Cell_system("relation", "Связь", Abstraction_level_enum.Class_void, Phase_direction_enum.before),
            new Cell_system("possibility", "Возможность", Abstraction_level_enum.Class_void, Phase_direction_enum.action),
            new Cell_system("chaos", "Случайность", Abstraction_level_enum.Class_void, Phase_direction_enum.after),

            new Cell_system("empty", "Пустота", Abstraction_level_enum.Class_infinity, Phase_direction_enum.invariant),
            new Cell_system("empty", "Пустота", Abstraction_level_enum.Class_infinity, Phase_direction_enum.before),
            new Cell_system("empty", "Пустота", Abstraction_level_enum.Class_infinity, Phase_direction_enum.action),
            new Cell_system("empty", "Пустота", Abstraction_level_enum.Class_infinity, Phase_direction_enum.after)

        };
    }
}
