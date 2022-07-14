using static System.Console;
using static System.Convert;

WriteLine();
WriteLine("18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y");

bool logic(bool x, bool y)
{
    return !(x || y) == (!x && !y);
}

WriteLine("Таблица истинности");

for (int i = 0; i < 2; i++)
{
    if (i == 0)
    {
       WriteLine("При X - true, начиная с Y - true");
       WriteLine($"{logic(true, true)} {logic(true, false)}"); 
    }
    else
    {
        WriteLine("При X - false, начиная с Y - true");
        WriteLine($"{logic(false, true)} {logic(false, false)}");;
    }
}
