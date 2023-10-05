using _66._Plus_One;

Solution solution = new Solution();

// Тест 1: Проверка добавления единицы к числу без переполнения
int[] test1 = { 1, 2, 3 };
int[] result1 = solution.PlusOne(test1);
Console.WriteLine("Результат теста 1: " + string.Join(", ", result1)); // Ожидаемый результат: 1, 2, 4

// Тест 2: Проверка добавления единицы с переполнением
int[] test2 = { 9, 9, 9 };
int[] result2 = solution.PlusOne(test2);
Console.WriteLine("Результат теста 2: " + string.Join(", ", result2)); // Ожидаемый результат: 1, 0, 0, 0

// Тест 3: Проверка добавления единицы к нулю
int[] test3 = { 0 };
int[] result3 = solution.PlusOne(test3);
Console.WriteLine("Результат теста 3: " + string.Join(", ", result3)); // Ожидаемый результат: 1