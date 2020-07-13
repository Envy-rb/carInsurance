using System;

namespace kursvaya
{
    [Serializable]
    public class person
    {
        private string name;
        private string surname;
        private string middleName;
        private int age;
        private int drivingExperience;

        public person(string name, string surname, string middleName, int age, int drivingExperience)
        {
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.surname = surname ?? throw new ArgumentNullException(nameof(surname));
            this.middleName = middleName ?? throw new ArgumentNullException(nameof(middleName));
            this.age = age;
            this.drivingExperience = drivingExperience;
        }

        public override string ToString()
        {
            return $"{nameof(name)}: {name}, {nameof(surname)}: {surname}, {nameof(middleName)}: {middleName}, {nameof(age)}: {age}, {nameof(drivingExperience)}: {drivingExperience}\n";
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Surname
        {
            get => surname;
            set => surname = value;
        }

        public string MiddleName
        {
            get => middleName;
            set => middleName = value;
        }

        public int Age
        {
            get => age;
            set => age = value;
        }

        public int DrivingExperience
        {
            get => drivingExperience;
            set => drivingExperience = value;
        }
    }
}