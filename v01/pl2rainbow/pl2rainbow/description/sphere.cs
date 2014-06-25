using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using Ab_lv = pl2.rainbow.description.Abstraction_level_enum;

namespace pl2.rainbow.description
{
    public class Sphere
    {
        public static Abstraction_system[] abstruction_collection = 
        {
            new Abstraction_system(Ab_lv.Class_C_infinity, "Пустота", 
               Importance_enum.reserved, "Пустое", "Пустой", Color.FromArgb( 96 , 0 , 160 )) ,
            new Abstraction_system(Ab_lv.Class_B_void, "Пространство", 
               Importance_enum.reserved, "Наполняемое", "Наполняемый", Color.FromArgb( 80 , 0 , 176 )),
            new Abstraction_system(Ab_lv.Class_A_domain, "Астрофизика", 
               Importance_enum.probably, "Доменное", "Хаотический", Color.FromArgb( 64 , 0 , 192 )),
            new Abstraction_system(Ab_lv.Class_9_tuple, "Физика", 
               Importance_enum.important, "Кортежное", "Физический", Color.FromArgb( 32 , 32 , 255 )),
            new Abstraction_system(Ab_lv.Class_8_structure, "Химия", 
               Importance_enum.main, "Структурное", "Канальный", Color.FromArgb( 0 , 96 , 160 )),
            new Abstraction_system(Ab_lv.Class_7_system, "Биология", 
               Importance_enum.main, "Системное", "Системный", Color.FromArgb( 0 , 112 , 144 )),
            new Abstraction_system(Ab_lv.Class_6_process, "Психология", 
               Importance_enum.important, "Процессное", "Межсетевой", Color.FromArgb( 0 , 128 , 128 )),
            new Abstraction_system(Ab_lv.Class_5_specialist, "Социология", 
               Importance_enum.important, "Специальное", "Специализированный", Color.FromArgb( 0 , 144 , 112 )),
            new Abstraction_system(Ab_lv.Class_4_parallel, "Экономика", 
               Importance_enum.probably, "Параллельное", "Параллельный", Color.FromArgb( 0 , 160 , 96 )),
            new Abstraction_system(Ab_lv.Class_3_stability, "Синергетика", 
               Importance_enum.probably, "Устойчивое", "Устойчивый", Color.FromArgb( 0 , 176 , 80 )),
            new Abstraction_system(Ab_lv.Class_2_technology, "Устойчивость", 
               Importance_enum.reserved, "Технологическое", "Технологический", Color.FromArgb( 0 , 192 , 64 )),
            new Abstraction_system(Ab_lv.Class_1_below_reality, "Нижний приреал", 
               Importance_enum.reserved, "Нижний приреал", "Нижний приреал", Color.FromArgb( 0 , 208 , 32 )),
            new Abstraction_system(Ab_lv.Class_0_reality, "Преобразование", 
               Importance_enum.probably, "Преобразующее", "Преобразование", Color.FromArgb( 32, 255 , 32 )),
            new Abstraction_system(Ab_lv.Interface_1_above_reality, "Верхний приреал", 
               Importance_enum.reserved, "Верхний приреал", "Верхний приреал", Color.FromArgb( 32 , 208 , 0 )),
            new Abstraction_system(Ab_lv.Interface_2_responsibility, "Технология", 
               Importance_enum.reserved, "Ответственное", "Ответственный", Color.FromArgb( 64 , 192 , 0 )),
            new Abstraction_system(Ab_lv.Interface_3_exchange, "Спорт", 
               Importance_enum.probably, "Оценивающее", "Оценивающий", Color.FromArgb( 80 , 176 , 0 )),
            new Abstraction_system(Ab_lv.Interface_4_control, "Маркетинг", 
               Importance_enum.probably, "Обменное", "Обменный", Color.FromArgb( 96 , 160 , 0 )),
            new Abstraction_system(Ab_lv.Interface_5_algorithm, "Менеджмент", 
               Importance_enum.important, "Управляющее", "Управляющий", Color.FromArgb( 128 , 128 , 0 )),
            new Abstraction_system(Ab_lv.Interface_6_politic, "Политология", 
               Importance_enum.important, "Транспортное", "Транспортный", Color.FromArgb( 160 , 96 , 0 )),
            new Abstraction_system(Ab_lv.Interface_7_session, "Культурология", 
               Importance_enum.main, "Сеансовое", "Сеансовый", Color.FromArgb( 176 , 80 , 0 )),
            new Abstraction_system(Ab_lv.Interface_8_functional, "Философия", 
               Importance_enum.main, "Функциональное", "Представительский", Color.FromArgb( 192 , 64 , 0 )),
            new Abstraction_system(Ab_lv.Interface_9_target, "Религиоведение", 
               Importance_enum.important, "Целевое", "Прикладной", Color.FromArgb( 255 , 32 , 32 )),
            new Abstraction_system(Ab_lv.Interface_A_logical, "Логика", 
               Importance_enum.probably, "Логическое", "Логический", Color.FromArgb( 224 , 0 , 32 )),
            new Abstraction_system(Ab_lv.Interface_B_abstract, "Моделирование", 
               Importance_enum.reserved, "Абстрактное", "Абстрактный", Color.FromArgb( 192 , 0 , 64 )),
            new Abstraction_system(Ab_lv.Interface_C_infinity, "Идея", 
               Importance_enum.reserved, "Идейное", "Мыслимый", Color.FromArgb( 176 , 0 , 80 ))
        };

