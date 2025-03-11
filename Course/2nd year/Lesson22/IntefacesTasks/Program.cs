using System;

// Настрой интерфейсы для шутников и клоунов так чтобы все заработало 

// Шуточный интерфейс "Способность танцевать"
interface IDanceable
{
    public void Dance();
}

// Шуточный интерфейс "Способность петь"
interface ISingable
{
    public void Sing();
}


internal interface ITalkable
{
    public void Talk();
}

internal interface IJokeable
{   
    public void TellJoke();
}

// Класс шутника, реализующий ITalkable, IJokeable, IDanceable и ISingable
class Joker  : ITalkable, ISingable, IDanceable, IJokeable
{
    public void Talk()
    {
        Console.WriteLine("Привет! Я мастер шуток и разговоров.");
    }

    public void TellJoke()
    {
        Console.WriteLine("Почему ученые не доверяют атомам? Потому что они составляют все!");
    }

    public void Dance()
    {
        Console.WriteLine("Я танцую, как будто никто не видит!");
    }

    public void Sing()
    {
        Console.WriteLine("Ла ла ла! Я певчая сенсация!");
    }
}


// Класс клоуна, реализующий ITalkable и IJokeable
class Clown  : ITalkable, IJokeable
{
    public void Talk()
    {
        Console.WriteLine("Привет! Я здесь, чтобы заставить вас улыбнуться.");
    }

    public void TellJoke()
    {
        Console.WriteLine("Почему пугало получило награду? Потому что оно было выдающимся на своем поле!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Создаем экземпляры шутника и клоуна 
        Clown clown1 = new Clown();
        Joker joker1 = new Joker();
        // Используем методы через интерфейсы
        clown1.Talk();
        clown1.TellJoke();
        joker1.Talk();
        joker1.TellJoke();
        joker1.Dance();
        joker1.Sing();
    }
}
