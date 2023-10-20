## Решение итогового задания к теме "Итоги блока. Выбор специализации".
_Задание Task_1_
Решение:
Применяемые методы.
1. *Prompt* - метод, запрашивающий элементы в виде строк у пользователя.
2. *GetArrey* - метод, заполняющий массив строками, что ввел пользователь, задается рандомный массив от 3 до 5 включительно.
3. *PrintArrey* - метод вывода массива.
4. *FindElement* - принимает строковый массив, происходит создание нового неопределённого массива, который копирует первый исходный массив. Создаёт счетчик, который будет использоваться для пербора позиций второго массива.
Далее через цикл *foreach* будем перебирать элементы первого массива, если длинна элемента меньше или ровняется 3, то второй массив через *count* увеличивается на 1, вставляется элемент из исходного массива. Выйдя из цикла проходит проверка. В случае отсутствия на первой позиции массива элемента это означает пустой массив и выводятся пустые скобки, в другом случае печатается массив.

*Описание кода*
Создаем строковый массив. Методом GetArrey выводим рандомно запрос строки у пользователя для удобства пользователя каждый запрос в отдельной строке.Потом печатается весь массив и через FindElement выводим все строки имеющие в себе не более 3 символов в другом случае выводим пустые скобки.
![схема](diagram.png)
![Alt text](image.png)