        public static Cell_system[] cell_collection =
        {
            new Cell_system("Idia_invariant", "Идея", Ab_lv.Interface_C_infinity, Phase_direction_enum.invariant),
            new Cell_system("Idia_before", "Идея", Ab_lv.Interface_C_infinity, Phase_direction_enum.before),
            new Cell_system("Idia_action", "Идея", Ab_lv.Interface_C_infinity, Phase_direction_enum.action),
            new Cell_system("Idia_after", "Идея", Ab_lv.Interface_C_infinity, Phase_direction_enum.after),

            new Cell_system("Need", "Необходимость", Ab_lv.Interface_B_abstract, Phase_direction_enum.invariant),
            new Cell_system("Directivity", "Направленность", Ab_lv.Interface_B_abstract, Phase_direction_enum.before),
            new Cell_system("Non_existence", "Несуществование", Ab_lv.Interface_B_abstract, Phase_direction_enum.action),
            new Cell_system("Denial", "Отрицание", Ab_lv.Interface_B_abstract, Phase_direction_enum.after),

            new Cell_system("Need", "Необходимость", Ab_lv.Interface_A_logical, Phase_direction_enum.invariant),
            new Cell_system("Directivity", "Направленность", Ab_lv.Interface_A_logical, Phase_direction_enum.before),
            new Cell_system("Non_existence", "Несуществование", Ab_lv.Interface_A_logical, Phase_direction_enum.action),
            new Cell_system("Denial", "Отрицание", Ab_lv.Interface_A_logical, Phase_direction_enum.after),

            new Cell_system("Purpose", "Цель", Ab_lv.Interface_9_target, Phase_direction_enum.invariant),
            new Cell_system("Respondent", "Респондент", Ab_lv.Interface_9_target, Phase_direction_enum.before),
            new Cell_system("Function", "Функция", Ab_lv.Interface_9_target, Phase_direction_enum.action),
            new Cell_system("Status", "Состояние", Ab_lv.Interface_9_target, Phase_direction_enum.after),

            new Cell_system("Point_of_view", "Точка зрения", Ab_lv.Interface_8_functional, Phase_direction_enum.invariant),
            new Cell_system("Generalization", "Обобщение", Ab_lv.Interface_8_functional, Phase_direction_enum.before),
            new Cell_system("Interface", "Интерфейс", Ab_lv.Interface_8_functional, Phase_direction_enum.action),
            new Cell_system("Assessment", "Оценка", Ab_lv.Interface_8_functional, Phase_direction_enum.after),

            new Cell_system("Criterion", "Критерий", Ab_lv.Interface_7_session, Phase_direction_enum.invariant),
            new Cell_system("Forecast", "Прогноз", Ab_lv.Interface_7_session, Phase_direction_enum.before),
            new Cell_system("Culture", "Культура", Ab_lv.Interface_7_session, Phase_direction_enum.action),
            new Cell_system("History", "История", Ab_lv.Interface_7_session, Phase_direction_enum.after),

            new Cell_system("Strategy", "Стратегия", Ab_lv.Interface_6_politic, Phase_direction_enum.invariant),
            new Cell_system("Planning", "Планирование", Ab_lv.Interface_6_politic, Phase_direction_enum.before),
            new Cell_system("Training", "Обучение", Ab_lv.Interface_6_politic, Phase_direction_enum.action),
            new Cell_system("Knowledge", "Познание", Ab_lv.Interface_6_politic, Phase_direction_enum.after),

            new Cell_system("Scenario", "Сценарий", Ab_lv.Interface_5_algorithm, Phase_direction_enum.invariant),
            new Cell_system("Support", "Обеспечение", Ab_lv.Interface_5_algorithm, Phase_direction_enum.before),
            new Cell_system("Project", "Проект", Ab_lv.Interface_5_algorithm, Phase_direction_enum.action),
            new Cell_system("Audit", "Аудит", Ab_lv.Interface_5_algorithm, Phase_direction_enum.after),

            new Cell_system("Dependence", "Отношение", Ab_lv.Interface_4_control, Phase_direction_enum.invariant),
            new Cell_system("Help", "Помощь", Ab_lv.Interface_4_control, Phase_direction_enum.before),
            new Cell_system("Control", "Управление", Ab_lv.Interface_4_control, Phase_direction_enum.action),
            new Cell_system("Account", "Учет", Ab_lv.Interface_4_control, Phase_direction_enum.after),
            
            new Cell_system("Role", "Роль", Ab_lv.Interface_3_exchange, Phase_direction_enum.invariant),
            new Cell_system("Organization", "Организация", Ab_lv.Interface_3_exchange, Phase_direction_enum.before),
            new Cell_system("Competition", "Соревнование", Ab_lv.Interface_3_exchange, Phase_direction_enum.action),
            new Cell_system("Monitoring", "Контроль", Ab_lv.Interface_3_exchange, Phase_direction_enum.after),

            new Cell_system("Competence", "Компетентность", Ab_lv.Interface_2_responsibility, Phase_direction_enum.invariant),
            new Cell_system("Coordination", "Согласование", Ab_lv.Interface_2_responsibility, Phase_direction_enum.before),
            new Cell_system("Implementation", "Реализация", Ab_lv.Interface_2_responsibility, Phase_direction_enum.action),
            new Cell_system("Result", "Результат", Ab_lv.Interface_2_responsibility, Phase_direction_enum.after),

            new Cell_system("Competence", "Компетентность", Ab_lv.Interface_1_above_reality, Phase_direction_enum.invariant),
            new Cell_system("Coordination", "Согласование", Ab_lv.Interface_1_above_reality, Phase_direction_enum.before),
            new Cell_system("Implementation", "Реализация", Ab_lv.Interface_1_above_reality, Phase_direction_enum.action),
            new Cell_system("Result", "Результат", Ab_lv.Interface_1_above_reality, Phase_direction_enum.after),

            new Cell_system("Competence", "Компетентность", Ab_lv.Class_0_reality, Phase_direction_enum.invariant),
            new Cell_system("Coordination", "Согласование", Ab_lv.Class_0_reality, Phase_direction_enum.before),
            new Cell_system("Implementation", "Реализация", Ab_lv.Class_0_reality, Phase_direction_enum.action),
            new Cell_system("Result", "Результат", Ab_lv.Class_0_reality, Phase_direction_enum.after),

            new Cell_system("Competence", "Компетентность", Ab_lv.Class_1_below_reality, Phase_direction_enum.invariant),
            new Cell_system("Coordination", "Согласование", Ab_lv.Class_1_below_reality, Phase_direction_enum.before),
            new Cell_system("Implementation", "Реализация", Ab_lv.Class_1_below_reality, Phase_direction_enum.action),
            new Cell_system("Result", "Результат", Ab_lv.Class_1_below_reality, Phase_direction_enum.after),

            new Cell_system("Competence", "Компетентность", Ab_lv.Class_2_technology, Phase_direction_enum.invariant),
            new Cell_system("Coordination", "Согласование", Ab_lv.Class_2_technology, Phase_direction_enum.before),
            new Cell_system("Implementation", "Реализация", Ab_lv.Class_2_technology, Phase_direction_enum.action),
            new Cell_system("Result", "Результат", Ab_lv.Class_2_technology, Phase_direction_enum.after),

            new Cell_system("Responsibility", "Ответственность", Ab_lv.Class_3_stability, Phase_direction_enum.invariant),
            new Cell_system("Regulations", "Регламент", Ab_lv.Class_3_stability, Phase_direction_enum.before),
            new Cell_system("Boundary", "Граница", Ab_lv.Class_3_stability, Phase_direction_enum.action),
            new Cell_system("Stability", "Устойчивоcть", Ab_lv.Class_3_stability, Phase_direction_enum.after),

            new Cell_system("Procedure", "Процедура", Ab_lv.Class_4_parallel, Phase_direction_enum.invariant),
            new Cell_system("Interaction", "Взаимодействие", Ab_lv.Class_4_parallel, Phase_direction_enum.before),
            new Cell_system("Instance", "Экземпляр", Ab_lv.Class_4_parallel, Phase_direction_enum.action),
            new Cell_system("Completion", "Завершение", Ab_lv.Class_4_parallel, Phase_direction_enum.after),

            new Cell_system("Requirement", "Требование", Ab_lv.Class_5_specialist, Phase_direction_enum.invariant),
            new Cell_system("Supplier", "Поставщик", Ab_lv.Class_5_specialist, Phase_direction_enum.before),
            new Cell_system("Production", "Продукция", Ab_lv.Class_5_specialist, Phase_direction_enum.action),
            new Cell_system("Customer", "Потребитель", Ab_lv.Class_5_specialist, Phase_direction_enum.after),

            new Cell_system("Composition", "Состав", Ab_lv.Class_6_process, Phase_direction_enum.invariant),
            new Cell_system("Input", "Вход", Ab_lv.Class_6_process, Phase_direction_enum.before),
            new Cell_system("Process", "Процесс", Ab_lv.Class_6_process, Phase_direction_enum.action),
            new Cell_system("Output", "Выход", Ab_lv.Class_6_process, Phase_direction_enum.after),

            new Cell_system("Erudition", "Знание", Ab_lv.Class_7_system, Phase_direction_enum.invariant),
            new Cell_system("System", "Система", Ab_lv.Class_7_system, Phase_direction_enum.before),
            new Cell_system("Alternative", "Альтернатива", Ab_lv.Class_7_system, Phase_direction_enum.action),
            new Cell_system("Use", "Использование", Ab_lv.Class_7_system, Phase_direction_enum.after),

            new Cell_system("Rule", "Правило", Ab_lv.Class_8_structure, Phase_direction_enum.invariant),
            new Cell_system("Structure", "Структура", Ab_lv.Class_8_structure, Phase_direction_enum.before),
            new Cell_system("Subject", "Субъект", Ab_lv.Class_8_structure, Phase_direction_enum.action),
            new Cell_system("Resource", "Ресурс", Ab_lv.Class_8_structure, Phase_direction_enum.after),

            new Cell_system("Entity", "Сущность", Ab_lv.Class_9_tuple, Phase_direction_enum.invariant),
            new Cell_system("Object", "Объект", Ab_lv.Class_9_tuple, Phase_direction_enum.before),
            new Cell_system("Message", "Сообщение", Ab_lv.Class_9_tuple, Phase_direction_enum.action),
            new Cell_system("Event", "Событие", Ab_lv.Class_9_tuple, Phase_direction_enum.after),

            new Cell_system("Exists", "Существование", Ab_lv.Class_A_domain, Phase_direction_enum.invariant),
            new Cell_system("Relation", "Связь", Ab_lv.Class_A_domain, Phase_direction_enum.before),
            new Cell_system("Possibility", "Возможность", Ab_lv.Class_A_domain, Phase_direction_enum.action),
            new Cell_system("Chaos", "Случайность", Ab_lv.Class_A_domain, Phase_direction_enum.after),

            new Cell_system("Exists", "Существование", Ab_lv.Class_B_void, Phase_direction_enum.invariant),
            new Cell_system("Relation", "Связь", Ab_lv.Class_B_void, Phase_direction_enum.before),
            new Cell_system("Possibility", "Возможность", Ab_lv.Class_B_void, Phase_direction_enum.action),
            new Cell_system("Chaos", "Случайность", Ab_lv.Class_B_void, Phase_direction_enum.after),

            new Cell_system("Empty_invariant", "Пустота", Ab_lv.Class_C_infinity, Phase_direction_enum.invariant),
            new Cell_system("Empty_before", "Пустота", Ab_lv.Class_C_infinity, Phase_direction_enum.before),
            new Cell_system("Empty_action", "Пустота", Ab_lv.Class_C_infinity, Phase_direction_enum.action),
            new Cell_system("Empty_after", "Пустота", Ab_lv.Class_C_infinity, Phase_direction_enum.after)

        };
    }
}
