// Вид 1: Ничего не принимают, ничего не возвращают
/*
void Method1()
{
    Console.WriteLine("Автор Екатерина К.");
}
*/
// Method1();
//--------------------------------------------------------------------------------------------------

//Вид 2: Что-то принимают, ничего не возвращают
/*
void Method2(string msg)
{
     Console.WriteLine(msg);
}
Method2(msg: "Текст сообщения"); // именованный аргумент - когда необходимо задать значение конкретному аргументу
*/
/*
void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    } 
}
Method21(count: 4, msg: "текст сообщения"); // можно перечислять в любом порядке
*/
//--------------------------------------------------------------------------------------------------

//Вид 3: Ничего не принимают, что-то возвращают
/*
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3(); // можем далее использовать переменную в пограмме
Console.WriteLine(year);
*/
//--------------------------------------------------------------------------------------------------

//Вид 4: Что-то принимают и что-то возвращают

/* через цикл while:
string Method4(int count, string text)
{
    int i = 1;
    string result = String.Empty;

    while (i <= count)
    {
        result += text;
        i++;
    }
    return result;
}

// string res = Method4(10, "aca-");
string res = Method4(text: "==/", count: 5);
Console.WriteLine(res);
*/

/* через цикл for:
string Method4(int count, string text)
{
    string result = String.Empty;

    for (int i = 1; i <= count; i++)
    {
        result += text;
    }
    return result;
}

string res = Method4(text: "==/", count: 5);
Console.WriteLine(res);
*/
//--------------------------------------------------------------------------------------------------

// Цикл в цикле. На примере табицы умножения

/*
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}
*/
//--------------------------------------------------------------------------------------------------

/* Дан текст. В тексте нужно все пробелы заменить черточками, маленькие буквы "к" заменить на
большие "К", а большие "С" заменить на маленькие "с".
*/

string text = "-Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012345
// s[3] // r

string Replase(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result += $"{newValue}";
        else result += $"{text[i]}";
    }
    return result;
}
string newText = Replase(text, ' ', '|');
newText = Replase(newText, 'к', 'К');
newText = Replase(newText, 'с', 'С');

Console.WriteLine(newText);