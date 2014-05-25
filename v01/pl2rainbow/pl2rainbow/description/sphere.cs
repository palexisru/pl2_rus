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
               Importance_enum.reserved, "Пустое", "Пустой", Color.FromArgb( 96 , 0 , 160 )) ,
            new Abstraction_system(Abstraction_level_enum.Class_void, "Пространство", 
               Importance_enum.reserved, "Наполняемое", "Наполняемый", Color.FromArgb( 80 , 0 , 176 )),
            new Abstraction_system(Abstraction_level_enum.Class_domain, "Астрофизика", 
               Importance_enum.probably, "Доменное", "Хаотический", Color.FromArgb( 64 , 0 , 192 )),
            new Abstraction_system(Abstraction_level_enum.Class_tuple, "Физика", 
               Importance_enum.important, "Кортежное", "Физический", Color.FromArgb( 32 , 32 , 255 )),
            new Abstraction_system(Abstraction_level_enum.Class_structure, "Химия", 
               Importance_enum.main, "Структурное", "Канальный", Color.FromArgb( 0 , 96 , 160 )),
            new Abstraction_system(Abstraction_level_enum.Class_system, "Биология", 
               Importance_enum.main, "Системное", "Системный", Color.FromArgb( 0 , 112 , 144 )),
            new Abstraction_system(Abstraction_level_enum.Class_process, "Психология", 
               Importance_enum.important, "Процессное", "Межсетевой", Color.FromArgb( 0 , 128 , 128 )),
            new Abstraction_system(Abstraction_level_enum.Class_specialist, "Социология", 
               Importance_enum.important, "Специальное", "Специализированный", Color.FromArgb( 0 , 144 , 112 )),
            new Abstraction_system(Abstraction_level_enum.Class_parallel, "Экономика", 
               Importance_enum.probably, "Параллельное", "Параллельный", Color.FromArgb( 0 , 160 , 96 )),
            new Abstraction_system(Abstraction_level_enum.Class_stability, "Синергетика", 
               Importance_enum.probably, "Устойчивое", "Устойчивый", Color.FromArgb( 0 , 176 , 80 )),
            new Abstraction_system(Abstraction_level_enum.Class_responsibility, "Управление", 
               Importance_enum.reserved, "Ответственное", "Ответственный", Color.FromArgb( 0 , 192 , 64 )),
            new Abstraction_system(Abstraction_level_enum.Class_below_reality, "Нижний приреал", 
               Importance_enum.reserved, "Нижний приреал", "Нижний приреал", Color.FromArgb( 0 , 208 , 32 )),
            new Abstraction_system(Abstraction_level_enum.Class_reality, "Преобразование", 
               Importance_enum.probably, "Преобразующее", "Преобразование", Color.FromArgb( 32, 255 , 32 )),
            new Abstraction_system(Abstraction_level_enum.Interface_above_reality, "Верхний приреал", 
               Importance_enum.reserved, "Верхний приреал", "Верхний приреал", Color.FromArgb( 32 , 208 , 0 )),
            new Abstraction_system(Abstraction_level_enum.Interface_technology, "Технология", 
               Importance_enum.reserved, "Технологическое", "Технологический", Color.FromArgb( 64 , 192 , 0 )),
            new Abstraction_system(Abstraction_level_enum.Interface_alignment, "Спорт", 
               Importance_enum.probably, "Выравнивающее", "Выравнивающий", Color.FromArgb( 80 , 176 , 0 )),
            new Abstraction_system(Abstraction_level_enum.Interface_exchange, "Маркетинг", 
               Importance_enum.probably, "Обменное", "Оценивающий", Color.FromArgb( 96 , 160 , 0 )),
            new Abstraction_system(Abstraction_level_enum.Interface_control, "Менеджмент", 
               Importance_enum.important, "Управляющее", "Управляющий", Color.FromArgb( 128 , 128 , 0 )),
            new Abstraction_system(Abstraction_level_enum.Interface_politic, "Политология", 
               Importance_enum.important, "Транспортное", "Транспортный", Color.FromArgb( 160 , 96 , 0 )),
            new Abstraction_system(Abstraction_level_enum.Interface_session, "Культурология", 
               Importance_enum.main, "Сеансовое", "Сеансовый", Color.FromArgb( 176 , 80 , 0 )),
            new Abstraction_system(Abstraction_level_enum.Interface_functional, "Философия", 
               Importance_enum.main, "Функциональное", "Представительский", Color.FromArgb( 192 , 64 , 0 )),
            new Abstraction_system(Abstraction_level_enum.Interface_target, "Религиоведение", 
               Importance_enum.important, "Целевое", "Прикладной", Color.FromArgb( 255 , 32 , 32 )),
            new Abstraction_system(Abstraction_level_enum.Interface_logical, "Логика", 
               Importance_enum.probably, "Логическое", "Логический", Color.FromArgb( 224 , 0 , 32 )),
            new Abstraction_system(Abstraction_level_enum.Interface_abstract, "Моделирование", 
               Importance_enum.reserved, "Абстрактное", "Абстрактный", Color.FromArgb( 192 , 0 , 64 )),
            new Abstraction_system(Abstraction_level_enum.Interface_infinity, "Идея", 
               Importance_enum.reserved, "Идейное", "Мыслимый", Color.FromArgb( 176 , 0 , 80 ))
        };

        public static Cell_system[] cell_collection =
        {
            new Cell_system("Idia_invariant", "Идея", Abstraction_level_enum.Interface_infinity, Phase_direction_enum.invariant),
            new Cell_system("Idia_before", "Идея", Abstraction_level_enum.Interface_infinity, Phase_direction_enum.before),
            new Cell_system("Idia_action", "Идея", Abstraction_level_enum.Interface_infinity, Phase_direction_enum.action),
            new Cell_system("Idia_after", "Идея", Abstraction_level_enum.Interface_infinity, Phase_direction_enum.after),

            new Cell_system("Need", "Необходимость", Abstraction_level_enum.Interface_abstract, Phase_direction_enum.invariant),
            new Cell_system("Directivity", "Направленность", Abstraction_level_enum.Interface_abstract, Phase_direction_enum.before),
            new Cell_system("Non_existence", "Несуществование", Abstraction_level_enum.Interface_abstract, Phase_direction_enum.action),
            new Cell_system("Denial", "Отрицание", Abstraction_level_enum.Interface_abstract, Phase_direction_enum.after),

            new Cell_system("Need", "Необходимость", Abstraction_level_enum.Interface_logical, Phase_direction_enum.invariant),
            new Cell_system("Directivity", "Направленность", Abstraction_level_enum.Interface_logical, Phase_direction_enum.before),
            new Cell_system("Non_existence", "Несуществование", Abstraction_level_enum.Interface_logical, Phase_direction_enum.action),
            new Cell_system("Denial", "Отрицание", Abstraction_level_enum.Interface_logical, Phase_direction_enum.after),

            new Cell_system("Purpose", "Цель", Abstraction_level_enum.Interface_target, Phase_direction_enum.invariant),
            new Cell_system("Respondent", "Респондент", Abstraction_level_enum.Interface_target, Phase_direction_enum.before),
            new Cell_system("Function", "Функция", Abstraction_level_enum.Interface_target, Phase_direction_enum.action),
            new Cell_system("Status", "Состояние", Abstraction_level_enum.Interface_target, Phase_direction_enum.after),

            new Cell_system("Point_of_view", "Точка зрения", Abstraction_level_enum.Interface_functional, Phase_direction_enum.invariant),
            new Cell_system("Generalization", "Обобщение", Abstraction_level_enum.Interface_functional, Phase_direction_enum.before),
            new Cell_system("Interface", "Интерфейс", Abstraction_level_enum.Interface_functional, Phase_direction_enum.action),
            new Cell_system("Assessment", "Оценка", Abstraction_level_enum.Interface_functional, Phase_direction_enum.after),

            new Cell_system("Criterion", "Критерий", Abstraction_level_enum.Interface_session, Phase_direction_enum.invariant),
            new Cell_system("Forecast", "Прогноз", Abstraction_level_enum.Interface_session, Phase_direction_enum.before),
            new Cell_system("Culture", "Культура", Abstraction_level_enum.Interface_session, Phase_direction_enum.action),
            new Cell_system("History", "История", Abstraction_level_enum.Interface_session, Phase_direction_enum.after),

            new Cell_system("Strategy", "Стратегия", Abstraction_level_enum.Interface_politic, Phase_direction_enum.invariant),
            new Cell_system("Planning", "Планирование", Abstraction_level_enum.Interface_politic, Phase_direction_enum.before),
            new Cell_system("Training", "Обучение", Abstraction_level_enum.Interface_politic, Phase_direction_enum.action),
            new Cell_system("Knowledge", "Познание", Abstraction_level_enum.Interface_politic, Phase_direction_enum.after),

            new Cell_system("Scenario", "Сценарий", Abstraction_level_enum.Interface_control, Phase_direction_enum.invariant),
            new Cell_system("Support", "Обеспечение", Abstraction_level_enum.Interface_control, Phase_direction_enum.before),
            new Cell_system("Project", "Проект", Abstraction_level_enum.Interface_control, Phase_direction_enum.action),
            new Cell_system("Audit", "Аудит", Abstraction_level_enum.Interface_control, Phase_direction_enum.after),

            new Cell_system("Dependence", "Отношение", Abstraction_level_enum.Interface_exchange, Phase_direction_enum.invariant),
            new Cell_system("Help", "Помощь", Abstraction_level_enum.Interface_exchange, Phase_direction_enum.before),
            new Cell_system("Control", "Управление", Abstraction_level_enum.Interface_exchange, Phase_direction_enum.action),
            new Cell_system("Account", "Учет", Abstraction_level_enum.Interface_exchange, Phase_direction_enum.after),
            
            new Cell_system("Role", "Роль", Abstraction_level_enum.Interface_alignment, Phase_direction_enum.invariant),
            new Cell_system("Organization", "Организация", Abstraction_level_enum.Interface_alignment, Phase_direction_enum.before),
            new Cell_system("Competition", "Соревнование", Abstraction_level_enum.Interface_alignment, Phase_direction_enum.action),
            new Cell_system("Monitoring", "Контроль", Abstraction_level_enum.Interface_alignment, Phase_direction_enum.after),

            new Cell_system("Competence", "Компетентность", Abstraction_level_enum.Interface_technology, Phase_direction_enum.invariant),
            new Cell_system("Coordination", "Согласование", Abstraction_level_enum.Interface_technology, Phase_direction_enum.before),
            new Cell_system("Implementation", "Реализация", Abstraction_level_enum.Interface_technology, Phase_direction_enum.action),
            new Cell_system("Result", "Результат", Abstraction_level_enum.Interface_technology, Phase_direction_enum.after),

            new Cell_system("Competence", "Компетентность", Abstraction_level_enum.Interface_above_reality, Phase_direction_enum.invariant),
            new Cell_system("Coordination", "Согласование", Abstraction_level_enum.Interface_above_reality, Phase_direction_enum.before),
            new Cell_system("Implementation", "Реализация", Abstraction_level_enum.Interface_above_reality, Phase_direction_enum.action),
            new Cell_system("Result", "Результат", Abstraction_level_enum.Interface_above_reality, Phase_direction_enum.after),

            new Cell_system("Competence", "Компетентность", Abstraction_level_enum.Class_reality, Phase_direction_enum.invariant),
            new Cell_system("Coordination", "Согласование", Abstraction_level_enum.Class_reality, Phase_direction_enum.before),
            new Cell_system("Implementation", "Реализация", Abstraction_level_enum.Class_reality, Phase_direction_enum.action),
            new Cell_system("Result", "Результат", Abstraction_level_enum.Class_reality, Phase_direction_enum.after),

            new Cell_system("Competence", "Компетентность", Abstraction_level_enum.Class_below_reality, Phase_direction_enum.invariant),
            new Cell_system("Coordination", "Согласование", Abstraction_level_enum.Class_below_reality, Phase_direction_enum.before),
            new Cell_system("Implementation", "Реализация", Abstraction_level_enum.Class_below_reality, Phase_direction_enum.action),
            new Cell_system("Result", "Результат", Abstraction_level_enum.Class_below_reality, Phase_direction_enum.after),

            new Cell_system("Competence", "Компетентность", Abstraction_level_enum.Class_responsibility, Phase_direction_enum.invariant),
            new Cell_system("Coordination", "Согласование", Abstraction_level_enum.Class_responsibility, Phase_direction_enum.before),
            new Cell_system("Implementation", "Реализация", Abstraction_level_enum.Class_responsibility, Phase_direction_enum.action),
            new Cell_system("Result", "Результат", Abstraction_level_enum.Class_responsibility, Phase_direction_enum.after),

            new Cell_system("Responsibility", "Ответственность", Abstraction_level_enum.Class_stability, Phase_direction_enum.invariant),
            new Cell_system("Regulations", "Регламент", Abstraction_level_enum.Class_stability, Phase_direction_enum.before),
            new Cell_system("Boundary", "Граница", Abstraction_level_enum.Class_stability, Phase_direction_enum.action),
            new Cell_system("Stability", "Устойчивоcть", Abstraction_level_enum.Class_stability, Phase_direction_enum.after),

            new Cell_system("Procedure", "Процедура", Abstraction_level_enum.Class_parallel, Phase_direction_enum.invariant),
            new Cell_system("Interaction", "Взаимодействие", Abstraction_level_enum.Class_parallel, Phase_direction_enum.before),
            new Cell_system("Instance", "Экземпляр", Abstraction_level_enum.Class_parallel, Phase_direction_enum.action),
            new Cell_system("Completion", "Завершение", Abstraction_level_enum.Class_parallel, Phase_direction_enum.after),

            new Cell_system("Requirement", "Требование", Abstraction_level_enum.Class_specialist, Phase_direction_enum.invariant),
            new Cell_system("Supplier", "Поставщик", Abstraction_level_enum.Class_specialist, Phase_direction_enum.before),
            new Cell_system("Production", "Продукция", Abstraction_level_enum.Class_specialist, Phase_direction_enum.action),
            new Cell_system("Customer", "Потребитель", Abstraction_level_enum.Class_specialist, Phase_direction_enum.after),

            new Cell_system("Composition", "Состав", Abstraction_level_enum.Class_process, Phase_direction_enum.invariant),
            new Cell_system("Input", "Вход", Abstraction_level_enum.Class_process, Phase_direction_enum.before),
            new Cell_system("Process", "Процесс", Abstraction_level_enum.Class_process, Phase_direction_enum.action),
            new Cell_system("Output", "Выход", Abstraction_level_enum.Class_process, Phase_direction_enum.after),

            new Cell_system("Erudition", "Знание", Abstraction_level_enum.Class_system, Phase_direction_enum.invariant),
            new Cell_system("System", "Система", Abstraction_level_enum.Class_system, Phase_direction_enum.before),
            new Cell_system("Alternative", "Альтернатива", Abstraction_level_enum.Class_system, Phase_direction_enum.action),
            new Cell_system("Use", "Использование", Abstraction_level_enum.Class_system, Phase_direction_enum.after),

            new Cell_system("Rule", "Правило", Abstraction_level_enum.Class_structure, Phase_direction_enum.invariant),
            new Cell_system("Structure", "Структура", Abstraction_level_enum.Class_structure, Phase_direction_enum.before),
            new Cell_system("Subject", "Субъект", Abstraction_level_enum.Class_structure, Phase_direction_enum.action),
            new Cell_system("Resource", "Ресурс", Abstraction_level_enum.Class_structure, Phase_direction_enum.after),

            new Cell_system("Entity", "Сущность", Abstraction_level_enum.Class_tuple, Phase_direction_enum.invariant),
            new Cell_system("Object", "Объект", Abstraction_level_enum.Class_tuple, Phase_direction_enum.before),
            new Cell_system("Message", "Сообщение", Abstraction_level_enum.Class_tuple, Phase_direction_enum.action),
            new Cell_system("Signal", "Сигнал", Abstraction_level_enum.Class_tuple, Phase_direction_enum.after),

            new Cell_system("Exists", "Существование", Abstraction_level_enum.Class_domain, Phase_direction_enum.invariant),
            new Cell_system("Relation", "Связь", Abstraction_level_enum.Class_domain, Phase_direction_enum.before),
            new Cell_system("Possibility", "Возможность", Abstraction_level_enum.Class_domain, Phase_direction_enum.action),
            new Cell_system("Chaos", "Случайность", Abstraction_level_enum.Class_domain, Phase_direction_enum.after),

            new Cell_system("Exists", "Существование", Abstraction_level_enum.Class_void, Phase_direction_enum.invariant),
            new Cell_system("Relation", "Связь", Abstraction_level_enum.Class_void, Phase_direction_enum.before),
            new Cell_system("Possibility", "Возможность", Abstraction_level_enum.Class_void, Phase_direction_enum.action),
            new Cell_system("Chaos", "Случайность", Abstraction_level_enum.Class_void, Phase_direction_enum.after),

            new Cell_system("Empty_invariant", "Пустота", Abstraction_level_enum.Class_infinity, Phase_direction_enum.invariant),
            new Cell_system("Empty_before", "Пустота", Abstraction_level_enum.Class_infinity, Phase_direction_enum.before),
            new Cell_system("Empty_action", "Пустота", Abstraction_level_enum.Class_infinity, Phase_direction_enum.action),
            new Cell_system("Empty_after", "Пустота", Abstraction_level_enum.Class_infinity, Phase_direction_enum.after)

        };
    }
}
