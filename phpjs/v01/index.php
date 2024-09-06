<html>
    <head>
        <script>
            const local_dictionary_path="/dict";  // национальные языки вывода ключевых слов
            let local_language_value="ru"; // актуальный язык вывода ключевых слов
            let local_form_id = 1; // номер выводимого раздела с формой
            let local_example_id="000"; // номер разбираемого примера
            let local_debug_string = 0;
            let local_debug_position = 0;
            let console_output = "";
            let console_input;
            let console_key;
            function dummy()
            {
            }
        </script>
        <script type="text/javascript" src="js/pages.js"></script>
        <script type="text/javascript" src="js/examples.js"></script>
        <script type="text/javascript" src="js/questions.js"></script>
        <script type="text/javascript" src="js/intern.js"></script>
        <script type="text/javascript" src="js/lex.js"></script>
        <script type="text/javascript" src="js/syntax.js"></script>
        <script type="text/javascript" src="js/debug.js"></script>
        <script type="text/javascript" src="js/vm.js"></script>
    </head>
    <body onLoad="start_settings_timer(1)">
        Язык программирования PL/2 <span id="rainbow">Ӧшкамӧшка</span><br>

        <div id="page_select">
                <button onClick="set_page(1);">Установки</button>
                <button onClick="set_page(2);">Программа</button>
                <button onClick="set_page(3);">Отладка</button>
                <button onClick="set_page(4);">Тестирование</button>
                <button onClick="set_page(5);">Рекорды</button>
                <button onClick="set_page(6);">Контакты</button>
        </div>

        <div id="settings" style="display:none">
            <h3 align="center" style="background-color:green;color:white;">Установки</h3>
            Язык <select id="kw_lang" onChange="settings_change_language();">
               <option value="en">Английский</option>
               <option value="ru">Русский</option>
               <option value="kv">Коми</option>
               <option value="tt">Татарский</option>
            </select>
        </div>

        <div id="select_source" style="display:none">
            <h3 align="center" style="background-color:green;color:yellow;">Программа</h3>
            Выбор программы<br>
            <select id="example" onChange="source_change();">
                 <option value="000">Здравствуй, мир!</option>
                 <option value="001">Здравствуйте!</option>
            </select>
        </div>

        <div id="debug_source" style="display:none">
            <h3 align="center" style="background-color:yellow;color:red;">Отладка</h3>
            <b>Программа:</b> <span id='program_name'>Пустая</span><br>
            <table border="0" id="program_code">
            </table><p>
            
            <b>Консоль:</b> <button onClick="debug_one_step();">шаг &gt;</button>
                     <button onClick="debug_restart();">сначала</button>
                     <button onClick="debug_next_program();">следующий</button><br>
            <span id="program_output">
            </span><p>
            <b>Переменные:</b><br>
            <table border="1" id="program_variable">
            </table>
        </div>

        <div id="estimate_knowlange" style="display:none">
            <h3 align="center" style="background-color:blue;color:yellow;">Тестирование</h3>
        </div>

        <div id="show_results" style="display:block">
            <h3 align="center" style="background-color:blue;color:yellow;">Рекорды</h3>
        </div>

        <div id="show_contacts" style="display:none">
            <h3 align="center" style="background-color:blue;color:yellow;">Контакты</h3>
            Группа ВКонтакте <a href="https://vk.com/club_pl2" target="blank">vk.com/club_pl2</a><br>
            Страница программы <a href="https://pl2-rainbow.livejournal.com/" target="blank">www.pl2-rainbow.livejournal.com/</a><br>
            Электронная почта для связи с разработчиком pl2-rainbow@mail.ru<br>
            Сайт языка программирования PL/2 <a href="http://pl2lang.ru" target="blank">www.pl2lang.ru</a><br>
            Описание языка программирования PL/2 
                <a href="https://github.com/palexisru/pl2_rus/wiki/Tutorial-Russian" target="blank">
                github.com/palexisru/pl2_rus/wiki/</a><br>
            Первоначальное сообщение о языке PL/2 <a href="https://habr.com/ru/articles/219419/" target="blank">habr.com/ru/articles/219419/</a><br>

        </div>
        <hr>
        <div align="center">&copy; Alexey Podorov, 2024</div>
        <?php
             phpinfo();
        ?>
    </body>
</html>