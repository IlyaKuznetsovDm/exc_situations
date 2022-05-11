// See https://aka.ms/new-console-template for more information
EnterInt();

 void EnterInt()
{
    string s=Console.ReadLine();
    int i=0;
    try
    {
        i = int.Parse(s);
    }
    catch (OverflowException ex)
    {
        Console.WriteLine("ого , многовато");
    }
    catch(FormatException)
    {
        throw new Exception("Нечего буквы вводить. Число - это только цифры");
    }
    catch(Exception e)
    {
        Console.WriteLine("Какое то другое исключение. Сам смотри текст: {0}",e.Message);
    }
    finally
    {
        Console.WriteLine("Блок finaly. Он выполняется всегда.");
    }
    if (i < 0) throw new MustBeMoreThenZeroExpection(i);
}
class MustBeMoreThenZeroExpection:Exception
{
    public MustBeMoreThenZeroExpection(int enteredValue)
        : base(string.Format("A-A-A. Число то должно быть больше 0." +
            "А ты вводишь {0}, не хорошо",enteredValue))
    {  
        EnteredValue = enteredValue;
    }
    public int EnteredValue { get; private set; } //расширям базовый класс
}