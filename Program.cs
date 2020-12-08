using System;
using static Week4Challenges.Mammal;

namespace Week4Challenges
{
    class Program
    {
        static void Main()
        {
            // create new Pet

            Mammal myPet = new Mammal("Coco", true, 40, "Brown");
            Console.WriteLine(myPet.PetClass);

            // iniative needed local varibales
            string petName;
            string indoorString;
            bool petLivesInside = false;
            char petTypeSelectionChar;
            int petTypeSelection;

            // get user input
            Console.WriteLine("Enter your pet's name:");
            petName = Console.ReadLine();

            Console.WriteLine("Does " + petName + " live indoors?");
            indoorString = Console.ReadLine();
            if (indoorString.ToLower() == "y" | indoorString.ToLower() == "yes")
            {
                petLivesInside = true;
            }
            bool active = true;

            while (active)
            {


                Console.WriteLine("Select what type of pet you have by number:\n" +
                    "1. Mammal,\n" +
                    "2. Bird,\n" +
                    "3. Reptile,\n" +
                    "4. Fish \n" +
                    "5. Amphibian");

                petTypeSelectionChar = Console.ReadKey().KeyChar;

                switch (petTypeSelectionChar.ToString())

                {
                    case "1":
                        {
                            GetMammal(petName, petLivesInside);
                            active = false;
                            break;
                        }
                    case "2":
                        {
                            GetBird(petName, petLivesInside);
                            active = false;
                            break;
                        }
                    case "3":
                        {
                            GetReptile(petName, petLivesInside);
                            active = false;
                            break;
                        }
                    case "4":
                        {
                            GetFish(petName, petLivesInside);
                            active = false;
                            break;
                        }
                    case "5":
                        {
                            GetAmphibian(petName, petLivesInside);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Please choose from the listed options");
                            break;
                        }

                        if (active)
                        {
                            Console.ReadKey();

                        }
                }
                
            }


            void GetMammal(string petName, bool petLivesInside)
            {
                Console.Clear();
                // create new instance
                var newMammal = new Mammal();

                // assign data already captured
                newMammal.PetName = petName;
                newMammal.IndoorPet = petLivesInside;

                // use the assign method to assign classification
                newMammal.AssignType();

                // get class-based data
                Console.WriteLine("Enter the type of pet: \n" +
                    "1. Dog\n" +
                    "2. Cat\n" +
                    "3. Hamster\n" +
                    "4. Goat\n" +
                    "5. Other\n");

                string typeAsString = Console.ReadLine().ToLower();
                int typeAsInt = int.Parse(typeAsString);
                newMammal.MammalType = (MammalTypes) typeAsInt;

                Console.WriteLine("Enter the pet's weight:");
                string weightAsString = Console.ReadLine();
                newMammal.Weight = Int32.Parse(weightAsString);

                Console.WriteLine("Enter the pet's color:");
                string colorAsString = Console.ReadLine();
                newMammal.Color = colorAsString;


                // Output something
                Console.WriteLine($"{ petName} is a {newMammal.MammalType} who weighs {newMammal.Weight}lbs, and is {newMammal.Color}");
            }

            void GetBird(string petName, bool petLivesInside)
            {
                Console.Clear();

                //var newBird = new Bird();

                bool isCarnivoreBool = false;
                Console.WriteLine("Is your pet a carnivore?");
                string isCarnivore = Console.ReadLine();
                if (isCarnivore.ToLower() == "y" | indoorString.ToLower() == "yes")
                {
                    isCarnivoreBool = true;
                }

                // create new instance using the loaded constructor
                Bird newBird = new Bird(petName, petLivesInside, isCarnivoreBool);
                newBird.AssignType();

                // Output something
                Console.WriteLine($"{newBird.PetName} is a {newBird.PetClass}");

            }

            void GetFish(string petName, bool petLivesInside)
            {
                Console.Clear();

                bool isAquadic = false;
                Console.WriteLine("Does your pet live in freshwater?");
                string isAquadicString = Console.ReadLine();
                if (isAquadicString.ToLower() == "y" | indoorString.ToLower() == "yes")
                    isAquadic = true;

                // create new instance using the loaded constructor
                Fish newPet = new Fish(petName, petLivesInside, isAquadic);
                newPet.AssignType();

                // Output something
                Console.WriteLine($"{newPet.PetName} is a {newPet.PetClass}");
            }


            void GetReptile(string petName, bool petLivesInside)
            {
                Console.Clear();

                bool isAquadic = false;
                Console.WriteLine("Does your pet live in water?");
                string isAquadicString = Console.ReadLine();
                if (isAquadicString.ToLower() == "y" | indoorString.ToLower() == "yes")
                    isAquadic = true;

                // create new instance using the loaded constructor
                Reptile newPet = new Reptile(petName, petLivesInside, isAquadic);
                newPet.AssignType();

                // Output something
                Console.WriteLine($"{newPet.PetName} is a {newPet.PetClass}");
            }

            void GetAmphibian(string petName, bool petLivesInside)
            {
                Console.Clear();

                bool doesLayEggs = false;
                Console.WriteLine("Does your fish lay eggs?");
                string doesLayEggsString = Console.ReadLine();
                if (doesLayEggsString.ToLower() == "y" | indoorString.ToLower() == "yes")
                    doesLayEggs = true;

                // create new instance using the loaded constructor
                Amphamphibian newPet = new Amphamphibian(petName, petLivesInside, doesLayEggs);
                newPet.AssignType();

                // Output something
                Console.WriteLine($"{newPet.PetName} is a {newPet.PetClass}");
            }
        }

    }
}
