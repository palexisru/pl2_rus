using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Drawing;

namespace pl2.rainbow.description
{
    /// <summary>
    /// Уровень абстрактности
    /// </summary>
    public enum Abstraction_level_enum
    {
        Class_infinity = -12 , // абсолютная пустота

        Class_void = -11 , // пустой тип - void, empty, nil, null

        Class_domain = -10 , // элементарный класс среды исполнения (ValueType)

        Class_tuple = -9 , // связь между указанными объектами (аналогично предложениям Prolog, списку параметров функций), методы и свойства отсутствуют, доступ происходит только к открытым членам. По возможностям аналогично набору, возвращаемому из реляционной базы данных

        Class_structure = -8 , // структура с открытыми элементами. Для доступа к элементу текущего объекта используется слово this. Может содержать методы для обработки.

        Class_system = -7 , // система, которая может содержать закрытые и защищенные наследуемые элементы.

        Class_process = -6 , // процесс, которому можно передать инициализирующие значения и получить результирующие значения. Соответствует службе. Любой метод получает не только указатель на себя (this), но и указатель на вызвавший класс или объект (sender). Это позволяет проверить авторизацию объекта, осуществляющего доступ к методу. Для предотвращения низкоуровневой подмены sender, параметры обрабатываемого события запрашиваются у вызывающего объекта после получения идентификатора сообщения. Содержит стандартные методы.

        Class_specialist = -5 , // специализированный класс, который выполняет указанный соглашениями набор функций. Соответствует COM-модели. Поддерживает свойство possibility с интерфейсом control interface

        Class_parallel = -4 , // асинхронно работающий класс, передающий сообщения о выполнении задачи. Поддерживает свойство manager с интерфейсом exchange interface

        Class_stability = -3 , // устойчивый класс

        Class_responsibility = -2 , // класс ответственности

        Class_below_reality = -1 , // нижний приреал

        Class_reality = 0 , //экватор реальности

        Interface_above_reality = 1 , // верхний приреал

        Interface_technology = 2 , // технологическое

        Interface_alignment = 3 , // выравнивающее 

        Interface_exchange = 4 , // взаимодействие с окружающей средой

        Interface_control = 5 , // описание управления

        Interface_politic = 6 , // описание стратегии

        Interface_session = 7 , // интерфейсы для хранения текущего состояния

        Interface_functional = 8 , // функциональные связи, конечные автоматы

        Interface_target = 9 , //   логические элементы

        Interface_logical = 10 , //   логические элементы

        Interface_abstract = 11 , // универсальный интерфейс

        Interface_infinity = 12 // абсолютная идея

    }

    /// <summary>
    /// описание компонентов абстрактности
    /// </summary>
    public class Abstraction_system
    {

        [Browsable( true ) , Description( "Уровень абстрактности" ) , Category( "Data" )]
        public Abstraction_level_enum abstraction_level { get; set; }

        [Browsable( true ) , Description( "Раздел знаний" ) , Category( "Data" )]
        public string science { get; set; }

        [Browsable( true ) , Description( "Вид программной единицы" ) , Category( "Data" )]
        public string programming { get; set; }

        [Browsable( true ) , Description( "Уровень модели взаимосвязи открытых систем" ) , Category( "Data" )]
        public string OSI { get; set; }

        [Browsable( true ) , Description( "Важность уровня" ) , Category( "Data" )]
        public Importance_enum importance { get; set; }

        [Browsable( true ) , Description( "Тег уровня" ) , Category( "Data" )]
        public string tag { get{ return abstraction_level.ToString();} }

        [Browsable( true ) , Description( "Численный индекс уровня" ) , Category( "Data" )]
        public Single percent { get { return (Single)abstraction_level; } }

        [Browsable( true ) , Description( "Цвет для вывода уровня" ) , Category( "Data" )]
        public Color color { get; set; }

        public Abstraction_system(Abstraction_level_enum abstraction_level_new , string science_new , Importance_enum importance_new
            , string programming_new , string OSI_new , Color color_new)
        {
            abstraction_level = abstraction_level_new;
            science = science_new;
            programming = programming_new;
            OSI = OSI_new;
            importance = importance_new;
            color = color_new;        
        }
    }
}
