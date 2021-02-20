namespace EAD_Practicals
{
    public class Person
    {
        private static int classVal;
        private int instValAge;

        public Person()
        {
            ++classVal;
        }

        public static int People()
        {
            return classVal;
        }

        public void SetAge(int age)
        {
            instValAge = age;
        }

        public int GetAge()
        {
            return instValAge;
        }
    }
}
