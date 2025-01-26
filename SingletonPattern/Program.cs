namespace SingletonPattern
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Task task1 = Task.Run(() =>
            {
                SingletonDesignPattern.Instance.Print(ConsoleColor.Red, 5);
            });
            Task task2 = Task.Run(() => {
                SingletonDesignPattern.Instance.Print(ConsoleColor.Green, 5);
            });
            Task task3 = Task.Run(() =>
            {
                SingletonDesignPattern.Instance.Print(ConsoleColor.Blue, 5);
            });
            await Task.WhenAll(task1, task2, task3);
            Console.ReadKey();
        }
    }
}
