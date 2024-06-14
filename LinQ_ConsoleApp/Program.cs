// See https://aka.ms/new-console-template for more information

/*
 Задание: Найти всех студентов, у которых средний балл больше 4.5. (Добавить в класс Student свойство AverageGrade)
Задание: Найти максимальное значение среди всех элементов коллекции
 Задание: Найти сумму всех чисел в коллекции, возводя каждое число в квадрат перед сложением
 Задание: Проверить, содержится ли хотя бы один отрицательный элемент в коллекции.
 Получить список уникальных элементов в коллекции.
Отсортировать коллекцию в порядке убывания и выбрать первые 5 элементов.
*/

using LinQ_ConsoleApp;

Console.WriteLine("Hello, World!");

var listStd = Student.GetStudents();


var selectedStudents = listStd
    .Where(el => el.AverageGrade >= 4.5)
    .OrderByDescending(el => el.AverageGrade)
    .ToList();

Console.WriteLine(string.Join(Environment.NewLine,selectedStudents));


List<int> listInts = new List<int>(){3,6,98,65};

Console.WriteLine(listInts.Max());


List<int> listFromSummaInts = new List<int>() { 3, 6, 98, 65 };

var summaList = listFromSummaInts
    .Select(el=>Math.Pow(el,2) )
    .Sum();

Console.WriteLine(summaList);


List<int> listOtricatelnoeChislo = new List<int>() { 3, 6, -98, 65 };

var isAny = listOtricatelnoeChislo.Any(el => el <0);

Console.WriteLine(isAny);


List<int> listnotUnicCollection = new List<int>() { 3, 6, 3, 65, 6 };
var discInt = listnotUnicCollection.Distinct().ToList();

Console.WriteLine(string.Join("; ", discInt));

List<int> listSortedCollection = new List<int>() { 3, 6, 3, 65, 6, -8, 56 };


var sortedcollection = listSortedCollection.Order().ToList();

Console.WriteLine(string.Join("; ", sortedcollection));