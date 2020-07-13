namespace kursvaya.validator
{
    public class personValidator
    {
        public bool stringValidator(string inp)
        {
            return inp.Length > 0;
        }

        public bool ageValidator(int age)
        {
            return age > 18;
        }

        public bool drivingExperienceValidator(int drivingExperience)
        {
            return drivingExperience >= 0;
        }
    }
}