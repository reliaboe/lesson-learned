using System.Globalization;

namespace Core
{
    public class Person
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime? Birth { get; set; }
        public int? Age => CalculateAge();

        public override string ToString()
        {
            var ci = CultureInfo.CurrentCulture;
            var birthString = Birth?.ToString("dd MM yyyy", ci);
            return $"{Id} {Name} {birthString} {Age}";
        }

        private int? CalculateAge()
        {
            if (!Birth.HasValue)
                return null;

            var now = DateTime.Now;

            var age = now.Year - Birth.Value.Year;

            if (now.Month < Birth.Value.Month || (now.Month == Birth.Value.Month && now.Day < Birth.Value.Day))
                age--;

            return age;
        }
    }
}
