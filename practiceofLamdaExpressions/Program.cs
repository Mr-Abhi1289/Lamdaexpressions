namespace practiceofLamdaExpressions
{
    public class Program
    {
           public static void AddRecords(List<person> listperson)
        {
            listperson.Add(new person("1289", "Abhilash", 22, "bangalore"));
            listperson.Add(new person("1234", "lokesh", 25, "chennai"));
            listperson.Add(new person("4556", "anil", 30, "mumbai"));
            listperson.Add(new person("5667", "mahesh", 60, "delhi"));
            listperson.Add(new person("4778", "amruth", 60, "calicutt"));

        }       
       public  static void Main(string[] args)
        {
            List<person> listperson = new List<person>();
           Addrecords(listperson);
           
        }
    }
    
}
