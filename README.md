Задача:
Написать программу, которая из имеющегося массива строк формирует массив из строк, длинна которых меньше или равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Примеры:
["hello", "2", "world", ":-)"]=>["2", ":-)"]
["1234", "1567", "-2", "computer science"]=>["-2"]
["Russia", "Denmark", "Kazan"]=>[]

Основной код представляет возможность пользователю ввести с клавиатуры строки, после чего программа инициализирует массив с разделением элементов через запятую.
Далее задача решается с помощью трех методов.
1. Метод FilterArray считает количество элементов удовлетворяющих условиям (длинна меньше или равна 3 символа).
2. Метод GetArray создает новый массив длинной равной количеству элементов полученной из метода FilterArray, и заполняет элементами удовлетворяющими условиям (длинна меньше или равна 3 символа).
3. Метод PrintArray распечатывает массив.