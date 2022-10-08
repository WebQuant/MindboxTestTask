# Тестовое задание MindBox Junior/Middle C#

## Вопрос №1

***Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам.***

Дополнительно к работоспособности оценим:
- Юнит-тесты
- Легкость добавления других фигур
- Вычисление площади фигуры без знания типа фигуры в compile-time
- Проверку на то, является ли треугольник прямоугольным

---
Код тестового консольного проекта для демонстрации работы библиотеки находится по следующей [ссылке](https://github.com/WebQuant/MindboxTestTask/blob/main/MindBoxTestTask/MindBoxTestTask/Program.cs).

Код самой библиотеки по следующей [ссылке](https://github.com/WebQuant/MindboxTestTask/blob/main/MindBoxTestTask/Lib/CalcArea.cs).

Код юнит-тестов находится [здесь](https://github.com/WebQuant/MindboxTestTask/blob/main/MindBoxTestTask/LibTest/Tests.cs).


## Вопрос №2
***В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.***

---
Создаются таблицы с продуктами и категориями, где в каждой хранится их идентификатор и название (или имя). Помимо них создается ещё одна таблица, которая будет хранить данные о принадлежности продукта той или иной категории.

```
CREATE TABLE Products(id INT PRIMARY KEY, name NVARCHAR(255) NOT NULL);
CREATE TABLE Categories(id INT PRIMARY KEY, name NVARCHAR(255) NOT NULL);
CREATE TABLE ProductCategories(product_id INT NOT NULL, category_id INT NULL);
```

Далее необходимо заполнить данными все таблицы, при этом сделать это таким образом, чтобы проверить все условия текущей задачи. Т. е. нужно добавить несколько товаров относящихся к одной категории, один товар имеющий несколько категорий и один товар не имеющий категорий.

```
INSERT INTO Categories VALUES(1, N'Смартфоны '), (2, N'Компьютерная техника'), (3, N'Планшеты ');
INSERT INTO Products VALUES(1, N'Realme 8i 4/64 ГБ RU'), (2, N'Realme 8i 4/128 ГБ RU'), (3, N'Xiaomi Pad 5, Global, 6 ГБ/128 ГБ'), (4, N'Liebherr CNPel 4313');
INSERT INTO ProductCategories VALUES(1, 1), (2, 1), (3, 2), (3, 3), (4, NULL);
```

Решение задачи выглядит следующим образом:

```
SELECT prod.name [Продукт], cat.name [Категория] FROM Products prod
    JOIN ProductCategories prodcat ON prod.id = prodcat.product_id
    LEFT JOIN Categories cat ON cat.id = prodcat.category_id
ORDER BY prod.name;
```

Результат запроса:
![Резульатат запроса на выборку](https://github.com/WebQuant/MindboxTestTask/blob/main/result.png)

Протестировано на платформе https://sqliteonline.com/.
