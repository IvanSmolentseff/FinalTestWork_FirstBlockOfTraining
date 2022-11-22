# Задача

Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
_[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]_
_[“1234”, “1567”, “-2”, “computer science”] → [“-2”]_
*[“Russia”, “Denmark”, “Kazan”] → []*
____
## Решение

### Алгоритм
1. Задаём начальный массив строк посредством ввода через клавиатуру.
2. Создаём главный метод решения:
    - вводим аргументы максимальной длины строки и счётчика
    - задаём результирующий массив, равный по размеру исходному
    - перебираем массив циклом/оператором **_foreach_** 
    - в цикле foreach каждую строку массива проверяем условиям задачи; если строка подходит, то записываем её в результирующий массив
    - далее методом **_Array.Resize_** изменяем количество строк в результирующем массиве до величины счётчика.
3. Создаём метод вывода результата на печать
    - ипользуем операторы **_ if / else_**

### Примечание
Строку кода 25 можно удалить, код останется рабочим. Различие будет только в размере результирующего массива.
В случае удаления этой строки кода размер массива останется неизменным, и заполнен он будет удовлетворяющими условиям и пустыми строками.  
____


