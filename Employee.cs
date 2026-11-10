// Define the employee model used by the console application.
namespace OperatorsAssignment
{
    public class Employee
    {
        // Store the identifier and the employee's first and last names.
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Compare employees by Id, safely handling identical references and null.
        public static bool operator ==(Employee left, Employee right)
        {
            if (object.ReferenceEquals(left, right))
                return true;

            if (object.ReferenceEquals(left, null) || object.ReferenceEquals(right, null))
                return false;

            return left.Id == right.Id;
        }

        // Overload inequality as the exact opposite of equality.
        public static bool operator !=(Employee left, Employee right)
        {
            return !(left == right);
        }

        // Keep standard object equality consistent with the overloaded operators.
        public override bool Equals(object obj)
        {
            return this == (obj as Employee);
        }

        // Equal employees must produce equal hash codes, so use the same Id.
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
