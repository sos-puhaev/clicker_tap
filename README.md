# Механика игры Clicker Tap.

Почему выбран подобный подход к реализации механики?

<b>Ответ:</b><br>
  Scriptable Objects позволяют удобно настраивать параметры игры (например, количество валюты за тап) без необходимости изменять код. Это облегчает работу геймдизайнеров.<br><br>
  Использование корутин для автосбора экономит ресурсы, так как это асинхронная операция, и игра не перегружается постоянными проверками.<br><br>
  Модификаторы позволяют гибко настраивать механику игры. Это обеспечивает возможность легко добавлять будущие бонусы или изменения в доход без переписывания основной логики.
