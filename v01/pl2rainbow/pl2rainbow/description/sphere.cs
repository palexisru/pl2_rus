using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace pl2.rainbow.description
{
    public class Sphere
    {
        public static Abstraction[] abstruction_collection = 
        {
            new Abstraction(Abstraction_level.Class_infinity, "Пустота", 
               Abstraction_level_importance.Level_reserved, "Пустое", "Пустой", Color.FromArgb( 96 , 0 , 160 )) ,
            new Abstraction(Abstraction_level.Class_void, "Пространство", 
               Abstraction_level_importance.Level_reserved, "Наполняемое", "Наполняемый", Color.FromArgb( 80 , 0 , 176 )),
            new Abstraction(Abstraction_level.Class_domain, "Астрофизика", 
               Abstraction_level_importance.Level_probably, "Доменное", "Хаотический", Color.FromArgb( 64 , 0 , 192 )),
            new Abstraction(Abstraction_level.Class_tuple, "Физика", 
               Abstraction_level_importance.Level_important, "Кортежное", "Физический", Color.FromArgb( 32 , 32 , 255 )),
            new Abstraction(Abstraction_level.Class_structure, "Химия", 
               Abstraction_level_importance.Level_main, "Структурное", "Канальный", Color.FromArgb( 0 , 96 , 160 )),
            new Abstraction(Abstraction_level.Class_system, "Биология", 
               Abstraction_level_importance.Level_main, "Системное", "Системный", Color.FromArgb( 0 , 112 , 144 )),
            new Abstraction(Abstraction_level.Class_process, "Психология", 
               Abstraction_level_importance.Level_important, "Процессное", "Межсетевой", Color.FromArgb( 0 , 128 , 128 )),
            new Abstraction(Abstraction_level.Class_specialist, "Социология", 
               Abstraction_level_importance.Level_important, "Специальное", "Специализированный", Color.FromArgb( 0 , 144 , 112 )),
            new Abstraction(Abstraction_level.Class_parallel, "Экономика", 
               Abstraction_level_importance.Level_probably, "Параллельное", "Параллельный", Color.FromArgb( 0 , 160 , 96 )),
            new Abstraction(Abstraction_level.Class_stability, "Синергетика", 
               Abstraction_level_importance.Level_probably, "Устойчивое", "Устойчивый", Color.FromArgb( 0 , 176 , 80 )),
            new Abstraction(Abstraction_level.Class_responsibility, "Управление", 
               Abstraction_level_importance.Level_reserved, "Ответственное", "Ответственный", Color.FromArgb( 0 , 192 , 64 )),
            new Abstraction(Abstraction_level.Class_below_reality, "Нижний приреал", 
               Abstraction_level_importance.Level_reserved, "Нижний приреал", "Нижний приреал", Color.FromArgb( 0 , 208 , 32 )),
            new Abstraction(Abstraction_level.Class_reality, "Преобразование", 
               Abstraction_level_importance.Level_probably, "Преобразующее", "Преобразование", Color.FromArgb( 32, 255 , 32 )),
            new Abstraction(Abstraction_level.Interface_above_reality, "Верхний приреал", 
               Abstraction_level_importance.Level_reserved, "Верхний приреал", "Верхний приреал", Color.FromArgb( 32 , 208 , 0 )),
            new Abstraction(Abstraction_level.Interface_technology, "Технология", 
               Abstraction_level_importance.Level_reserved, "Технологическое", "Технологический", Color.FromArgb( 64 , 192 , 0 )),
            new Abstraction(Abstraction_level.Interface_alignment, "Спорт", 
               Abstraction_level_importance.Level_probably, "Выравнивающее", "Выравнивающий", Color.FromArgb( 80 , 176 , 0 )),
            new Abstraction(Abstraction_level.Interface_exchange, "Маркетинг", 
               Abstraction_level_importance.Level_probably, "Обменное", "Оценивающий", Color.FromArgb( 96 , 160 , 0 )),
            new Abstraction(Abstraction_level.Interface_control, "Менеджмент", 
               Abstraction_level_importance.Level_important, "Управляющее", "Управляющий", Color.FromArgb( 128 , 128 , 0 )),
            new Abstraction(Abstraction_level.Interface_politic, "Политология", 
               Abstraction_level_importance.Level_important, "Транспортное", "Транспортный", Color.FromArgb( 160 , 96 , 0 )),
            new Abstraction(Abstraction_level.Interface_session, "Культурология", 
               Abstraction_level_importance.Level_main, "Сеансовое", "Сеансовый", Color.FromArgb( 176 , 80 , 0 )),
            new Abstraction(Abstraction_level.Interface_functional, "Философия", 
               Abstraction_level_importance.Level_main, "Функциональное", "Представительский", Color.FromArgb( 192 , 64 , 0 )),
            new Abstraction(Abstraction_level.Interface_target, "Религиоведение", 
               Abstraction_level_importance.Level_important, "Целевое", "Прикладной", Color.FromArgb( 255 , 32 , 32 )),
            new Abstraction(Abstraction_level.Interface_logical, "Логика", 
               Abstraction_level_importance.Level_probably, "Логическое", "Логический", Color.FromArgb( 224 , 0 , 32 )),
            new Abstraction(Abstraction_level.Interface_abstract, "Моделирование", 
               Abstraction_level_importance.Level_reserved, "Абстрактное", "Абстрактный", Color.FromArgb( 192 , 0 , 64 )),
            new Abstraction(Abstraction_level.Interface_infinity, "Идея", 
               Abstraction_level_importance.Level_reserved, "Идейное", "Мыслимый", Color.FromArgb( 176 , 0 , 80 ))
        };

        public static Cell[] cell_collection =
        {
            new Cell("idia", "Идея", Abstraction_level.Interface_infinity, Phase_direction.invariant),
            new Cell("idia", "Идея", Abstraction_level.Interface_infinity, Phase_direction.before),
            new Cell("idia", "Идея", Abstraction_level.Interface_infinity, Phase_direction.action),
            new Cell("idia", "Идея", Abstraction_level.Interface_infinity, Phase_direction.after),

            new Cell("idia", "Необходимость", Abstraction_level.Interface_abstract, Phase_direction.invariant),
            new Cell("idia", "Направленность", Abstraction_level.Interface_abstract, Phase_direction.before),
            new Cell("idia", "Несуществование", Abstraction_level.Interface_abstract, Phase_direction.action),
            new Cell("idia", "Отрицание", Abstraction_level.Interface_abstract, Phase_direction.after),

            new Cell("idia", "Необходимость", Abstraction_level.Interface_logical, Phase_direction.invariant),
            new Cell("idia", "Направленность", Abstraction_level.Interface_logical, Phase_direction.before),
            new Cell("idia", "Несуществование", Abstraction_level.Interface_logical, Phase_direction.action),
            new Cell("idia", "Отрицание", Abstraction_level.Interface_logical, Phase_direction.after),

            new Cell("idia", "Цель", Abstraction_level.Interface_target, Phase_direction.invariant),
            new Cell("idia", "Респондент", Abstraction_level.Interface_target, Phase_direction.before),
            new Cell("idia", "Функция", Abstraction_level.Interface_target, Phase_direction.action),
            new Cell("idia", "Состояние", Abstraction_level.Interface_target, Phase_direction.after),

            new Cell("idia", "Точка зрения", Abstraction_level.Interface_functional, Phase_direction.invariant),
            new Cell("idia", "Обобщение", Abstraction_level.Interface_functional, Phase_direction.before),
            new Cell("idia", "Интерфейс", Abstraction_level.Interface_functional, Phase_direction.action),
            new Cell("idia", "Оценка", Abstraction_level.Interface_functional, Phase_direction.after),

            new Cell("idia", "Критерий", Abstraction_level.Interface_session, Phase_direction.invariant),
            new Cell("idia", "Прогноз", Abstraction_level.Interface_session, Phase_direction.before),
            new Cell("idia", "Культура", Abstraction_level.Interface_session, Phase_direction.action),
            new Cell("idia", "История", Abstraction_level.Interface_session, Phase_direction.after),

            new Cell("idia", "Стратегия", Abstraction_level.Interface_politic, Phase_direction.invariant),
            new Cell("idia", "Планирование", Abstraction_level.Interface_politic, Phase_direction.before),
            new Cell("idia", "Обучение", Abstraction_level.Interface_politic, Phase_direction.action),
            new Cell("idia", "Познание", Abstraction_level.Interface_politic, Phase_direction.after),

            new Cell("idia", "Сценарий", Abstraction_level.Interface_control, Phase_direction.invariant),
            new Cell("idia", "Обеспечение", Abstraction_level.Interface_control, Phase_direction.before),
            new Cell("idia", "Проект", Abstraction_level.Interface_control, Phase_direction.action),
            new Cell("idia", "Аудит", Abstraction_level.Interface_control, Phase_direction.after),

            new Cell("idia", "Отношение", Abstraction_level.Interface_exchange, Phase_direction.invariant),
            new Cell("idia", "Помощь", Abstraction_level.Interface_exchange, Phase_direction.before),
            new Cell("idia", "Управление", Abstraction_level.Interface_exchange, Phase_direction.action),
            new Cell("idia", "Учет", Abstraction_level.Interface_exchange, Phase_direction.after),

            new Cell("idia", "Роль", Abstraction_level.Interface_alignment, Phase_direction.invariant),
            new Cell("idia", "Организация", Abstraction_level.Interface_alignment, Phase_direction.before),
            new Cell("idia", "Соревнование", Abstraction_level.Interface_alignment, Phase_direction.action),
            new Cell("idia", "Контроль", Abstraction_level.Interface_alignment, Phase_direction.after),

            new Cell("idia", "Компетентность", Abstraction_level.Interface_technology, Phase_direction.invariant),
            new Cell("idia", "Согласование", Abstraction_level.Interface_technology, Phase_direction.before),
            new Cell("idia", "Реализация", Abstraction_level.Interface_technology, Phase_direction.action),
            new Cell("idia", "Результат", Abstraction_level.Interface_technology, Phase_direction.after),

            new Cell("idia", "Компетентность", Abstraction_level.Interface_above_reality, Phase_direction.invariant),
            new Cell("idia", "Согласование", Abstraction_level.Interface_above_reality, Phase_direction.before),
            new Cell("idia", "Реализация", Abstraction_level.Interface_above_reality, Phase_direction.action),
            new Cell("idia", "Результат", Abstraction_level.Interface_above_reality, Phase_direction.after),

            new Cell("idia", "Компетентность", Abstraction_level.Class_reality, Phase_direction.invariant),
            new Cell("idia", "Согласование", Abstraction_level.Class_reality, Phase_direction.before),
            new Cell("idia", "Реализация", Abstraction_level.Class_reality, Phase_direction.action),
            new Cell("idia", "Результат", Abstraction_level.Class_reality, Phase_direction.after),

            new Cell("idia", "Компетентность", Abstraction_level.Class_below_reality, Phase_direction.invariant),
            new Cell("idia", "Согласование", Abstraction_level.Class_below_reality, Phase_direction.before),
            new Cell("idia", "Реализация", Abstraction_level.Class_below_reality, Phase_direction.action),
            new Cell("idia", "Результат", Abstraction_level.Class_below_reality, Phase_direction.after),

            new Cell("idia", "Компетентность", Abstraction_level.Class_responsibility, Phase_direction.invariant),
            new Cell("idia", "Согласование", Abstraction_level.Class_responsibility, Phase_direction.before),
            new Cell("idia", "Реализация", Abstraction_level.Class_responsibility, Phase_direction.action),
            new Cell("idia", "Результат", Abstraction_level.Class_responsibility, Phase_direction.after),

            new Cell("idia", "Ответственность", Abstraction_level.Class_stability, Phase_direction.invariant),
            new Cell("idia", "Регламент", Abstraction_level.Class_stability, Phase_direction.before),
            new Cell("idia", "Граница", Abstraction_level.Class_stability, Phase_direction.action),
            new Cell("idia", "Устойчивоть", Abstraction_level.Class_stability, Phase_direction.after),

            new Cell("idia", "Процедура", Abstraction_level.Class_parallel, Phase_direction.invariant),
            new Cell("idia", "Взаимодействие", Abstraction_level.Class_parallel, Phase_direction.before),
            new Cell("idia", "Экземпляр", Abstraction_level.Class_parallel, Phase_direction.action),
            new Cell("idia", "Завершение", Abstraction_level.Class_parallel, Phase_direction.after),

            new Cell("idia", "Требование", Abstraction_level.Class_specialist, Phase_direction.invariant),
            new Cell("idia", "Поставщик", Abstraction_level.Class_specialist, Phase_direction.before),
            new Cell("idia", "Продукция", Abstraction_level.Class_specialist, Phase_direction.action),
            new Cell("idia", "Потребитель", Abstraction_level.Class_specialist, Phase_direction.after),

            new Cell("idia", "Состав", Abstraction_level.Class_process, Phase_direction.invariant),
            new Cell("idia", "Вход", Abstraction_level.Class_process, Phase_direction.before),
            new Cell("idia", "Процесс", Abstraction_level.Class_process, Phase_direction.action),
            new Cell("idia", "Выход", Abstraction_level.Class_process, Phase_direction.after),

            new Cell("idia", "Знание", Abstraction_level.Class_system, Phase_direction.invariant),
            new Cell("idia", "Система", Abstraction_level.Class_system, Phase_direction.before),
            new Cell("idia", "Альтернатива", Abstraction_level.Class_system, Phase_direction.action),
            new Cell("idia", "Использование", Abstraction_level.Class_system, Phase_direction.after),

            new Cell("idia", "Правило", Abstraction_level.Class_structure, Phase_direction.invariant),
            new Cell("idia", "Структура", Abstraction_level.Class_structure, Phase_direction.before),
            new Cell("idia", "Субъект", Abstraction_level.Class_structure, Phase_direction.action),
            new Cell("idia", "Ресурс", Abstraction_level.Class_structure, Phase_direction.after),

            new Cell("idia", "Сущность", Abstraction_level.Class_tuple, Phase_direction.invariant),
            new Cell("idia", "Объект", Abstraction_level.Class_tuple, Phase_direction.before),
            new Cell("idia", "Сообщение", Abstraction_level.Class_tuple, Phase_direction.action),
            new Cell("idia", "Сигнал", Abstraction_level.Class_tuple, Phase_direction.after),

            new Cell("exists", "Существование", Abstraction_level.Class_domain, Phase_direction.invariant),
            new Cell("relation", "Связь", Abstraction_level.Class_domain, Phase_direction.before),
            new Cell("possibility", "Возможность", Abstraction_level.Class_domain, Phase_direction.action),
            new Cell("chaos", "Случайность", Abstraction_level.Class_domain, Phase_direction.after),

            new Cell("exists", "Существование", Abstraction_level.Class_void, Phase_direction.invariant),
            new Cell("relation", "Связь", Abstraction_level.Class_void, Phase_direction.before),
            new Cell("possibility", "Возможность", Abstraction_level.Class_void, Phase_direction.action),
            new Cell("chaos", "Случайность", Abstraction_level.Class_void, Phase_direction.after),

            new Cell("empty", "Пустота", Abstraction_level.Class_infinity, Phase_direction.invariant),
            new Cell("empty", "Пустота", Abstraction_level.Class_infinity, Phase_direction.before),
            new Cell("empty", "Пустота", Abstraction_level.Class_infinity, Phase_direction.action),
            new Cell("empty", "Пустота", Abstraction_level.Class_infinity, Phase_direction.after)

        };
    }
}
