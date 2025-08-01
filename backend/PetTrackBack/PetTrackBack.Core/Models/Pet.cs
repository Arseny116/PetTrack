namespace PetTrackBack.Core.Models
{
    public class Pet
    {
        const int LengthName = 100;
        public Guid Id { get; }
        public string Name { get; } = string.Empty;

        public string Species { get; } = string.Empty;


        public string DateOfBirth { get; } = string.Empty;


        private Pet(Guid id, string name, string species, string dateOfBirth)
        {
            Id = id;
            Name = name;
            Species = species;
            DateOfBirth = dateOfBirth;
        }

        public static (Pet, string) Create(Guid id, string name, string species, string dateOfBirth)
        {
            var error = string.Empty;
            if (string.IsNullOrEmpty(name) || (name.Length >= 100))
            {
                error = "Error is length";
            }

            Pet pet = new Pet(id, name, species, dateOfBirth);


            return (pet, error);
        }


    }
}
