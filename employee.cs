public class Employee
{
 public string Name {get;set;}
 public Hash
 {
  get
  {
   return Name.GetHashCode();
  }
 }
}
