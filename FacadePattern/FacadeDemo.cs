//Създайте програма, която да връща информация на потребителя
//относно ценоразписа на различни видове хотелски стаи. 
//Направете клиентския код възможно най-опростен, изпозлвайки Facade шаблон.

using FacadeDesignPattern;

public class FacadeDemo
{
    static void Main()
    {  
        RoomPrice price = new RoomPrice();

        price.Single();
        price.Double();
        price.Triple();

    }
}
