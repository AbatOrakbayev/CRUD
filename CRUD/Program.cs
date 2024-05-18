namespace CRUD
{
    public class User
    {
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public int Age { get; set; }
        public User(string? Firstname,string? Lastname, int Age)
        {
            this.Firstname = Firstname;
            this.Lastname = Lastname;
            this.Age = Age;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Assalomu Alaykum!");
            List<User> users = new List<User>();
            while (true)
            {
                
                Console.WriteLine("Create - 1");
                Console.WriteLine("Read - 2");
                Console.WriteLine("Update - 3");
                Console.WriteLine("Delete - 4");
                int jarayon = Convert.ToInt32(Console.ReadLine());
                switch (jarayon)
                {
                    case 1:
                        Console.Write("Firstname: ");
                        string? firstname = Console.ReadLine();
                        Console.Write("Lastname: ");
                        string? lastname = Console.ReadLine();
                        Console.Write("Age: ");
                        int age = Convert.ToInt32(Console.ReadLine());
                        User user = new User(firstname, lastname, age);
                        if (!users.Contains(user))
                        {
                            users.Add(user);
                            Console.WriteLine("Muvaffaqiyatli bajarildi.");
                        }
                        else
                        {
                            Console.WriteLine("Bu user avvaldan mavjud!");
                        }
                        break;
                    case 2:
                        if (users.Count != 0)
                        {
                            Console.WriteLine("Firsname\tLastname\tAge");
                            foreach (User item in users)
                            {
                                Console.WriteLine($"{item.Firstname}\t{item.Lastname}\t{item.Age}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ro'yxat bo'sh");
                        }
                        break;
                    case 3:
                        Console.WriteLine($"Id\tFirstname\tLastname\tAge");
                        int i = 1;
                        foreach (var item in users)
                        {
                            Console.WriteLine($"{i}\t{item.Firstname}\t{item.Lastname}\t{item.Age}");
                            i++;
                        }
                        Console.WriteLine("Qaysi foydalanuvchini ma'lumotlarini yangilaymiz tanglang(Id ni kiriting): ");
                        int j = Convert.ToInt32(Console.ReadLine());
                        Console.Write($"FirstName: {users[j-1].Firstname}, yangi firstname kiriting: ");
                        users[j-1].Firstname = Console.ReadLine();
                        Console.Write($"Lastname: {users[j - 1].Lastname}, yangi lastname kiriting: ");
                        users[j-1].Lastname = Console.ReadLine();
                        Console.Write($"Age: {users[j - 1].Age}, yangi age kiriting: ");
                        users[j - 1].Age = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Muvaffaqiyatli bajarildi!");
                        break;
                    case 4:
                        Console.WriteLine($"Id\tFirstname\tLastname\tAge");
                        int k = 1;
                        foreach (var item in users)
                        {
                            Console.WriteLine($"{k}\t{item.Firstname}\t{item.Lastname}\t{item.Age}");
                            k++;
                        }
                        Console.WriteLine("Qaysi foydalanuvchini ma'lumotlarini o'chiramiz tanglang(Id ni kiriting): ");
                        int l = Convert.ToInt32(Console.ReadLine());
                        users.Remove(users[l - 1]);
                        Console.WriteLine("Muvaffaqiyatli bajarildi!");
                        break;
                    default:
                        Console.WriteLine("Kiritishda xatolik. Qayta kiriting.");
                        break;
                }
                yana:
                Console.Write("Davom ettirilsinmi? +/-: ");
                string? buyruq = Console.ReadLine();
                if (buyruq == "-")
                {
                    Console.WriteLine("Yakunlandi...");
                    break;
                }
                else if(buyruq == "+")
                {
                    continue;
                }
                else
                {
                    goto yana;
                }
            }
            Console.WriteLine("Ixtiyoriy tugmani bosing.");
            Console.ReadKey();
        }
    }
}
