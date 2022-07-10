using static System.Console;
using static System.Convert;

WriteLine("3. По заданному номеру дня недели вывести его название");

string Week(int day)
{
return day switch
{
1 => "Будний: понедельник",
2 => "Будний: вторник",
3 => "Будний: среда",
4 => "Будний: четверг",
5 => "Будний: пятница",
6 => "Выходной: суббота",
7 => "Выходной: воскресенье",
_ => "нет дня недели с таким номером"
};
}
WriteLine(Week(ToInt32(ReadLine())));


WriteLine();
WriteLine("16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным");

WriteLine(Week(ToInt32(ReadLine())));
