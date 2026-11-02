//by alexx
namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //часть 1
            Box<int> num = new Box<int>();
            num.Put (52);

            Box<string> text = new Box<string>();
            text.Put("У меня нет фантазии");

            //вывод
            Console.WriteLine($"\n число в коробке: {num.Get()}\n текст в коробке: {text.Get()}");;

            //часть 2
            int x = 13, y = 33;
            Utils.Swap(ref x, ref y);

            string a1 = "Казнить", a2 = "Помилывать";
            Utils.Swap(ref a1, ref a2);

            //вывод
            Console.WriteLine($"\n тест работы swap числа: {x} {y}\n тест работы swap текст {a1} {a2}");

            //часть 3
            Pair<int, string> test = new Pair<int, string>();
            test.First = 104;
            test.Second = "Число";

            //вывод
            Console.WriteLine($"\n тест число: {test.First}\n тест текст {test.Second}");



            Console.ReadKey();
        }
    }

    public class Box<T>
    {
        public T? info;
       public void Put(T item)
        {
            info = item;
        }
        public T Get()
        {
            return info;
        }
    }

    class Utils
    {
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }

    public class Pair<T1, T2>
    {
        public T1? First;
        public T2? Second;
    }
}
