namespace PersonalDetails
{
public class Program
    {
        public static void Main(string[] args)
        {
            // TODO 1: declare one variable per detail.
            //         Text uses string, a whole number uses int.
            //         The first one is done for you.
            string name = "Kobit Gurung";

            // TODO 2: declare a variable for the address, contact number,
            //         email, college, course, and year of study.
            string address = "KajiPokhari";
            long contactNumber = 9826629985;
            string email = "kobitgrg22@gmail.com";
            string college = "Informatics";
            string course = "BIT";
            int yearOfStudy = 3;

            // TODO 3: print a heading line, then one labelled line per detail.
            //         The first two are done for you as a model.
            Console.WriteLine("========== Personal Details ==========");
            Console.WriteLine($"Name          : {name}");
          

            // TODO 4: print a line for every remaining detail.
              Console.WriteLine($"Address       : {address}");
            Console.WriteLine($"Contact Number: {contactNumber}");
            Console.WriteLine($"Email         : {email}");
            Console.WriteLine($"College       : {college}");
            Console.WriteLine($"Course        : {course}");
            Console.WriteLine($"Year of Study : {yearOfStudy}");
        }
    }
}
