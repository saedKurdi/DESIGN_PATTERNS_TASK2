#region Single Responsibility Principle


namespace SRP_Before
{

    public class CulinaryExpert
{
    public void CookFood()
    {
        Console.WriteLine("Expert is cooking food !");
    }

    public void CarryFood()
    {
     // ashbaz yemek dasimamalidir onun evezini bunu ofisiant etmelidir !
        Console.WriteLine("Expert is Carrying food !");
    }
}
}

namespace SRP_After
{
    public class CulinaryExpert
    {
        public void CookFood()
        {
            Console.WriteLine("Expert is cooking foood !");
        }
    }
    public class Waiter
    {
        public void CarryFood()
        {
            Console.WriteLine("Waiter is carring the food !");
        }
    }
}



#endregion



#region Open Close Principle

namespace OCP_Before
{
    public class Vocabulary
    {
        public void CallVocabulary(string vocabulary)
        {
            if(vocabulary == "English") Console.WriteLine("English !");
            else if(vocabulary == "Russian") Console.WriteLine("Russian !");
            else if(vocabulary == "German") Console.WriteLine("German !");
            // ... ... 
        }
    }
}

namespace OCP_After
{
    public interface IVocabulary
    {
        public void PrintVocabulary();
    }

    public class EnglishVocabulary : IVocabulary
    {
        public void PrintVocabulary()
        {
            Console.WriteLine("English !"); ;
        }
    }

    public class RussianVocabulary : IVocabulary
    {
        public void PrintVocabulary()
        {
            Console.WriteLine("Russian !"); ;
        }
    }

    public class GermanVocabulary : IVocabulary
    {
        public void PrintVocabulary()
        {
            Console.WriteLine("German !"); ;
        }
    }

    public class Vocabulary
    {
        public void CallVocabulary(IVocabulary vocabulary)
        {
            vocabulary.PrintVocabulary();
           
        }
    }
}

#endregion



#region Liskov Substition Principle 

namespace LSP_Before
{
    public class Boss
    {
        public void GiveSalaryToWorkers()
        {
            Console.WriteLine("I Can Give Salary To 1000 Workers in Factory !");
        }
    }

    public class Assistant : Boss
    {
        // tam olaraq komekci boss u evez ede bilmir ! 
        public void GiveMotivation()
        {
            Console.WriteLine("I Only Can Give Motivation To Workers !");
        }
    }

}

// tam olaraq evez ede bilmesede mueyyen islerini gorur ! 
namespace LSP_After
{
    public class Boss
    {
        public virtual void GiveSalaryToWorkers()
        {
            Console.WriteLine("I Can Give Salary To 1000 Workers in Factory !");
        }
    }

    public class Assistant : Boss
    {
        public override void GiveSalaryToWorkers()
        {
            Console.WriteLine("I Can Give Salary To 500 Workers in Factory !");
        }

        public void GiveMotivation()
        {
            Console.WriteLine("I Can Give Motivation To Workers !");
        }
    }
}

#endregion



#region Interface Segregation Principle

namespace ISP_Before
{
    public interface IAnimal
    {
        public void Run();
        public void Fly();
        public void Speak();
        public void Walk();
        public void Swim();
    }

    public class Human : IAnimal
    {
        public void Fly()
        {
            throw new NotImplementedException("Human can not fly !");
        }

        public void Run()
        {
            Console.WriteLine("Human can run !");
        }

        public void Speak()
        {
            Console.WriteLine("Human can speak !");
        }

        public void Swim()
        {
            Console.WriteLine("Human can speak !");
        }

        public void Walk()
        {
            Console.WriteLine("Human can walk !");
        }
    }

    public class Wolf : IAnimal
    {
        public void Fly()
        {
            throw new NotImplementedException("Wolf can not fly !");
        }

        public void Run()
        {
            Console.WriteLine("Wolf can run");
        }

        public void Speak()
        {
            throw new NotImplementedException("Wolf can not speak! ");
        }

        public void Swim()
        {
            Console.WriteLine("Wolf can swim !");
        }

        public void Walk()
        {
            Console.WriteLine("Wolf can walk !");
        }
    }


    public class Bird : IAnimal
    {
        public void Fly()
        {
            throw new NotImplementedException("Bird can fly !");
        }

        public void Run()
        {
            Console.WriteLine("Bird can run !");
        }

        public void Speak()
        {
            throw new NotImplementedException("Bird can not speak! ");
        }

        public void Swim()
        {
            throw new NotImplementedException("Bird can not Swim! ");
        }

        public void Walk()
        {
            Console.WriteLine("Bird can walk !");
        }
    }
}

namespace ISP_After
{
    public interface ICanRun
    {
        public void Run();
    }

    public interface ICanSwim
    {
        public void Swim();
    }

    public interface ICanSpeak
    {
        public void Speak();
    }

    public interface ICanFly
    {
        public void Fly();
    }

    public interface ICanWalk
    {
        public void Walk();
    }

    public class Human : ICanRun, ICanSpeak, ICanSwim
    {
        public void Run()
        {
            Console.WriteLine("Human Can Run !");
        }

        public void Speak()
        {
            Console.WriteLine("Human Can Speak !"); ;
        }

        public void Swim()
        {
            Console.WriteLine("Human Can Swim !");
        }
    }

    public class Wolf : ICanRun, ICanSwim, ICanWalk
    {
        public void Run()
        {
            Console.WriteLine("Wolf Can Run !");
        }

        public void Swim()
        {
            Console.WriteLine("Wolf Can Swim !");
        }

        public void Walk()
        {
            Console.WriteLine("Wolf Can Walk !");
        }
    }

    public class Bird : ICanFly, ICanWalk
    {
        public void Fly()
        {
            Console.WriteLine("Bird Can Fly !");
        }

        public void Walk()
        {
            Console.WriteLine("Bird Can Walk !");
        }
    }
}

#endregion



#region Dependency Principle

#endregion