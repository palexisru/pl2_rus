﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace pl2.rainbow.description
{
    public enum Abstraction_level
    {
        Class_infinity = -11 , // пустой тип - void, empty, nil, null

        Class_domain = -10 , // элементарный класс среды исполнения (ValueType)

        Class_tuple = -9 , // связь между указанными объектами (аналогично предложениям Prolog, списку параметров функций), методы и свойства отсутствуют, доступ происходит только к открытым членам. По возможностям аналогично набору, возвращаемому из реляционной базы данных

        Class_structure = -8 , // структура с открытыми элементами. Для доступа к элементу текущего объекта используется слово this. Может содержать методы для обработки.

        Class_system = -7 , // система, которая может содержать закрытые и защищенные наследуемые элементы.

        Class_process = -6 , // процесс, которому можно передать инициализирующие значения и получить результирующие значения. Соответствует службе. Любой метод получает не только указатель на себя (this), но и указатель на вызвавший класс или объект (sender). Это позволяет проверить авторизацию объекта, осуществляющего доступ к методу. Для предотвращения низкоуровневой подмены sender, параметры обрабатываемого события запрашиваются у вызывающего объекта после получения идентификатора сообщения. Содержит стандартные методы.

        Class_specialist = -5 , // специализированный класс, который выполняет указанный соглашениями набор функций. Соответствует COM-модели. Поддерживает свойство possibility с интерфейсом control interface

        Class_parallel = -4 , // асинхронно работающий класс, передающий сообщения о выполнении задачи. Поддерживает свойство manager с интерфейсом exchange interface

        Class_responsibility = -3 , // таможня, обеспечивающее ответственность за выполнение задачи. Поддерживает свойство environment с интерфейсом concurent interface

        Class_executive = -2 , // исполняемый класс

        Class_below_reality = -1 , // нижний приреал

        Class_reality = 0 , //экватор реальности

        Interface_above_reality = 1 , //верхний приреал

        Interface_technology = 2 , // технологические элементы

        Interface_concurent = 3 , // оценка соответствия с внешними аналогами

        Interface_exchange = 4 , // взаимодействие с окружающей средой

        Interface_control = 5 , // описание управления

        Interface_politic = 6 , // описание стратегии

        Interface_session = 7 , // интерфейсы для хранения текущего состояния

        Interface_functional = 8 , // функциональные связи, конечные автоматы

        Interface_target = 9 , //  описание целевых функций

        Interface_logical = 10 , //   логические элементы

        Interface_infinity = 11 // универсальный интерфейс

    }
}
