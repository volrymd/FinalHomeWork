*Задача:* 
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.

*Примеры:*
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []

*Решение задачи:*
1. Предлагаем пользователю ввести размер массива.
2. Пользователь каждый элемент массива вводит с клавиатуры, количество элементов, которые ему предлагают вводить равно исходному числу из пункта 1.
3. Каждый элемент конвертируется в string и записывается в массив строк.
4. Исходный массив выводится на экран.
5. Создается счетчик подходящих элементов.
5. Каждый элемент проверяется на количество символов в этом элементе, если оно меньше или равно 3, то этот элемент суммируется в счетчик как +1.
6. Создается новый массив с количеством элеметов равным значению счетчика.
7. Все подходящие элементы записываются в новый массив.
8. Массив выводится на экран.